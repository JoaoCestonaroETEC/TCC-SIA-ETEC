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
    public partial class CadastroPedido : Form
    {
        #region Inicializa o formulário
        public CadastroPedido()
        {
            InitializeComponent();

            #region Carrega os dados nas comboBoxs
            listarCliente();
            listarPeca();
            listarServico();
            listarVeiculo();

            //Criação do objeto NpgsqlDataReader servico e controleServico
            controleServico cServico = new controleServico();
            NpgsqlDataReader servico = cServico.pesquisaServico(comboBoxServico.Text);

            //Apaga as colunas da datagridview
            dataGridViewServico.Columns.Clear();

            //Definindo a quant. de colunas que a grid terá
            dataGridViewServico.ColumnCount = servico.FieldCount;

            //Definindo três colunas na DataGridView para exibir as descrições
            dataGridViewServico.ColumnCount = 3;
            dataGridViewServico.Columns[0].Name = "Id";
            dataGridViewServico.Columns[1].Name = "Nome";
            dataGridViewServico.Columns[2].Name = "Valor";

            //Adicionando as descrições dos serviços
            while (servico.Read())
            {
                string idServico = servico["IDSERVICO"].ToString();
                string nomeServico = servico["NOMESERVICO"].ToString();
                string valorServico = servico["VALORSERVICO"].ToString();
                dataGridViewServico.Rows.Add(idServico, nomeServico, valorServico);
            }
            #endregion 

            #region Carrega os dados de pesquisa de peças

            //Criação do objeto NpgsqlDataReader peca e controlePeca
            controlePeca cPeca = new controlePeca();
            NpgsqlDataReader peca = cPeca.pesquisaPeca(comboBoxPeca.Text);

            //Apaga as colunas da datagridview
            dataGridViewPeca.Columns.Clear();

            //Definindo a quant. de colunas que a grid terá
            dataGridViewPeca.ColumnCount = peca.FieldCount;

            //Definindo seis colunas na DataGridView para exibir as descrições
            dataGridViewPeca.ColumnCount = 6;
            dataGridViewPeca.Columns[0].Name = "Marca";
            dataGridViewPeca.Columns[1].Name = "Nome";
            dataGridViewPeca.Columns[2].Name = "Tipo";
            dataGridViewPeca.Columns[3].Name = "Valor";
            dataGridViewPeca.Columns[4].Name = "Quantidade";
            dataGridViewPeca.Columns[5].Name = "Garantia";

            //Adicionando as descrições de peças
            while (peca.Read())
            {
                string idMarca = peca["IDMARCAPECA"].ToString();
                string nomePeca = peca["NOMEPECA"].ToString();
                string tipoPeca = peca["TIPOPECA"].ToString();
                string valorPeca = peca["VALORPECA"].ToString();
                string quantPeca = peca["QUANTPECA"].ToString();
                string garantiaPeca = peca["GARANTIAPECA"].ToString();

                //Consulta o nome da marca pelo id
                string marca = cPeca.pesquisaMarcaPecaPorId(idMarca);

                dataGridViewPeca.Rows.Add(marca, nomePeca, tipoPeca, valorPeca, quantPeca, garantiaPeca);
            }
            #endregion

        }
        #endregion

        #region Cadastrar pedido
        //Evento de cadastrar pedido
        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            // Verifica se os campos obrigatórios foram preenchidos
            if (string.IsNullOrWhiteSpace(comboBoxCliente.Text) ||
                string.IsNullOrWhiteSpace(comboBoxVeiculo.Text) ||
                string.IsNullOrWhiteSpace(maskedTextBoxValorTotal.Text) ||
                string.IsNullOrWhiteSpace(maskedTextBoxValorTotalServicos.Text))

            {
                MessageBox.Show("Insira pelo menos o cliente, o veículo, a data de início, e os valores");
                return;
            }

            // Criação do objeto Pedido e controlePedido
            Pedido mPedido = new Pedido();
            Pedido_Peca mPedido_Peca = new Pedido_Peca();
            Servico mServico = new Servico();
            controlePedido cPedido = new controlePedido();

            //Definindo os valores nos atributos
            mPedido.setCpfCliente(Convert.ToInt64(comboBoxCliente.SelectedValue));
            mPedido.setIdVeiculo(Convert.ToInt64(comboBoxVeiculo.SelectedValue));
            mPedido.setDataInicio(Convert.ToDateTime(dateTimePickerDataInicio.Text));
            mPedido.setDataFim(Convert.ToDateTime(dateTimePickerDataInicio.Text));

            mPedido.setObservacao(richTextBoxObs.Text);

            //Faz uma verificação para tentar enviar o valor para o atributo, se existiver vazia ele envia vazia sem dar erro
            long valor;
            if (long.TryParse(maskedTextBoxValorTotal.Text, out valor))
            {
                mPedido.setValorTotalPeca(valor);
            }

            //Faz uma verificação para tentar enviar o valor para o atributo, se existiver vazia ele envia vazia sem dar erro
            long valorPeca;
            if (long.TryParse(maskedTextBoxValorTotalPecas.Text, out valorPeca))
            {
                mPedido.setValorTotalPeca(valorPeca);
            }

            //Faz uma verificação para tentar enviar o valor para o atributo, se existiver vazia ele envia vazia sem dar erro
            long valorServico;
            if (long.TryParse(maskedTextBoxValorTotal.Text, out valorServico))
            {
                mPedido.setValorTotalServico(valorServico);
            }

            List<Pedido_Peca> pecas = ExtrairPecasDataGridView(dataGridViewPeca);
            List<Pedido_Peca> servicos = ExtrairPecasDataGridView(dataGridViewServico);

            //Chamada ao método de cadastro no controlePedido
            string res = cPedido.cadastroPedido(mPedido, mPedido_Peca, mServico);

            //Mostra o resultado
            MessageBox.Show(res);
        }
        #endregion

        #region Listar cliente
        public void listarCliente()
        {
            controleCliente cCliente = new controleCliente();
            //Recebe os dados da consulta e salva no dataReader (Tipo)
            NpgsqlDataReader cliente = cCliente.listarCliente();

            //Converter o dataReader em DataTable
            DataTable dtCliente = new DataTable();
            dtCliente.Load(cliente);

            //Preencher a combobox com os dados do DataTable
            comboBoxCliente.DataSource = dtCliente;

            //Define qual coluna do DataTable que será exibida (nome da coluna)
            comboBoxCliente.DisplayMember = "NOMECLIENTE";

            //Define qual o valor da linha será utilizado ao selecionar um valor
            comboBoxCliente.ValueMember = "CPFCLIENTE";
        }
        #endregion

        #region Listar veículo
        public void listarVeiculo()
        {
            controleVeiculo cVeiculo = new controleVeiculo();
            //Recebe os dados da consulta e salva no dataReader (Tipo)
            NpgsqlDataReader veiculo = cVeiculo.listarVeiculo();

            //Converter o dataReader em DataTable
            DataTable dtVeiculo = new DataTable();
            dtVeiculo.Load(veiculo);

            //Preencher a combobox com os dados do DataTable
            comboBoxVeiculo.DataSource = dtVeiculo;

            //Define qual coluna do DataTable que será exibida (nome da coluna)
            comboBoxVeiculo.DisplayMember = "NOMEVEICULO";

            //Define qual o valor da linha será utilizado ao selecionar um valor
            comboBoxVeiculo.ValueMember = "IDVEICULO";
        }
        #endregion

        #region Listar veículo por cliente
        public void listarVeiculoPorCliente()
        {
            //Criação do objeto NpgsqlDataReader veiculo e controleVeiculo
            controleVeiculo cVeiculo = new controleVeiculo();
            NpgsqlDataReader veiculo = cVeiculo.listarVeiculoPorCliente(Convert.ToString(comboBoxCliente.SelectedValue));

            //Converter o dataReader em DataTable
            DataTable dtVeiculo = new DataTable();
            dtVeiculo.Load(veiculo);

            //Preencher a combobox com os dados do DataTable
            comboBoxVeiculo.DataSource = dtVeiculo;

            //Define qual coluna do DataTable que será exibida (nome da coluna)
            comboBoxVeiculo.DisplayMember = "NOMEVEICULO";

            //Define qual o valor da linha será utilizado ao selecionar um valor
            comboBoxVeiculo.ValueMember = "IDVEICULO";

        }
        #endregion

        #region Listar peça
        public void listarPeca()
        {
            controlePeca cPeca = new controlePeca();
            //Recebe os dados da consulta e salva no dataReader (Tipo)
            NpgsqlDataReader peca = cPeca.listarPeca();

            //Converter o dataReader em DataTable
            DataTable dtPeca = new DataTable();
            dtPeca.Load(peca);

            //Preencher a combobox com os dados do DataTable
            comboBoxPeca.DataSource = dtPeca;

            //Define qual coluna do DataTable que será exibida (nome da coluna)
            comboBoxPeca.DisplayMember = "NOMEPECA";

            //Define qual o valor da linha será utilizado ao selecionar um valor
            comboBoxPeca.ValueMember = "IDPECA";
        }
        #endregion

        #region Listar serviço
        public void listarServico()
        {
            controleServico cServico = new controleServico();
            //Recebe os dados da consulta e salva no dataReader (Tipo)
            NpgsqlDataReader servico = cServico.listaServico();

            //Converter o dataReader em DataTable
            DataTable dtServico = new DataTable();
            dtServico.Load(servico);

            //Preencher a combobox com os dados do DataTable
            comboBoxServico.DataSource = dtServico;

            //Define qual coluna do DataTable que será exibida (nome da coluna)
            comboBoxServico.DisplayMember = "NOMESERVICO";

            //Define qual o valor da linha será utilizado ao selecionar um valor
            comboBoxServico.ValueMember = "IDSERVICO";
        }
        #endregion

        #region Pesquisar peça
        //Evento de pesquisar peça
        private void buttonPesquisarPeca_Click(object sender, EventArgs e)
        {
            //Criação do objeto NpgsqlDataReader peca e controlePeca
            controlePeca cPeca = new controlePeca();
            NpgsqlDataReader peca = cPeca.pesquisaPeca(comboBoxPeca.Text);

            //Apaga as colunas da datagridview
            dataGridViewPeca.Columns.Clear();

            //Definindo a quant. de colunas que a grid terá
            dataGridViewPeca.ColumnCount = peca.FieldCount;

            //Definindo seis colunas na DataGridView para exibir as descrições
            dataGridViewPeca.ColumnCount = 7;
            dataGridViewPeca.Columns[0].Name = "Marca";
            dataGridViewPeca.Columns[1].Name = "Nome";
            dataGridViewPeca.Columns[2].Name = "Tipo";
            dataGridViewPeca.Columns[3].Name = "Valor";
            dataGridViewPeca.Columns[4].Name = "Quantidade";
            dataGridViewPeca.Columns[5].Name = "Garantia";
            dataGridViewPeca.Columns[6].Name = "Descrição";

            //Adicionando as descrições de peças
            while (peca.Read())
            {
                string idMarca = peca["IDMARCAPECA"].ToString();
                string nomePeca = peca["NOMEPECA"].ToString();
                string tipoPeca = peca["TIPOPECA"].ToString();
                string valorPeca = peca["VALORPECA"].ToString();
                string quantPeca = peca["QUANTPECA"].ToString();
                string garantiaPeca = peca["GARANTIAPECA"].ToString();

                //Consulta o nome da marca pelo id
                string marca = cPeca.pesquisaMarcaPecaPorId(idMarca);

                dataGridViewPeca.Rows.Add(marca, nomePeca, tipoPeca, valorPeca, quantPeca, garantiaPeca);
            }
        }
        #endregion

        #region Pesquisar serviço
        //Evento de pesquisar serviço
        private void buttonPesquisarServico_Click(object sender, EventArgs e)
        {
            //Criação do objeto NpgsqlDataReader servico e controleServico
            controleServico cServico = new controleServico();
            NpgsqlDataReader servico = cServico.pesquisaServico(comboBoxServico.Text);

            //Apaga as colunas da datagridview
            dataGridViewServico.Columns.Clear();

            //Definindo a quant. de colunas que a grid terá
            dataGridViewServico.ColumnCount = servico.FieldCount;

            //Definindo três colunas na DataGridView para exibir as descrições
            dataGridViewServico.ColumnCount = 3;
            dataGridViewServico.Columns[0].Name = "Id";
            dataGridViewServico.Columns[1].Name = "Nome";
            dataGridViewServico.Columns[2].Name = "Valor";

            //Adicionando as descrições dos serviços
            while (servico.Read())
            {
                string idServico = servico["IDSERVICO"].ToString();
                string nomeServico = servico["NOMESERVICO"].ToString();
                string valorServico = servico["VALORSERVICO"].ToString();
                dataGridViewServico.Rows.Add(idServico, nomeServico, valorServico);
            }
        }
        #endregion

        #region Extrai as peças
        public List<Pedido_Peca> ExtrairPecasDataGridView(DataGridView dataGridView)
        {
            List<Pedido_Peca> Pecas = new List<Pedido_Peca>();
            controlePeca cPeca = new controlePeca();

            foreach (DataGridViewRow row in dataGridView.SelectedRows)
            {
                string nomePeca = row.Cells["Nome"].Value?.ToString();
                NpgsqlDataReader peca = cPeca.pesquisaPecaParaOPedido(nomePeca);

                if (peca != null)
                {
                    DataTable dtPecas = new DataTable();
                    dtPecas.Load(peca);

                    if (dtPecas.Rows.Count > 0)
                    {
                        Pedido_Peca pecas = new Pedido_Peca();

                        if (long.TryParse(dtPecas.Rows[0]["IDMARCAPECA"].ToString(), out long idNomeMarca))
                        {
                            pecas.setIdMarca(idNomeMarca);
                        }
                        string nomePecaVar = row.Cells["Nome"].Value?.ToString();
                        string tipoPecaVar = (row.Cells["Tipo"].Value?.ToString());

                       if (long.TryParse(row.Cells["Valor"].Value?.ToString(), out long valor))
                       {
                            pecas.setValorPeca(valor);
                       }

                       if (int.TryParse(row.Cells["Quantidade"].Value?.ToString(), out int quant))
                       {
                            pecas.setQuantPeca(quant);
                       }

                       string descPecaVar = (row.Cells["Descrição"].Value?.ToString());

                       if (DateTime.TryParse(row.Cells["Garantia"].Value?.ToString(), out DateTime garantia))
                       {
                            pecas.setGarantiaPeca(garantia);
                       }

                       pecas.setNomePeca(nomePecaVar);
                       pecas.setTipoPeca(tipoPecaVar);

                        Pecas.Add(pecas);

                    }

                    peca.Close();
                }
            }

            return Pecas;
        }
        #endregion

        #region Extrai os serviços
        public List<Servico> ExtrairServicosDataGridView(DataGridView dataGridView)
        {
            List<Servico> Servicos = new List<Servico>();

            foreach (DataGridViewRow row in dataGridView.SelectedRows)
            {
                if (!row.IsNewRow)
                {
                    Servico servicos = new Servico();
                    servicos.setNomeServico(row.Cells["Nome"].Value?.ToString());

                    if (long.TryParse(row.Cells["Valor"].Value?.ToString(), out long valor))
                    {
                        servicos.setValorServico(valor);
                    }

                    servicos.setDescServico(row.Cells["Descrição"].Value?.ToString());

                    Servicos.Add(servicos);
                }
            }

            return Servicos;
        }
        #endregion

        #region Carregar novos dados
        private void comboBoxCliente_Click(object sender, EventArgs e)
        {
            listarCliente();
        }
        #endregion

        #region Carregar novos dados
        private void comboBoxVeiculo_Click(object sender, EventArgs e)
        {
            listarVeiculoPorCliente();
        }
        #endregion

        #region Carregar novos dados
        private void comboBoxPeca_Click(object sender, EventArgs e)
        {
            listarPeca();
        }

        #endregion

        #region Carregar novos dados
        private void comboBoxServico_Click(object sender, EventArgs e)
        {
            listarServico();
        }
        #endregion
    }
}
