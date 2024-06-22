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
using Npgsql;

namespace TCC_SIA.View
{
    public partial class PesquisaMarca : Form
    {
        public PesquisaMarca()
        {
            InitializeComponent();
        }

        #region Pesquisar marca
        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            controleMarca cMarca = new controleMarca();

            NpgsqlDataReader marca = cMarca.pesquisaMarca(textBoxPesquisar.Text);

            // Apaga as colunas da datagridview
            dataGridViewPesquisar.Columns.Clear();

            // Definindo a quant. de colunas que a grid terá
            dataGridViewPesquisar.ColumnCount = marca.FieldCount;

            // Definindo os cabeçalhos das colunas
            for (int i = 0; i < marca.FieldCount; i++)
            {
                dataGridViewPesquisar.Columns[i].Name = marca.GetName(i);
            }

            // Aqui criamos um vetor para representar uma linha da consulta(registro)
            string[] linha = new string[marca.FieldCount];

            while (marca.Read())
            {
                for (int i = 0; i < marca.FieldCount; i++)
                {
                    linha[i] = marca.GetValue(i).ToString();
                }

                dataGridViewPesquisar.Rows.Add(linha);
            }
        }
        #endregion
    }
}
