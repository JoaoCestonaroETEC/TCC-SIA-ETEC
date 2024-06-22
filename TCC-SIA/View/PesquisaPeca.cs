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
using TCC_SIA.Model;

namespace TCC_SIA.View
{
    public partial class PesquisaPeca : Form
    {
        #region Inicializa o formulário
        public PesquisaPeca()
        {
            InitializeComponent();

            #region Carrega as informações gerais das peças
            //Criação do objeto NpgsqlDataReader peca e controlePeca
            controlePeca cPeca = new controlePeca();
            NpgsqlDataReader peca = cPeca.pesquisaPeca(textBoxPesquisar.Text);

            //Apaga as colunas da datagridview
            dataGridViewPesquisar.Columns.Clear();

            //Definindo a quant. de colunas que a grid terá
            dataGridViewPesquisar.ColumnCount = peca.FieldCount;

            //Definindo seis colunas na DataGridView para exibir as descrições
            dataGridViewPesquisar.ColumnCount = 6;
            dataGridViewPesquisar.Columns[0].Name = "Id";
            dataGridViewPesquisar.Columns[1].Name = "Marca";
            dataGridViewPesquisar.Columns[2].Name = "Nome";
            dataGridViewPesquisar.Columns[3].Name = "Tipo";
            dataGridViewPesquisar.Columns[4].Name = "Valor";
            dataGridViewPesquisar.Columns[5].Name = "Quantidade";

            //Adicionando as descrições de peças
            while (peca.Read())
            {
                string idPeca = peca["IDPECA"].ToString();
                string idMarca = peca["IDMARCAPECA"].ToString();
                string nomePeca = peca["NOMEPECA"].ToString();
                string tipoPeca = peca["TIPOPECA"].ToString();
                string valorPeca = peca["VALORPECA"].ToString();
                string quantPeca = peca["QUANTPECA"].ToString();

                //Consulta o nome da marca pelo id
                string marca = cPeca.pesquisaMarcaPecaPorId(idMarca);

                dataGridViewPesquisar.Rows.Add(idPeca, marca, nomePeca, tipoPeca, valorPeca, quantPeca);
            }
            #endregion
        }
        #endregion

        #region Pesquisar peça
        //Evento de pesquisar peça
        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            //Criação do objeto NpgsqlDataReader peca e controlePeca
            controlePeca cPeca = new controlePeca();
            NpgsqlDataReader peca = cPeca.pesquisaPeca(textBoxPesquisar.Text);

            //Apaga as colunas da datagridview
            dataGridViewPesquisar.Columns.Clear();

            //Definindo a quant. de colunas que a grid terá
            dataGridViewPesquisar.ColumnCount = peca.FieldCount;

            //Definindo seis colunas na DataGridView para exibir as descrições
            dataGridViewPesquisar.ColumnCount = 6;
            dataGridViewPesquisar.Columns[0].Name = "Id";
            dataGridViewPesquisar.Columns[1].Name = "Marca";
            dataGridViewPesquisar.Columns[2].Name = "Nome";
            dataGridViewPesquisar.Columns[3].Name = "Tipo";
            dataGridViewPesquisar.Columns[4].Name = "Valor";
            dataGridViewPesquisar.Columns[5].Name = "Quantidade";

            //Adicionando as descrições de peças
            while (peca.Read())
            {
                string idPeca = peca["IDPECA"].ToString();
                string idMarca = peca["IDMARCAPECA"].ToString();
                string nomePeca = peca["NOMEPECA"].ToString();
                string tipoPeca = peca["TIPOPECA"].ToString();
                string valorPeca = peca["VALORPECA"].ToString();
                string quantPeca = peca["QUANTPECA"].ToString();

                //Consulta o nome da marca pelo id
                string marca = cPeca.pesquisaMarcaPecaPorId(idMarca);

                dataGridViewPesquisar.Rows.Add(idPeca, marca, nomePeca, tipoPeca, valorPeca, quantPeca);
            }
        }
        #endregion
    }
}