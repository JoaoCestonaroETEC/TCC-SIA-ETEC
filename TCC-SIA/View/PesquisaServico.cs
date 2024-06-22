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
    public partial class PesquisaServico : Form
    {
        #region Inicializa o formulário
        public PesquisaServico()
        {
            InitializeComponent();
        }
        #endregion

        #region Pesquisar serviço
        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            controleServico cServico = new controleServico();

            NpgsqlDataReader servico = cServico.pesquisaServico(textBoxPesquisar.Text);

            // Apaga as colunas da datagridview
            dataGridViewPesquisar.Columns.Clear();

            // Definindo a quant. de colunas que a grid terá
            dataGridViewPesquisar.ColumnCount = servico.FieldCount;

            // Definindo os cabeçalhos das colunas
            for (int i = 0; i < servico.FieldCount; i++)
            {
                dataGridViewPesquisar.Columns[i].Name = servico.GetName(i);
            }

            // Aqui criamos um vetor para representar uma linha da consulta(registro)
            string[] linha = new string[servico.FieldCount];

            while (servico.Read())
            {
                for (int i = 0; i < servico.FieldCount; i++)
                {
                    linha[i] = servico.GetValue(i).ToString();
                }

                dataGridViewPesquisar.Rows.Add(linha);
            }
        }
        #endregion

        private void dataGridViewPesquisar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
