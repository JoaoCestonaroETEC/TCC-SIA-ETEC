﻿using Npgsql;
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
            #endregion

            cbSexo.Items.AddRange(new string[]
           {
               "Masculino",
               "Feminino",
               "Outro"
           });

            #region Carrega as informações gerais dos clientes
            // Criação do objeto NpgsqlDataReader cliente e ControleVeiculo
            controleCliente cCliente = new controleCliente();
            NpgsqlDataReader cliente = cCliente.pesquisarCliente(textBoxPesquisar.Text);

            //Apaga as colunas da datagridview
            dataGridViewPesquisar.Columns.Clear();

            //Definindo a quant. de colunas que a grid terá
            dataGridViewPesquisar.ColumnCount = cliente.FieldCount;

            //Definindo doze colunas na DataGridView para exibir as caracteristícas dos clientes
            dataGridViewPesquisar.ColumnCount = 13;
            dataGridViewPesquisar.Columns[0].Name = "Id";
            dataGridViewPesquisar.Columns[1].Name = "Cpf";
            dataGridViewPesquisar.Columns[2].Name = "Nome";
            dataGridViewPesquisar.Columns[3].Name = "Email";
            dataGridViewPesquisar.Columns[4].Name = "DataNasc";
            dataGridViewPesquisar.Columns[5].Name = "Sexo";
            dataGridViewPesquisar.Columns[6].Name = "Telefone";
            dataGridViewPesquisar.Columns[7].Name = "NumeroCasa";
            dataGridViewPesquisar.Columns[8].Name = "Rua";
            dataGridViewPesquisar.Columns[9].Name = "Cidade";
            dataGridViewPesquisar.Columns[10].Name = "Cep";
            dataGridViewPesquisar.Columns[11].Name = "Bairro";
            dataGridViewPesquisar.Columns[12].Name = "Estado";

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

                dataGridViewPesquisar.Rows.Add(idCliente, cpfCliente, nomeCliente, emailCliente, dataNasc, sexo, telefone, numCasa, rua, cidade, cep, bairro, estado);
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
            NpgsqlDataReader cliente = cCliente.pesquisarCliente(textBoxPesquisar.Text);

            //Apaga as colunas da datagridview
            dataGridViewPesquisar.Columns.Clear();

            //Definindo a quant. de colunas que a grid terá
            dataGridViewPesquisar.ColumnCount = cliente.FieldCount;

            //Definindo doze colunas na DataGridView para exibir as caracteristícas dos clientes
            dataGridViewPesquisar.ColumnCount = 13;
            dataGridViewPesquisar.Columns[0].Name = "Id";
            dataGridViewPesquisar.Columns[1].Name = "Cpf";
            dataGridViewPesquisar.Columns[2].Name = "Nome";
            dataGridViewPesquisar.Columns[3].Name = "Email";
            dataGridViewPesquisar.Columns[4].Name = "DataNasc";
            dataGridViewPesquisar.Columns[5].Name = "Sexo";
            dataGridViewPesquisar.Columns[6].Name = "Telefone";
            dataGridViewPesquisar.Columns[7].Name = "NumeroCasa";
            dataGridViewPesquisar.Columns[8].Name = "Rua";
            dataGridViewPesquisar.Columns[9].Name = "Cidade";
            dataGridViewPesquisar.Columns[10].Name = "Cep";
            dataGridViewPesquisar.Columns[11].Name = "Bairro";
            dataGridViewPesquisar.Columns[12].Name = "Estado";

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

                dataGridViewPesquisar.Rows.Add(idCliente, cpfCliente, nomeCliente, emailCliente, dataNasc, sexo, telefone, numCasa, rua, cidade, cep, bairro, estado);
            }
            #endregion
        }
        #endregion

        private void AtualizarCliente(object sender, EventArgs e)
        {
            if (dataGridViewPesquisar.SelectedRows.Count > 0)
            {
                DialogResult res = MessageBox.Show("Deseja atualizar este registro?", "Atualização de registro",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (res == DialogResult.OK)
                {
                    maskedID.Text = dataGridViewPesquisar.CurrentRow.Cells[0].Value.ToString();
                    maskedCPF.Text = dataGridViewPesquisar.CurrentRow.Cells[1].Value.ToString();
                    txbNome.Text = dataGridViewPesquisar.CurrentRow.Cells[2].Value.ToString();
                    txbEmail.Text = dataGridViewPesquisar.CurrentRow.Cells[3].Value.ToString();
                    dtpNasc.Value = Convert.ToDateTime(dataGridViewPesquisar.CurrentRow.Cells[4].Value.ToString());
                    cbSexo.SelectedIndex = cbSexo.FindString(dataGridViewPesquisar.CurrentRow.Cells[5].Value.ToString());
                    maskTelefone.Text = dataGridViewPesquisar.CurrentRow.Cells[6].Value.ToString();
                    maskNumero.Text = dataGridViewPesquisar.CurrentRow.Cells[7].Value.ToString();
                    txbRua.Text = dataGridViewPesquisar.CurrentRow.Cells[8].Value.ToString();
                    txbCidade.Text = dataGridViewPesquisar.CurrentRow.Cells[9].Value.ToString();
                    maskCep.Text = dataGridViewPesquisar.CurrentRow.Cells[10].Value.ToString();
                    txbBairro.Text = dataGridViewPesquisar.CurrentRow.Cells[11].Value.ToString();
                    cbEstado.SelectedIndex = cbEstado.FindStringExact(dataGridViewPesquisar.CurrentRow.Cells[12].Value.ToString());
                    tabControl1.SelectedTab = tabPage2;

                }
            }
        }

        private void btnSalvarA_Click(object sender, EventArgs e)
        {
            controleCliente cCliente = new controleCliente();

            Cliente mCliente = new Cliente();

            //Definindo os valores nos atributos

            //Faz uma verificação para tentar enviar o valor para o atributo, se existiver vazia ele envia vazia sem dar erro

            mCliente.setIDCliente(Convert.ToInt32(maskedID.Text));
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
        }

        private void buttonPesquisar_Click_1(object sender, EventArgs e)
        {
            #region Carrega as informações gerais dos clientes
            // Criação do objeto NpgsqlDataReader cliente e ControleVeiculo
            controleCliente cCliente = new controleCliente();
            NpgsqlDataReader cliente = cCliente.pesquisarCliente(textBoxPesquisar.Text);

            //Apaga as colunas da datagridview
            dataGridViewPesquisar.Columns.Clear();

            //Definindo a quant. de colunas que a grid terá
            dataGridViewPesquisar.ColumnCount = cliente.FieldCount;

            //Definindo doze colunas na DataGridView para exibir as caracteristícas dos clientes
            dataGridViewPesquisar.ColumnCount = 13;
            dataGridViewPesquisar.Columns[0].Name = "Id";
            dataGridViewPesquisar.Columns[1].Name = "Cpf";
            dataGridViewPesquisar.Columns[2].Name = "Nome";
            dataGridViewPesquisar.Columns[3].Name = "Email";
            dataGridViewPesquisar.Columns[4].Name = "DataNasc";
            dataGridViewPesquisar.Columns[5].Name = "Sexo";
            dataGridViewPesquisar.Columns[6].Name = "Telefone";
            dataGridViewPesquisar.Columns[7].Name = "NumeroCasa";
            dataGridViewPesquisar.Columns[8].Name = "Rua";
            dataGridViewPesquisar.Columns[9].Name = "Cidade";
            dataGridViewPesquisar.Columns[10].Name = "Cep";
            dataGridViewPesquisar.Columns[11].Name = "Bairro";
            dataGridViewPesquisar.Columns[12].Name = "Estado";

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

                dataGridViewPesquisar.Rows.Add(idCliente, cpfCliente, nomeCliente, emailCliente, dataNasc, sexo, telefone, numCasa, rua, cidade, cep, bairro, estado);
            }
            #endregion
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
           

        }
    }
}
