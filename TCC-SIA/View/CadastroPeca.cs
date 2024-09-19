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

            #region Carrega os dados nas comboBoxs
            listarMarca();
            #endregion
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
            decimal valor;
            if (decimal.TryParse(maskedTextBoxValor.Text, out valor))
            {
                mPeca.setValorPeca(valor);
            }

            mPeca.setQuantPeca(Convert.ToInt32(numericUpDownQuant.Text));
            mPeca.setGarantiaPeca(Convert.ToDateTime(dateTimePickerGarantia.Text));
            mPeca.setUnidade(Convert.ToInt32(numericUpDownUnid.Text));
            mPeca.setFornecedor(comboBoxFornecedor.Text);
            mPeca.setDataAquisao(Convert.ToDateTime(dateTimePickerAquis.Text));

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
            NpgsqlDataReader marca = cMarca.listarMarca();

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
        #region Listar Tipo
        public void listarTipo()
        {
            controlePeca cPeca = new controlePeca();
            // Recebe os dados da consulta e salva no dataReader (Tipo)
            NpgsqlDataReader peca = cPeca.listaTipo();

            // Criar e configurar o DataTable
            DataTable dtTipo = new DataTable();

            // Definir as colunas do DataTable
            dtTipo.Columns.Add("ID", typeof(int));  // Supondo que o ID seja um int
            dtTipo.Columns.Add("TIPOPECA", typeof(string)); // Supondo que o tipo seja uma string

            // Adicionar itens pré-configurados
            dtTipo.Rows.Add(-1, "Motor");
            dtTipo.Rows.Add(-2, "Suspensão e Direção");
            dtTipo.Rows.Add(-3, "Freio");
            dtTipo.Rows.Add(-4, "Transmissão");
            dtTipo.Rows.Add(-5, "Elétrica");
            dtTipo.Rows.Add(-6, "Arrefecimento");
            dtTipo.Rows.Add(-7, "Escape");
            dtTipo.Rows.Add(-8, "Estética e Acabamento");
            dtTipo.Rows.Add(-9, "Combustível");
            dtTipo.Rows.Add(-10, "Pneumáticos");
            dtTipo.Rows.Add(-11, "Outro");

            // Carregar os dados do NpgsqlDataReader
            dtTipo.Load(peca);

            // Preencher a ComboBox com os dados do DataTable
            comboBoxTIpo.DataSource = dtTipo;

            // Define qual coluna do DataTable que será exibida (nome da coluna)
            comboBoxTIpo.DisplayMember = "TIPOPECA";
        }
        #endregion

        #region Listar Fornecedor
        public void listarFornecedor()
        {
            controlePeca cPeca = new controlePeca();
            //Recebe os dados da consulta e salva no dataReader (Tipo)
            NpgsqlDataReader peca = cPeca.listaFornecedor();

            //Converter o dataReader em DataTable
            DataTable dtFornecedor = new DataTable();
            dtFornecedor.Load(peca);

            //Preencher a combobox com os dados do DataTable
            comboBoxFornecedor.DataSource = dtFornecedor;

            //Define qual coluna do DataTable que será exibida (nome da coluna)
            comboBoxFornecedor.DisplayMember = "FORNECEDOR";

            //Define qual o valor da linha será utilizado ao selecionar um valor
            comboBoxFornecedor.ValueMember = "FORNECEDOR";
        }
        #endregion

        #region Método de aceitar apenas números
        private void maskedTextBoxDinheiro_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(maskedTextBoxValor.Text))
            {
                // Remove qualquer ponto ou vírgula adicional, se houver
                string textoLimpo = maskedTextBoxValor.Text.Replace(",", "").Replace(".", "").Trim();

                // Verifica se o valor pode ser convertido em um número
                if (decimal.TryParse(textoLimpo, out decimal valor))
                {
                    // Divide por 100 para ajustar o valor para centavos e formata com duas casas decimais
                    maskedTextBoxValor.Text = (valor / 100).ToString("N2");
                }
                else
                {
                    // Se a entrada for inválida, pode limpar o campo ou tomar outra ação
                    maskedTextBoxValor.Text = "0,00"; // Opcional: Define como 0 se o valor for inválido
                }
            }
        }
        #endregion

        #region Carrega o formulário
        private void CadastroPeça_Load(object sender, EventArgs e)
        {
            //Definir eventos para validar a entrada
            maskedTextBoxValor.Leave += maskedTextBoxDinheiro_Leave;
            listarMarca();
            listarTipo();
            listarFornecedor();
        }

        #endregion

        private void maskedTextBoxValor_Leave(object sender, EventArgs e)
        {

        }

        private void maskedTextBoxValor_TextChanged(object sender, EventArgs e)
        {
            MaskedTextBox maskedTextBox = sender as MaskedTextBox;

            // Remove qualquer formatação anterior e deixa apenas os números
            string textoAtual = maskedTextBox.Text.Replace(",", "").Replace(".", "").TrimStart('0');

            if (textoAtual.Length == 0)
            {
                textoAtual = "0";
            }

            // Converte o texto para decimal
            if (decimal.TryParse(textoAtual, out decimal valorDecimal))
            {
                maskedTextBox.TextChanged -= maskedTextBoxValor_TextChanged; // Remove o evento para evitar loop

                // Formata o valor com ponto como separador de centavos e sem separadores de milhar
                maskedTextBox.Text = string.Format("{0:0.00}", valorDecimal / 100);

                // Coloca o cursor no final
                maskedTextBox.SelectionStart = maskedTextBox.Text.Length;

                maskedTextBox.TextChanged += maskedTextBoxValor_TextChanged; // Reinscreve o evento
            }
        }

    }
}
