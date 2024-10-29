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
    public partial class ListaPecas : Form
    {
        public ListaPecas()
        {
            InitializeComponent();
        }

        public void CarregarDadosPecas(long idPedido)
        {
            #region Carrega os dados de pesquisa de serviços
            // Criação do objeto NpgsqlDataReader servico e controleServico
            controlePedido cMarca = new controlePedido();
            NpgsqlDataReader marca = cMarca.listarPecas(idPedido);

            // Apaga as colunas da datagridview
            dataGridViewPesquisar.Columns.Clear();

            // Desabilitar a adição automática de novas linhas
            dataGridViewPesquisar.AllowUserToAddRows = false;

            // Definindo a quantidade de colunas que a grid terá
            dataGridViewPesquisar.ColumnCount = 13;

            // Definindo as colunas na DataGridView para exibir as descrições
            dataGridViewPesquisar.Columns[0].Name = "Id Pedido";
            dataGridViewPesquisar.Columns[0].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisar.Columns[1].Name = "Id Peça";
            dataGridViewPesquisar.Columns[1].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisar.Columns[2].Name = "Marca";
            dataGridViewPesquisar.Columns[2].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisar.Columns[3].Name = "Nome";
            dataGridViewPesquisar.Columns[3].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisar.Columns[4].Name = "Tipo";
            dataGridViewPesquisar.Columns[4].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisar.Columns[5].Name = "Descrição";
            dataGridViewPesquisar.Columns[5].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisar.Columns[6].Name = "Valor";
            dataGridViewPesquisar.Columns[6].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisar.Columns[7].Name = "Quantidade";
            dataGridViewPesquisar.Columns[7].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisar.Columns[8].Name = "Garantia";
            dataGridViewPesquisar.Columns[8].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisar.Columns[9].Name = "Unidade";
            dataGridViewPesquisar.Columns[9].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisar.Columns[10].Name = "Data de Aquisição";
            dataGridViewPesquisar.Columns[10].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisar.Columns[11].Name = "Fonecedor";
            dataGridViewPesquisar.Columns[11].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisar.Columns[12].Name = "Quant. De Vezes";
            dataGridViewPesquisar.Columns[12].ReadOnly = true; // Definindo como somente leitura

            // Adicionando as descrições dos serviços
            while (marca.Read())
            {
                string idPedido1 = marca["IDPEDIDO"].ToString();
                string idPeca = marca["IDPECA"].ToString();
                string nomeMarca = marca["NOMEMARCA"].ToString();
                string nomePeca = marca["NOMEPECA"].ToString();
                string tipoPeca = marca["TIPOPECA"].ToString();
                string descPeca = marca["DESCPECA"].ToString();
                string valorPeca = marca["VALORPECA"].ToString();
                string quantPeca = marca["QUANTPECA"].ToString();
                string garantiaPeca = marca["GARANTIAPECA"].ToString();
                string unidade = marca["UNIDADE"].ToString();
                string dataAquisicao = marca["DATA_AQUISICAO"].ToString();
                string fornecedor = marca["FORNECEDOR"].ToString();
                string quantVezes = marca["QUANTVEZES"].ToString();

                // Criando a nova linha manualmente
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridViewPesquisar); // Define a grid para onde a linha vai

                // Preenchendo a linha com os valores
                row.Cells[0].Value = marca["IDPEDIDO"].ToString();
                row.Cells[1].Value = marca["IDPECA"].ToString();
                row.Cells[2].Value = marca["NOMEMARCA"].ToString();
                row.Cells[3].Value = marca["NOMEPECA"].ToString();
                row.Cells[4].Value = marca["TIPOPECA"].ToString();
                row.Cells[5].Value = marca["DESCPECA"].ToString();
                row.Cells[6].Value = marca["VALORPECA"].ToString();
                row.Cells[7].Value = marca["QUANTPECA"].ToString();
                row.Cells[8].Value = marca["GARANTIAPECA"].ToString();
                row.Cells[9].Value = marca["UNIDADE"].ToString();
                row.Cells[10].Value = marca["DATA_AQUISICAO"].ToString();
                row.Cells[11].Value = marca["FORNECEDOR"].ToString();
                row.Cells[12].Value = marca["QUANTVEZES"].ToString();

                dataGridViewPesquisar.Rows.Add(row);
                
            }
            #endregion
        }
    }
}
