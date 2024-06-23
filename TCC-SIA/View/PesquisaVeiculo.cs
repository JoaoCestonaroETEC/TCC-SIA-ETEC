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
    public partial class PesquisaVeiculo : Form
    {
        #region Inicializa o formulário
        public PesquisaVeiculo()
        {
            InitializeComponent();

            #region Carrega as informações gerais das dos veículos
            //Criação do objeto NpgsqlDataReader veiculo e controleVeiculo
            controleVeiculo cVeiculo = new controleVeiculo();
            NpgsqlDataReader veiculo = cVeiculo.listaVeiculo();

            //Apaga as colunas da datagridview
            dataGridViewPesquisar.Columns.Clear();

            //Definindo a quant. de colunas que a grid terá
            dataGridViewPesquisar.ColumnCount = veiculo.FieldCount;

            //Definindo seis colunas na DataGridView para exibir as descrições
            dataGridViewPesquisar.ColumnCount = 6;
            dataGridViewPesquisar.Columns[0].Name = "Id";
            dataGridViewPesquisar.Columns[1].Name = "Cpf do cliente";
            dataGridViewPesquisar.Columns[2].Name = "Marca";
            dataGridViewPesquisar.Columns[3].Name = "Nome";
            dataGridViewPesquisar.Columns[4].Name = "Tipo";
            dataGridViewPesquisar.Columns[5].Name = "Placa";

            //Adicionando as descrições de peças
            while (veiculo.Read())
            {
                string idVeiculo = veiculo["IDVEICULO"].ToString();
                string cpfCliente = veiculo["CPFCLIENTE"].ToString();
                string idMarca = veiculo["IDMARCAVEICULO"].ToString();
                string nomeVeiculo = veiculo["NOMEVEICULO"].ToString();
                string tipoVeiculo = veiculo["TIPOVEICULO"].ToString();
                string placaVeiculo = veiculo["PLACAVEICULO"].ToString();

                //Consulta o nome da marca pelo id
                string marca = cVeiculo.pesquisaMarcaVeiculoPorId(idMarca);

                dataGridViewPesquisar.Rows.Add(idVeiculo, cpfCliente, marca, nomeVeiculo, tipoVeiculo, placaVeiculo);
            }
            #endregion
        }
        #endregion

        #region Pesquisar veículo
        //Evento de pesquisar veículo
        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            //Criação do objeto NpgsqlDataReader veiculo e controleVeiculo 
            controleVeiculo cVeiculo = new controleVeiculo();
            NpgsqlDataReader veiculo = cVeiculo.pesquisaVeiculo(textBoxPesquisar.Text);

            //Apaga as colunas da datagridview
            dataGridViewPesquisar.Columns.Clear();

            //Definindo a quant. de colunas que a grid terá
            dataGridViewPesquisar.ColumnCount = veiculo.FieldCount;

            //Definindo seis colunas na DataGridView para exibir as descrições
            dataGridViewPesquisar.ColumnCount = 6;
            dataGridViewPesquisar.Columns[0].Name = "Id";
            dataGridViewPesquisar.Columns[1].Name = "Cpf do cliente";
            dataGridViewPesquisar.Columns[2].Name = "Marca";
            dataGridViewPesquisar.Columns[3].Name = "Nome";
            dataGridViewPesquisar.Columns[4].Name = "Tipo";
            dataGridViewPesquisar.Columns[5].Name = "Placa";

            //Adicionando as descrições de peças
            while (veiculo.Read())
            {
                string idVeiculo = veiculo["IDVEICULO"].ToString();
                string cpfCliente = veiculo["CPFCLIENTE"].ToString();
                string idMarca = veiculo["IDMARCAVEICULO"].ToString();
                string nomeVeiculo = veiculo["NOMEVEICULO"].ToString();
                string tipoVeiculo = veiculo["TIPOVEICULO"].ToString();
                string placaVeiculo = veiculo["PLACAVEICULO"].ToString();

                //Consulta o nome da marca pelo id

                //Consulta o nome da marca pelo id
                string marca = cVeiculo.pesquisaMarcaVeiculoPorId(idMarca);

                dataGridViewPesquisar.Rows.Add(idVeiculo, cpfCliente, marca, nomeVeiculo, tipoVeiculo, placaVeiculo);
            }
        }
        #endregion
    }
}
