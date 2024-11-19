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

            listarCliente();
            listarVeiculoPorCliente();

            #region Carrega os dados de pesquisa de serviços
            // Criação do objeto NpgsqlDataReader servico e controleServico
            controleServico cServico = new controleServico();
            NpgsqlDataReader servico = cServico.pesquisaServico(textBoxPesquisarS.Text);

            // Armazena os estados das checkboxes e os valores de "Quantidade de Vezes" antes de limpar
            List<bool> checkboxStates = new List<bool>();
            List<int> quantidadeVezesValues = new List<int>();

            for (int i = 0; i < dataGridViewServico.Rows.Count; i++)
            {
                if (!dataGridViewServico.Rows[i].IsNewRow)
                {
                    checkboxStates.Add(dataGridViewServico.Rows[i].Cells["Selecionar"].Value is bool isChecked && isChecked);
                    quantidadeVezesValues.Add(Convert.ToInt32(dataGridViewServico.Rows[i].Cells["Quant. Vezes"].Value));
                }
            }

            // Apaga as colunas da datagridview
            dataGridViewServico.Columns.Clear();

            // Desabilitar a adição automática de novas linhas
            dataGridViewServico.AllowUserToAddRows = false;

            // Definindo a quantidade de colunas que a grid terá
            dataGridViewServico.ColumnCount = 6;

            // Definindo as colunas na DataGridView para exibir as descrições
            dataGridViewServico.Columns[0].Name = "Id Serviço";
            dataGridViewServico.Columns[0].ReadOnly = true; // Definindo como somente leitura

            dataGridViewServico.Columns[1].Name = "Nome";
            dataGridViewServico.Columns[1].ReadOnly = true; // Definindo como somente leitura

            dataGridViewServico.Columns[2].Name = "Valor";
            dataGridViewServico.Columns[2].ReadOnly = true; // Definindo como somente leitura

            dataGridViewServico.Columns[3].Name = "Descrição";
            dataGridViewServico.Columns[3].ReadOnly = true; // Definindo como somente leitura

            dataGridViewServico.Columns[4].Name = "Garantia";
            dataGridViewServico.Columns[4].ReadOnly = true; // Definindo como somente leitura

            dataGridViewServico.Columns[5].Name = "Funcionário";
            dataGridViewServico.Columns[5].ReadOnly = true; // Definindo como somente leitura

            // Criando a coluna "Quantidade de Vezes" (apenas números, editável)
            DataGridViewTextBoxColumn quantidadeVezesColumn = new DataGridViewTextBoxColumn();
            quantidadeVezesColumn.Name = "Quant. Vezes";
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
                string idServico = servico["IDSERVICO"].ToString();
                string nomeServico = servico["NOMESERVICO"].ToString();
                string valorServico = servico["VALORSERVICO"].ToString();
                string descServico = servico["DESCSERVICO"].ToString();
                string garantiaServico = servico["GARANTIASERVICO"].ToString();
                string funcionarioServico = servico["FUNCIONARIO"].ToString();

                // Verifique se a linha já existe
                bool exists = false;
                foreach (DataGridViewRow existingRow in dataGridViewServico.Rows)
                {
                    if (!existingRow.IsNewRow &&
                        existingRow.Cells["Id Serviço"].Value.ToString() == idServico &&
                        existingRow.Cells["Nome"].Value.ToString() == nomeServico)
                    {
                        exists = true;
                        break;
                    }
                }

                // Adiciona a nova linha apenas se não existir
                if (!exists)
                {
                    // Criando a nova linha manualmente
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dataGridViewServico); // Define a grid para onde a linha vai

                    // Preenchendo a linha com os valores
                    row.Cells[0].Value = idServico;
                    row.Cells[1].Value = nomeServico;
                    row.Cells[2].Value = valorServico;
                    row.Cells[3].Value = descServico;
                    row.Cells[4].Value = garantiaServico;
                    row.Cells[5].Value = funcionarioServico;
                    row.Cells[6].Value = 1; // Valor padrão para "Quantidade de Vezes"
                    row.Cells[7].Value = false; // Valor padrão para "Selecionar" (desmarcado)

                    dataGridViewServico.Rows.Add(row);
                }
            }

            // Após adicionar novas linhas, restaure os estados das checkboxes e os valores de "Quantidade de Vezes"
            for (int i = 0; i < dataGridViewServico.Rows.Count; i++)
            {
                if (i < checkboxStates.Count)
                {
                    dataGridViewServico.Rows[i].Cells["Selecionar"].Value = checkboxStates[i];
                    dataGridViewServico.Rows[i].Cells["Quant. Vezes)"].Value = quantidadeVezesValues[i];
                }
            }

            // Validando a entrada da coluna "Quantidade de Vezes" para aceitar apenas números
            dataGridViewServico.EditingControlShowing += (s, e) =>
            {
                if (dataGridViewServico.CurrentCell.ColumnIndex == dataGridViewServico.Columns["Quant. Vezes"].Index)
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
            dataGridViewPeca.Columns[0].Name = "Id Peça";
            dataGridViewPeca.Columns[0].ReadOnly = true; // Somente leitura

            dataGridViewPeca.Columns[1].Name = "Nome";
            dataGridViewPeca.Columns[1].ReadOnly = true; // Somente leitura

            dataGridViewPeca.Columns[2].Name = "Marca";
            dataGridViewPeca.Columns[2].ReadOnly = true; // Somente leitura

            dataGridViewPeca.Columns[3].Name = "Tipo";
            dataGridViewPeca.Columns[3].ReadOnly = true; // Somente leitura

            dataGridViewPeca.Columns[4].Name = "Quant. no Estoque";
            dataGridViewPeca.Columns[4].ReadOnly = true; // Somente leitura

            dataGridViewPeca.Columns[5].Name = "Valor";
            dataGridViewPeca.Columns[5].ReadOnly = true; // Somente leitura

            dataGridViewPeca.Columns[6].Name = "Fornecedor";
            dataGridViewPeca.Columns[6].ReadOnly = true; // Somente leitura

            // Criando a coluna "Quantidade de Vezes" (apenas números, editável)
            DataGridViewTextBoxColumn quantidadeVezesColumn2 = new DataGridViewTextBoxColumn();
            quantidadeVezesColumn2.Name = "Quant. Vezes";
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
                string quantEstoque = peca["QUANTPECA"].ToString();
                string valorPeca = peca["VALORPECA"].ToString();
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
                row.Cells[4].Value = quantEstoque;
                row.Cells[5].Value = valorPeca;
                row.Cells[6].Value = fornecedor;
                row.Cells[7].Value = 1; // Valor padrão para "Quantidade de Vezes"
                row.Cells[8].Value = false; // Valor padrão para "Selecionar" (desmarcado)

                dataGridViewPeca.Rows.Add(row);
            }

            // Validando a entrada da coluna "Quantidade de Vezes" para aceitar apenas números
            dataGridViewPeca.EditingControlShowing += (s, e) =>
            {
                if (dataGridViewPeca.CurrentCell.ColumnIndex == dataGridViewPeca.Columns["Quant. Vezes" +
                    ""].Index)
                {
                    TextBox tb = e.Control as TextBox;
                    if (tb != null)
                    {
                        tb.KeyPress -= new KeyPressEventHandler(TextBox_KeyPress2);
                        tb.KeyPress += new KeyPressEventHandler(TextBox_KeyPress2);
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


        private void AtualizarValoresTotais()
        {
            decimal valorTotalPecas = CalcularValorTotal(dataGridViewPeca);
            decimal valorTotalServicos = CalcularValorTotal(dataGridViewServico);

            // Atualiza as MaskedTextBoxes de valores totais
            maskedTextBoxValorTotalPecas.Text = valorTotalPecas.ToString("0.00");
            maskedTextBoxValorTotalServicos.Text = valorTotalServicos.ToString("0.00");

            // Aplicar descontos
            decimal valorFinalPecas = AplicarDescontosParciais(valorTotalPecas, maskedTextBoxDescontoRPeca, maskedTextBoxDescontoPPecaDesconto);
            decimal valorFinalServicos = AplicarDescontosParciais(valorTotalServicos, maskedTextBoxDescontoRServico, maskedTextBoxDescontoPServico);

            // Calcular o valor total final
            decimal valorTotalPedido = valorFinalPecas + valorFinalServicos;

            // Aplicar descontos gerais no pedido
            valorTotalPedido -= AplicarDescontosTotais(maskedTextBoxDescontoTotalReais, maskedTextBoxDescontoTotalPorc, valorTotalPedido);

            // Atualize o valor total do pedido
            maskedTextBoxValorTotal.Text = valorTotalPedido.ToString("0.00");
        }

        private decimal CalcularValorTotal(DataGridView dataGridView)
        {
            decimal valorTotal = 0;

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.IsNewRow) continue;

                // Verifica se a linha está selecionada
                if (row.Cells["Selecionar"]?.Value is bool isSelected && isSelected)
                {
                    int quantidadeVezes = row.Cells["Quant. Vezes"]?.Value != null
                        ? Convert.ToInt32(row.Cells["Quant. Vezes"].Value)
                        : 0;

                    decimal valorUnitario = row.Cells["Valor"]?.Value != null
                        ? Convert.ToDecimal(row.Cells["Valor"].Value)
                        : 0;

                    valorTotal += quantidadeVezes * valorUnitario;
                }
            }

            return valorTotal;
        }

        private decimal AplicarDescontosParciais(decimal valorTotal, MaskedTextBox descontoReaisBox, MaskedTextBox descontoPorcentagemBox)
        {
            decimal descontoReais = decimal.TryParse(descontoReaisBox.Text, out decimal dr) ? dr : 0;
            decimal descontoPorcentagem = decimal.TryParse(descontoPorcentagemBox.Text, out decimal dp) ? dp / 100 : 0;

            return valorTotal - descontoReais - (valorTotal * descontoPorcentagem);
        }

        private decimal AplicarDescontosTotais(MaskedTextBox descontoReaisBox, MaskedTextBox descontoPorcentagemBox, decimal valorTotalPedido)
        {
            decimal descontoReais = decimal.TryParse(descontoReaisBox.Text, out decimal dr) ? dr : 0;
            decimal descontoPorcentagem = decimal.TryParse(descontoPorcentagemBox.Text, out decimal dp) ? dp / 100 : 0;

            return descontoReais + (valorTotalPedido * descontoPorcentagem);
        }

        private void dataGridViewPeca_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != dataGridViewPeca.Columns["Selecionar"].Index) return;

            // Alterna o valor da checkbox
            var checkBox = (DataGridViewCheckBoxCell)dataGridViewPeca.Rows[e.RowIndex].Cells["Selecionar"];
            bool isChecked = checkBox.Value != null && Convert.ToBoolean(checkBox.Value);
            checkBox.Value = !isChecked;

            AtualizarValoresTotais();
        }

        private void dataGridViewServico_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != dataGridViewServico.Columns["Selecionar"].Index) return;

            // Alterna o valor da checkbox
            var checkBox = (DataGridViewCheckBoxCell)dataGridViewServico.Rows[e.RowIndex].Cells["Selecionar"];
            bool isChecked = checkBox.Value != null && Convert.ToBoolean(checkBox.Value);
            checkBox.Value = !isChecked;

            AtualizarValoresTotais();
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
                mPedido.setValorTotalPedido(valor);
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
            }

            //Cria as listas para extrair os valores das datagridview
            List<Pedido_Peca> ListaDePecas = ExtrairPecasDataGridView(dataGridViewPeca);
            List<Servico> ListaDeServicos = ExtrairServicosDataGridView(dataGridViewServico);

            string resultado = cPedido.cadastroCompletoPedido(mPedido, ListaDePecas, ListaDeServicos);

            //Mostra os resultados
            MessageBox.Show(resultado);
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
            // Armazena os estados das checkboxes e os valores de "Quantidade de Vezes" antes de limpar
            List<bool> checkboxStates = new List<bool>();
            List<int> quantidadeVezesValues = new List<int>();

            for (int i = 0; i < dataGridViewPeca.Rows.Count; i++)
            {
                if (!dataGridViewPeca.Rows[i].IsNewRow)
                {
                    checkboxStates.Add(dataGridViewPeca.Rows[i].Cells["Selecionar"].Value is bool isChecked && isChecked);
                    quantidadeVezesValues.Add(Convert.ToInt32(dataGridViewPeca.Rows[i].Cells["Quant. Vezes"].Value));
                }
            }

            // Limpar as linhas da DataGridView, exceto as que têm o checkbox "Selecionar" marcado
            for (int i = dataGridViewPeca.Rows.Count - 1; i >= 0; i--)
            {
                if (!dataGridViewPeca.Rows[i].IsNewRow &&
                    !(dataGridViewPeca.Rows[i].Cells["Selecionar"].Value is bool isChecked && isChecked))
                {
                    dataGridViewPeca.Rows.RemoveAt(i);
                }
            }

            // Criação do objeto NpgsqlDataReader peca e controlePeca
            controlePeca cPeca = new controlePeca();
            NpgsqlDataReader peca = cPeca.pesquisaPeca(textBoxPesquisarP.Text);

            // Definindo a quantidade de colunas que a grid terá
            dataGridViewPeca.ColumnCount = 6;

            // Definindo as colunas na DataGridView para exibir as descrições das peças
            dataGridViewPeca.Columns[0].Name = "Id Peça";
            dataGridViewPeca.Columns[0].ReadOnly = true;

            dataGridViewPeca.Columns[1].Name = "Nome";
            dataGridViewPeca.Columns[1].ReadOnly = true;

            dataGridViewPeca.Columns[2].Name = "Marca";
            dataGridViewPeca.Columns[2].ReadOnly = true;

            dataGridViewPeca.Columns[3].Name = "Tipo";
            dataGridViewPeca.Columns[3].ReadOnly = true;

            dataGridViewPeca.Columns[4].Name = "Valor";
            dataGridViewPeca.Columns[4].ReadOnly = true;

            dataGridViewPeca.Columns[5].Name = "Fornecedor";
            dataGridViewPeca.Columns[5].ReadOnly = true;

            // Criando a coluna "Quantidade de Vezes" (apenas números, editável)
            DataGridViewTextBoxColumn quantidadeVezesColumn2 = new DataGridViewTextBoxColumn();
            quantidadeVezesColumn2.Name = "Quant. Vezes";
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
                string fornecedor = peca["FORNECEDOR"].ToString();

                // Consulta o nome da marca pelo id
                string marca = cPeca.pesquisaMarcaPecaPorId(idMarca);

                // Verifique se a linha já existe
                bool exists = false;
                foreach (DataGridViewRow existingRow in dataGridViewPeca.Rows)
                {
                    if (!existingRow.IsNewRow &&
                        existingRow.Cells["Id Peça"].Value.ToString() == idPeca &&
                        existingRow.Cells["Nome"].Value.ToString() == nomePeca &&
                        existingRow.Cells["Marca"].Value.ToString() == marca)
                    {
                        exists = true;
                        break;
                    }
                }

                // Adiciona a nova linha apenas se não existir
                if (!exists)
                {
                    // Criando a nova linha manualmente
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dataGridViewPeca); // Define a grid para onde a linha vai

                    // Preenchendo a linha com os valores
                    row.Cells[0].Value = idPeca;
                    row.Cells[1].Value = nomePeca;
                    row.Cells[2].Value = marca;
                    row.Cells[3].Value = tipoPeca;
                    row.Cells[4].Value = valorPeca;
                    row.Cells[5].Value = fornecedor;
                    row.Cells[6].Value = 1; // Valor padrão para "Quantidade de Vezes"
                    row.Cells[7].Value = false; // Valor padrão para "Selecionar" (desmarcado)

                    dataGridViewPeca.Rows.Add(row);
                }
            }

            // Após adicionar novas linhas, restaure os estados das checkboxes e os valores de "Quantidade de Vezes"
            for (int i = 0; i < dataGridViewPeca.Rows.Count; i++)
            {
                if (i < checkboxStates.Count)
                {
                    dataGridViewPeca.Rows[i].Cells["Selecionar"].Value = checkboxStates[i];
                    dataGridViewPeca.Rows[i].Cells["Quant. Vezes"].Value = quantidadeVezesValues[i];
                }
            }

            // Validando a entrada da coluna "Quantidade de Vezes" para aceitar apenas números
            dataGridViewPeca.EditingControlShowing += (s, e) =>
            {
                if (dataGridViewPeca.CurrentCell.ColumnIndex == dataGridViewPeca.Columns["Quant. Vezes"].Index)
                {
                    TextBox tb = e.Control as TextBox;
                    if (tb != null)
                    {
                        tb.KeyPress -= new KeyPressEventHandler(TextBox_KeyPress2);
                        tb.KeyPress += new KeyPressEventHandler(TextBox_KeyPress2);
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
        }


        #endregion

        #region Pesquisar serviço
        // Evento de pesquisar serviço
        private void buttonPesquisarServico_Click(object sender, EventArgs e)
        {
            // Armazena os estados das checkboxes e os valores de "Quantidade de Vezes" antes de limpar
            List<bool> checkboxStates = new List<bool>();
            List<int> quantidadeVezesValues = new List<int>();

            for (int i = 0; i < dataGridViewServico.Rows.Count; i++)
            {
                if (!dataGridViewServico.Rows[i].IsNewRow)
                {
                    checkboxStates.Add(dataGridViewServico.Rows[i].Cells["Selecionar"].Value is bool isChecked && isChecked);
                    quantidadeVezesValues.Add(Convert.ToInt32(dataGridViewServico.Rows[i].Cells["Quant. Vezes"].Value));
                }
            }

            // Limpar as linhas da DataGridView, exceto as que têm o checkbox "Selecionar" marcado
            for (int i = dataGridViewServico.Rows.Count - 1; i >= 0; i--)
            {
                if (!dataGridViewServico.Rows[i].IsNewRow &&
                    !(dataGridViewServico.Rows[i].Cells["Selecionar"].Value is bool isChecked && isChecked))
                {
                    dataGridViewServico.Rows.RemoveAt(i);
                }
            }

            // Criação do objeto NpgsqlDataReader servico e controleServico
            controleServico cServico = new controleServico();
            NpgsqlDataReader servico = cServico.pesquisaServico(textBoxPesquisarS.Text);

            // Definindo a quantidade de colunas que a grid terá
            dataGridViewServico.ColumnCount = 6;

            // Definindo as colunas na DataGridView para exibir as descrições
            dataGridViewServico.Columns[0].Name = "Id Serviço";
            dataGridViewServico.Columns[0].ReadOnly = true;

            dataGridViewServico.Columns[1].Name = "Nome";
            dataGridViewServico.Columns[1].ReadOnly = true;

            dataGridViewServico.Columns[2].Name = "Valor";
            dataGridViewServico.Columns[2].ReadOnly = true;

            dataGridViewServico.Columns[3].Name = "Descrição";
            dataGridViewServico.Columns[3].ReadOnly = true;

            dataGridViewServico.Columns[4].Name = "Garantia";
            dataGridViewServico.Columns[4].ReadOnly = true;

            dataGridViewServico.Columns[5].Name = "Funcionário";
            dataGridViewServico.Columns[5].ReadOnly = true;

            // Criando a coluna "Quantidade de Vezes" (apenas números, editável)
            DataGridViewTextBoxColumn quantidadeVezesColumn = new DataGridViewTextBoxColumn();
            quantidadeVezesColumn.Name = "Quant. Vezes";
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
                string idServico = servico["IDSERVICO"].ToString();
                string nomeServico = servico["NOMESERVICO"].ToString();
                string valorServico = servico["VALORSERVICO"].ToString();
                string descServico = servico["DESCSERVICO"].ToString();
                string garantiaServico = servico["GARANTIASERVICO"].ToString();
                string funcionarioServico = servico["FUNCIONARIO"].ToString();

                // Verifique se a linha já existe
                bool exists = false;
                foreach (DataGridViewRow existingRow in dataGridViewServico.Rows)
                {
                    if (!existingRow.IsNewRow &&
                        existingRow.Cells["Id Serviço"].Value.ToString() == idServico &&
                        existingRow.Cells["Nome"].Value.ToString() == nomeServico)
                    {
                        exists = true;
                        break;
                    }
                }

                // Adiciona a nova linha apenas se não existir
                if (!exists)
                {
                    // Criando a nova linha manualmente
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dataGridViewServico); // Define a grid para onde a linha vai

                    // Preenchendo a linha com os valores
                    row.Cells[0].Value = idServico;
                    row.Cells[1].Value = nomeServico;
                    row.Cells[2].Value = valorServico;
                    row.Cells[3].Value = descServico;
                    row.Cells[4].Value = garantiaServico;
                    row.Cells[5].Value = funcionarioServico;
                    row.Cells[6].Value = 1; // Valor padrão para "Quantidade de Vezes"
                    row.Cells[7].Value = false; // Valor padrão para "Selecionar" (desmarcado)

                    dataGridViewServico.Rows.Add(row);
                }
            }

            // Após adicionar novas linhas, restaure os estados das checkboxes e os valores de "Quantidade de Vezes"
            for (int i = 0; i < dataGridViewServico.Rows.Count; i++)
            {
                if (i < checkboxStates.Count)
                {
                    dataGridViewServico.Rows[i].Cells["Selecionar"].Value = checkboxStates[i];
                    dataGridViewServico.Rows[i].Cells["Quant. Vezes"].Value = quantidadeVezesValues[i];
                }
            }

            // Validando a entrada da coluna "Quantidade de Vezes" para aceitar apenas números
            dataGridViewServico.EditingControlShowing += (s, e) =>
            {
                if (dataGridViewServico.CurrentCell.ColumnIndex == dataGridViewServico.Columns["Quant. Vezes"].Index)
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
        }
        #endregion



        public List<Pedido_Peca> ExtrairPecasDataGridView(DataGridView dataGridViewPeca)
        {
            List<Pedido_Peca> Pecas = new List<Pedido_Peca>();

            foreach (DataGridViewRow row in dataGridViewPeca.Rows)
            {
                if (!row.IsNewRow && Convert.ToBoolean(row.Cells["Selecionar"].Value))
                {
                    Pedido_Peca peca = new Pedido_Peca();

                    if (long.TryParse(row.Cells["Id Peça"].Value?.ToString(), out long idPeca))
                    {
                        peca.setIdPeca(idPeca);
                    }

                    if (int.TryParse(row.Cells["Quant. Vezes"].Value?.ToString(), out int quantVezes))
                    {
                        peca.setQuantVezes(quantVezes);
                    }

                    Pecas.Add(peca);
                }
            }

            return Pecas;
        }




        #region Extrai os serviços
        public List<Servico> ExtrairServicosDataGridView(DataGridView dataGridViewServico)
        {
            List<Servico> Servicos = new List<Servico>();

            foreach (DataGridViewRow row in dataGridViewServico.Rows)
            {
                if (!row.IsNewRow && Convert.ToBoolean(row.Cells["Selecionar"].Value))
                {
                    Servico servico = new Servico();

                    if (long.TryParse(row.Cells["Id Serviço"].Value?.ToString(), out long idServico))
                    {
                        servico.setIDServico(idServico);
                    }

                    if (int.TryParse(row.Cells["Quant. Vezes"].Value?.ToString(), out int quantVezes))
                    {
                        servico.setQuantVezes(quantVezes);
                    }

                    Servicos.Add(servico);
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

        private void maskedTextBoxDescontoRServico_TextChanged_1(object sender, EventArgs e)
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
                maskedTextBox.TextChanged -= maskedTextBoxDescontoRServico_TextChanged_1; // Remove o evento para evitar loop

                // Formata o valor com ponto como separador de centavos e sem separadores de milhar
                maskedTextBox.Text = string.Format("{0:0.00}", valorDecimal / 100);

                // Coloca o cursor no final
                maskedTextBox.SelectionStart = maskedTextBox.Text.Length;

                maskedTextBox.TextChanged += maskedTextBoxDescontoRServico_TextChanged_1; // Reinscreve o evento
            }
            AtualizarValoresTotais();
        }
    }
}
