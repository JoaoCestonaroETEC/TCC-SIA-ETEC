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
            listarTipo();
            listarMarca();

            #region Carrega as informações gerais das peças
            //Criação do objeto NpgsqlDataReader peca e controlePeca
            controlePeca cPeca = new controlePeca();
            NpgsqlDataReader peca = cPeca.listaPeca();

            //Apaga as colunas da datagridview
            dataGridViewPesquisar.Columns.Clear();

            //Definindo a quant. de colunas que a grid terá
            dataGridViewPesquisar.ColumnCount = peca.FieldCount;

            //Definindo seis colunas na DataGridView para exibir as descrições
            dataGridViewPesquisar.ColumnCount = 10;
            dataGridViewPesquisar.Columns[0].Name = "Id";
            dataGridViewPesquisar.Columns[1].Name = "Marca";
            dataGridViewPesquisar.Columns[2].Name = "Nome";
            dataGridViewPesquisar.Columns[3].Name = "Tipo";
            dataGridViewPesquisar.Columns[4].Name = "Valor";
            dataGridViewPesquisar.Columns[5].Name = "Quantidade";
            dataGridViewPesquisar.Columns[6].Name = "Garantia";
            dataGridViewPesquisar.Columns[7].Name = "Unidade";
            dataGridViewPesquisar.Columns[8].Name = "Data de Aquisição";
            dataGridViewPesquisar.Columns[9].Name = "Fornecedor";


            //Adicionando as descrições de peças
            while (peca.Read())
            {
                string idPeca = peca["IDPECA"].ToString();
                string idMarca = peca["IDMARCA"].ToString();
                string nomePeca = peca["NOMEPECA"].ToString();
                string tipoPeca = peca["TIPOPECA"].ToString();
                string valorPeca = peca["VALORPECA"].ToString();
                string quantPeca = peca["QUANTPECA"].ToString();
                string garantiaPeca = peca["GARANTIAPECA"].ToString();
                string unidade = peca["UNIDADE"].ToString();
                string dataAquis = peca["DATA_AQUISICAO"].ToString();
                string fornecedor = peca["FORNECEDOR"].ToString();


                //Consulta o nome da marca pelo id
                string marca = cPeca.pesquisaMarcaPecaPorId(idMarca);

                dataGridViewPesquisar.Rows.Add(idPeca, marca, nomePeca, tipoPeca, valorPeca, quantPeca, garantiaPeca, unidade, dataAquis, fornecedor);
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
            dataGridViewPesquisar.ColumnCount = 7;
            dataGridViewPesquisar.Columns[0].Name = "Id";
            dataGridViewPesquisar.Columns[1].Name = "Marca";
            dataGridViewPesquisar.Columns[2].Name = "Nome";
            dataGridViewPesquisar.Columns[3].Name = "Tipo";
            dataGridViewPesquisar.Columns[4].Name = "Valor";
            dataGridViewPesquisar.Columns[5].Name = "Quantidade";
            dataGridViewPesquisar.Columns[6].Name = "Garantia";


            //Adicionando as descrições de peças
            while (peca.Read())
            {
                string idPeca = peca["IDPECA"].ToString();
                string idMarca = peca["IDMARCA"].ToString();
                string nomePeca = peca["NOMEPECA"].ToString();
                string tipoPeca = peca["TIPOPECA"].ToString();
                string valorPeca = peca["VALORPECA"].ToString();
                string quantPeca = peca["QUANTPECA"].ToString();
                string garantiaPeca = peca["GARANTIAPECA"].ToString();
                string unidade = peca["UNIDADE"].ToString();
                string dataAquis = peca["DATA_AQUISICAO"].ToString();
                string fornecedor = peca["FORNECEDOR"].ToString();


                //Consulta o nome da marca pelo id
                string marca = cPeca.pesquisaMarcaPecaPorId(idMarca);

                dataGridViewPesquisar.Rows.Add(idPeca, marca, nomePeca, tipoPeca, valorPeca, quantPeca, garantiaPeca, unidade, dataAquis, fornecedor);
            }
        }
        #endregion

        #region Listar marca
        public void listarMarca()
        {
            controleMarca cMarca = new controleMarca();
            //Recebe os dados da consulta e salva no dataReader (Tipo)
            NpgsqlDataReader marca = cMarca.listarMarca();

            //Converter o dataReader em DataTable
            DataTable dtMarca = new DataTable();
            dtMarca.Load(marca);

            //Preencher a combobox com os dados do DataTable
            comboBoxMarca.DataSource = dtMarca;

            //Define qual coluna do DataTable que será exibida (nome da coluna)
            comboBoxMarca.DisplayMember = "NOMEMARCA";

            //Define qual o valor da linha será utilizado ao selecionar um valor
            comboBoxMarca.ValueMember = "IDMARCA";

        }
        #endregion

        #region Listar Tipo
        public void listarTipo()
        {
            controlePeca cPeca = new controlePeca();
            // Recebe os dados da consulta e salva no dataReader (Tipo)
            NpgsqlDataReader peca = cPeca.listaTipo();

            // Criar e configurar o DataTable
            DataTable dtTipo = new DataTable();

            // Definir as colunas do DataTable
            dtTipo.Columns.Add("ID", typeof(int));  // Supondo que o ID seja um int
            dtTipo.Columns.Add("TIPOPECA", typeof(string)); // Supondo que o tipo seja uma string

            // Adicionar itens pré-configurados
            dtTipo.Rows.Add(-1, "Motor");
            dtTipo.Rows.Add(-2, "Suspensão e Direção");
            dtTipo.Rows.Add(-3, "Freio");
            dtTipo.Rows.Add(-4, "Transmissão");
            dtTipo.Rows.Add(-5, "Elétrica");
            dtTipo.Rows.Add(-6, "Arrefecimento");
            dtTipo.Rows.Add(-7, "Escape");
            dtTipo.Rows.Add(-8, "Estética e Acabamento");
            dtTipo.Rows.Add(-9, "Combustível");
            dtTipo.Rows.Add(-10, "Pneumáticos");
            dtTipo.Rows.Add(-11, "Outro");

            // Carregar os dados do NpgsqlDataReader
            dtTipo.Load(peca);

            // Preencher a ComboBox com os dados do DataTable
            comboBoxTipo.DataSource = dtTipo;

            // Define qual coluna do DataTable que será exibida (nome da coluna)
            comboBoxTipo.DisplayMember = "TIPOPECA";
        }
        #endregion


        private void btnSalvarA_Click(object sender, EventArgs e)
        {
            controlePeca cPeca = new controlePeca();

            Peca mPeca = new Peca();

            //Definindo os valores nos atributos

            //Faz uma verificação para tentar enviar o valor para o atributo, se existiver vazia ele envia vazia sem dar erro

            mPeca.setIdPeca(Convert.ToInt32(maskedTextBoxID.Text));
            mPeca.setNomePeca(textBoxNome.Text);
            mPeca.setTipoPeca(comboBoxTipo.Text);
            mPeca.setDescPeca(richTextBoxDesc.Text);
            mPeca.setValorPeca(Convert.ToInt32(maskedTextBoxValor.Text));
            mPeca.setQuantPeca(Convert.ToInt32(numericUpDownQuant.Text));
            mPeca.setGarantiaPeca(Convert.ToDateTime(dateTimePickerGarantia.Text));

            //Chamada ao método de cadastro no ControleCliente
            string res = cPeca.atualizaPeca(mPeca);

            //Mostra o resultado
            MessageBox.Show(res);
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (dataGridViewPesquisar.SelectedRows.Count > 0)
            {
                DialogResult res = MessageBox.Show("Deseja atualizar este registro?", "Atualização de registro",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (res == DialogResult.OK)
                {
                    maskedTextBoxID.Text = dataGridViewPesquisar.CurrentRow.Cells[0].Value.ToString();
                    textBoxNome.Text = dataGridViewPesquisar.CurrentRow.Cells[1].Value.ToString();
                    comboBoxTipo.Text = dataGridViewPesquisar.CurrentRow.Cells[2].Value.ToString();
                    richTextBoxDesc.Text = dataGridViewPesquisar.CurrentRow.Cells[3].Value.ToString();
                    maskedTextBoxValor.Text = dataGridViewPesquisar.CurrentRow.Cells[4].Value.ToString();
                    numericUpDownQuant.Text = dataGridViewPesquisar.CurrentRow.Cells[5].Value.ToString();
                    dateTimePickerGarantia.Value = Convert.ToDateTime(dataGridViewPesquisar.CurrentRow.Cells[6].Value.ToString());
                    tabControl1.SelectedTab = tabPage2;

                }
            }
        }
    }
}