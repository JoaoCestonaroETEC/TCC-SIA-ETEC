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
using static System.Net.Mime.MediaTypeNames;
using TCC_SIA.Controller;
using TCC_SIA.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TCC_SIA.View
{
    public partial class PesquisaCliente : Form
    {
        #region Inicializa o formulário
        public PesquisaCliente()
        {
            InitializeComponent();

            #region Campos dos estados
            //Adiciona campos de estados do Brasil
            comboBoxEstado.Items.AddRange(new string[]
            {
                "AC",
                "AL",
                "AP",
                "AM",
                "BA",
                "CE",
                "DF",
                "ES",
                "GO",
                "MA",
                "MT",
                "MS",
                "MG",
                "PA",
                "PB",
                "PR",
                "PE",
                "PI",
                "RJ",
                "RN",
                "RS",
                "RO",
                "RR",
                "SC",
                "SP",
                "SE",
                "TO"
            });
            #endregion

            #region Campos de gêneros
            //Adiciona gêneros
            comboBoxSexo.Items.AddRange(new string[]
            {
                "Masculino",
                "Feminino",
                "Outro"
            });
            #endregion

            #region Carrega as informações gerais dos clientes
            // Criação do objeto NpgsqlDataReader cliente e ControleVeiculo
            controleCliente cCliente = new controleCliente();
            NpgsqlDataReader cliente = cCliente.pesquisarCliente(textBoxPesquisar.Text);

            //Apaga as colunas da datagridview
            dataGridViewPesquisar.Columns.Clear();

            //Definindo a quant. de colunas que a grid terá
            dataGridViewPesquisar.ColumnCount = cliente.FieldCount;

            //Definindo doze colunas na DataGridView para exibir as caracteristícas dos clientes
            dataGridViewPesquisar.ColumnCount = 12;
            dataGridViewPesquisar.Columns[0].Name = "Cpf";
            dataGridViewPesquisar.Columns[1].Name = "Nome";
            dataGridViewPesquisar.Columns[2].Name = "Email";
            dataGridViewPesquisar.Columns[3].Name = "DataNasc";
            dataGridViewPesquisar.Columns[4].Name = "Sexo";
            dataGridViewPesquisar.Columns[5].Name = "Telefone";
            dataGridViewPesquisar.Columns[6].Name = "NumeroCasa";
            dataGridViewPesquisar.Columns[7].Name = "Rua";
            dataGridViewPesquisar.Columns[8].Name = "Cidade";
            dataGridViewPesquisar.Columns[9].Name = "Cep";
            dataGridViewPesquisar.Columns[10].Name = "Bairro";
            dataGridViewPesquisar.Columns[11].Name = "Estado";

            //Aqui criamos um vetor para representar uma linha da consulta(registro)
            string[] linha = new string[cliente.FieldCount];

            //Adicionando as descrições dos clientes
            while (cliente.Read())
            {
                string cpfCliente = cliente["CPFCLIENTE"].ToString();
                string nomeCliente = cliente["NOMECLIENTE"].ToString();
                string emailCliente = cliente["EMAILCLIENTE"].ToString();
                string dataNasc = cliente["DATANASC_CLIENTE"].ToString();
                string sexo = cliente["SEXO"].ToString();
                string telefone = cliente["TELEFONE"].ToString();
                string numCasa = cliente["NUMERO"].ToString();
                string rua = cliente["RUA"].ToString();
                string cidade = cliente["CIDADE"].ToString();
                string cep = cliente["CEP"].ToString();
                string bairro = cliente["BAIRRO"].ToString();
                string estado = cliente["ESTADO"].ToString();

                dataGridViewPesquisar.Rows.Add(cpfCliente, nomeCliente, emailCliente, dataNasc, sexo, telefone, numCasa, rua, cidade, cep, bairro, estado);
            }
            #endregion
        }
        #endregion

        #region Pesquisar cliente
        //Evento de pesquisar cliente
        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            //Criação do objeto NpgsqlDataReader cliente e controleCliente
            controleCliente cCliente = new controleCliente();
            NpgsqlDataReader cliente = cCliente.pesquisarCliente(textBoxPesquisar.Text);

            //Apaga as colunas da datagridview
            dataGridViewPesquisar.Columns.Clear();

            //Definindo a quant. de colunas que a grid terá
            dataGridViewPesquisar.ColumnCount = cliente.FieldCount;

            //Definindo três colunas na DataGridView para exibir as caracteristícas dos clientes
            dataGridViewPesquisar.ColumnCount = 3;
            dataGridViewPesquisar.Columns[0].Name = "Cpf";
            dataGridViewPesquisar.Columns[1].Name = "Nome";
            dataGridViewPesquisar.Columns[2].Name = "Telefone";

            //Aqui criamos um vetor para representar uma linha da consulta(registro)
            string[] linha = new string[cliente.FieldCount];

            //Adicionando as descrições dos clientes
            while (cliente.Read())
            {
                string cpfCliente = cliente["CPFCLIENTE"].ToString();
                string nomeCliente = cliente["NOMECLIENTE"].ToString();
                string telefone = cliente["TELEFONE"].ToString();
                dataGridViewPesquisar.Rows.Add(cpfCliente, nomeCliente, telefone);
            }
        }
        #endregion

        private void atualiza_Cliente(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (dataGridViewPesquisar.SelectedRows.Count > 0)
            {
                DialogResult res = MessageBox.Show("Deseja atualizar este registro?", "Atualização de registro",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (res == DialogResult.OK)
                {

                    string ValSexo;
                    string ValUF;

                    maskedTextBoxCPF.Text = dataGridViewPesquisar.CurrentRow.Cells[0].Value.ToString();
                    textBoxNome.Text = dataGridViewPesquisar.CurrentRow.Cells[1].Value.ToString();
                    maskedTextBoxEmail.Text = dataGridViewPesquisar.CurrentRow.Cells[2].Value.ToString();
                    dateTimePickerNasc.Value = Convert.ToDateTime(dataGridViewPesquisar.CurrentRow.Cells[3].Value.ToString());
                    comboBoxSexo.SelectedIndex = comboBoxSexo.FindString(dataGridViewPesquisar.CurrentRow.Cells[4].Value.ToString());
                    maskedTextBoxTelefone.Text = dataGridViewPesquisar.CurrentRow.Cells[5].Value.ToString();
                    maskedTextBoxNumero.Text = dataGridViewPesquisar.CurrentRow.Cells[6].Value.ToString();
                    textBoxRua.Text = dataGridViewPesquisar.CurrentRow.Cells[7].Value.ToString();
                    textBoxCidade.Text = dataGridViewPesquisar.CurrentRow.Cells[8].Value.ToString();
                    maskedTextBoxCep.Text = dataGridViewPesquisar.CurrentRow.Cells[9].Value.ToString();
                    textBoxBairro.Text = dataGridViewPesquisar.CurrentRow.Cells[10].Value.ToString();
                    comboBoxEstado.SelectedIndex = comboBoxEstado.FindStringExact(dataGridViewPesquisar.CurrentRow.Cells[11].Value.ToString());
                    tabControl1.SelectedTab = tabPage2;

                }
            }




        }

        private void buttonPesquisar_Click_1(object sender, EventArgs e)
        {
            #region Pesquisar clientes
            // Criação do objeto NpgsqlDataReader cliente e ControleVeiculo
            controleCliente cCliente = new controleCliente();
            NpgsqlDataReader cliente = cCliente.pesquisarCliente(textBoxPesquisar.Text);

            //Apaga as colunas da datagridview
            dataGridViewPesquisar.Columns.Clear();

            //Definindo a quant. de colunas que a grid terá
            dataGridViewPesquisar.ColumnCount = cliente.FieldCount;

            //Definindo doze colunas na DataGridView para exibir as caracteristícas dos clientes
            dataGridViewPesquisar.ColumnCount = 12;
            dataGridViewPesquisar.Columns[0].Name = "Cpf";
            dataGridViewPesquisar.Columns[1].Name = "Nome";
            dataGridViewPesquisar.Columns[2].Name = "Email";
            dataGridViewPesquisar.Columns[3].Name = "DataNasc";
            dataGridViewPesquisar.Columns[4].Name = "Sexo";
            dataGridViewPesquisar.Columns[5].Name = "Telefone";
            dataGridViewPesquisar.Columns[6].Name = "NumeroCasa";
            dataGridViewPesquisar.Columns[7].Name = "Rua";
            dataGridViewPesquisar.Columns[8].Name = "Cidade";
            dataGridViewPesquisar.Columns[9].Name = "Cep";
            dataGridViewPesquisar.Columns[10].Name = "Bairro";
            dataGridViewPesquisar.Columns[11].Name = "Estado";

            //Aqui criamos um vetor para representar uma linha da consulta(registro)
            string[] linha = new string[cliente.FieldCount];

            //Adicionando as descrições dos clientes
            while (cliente.Read())
            {
                string cpfCliente = cliente["CPFCLIENTE"].ToString();
                string nomeCliente = cliente["NOMECLIENTE"].ToString();
                string emailCliente = cliente["EMAILCLIENTE"].ToString();
                string dataNasc = cliente["DATANASC_CLIENTE"].ToString();
                string sexo = cliente["SEXO"].ToString();
                string telefone = cliente["TELEFONE"].ToString();
                string numCasa = cliente["NUMERO"].ToString();
                string rua = cliente["RUA"].ToString();
                string cidade = cliente["CIDADE"].ToString();
                string cep = cliente["CEP"].ToString();
                string bairro = cliente["BAIRRO"].ToString();
                string estado = cliente["ESTADO"].ToString();

                dataGridViewPesquisar.Rows.Add(cpfCliente, nomeCliente, emailCliente, dataNasc, sexo, telefone, numCasa, rua, cidade, cep, bairro, estado);
            }
            #endregion
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region Atualizar clientes
            // Verifica se os campos obrigatórios foram preenchidos
            if (string.IsNullOrWhiteSpace(maskedTextBoxCPF.Text) &&
                string.IsNullOrWhiteSpace(textBoxNome.Text) &&
                string.IsNullOrWhiteSpace(maskedTextBoxNumero.Text) &&
                string.IsNullOrWhiteSpace(maskedTextBoxCep.Text) &&
                string.IsNullOrWhiteSpace(textBoxBairro.Text) &&
                string.IsNullOrWhiteSpace(textBoxCidade.Text) &&
                string.IsNullOrWhiteSpace(textBoxRua.Text) &&
                string.IsNullOrWhiteSpace(comboBoxEstado.Text))
            {
                MessageBox.Show("Preencha todos os campos! (exceto email, data de nascimento, sexo e telefone)");
                return;
            }

            //Criação do objeto Cliente e controleCliente
            Cliente mCliente = new Cliente();
            controleCliente cCliente = new controleCliente();

            //Definindo os valores nos atributos

            //Faz uma verificação para tentar enviar o valor para o atributo, se existiver vazia ele envia vazia sem dar erro
            long cpf;
            if (!long.TryParse(maskedTextBoxCPF.Text, out cpf))
            {
                MessageBox.Show("CPF inválido.");
                return;
            }

            mCliente.setCpfCliente(Convert.ToString(maskedTextBoxCPF));
            mCliente.setNomeCliente(textBoxNome.Text);
            mCliente.setEmailCliente(maskedTextBoxEmail.Text);
            mCliente.setDataNascCliente(Convert.ToDateTime(dateTimePickerNasc.Text));
            mCliente.setSexo(comboBoxSexo.Text);
            mCliente.setTelefone(maskedTextBoxTelefone.Text);

            //Faz uma verificação para tentar enviar o valor para o atributo, se existiver vazia ele envia vazia sem dar erro
            long numero;
            if (long.TryParse(maskedTextBoxNumero.Text, out numero))
            {
                mCliente.setNumero(numero);
            }

            mCliente.setRua(textBoxRua.Text);
            mCliente.setCidade(textBoxCidade.Text);

            //Faz uma verificação para tentar enviar o valor para o atributo, se existiver vazia ele envia vazia sem dar erro
            long cep;
            if (long.TryParse(maskedTextBoxCep.Text, out cep))
            {
                mCliente.setCep(cep);
            }

            mCliente.setBairro(textBoxBairro.Text);
            mCliente.setUf(comboBoxEstado.Text);

            //Chamada ao método de cadastro no ControleCliente
            string res = cCliente.atualizarCliente(mCliente);

            //Mostra o resultado
            MessageBox.Show(res);
            #endregion
        }
    }

}
