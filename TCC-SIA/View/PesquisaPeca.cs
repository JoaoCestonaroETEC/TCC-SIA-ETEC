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

            // Ensure a row is selected
            if (dataGridViewPesquisar.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridViewPesquisar.SelectedRows[0];

                // Retrieve the ID of the item to delete and set it in mPeca
                long idPeca = Convert.ToInt64(selectedRow.Cells["Id"].Value);

                // Create instances of controlePeca and Peca
                controlePeca cPeca = new controlePeca();
                Peca mPeca = new Peca();
                mPeca.setIdPeca(idPeca);  // Set the ID using the setter method

                // Call the delete method on controlePeca
                string result = cPeca.deletarPeca(mPeca);

                if (result == "Part deleted successfully.")
                {
                    // Remove the row from the DataGridView
                    dataGridViewPesquisar.Rows.Remove(selectedRow);
                    MessageBox.Show("Item deleted successfully.");
                }
                else
                {
                    MessageBox.Show(result); // Display any error messages returned by deletarPeca
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }

        }
    }
}