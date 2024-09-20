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
            dataGridViewPesquisar.ColumnCount = 15;
            dataGridViewPesquisar.Columns[0].Name = "Id";
            dataGridViewPesquisar.Columns[1].Name = "Cliente";
            dataGridViewPesquisar.Columns[2].Name = "Marca";
            dataGridViewPesquisar.Columns[3].Name = "Nome";
            dataGridViewPesquisar.Columns[4].Name = "Tipo";
            dataGridViewPesquisar.Columns[5].Name = "Cor";
            dataGridViewPesquisar.Columns[6].Name = "Placa";
            dataGridViewPesquisar.Columns[7].Name = "Modelo";
            dataGridViewPesquisar.Columns[8].Name = "Chassi";
            dataGridViewPesquisar.Columns[9].Name = "Ano de fabricação";
            dataGridViewPesquisar.Columns[10].Name = "Quilometragem (KM)";
            dataGridViewPesquisar.Columns[11].Name = "ID do Motor";
            dataGridViewPesquisar.Columns[12].Name = "Combustível";
            dataGridViewPesquisar.Columns[13].Name = "Data";
            dataGridViewPesquisar.Columns[14].Name = "Seguro";

            //Adicionando as descrições de peças
            while (veiculo.Read())
            {
                string idVeiculo = veiculo["IDVEICULO"].ToString();
                string idCliente = veiculo["IDCLIENTE"].ToString();
                string idMarca = veiculo["IDMARCA"].ToString();
                string nomeVeiculo = veiculo["NOMEVEICULO"].ToString();
                string tipoVeiculo = veiculo["TIPOVEICULO"].ToString();
                string corVeiculo = veiculo["CORVEICULO"].ToString();
                string placaVeiculo = veiculo["PLACAVEICULO"].ToString();
                string modeloVeiculo = veiculo["MODELOVEICULO"].ToString();
                string chassi = veiculo["CHASSI"].ToString();
                string anoFab = veiculo["ANOFAB"].ToString();
                string quilometragem = veiculo["QUILOMETRAGEM"].ToString();
                string motor = veiculo["MOTOR"].ToString();
                string combustivel = veiculo["COMBUSTIVEL"].ToString();
                string data = veiculo["DATA"].ToString();
                string seguro = veiculo["SEGURO"].ToString();

                //Consulta o nome da marca pelo id
                string marca = cVeiculo.pesquisaMarcaVeiculoPorId(idMarca);
                string cliente = cVeiculo.pesquisaClienteVeiculoPorId(idCliente);

                dataGridViewPesquisar.Rows.Add(idVeiculo, cliente, marca, nomeVeiculo, tipoVeiculo, corVeiculo, placaVeiculo, modeloVeiculo, chassi, anoFab, quilometragem, motor, combustivel, data, seguro);
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
            dataGridViewPesquisar.ColumnCount = 15;
            dataGridViewPesquisar.Columns[0].Name = "Id";
            dataGridViewPesquisar.Columns[1].Name = "Cliente";
            dataGridViewPesquisar.Columns[2].Name = "Marca";
            dataGridViewPesquisar.Columns[3].Name = "Nome";
            dataGridViewPesquisar.Columns[4].Name = "Tipo";
            dataGridViewPesquisar.Columns[5].Name = "Cor";
            dataGridViewPesquisar.Columns[6].Name = "Placa";
            dataGridViewPesquisar.Columns[7].Name = "Modelo";
            dataGridViewPesquisar.Columns[8].Name = "Chassi";
            dataGridViewPesquisar.Columns[9].Name = "Ano de fabricação";
            dataGridViewPesquisar.Columns[10].Name = "Quilometragem (KM)";
            dataGridViewPesquisar.Columns[11].Name = "ID do Motor";
            dataGridViewPesquisar.Columns[12].Name = "Combustível";
            dataGridViewPesquisar.Columns[13].Name = "Data";
            dataGridViewPesquisar.Columns[14].Name = "Seguro";

            //Adicionando as descrições de peças
            while (veiculo.Read())
            {
                string idVeiculo = veiculo["IDVEICULO"].ToString();
                string idCliente = veiculo["IDCLIENTE"].ToString();
                string idMarca = veiculo["IDMARCA"].ToString();
                string nomeVeiculo = veiculo["NOMEVEICULO"].ToString();
                string tipoVeiculo = veiculo["TIPOVEICULO"].ToString();
                string corVeiculo = veiculo["CORVEICULO"].ToString();
                string placaVeiculo = veiculo["PLACAVEICULO"].ToString();
                string modeloVeiculo = veiculo["MODELOVEICULO"].ToString();
                string chassi = veiculo["CHASSI"].ToString();
                string anoFab = veiculo["ANOFAB"].ToString();
                string quilometragem = veiculo["QUILOMETRAGEM"].ToString();
                string motor = veiculo["MOTOR"].ToString();
                string combustivel = veiculo["COMBUSTIVEL"].ToString();
                string data = veiculo["DATA"].ToString();
                string seguro = veiculo["SEGURO"].ToString();

                //Consulta o nome da marca pelo id
                string marca = cVeiculo.pesquisaMarcaVeiculoPorId(idMarca);
                string cliente = cVeiculo.pesquisaClienteVeiculoPorId(idCliente);

                dataGridViewPesquisar.Rows.Add(idVeiculo, cliente, marca, nomeVeiculo, tipoVeiculo, corVeiculo, placaVeiculo, modeloVeiculo, chassi, anoFab, quilometragem, motor, combustivel, data, seguro);
            }
        }
        #endregion
    }
}
