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

namespace TCC_SIA.View
{
    public partial class PesquisaCliente : Form
    {
        public PesquisaCliente(String p)
        {
            InitializeComponent();

            dataGridViewPesquisarJ.Text = p;

        }

        #region Inicializa o formulário
        public PesquisaCliente()
        {
            InitializeComponent();

            #region Campos dos estados
            //Adiciona campos de estados do Brasil
            /*
            cbEstado.Items.AddRange(new string[]
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
            */
            #endregion

            /* cbSexo.Items.AddRange(new string[]
            {
                "Masculino",
                "Feminino",
                "Outro"
            });
            */

            #region Carrega as informações gerais dos clientes
            // Criação do objeto NpgsqlDataReader cliente e ControleVeiculo
            controleCliente cCliente = new controleCliente();
            NpgsqlDataReader clienteF = cCliente.pesquisarClienteF("");

            // Apaga as colunas da DataGridView
            dataGridViewPesquisarF.Columns.Clear();

            // Definindo a quantidade de colunas da grid
            dataGridViewPesquisarF.ColumnCount = 16;

            // Definindo os nomes das colunas
            dataGridViewPesquisarF.Columns[0].Name = "Id";
            dataGridViewPesquisarF.Columns[1].Name = "Cpf";
            dataGridViewPesquisarF.Columns[2].Name = "Nome";
            dataGridViewPesquisarF.Columns[3].Name = "Email";
            dataGridViewPesquisarF.Columns[4].Name = "Data de Nascimento";
            dataGridViewPesquisarF.Columns[5].Name = "Sexo";
            dataGridViewPesquisarF.Columns[6].Name = "Telefone";
            dataGridViewPesquisarF.Columns[7].Name = "Número";
            dataGridViewPesquisarF.Columns[8].Name = "Rua";
            dataGridViewPesquisarF.Columns[9].Name = "Cidade";
            dataGridViewPesquisarF.Columns[10].Name = "Cep";
            dataGridViewPesquisarF.Columns[11].Name = "Bairro";
            dataGridViewPesquisarF.Columns[12].Name = "Estado";
            dataGridViewPesquisarF.Columns[13].Name = "Status";
            dataGridViewPesquisarF.Columns[14].Name = "Data";
            dataGridViewPesquisarF.Columns[15].Name = "Observações";

            // Aqui criamos um vetor para representar uma linha da consulta (registro)
            string[] linhaF = new string[16];

            // Adicionando as descrições dos clientes
            while (clienteF.Read())
            {
                string idCliente = clienteF.IsDBNull(clienteF.GetOrdinal("IDCLIENTE")) ? "" : clienteF["IDCLIENTE"].ToString();
                string cpfCliente = clienteF.IsDBNull(clienteF.GetOrdinal("CPFCLIENTE")) ? "" : clienteF["CPFCLIENTE"].ToString();
                string nomeCliente = clienteF.IsDBNull(clienteF.GetOrdinal("NOMECLIENTE")) ? "" : clienteF["NOMECLIENTE"].ToString();
                string emailCliente = clienteF.IsDBNull(clienteF.GetOrdinal("EMAILCLIENTE")) ? "" : clienteF["EMAILCLIENTE"].ToString();
                string dataNasc = clienteF.IsDBNull(clienteF.GetOrdinal("DATANASC_CLIENTE")) ? "" : clienteF["DATANASC_CLIENTE"].ToString();
                string sexo = clienteF.IsDBNull(clienteF.GetOrdinal("SEXO")) ? "" : clienteF["SEXO"].ToString();
                string telefone = clienteF.IsDBNull(clienteF.GetOrdinal("TELEFONE")) ? "" : clienteF["TELEFONE"].ToString();
                string numCasa = clienteF.IsDBNull(clienteF.GetOrdinal("NUMERO")) ? "" : clienteF["NUMERO"].ToString();
                string rua = clienteF.IsDBNull(clienteF.GetOrdinal("RUA")) ? "" : clienteF["RUA"].ToString();
                string cidade = clienteF.IsDBNull(clienteF.GetOrdinal("CIDADE")) ? "" : clienteF["CIDADE"].ToString();
                string cep = clienteF.IsDBNull(clienteF.GetOrdinal("CEP")) ? "" : clienteF["CEP"].ToString();
                string bairro = clienteF.IsDBNull(clienteF.GetOrdinal("BAIRRO")) ? "" : clienteF["BAIRRO"].ToString();
                string estado = clienteF.IsDBNull(clienteF.GetOrdinal("ESTADO")) ? "" : clienteF["ESTADO"].ToString();
                string status = clienteF.IsDBNull(clienteF.GetOrdinal("STATUS")) ? "" : clienteF["STATUS"].ToString();
                string data = clienteF.IsDBNull(clienteF.GetOrdinal("DATA")) ? "" : clienteF["DATA"].ToString();
                string obs = clienteF.IsDBNull(clienteF.GetOrdinal("OBS")) ? "" : clienteF["OBS"].ToString();

                // Adiciona a linha à DataGridView
                dataGridViewPesquisarF.Rows.Add(idCliente, cpfCliente, nomeCliente, emailCliente, dataNasc, sexo, telefone, numCasa, rua, cidade, cep, bairro, estado, status, data, obs);
            }
            #endregion


            // Criação do objeto NpgsqlDataReader cliente e ControleVeiculo
            NpgsqlDataReader clienteJ = cCliente.pesquisarClienteJ(textBoxPesquisarJ.Text);

            //Apaga as colunas da datagridview
            dataGridViewPesquisarJ.Columns.Clear();

            //Definindo a quant. de colunas que a grid terá
            dataGridViewPesquisarJ.ColumnCount = clienteJ.FieldCount;

            //Definindo doze colunas na DataGridView para exibir as caracteristícas dos clientes
            dataGridViewPesquisarJ.ColumnCount = 14;
            dataGridViewPesquisarJ.Columns[0].Name = "Id";
            dataGridViewPesquisarJ.Columns[1].Name = "Cnpj";
            dataGridViewPesquisarJ.Columns[2].Name = "Nome";
            dataGridViewPesquisarJ.Columns[3].Name = "Email";
            dataGridViewPesquisarJ.Columns[4].Name = "Telefone";
            dataGridViewPesquisarJ.Columns[5].Name = "Número";
            dataGridViewPesquisarJ.Columns[6].Name = "Rua";
            dataGridViewPesquisarJ.Columns[7].Name = "Cidade";
            dataGridViewPesquisarJ.Columns[8].Name = "Cep";
            dataGridViewPesquisarJ.Columns[9].Name = "Bairro";
            dataGridViewPesquisarJ.Columns[10].Name = "Estado";
            dataGridViewPesquisarJ.Columns[11].Name = "Status";
            dataGridViewPesquisarJ.Columns[12].Name = "Data";
            dataGridViewPesquisarJ.Columns[13].Name = "Razão Júdicial";

            //Aqui criamos um vetor para representar uma linha da consulta(registro)
            string[] linhaJ = new string[clienteJ.FieldCount];

            //Adicionando as descrições dos clientes
            while (clienteJ.Read())
            {
                string idCliente = clienteJ["IDCLIENTE"].ToString();
                string cnpjCliente = clienteJ["CNPJCLIENTE"].ToString();
                string nomeCliente = clienteJ["NOMECLIENTE"].ToString();
                string emailCliente = clienteJ["EMAILCLIENTE"].ToString();
                string telefone = clienteJ["TELEFONE"].ToString();
                string numCasa = clienteJ["NUMERO"].ToString();
                string rua = clienteJ["RUA"].ToString();
                string cidade = clienteJ["CIDADE"].ToString();
                string cep = clienteJ["CEP"].ToString();
                string bairro = clienteJ["BAIRRO"].ToString();
                string estado = clienteJ["ESTADO"].ToString();
                string status = clienteJ["STATUS"].ToString();
                string data = clienteJ["DATA"].ToString();
                string razao = clienteJ["RAZAO"].ToString();

                dataGridViewPesquisarJ.Rows.Add(idCliente, cnpjCliente, nomeCliente, emailCliente, telefone, numCasa, rua, cidade, cep, bairro, estado, status, data, razao);
            }
            #endregion
        }


