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
            // Criação do objeto NpgsqlDataReader peça e controlePeca
            controlePeca cPeca = new controlePeca();
            NpgsqlDataReader peca = cPeca.listaPeca();

            // Armazena os estados das checkboxes antes de limpar
            List<bool> checkboxStates = new List<bool>();

            for (int i = 0; i < dataGridViewPesquisar.Rows.Count; i++)
            {
                if (!dataGridViewPesquisar.Rows[i].IsNewRow)
                {
                    checkboxStates.Add(dataGridViewPesquisar.Rows[i].Cells["Selecionar"].Value is bool isChecked && isChecked);
                }
            }

            // Apaga as colunas da datagridview
            dataGridViewPesquisar.Columns.Clear();

            // Desabilitar a adição automática de novas linhas
            dataGridViewPesquisar.AllowUserToAddRows = false;

            // Definindo a quantidade de colunas que a grid terá
            dataGridViewPesquisar.ColumnCount = 11;

            // Definindo as colunas na DataGridView para exibir as descrições
            dataGridViewPesquisar.Columns[0].Name = "Id";
            dataGridViewPesquisar.Columns[0].ReadOnly = true;

            dataGridViewPesquisar.Columns[1].Name = "Marca";
            dataGridViewPesquisar.Columns[1].ReadOnly = true;

            dataGridViewPesquisar.Columns[2].Name = "Nome";
            dataGridViewPesquisar.Columns[2].ReadOnly = true;

            dataGridViewPesquisar.Columns[3].Name = "Tipo";
            dataGridViewPesquisar.Columns[3].ReadOnly = true;

            dataGridViewPesquisar.Columns[4].Name = "Valor";
            dataGridViewPesquisar.Columns[4].ReadOnly = true;

            dataGridViewPesquisar.Columns[5].Name = "Quantidade";
            dataGridViewPesquisar.Columns[5].ReadOnly = true;

            dataGridViewPesquisar.Columns[6].Name = "Garantia";
            dataGridViewPesquisar.Columns[6].ReadOnly = true;

            dataGridViewPesquisar.Columns[7].Name = "Unidade";
            dataGridViewPesquisar.Columns[7].ReadOnly = true;

            dataGridViewPesquisar.Columns[8].Name = "Data de Aquisição";
            dataGridViewPesquisar.Columns[8].ReadOnly = true;

            dataGridViewPesquisar.Columns[9].Name = "Fornecedor";
            dataGridViewPesquisar.Columns[9].ReadOnly = true;

            dataGridViewPesquisar.Columns[10].Name = "Descrição";
            dataGridViewPesquisar.Columns[10].ReadOnly = true;

            // Criando a coluna de checkbox para marcação (editável)
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.Name = "Selecionar";
            checkBoxColumn.ReadOnly = false; // Deixando a checkbox editável
            dataGridViewPesquisar.Columns.Add(checkBoxColumn);

            // Adicionando as descrições das peças
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
                string descricao = peca["DESCPECA"].ToString();

                // Consulta o nome da marca pelo id
                string marca = cPeca.pesquisaMarcaPecaPorId(idMarca);

                // Verifique se a linha já existe
                bool exists = false;
                foreach (DataGridViewRow existingRow in dataGridViewPesquisar.Rows)
                {
                    if (!existingRow.IsNewRow &&
                        existingRow.Cells["Id"].Value.ToString() == idPeca)
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
                    row.CreateCells(dataGridViewPesquisar); // Define a grid para onde a linha vai

                    // Preenchendo a linha com os valores
                    row.Cells[0].Value = idPeca;
                    row.Cells[1].Value = marca;
                    row.Cells[2].Value = nomePeca;
                    row.Cells[3].Value = tipoPeca;
                    row.Cells[4].Value = valorPeca;
                    row.Cells[5].Value = quantPeca;
                    row.Cells[6].Value = garantiaPeca;
                    row.Cells[7].Value = unidade;
                    row.Cells[8].Value = dataAquis;
                    row.Cells[9].Value = fornecedor;
                    row.Cells[10].Value = descricao;
                    row.Cells[11].Value = false; // Valor padrão para "Selecionar" (desmarcado)

                    dataGridViewPesquisar.Rows.Add(row);
                }
            }

            // Após adicionar novas linhas, restaure os estados das checkboxes
            for (int i = 0; i < dataGridViewPesquisar.Rows.Count; i++)
            {
                if (i < checkboxStates.Count)
                {
                    dataGridViewPesquisar.Rows[i].Cells["Selecionar"].Value = checkboxStates[i];
                }
            }
            #endregion


        }
        #endregion

        #region Pesquisar peça
        //Evento de pesquisar peça
        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            // Criação do objeto NpgsqlDataReader peça e controlePeca
            controlePeca cPeca = new controlePeca();
            NpgsqlDataReader peca = cPeca.pesquisaPeca(textBoxPesquisar.Text);

            // Armazena os estados das checkboxes antes de limpar
            List<bool> checkboxStates = new List<bool>();

            for (int i = 0; i < dataGridViewPesquisar.Rows.Count; i++)
            {
                if (!dataGridViewPesquisar.Rows[i].IsNewRow)
                {
                    checkboxStates.Add(dataGridViewPesquisar.Rows[i].Cells["Selecionar"].Value is bool isChecked && isChecked);
                }
            }

            // Apaga as colunas da datagridview
            dataGridViewPesquisar.Columns.Clear();

            // Desabilitar a adição automática de novas linhas
            dataGridViewPesquisar.AllowUserToAddRows = false;

            // Definindo a quantidade de colunas que a grid terá
            dataGridViewPesquisar.ColumnCount = 11;

            // Definindo as colunas na DataGridView para exibir as descrições
            dataGridViewPesquisar.Columns[0].Name = "Id";
            dataGridViewPesquisar.Columns[0].ReadOnly = true;

            dataGridViewPesquisar.Columns[1].Name = "Marca";
            dataGridViewPesquisar.Columns[1].ReadOnly = true;

            dataGridViewPesquisar.Columns[2].Name = "Nome";
            dataGridViewPesquisar.Columns[2].ReadOnly = true;

            dataGridViewPesquisar.Columns[3].Name = "Tipo";
            dataGridViewPesquisar.Columns[3].ReadOnly = true;

            dataGridViewPesquisar.Columns[4].Name = "Valor";
            dataGridViewPesquisar.Columns[4].ReadOnly = true;

            dataGridViewPesquisar.Columns[5].Name = "Quantidade";
            dataGridViewPesquisar.Columns[5].ReadOnly = true;

            dataGridViewPesquisar.Columns[6].Name = "Garantia";
            dataGridViewPesquisar.Columns[6].ReadOnly = true;

            dataGridViewPesquisar.Columns[7].Name = "Unidade";
            dataGridViewPesquisar.Columns[7].ReadOnly = true;

            dataGridViewPesquisar.Columns[8].Name = "Data de Aquisição";
            dataGridViewPesquisar.Columns[8].ReadOnly = true;

            dataGridViewPesquisar.Columns[9].Name = "Fornecedor";
            dataGridViewPesquisar.Columns[9].ReadOnly = true;

            dataGridViewPesquisar.Columns[10].Name = "Descrição";
            dataGridViewPesquisar.Columns[10].ReadOnly = true;

            // Criando a coluna de checkbox para marcação (editável)
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.Name = "Selecionar";
            checkBoxColumn.ReadOnly = false; // Deixando a checkbox editável
            dataGridViewPesquisar.Columns.Add(checkBoxColumn);

            // Adicionando as descrições das peças
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
                string descricao = peca["DESCPECA"].ToString();

                // Consulta o nome da marca pelo id
                string marca = cPeca.pesquisaMarcaPecaPorId(idMarca);

                // Verifique se a linha já existe
                bool exists = false;
                foreach (DataGridViewRow existingRow in dataGridViewPesquisar.Rows)
                {
                    if (!existingRow.IsNewRow &&
                        existingRow.Cells["Id"].Value.ToString() == idPeca)
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
                    row.CreateCells(dataGridViewPesquisar); // Define a grid para onde a linha vai

                    // Preenchendo a linha com os valores
                    row.Cells[0].Value = idPeca;
                    row.Cells[1].Value = marca;
                    row.Cells[2].Value = nomePeca;
                    row.Cells[3].Value = tipoPeca;
                    row.Cells[4].Value = valorPeca;
                    row.Cells[5].Value = quantPeca;
                    row.Cells[6].Value = garantiaPeca;
                    row.Cells[7].Value = unidade;
                    row.Cells[8].Value = dataAquis;
                    row.Cells[9].Value = fornecedor;
                    row.Cells[10].Value = descricao;
                    row.Cells[11].Value = false; // Valor padrão para "Selecionar" (desmarcado)

                    dataGridViewPesquisar.Rows.Add(row);
                }
            }

            // Após adicionar novas linhas, restaure os estados das checkboxes
            for (int i = 0; i < dataGridViewPesquisar.Rows.Count; i++)
            {
                if (i < checkboxStates.Count)
                {
                    dataGridViewPesquisar.Rows[i].Cells["Selecionar"].Value = checkboxStates[i];
                }
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

        #region Listar Fornecedor
        public void listarFornecedor()
        {
            controlePeca cPeca = new controlePeca();
            //Recebe os dados da consulta e salva no dataReader (Tipo)
            NpgsqlDataReader peca = cPeca.listaFornecedor();

            //Converter o dataReader em DataTable
            DataTable dtFornecedor = new DataTable();
            dtFornecedor.Load(peca);

            //Preencher a combobox com os dados do DataTable
            comboBoxFornecedor.DataSource = dtFornecedor;

            //Define qual coluna do DataTable que será exibida (nome da coluna)
            comboBoxFornecedor.DisplayMember = "FORNECEDOR";

            //Define qual o valor da linha será utilizado ao selecionar um valor
            comboBoxFornecedor.ValueMember = "FORNECEDOR";
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
<<<<<<< HEAD
            decimal valor;
            if (decimal.TryParse(maskedTextBoxValor.Text, out valor))
            {
                mPeca.setValorPeca(valor);
            }
=======
            mPeca.setFornecedor(comboBoxFornecedor.Text);
            mPeca.setValorPeca(Convert.ToInt32(maskedTextBoxValor.Text));
>>>>>>> deae05ff8a6420e700280864cfe569a1ea72a801
            mPeca.setQuantPeca(Convert.ToInt32(numericUpDownQuant.Text));
            mPeca.setGarantiaPeca(Convert.ToDateTime(dateTimePickerGarantia.Text));

            //Chamada ao método de cadastro no ControleCliente
            string res = cPeca.atualizaPeca(mPeca);

            //Mostra o resultado
            MessageBox.Show(res);
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewPesquisar.Rows)
            {
                // Verifica se a linha contém pelo menos 11 células e se a célula "Selecionar" (índice 10) está marcada
                if (row.Cells.Count > 11 && Convert.ToBoolean(row.Cells[11].Value) == true)
                {
                    DialogResult res = MessageBox.Show("Deseja atualizar este registro?", "Atualização de registro",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                    if (res == DialogResult.OK)
                    {
                        // Atualiza os campos no formulário com base nos valores da DataGridView
                        maskedTextBoxID.Text = dataGridViewPesquisar.CurrentRow.Cells[0].Value.ToString(); // Id
                        comboBoxMarca.Text = dataGridViewPesquisar.CurrentRow.Cells[1].Value.ToString(); // Marca
                        textBoxNome.Text = dataGridViewPesquisar.CurrentRow.Cells[2].Value.ToString(); // Nome
                        comboBoxTipo.Text = dataGridViewPesquisar.CurrentRow.Cells[3].Value.ToString(); // Tipo
                        maskedTextBoxValor.Text = dataGridViewPesquisar.CurrentRow.Cells[4].Value.ToString(); // Valor
                        numericUpDownQuant.Value = Convert.ToDecimal(dataGridViewPesquisar.CurrentRow.Cells[5].Value); // Quantidade
                        dateTimePickerGarantia.Value = Convert.ToDateTime(dataGridViewPesquisar.CurrentRow.Cells[6].Value.ToString()); // Garantia
                        numericUpDownUnidade.Text = dataGridViewPesquisar.CurrentRow.Cells[7].Value.ToString(); // Unidade
                        dateTimePickerAquisicao.Value = Convert.ToDateTime(dataGridViewPesquisar.CurrentRow.Cells[8].Value.ToString()); // Data de Aquisição
                        comboBoxFornecedor.Text = dataGridViewPesquisar.CurrentRow.Cells[9].Value.ToString(); // Fornecedor
                        richTextBoxDesc.Text = dataGridViewPesquisar.CurrentRow.Cells[10].Value.ToString();

                        // Troca para a aba de edição
                        tabControl1.SelectedTab = tabPage2;
                    }
                }
            }

        }
        private void btnDeletar_Click(object sender, EventArgs e)
        {

            // Lista para armazenar os IDs dos pedidos a serem deletados
            List<long> pecasParaDeletar = new List<long>();

            // Percorrer todas as linhas do DataGridView
            foreach (DataGridViewRow row in dataGridViewPesquisar.Rows)
            {
                // Verifica se a checkbox está marcada na linha
                bool isSelected = Convert.ToBoolean(row.Cells["Selecionar"].Value);

                if (isSelected)
                {
                    // Recupera o ID do pedido da linha
                    long idPeca = Convert.ToInt64(row.Cells["Id"].Value);
                    pecasParaDeletar.Add(idPeca);
                }
            }

            if (pecasParaDeletar.Count > 0)
            {
                // Inicializa o controlePedido para acessar o método de deletação
                controlePeca cPeca = new controlePeca();

                // Deletar cada pedido selecionado
                foreach (int idPeca in pecasParaDeletar)
                {
                    Peca mPeca = new Peca();
                    mPeca.setIdPeca(idPeca);

                    // Chama o método para deletar o pedido
                    string resultMessage = cPeca.deletarPeca(mPeca);

                    // Exibe o resultado da exclusão
                    MessageBox.Show(resultMessage);
                }
            }
            else
            {
                MessageBox.Show("Please select at least one order to delete.");
            }

        }

        private void comboBoxTipo_DropDown(object sender, EventArgs e)
        {
            listarTipo();
        }

        private void comboBoxMarca_DropDown(object sender, EventArgs e)
        {
            listarMarca();
        }

        private void comboBoxFornecedor_DropDown(object sender, EventArgs e)
        {
            listarFornecedor();
        }

        private void comboBoxFornecedor_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            System.Windows.Forms.ComboBox comboBox = sender as System.Windows.Forms.ComboBox;
            string fornecedorDigitado = comboBox.Text;

            // Verifica se o valor digitado já existe na lista de itens da ComboBox
            bool fornecedorExiste = comboBox.Items.Cast<System.Data.DataRowView>()
                                       .Any(item => item["FORNECEDOR"].ToString()
                                       .Equals(fornecedorDigitado, StringComparison.OrdinalIgnoreCase));

            if (!fornecedorExiste && !string.IsNullOrEmpty(fornecedorDigitado))
            {
                // Exibe a mensagem com o aviso
                DialogResult result = MessageBox.Show("Aviso! Fornecedor não registrado, deseja adicionar um novo?",
                                                      "Novo Fornecedor",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Ação para adicionar um novo fornecedor (sem adicionar o valor na ComboBox diretamente)
                    MessageBox.Show("Mantenha o valor digitado para cadastrar um novo fornecedor",
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

        private void maskedTextBoxValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir apenas números e a tecla Backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Bloqueia a entrada
            }
        }

        private void maskedTextBoxValor_TextChanged(object sender, EventArgs e)
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
                maskedTextBox.TextChanged -= maskedTextBoxValor_TextChanged; // Remove o evento para evitar loop

                // Formata o valor com ponto como separador de centavos e sem separadores de milhar
                maskedTextBox.Text = string.Format("{0:0.00}", valorDecimal / 100);

                // Coloca o cursor no final
                maskedTextBox.SelectionStart = maskedTextBox.Text.Length;

                maskedTextBox.TextChanged += maskedTextBoxValor_TextChanged; // Reinscreve o evento
            }
        }

        private void maskedTextBoxValor_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            // Permitir apenas números e a tecla Backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Bloqueia a entrada
            }
        }
    }
}