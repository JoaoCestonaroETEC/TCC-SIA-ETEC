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
using TCC_SIA.Model;

namespace TCC_SIA.View
{
    public partial class PesquisaMarca : Form
    {
        #region Inicializa o formulário
        public PesquisaMarca()
        {
            InitializeComponent();

        }
        #endregion

        #region Pesquisar marcas

        //Evento de pesquisar marcas
        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            {
                //Criação do objeto NpgsqlDataReader marcaVeiculo e controleMarca
                controleMarca cMarca = new controleMarca();
                NpgsqlDataReader marcaVeiculo = cMarca.listarMarca();

                //Apaga as colunas da datagridview
                dataGridViewPesquisar.Columns.Clear();

                //Definindo a quant. de colunas que a grid terá
                dataGridViewPesquisar.ColumnCount = marcaVeiculo.FieldCount;

                //Definindo três colunas na DataGridView para exibir as marcas e descrições
                dataGridViewPesquisar.ColumnCount = 3;
                dataGridViewPesquisar.Columns[0].Name = "Id";
                dataGridViewPesquisar.Columns[1].Name = "Marca";
                dataGridViewPesquisar.Columns[2].Name = "Descrição";

                //Adicionando as marcas e descrições de peças
                while (marcaVeiculo.Read())
                {
                    string idMarcaVeiculo = marcaVeiculo["IDMARCA"].ToString();
                    string nomeMarcaPeca = marcaVeiculo["NOMEMARCA"].ToString();
                    string descMarcaPeca = marcaVeiculo["DESCMARCA"].ToString();
                    dataGridViewPesquisar.Rows.Add(idMarcaVeiculo, nomeMarcaPeca, descMarcaPeca);
                }
            }
        }
        #endregion

        #region Atualiza marcas

        #endregion

   
    }
}
