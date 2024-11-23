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

            #region Carrega os dados de pesquisa de serviços
            // Criação do objeto NpgsqlDataReader servico e controleServico
            controleCliente cCliente = new controleCliente();
            NpgsqlDataReader cliente = cCliente.pesquisarClienteF(textBoxPesquisarF.Text);

            // Armazena os estados das checkboxes e os valores de "Quantidade de Vezes" antes de limpar
            List<bool> checkboxStates = new List<bool>();
            List<int> quantidadeVezesValues = new List<int>();

            for (int i = 0; i < dataGridViewPesquisarF.Rows.Count; i++)
            {
                if (!dataGridViewPesquisarF.Rows[i].IsNewRow)
                {
                    checkboxStates.Add(dataGridViewPesquisarF.Rows[i].Cells["Selecionar"].Value is bool isChecked && isChecked);
                }
            }

            // Apaga as colunas da datagridview
            dataGridViewPesquisarF.Columns.Clear();

            // Desabilitar a adição automática de novas linhas
            dataGridViewPesquisarF.AllowUserToAddRows = false;

            // Definindo a quantidade de colunas que a grid terá
            dataGridViewPesquisarF.ColumnCount = 16;

            // Definindo as colunas na DataGridView para exibir as descrições
            dataGridViewPesquisarF.Columns[0].Name = "Id Cliente";
            dataGridViewPesquisarF.Columns[0].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisarF.Columns[1].Name = "Nome";
            dataGridViewPesquisarF.Columns[1].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisarF.Columns[2].Name = "Email";
            dataGridViewPesquisarF.Columns[2].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisarF.Columns[3].Name = "Data";
            dataGridViewPesquisarF.Columns[3].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisarF.Columns[4].Name = "Status";
            dataGridViewPesquisarF.Columns[4].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisarF.Columns[5].Name = "CPF";
            dataGridViewPesquisarF.Columns[5].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisarF.Columns[6].Name = "Data de Nascimento";
            dataGridViewPesquisarF.Columns[6].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisarF.Columns[7].Name = "Sexo";
            dataGridViewPesquisarF.Columns[7].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisarF.Columns[8].Name = "Observação";
            dataGridViewPesquisarF.Columns[8].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisarF.Columns[9].Name = "Telefone";
            dataGridViewPesquisarF.Columns[9].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisarF.Columns[10].Name = "Numero";
            dataGridViewPesquisarF.Columns[10].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisarF.Columns[11].Name = "Rua";
            dataGridViewPesquisarF.Columns[11].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisarF.Columns[12].Name = "Cidade";
            dataGridViewPesquisarF.Columns[12].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisarF.Columns[13].Name = "Cep";
            dataGridViewPesquisarF.Columns[13].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisarF.Columns[14].Name = "Bairro";
            dataGridViewPesquisarF.Columns[14].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisarF.Columns[15].Name = "Estado";
            dataGridViewPesquisarF.Columns[15].ReadOnly = true; // Definindo como somente leitura

            // Criando a coluna de checkbox para marcação (editável)
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.Name = "Selecionar";
            checkBoxColumn.ReadOnly = false; // Deixando a checkbox editável
            dataGridViewPesquisarF.Columns.Add(checkBoxColumn);

            // Adicionando as descrições dos serviços
            while (cliente.Read())
            {
                string idCliente = cliente["IDCLIENTE"].ToString();
                string nomeCliente = cliente["NOMECLIENTE"].ToString();
                string emailCliente = cliente["EMAILCLIENTE"].ToString();
                string data = cliente["DATA"].ToString();
                string status = cliente["STATUS"].ToString();
                string cpfCliente = cliente["CPFCLIENTE"].ToString();
                string datanasc_cliente = cliente["DATANASC_CLIENTE"].ToString();
                string sexo = cliente["SEXO"].ToString();
                string obs = cliente["OBS"].ToString();
                string telefone = cliente["TELEFONE"].ToString();
                string numero = cliente["NUMERO"].ToString();
                string rua = cliente["RUA"].ToString();
                string cidade = cliente["CIDADE"].ToString();
                string cep = cliente["CEP"].ToString();
                string bairro = cliente["BAIRRO"].ToString();
                string estado = cliente["ESTADO"].ToString();

                // Verifique se a linha já existe
                bool exists = false;
                foreach (DataGridViewRow existingRow in dataGridViewPesquisarF.Rows)
                {
                    if (!existingRow.IsNewRow &&
                        existingRow.Cells["Id Cliente"].Value.ToString() == idCliente &&
                        existingRow.Cells["Nome"].Value.ToString() == nomeCliente)
                    {
                        exists = true;
                        break;
                    }
                }

                // Adiciona a nova linha apenas se não existir
                if (!exists)
                {
                    // Criando a nova linha manualmente
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dataGridViewPesquisarF); // Define a grid para onde a linha vai

                    // Preenchendo a linha com os valores
                    row.Cells[0].Value = idCliente;
                    row.Cells[1].Value = nomeCliente;
                    row.Cells[2].Value = emailCliente;
                    row.Cells[3].Value = data;
                    row.Cells[4].Value = status;
                    row.Cells[5].Value = cpfCliente;
                    row.Cells[6].Value = datanasc_cliente;
                    row.Cells[7].Value = sexo;
                    row.Cells[8].Value = obs;
                    row.Cells[9].Value = telefone;
                    row.Cells[10].Value = numero;
                    row.Cells[11].Value = rua;
                    row.Cells[12].Value = cidade;
                    row.Cells[13].Value = cep;
                    row.Cells[14].Value = bairro;
                    row.Cells[15].Value = estado;
                    row.Cells[16].Value = false; // Valor padrão para "Selecionar" (desmarcado)

                    dataGridViewPesquisarF.Rows.Add(row);
                }
                #endregion

                buttonPesquisarJ.Click += buttonPesquisarJ_Click;


            }
        }
        #region Pesquisar cliente
        //Evento de pesquisar cliente
        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            #region Pesquisar clientes
            #region Carrega os dados de pesquisa de serviços
            // Criação do objeto NpgsqlDataReader servico e controleServico
            controleCliente cCliente = new controleCliente();
            NpgsqlDataReader cliente = cCliente.pesquisarClienteF(textBoxPesquisarF.Text);

            // Armazena os estados das checkboxes e os valores de "Quantidade de Vezes" antes de limpar
            List<bool> checkboxStates = new List<bool>();
            List<int> quantidadeVezesValues = new List<int>();

            for (int i = 0; i < dataGridViewPesquisarF.Rows.Count; i++)
            {
                if (!dataGridViewPesquisarF.Rows[i].IsNewRow)
                {
                    checkboxStates.Add(dataGridViewPesquisarF.Rows[i].Cells["Selecionar"].Value is bool isChecked && isChecked);
                }
            }

            // Apaga as colunas da datagridview
            dataGridViewPesquisarF.Columns.Clear();

            // Desabilitar a adição automática de novas linhas
            dataGridViewPesquisarF.AllowUserToAddRows = false;

            // Definindo a quantidade de colunas que a grid terá
            dataGridViewPesquisarF.ColumnCount = 16;

            // Definindo as colunas na DataGridView para exibir as descrições
            dataGridViewPesquisarF.Columns[0].Name = "Id Cliente";
            dataGridViewPesquisarF.Columns[0].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisarF.Columns[1].Name = "Nome";
            dataGridViewPesquisarF.Columns[1].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisarF.Columns[2].Name = "Email";
            dataGridViewPesquisarF.Columns[2].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisarF.Columns[3].Name = "Data";
            dataGridViewPesquisarF.Columns[3].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisarF.Columns[4].Name = "Status";
            dataGridViewPesquisarF.Columns[4].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisarF.Columns[5].Name = "CPF";
            dataGridViewPesquisarF.Columns[5].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisarF.Columns[6].Name = "Data de Nascimento";
            dataGridViewPesquisarF.Columns[6].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisarF.Columns[7].Name = "Sexo";
            dataGridViewPesquisarF.Columns[7].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisarF.Columns[8].Name = "Observação";
            dataGridViewPesquisarF.Columns[8].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisarF.Columns[9].Name = "Telefone";
            dataGridViewPesquisarF.Columns[9].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisarF.Columns[10].Name = "Numero";
            dataGridViewPesquisarF.Columns[10].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisarF.Columns[11].Name = "Rua";
            dataGridViewPesquisarF.Columns[11].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisarF.Columns[12].Name = "Cidade";
            dataGridViewPesquisarF.Columns[12].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisarF.Columns[13].Name = "Cep";
            dataGridViewPesquisarF.Columns[13].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisarF.Columns[14].Name = "Bairro";
            dataGridViewPesquisarF.Columns[14].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisarF.Columns[15].Name = "Estado";
            dataGridViewPesquisarF.Columns[15].ReadOnly = true; // Definindo como somente leitura

            // Criando a coluna de checkbox para marcação (editável)
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.Name = "Selecionar";
            checkBoxColumn.ReadOnly = false; // Deixando a checkbox editável
            dataGridViewPesquisarF.Columns.Add(checkBoxColumn);

            // Adicionando as descrições dos serviços
            while (cliente.Read())
            {
                string idCliente = cliente["IDCLIENTE"].ToString();
                string nomeCliente = cliente["NOMECLIENTE"].ToString();
                string emailCliente = cliente["EMAILCLIENTE"].ToString();
                string data = cliente["DATA"].ToString();
                string status = cliente["STATUS"].ToString();
                string cpfCliente = cliente["CPFCLIENTE"].ToString();
                string datanasc_cliente = cliente["DATANASC_CLIENTE"].ToString();
                string sexo = cliente["SEXO"].ToString();
                string obs = cliente["OBS"].ToString();
                string telefone = cliente["TELEFONE"].ToString();
                string numero = cliente["NUMERO"].ToString();
                string rua = cliente["RUA"].ToString();
                string cidade = cliente["CIDADE"].ToString();
                string cep = cliente["CEP"].ToString();
                string bairro = cliente["BAIRRO"].ToString();
                string estado = cliente["ESTADO"].ToString();

                // Verifique se a linha já existe
                bool exists = false;
                foreach (DataGridViewRow existingRow in dataGridViewPesquisarF.Rows)
                {
                    if (!existingRow.IsNewRow &&
                        existingRow.Cells["Id Cliente"].Value.ToString() == idCliente &&
                        existingRow.Cells["Nome"].Value.ToString() == nomeCliente)
                    {
                        exists = true;
                        break;
                    }
                }

                // Adiciona a nova linha apenas se não existir
                if (!exists)
                {
                    // Criando a nova linha manualmente
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dataGridViewPesquisarF); // Define a grid para onde a linha vai

                    // Preenchendo a linha com os valores
                    row.Cells[0].Value = idCliente;
                    row.Cells[1].Value = nomeCliente;
                    row.Cells[2].Value = emailCliente;
                    row.Cells[3].Value = data;
                    row.Cells[4].Value = status;
                    row.Cells[5].Value = cpfCliente;
                    row.Cells[6].Value = datanasc_cliente;
                    row.Cells[7].Value = sexo;
                    row.Cells[8].Value = obs;
                    row.Cells[9].Value = telefone;
                    row.Cells[10].Value = numero;
                    row.Cells[11].Value = rua;
                    row.Cells[12].Value = cidade;
                    row.Cells[13].Value = cep;
                    row.Cells[14].Value = bairro;
                    row.Cells[15].Value = estado;
                    row.Cells[16].Value = false; // Valor padrão para "Selecionar" (desmarcado)

                    dataGridViewPesquisarF.Rows.Add(row);
                }
            }
            #endregion
        }
        #endregion


        private void AtualizarClienteF(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewPesquisarF.Rows)
            {
                // Verifica se a linha contém pelo menos 11 células e se a célula "Selecionar" (índice 10) está marcada
                if (row.Cells.Count > 16 && Convert.ToBoolean(row.Cells[16].Value) == true)
                {
                    DialogResult res = MessageBox.Show("Deseja atualizar este registro?", "Atualização de registro",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                    if (res == DialogResult.OK)
                    {

                        maskedID.Text = dataGridViewPesquisarF.CurrentRow.Cells[0].Value.ToString();

                        textBoxNomeF.Text = dataGridViewPesquisarF.CurrentRow.Cells[1].Value.ToString();

                        maskedTextBoxEmailF.Text = dataGridViewPesquisarF.CurrentRow.Cells[2].Value.ToString();

                        dateTimePickerDataF.Value = Convert.ToDateTime(dataGridViewPesquisarF.CurrentRow.Cells[3].Value.ToString());

                        comboBoxStatusF.SelectedIndex = comboBoxStatusF.FindStringExact(dataGridViewPesquisarF.CurrentRow.Cells[4].Value.ToString());

                        maskedTextBoxCPFF.Text = dataGridViewPesquisarF.CurrentRow.Cells[5].Value.ToString();

                        dateTimePickerNascF.Value = Convert.ToDateTime(dataGridViewPesquisarF.CurrentRow.Cells[6].Value.ToString());

                        comboBoxSexoF.Text = dataGridViewPesquisarF.CurrentRow.Cells[7].Value.ToString();

                        richTextBoxObsF.Text = dataGridViewPesquisarF.CurrentRow.Cells[8].Value.ToString();

                        maskedTextBoxTelefoneF.Text = dataGridViewPesquisarF.CurrentRow.Cells[9].Value.ToString();

                        maskedTextBoxNumeroF.Text = dataGridViewPesquisarF.CurrentRow.Cells[10].Value.ToString();

                        textBoxRuaF.Text = dataGridViewPesquisarF.CurrentRow.Cells[11].Value.ToString();

                        textBoxCidadeF.Text = dataGridViewPesquisarF.CurrentRow.Cells[12].Value.ToString();

                        maskedTextBoxCepF.Text = dataGridViewPesquisarF.CurrentRow.Cells[13].Value.ToString();

                        textBoxBairroF.Text = dataGridViewPesquisarF.CurrentRow.Cells[14].Value.ToString();

                        comboBoxUfF.SelectedIndex = comboBoxUfF.FindStringExact(dataGridViewPesquisarF.CurrentRow.Cells[15].Value.ToString());

                        tabControlPesquisarClientes.SelectedTab = tabPage1;
                    }
                }
            }
        }

        private void buttonPesquisarJ_Click(object sender, EventArgs e)
        {
            #region Pesquisar clientes

            #region Carrega os dados de pesquisa de serviços
            // Criação do objeto NpgsqlDataReader servico e controleServico
            controleCliente cClienteJ = new controleCliente();
            NpgsqlDataReader clienteJ = cClienteJ.pesquisarClienteJ(textBoxPesquisarJ.Text);

            // Armazena os estados das checkboxes e os valores de "Quantidade de Vezes" antes de limpar
            List<bool> checkboxStatesJ = new List<bool>();
            List<int> quantidadeVezesValuesJ = new List<int>();

            for (int i = 0; i < dataGridViewPesquisarJ.Rows.Count; i++)
            {
                if (!dataGridViewPesquisarJ.Rows[i].IsNewRow)
                {
                    checkboxStatesJ.Add(dataGridViewPesquisarJ.Rows[i].Cells["Selecionar"].Value is bool isChecked && isChecked);
                }
            }

            // Apaga as colunas da datagridview
            dataGridViewPesquisarJ.Columns.Clear();

            // Desabilitar a adição automática de novas linhas
            dataGridViewPesquisarJ.AllowUserToAddRows = false;

            // Definindo a quantidade de colunas que a grid terá
            dataGridViewPesquisarJ.ColumnCount = 14;

            // Definindo as colunas na DataGridView para exibir as descrições
            dataGridViewPesquisarJ.Columns[0].Name = "Id Cliente";
            dataGridViewPesquisarJ.Columns[0].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisarJ.Columns[1].Name = "Nome";
            dataGridViewPesquisarJ.Columns[1].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisarJ.Columns[2].Name = "Email";
            dataGridViewPesquisarJ.Columns[2].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisarJ.Columns[3].Name = "Data";
            dataGridViewPesquisarJ.Columns[3].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisarJ.Columns[4].Name = "Status";
            dataGridViewPesquisarJ.Columns[4].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisarJ.Columns[5].Name = "CNPJ";
            dataGridViewPesquisarJ.Columns[5].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisarJ.Columns[6].Name = "Razao";
            dataGridViewPesquisarJ.Columns[6].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisarJ.Columns[7].Name = "Telefone";
            dataGridViewPesquisarJ.Columns[7].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisarJ.Columns[8].Name = "Numero";
            dataGridViewPesquisarJ.Columns[8].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisarJ.Columns[9].Name = "Rua";
            dataGridViewPesquisarJ.Columns[9].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisarJ.Columns[10].Name = "Cidade";
            dataGridViewPesquisarJ.Columns[10].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisarJ.Columns[11].Name = "Cep";
            dataGridViewPesquisarJ.Columns[11].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisarJ.Columns[12].Name = "Bairro";
            dataGridViewPesquisarJ.Columns[12].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisarJ.Columns[13].Name = "Estado";
            dataGridViewPesquisarJ.Columns[13].ReadOnly = true; // Definindo como somente leitura

            // Criando a coluna de checkbox para marcação (editável)
            DataGridViewCheckBoxColumn checkBoxColumnJ = new DataGridViewCheckBoxColumn();
            checkBoxColumnJ.Name = "Selecionar";
            checkBoxColumnJ.ReadOnly = false; // Deixando a checkbox editável
            dataGridViewPesquisarJ.Columns.Add(checkBoxColumnJ);

            // Adicionando as descrições dos serviços
            while (clienteJ.Read())
            {
                string idClienteJ = clienteJ["IDCLIENTE"].ToString();
                string nomeClienteJ = clienteJ["NOMECLIENTE"].ToString();
                string emailClienteJ = clienteJ["EMAILCLIENTE"].ToString();
                string dataJ = clienteJ["DATA"].ToString();
                string statusJ = clienteJ["STATUS"].ToString();
                string cnpjCliente = clienteJ["CNPJCLIENTE"].ToString();
                string razao = clienteJ["RAZAO"].ToString();
                string telefoneJ = clienteJ["TELEFONE"].ToString();
                string numeroJ = clienteJ["NUMERO"].ToString();
                string ruaJ = clienteJ["RUA"].ToString();
                string cidadeJ = clienteJ["CIDADE"].ToString();
                string cepJ = clienteJ["CEP"].ToString();
                string bairroJ = clienteJ["BAIRRO"].ToString();
                string estadoJ = clienteJ["ESTADO"].ToString();

                // Verifique se a linha já existe
                bool existsJ = false;
                foreach (DataGridViewRow existingRow in dataGridViewPesquisarJ.Rows)
                {
                    if (!existingRow.IsNewRow &&
                        existingRow.Cells["Id Cliente"].Value.ToString() == idClienteJ &&
                        existingRow.Cells["Nome"].Value.ToString() == nomeClienteJ)
                    {
                        existsJ = true;
                        break;
                    }
                }

                // Adiciona a nova linha apenas se não existir
                if (!existsJ)
                {
                    // Criando a nova linha manualmente
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dataGridViewPesquisarJ); // Define a grid para onde a linha vai

                    // Preenchendo a linha com os valores
                    row.Cells[0].Value = idClienteJ;
                    row.Cells[1].Value = nomeClienteJ;
                    row.Cells[2].Value = emailClienteJ;
                    row.Cells[3].Value = dataJ;
                    row.Cells[4].Value = statusJ;
                    row.Cells[5].Value = cnpjCliente;
                    row.Cells[6].Value = razao;
                    row.Cells[7].Value = telefoneJ;
                    row.Cells[8].Value = numeroJ;
                    row.Cells[9].Value = ruaJ;
                    row.Cells[10].Value = cidadeJ;
                    row.Cells[11].Value = cepJ;
                    row.Cells[12].Value = bairroJ;
                    row.Cells[13].Value = estadoJ;
                    row.Cells[14].Value = false; // Valor padrão para "Selecionar" (desmarcado)

                    dataGridViewPesquisarJ.Rows.Add(row);
                }
                #endregion

            }
            #endregion
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
            foreach (DataGridViewRow row in dataGridViewPesquisarJ.Rows)
            {
                // Verifica se a linha contém pelo menos 11 células e se a célula "Selecionar" (índice 10) está marcada
                if (row.Cells.Count > 14 && Convert.ToBoolean(row.Cells[14].Value) == true)
                {
                    DialogResult res = MessageBox.Show("Deseja atualizar este registro?", "Atualização de registro",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                    if (res == DialogResult.OK)
                    {

                        maskedTextBoxIDJ.Text = dataGridViewPesquisarJ.CurrentRow.Cells[0].Value.ToString();

                        textBoxNomeJ.Text = dataGridViewPesquisarJ.CurrentRow.Cells[1].Value.ToString();

                        maskedTextBoxEmailJ.Text = dataGridViewPesquisarJ.CurrentRow.Cells[2].Value.ToString();

                        dateTimePickerDataJ.Value = Convert.ToDateTime(dataGridViewPesquisarJ.CurrentRow.Cells[3].Value.ToString());

                        comboBoxStatusJ.SelectedIndex = comboBoxStatusF.FindStringExact(dataGridViewPesquisarJ.CurrentRow.Cells[4].Value.ToString());

                        maskedTextBoxCNPJ.Text = dataGridViewPesquisarJ.CurrentRow.Cells[5].Value.ToString();

                        richTextBoxRazao.Text = dataGridViewPesquisarJ.CurrentRow.Cells[6].Value.ToString();

                        maskedTextBoxTelefoneJ.Text = dataGridViewPesquisarJ.CurrentRow.Cells[7].Value.ToString();

                        maskedTextBoxNumeroJ.Text = dataGridViewPesquisarJ.CurrentRow.Cells[8].Value.ToString();

                        textBoxRuaJ.Text = dataGridViewPesquisarJ.CurrentRow.Cells[9].Value.ToString();

                        textBoxCidadeJ.Text = dataGridViewPesquisarJ.CurrentRow.Cells[10].Value.ToString();

                        maskedTextBoxCepJ.Text = dataGridViewPesquisarJ.CurrentRow.Cells[11].Value.ToString();

                        textBoxBairroJ.Text = dataGridViewPesquisarJ.CurrentRow.Cells[12].Value.ToString();

                        comboBoxUfJ.SelectedIndex = comboBoxUfF.FindStringExact(dataGridViewPesquisarJ.CurrentRow.Cells[13].Value.ToString());

                        // Troca para a aba de edição
                        tabControlPesquisarClientes.SelectedTab = tabPage2;
                    }
                }
            }
        }


        private void btnDeletarF_Click(object sender, EventArgs e)
        {
            // Lista para armazenar os IDs dos pedidos a serem deletados
            List<long> clientesParaDeletar = new List<long>();

            // Percorrer todas as linhas do DataGridView
            foreach (DataGridViewRow row in dataGridViewPesquisarF.Rows)
            {
                // Verifica se a checkbox está marcada na linha
                bool isSelected = Convert.ToBoolean(row.Cells["Selecionar"].Value);

                if (isSelected)
                {
                    // Recupera o ID do pedido da linha
                    long idCliente = Convert.ToInt64(row.Cells["Id Cliente"].Value);
                    clientesParaDeletar.Add(idCliente);
                }
            }

            if (clientesParaDeletar.Count > 0)
            {
                // Inicializa o controlePedido para acessar o método de deletação
                controleCliente cCliente = new controleCliente();

                // Deletar cada pedido selecionado
                foreach (int idCliente in clientesParaDeletar)
                {
                    Cliente mCliente = new Cliente();
                    mCliente.setIdCliente(idCliente);

                    // Chama o método para deletar o pedido
                    string resultMessage = cCliente.DeletarClienteF(mCliente);

                    // Exibe o resultado da exclusão
                    MessageBox.Show(resultMessage);
                }
            }
            else
            {
                MessageBox.Show("Please select at least one order to delete.");
            }

        }

        private void btnDeletarJ_Click(object sender, EventArgs e)
        {
            // Lista para armazenar os IDs dos pedidos a serem deletados
            List<long> clientesParaDeletar = new List<long>();

            // Percorrer todas as linhas do DataGridView
            foreach (DataGridViewRow row in dataGridViewPesquisarJ.Rows)
            {
                // Verifica se a checkbox está marcada na linha
                bool isSelected = Convert.ToBoolean(row.Cells["Selecionar"].Value);

                if (isSelected)
                {
                    // Recupera o ID do pedido da linha
                    long idCliente = Convert.ToInt64(row.Cells["Id Cliente"].Value);
                    clientesParaDeletar.Add(idCliente);
                }
            }

            if (clientesParaDeletar.Count > 0)
            {
                // Inicializa o controlePedido para acessar o método de deletação
                controleCliente cCliente = new controleCliente();

                // Deletar cada pedido selecionado
                foreach (int idCliente in clientesParaDeletar)
                {
                    Cliente mCliente = new Cliente();
                    mCliente.setIdCliente(idCliente);

                    // Chama o método para deletar o pedido
                    string resultMessage = cCliente.DeletarClienteJ(mCliente);

                    // Exibe o resultado da exclusão
                    MessageBox.Show(resultMessage);
                }
            }
            else
            {
                MessageBox.Show("Please select at least one order to delete.");
            }
        }


        private bool programmaticSelection = false;
        private void tabPage1_Click(object sender, EventArgs e)
        {


            // Impede que a aba 'tabPage1' seja selecionada ao clicar
            if (tabControlPesquisarClientes.SelectedTab == tabPage1)
            {
                // Cancela a seleção da aba (recoloca a aba anterior selecionada)
                tabControlPesquisarClientes.SelectedTab = null;

                // Exibe uma mensagem, se desejado
                MessageBox.Show("Esta aba está desativada para seleção manual.");
            }
        }
    }
}
#endregion
#endregion