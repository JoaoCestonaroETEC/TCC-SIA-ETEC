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
            mVeiculo.setCorVeiculo(comboBoxCor.Text);
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

            // Carregar os dados do NpgsqlDataReader
            dtTipo.Load(veiculo);

            // Preencher a ComboBox com os dados do DataTable
            comboBoxTipo.DataSource = dtTipo;

            // Define qual coluna do DataTable que será exibida (nome da coluna)
            comboBoxTipo.DisplayMember = "TIPOVEICULO";

            // Define qual coluna do DataTable que será exibida (nome da coluna)
            comboBoxTipo.ValueMember = "TIPOVEICULO";
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

            comboBoxCor.ValueMember = "CORVEICULO";

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

            //Define qual o valor da linha será utilizado ao selecionar um valor
            comboBoxCombustivel.ValueMember = "COMBUSTIVEL";
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
            NpgsqlDataReader veiculo = cVeiculo.listaSeguro();

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

        private void comboBoxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            listarTipo();
        }

        private void comboBoxCor_SelectedIndexChanged(object sender, EventArgs e)
        {
            listarCor();
        }

        private void comboBoxCombustivel_SelectedIndexChanged(object sender, EventArgs e)
        {
            listarCombustivel();
        }

        private void comboBoxSeguro_SelectedIndexChanged(object sender, EventArgs e)
        {
            listarSeguro();
        }

        private void comboBoxTipo_Validating(object sender, CancelEventArgs e)
        {
            System.Windows.Forms.ComboBox comboBox = sender as System.Windows.Forms.ComboBox;
            string fornecedorDigitado = comboBox.Text;

            // Verifica se o valor digitado já existe na lista de itens da ComboBox
            bool fornecedorExiste = comboBox.Items.Cast<System.Data.DataRowView>()
                                       .Any(item => item["TIPOVEICULO"].ToString()
                                       .Equals(fornecedorDigitado, StringComparison.OrdinalIgnoreCase));

            if (!fornecedorExiste && !string.IsNullOrEmpty(fornecedorDigitado))
            {
                // Exibe a mensagem com o aviso
                DialogResult result = MessageBox.Show("Aviso! Tipo não registrado, deseja adicionar um novo?",
                                                      "Aviso!",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Ação para adicionar um novo fornecedor (sem adicionar o valor na ComboBox diretamente)
                    MessageBox.Show("Mantenha o valor digitado para cadastrar um novo tipo de peça",
                                    "Ação Necessária",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                else
                {
                    // Limpa o texto da ComboBox
                    comboBox.Text = string.Empty;
                }
            }
        }

        private void comboBoxCor_Validating(object sender, CancelEventArgs e)
        {
            System.Windows.Forms.ComboBox comboBox = sender as System.Windows.Forms.ComboBox;
            string fornecedorDigitado = comboBox.Text;

            // Verifica se o valor digitado já existe na lista de itens da ComboBox
            bool fornecedorExiste = comboBox.Items.Cast<System.Data.DataRowView>()
                                       .Any(item => item["CORVEICULO"].ToString()
                                       .Equals(fornecedorDigitado, StringComparison.OrdinalIgnoreCase));

            if (!fornecedorExiste && !string.IsNullOrEmpty(fornecedorDigitado))
            {
                // Exibe a mensagem com o aviso
                DialogResult result = MessageBox.Show("Aviso! Cor não registrada, deseja adicionar um nova?",
                                                      "Aviso!",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Ação para adicionar um novo fornecedor (sem adicionar o valor na ComboBox diretamente)
                    MessageBox.Show("Mantenha o valor digitado para cadastrar um novo tipo de cor",
                                    "Ação Necessária",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                else
                {
                    // Limpa o texto da ComboBox
                    comboBox.Text = string.Empty;
                }
            }
        }

        private void comboBoxCombustivel_Validating(object sender, CancelEventArgs e)
        {
            System.Windows.Forms.ComboBox comboBox = sender as System.Windows.Forms.ComboBox;
            string fornecedorDigitado = comboBox.Text;

            // Verifica se o valor digitado já existe na lista de itens da ComboBox
            bool fornecedorExiste = comboBox.Items.Cast<System.Data.DataRowView>()
                                       .Any(item => item["COMBUSTIVEL"].ToString()
                                       .Equals(fornecedorDigitado, StringComparison.OrdinalIgnoreCase));

            if (!fornecedorExiste && !string.IsNullOrEmpty(fornecedorDigitado))
            {
                // Exibe a mensagem com o aviso
                DialogResult result = MessageBox.Show("Aviso! Combustível não registrado, deseja adicionar um novo?",
                                                      "Aviso!",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Ação para adicionar um novo fornecedor (sem adicionar o valor na ComboBox diretamente)
                    MessageBox.Show("Mantenha o valor digitado para cadastrar um novo tipo de combustível",
                                    "Ação Necessária",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                else
                {
                    // Limpa o texto da ComboBox
                    comboBox.Text = string.Empty;
                }
            }
        }

        private void comboBoxSeguro_Validating(object sender, CancelEventArgs e)
        {
            System.Windows.Forms.ComboBox comboBox = sender as System.Windows.Forms.ComboBox;
            string fornecedorDigitado = comboBox.Text;

            // Verifica se o valor digitado já existe na lista de itens da ComboBox
            bool fornecedorExiste = comboBox.Items.Cast<System.Data.DataRowView>()
                                       .Any(item => item["SEGURO"].ToString()
                                       .Equals(fornecedorDigitado, StringComparison.OrdinalIgnoreCase));

            if (!fornecedorExiste && !string.IsNullOrEmpty(fornecedorDigitado))
            {
                // Exibe a mensagem com o aviso
                DialogResult result = MessageBox.Show("Aviso! Seguro não registrado, deseja adicionar um novo?",
                                                      "Aviso!",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Ação para adicionar um novo fornecedor (sem adicionar o valor na ComboBox diretamente)
                    MessageBox.Show("Mantenha o valor digitado para cadastrar um novo seguro",
                                    "Ação Necessária",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                else
                {
                    // Limpa o texto da ComboBox
                    comboBox.Text = string.Empty;
                }
            }
        }

        private void comboBoxIdCliente_Validating(object sender, CancelEventArgs e)
        {
            System.Windows.Forms.ComboBox comboBox = sender as System.Windows.Forms.ComboBox;
            string fornecedorDigitado = comboBox.Text;

            // Verifica se o valor digitado já existe na lista de itens da ComboBox
            bool fornecedorExiste = comboBox.Items.Cast<System.Data.DataRowView>()
                                       .Any(item => item["NOMECLIENTE"].ToString()
                                       .Equals(fornecedorDigitado, StringComparison.OrdinalIgnoreCase));

            if (!fornecedorExiste && !string.IsNullOrEmpty(fornecedorDigitado))
            {
                // Exibe a mensagem com o aviso
                DialogResult result = MessageBox.Show("Aviso! Cliente não registrado! Deseja Registrar um novo?",
                                                      "Aviso!",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Ação para adicionar um novo fornecedor (sem adicionar o valor na ComboBox diretamente)
                    CadastroCliente formCliente = new CadastroCliente();
                    formCliente.Show();
                }
                else
                {
                    // Limpa o texto da ComboBox
                    comboBox.Text = string.Empty;
                }
            }
        }

        private void comboBoxMarca_Validating(object sender, CancelEventArgs e)
        {
            System.Windows.Forms.ComboBox comboBox = sender as System.Windows.Forms.ComboBox;
            string fornecedorDigitado = comboBox.Text;

            // Verifica se o valor digitado já existe na lista de itens da ComboBox
            bool fornecedorExiste = comboBox.Items.Cast<System.Data.DataRowView>()
                                       .Any(item => item["NOMEMARCA"].ToString()
                                       .Equals(fornecedorDigitado, StringComparison.OrdinalIgnoreCase));

            if (!fornecedorExiste && !string.IsNullOrEmpty(fornecedorDigitado))
            {
                // Exibe a mensagem com o aviso
                DialogResult result = MessageBox.Show("Aviso! Marca não registrada! Deseja registrar uma nova?",
                                                      "Aviso!",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Ação para adicionar um novo fornecedor (sem adicionar o valor na ComboBox diretamente)
                    CadastroMarca cadastroMarca = new CadastroMarca();
                    cadastroMarca.Show();
                }
                else
                {
                    // Limpa o texto da ComboBox
                    comboBox.Text = string.Empty;
                }
            }
        }

        private void maskedTextBoxQuilo_TextChanged(object sender, EventArgs e)
        {
            if (maskedTextBoxQuilo == null || string.IsNullOrEmpty(maskedTextBoxQuilo.Text))
            {
                maskedTextBoxQuilo.Text = "1";
            }
            // Armazena o texto atual do TextBox
            string textoAtual = maskedTextBoxQuilo.Text;

            // Remove caracteres especiais e letras
            string textoFiltrado = new string(textoAtual.Where(char.IsDigit).ToArray());

            // Atualiza o TextBox com o texto filtrado
            if (textoAtual != textoFiltrado)
            {
                maskedTextBoxQuilo.Text = textoFiltrado;
                maskedTextBoxQuilo.SelectionStart = textoFiltrado.Length; // Mantém o cursor no final
            }
        }

        private void comboBoxMarca_DropDown(object sender, EventArgs e)
        {
            listarMarca();
        }

        private void comboBoxTipo_DropDown(object sender, EventArgs e)
        {
            listarTipo();
        }

        private void comboBoxCor_DropDown(object sender, EventArgs e)
        {
            listarCor();
        }

        private void comboBoxCombustivel_DropDown(object sender, EventArgs e)
        {
            listarCombustivel();
        }

        private void comboBoxSeguro_DropDown(object sender, EventArgs e)
        {
            listarSeguro();
        }
    }
}
