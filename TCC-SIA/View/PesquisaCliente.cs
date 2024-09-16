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
            NpgsqlDataReader clienteF = cCliente.pesquisarClienteF(textBoxPesquisarF.Text);

            //Apaga as colunas da datagridview
            dataGridViewPesquisarF.Columns.Clear();

            //Definindo a quant. de colunas que a grid terá
            dataGridViewPesquisarF.ColumnCount = clienteF.FieldCount;

            //Definindo doze colunas na DataGridView para exibir as caracteristícas dos clientes
            dataGridViewPesquisarF.ColumnCount = 15;
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

            //Aqui criamos um vetor para representar uma linha da consulta(registro)
            string[] linhaF = new string[clienteF.FieldCount];

            //Adicionando as descrições dos clientes
            while (clienteF.Read())
            {
                string idCliente = clienteF["IDCLIENTE"].ToString();
                string cpfCliente = clienteF["CPFCLIENTE"].ToString();
                string nomeCliente = clienteF["NOMECLIENTE"].ToString();
                string emailCliente = clienteF["EMAILCLIENTE"].ToString();
                string dataNasc = clienteF["DATANASC_CLIENTE"].ToString();
                string sexo = clienteF["SEXO"].ToString();
                string telefone = clienteF["TELEFONE"].ToString();
                string numCasa = clienteF["NUMERO"].ToString();
                string rua = clienteF["RUA"].ToString();
                string cidade = clienteF["CIDADE"].ToString();
                string cep = clienteF["CEP"].ToString();
                string bairro = clienteF["BAIRRO"].ToString();
                string estado = clienteF["ESTADO"].ToString();
                string status = clienteF["STATUS"].ToString();
                string data = clienteF["DATA"].ToString();

                dataGridViewPesquisarF.Rows.Add(idCliente, cpfCliente, nomeCliente, emailCliente, dataNasc, sexo, telefone, numCasa, rua, cidade, cep, bairro, estado, status, data);
            }

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
        #endregion

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

        private void AtualizarCliente(object sender, EventArgs e)
        {
            /*if (dataGridViewPesquisarF.SelectedRows.Count > 0)
            {
                DialogResult res = MessageBox.Show("Deseja atualizar este registro?", "Atualização de registro",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (res == DialogResult.OK)
                {
                    maskedID.Text = dataGridViewPesquisarF.CurrentRow.Cells[0].Value.ToString();
                    maskedCPF.Text = dataGridViewPesquisarF.CurrentRow.Cells[1].Value.ToString();
                    txbNome.Text = dataGridViewPesquisarF.CurrentRow.Cells[2].Value.ToString();
                    txbEmail.Text = dataGridViewPesquisarF.CurrentRow.Cells[3].Value.ToString();
                    dtpNasc.Value = Convert.ToDateTime(dataGridViewPesquisarF.CurrentRow.Cells[4].Value.ToString());
                    cbSexo.SelectedIndex = cbSexo.FindString(dataGridViewPesquisarF.CurrentRow.Cells[5].Value.ToString());
                    maskTelefone.Text = dataGridViewPesquisarF.CurrentRow.Cells[6].Value.ToString();
                    maskNumero.Text = dataGridViewPesquisarF.CurrentRow.Cells[7].Value.ToString();
                    txbRua.Text = dataGridViewPesquisarF.CurrentRow.Cells[8].Value.ToString();
                    txbCidade.Text = dataGridViewPesquisarF.CurrentRow.Cells[9].Value.ToString();
                    maskCep.Text = dataGridViewPesquisarF.CurrentRow.Cells[10].Value.ToString();
                    txbBairro.Text = dataGridViewPesquisarF.CurrentRow.Cells[11].Value.ToString();
                    cbEstado.SelectedIndex = cbEstado.FindStringExact(dataGridViewPesquisarF.CurrentRow.Cells[12].Value.ToString());
                    tabControlPesquisarClientes.SelectedTab = tabControlPesquisarClienteJ;

                }
            }*/
        }

        private void btnSalvarA_Click(object sender, EventArgs e)
        {
            /*controleCliente cCliente = new controleCliente();

            Cliente mCliente = new Cliente();

            //Definindo os valores nos atributos

            //Faz uma verificação para tentar enviar o valor para o atributo, se existiver vazia ele envia vazia sem dar erro

            mCliente.setIdCliente(Convert.ToInt32(maskedID.Text));
            mCliente.setCpfCliente(maskedCPF.Text);
            mCliente.setNomeCliente(txbNome.Text);
            mCliente.setEmailCliente(txbEmail.Text);
            mCliente.setDataNascCliente(Convert.ToDateTime(dtpNasc.Text));
            mCliente.setSexo(cbSexo.Text);
            mCliente.setTelefone(maskTelefone.Text);

            //Faz uma verificação para tentar enviar o valor para o atributo, se existiver vazia ele envia vazia sem dar erro
            long numero;
            if (long.TryParse(maskNumero.Text, out numero))
            {
                mCliente.setNumero(numero);
            }

            mCliente.setRua(txbRua.Text);
            mCliente.setCidade(txbCidade.Text);

            //Faz uma verificação para tentar enviar o valor para o atributo, se existiver vazia ele envia vazia sem dar erro
            long cep;
            if (long.TryParse(maskCep.Text, out cep))
            {
                mCliente.setCep(cep);
            }

            //bool cpfValido = ValidaCPF.IsCpf(maskedCPF.Text);

            mCliente.setBairro(txbBairro.Text);
            mCliente.setUf(cbEstado.Text);

            //Chamada ao método de cadastro no ControleCliente
            string res = cCliente.atualizaCliente(mCliente);

            //Mostra o resultado
            MessageBox.Show(res);
            */
        }


        private void btnDeletar_Click(object sender, EventArgs e)
        {


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
            dataGridViewPesquisarJ.ColumnCount = 16;
            dataGridViewPesquisarJ.Columns[0].Name = "Id";
            dataGridViewPesquisarJ.Columns[1].Name = "Cnpj";
            dataGridViewPesquisarJ.Columns[2].Name = "Nome";
            dataGridViewPesquisarJ.Columns[3].Name = "Email";
            dataGridViewPesquisarJ.Columns[6].Name = "Telefone";
            dataGridViewPesquisarJ.Columns[7].Name = "Número";
            dataGridViewPesquisarJ.Columns[8].Name = "Rua";
            dataGridViewPesquisarJ.Columns[9].Name = "Cidade";
            dataGridViewPesquisarJ.Columns[10].Name = "Cep";
            dataGridViewPesquisarJ.Columns[11].Name = "Bairro";
            dataGridViewPesquisarJ.Columns[12].Name = "Estado";
            dataGridViewPesquisarJ.Columns[13].Name = "Status";
            dataGridViewPesquisarJ.Columns[14].Name = "Data";
            dataGridViewPesquisarJ.Columns[15].Name = "Razão Júdicial";

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
    }
}
