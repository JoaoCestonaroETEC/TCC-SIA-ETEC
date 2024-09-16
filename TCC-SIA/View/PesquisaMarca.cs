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
using System.Text.RegularExpressions;

namespace TCC_SIA.View
{
    public partial class PesquisaMarca : Form
    {
        #region Inicializa o formulário
        public PesquisaMarca()
        {
            InitializeComponent();
            //Criação do objeto NpgsqlDataReader marcaVeiculo e controleMarca
            controleMarca cMarca = new controleMarca();
            NpgsqlDataReader marca = cMarca.listarMarca();

            //Apaga as colunas da datagridview
            dataGridViewPesquisar.Columns.Clear();

            //Definindo a quant. de colunas que a grid terá
            dataGridViewPesquisar.ColumnCount = marca.FieldCount;

            //Definindo quatro colunas na DataGridView para exibir as marcas e descrições
            dataGridViewPesquisar.ColumnCount = 4;
            dataGridViewPesquisar.Columns[0].Name = "Id";
            dataGridViewPesquisar.Columns[1].Name = "Marca";
            dataGridViewPesquisar.Columns[2].Name = "Descrição";
            dataGridViewPesquisar.Columns[3].Name = "Tipo de marca";

            //Adicionando as marcas e descrições de peças
            while (marca.Read())
            {
                string idMarcaVeiculo = marca["IDMARCA"].ToString();
                string nomeMarcaPeca = marca["NOMEMARCA"].ToString();
                string descMarcaPeca = marca["DESCMARCA"].ToString();
                string tipoMarcaPeca = marca["TIPOMARCA"].ToString();
                dataGridViewPesquisar.Rows.Add(idMarcaVeiculo, nomeMarcaPeca, descMarcaPeca, tipoMarcaPeca);
            }
        }
        #endregion

        #region Pesquisar marcas

        //Evento de pesquisar marcas
        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            {
                //Criação do objeto NpgsqlDataReader marcaVeiculo e controleMarca
                controleMarca cMarca = new controleMarca();
                NpgsqlDataReader marca = cMarca.pesquisaMarca(textBoxPesquisar.Text, comboBoxTipo.Text);

                //Apaga as colunas da datagridview
                dataGridViewPesquisar.Columns.Clear();

                //Definindo a quant. de colunas que a grid terá
                dataGridViewPesquisar.ColumnCount = marca.FieldCount;

                //Definindo quatro colunas na DataGridView para exibir as marcas e descrições
                dataGridViewPesquisar.ColumnCount = 4;
                dataGridViewPesquisar.Columns[0].Name = "Id";
                dataGridViewPesquisar.Columns[1].Name = "Marca";
                dataGridViewPesquisar.Columns[2].Name = "Descrição";
                dataGridViewPesquisar.Columns[3].Name = "Tipo de marca";

                //Adicionando as marcas e descrições de peças
                while (marca.Read())
                {
                    string idMarcaVeiculo = marca["IDMARCA"].ToString();
                    string nomeMarcaPeca = marca["NOMEMARCA"].ToString();
                    string descMarcaPeca = marca["DESCMARCA"].ToString();
                    string tipoMarcaPeca = marca["TIPOMARCA"].ToString();
                    dataGridViewPesquisar.Rows.Add(idMarcaVeiculo, nomeMarcaPeca, descMarcaPeca, tipoMarcaPeca);
                }
            }
        }
        #endregion

        #region Atualiza marcas

        #endregion

   
    }
}
