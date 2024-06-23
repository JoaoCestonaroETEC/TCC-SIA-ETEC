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

            #region Carrega as informações gerais das marcas
            //Criação do objeto NpgsqlDataReader marcaVeiculo, marcaPeca e controleMarca
            controleMarca cMarca = new controleMarca();
            NpgsqlDataReader marcaVeiculo = cMarca.pesquisaMarcaVeiculo(textBoxPesquisar.Text);
            NpgsqlDataReader marcaPeca = cMarca.pesquisaMarcaPeca(textBoxPesquisar.Text);

            //Apaga as colunas da DataGridView
            dataGridViewPesquisar.Columns.Clear();

            //Definindo três colunas na DataGridView para exibir as marcas e descrições
            dataGridViewPesquisar.ColumnCount = 3;
            dataGridViewPesquisar.Columns[0].Name = "Id";
            dataGridViewPesquisar.Columns[1].Name = "Marca";
            dataGridViewPesquisar.Columns[2].Name = "Descrição";

            //Adicionando as marcas e descrições de veículos
            while (marcaVeiculo.Read())
            {
                string idMarcaVeiculo = marcaVeiculo["IDMARCAVEICULO"].ToString();
                string nomeMarcaVeiculo = marcaVeiculo["NOMEMARCAVEICULO"].ToString();
                string descMarcaVeiculo = marcaVeiculo["DESCMARCAVEICULO"].ToString();
                dataGridViewPesquisar.Rows.Add(idMarcaVeiculo, nomeMarcaVeiculo, descMarcaVeiculo);
            }

            //Adicionando as marcas e descrições de peças
            while (marcaPeca.Read())
            {
                string idMarcaPeca = marcaPeca["IDMARCAPECA"].ToString();
                string nomeMarcaPeca = marcaPeca["NOMEMARCAPECA"].ToString();
                string descMarcaPeca = marcaPeca["DESCMARCAPECA"].ToString();
                dataGridViewPesquisar.Rows.Add(idMarcaPeca, nomeMarcaPeca, descMarcaPeca);
            }
            #endregion
        }
        #endregion

        #region Pesquisar marcas

        //Evento de pesquisar marcas
        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            //Faz a verificação das checkBoxs
            if (checkBoxVeiculo.Checked &&
                !checkBoxPeca.Checked)
            {
                //Criação do objeto NpgsqlDataReader marcaVeiculo e controleMarca
                controleMarca cMarca = new controleMarca();
                NpgsqlDataReader marcaVeiculo = cMarca.listarMarcaVeiculo();

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
                    string idMarcaVeiculo = marcaVeiculo["IDMARCAPECA"].ToString();
                    string nomeMarcaPeca = marcaVeiculo["NOMEMARCAPECA"].ToString();
                    string descMarcaPeca = marcaVeiculo["DESCMARCAPECA"].ToString();
                    dataGridViewPesquisar.Rows.Add(idMarcaVeiculo, nomeMarcaPeca, descMarcaPeca);
                }
            }

            //Faz a verificação das checkBoxs
            if (checkBoxPeca.Checked &&
                !checkBoxVeiculo.Checked)
            {
                //Criação do objeto NpgsqlDataReader marcaVeiculo e controleMarca
                controleMarca cMarca = new controleMarca();
                NpgsqlDataReader marcaPeca = cMarca.listarMarcaPeca();

                //Apaga as colunas da DataGridView
                dataGridViewPesquisar.Columns.Clear();

                //Definindo três colunas na DataGridView para exibir as marcas e descrições
                dataGridViewPesquisar.ColumnCount = 3;
                dataGridViewPesquisar.Columns[0].Name = "Id";
                dataGridViewPesquisar.Columns[1].Name = "Marca";
                dataGridViewPesquisar.Columns[2].Name = "Descrição";

                //Adicionando as marcas e descrições de peças
                while (marcaPeca.Read())
                {
                    string idMarcaPeca = marcaPeca["IDMARCAPECA"].ToString();
                    string nomeMarcaPeca = marcaPeca["NOMEMARCAPECA"].ToString();
                    string descMarcaPeca = marcaPeca["DESCMARCAPECA"].ToString();
                    dataGridViewPesquisar.Rows.Add(idMarcaPeca, nomeMarcaPeca, descMarcaPeca);
                }
            }

            //Faz a verificação das checkBoxs
            if (checkBoxVeiculo.Checked && checkBoxPeca.Checked ||
                !checkBoxVeiculo.Checked && checkBoxPeca.Checked)
            {
                //Criação do objeto NpgsqlDataReader marcaVeiculo, marcaPeca e controleMarca
                controleMarca cMarca = new controleMarca();
                NpgsqlDataReader marcaVeiculo = cMarca.pesquisaMarcaVeiculo(textBoxPesquisar.Text);
                NpgsqlDataReader marcaPeca = cMarca.pesquisaMarcaPeca(textBoxPesquisar.Text);

                //Apaga as colunas da DataGridView
                dataGridViewPesquisar.Columns.Clear();

                //Definindo três colunas na DataGridView para exibir as marcas e descrições
                dataGridViewPesquisar.ColumnCount = 3;
                dataGridViewPesquisar.Columns[0].Name = "Id";
                dataGridViewPesquisar.Columns[1].Name = "Marca";
                dataGridViewPesquisar.Columns[2].Name = "Descrição";

                //Adicionando as marcas e descrições de veículos
                while (marcaVeiculo.Read())
                {
                    string idMarcaVeiculo = marcaVeiculo["IDMARCAPECA"].ToString();
                    string nomeMarcaPeca = marcaVeiculo["NOMEMARCAPECA"].ToString();
                    string descMarcaPeca = marcaVeiculo["DESCMARCAPECA"].ToString();
                    dataGridViewPesquisar.Rows.Add(idMarcaVeiculo, nomeMarcaPeca, descMarcaPeca);
                }

                //Adicionando as marcas e descrições de peças
                while (marcaPeca.Read())
                {
                    string idMarcaPeca = marcaPeca["IDMARCAPECA"].ToString();
                    string nomeMarcaPeca = marcaPeca["NOMEMARCAPECA"].ToString();
                    string descMarcaPeca = marcaPeca["DESCMARCAPECA"].ToString();
                    dataGridViewPesquisar.Rows.Add(idMarcaPeca, nomeMarcaPeca, descMarcaPeca);
                }
            }
        }
        #endregion
    }
}
