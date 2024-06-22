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
    public partial class PesquisaPeca : Form
    {
        #region Inicializa o formulário
        public PesquisaPeca()
        {
            InitializeComponent();
        }
        #endregion

        #region Pesquisar peça
        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            controlePeca cPeca = new controlePeca();

            NpgsqlDataReader peca = cPeca.pesquisaPeca(textBoxPesquisar.Text);

            // Apaga as colunas da datagridview
            dataGridViewPesquisar.Columns.Clear();

            // Definindo a quant. de colunas que a grid terá
            dataGridViewPesquisar.ColumnCount = peca.FieldCount;

            // Definindo os cabeçalhos das colunas
            for (int i = 0; i < peca.FieldCount; i++)
            {
                dataGridViewPesquisar.Columns[i].Name = peca.GetName(i);
            }

            // Aqui criamos um vetor para representar uma linha da consulta(registro)
            string[] linha = new string[peca.FieldCount];

            while (peca.Read())
            {
                for (int i = 0; i < peca.FieldCount; i++)
                {
                    linha[i] = peca.GetValue(i).ToString();
                }

                dataGridViewPesquisar.Rows.Add(linha);
            }
        }
        #endregion
    }
}
