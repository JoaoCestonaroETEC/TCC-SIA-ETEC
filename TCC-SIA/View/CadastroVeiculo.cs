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
    public partial class CadastroVeiculo : Form
    {
        #region Inicializa o formulário
        public CadastroVeiculo()
        {
            #region Campos de cores
            //Adiciona campos de cores de veículos mais comuns
            InitializeComponent();
            comboBoxCor.Items.Add("Branco");
            comboBoxCor.Items.Add("Preto");
            comboBoxCor.Items.Add("Prata");
            comboBoxCor.Items.Add("Cinza");
            comboBoxCor.Items.Add("Azul");
            comboBoxCor.Items.Add("Vermelho");
            comboBoxCor.Items.Add("Amarelo");
            comboBoxCor.Items.Add("Verde");
            comboBoxCor.Items.Add("Roxo");
            #endregion

            #region Campos dos tipos de veículos
            //Adiciona campos de tipos de veículos mais comuns
            comboBoxTipo.Items.Add("Carro");
            comboBoxTipo.Items.Add("Moto");
            comboBoxTipo.Items.Add("Bicileta");
            comboBoxTipo.Items.Add("Moto-cicleta");
            comboBoxTipo.Items.Add("Caminhão");
            #endregion

            #region Carrega os dados nas comboBoxs
            listarMarca();
            listarCliente();
            #endregion
        }
        #endregion

        #region Cadastrar veículo
        //Evento de cadastrar veículo
        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            // Verifica se os campos obrigatórios foram preenchidos
            if (string.IsNullOrWhiteSpace(comboBoxCpf.Text) ||
                string.IsNullOrWhiteSpace(textBoxNome.Text) ||
                string.IsNullOrWhiteSpace(comboBoxTipo.Text) ||
                string.IsNullOrWhiteSpace(maskedTextBoxPlaca.Text))

            {
                MessageBox.Show("Insira o cpf, o nome, o tipo e a placa!");
                return;
            }
            // Criação do objeto Veiculo e controleVeiculo
            Veiculo mVeiculo = new Veiculo();
            controleVeiculo cVeiculo = new controleVeiculo();

            //Definindo os valores nos atributos
            mVeiculo.setCpfCliente(Convert.ToInt64(comboBoxCpf.SelectedValue));
            mVeiculo.setIdMarca(Convert.ToInt64(comboBoxMarca.SelectedValue));
            mVeiculo.setNomeVeiculo(textBoxNome.Text);
            mVeiculo.setTipoVeiculo(comboBoxTipo.Text);
            mVeiculo.setCorVeiculo(comboBoxTipo.Text);
            mVeiculo.setPlacaVeiculo(maskedTextBoxPlaca.Text);
            mVeiculo.setModeloVeiculo(textBoxModelo.Text);

            //Chamada ao método de cadastro no ControleServico
            string res = cVeiculo.cadastroVeiculo(mVeiculo);

            //Mostra o resultado
            MessageBox.Show(res);
        }
        #endregion

        #region Listar cliente
        public void listarCliente()
        {
            controleCliente cCliente = new controleCliente();
            //Recebe os dados da consulta e salva no dataReader (Tipo)
            NpgsqlDataReader cliente = cCliente.listarCliente();

            //Converter o dataReader em DataTable
            DataTable dtCliente = new DataTable();
            dtCliente.Load(cliente);

            //Preencher a combobox com os dados do DataTable
            comboBoxCpf.DataSource = dtCliente;

            //Define qual coluna do DataTable que será exibida (nome da coluna)
            comboBoxCpf.DisplayMember = "NOMECLIENTE";

            //Define qual o valor da linha será utilizado ao selecionar um valor
            comboBoxCpf.ValueMember = "CPFCLIENTE";
        }
        #endregion

        #region Listar marca
        public void listarMarca()
        {
            controleMarca cMarca = new controleMarca();
            //Recebe os dados da consulta e salva no dataReader (Tipo)
            NpgsqlDataReader marca = cMarca.listarMarcaVeiculo();

            //Converter o dataReader em DataTable
            DataTable dtMarca = new DataTable();
            dtMarca.Load(marca);

            //Preencher a combobox com os dados do DataTable
            comboBoxMarca.DataSource = dtMarca;

            //Define qual coluna do DataTable que será exibida (nome da coluna)
            comboBoxMarca.DisplayMember = "NOMEMARCAVEICULO";

            //Define qual o valor da linha será utilizado ao selecionar um valor
            comboBoxMarca.ValueMember = "IDMARCAVEICULO";
        }
        #endregion

        #region Carrega o formulário
        private void CadastroVeiculo_Load(object sender, EventArgs e)
        {
            listarMarca();
        }
        #endregion
    }
}