        #region Pesquisar cliente
        //Evento de pesquisar cliente
        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            #region Pesquisar clientes
            // Criação do objeto NpgsqlDataReader cliente e ControleVeiculo
            controleCliente cCliente = new controleCliente();
            NpgsqlDataReader cliente = cCliente.pesquisarClienteF(textBoxPesquisarF.Text);

            //Apaga as colunas da datagridview
            dataGridViewPesquisarF.Columns.Clear();

            //Definindo a quant. de colunas que a grid terá
            dataGridViewPesquisarF.ColumnCount = cliente.FieldCount;

            //Definindo doze colunas na DataGridView para exibir as caracteristícas dos clientes
            dataGridViewPesquisarF.ColumnCount = 16;
            dataGridViewPesquisarF.Columns[0].Name = "Id";
            dataGridViewPesquisarF.Columns[1].Name = "Cpf";
            dataGridViewPesquisarF.Columns[2].Name = "Nome";
            dataGridViewPesquisarF.Columns[3].Name = "Email";
            dataGridViewPesquisarF.Columns[4].Name = "Data de Nascimento";
            dataGridViewPesquisarF.Columns[5].Name = "Sexo";
            dataGridViewPesquisarF.Columns[6].Name = "Telefone";
            dataGridViewPesquisarF.Columns[7].Name = "Número";
            dataGridViewPesquisarF.Columns[8].Name = "Rua";
            dataGridViewPesquisarF.Columns[9].Name = "Cidade";
            dataGridViewPesquisarF.Columns[10].Name = "Cep";
            dataGridViewPesquisarF.Columns[11].Name = "Bairro";
            dataGridViewPesquisarF.Columns[12].Name = "Estado";
            dataGridViewPesquisarF.Columns[13].Name = "Status";
            dataGridViewPesquisarF.Columns[14].Name = "Data";
            dataGridViewPesquisarF.Columns[15].Name = "Observações";

