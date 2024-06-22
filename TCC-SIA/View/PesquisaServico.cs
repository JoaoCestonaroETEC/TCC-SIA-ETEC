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

            #region Carrega as informações gerais dos serviços
            //Criação do objeto NpgsqlDataReader servico e controleServico
            controleServico cServico = new controleServico();
            NpgsqlDataReader servico = cServico.pesquisaServico(textBoxPesquisar.Text);

            //Apaga as colunas da datagridview
            dataGridViewPesquisar.Columns.Clear();

            //Definindo a quant. de colunas que a grid terá
            dataGridViewPesquisar.ColumnCount = servico.FieldCount;

            //Definindo três colunas na DataGridView para exibir as descrições
            dataGridViewPesquisar.ColumnCount = 3;
            dataGridViewPesquisar.Columns[0].Name = "Id";
            dataGridViewPesquisar.Columns[1].Name = "Nome";
            dataGridViewPesquisar.Columns[2].Name = "Valor";

            //Adicionando as descrições dos serviços
            while (servico.Read())
            {
                string idServico = servico["IDSERVICO"].ToString();
                string nomeServico = servico["NOMESERVICO"].ToString();
                string valorServico = servico["VALORSERVICO"].ToString();
                dataGridViewPesquisar.Rows.Add(idServico, nomeServico, valorServico);
            }
            #endregion
        }
        #endregion

        #region Pesquisar serviço
        //Evento de pesquisar serviço
        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            //Criação do objeto NpgsqlDataReader servico e controleServico
            controleServico cServico = new controleServico();
            NpgsqlDataReader servico = cServico.pesquisaServico(textBoxPesquisar.Text);

            //Apaga as colunas da datagridview
            dataGridViewPesquisar.Columns.Clear();

            //Definindo a quant. de colunas que a grid terá
            dataGridViewPesquisar.ColumnCount = servico.FieldCount;

            //Definindo três colunas na DataGridView para exibir as descrições
            dataGridViewPesquisar.ColumnCount = 3;
            dataGridViewPesquisar.Columns[0].Name = "Id";
            dataGridViewPesquisar.Columns[1].Name = "Nome";
            dataGridViewPesquisar.Columns[2].Name = "Valor";

            //Adicionando as descrições dos serviços
            while (servico.Read())
            {
                string idServico = servico["IDSERVICO"].ToString();
                string nomeServico = servico["NOMESERVICO"].ToString();
                string valorServico = servico["VALORSERVICO"].ToString();
                dataGridViewPesquisar.Rows.Add(idServico, nomeServico, valorServico);
            }
        }
        #endregion
    }
}
