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

namespace TCC_SIA.View
{
    public partial class PesquisaVeiculo : Form
    {
        #region Inicializa o formulário
        public PesquisaVeiculo()
        {
            InitializeComponent();
        }
        #endregion

        #region Pesquisar veículo
        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            controleVeiculo cVeiculo = new controleVeiculo();

            NpgsqlDataReader veiculo = cVeiculo.pesquisarVeiculo(textBoxPesquisar.Text);

            // Apaga as colunas da datagridview
            dataGridViewPesquisar.Columns.Clear();

            // Definindo a quant. de colunas que a grid terá
            dataGridViewPesquisar.ColumnCount = veiculo.FieldCount;

            // Definindo os cabeçalhos das colunas
            for (int i = 0; i < veiculo.FieldCount; i++)
            {
                dataGridViewPesquisar.Columns[i].Name = veiculo.GetName(i);
            }

            // Aqui criamos um vetor para representar uma linha da consulta(registro)
            string[] linha = new string[veiculo.FieldCount];

            while (veiculo.Read())
            {
                for (int i = 0; i < veiculo.FieldCount; i++)
                {
                    linha[i] = veiculo.GetValue(i).ToString();
                }

                dataGridViewPesquisar.Rows.Add(linha);
            }
        }
        #endregion
    }
}
