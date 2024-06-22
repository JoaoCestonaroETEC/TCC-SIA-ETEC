using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCC_SIA.Controller;
using TCC_SIA.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TCC_SIA.View
{
    public partial class CadastroPeca : Form
    {
        #region Inicializa o formulário
        public CadastroPeca()
        {
            InitializeComponent();
        }
        #endregion

        #region Cadastrar peça
        //Evento de cadastrar peça
        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            // Verifica se os campos obrigatórios foram preenchidos
            if (string.IsNullOrWhiteSpace(textBoxNome.Text) ||
                string.IsNullOrWhiteSpace(maskedTextBoxValor.Text))

            {
                MessageBox.Show("Insira pelo menos o nome e o valor!");
                return;
            }

            // Criação do objeto Peca e controlePeca
            Peca mPeca = new Peca();
            controlePeca cPeca = new controlePeca();

            //Definindo os valores nos atributos
            mPeca.setIdMarca(Convert.ToInt64(comboBoxMarca.SelectedValue));
            mPeca.setNomePeca(textBoxNome.Text);
            mPeca.setTipoPeca(comboBoxTIpo.Text);
            mPeca.setDescPeca(richTextBoxDesc.Text);

            //Faz uma verificação para tentar enviar o valor para o atributo, se existiver vazia ele envia vazia sem dar erro
            long valor;
            if (long.TryParse(maskedTextBoxValor.Text, out valor))
            {
                mPeca.setValorPeca(valor);
            }

            mPeca.setQuantPeca(Convert.ToInt32(numericUpDownQuant.Text));
            mPeca.setGarantiaPeca(Convert.ToDateTime(dateTimePickerGarantia.Text));

            //Chamada ao método de cadastro no ControlePeca
            string res = cPeca.cadastroPeca(mPeca);

            //Mostra o resultado
            MessageBox.Show(res);
        }
        #endregion

        #region Listar marca
        public void listarMarca()
        {
            controleMarca cMarca = new controleMarca();
            //Recebe os dados da consulta e salva no dataReader (Tipo)
            NpgsqlDataReader marca = cMarca.listarMarcaPeca();

            //Converter o dataReader em DataTable
            DataTable dtMarca = new DataTable();
            dtMarca.Load(marca);

            //Preencher a combobox com os dados do DataTable
            comboBoxMarca.DataSource = dtMarca;

            //Define qual coluna do DataTable que será exibida (nome da coluna)
            comboBoxMarca.DisplayMember = "NOMEMARCAPECA";

            //Define qual o valor da linha será utilizado ao selecionar um valor
            comboBoxMarca.ValueMember = "IDMARCAPECA";
        }
        #endregion

        #region Método de aceitar apenas números
        private void maskedTextBoxValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Verifica se a tecla pressionada é um dígito ou uma tecla de controle (como Backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; //Impede a entrada de caracteres não numéricos
            }
        }
        #endregion

        #region Carrega o formulário
        private void CadastroPeça_Load(object sender, EventArgs e)
        {
            //Definir eventos para validar a entrada
            maskedTextBoxValor.KeyPress += new KeyPressEventHandler(maskedTextBoxValor_KeyPress);
            listarMarca();
        }
        #endregion
    }
}
