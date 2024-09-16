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
            InitializeComponent();

            #region Carrega os dados nas comboBoxs
            listarMarca();
            listarCliente();
            listarTipo();
            listarCor();
            #endregion
        }
        #endregion

        #region Cadastrar veículo
        //Evento de cadastrar veículo
        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            // Verifica se os campos obrigatórios foram preenchidos
            if (string.IsNullOrWhiteSpace(comboBoxIdCliente.Text) ||
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
            mVeiculo.setIdCliente(Convert.ToInt64(comboBoxIdCliente.SelectedValue));
            mVeiculo.setIdMarca(Convert.ToInt64(comboBoxMarca.SelectedValue));
            mVeiculo.setNomeVeiculo(textBoxNome.Text);
            mVeiculo.setTipoVeiculo(comboBoxTipo.Text);
            mVeiculo.setCorVeiculo(comboBoxTipo.Text);
            mVeiculo.setPlacaVeiculo(maskedTextBoxPlaca.Text);
            mVeiculo.setModeloVeiculo(textBoxModelo.Text);
            mVeiculo.setChassi(maskedTextBoxChassi.Text);
            mVeiculo.setAnoFabricacao(Convert.ToDateTime(dateTimePickerFab.Text));
            mVeiculo.setQuilometragem(Convert.ToInt32(maskedTextBoxQuilo.Text));
            mVeiculo.setMotor(maskedTextBoxMotor.Text);
            mVeiculo.setCombustivel(comboBoxCombustivel.Text);
            mVeiculo.setData(Convert.ToDateTime(dateTimePickerData.Text));
            mVeiculo.setSeguro(comboBoxSeguro.Text);

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
            comboBoxIdCliente.DataSource = dtCliente;

            //Define qual coluna do DataTable que será exibida (nome da coluna)
            comboBoxIdCliente.DisplayMember = "NOMECLIENTE";

            //Define qual o valor da linha será utilizado ao selecionar um valor
            comboBoxIdCliente.ValueMember = "IDCLIENTE";
        }
        #endregion

        #region Listar tipo
        public void listarTipo()
        {
            controleVeiculo cVeiculo = new controleVeiculo();
            // Recebe os dados da consulta e salva no dataReader (Tipo)
            NpgsqlDataReader veiculo = cVeiculo.listaTipo();

            // Criar e configurar o DataTable
            DataTable dtTipo = new DataTable();

            // Definir as colunas do DataTable
            dtTipo.Columns.Add("ID", typeof(int));  // Supondo que o ID seja um int
            dtTipo.Columns.Add("TIPOVEICULO", typeof(string)); // Supondo que o tipo seja uma string

            // Adicionar itens pré-configurados
            dtTipo.Rows.Add(-1, "Sedan");
            dtTipo.Rows.Add(-2, "Hatchback");
            dtTipo.Rows.Add(-3, "SUV (Sport Utility Vehicle)");
            dtTipo.Rows.Add(-4, "Crossover");
            dtTipo.Rows.Add(-5, "Conversível");
            dtTipo.Rows.Add(-6, "Coupe");
            dtTipo.Rows.Add(-7, "Escape");
            dtTipo.Rows.Add(-8, "Caminhão");
            dtTipo.Rows.Add(-9, "Van");
            dtTipo.Rows.Add(-10, "Furgão");
            dtTipo.Rows.Add(-11, "Motocicleta");
            dtTipo.Rows.Add(-12, "Scooter");
            dtTipo.Rows.Add(-13, "Micro-ônibus");
            dtTipo.Rows.Add(-14, "ATV (All-Terrain Vehicle)");
            dtTipo.Rows.Add(-15, "Quadriciclo");
            dtTipo.Rows.Add(-16, "Carro Elétrico");
            dtTipo.Rows.Add(-17, "Carro Híbrido");
            dtTipo.Rows.Add(-18, "Caminhão Tanque");
            dtTipo.Rows.Add(-19, "Reboque");
            dtTipo.Rows.Add(-20, "Outro");

            // Carregar os dados do NpgsqlDataReader
            dtTipo.Load(veiculo);

            // Preencher a ComboBox com os dados do DataTable
            comboBoxTipo.DataSource = dtTipo;

            // Define qual coluna do DataTable que será exibida (nome da coluna)
            comboBoxTipo.DisplayMember = "TIPOVEICULO";
        }
        #endregion
        #region Listar cor
        public void listarCor()
        {
            controleVeiculo cVeiculo = new controleVeiculo();
            // Recebe os dados da consulta e salva no dataReader (Tipo)
            NpgsqlDataReader veiculo = cVeiculo.listaCor();

            // Criar e configurar o DataTable
            DataTable dtTipo = new DataTable();

            // Definir as colunas do DataTable
            dtTipo.Columns.Add("ID", typeof(int));  // Supondo que o ID seja um int
            dtTipo.Columns.Add("CORVEICULO", typeof(string)); // Supondo que o tipo seja uma string

            // Adicionar itens pré-configurados
            dtTipo.Rows.Add(-1, "Branco");
            dtTipo.Rows.Add(-2, "Preto");
            dtTipo.Rows.Add(-3, "Prata");
            dtTipo.Rows.Add(-4, "Cinza");
            dtTipo.Rows.Add(-5, "Azul");
            dtTipo.Rows.Add(-6, "Vermelho");
            dtTipo.Rows.Add(-7, "Amarelo");
            dtTipo.Rows.Add(-8, "Verde");
            dtTipo.Rows.Add(-9, "Roxo");

            // Carregar os dados do NpgsqlDataReader
            dtTipo.Load(veiculo);

            // Preencher a ComboBox com os dados do DataTable
            comboBoxCor.DataSource = dtTipo;

            // Define qual coluna do DataTable que será exibida (nome da coluna)
            comboBoxCor.DisplayMember = "CORVEICULO";
        }
        #endregion

        #region Listar combustível
        public void listarCombustivel()
        {
            controleVeiculo cVeiculo = new controleVeiculo();
            // Recebe os dados da consulta e salva no dataReader (Tipo)
            NpgsqlDataReader veiculo = cVeiculo.listaCombustivel();

            // Criar e configurar o DataTable
            DataTable dtTipo = new DataTable();

            // Definir as colunas do DataTable
            dtTipo.Columns.Add("ID", typeof(int));  // Supondo que o ID seja um int
            dtTipo.Columns.Add("COMBUSTIVEL", typeof(string)); // Supondo que o tipo seja uma string

            // Adicionar itens pré-configurados
            dtTipo.Rows.Add(-1, "Gasolina");
            dtTipo.Rows.Add(-2, "Diesel");
            dtTipo.Rows.Add(-3, "Álcool Etílico (Ethanol)");
            dtTipo.Rows.Add(-4, "Gás Natural");
            dtTipo.Rows.Add(-5, "Gás Liquefeito de Petróleo (GLP)");
            dtTipo.Rows.Add(-6, "Óleo Diesel Biodiesel");
            dtTipo.Rows.Add(-7, "Óleo de Cocina");
            dtTipo.Rows.Add(-8, "Biogás");

            // Carregar os dados do NpgsqlDataReader
            dtTipo.Load(veiculo);

            // Preencher a ComboBox com os dados do DataTable
            comboBoxCombustivel.DataSource = dtTipo;

            // Define qual coluna do DataTable que será exibida (nome da coluna)
            comboBoxCombustivel.DisplayMember = "COMBUSTIVEL";
        }
        #endregion

        #region Listar marca
        public void listarMarca()
        {
            controleMarca cMarca = new controleMarca();
            //Recebe os dados da consulta e salva no dataReader (Tipo)
            NpgsqlDataReader marca = cMarca.listarMarcaVeiculos();

            //Converter o dataReader em DataTable
            DataTable dtMarca = new DataTable();
            dtMarca.Load(marca);

            //Preencher a combobox com os dados do DataTable
            comboBoxMarca.DataSource = dtMarca;

            //Define qual coluna do DataTable que será exibida (nome da coluna)
            comboBoxMarca.DisplayMember = "NOMEMARCA";

            //Define qual o valor da linha será utilizado ao selecionar um valor
            comboBoxMarca.ValueMember = "IDMARCA";
        }
        #endregion

        #region Listar seguro
        public void listarSeguro()
        {
            controleVeiculo cVeiculo = new controleVeiculo();
            //Recebe os dados da consulta e salva no dataReader (Tipo)
            NpgsqlDataReader veiculo = cVeiculo.listaVeiculo();

            //Converter o dataReader em DataTable
            DataTable dtVeiculo = new DataTable();
            dtVeiculo.Load(veiculo);

            //Preencher a combobox com os dados do DataTable
            comboBoxSeguro.DataSource = dtVeiculo;

            //Define qual coluna do DataTable que será exibida (nome da coluna)
            comboBoxSeguro.DisplayMember = "SEGURO";

            //Define qual o valor da linha será utilizado ao selecionar um valor
            comboBoxSeguro.ValueMember = "SEGURO";
        }
        #endregion

        #region Carrega o formulário
        private void CadastroVeiculo_Load(object sender, EventArgs e)
        {
            listarMarca();
            listarCliente();
            listarTipo();
            listarCor();
            listarCombustivel();
            listarSeguro();
        }
        #endregion
    }
}
