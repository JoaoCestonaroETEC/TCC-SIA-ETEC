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
    public partial class PesquisarCliente : Form
    {
        #region Inicializa o formulário
        public PesquisarCliente()
        {
            InitializeComponent();
        }
        #endregion

        #region Pesquisar cliente
        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            controleCliente cCliente = new controleCliente();

            NpgsqlDataReader clientes = cCliente.pesquisarCliente(textBoxPesquisar.Text);

            // Apaga as colunas da datagridview
            dataGridViewPesquisar.Columns.Clear();

            // Definindo a quant. de colunas que a grid terá
            dataGridViewPesquisar.ColumnCount = clientes.FieldCount;

            // Definindo os cabeçalhos das colunas
            for (int i = 0; i < clientes.FieldCount; i++)
            {
                dataGridViewPesquisar.Columns[i].Name = clientes.GetName(i);
            }

            // Aqui criamos um vetor para representar uma linha da consulta(registro)
            string[] linha = new string[clientes.FieldCount];

            while (clientes.Read())
            {
                for (int i = 0; i < clientes.FieldCount; i++)
                {
                    linha[i] = clientes.GetValue(i).ToString();
                }

                dataGridViewPesquisar.Rows.Add(linha);
            }

        }
        #endregion
    }
}
