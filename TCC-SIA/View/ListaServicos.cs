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
    public partial class ListaServicos : Form
    {
        public ListaServicos()
        {
            InitializeComponent();
        }

        public void CarregarDadosServicos(long idPedido)
        {
            #region Carrega os dados de pesquisa de serviços
            // Criação do objeto NpgsqlDataReader servico e controleServico
            controlePedido cMarca = new controlePedido();
            NpgsqlDataReader marca = cMarca.listarServico(idPedido);

            // Apaga as colunas da datagridview
            dataGridViewPesquisar.Columns.Clear();

            // Desabilitar a adição automática de novas linhas
            dataGridViewPesquisar.AllowUserToAddRows = false;

            // Definindo a quantidade de colunas que a grid terá
            dataGridViewPesquisar.ColumnCount = 8;

            // Definindo as colunas na DataGridView para exibir as descrições
            dataGridViewPesquisar.Columns[0].Name = "Id Pedido";
            dataGridViewPesquisar.Columns[0].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisar.Columns[1].Name = "Id Servico";
            dataGridViewPesquisar.Columns[1].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisar.Columns[2].Name = "Nome";
            dataGridViewPesquisar.Columns[2].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisar.Columns[3].Name = "Descrição";
            dataGridViewPesquisar.Columns[3].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisar.Columns[4].Name = "Valor";
            dataGridViewPesquisar.Columns[4].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisar.Columns[5].Name = "Funcionario";
            dataGridViewPesquisar.Columns[5].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisar.Columns[6].Name = "Garantia";
            dataGridViewPesquisar.Columns[6].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisar.Columns[7].Name = "Quant. De Vezes";
            dataGridViewPesquisar.Columns[7].ReadOnly = true; // Definindo como somente leitura

            // Adicionando as descrições dos serviços
            while (marca.Read())
            {
                string idPedido1 = marca["IDPEDIDO"].ToString();
                string idPeca = marca["IDSERVICO"].ToString();
                string nomeMarca = marca["NOMESERVICO"].ToString();
                string nomePeca = marca["DESCSERVICO"].ToString();
                string tipoPeca = marca["VALORSERVICO"].ToString();
                string descPeca = marca["FUNCIONARIO"].ToString();
                string valorPeca = marca["GARANTIASERVICO"].ToString();
                string quantPeca = marca["QUANTVEZES"].ToString();

                // Criando a nova linha manualmente
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridViewPesquisar); // Define a grid para onde a linha vai

                // Preenchendo a linha com os valores
                row.Cells[0].Value = idPedido1;
                row.Cells[1].Value = idPeca;
                row.Cells[2].Value = nomeMarca;
                row.Cells[3].Value = nomePeca;
                row.Cells[4].Value = tipoPeca;
                row.Cells[5].Value = descPeca;
                row.Cells[6].Value = valorPeca;
                row.Cells[7].Value = quantPeca;


                dataGridViewPesquisar.Rows.Add(row);

            }
            #endregion
        }
    }
}
