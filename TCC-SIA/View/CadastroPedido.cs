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
            #endregion 

            #region Carrega os dados de pesquisa de serviços
            //Criação do objeto NpgsqlDataReader servico e controleServico
            controleServico cServico = new controleServico();
            NpgsqlDataReader servico = cServico.listaServico();

            //Apaga as colunas da datagridview
            dataGridViewServico.Columns.Clear();

            //Definindo a quant. de colunas que a grid terá
            dataGridViewServico.ColumnCount = servico.FieldCount;

            //Definindo três colunas na DataGridView para exibir as descrições
            dataGridViewServico.ColumnCount = 3;
            dataGridViewServico.Columns[0].Name = "Nome";
            dataGridViewServico.Columns[1].Name = "Valor";
            dataGridViewServico.Columns[2].Name = "Descrição";

            //Adicionando as descrições dos serviços
            while (servico.Read())
            {
                string nomeServico = servico["NOMESERVICO"].ToString();
                string valorServico = servico["VALORSERVICO"].ToString();
                string descServico = servico["DESCSERVICO"].ToString();
                dataGridViewServico.Rows.Add(nomeServico, valorServico, descServico);
            }
            #endregion

            #region Carrega os dados de pesquisa de peças
            //Criação do objeto NpgsqlDataReader peca e controlePeca
            controlePeca cPeca = new controlePeca();
            NpgsqlDataReader peca = cPeca.listaPeca();

            //Apaga as colunas da datagridview
            dataGridViewPeca.Columns.Clear();

            //Definindo a quant. de colunas que a grid terá
            dataGridViewPeca.ColumnCount = peca.FieldCount;

            //Definindo sete colunas na DataGridView para exibir as descrições
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
                string descPeca = peca["DESCPECA"].ToString();

                //Consulta o nome da marca pelo id
                string marca = cPeca.pesquisaMarcaPecaPorId(idMarca);

                dataGridViewPeca.Rows.Add(marca, nomePeca, tipoPeca, valorPeca, quantPeca, garantiaPeca, descPeca);
            }
            #endregion

            #region Puxa o maior id de pedido
            //Criação do objeto NpgsqlDataReader idPedido, mPedido e controlePedido 
            controlePedido cPedido = new controlePedido();
            Pedido mPedido = new Pedido();
            NpgsqlDataReader pedido = cPedido.listarIdPedido();

            //Converter o dataReader em DataTable
            DataTable dtPedido = new DataTable();
            dtPedido.Load(pedido);

            //Cria uma nova variável pra manter o id do pedido
            long idPedido;

            //Verifica sem tem algum valor na tabela
            if (dtPedido.Rows[0]["MAX"] == DBNull.Value)
            {
                idPedido = 0;
            }
            //Se tem ele faz a soma
            else
            {
                //Puxa o valor da consulta da tabela e coloca numa variável
                idPedido = Convert.ToInt64(dtPedido.Rows[0]["MAX"].ToString());
            }

            //Soma mais um para impedir a restrição por chave primária no banco
            idPedido = idPedido + 1;
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
            decimal valor;
            if (decimal.TryParse(maskedTextBoxValorTotal.Text, out valor))
            {
                mPedido.setValorTotalPeca(valor);
            }

            //Faz uma verificação para tentar enviar o valor para o atributo, se existiver vazia ele envia vazia sem dar erro
            decimal valorPeca;
            if (decimal.TryParse(maskedTextBoxValorTotalPecas.Text, out valorPeca))
            {
                mPedido.setValorTotalPeca(valorPeca);
            }

            //Faz uma verificação para tentar enviar o valor para o atributo, se existiver vazia ele envia vazia sem dar erro
            decimal valorServico;
            if (decimal.TryParse(maskedTextBoxValorTotal.Text, out valorServico))
            {
                mPedido.setValorTotalServico(valorServico);
            }

            #region Puxa o maior id de pedido
            //Criação do objeto NpgsqlDataReader pedido
            NpgsqlDataReader pedido = cPedido.listarIdPedido();

            //Converter o dataReader em DataTable
            DataTable dtPedido = new DataTable();
            dtPedido.Load(pedido);

            long idPedido;

            //Verifica sem tem algum valor na tabela
            if (dtPedido.Rows[0]["MAX"] == DBNull.Value)
            {
                idPedido = 0;
            }
            //Se tem ele faz a soma
            else
            {
                //Puxa o valor da consulta da tabela e coloca numa variável
                idPedido = Convert.ToInt64(dtPedido.Rows[0]["MAX"].ToString());
            }

            //Soma mais um para impedir a restrição por chave primária no banco
            idPedido = idPedido + 1;

            mPedido.setIdPedido(idPedido);
            #endregion

            foreach (DataGridViewRow row in dataGridViewPeca.SelectedRows)
            {
                if (row.Cells["Nome"].Value == null)
                {
                    MessageBox.Show("Preencha o nome do campo!)");
                    return;
                }

                if (row.Cells["Valor"].Value == null)
                {
                    MessageBox.Show("Preencha o nome de valor!)");
                    return;
                }

                if (row.Cells["Quantidade"].Value == null)
                {
                    MessageBox.Show("Preencha o nome de quantidade!)");
                    return;
                }

                if (row.Cells["Garantia"].Value == null)
                {
                    MessageBox.Show("Coloque uma garantia!");
                    return;
                }
            }

            //Cria as listas para extrair os valores das datagridview
            List<Pedido_Peca> ListaDePecas = ExtrairPecasDataGridView(dataGridViewPeca);
            List<Servico> ListaDeServicos = ExtrairServicosDataGridView(dataGridViewServico);

            //Chamada aos métodos de cadastros no controlePedido
            string res = cPedido.cadastroPedido(mPedido);
            string resPeca = cPedido.cadastroPedidoPecas(ListaDePecas, mPedido);
            string resServ = cPedido.cadastroPedidoServicos(ListaDeServicos, mPedido);

            //Mostra os resultados
            MessageBox.Show(res);
            MessageBox.Show(resPeca);
            MessageBox.Show(resServ);
        }
        #endregion

        #region Listar cliente
        public void listarCliente()
        {
            //Criação do objeto cliente e controleCliente
            controleCliente cCliente = new controleCliente();

            //Recebe os dados da consulta e salva no dataReader (Cliente)
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
            //Criação do objeto veiculo e controleVeiculo
            controleVeiculo cVeiculo = new controleVeiculo();

            //Recebe os dados da consulta e salva no dataReader (Veiculo)
            NpgsqlDataReader veiculo = cVeiculo.listaVeiculo();

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

            //Recebe os dados da consulta e salva no dataReader (Veiculo)
            NpgsqlDataReader veiculo = cVeiculo.listaVeiculoPorCliente(Convert.ToString(comboBoxCliente.SelectedValue));

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
            //Criação do objeto peca e controlePeca
            controlePeca cPeca = new controlePeca();

            //Recebe os dados da consulta e salva no dataReader (Peca)
            NpgsqlDataReader peca = cPeca.listaPeca();

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
            //Criação do objeto servico e controleServico
            controleServico cServico = new controleServico();

            //Recebe os dados da consulta e salva no dataReader (Servico)
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
            //Caso ele queria pesquisar alguma coisa sem ter selecionado nada
            if (dataGridViewPeca.SelectedRows.Count == 0)
            {
                //Criação do objeto NpgsqlDataReader peca e controlePeca
                controlePeca cPeca = new controlePeca();
                NpgsqlDataReader peca = cPeca.pesquisaPeca(comboBoxPeca.Text);

                //Apaga as colunas da datagridview
                dataGridViewPeca.Columns.Clear();

                //Definindo a quant. de colunas que a grid terá
                dataGridViewPeca.ColumnCount = peca.FieldCount;

                //Definindo sete colunas na DataGridView para exibir as descrições
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
                    string descPeca = peca["DESCPECA"].ToString();

                    //Consulta o nome da marca pelo id
                    string marca = cPeca.pesquisaMarcaPecaPorId(idMarca);

                    dataGridViewPeca.Rows.Add(marca, nomePeca, tipoPeca, valorPeca, quantPeca, garantiaPeca, descPeca);
                }
            }

            //Caso ele queria pesquisar alguma coisa e tenha selecionado alguma linha
            if (dataGridViewPeca.SelectedRows.Count != 0)
            {
                //Criação do objeto NpgsqlDataReader peca e controlePeca
                controlePeca cPeca = new controlePeca();
                NpgsqlDataReader peca = cPeca.pesquisaPeca(comboBoxPeca.Text);

                //Definindo a quant. de colunas que a grid terá
                dataGridViewPeca.ColumnCount = peca.FieldCount;

                //Definindo sete colunas na DataGridView para exibir as descrições
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
                    string descPeca = peca["DESCPECA"].ToString();

                    //Consulta o nome da marca pelo id
                    string marca = cPeca.pesquisaMarcaPecaPorId(idMarca);

                    dataGridViewPeca.Rows.Add(marca, nomePeca, tipoPeca, valorPeca, quantPeca, garantiaPeca, descPeca);
                }
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
            dataGridViewServico.Columns[0].Name = "Nome";
            dataGridViewServico.Columns[1].Name = "Valor";
            dataGridViewServico.Columns[2].Name = "Descrição";

            //Adicionando as descrições dos serviços
            while (servico.Read())
            {
                string nomeServico = servico["NOMESERVICO"].ToString();
                string valorServico = servico["VALORSERVICO"].ToString();
                string descServico = servico["DESCSERVICO"].ToString();
                dataGridViewServico.Rows.Add(nomeServico, valorServico, descServico);
            }
        }
        #endregion

        #region Extrai as peças
        //Cria o método de extrar os serviços através de uma lista genérica da classe Pedido_Peca
        public List<Pedido_Peca> ExtrairPecasDataGridView(DataGridView dataGridView)
        {
            //Criação da lista e do objeto controlePeca
            List<Pedido_Peca> Pecas = new List<Pedido_Peca>();
            controlePeca cPeca = new controlePeca();

            //Loop de repetição para cada linha selecionada, adiciona um objeto Pedido_Peca na lista
            foreach (DataGridViewRow row in dataGridView.SelectedRows)
            {
                string nomePeca = row.Cells["Nome"].Value?.ToString();

                //Lê o nome da marca de peça e trás o Id dessa peça
                NpgsqlDataReader peca = cPeca.pesquisaPecaParaOPedido(nomePeca);

                //Verificação da consulta do banco de dados
                if (peca != null)
                {
                    //Carrega os valores da consulta
                    DataTable dtPecas = new DataTable();
                    dtPecas.Load(peca);

                    //Se trás o valor de id da marca, carrega a lista
                    if (dtPecas.Rows.Count > 0)
                    {
                        Pedido_Peca pecas = new Pedido_Peca();

                        //Definição aos atributos da classe
                        if (long.TryParse(dtPecas.Rows[0]["IDMARCAPECA"].ToString(), out long idNomeMarca))
                        {
                            pecas.setIdMarca(idNomeMarca);
                        }

                        string nomePecaVar = (row.Cells["Nome"].Value?.ToString());
                        string tipoPecaVar = (row.Cells["Tipo"].Value?.ToString());



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
                        pecas.setDescPeca(descPecaVar);

                        //Adiciona a classe Pedido_Peca na lista
                        Pecas.Add(pecas);

                    }

                    //Fecha a consulta do banco de dados
                    peca.Close();
                }
            }

            //Retorna a lista
            return Pecas;
        }
        #endregion

        #region Extrai os serviços
        //Cria o método de extrar os serviços através de uma lista genérica da classe Servico
        public List<Servico> ExtrairServicosDataGridView(DataGridView dataGridView)
        {
            //Criação da lista
            List<Servico> Servicos = new List<Servico>();

            //Loop de repetição para cada linha selecionada, adiciona um objeto Servico na lista
            foreach (DataGridViewRow row in dataGridView.SelectedRows)
            {
                //Verificação da consulta do banco de dados
                if (!row.IsNewRow)
                {
                    //Definição aos atributos da classe
                    Servico servicos = new Servico();
                    servicos.setNomeServico(row.Cells["Nome"].Value?.ToString());

                    if (long.TryParse(row.Cells["Valor"].Value?.ToString(), out long valor))
                    {
                        servicos.setValorServico(valor);
                    }

                    servicos.setDescServico(row.Cells["Descrição"].Value?.ToString());

                    //Adiciona a classe Servico na lista
                    Servicos.Add(servicos);
                }
            }

            //Retorna a lista
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

        private void dataGridViewPeca_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewPeca.Rows[e.RowIndex].Selected = true;
            // Verifica se o índice da célula é válido e está dentro do range de linhas e colunas
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 &&
                e.RowIndex < dataGridViewPeca.Rows.Count && e.ColumnIndex < dataGridViewPeca.Columns.Count)
            {
                // Inicia a edição da célula clicada
                dataGridViewPeca.BeginEdit(true);
            }

        }

        private void dataGridViewPeca_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewPeca.Rows[e.RowIndex].Selected = true;

            // Verifica se o índice da célula é válido e está dentro do range de linhas
            if (e.RowIndex >= 0 && e.RowIndex < dataGridViewPeca.Rows.Count)
            {
                // Obtém a linha clicada
                DataGridViewRow clickedRow = dataGridViewPeca.Rows[e.RowIndex];

                // Alterna o estado de seleção da linha clicada
                clickedRow.Selected = !clickedRow.Selected;
            }
        }
    }
}
