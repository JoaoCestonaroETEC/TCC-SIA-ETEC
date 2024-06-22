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
        }
        #endregion

        #region Pesquisar cliente
        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            controleCliente cCliente = new controleCliente();

            NpgsqlDataReader cliente = cCliente.pesquisarCliente(textBoxPesquisar.Text);

            // Apaga as colunas da datagridview
            dataGridViewPesquisar.Columns.Clear();

            // Definindo a quant. de colunas que a grid terá
            dataGridViewPesquisar.ColumnCount = cliente.FieldCount;

            // Definindo os cabeçalhos das colunas
            for (int i = 0; i < cliente.FieldCount; i++)
            {
                dataGridViewPesquisar.Columns[i].Name = cliente.GetName(i);
            }

            // Aqui criamos um vetor para representar uma linha da consulta(registro)
            string[] linha = new string[cliente.FieldCount];

            while (cliente.Read())
            {
                for (int i = 0; i < cliente.FieldCount; i++)
                {
                    linha[i] = cliente.GetValue(i).ToString();
                }

                dataGridViewPesquisar.Rows.Add(linha);
            }

        }
        #endregion

        private void textBoxPesquisar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
