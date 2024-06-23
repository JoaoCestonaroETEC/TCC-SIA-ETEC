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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TCC_SIA.View
{
    public partial class PesquisaCliente : Form
    {
        #region Inicializa o formulário
        public PesquisaCliente()
        {
            InitializeComponent();

            #region Carrega as informações gerais dos clientes
            // Criação do objeto NpgsqlDataReader cliente e ControleVeiculo
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
                    /*TODO: redefinir máscara de acordo com o preço de venda */

                    maskedTextBoxCPF.Text = dataGridViewPesquisar.CurrentRow.Cells[1].Value.ToString();
                    textBoxNome.Text = dataGridViewPesquisar.CurrentRow.Cells[2].Value.ToString();
                    maskedTextBoxTelefone.Text = dataGridViewPesquisar.CurrentRow.Cells[3].Value.ToString();

                    tabControl1.SelectedTab = tabPage2;
                }
            }

        }
    }

}
