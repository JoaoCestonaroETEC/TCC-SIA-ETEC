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
        }
        #endregion

        #region Cadastrar veículo
        //Evento de cadastrar veículo
        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            // Verifica se os campos obrigatórios foram preenchidos
            if (string.IsNullOrWhiteSpace(maskedTextBoxCpf.Text) ||
                string.IsNullOrWhiteSpace(textBoxNome.Text) ||
                string.IsNullOrWhiteSpace(comboBoxTipo.Text) ||
                string.IsNullOrWhiteSpace(maskedTextBoxPlaca.Text))

            {
                MessageBox.Show("Insira o cpf, o nome, o tipo e a placa!");
                return;
            }
            // Criação do objeto Veiculo e ControleVeiculo
            Veiculo mVeiculo = new Veiculo();
            controleVeiculo cVeiculo = new controleVeiculo();

            //Definindo os valores nos atributos
            mVeiculo.setCpfCliente(Convert.ToInt64(maskedTextBoxCpf.Text));
            mVeiculo.setIdMarca(Convert.ToInt64(comboBoxMarca.Text));
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
    }
}