            //Aqui criamos um vetor para representar uma linha da consulta(registro)
            string[] linha = new string[cliente.FieldCount];

            //Adicionando as descrições dos clientes
            while (cliente.Read())
            {
                string idCliente = cliente["IDCLIENTE"].ToString();
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
                string status = cliente["STATUS"].ToString();
                string data = cliente["DATA"].ToString();
                string obs = cliente["OBS"].ToString();

                dataGridViewPesquisarF.Rows.Add(idCliente, cpfCliente, nomeCliente, emailCliente, dataNasc, sexo, telefone, numCasa, rua, cidade, cep, bairro, estado, status, data, obs);
            }
            #endregion
        }
        #endregion

        private void AtualizarClienteF(object sender, EventArgs e)
        {
            if (dataGridViewPesquisarF.SelectedRows.Count > 0)
            {
                DialogResult res = MessageBox.Show("Deseja atualizar este registro?", "Atualização de registro",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (res == DialogResult.OK)
                {
                    maskedID.Text = dataGridViewPesquisarF.CurrentRow.Cells[0].Value.ToString();

                    maskedTextBoxCPFF.Text = dataGridViewPesquisarF.CurrentRow.Cells[1].Value.ToString();

                    textBoxNomeF.Text = dataGridViewPesquisarF.CurrentRow.Cells[2].Value.ToString();

                    maskedTextBoxEmailF.Text = dataGridViewPesquisarF.CurrentRow.Cells[3].Value.ToString();

                    dateTimePickerNascF.Value = Convert.ToDateTime(dataGridViewPesquisarF.CurrentRow.Cells[4].Value.ToString());

                    comboBoxSexoF.Text = dataGridViewPesquisarF.CurrentRow.Cells[5].Value.ToString();

                    maskedTextBoxTelefoneF.Text = dataGridViewPesquisarF.CurrentRow.Cells[6].Value.ToString();

                    maskedTextBoxNumeroF.Text = dataGridViewPesquisarF.CurrentRow.Cells[7].Value.ToString();

                    textBoxRuaF.Text = dataGridViewPesquisarF.CurrentRow.Cells[8].Value.ToString();

                    textBoxCidadeF.Text = dataGridViewPesquisarF.CurrentRow.Cells[9].Value.ToString();

                    maskedTextBoxCepF.Text = dataGridViewPesquisarF.CurrentRow.Cells[10].Value.ToString();

                    textBoxBairroF.Text = dataGridViewPesquisarF.CurrentRow.Cells[11].Value.ToString();

                    comboBoxUfF.SelectedIndex = comboBoxUfF.FindStringExact(dataGridViewPesquisarF.CurrentRow.Cells[12].Value.ToString());

                    comboBoxStatusF.SelectedIndex = comboBoxStatusF.FindStringExact(dataGridViewPesquisarF.CurrentRow.Cells[13].Value.ToString());

                    dateTimePickerDataF.Value = Convert.ToDateTime(dataGridViewPesquisarF.CurrentRow.Cells[14].Value.ToString());

                    richTextBoxObsF.Text = dataGridViewPesquisarF.CurrentRow.Cells[15].Value.ToString();

                    tabControlPesquisarClientes.SelectedTab = tabPage1;

                }
            }
        }



        private void btnSalvarAF_Click(object sender, EventArgs e)
        {
            controleCliente cClienteF = new controleCliente();

            Cliente mClienteF = new Cliente();

            //Definindo os valores nos atributos

            //Faz uma verificação para tentar enviar o valor para o atributo, se existiver vazia ele envia vazia sem dar erro

            mClienteF.setIdCliente(Convert.ToInt32(maskedID.Text));
            mClienteF.setCpfCliente(maskedTextBoxCPFF.Text);
            mClienteF.setNomeCliente(textBoxNomeF.Text);
            mClienteF.setEmailCliente(maskedTextBoxEmailF.Text);
            mClienteF.setDataNascCliente(Convert.ToDateTime(dateTimePickerNascF.Text));
            mClienteF.setSexo(comboBoxSexoF.Text);
            mClienteF.setTelefone(maskedTextBoxTelefoneF.Text);

            //Faz uma verificação para tentar enviar o valor para o atributo, se existiver vazia ele envia vazia sem dar erro
            long numero;
            if (long.TryParse(maskedTextBoxNumeroF.Text, out numero))
            {
                mClienteF.setNumero(numero);
            }

            mClienteF.setRua(textBoxRuaF.Text);
            mClienteF.setCidade(textBoxCidadeF.Text);

            //Faz uma verificação para tentar enviar o valor para o atributo, se existiver vazia ele envia vazia sem dar erro
            long cep;
            if (long.TryParse(maskedTextBoxCepF.Text, out cep))
            {
                mClienteF.setCep(cep);
            }

            //bool cpfValido = ValidaCPF.IsCpf(maskedCPF.Text);

            mClienteF.setBairro(textBoxBairroF.Text);
            mClienteF.setUf(comboBoxUfF.Text);
            mClienteF.setStatus(comboBoxStatusF.Text);
            mClienteF.setData(Convert.ToDateTime(dateTimePickerDataF.Text));
            mClienteF.setObs(richTextBoxObsF.Text);

            //Chamada ao método de cadastro no ControleCliente
            string res = cClienteF.atualizaClienteF(mClienteF);

            //Mostra o resultado
            MessageBox.Show(res);

        }

        private void buttonPesquisarJ_Click(object sender, EventArgs e)
        {
            #region Pesquisar clientes
            // Criação do objeto NpgsqlDataReader cliente e ControleVeiculo
            controleCliente cCliente = new controleCliente();
            NpgsqlDataReader cliente = cCliente.pesquisarClienteJ(textBoxPesquisarJ.Text);

            //Apaga as colunas da datagridview
            dataGridViewPesquisarJ.Columns.Clear();

            //Definindo a quant. de colunas que a grid terá
            dataGridViewPesquisarJ.ColumnCount = cliente.FieldCount;

            //Definindo doze colunas na DataGridView para exibir as caracteristícas dos clientes
            dataGridViewPesquisarJ.ColumnCount = 14;
            dataGridViewPesquisarJ.Columns[0].Name = "Id";
            dataGridViewPesquisarJ.Columns[1].Name = "Cnpj";
            dataGridViewPesquisarJ.Columns[2].Name = "Nome";
            dataGridViewPesquisarJ.Columns[3].Name = "Email";
            dataGridViewPesquisarJ.Columns[4].Name = "Telefone";
            dataGridViewPesquisarJ.Columns[5].Name = "Número";
            dataGridViewPesquisarJ.Columns[6].Name = "Rua";
            dataGridViewPesquisarJ.Columns[7].Name = "Cidade";
            dataGridViewPesquisarJ.Columns[8].Name = "Cep";
            dataGridViewPesquisarJ.Columns[9].Name = "Bairro";
            dataGridViewPesquisarJ.Columns[10].Name = "Estado";
            dataGridViewPesquisarJ.Columns[11].Name = "Status";
            dataGridViewPesquisarJ.Columns[12].Name = "Data";
            dataGridViewPesquisarJ.Columns[13].Name = "Razão Júdicial";

            //Aqui criamos um vetor para representar uma linha da consulta(registro)
            string[] linha = new string[cliente.FieldCount];

            //Adicionando as descrições dos clientes
            while (cliente.Read())
            {
                string idCliente = cliente["IDCLIENTE"].ToString();
                string cnpjCliente = cliente["CNPJCLIENTE"].ToString();
                string nomeCliente = cliente["NOMECLIENTE"].ToString();
                string emailCliente = cliente["EMAILCLIENTE"].ToString();
                string telefone = cliente["TELEFONE"].ToString();
                string numCasa = cliente["NUMERO"].ToString();
                string rua = cliente["RUA"].ToString();
                string cidade = cliente["CIDADE"].ToString();
                string cep = cliente["CEP"].ToString();
                string bairro = cliente["BAIRRO"].ToString();
                string estado = cliente["ESTADO"].ToString();
                string status = cliente["STATUS"].ToString();
                string data = cliente["DATA"].ToString();
                string razao = cliente["RAZAO"].ToString();

                dataGridViewPesquisarJ.Rows.Add(idCliente, cnpjCliente, nomeCliente, emailCliente, telefone, numCasa, rua, cidade, cep, bairro, estado, status, data, razao);
            }
            #endregion
        }

        private void buttonSalvarAJ_Click(object sender, EventArgs e)
        {
            controleCliente cClienteJ = new controleCliente();

            Cliente mClienteJ = new Cliente();

            //Definindo os valores nos atributos

            //Faz uma verificação para tentar enviar o valor para o atributo, se existiver vazia ele envia vazia sem dar erro

            mClienteJ.setIdCliente(Convert.ToInt32(maskedTextBoxIDJ.Text));
            mClienteJ.setCNPJCLiente(maskedTextBoxCNPJ.Text);
            mClienteJ.setNomeCliente(textBoxNomeJ.Text);
            mClienteJ.setEmailCliente(maskedTextBoxEmailJ.Text);
            mClienteJ.setTelefone(maskedTextBoxTelefoneJ.Text);

            //Faz uma verificação para tentar enviar o valor para o atributo, se existiver vazia ele envia vazia sem dar erro
            long numero;
            if (long.TryParse(maskedTextBoxNumeroJ.Text, out numero))
            {
                mClienteJ.setNumero(numero);
            }

            mClienteJ.setRua(textBoxRuaJ.Text);
            mClienteJ.setCidade(textBoxCidadeJ.Text);

            //Faz uma verificação para tentar enviar o valor para o atributo, se existiver vazia ele envia vazia sem dar erro
            long cep;
            if (long.TryParse(maskedTextBoxCepJ.Text, out cep))
            {
                mClienteJ.setCep(cep);
            }

            //bool cpfValido = ValidaCPF.IsCpf(maskedCPF.Text);

            mClienteJ.setBairro(textBoxBairroJ.Text);
            mClienteJ.setUf(comboBoxUfJ.Text);
            mClienteJ.setStatus(comboBoxStatusJ.Text);
            mClienteJ.setData(Convert.ToDateTime(dateTimePickerDataJ.Text));
            mClienteJ.setRazao(richTextBoxRazao.Text);

            //Chamada ao método de cadastro no ControleCliente
            string res = cClienteJ.atualizaClienteJ(mClienteJ);

            //Mostra o resultado
            MessageBox.Show(res);

        }

        private void AtualizaClienteJ(object sender, EventArgs e)
        {

            if (dataGridViewPesquisarJ.SelectedRows.Count > 0)
            {
                DialogResult res = MessageBox.Show("Deseja atualizar este registro?", "Atualização de registro",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (res == DialogResult.OK)
                {
                    maskedTextBoxIDJ.Text = dataGridViewPesquisarJ.CurrentRow.Cells[0].Value.ToString();

                    maskedTextBoxCNPJ.Text = dataGridViewPesquisarJ.CurrentRow.Cells[1].Value.ToString();

                    textBoxNomeJ.Text = dataGridViewPesquisarJ.CurrentRow.Cells[2].Value.ToString();

                    maskedTextBoxEmailJ.Text = dataGridViewPesquisarJ.CurrentRow.Cells[3].Value.ToString();

                    maskedTextBoxTelefoneJ.Text = dataGridViewPesquisarJ.CurrentRow.Cells[4].Value.ToString();

                    maskedTextBoxNumeroJ.Text = dataGridViewPesquisarJ.CurrentRow.Cells[5].Value.ToString();

                    textBoxRuaJ.Text = dataGridViewPesquisarJ.CurrentRow.Cells[6].Value.ToString();

                    textBoxCidadeJ.Text = dataGridViewPesquisarJ.CurrentRow.Cells[7].Value.ToString();

                    maskedTextBoxCepJ.Text = dataGridViewPesquisarJ.CurrentRow.Cells[8].Value.ToString();

                    textBoxBairroJ.Text = dataGridViewPesquisarJ.CurrentRow.Cells[9].Value.ToString();

                    comboBoxUfJ.SelectedIndex = comboBoxUfF.FindStringExact(dataGridViewPesquisarJ.CurrentRow.Cells[10].Value.ToString());

                    comboBoxStatusJ.SelectedIndex = comboBoxStatusF.FindStringExact(dataGridViewPesquisarJ.CurrentRow.Cells[11].Value.ToString());

                    dateTimePickerDataJ.Value = Convert.ToDateTime(dataGridViewPesquisarJ.CurrentRow.Cells[12].Value.ToString());

                    richTextBoxRazao.Text = dataGridViewPesquisarJ.CurrentRow.Cells[13].Value.ToString();

                    tabControlPesquisarClientes.SelectedTab = tabPage2;
               }
            }
        }
    }
}
