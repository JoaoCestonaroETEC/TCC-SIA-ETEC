using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

            #region Carrega os dados de pesquisa de serviços
            // Criação do objeto NpgsqlDataReader servico e controleServico
            controleServico cServico = new controleServico();
            NpgsqlDataReader servico = cServico.listaServico();

            // Apaga as colunas da datagridview
            dataGridViewServico.Columns.Clear();

            // Desabilitar a adição automática de novas linhas
            dataGridViewServico.AllowUserToAddRows = false;

            // Definindo a quantidade de colunas que a grid terá
            dataGridViewServico.ColumnCount = 4;

            // Definindo as colunas na DataGridView para exibir as descrições
            dataGridViewServico.Columns[0].Name = "Nome";
            dataGridViewServico.Columns[0].ReadOnly = true; // Definindo como somente leitura

            dataGridViewServico.Columns[1].Name = "Valor";
            dataGridViewServico.Columns[1].ReadOnly = true; // Definindo como somente leitura

            dataGridViewServico.Columns[2].Name = "Descrição";
            dataGridViewServico.Columns[2].ReadOnly = true; // Definindo como somente leitura

            dataGridViewServico.Columns[3].Name = "Garantia";
            dataGridViewServico.Columns[3].ReadOnly = true; // Definindo como somente leitura

            // Criando a coluna "Quantidade de Vezes" (apenas números, editável)
            DataGridViewTextBoxColumn quantidadeVezesColumn = new DataGridViewTextBoxColumn();
            quantidadeVezesColumn.Name = "Quantidade de Vezes";
            quantidadeVezesColumn.ValueType = typeof(int);
            quantidadeVezesColumn.ReadOnly = false; // Mantém editável
            dataGridViewServico.Columns.Add(quantidadeVezesColumn);

            // Criando a coluna de checkbox para marcação (editável)
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.Name = "Selecionar";
            checkBoxColumn.ReadOnly = false; // Deixando a checkbox editável
            dataGridViewServico.Columns.Add(checkBoxColumn);

            // Adicionando as descrições dos serviços
            while (servico.Read())
            {
                string nomeServico = servico["NOMESERVICO"].ToString();
                string valorServico = servico["VALORSERVICO"].ToString();
                string descServico = servico["DESCSERVICO"].ToString();
                string garantiaServico = servico["GARANTIASERVICO"].ToString();

                // Criando a nova linha manualmente
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridViewServico); // Define a grid para onde a linha vai

                // Preenchendo a linha com os valores
                row.Cells[0].Value = nomeServico;
                row.Cells[1].Value = valorServico;
                row.Cells[2].Value = descServico;
                row.Cells[3].Value = garantiaServico;
                row.Cells[4].Value = 1; // Valor padrão para "Quantidade de Vezes"
                row.Cells[5].Value = false; // Valor padrão para "Selecionar" (desmarcado)

                dataGridViewServico.Rows.Add(row);
            }

            // Validando a entrada da coluna "Quantidade de Vezes" para aceitar apenas números
            dataGridViewServico.EditingControlShowing += (s, e) =>
            {
                if (dataGridViewServico.CurrentCell.ColumnIndex == dataGridViewServico.Columns["Quantidade de Vezes"].Index)
                {
                    TextBox tb = e.Control as TextBox;
                    if (tb != null)
                    {
                        tb.KeyPress -= new KeyPressEventHandler(TextBox_KeyPress);
                        tb.KeyPress += new KeyPressEventHandler(TextBox_KeyPress);
                    }
                }
            };

            // Evento para permitir apenas números na coluna "Quantidade de Vezes"
            void TextBox_KeyPress(object sender, KeyPressEventArgs e)
            {
                // Permite apenas dígitos e tecla Backspace
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            #endregion






            #region Carrega os dados de pesquisa de peças
            // Criação do objeto NpgsqlDataReader peca e controlePeca
            controlePeca cPeca = new controlePeca();
            NpgsqlDataReader peca = cPeca.listaPeca();

            // Apaga as colunas da datagridview
            dataGridViewPeca.Columns.Clear();

            // Desabilitar a adição automática de novas linhas
            dataGridViewPeca.AllowUserToAddRows = false;

            // Definindo a quantidade de colunas que a grid terá
            dataGridViewPeca.ColumnCount = 7;

            // Definindo as colunas na DataGridView para exibir as descrições das peças
            dataGridViewPeca.Columns[0].Name = "Id";
            dataGridViewPeca.Columns[0].ReadOnly = true; // Somente leitura

            dataGridViewPeca.Columns[1].Name = "Nome";
            dataGridViewPeca.Columns[1].ReadOnly = true; // Somente leitura

            dataGridViewPeca.Columns[2].Name = "Marca";
            dataGridViewPeca.Columns[2].ReadOnly = true; // Somente leitura

            dataGridViewPeca.Columns[3].Name = "Tipo";
            dataGridViewPeca.Columns[3].ReadOnly = true; // Somente leitura

            dataGridViewPeca.Columns[4].Name = "Valor";
            dataGridViewPeca.Columns[4].ReadOnly = true; // Somente leitura

            dataGridViewPeca.Columns[5].Name = "Quantidade";
            dataGridViewPeca.Columns[5].ReadOnly = true; // Somente leitura

            dataGridViewPeca.Columns[6].Name = "Fornecedor";
            dataGridViewPeca.Columns[6].ReadOnly = true; // Somente leitura

            // Criando a coluna "Quantidade de Vezes" (apenas números, editável)
            DataGridViewTextBoxColumn quantidadeVezesColumn2 = new DataGridViewTextBoxColumn();
            quantidadeVezesColumn2.Name = "Quantidade de Vezes";
            quantidadeVezesColumn2.ValueType = typeof(int);
            quantidadeVezesColumn2.ReadOnly = false; // Mantém editável
            dataGridViewPeca.Columns.Add(quantidadeVezesColumn2);

            // Criando a coluna de checkbox para marcação (editável)
            DataGridViewCheckBoxColumn checkBoxColumn2 = new DataGridViewCheckBoxColumn();
            checkBoxColumn2.Name = "Selecionar";
            checkBoxColumn2.ReadOnly = false; // Deixando a checkbox editável
            dataGridViewPeca.Columns.Add(checkBoxColumn2);

            // Adicionando as descrições das peças
            while (peca.Read())
            {
                string idPeca = peca["IDPECA"].ToString();
                string nomePeca = peca["NOMEPECA"].ToString();
                string idMarca = peca["IDMARCA"].ToString();
                string tipoPeca = peca["TIPOPECA"].ToString();
                string valorPeca = peca["VALORPECA"].ToString();
                string quantPeca = peca["QUANTPECA"].ToString();
                string fornecedor = peca["FORNECEDOR"].ToString();

                // Consulta o nome da marca pelo id
                string marca = cPeca.pesquisaMarcaPecaPorId(idMarca);

                // Criando a nova linha manualmente
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridViewPeca); // Define a grid para onde a linha vai

                // Preenchendo a linha com os valores
                row.Cells[0].Value = idPeca;
                row.Cells[1].Value = nomePeca;
                row.Cells[2].Value = marca;
                row.Cells[3].Value = tipoPeca;
                row.Cells[4].Value = valorPeca;
                row.Cells[5].Value = quantPeca;
                row.Cells[6].Value = fornecedor;
                row.Cells[7].Value = 1; // Valor padrão para "Quantidade de Vezes"
                row.Cells[8].Value = false; // Valor padrão para "Selecionar" (desmarcado)

                dataGridViewPeca.Rows.Add(row);
            }

            // Validando a entrada da coluna "Quantidade de Vezes" para aceitar apenas números
            dataGridViewPeca.EditingControlShowing += (s, e) =>
            {
                if (dataGridViewPeca.CurrentCell.ColumnIndex == dataGridViewPeca.Columns["Quantidade de Vezes"].Index)
                {
                    TextBox tb = e.Control as TextBox;
                    if (tb != null)
                    {
                        tb.KeyPress -= new KeyPressEventHandler(TextBox_KeyPress);
                        tb.KeyPress += new KeyPressEventHandler(TextBox_KeyPress);
                    }
                }
            };

            // Evento para permitir apenas números na coluna "Quantidade de Vezes"
            void TextBox_KeyPress2(object sender, KeyPressEventArgs e)
            {
                // Permite apenas dígitos e tecla Backspace
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
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

  

        // Se a célula clicada não é da coluna "Quantidade de V
        private void AtualizarValoresTotais()
        {
            decimal valorTotalPecas = 0;
            decimal valorTotalServicos = 0;
            decimal descontoPecas = 0;
            decimal descontoServicos = 0;

            // Parse os valores das MaskedTextBoxes, com verificações de erro
            decimal.TryParse(maskedTextBoxValorTotalPecas.Text, out valorTotalPecas);
            decimal.TryParse(maskedTextBoxValorTotalServicos.Text, out valorTotalServicos);
            decimal.TryParse(maskedTextBoxDescontoRPeca.Text, out descontoPecas);
            decimal.TryParse(maskedTextBoxDescontoRServico.Text, out descontoServicos);

            // Calcule os valores totais aplicando os descontos
            decimal valorFinalPecas = valorTotalPecas - descontoPecas;
            decimal valorFinalServicos = valorTotalServicos - descontoServicos;
            decimal valorTotalPedido = valorFinalPecas + valorFinalServicos;

            // Atualize os valores nas MaskedTextBoxes
            maskedTextBoxValorTotal.Text = valorTotalPedido.ToString("0.00");
        }


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
            mPedido.setIdCliente(Convert.ToInt64(comboBoxCliente.SelectedValue));
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
            comboBoxCliente.ValueMember = "IDCLIENTE";
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

            if (comboBoxCliente.SelectedValue == null || string.IsNullOrEmpty(comboBoxCliente.SelectedValue.ToString()))
            {
                // Define o valor como o primeiro item da ComboBox
                if (comboBoxCliente.Items.Count > 0)
                {
                    comboBoxCliente.SelectedIndex = 0; // Seleciona o primeiro item
                }
                else
                {
                    MessageBox.Show("A ComboBox está vazia.");
                }
            }
            else
            {
                // O valor selecionado não é vazio, pode prosseguir
            }

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
        }
        #endregion

        #region Pesquisar peça
        // Evento de pesquisar peça
        private void buttonPesquisarPeca_Click(object sender, EventArgs e)
        {
            // Armazena os índices das linhas selecionadas
            List<int> selectedRowIndices = new List<int>();
            foreach (DataGridViewRow row in dataGridViewPeca.SelectedRows)
            {
                selectedRowIndices.Add(row.Index);
            }

            // Limpar as linhas da DataGridView, exceto as selecionadas
            for (int i = dataGridViewPeca.Rows.Count - 1; i >= 0; i--)
            {
                // Verifica se a linha não é uma nova linha (linha vazia) e não está selecionada
                if (!dataGridViewPeca.Rows[i].IsNewRow && !selectedRowIndices.Contains(i))
                {
                    dataGridViewPeca.Rows.RemoveAt(i);
                }
            }

            // Criação do objeto NpgsqlDataReader peca e controlePeca
            controlePeca cPeca = new controlePeca();
            NpgsqlDataReader peca = cPeca.pesquisaPeca(textBoxPesquisarP.Text);

            // Definindo a quantidade de colunas que a grid terá
            dataGridViewPeca.ColumnCount = 9;
            dataGridViewPeca.Columns[0].Name = "Id";
            dataGridViewPeca.Columns[1].Name = "Nome";
            dataGridViewPeca.Columns[2].Name = "Marca";
            dataGridViewPeca.Columns[3].Name = "Tipo";
            dataGridViewPeca.Columns[4].Name = "Valor";
            dataGridViewPeca.Columns[5].Name = "Quantidade";
            dataGridViewPeca.Columns[8].Name = "Fornecedor";

            // Adicionando as descrições de peças sem duplicação
            while (peca.Read())
            {
                string idPeca = peca["IDPECA"].ToString();
                string nomePeca = peca["NOMEPECA"].ToString();
                string idMarca = peca["IDMARCA"].ToString();
                string tipoPeca = peca["TIPOPECA"].ToString();
                string valorPeca = peca["VALORPECA"].ToString();
                string quantPeca = peca["QUANTPECA"].ToString();
                string fornecedor = peca["FORNECEDOR"].ToString();

                // Consulta o nome da marca pelo id
                string marca = cPeca.pesquisaMarcaPecaPorId(idMarca);
                dataGridViewPeca.Rows.Add(idPeca, nomePeca, marca, tipoPeca, valorPeca, quantPeca, fornecedor);
            }
        }
        #endregion

        #region Pesquisar serviço
        // Evento de pesquisar serviço
        private void buttonPesquisarServico_Click(object sender, EventArgs e)
        {
            // Criação do objeto NpgsqlDataReader servico e controleServico
            controleServico cServico = new controleServico();
            NpgsqlDataReader servico = cServico.pesquisaServico(textBoxPesquisarS.Text);
            dataGridViewServico.Columns.Clear();

            dataGridViewServico.ColumnCount = servico.FieldCount;

            // Definindo a quant. de colunas que a grid terá
            dataGridViewServico.ColumnCount = 4;
            dataGridViewServico.Columns[0].Name = "Nome";
            dataGridViewServico.Columns[1].Name = "Valor";
            dataGridViewServico.Columns[2].Name = "Descrição";
            dataGridViewServico.Columns[3].Name = "Garantia";

            // Adicionando as descrições dos serviços
            while (servico.Read())
            {
                string nomeServico = servico["NOMESERVICO"].ToString();
                string valorServico = servico["VALORSERVICO"].ToString();
                string descServico = servico["DESCSERVICO"].ToString();
                string garantia = servico["GARANTIASERVICO"].ToString();

                dataGridViewServico.Rows.Add(nomeServico, valorServico, descServico, garantia);
            }
        }
        #endregion


        #region Extrai as peças
        // Cria o método de extrair os serviços através de uma lista genérica da classe Pedido_Peca
        public List<Pedido_Peca> ExtrairPecasDataGridView(DataGridView dataGridView)
        {
            // Criação da lista e do objeto controlePeca
            List<Pedido_Peca> Pecas = new List<Pedido_Peca>();
            controlePeca cPeca = new controlePeca();

            // Loop de repetição para cada linha, adiciona um objeto Pedido_Peca na lista apenas se a checkbox estiver marcada
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                // Verifica se a linha não é nova e se a checkbox "Selecionar" está marcada
                if (!row.IsNewRow && Convert.ToBoolean(row.Cells["Selecionar"].Value))
                {
                    string nomePeca = row.Cells["Nome"].Value?.ToString();

                    // Lê o nome da marca de peça e traz o Id dessa peça
                    NpgsqlDataReader peca = cPeca.pesquisaPecaParaOPedido(nomePeca);

                    // Verificação da consulta do banco de dados
                    if (peca != null)
                    {
                        // Carrega os valores da consulta
                        DataTable dtPecas = new DataTable();
                        dtPecas.Load(peca);

                        // Se traz o valor de id da marca, carrega a lista
                        if (dtPecas.Rows.Count > 0)
                        {
                            Pedido_Peca pecas = new Pedido_Peca();


                            // Definição aos atributos da classe

                            if (long.TryParse(dtPecas.Rows[0]["IDMARCA"].ToString(), out long idNomeMarca))
                            {
                                pecas.setIdMarca(idNomeMarca);
                            }

                            string nomePecaVar = (row.Cells["Nome"].Value?.ToString());
                            string tipoPecaVar = (row.Cells["Tipo"].Value?.ToString());

                            if (int.TryParse(row.Cells["Quantidade de Vezes"].Value?.ToString(), out int quant))
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

                            // Adiciona a classe Pedido_Peca na lista
                            Pecas.Add(pecas);
                        }

                        // Fecha a consulta do banco de dados
                        peca.Close();
                    }
                }
            }

            // Retorna a lista
            return Pecas;
        }
        #endregion

        #region Extrai os serviços
        // Cria o método de extrair os serviços através de uma lista genérica da classe Servico
        public List<Servico> ExtrairServicosDataGridView(DataGridView dataGridView)
        {
            // Criação da lista
            List<Servico> Servicos = new List<Servico>();

            // Loop de repetição para cada linha, adiciona um objeto Servico na lista apenas se a checkbox estiver marcada
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                // Verifica se a linha não é nova e se a checkbox "Selecionar" está marcada
                if (!row.IsNewRow && Convert.ToBoolean(row.Cells["Selecionar"].Value))
                {
                    // Definição aos atributos da classe
                    Servico servicos = new Servico();
                    servicos.setNomeServico(row.Cells["Nome"].Value?.ToString());

                    if (long.TryParse(row.Cells["Valor"].Value?.ToString(), out long valor))
                    {
                        servicos.setValorServico(valor);
                    }

                    servicos.setDescServico(row.Cells["Descrição"].Value?.ToString());

                    // Adiciona a classe Servico na lista
                    Servicos.Add(servicos);
                }
            }

            // Retorna a lista
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

        private void CadastroPedido_Load(object sender, EventArgs e)
        {

        }

        #region Métodos para combo box de valores e descontos
        private void maskedTextBoxValorTotal_TextChanged(object sender, EventArgs e)
        {
            MaskedTextBox maskedTextBox = sender as MaskedTextBox;

            // Remove qualquer formatação anterior e deixa apenas os números
            string textoAtual = maskedTextBox.Text.Replace(",", "").Replace(".", "").TrimStart('0');

            if (textoAtual.Length == 0)
            {
                textoAtual = "0";
            }

            // Converte o texto para decimal
            if (decimal.TryParse(textoAtual, out decimal valorDecimal))
            {
                maskedTextBox.TextChanged -= maskedTextBoxValorTotal_TextChanged; // Remove o evento para evitar loop

                // Formata o valor com ponto como separador de centavos e sem separadores de milhar
                maskedTextBox.Text = string.Format("{0:0.00}", valorDecimal / 100);

                // Coloca o cursor no final
                maskedTextBox.SelectionStart = maskedTextBox.Text.Length;

                maskedTextBox.TextChanged += maskedTextBoxValorTotal_TextChanged; // Reinscreve o evento
            }
            AtualizarValoresTotais();
        }

        private void maskedTextBoxValorTotalServicos_TextChanged(object sender, EventArgs e)
        {

            MaskedTextBox maskedTextBox = sender as MaskedTextBox;

            // Remove qualquer formatação anterior e deixa apenas os números
            string textoAtual = maskedTextBox.Text.Replace(",", "").Replace(".", "").TrimStart('0');

            if (textoAtual.Length == 0)
            {
                textoAtual = "0";
            }

            // Converte o texto para decimal
            if (decimal.TryParse(textoAtual, out decimal valorDecimal))
            {
                maskedTextBox.TextChanged -= maskedTextBoxValorTotalServicos_TextChanged; // Remove o evento para evitar loop

                // Formata o valor com ponto como separador de centavos e sem separadores de milhar
                maskedTextBox.Text = string.Format("{0:0.00}", valorDecimal / 100);

                // Coloca o cursor no final
                maskedTextBox.SelectionStart = maskedTextBox.Text.Length;

                maskedTextBox.TextChanged += maskedTextBoxValorTotalServicos_TextChanged; // Reinscreve o evento
            }
            AtualizarValoresTotais();
        }

        private void maskedTextBoxValorTotalPecas_TextChanged(object sender, EventArgs e)
        {

            MaskedTextBox maskedTextBox = sender as MaskedTextBox;

            // Remove qualquer formatação anterior e deixa apenas os números
            string textoAtual = maskedTextBox.Text.Replace(",", "").Replace(".", "").TrimStart('0');

            if (textoAtual.Length == 0)
            {
                textoAtual = "0";
            }

            // Converte o texto para decimal
            if (decimal.TryParse(textoAtual, out decimal valorDecimal))
            {
                maskedTextBox.TextChanged -= maskedTextBoxValorTotalPecas_TextChanged; // Remove o evento para evitar loop

                // Formata o valor com ponto como separador de centavos e sem separadores de milhar
                maskedTextBox.Text = string.Format("{0:0.00}", valorDecimal / 100);

                // Coloca o cursor no final
                maskedTextBox.SelectionStart = maskedTextBox.Text.Length;

                maskedTextBox.TextChanged += maskedTextBoxValorTotalPecas_TextChanged; // Reinscreve o evento
            }
            AtualizarValoresTotais();
        }

        private void maskedTextBoxDescontoReais_TextChanged(object sender, EventArgs e)
        {
            MaskedTextBox textBox = sender as MaskedTextBox;

            // Remover tudo que não seja número
            string digitsOnly = new string(textBox.Text.Where(char.IsDigit).ToArray());

            // Remover zeros à esquerda
            digitsOnly = digitsOnly.TrimStart('0');

            // Garantir que pelo menos 1 zero seja mantido caso o campo fique vazio após remover zeros
            if (string.IsNullOrEmpty(digitsOnly))
            {
                digitsOnly = "0";
            }

            // Limitar a 3 dígitos
            if (digitsOnly.Length > 3)
            {
                digitsOnly = digitsOnly.Substring(0, 3);
            }

            // Verificar se o valor numérico não excede 100
            if (int.TryParse(digitsOnly, out int number))
            {
                if (number > 100)
                {
                    digitsOnly = "100";  // Definir o valor máximo como 100
                }
            }

            // Atualizar o texto da MaskedTextBox com os 3 dígitos válidos
            textBox.Text = digitsOnly;

            // Colocar o cursor no final
            textBox.SelectionStart = textBox.Text.Length;
        }

        private void maskedTextBoxDescontoPorc_TextChanged(object sender, EventArgs e)
        {

            MaskedTextBox maskedTextBox = sender as MaskedTextBox;

            // Remove qualquer formatação anterior e deixa apenas os números
            string textoAtual = maskedTextBox.Text.Replace(",", "").Replace(".", "").TrimStart('0');

            if (textoAtual.Length == 0)
            {
                textoAtual = "0";
            }

            // Converte o texto para decimal
            if (decimal.TryParse(textoAtual, out decimal valorDecimal))
            {
                maskedTextBox.TextChanged -= maskedTextBoxDescontoPorc_TextChanged; // Remove o evento para evitar loop

                // Formata o valor com ponto como separador de centavos e sem separadores de milhar
                maskedTextBox.Text = string.Format("{0:0.00}", valorDecimal / 100);

                // Coloca o cursor no final
                maskedTextBox.SelectionStart = maskedTextBox.Text.Length;

                maskedTextBox.TextChanged += maskedTextBoxDescontoPorc_TextChanged; // Reinscreve o evento
            }
        }

        private void maskedTextBoxDescontoRPeca_TextChanged(object sender, EventArgs e)
        {
            MaskedTextBox textBox = sender as MaskedTextBox;

            // Remover tudo que não seja número
            string digitsOnly = new string(textBox.Text.Where(char.IsDigit).ToArray());

            // Remover zeros à esquerda
            digitsOnly = digitsOnly.TrimStart('0');

            // Garantir que pelo menos 1 zero seja mantido caso o campo fique vazio após remover zeros
            if (string.IsNullOrEmpty(digitsOnly))
            {
                digitsOnly = "0";
            }

            // Limitar a 3 dígitos
            if (digitsOnly.Length > 3)
            {
                digitsOnly = digitsOnly.Substring(0, 3);
            }

            // Verificar se o valor numérico não excede 100
            if (int.TryParse(digitsOnly, out int number))
            {
                if (number > 100)
                {
                    digitsOnly = "100";  // Definir o valor máximo como 100
                }
            }

            // Atualizar o texto da MaskedTextBox com os 3 dígitos válidos
            textBox.Text = digitsOnly;

            // Colocar o cursor no final
            textBox.SelectionStart = textBox.Text.Length;
        }

        private void maskedTextBoxDescontoPPeca_TextChanged(object sender, EventArgs e)
        {
            MaskedTextBox maskedTextBox = sender as MaskedTextBox;

            // Remove qualquer formatação anterior e deixa apenas os números
            string textoAtual = maskedTextBox.Text.Replace(",", "").Replace(".", "").TrimStart('0');

            if (textoAtual.Length == 0)
            {
                textoAtual = "0";
            }

            // Converte o texto para decimal
            if (decimal.TryParse(textoAtual, out decimal valorDecimal))
            {
                maskedTextBox.TextChanged -= maskedTextBoxDescontoPPeca_TextChanged; // Remove o evento para evitar loop

                // Formata o valor com ponto como separador de centavos e sem separadores de milhar
                maskedTextBox.Text = string.Format("{0:0.00}", valorDecimal / 100);

                // Coloca o cursor no final
                maskedTextBox.SelectionStart = maskedTextBox.Text.Length;

                maskedTextBox.TextChanged += maskedTextBoxDescontoPPeca_TextChanged; // Reinscreve o evento
            }
            AtualizarValoresTotais();
        }

        private void maskedTextBoxDescontoRServico_TextChanged(object sender, EventArgs e)
        {
            MaskedTextBox textBox = sender as MaskedTextBox;

            // Remover tudo que não seja número
            string digitsOnly = new string(textBox.Text.Where(char.IsDigit).ToArray());

            // Remover zeros à esquerda
            digitsOnly = digitsOnly.TrimStart('0');

            // Garantir que pelo menos 1 zero seja mantido caso o campo fique vazio após remover zeros
            if (string.IsNullOrEmpty(digitsOnly))
            {
                digitsOnly = "0";
            }

            // Limitar a 3 dígitos
            if (digitsOnly.Length > 3)
            {
                digitsOnly = digitsOnly.Substring(0, 3);
            }

            // Verificar se o valor numérico não excede 100
            if (int.TryParse(digitsOnly, out int number))
            {
                if (number > 100)
                {
                    digitsOnly = "100";  // Definir o valor máximo como 100
                }
            }

            // Atualizar o texto da MaskedTextBox com os 3 dígitos válidos
            textBox.Text = digitsOnly;

            // Colocar o cursor no final
            textBox.SelectionStart = textBox.Text.Length;
        }

        private void maskedTextBoxDescontoPServico_TextChanged(object sender, EventArgs e)
        {
            MaskedTextBox maskedTextBox = sender as MaskedTextBox;

            // Remove qualquer formatação anterior e deixa apenas os números
            string textoAtual = maskedTextBox.Text.Replace(",", "").Replace(".", "").TrimStart('0');

            if (textoAtual.Length == 0)
            {
                textoAtual = "0";
            }

            // Converte o texto para decimal
            if (decimal.TryParse(textoAtual, out decimal valorDecimal))
            {
                maskedTextBox.TextChanged -= maskedTextBoxDescontoPServico_TextChanged; // Remove o evento para evitar loop

                // Formata o valor com ponto como separador de centavos e sem separadores de milhar
                maskedTextBox.Text = string.Format("{0:0.00}", valorDecimal / 100);

                // Coloca o cursor no final
                maskedTextBox.SelectionStart = maskedTextBox.Text.Length;

                maskedTextBox.TextChanged += maskedTextBoxDescontoPServico_TextChanged; // Reinscreve o evento
            }
            AtualizarValoresTotais();
        }
        #endregion

        private void comboBoxCliente_Validating(object sender, CancelEventArgs e)
        {
            System.Windows.Forms.ComboBox comboBox = sender as System.Windows.Forms.ComboBox;
            string fornecedorDigitado = comboBox.Text;

            // Verifica se o valor digitado já existe na lista de itens da ComboBox
            bool fornecedorExiste = comboBox.Items.Cast<System.Data.DataRowView>()
                                       .Any(item => item["NOMECLIENTE"].ToString()
                                       .Equals(fornecedorDigitado, StringComparison.OrdinalIgnoreCase));

            if (!fornecedorExiste && !string.IsNullOrEmpty(fornecedorDigitado))
            {
                // Exibe a mensagem com o aviso
                DialogResult result = MessageBox.Show("Aviso! Cliente não registrado! Deseja registrar um novo?",
                                                      "Aviso!",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    CadastroCliente formCliente = new CadastroCliente();
                    formCliente.Show();
                }
                else
                {
                    // Limpa o texto da ComboBox
                    comboBox.Text = string.Empty;
                }
            }
        }

        private void comboBoxVeiculo_Validating(object sender, CancelEventArgs e)
        {
            System.Windows.Forms.ComboBox comboBox = sender as System.Windows.Forms.ComboBox;
            string fornecedorDigitado = comboBox.Text;

            // Verifica se o valor digitado já existe na lista de itens da ComboBox
            bool fornecedorExiste = comboBox.Items.Cast<System.Data.DataRowView>()
                                       .Any(item => item["NOMEVEICULO"].ToString()
                                       .Equals(fornecedorDigitado, StringComparison.OrdinalIgnoreCase));

            if (!fornecedorExiste && !string.IsNullOrEmpty(fornecedorDigitado))
            {
                // Exibe a mensagem com o aviso
                DialogResult result = MessageBox.Show("Aviso! Veiculo não registrado! Deseja registrar um novo?",
                                                      "Aviso!",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    CadastroVeiculo formVeiculo = new CadastroVeiculo();
                    formVeiculo.Show();
                }
                else
                {
                    // Limpa o texto da ComboBox
                    comboBox.Text = string.Empty;
                }
            }
        }

        private void comboBoxCliente_DropDown(object sender, EventArgs e)
        {
            listarCliente();
        }

        private void comboBoxVeiculo_DropDown(object sender, EventArgs e)
        {
            listarVeiculoPorCliente();
        }

        private void maskedTextBoxValorTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir apenas números e a tecla Backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Bloqueia a entrada
            }
        }

        private void maskedTextBoxValorTotalServicos_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir apenas números e a tecla Backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Bloqueia a entrada
            }
        }

        private void maskedTextBoxValorTotalPecas_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir apenas números e a tecla Backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Bloqueia a entrada
            }
        }

        private void maskedTextBoxDescontoPorc_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir apenas números e a tecla Backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Bloqueia a entrada
            }
        }

        private void maskedTextBoxDescontoPPeca_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir apenas números e a tecla Backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Bloqueia a entrada
            }
        }

        private void maskedTextBoxDescontoPServico_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir apenas números e a tecla Backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Bloqueia a entrada
            }
        }

        private void dataGridViewPeca_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = sender as DataGridView;

            // Verifica se o clique foi em uma célula válida
            if (e.RowIndex >= 0)
            {
                // Verifica se a tecla Ctrl está pressionada
                if (Control.ModifierKeys == Keys.Control)
                {
                    // Alterna a seleção da linha
                    dataGridView.Rows[e.RowIndex].Selected = !dataGridView.Rows[e.RowIndex].Selected;
                }
                else
                {
                    // Se Ctrl não está pressionado, selecione apenas a linha clicada
                    dataGridView.ClearSelection(); // Limpa a seleção atual
                    dataGridView.Rows[e.RowIndex].Selected = true; // Seleciona a linha clicada
                }
            }
        }
    }
}
