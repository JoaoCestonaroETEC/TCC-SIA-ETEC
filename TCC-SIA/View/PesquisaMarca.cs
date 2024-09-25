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
            listarTipos();
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

        #region Listar tipos
        public void listarTipos()
        {
            controleMarca cMarca = new controleMarca();
            // Recebe os dados da consulta e salva no dataReader (Tipo)
            NpgsqlDataReader marca = cMarca.listarNovasMarca();

            // Criar e configurar o DataTable
            DataTable dtTipo = new DataTable();

            // Definir as colunas do DataTable
            dtTipo.Columns.Add("ID", typeof(int));  // Supondo que o ID seja um int
            dtTipo.Columns.Add("TIPOMARCA", typeof(string)); // Supondo que o tipo seja uma string

            // Adicionar itens pré-configurados
            dtTipo.Rows.Add(-1, "Peças Automotívas");
            dtTipo.Rows.Add(-2, "Óleos lubrificantes");
            dtTipo.Rows.Add(-3, "Pneus");
            dtTipo.Rows.Add(-4, "Ferramentas e Equipamentos para oficinas");
            dtTipo.Rows.Add(-5, "Veiculos");

            // Carregar os dados do NpgsqlDataReader
            dtTipo.Load(marca);

            // Preencher a ComboBox com os dados do DataTable
            comboBoxTipo.DataSource = dtTipo;

            // Define qual coluna do DataTable que será exibida (nome da coluna)
            comboBoxTipo.DisplayMember = "TIPOMARCA";
        }
        #endregion

        private void comboBoxTipo_Validating(object sender, CancelEventArgs e)
        {
            System.Windows.Forms.ComboBox comboBox = sender as System.Windows.Forms.ComboBox;
            string fornecedorDigitado = comboBox.Text;

            // Verifica se o valor digitado já existe na lista de itens da ComboBox
            bool fornecedorExiste = comboBox.Items.Cast<System.Data.DataRowView>()
                                       .Any(item => item["TIPOMARCA"].ToString()
                                       .Equals(fornecedorDigitado, StringComparison.OrdinalIgnoreCase));

            if (!fornecedorExiste && !string.IsNullOrEmpty(fornecedorDigitado))
            {
                // Exibe a mensagem com o aviso
                DialogResult result = MessageBox.Show("Aviso! Tipo não registrado",
                                                      "Aviso!",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Ação para adicionar um novo fornecedor (sem adicionar o valor na ComboBox diretamente)
                    MessageBox.Show("Para criar um novo tipo deve se criar uma marca primeiro!",
                                    "Ação Necessária",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                else
                {
                    // Limpa o texto da ComboBox
                    comboBox.Text = string.Empty;
                }
            }
        }

        private void comboBoxTipo_Click(object sender, EventArgs e)
        {
            listarTipos();
        }
    }
}
