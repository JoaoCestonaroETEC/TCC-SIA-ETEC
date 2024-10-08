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

namespace TCC_SIA.View
{
    public partial class CadastroServico : Form
    {
        #region Inicializa o formulário
        public CadastroServico()
        {
            InitializeComponent();
            listarFuncionario();
        }
        #endregion

        #region Cadastrar serviço
        //Evento de cadastrar serviço
        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            // Verifica se os campos obrigatórios foram preenchidos
            if (string.IsNullOrWhiteSpace(textBoxNome.Text) ||
                string.IsNullOrWhiteSpace(maskedTextBoxValor.Text))

            {
                MessageBox.Show("Insira pelo menos o nome e o valor!");
                return;
            }

            // Criação do objeto Servico e controleServico
            Servico mServico = new Servico();
            controleServico cServico = new controleServico();

            //Definindo os valores nos atributos
            mServico.setNomeServico(textBoxNome.Text);
            mServico.setGarantiaServico(Convert.ToDateTime(dateTimePickerGarantia.Text)); ;


            //Faz uma verificação para tentar enviar o valor para o atributo, se existiver vazia ele envia vazia sem dar erro
            decimal valor;
            if (decimal.TryParse(maskedTextBoxValor.Text, out valor))
            {
                mServico.setValorServico(valor);
            }

            mServico.setDescServico(richTextBoxDesc.Text);

            mServico.setFuncionario(comboBoxFunc.Text);

            //Chamada ao método de cadastro no ControleServico
            string res = cServico.cadastroServico(mServico);

            //Mostra o resultado
            MessageBox.Show(res);
        }
        #endregion

        #region Listar tipos
        public void listarFuncionario()
        {
            controleServico cVeiculo = new controleServico();
            //Recebe os dados da consulta e salva no dataReader (Tipo)
            NpgsqlDataReader veiculo = cVeiculo.listaFuncionario();

            //Converter o dataReader em DataTable
            DataTable dtVeiculo = new DataTable();
            dtVeiculo.Load(veiculo);

            //Preencher a combobox com os dados do DataTable
            comboBoxFunc.DataSource = dtVeiculo;

            //Define qual coluna do DataTable que será exibida (nome da coluna)
            comboBoxFunc.DisplayMember = "FUNCIONARIO";
        }
        #endregion

        #region Carrega o formulário
        private void CadastroServico_Load(object sender, EventArgs e)
        {
            //Definir eventos para validar a entrada
            maskedTextBoxValor.KeyPress += new KeyPressEventHandler(maskedTextBoxValor_TextChanged);
        }
        #endregion

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

        private void maskedTextBoxValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir apenas números e a tecla Backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Bloqueia a entrada
            }
        }

        private void comboBox1_Validating(object sender, CancelEventArgs e)
        {
            System.Windows.Forms.ComboBox comboBox = sender as System.Windows.Forms.ComboBox;
            string fornecedorDigitado = comboBox.Text;

            // Verifica se o valor digitado já existe na lista de itens da ComboBox
            bool fornecedorExiste = comboBox.Items.Cast<System.Data.DataRowView>()
                                       .Any(item => item["FUNCIONARIO"].ToString()
                                       .Equals(fornecedorDigitado, StringComparison.OrdinalIgnoreCase));

            if (!fornecedorExiste && !string.IsNullOrEmpty(fornecedorDigitado))
            {
                // Exibe a mensagem com o aviso
                DialogResult result = MessageBox.Show("Aviso! Funcionário não registrado, deseja adicionar um novo?",
                                                      "Aviso!",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Ação para adicionar um novo fornecedor (sem adicionar o valor na ComboBox diretamente)
                    MessageBox.Show("Mantenha o valor digitado para cadastrar um novo funcionário",
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

        private void comboBoxFunc_DropDown(object sender, EventArgs e)
        {
            listarFuncionario();
        }
    }
}
