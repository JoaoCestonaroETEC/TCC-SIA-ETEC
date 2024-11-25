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
using Npgsql;
using TCC_SIA.Model;
using System.Text.RegularExpressions;

namespace TCC_SIA.View
{
    public partial class PesquisaMarca : Form
    {

        #region Inicializa o formulário
        public PesquisaMarca()
        {
            InitializeComponent();


            #region Carrega os dados de pesquisa de serviços
            // Criação do objeto NpgsqlDataReader servico e controleServico
            controleMarca cMarca = new controleMarca();
            NpgsqlDataReader marca = cMarca.pesquisaMarca(textBoxPesquisar.Text);

            // Armazena os estados das checkboxes e os valores de "Quantidade de Vezes" antes de limpar
            List<bool> checkboxStates = new List<bool>();
            List<int> quantidadeVezesValues = new List<int>();

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
            dataGridViewPesquisar.ColumnCount = 4;

            // Definindo as colunas na DataGridView para exibir as descrições
            dataGridViewPesquisar.Columns[0].Name = "Id Marca";
            dataGridViewPesquisar.Columns[0].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisar.Columns[1].Name = "Nome";
            dataGridViewPesquisar.Columns[1].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisar.Columns[2].Name = "Descrição";
            dataGridViewPesquisar.Columns[2].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisar.Columns[3].Name = "Tipo da Marca";
            dataGridViewPesquisar.Columns[3].ReadOnly = true; // Definindo como somente leitura

            // Criando a coluna de checkbox para marcação (editável)
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.Name = "Selecionar";
            checkBoxColumn.ReadOnly = false; // Deixando a checkbox editável
            dataGridViewPesquisar.Columns.Add(checkBoxColumn);

            // Adicionando as descrições dos serviços
            while (marca.Read())
            {
                string idMarca = marca["IDMARCA"].ToString();
                string nomeMarca = marca["NOMEMARCA"].ToString();
                string descMarca = marca["DESCMARCA"].ToString();
                string tipoMarca = marca["TIPOMARCA"].ToString();

                // Verifique se a linha já existe
                bool exists = false;
                foreach (DataGridViewRow existingRow in dataGridViewPesquisar.Rows)
                {
                    if (!existingRow.IsNewRow &&
                        existingRow.Cells["Id Marca"].Value.ToString() == idMarca &&
                        existingRow.Cells["Nome"].Value.ToString() == nomeMarca)
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
                    row.Cells[0].Value = idMarca;
                    row.Cells[1].Value = nomeMarca;
                    row.Cells[2].Value = descMarca;
                    row.Cells[3].Value = tipoMarca;
                    row.Cells[4].Value = false; // Valor padrão para "Selecionar" (desmarcado)

                    dataGridViewPesquisar.Rows.Add(row);
                }
            }

            // Após adicionar novas linhas, restaure os estados das checkboxes e os valores de "Quantidade de Vezes"
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

        #region Pesquisar marcas

        //Evento de pesquisar marcas
        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            // Armazena os estados das checkboxes e os valores de "Quantidade de Vezes" antes de limpar
            List<bool> checkboxStates = new List<bool>();

            for (int i = 0; i < dataGridViewPesquisar.Rows.Count; i++)
            {
                if (!dataGridViewPesquisar.Rows[i].IsNewRow)
                {
                    checkboxStates.Add(dataGridViewPesquisar.Rows[i].Cells["Selecionar"].Value is bool isChecked && isChecked);
                }
            }

            // Limpar as linhas da DataGridView, exceto as que têm o checkbox "Selecionar" marcado
            for (int i = dataGridViewPesquisar.Rows.Count - 1; i >= 0; i--)
            {
                if (!dataGridViewPesquisar.Rows[i].IsNewRow &&
                    !(dataGridViewPesquisar.Rows[i].Cells["Selecionar"].Value is bool isChecked && isChecked))
                {
                    dataGridViewPesquisar.Rows.RemoveAt(i);
                }
            }

            // Criação do objeto NpgsqlDataReader servico e controleServico
            controleMarca cMarca = new controleMarca();
            NpgsqlDataReader marca = cMarca.pesquisaMarca(textBoxPesquisar.Text);

            // Definindo a quantidade de colunas que a grid terá
            dataGridViewPesquisar.ColumnCount = 4;

            // Definindo as colunas na DataGridView para exibir as descrições
            dataGridViewPesquisar.Columns[0].Name = "Id Marca";
            dataGridViewPesquisar.Columns[0].ReadOnly = true;

            dataGridViewPesquisar.Columns[1].Name = "Nome";
            dataGridViewPesquisar.Columns[1].ReadOnly = true;

            dataGridViewPesquisar.Columns[2].Name = "Descrição";
            dataGridViewPesquisar.Columns[2].ReadOnly = true;

            dataGridViewPesquisar.Columns[3].Name = "Tipo da Marca";
            dataGridViewPesquisar.Columns[3].ReadOnly = true;

            // Criando a coluna de checkbox para marcação (editável)
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.Name = "Selecionar";
            checkBoxColumn.ReadOnly = false; // Deixando a checkbox editável
            dataGridViewPesquisar.Columns.Add(checkBoxColumn);

            // Adicionando as descrições dos serviços
            while (marca.Read())
            {
                string idMarca = marca["IDMARCA"].ToString();
                string nomeMarca = marca["NOMEMARCA"].ToString();
                string descMarca = marca["DESCMARCA"].ToString();
                string tipoMarca = marca["TIPOMARCA"].ToString();

                // Verifique se a linha já existe
                bool exists = false;
                foreach (DataGridViewRow existingRow in dataGridViewPesquisar.Rows)
                {
                    if (!existingRow.IsNewRow &&
                        existingRow.Cells["Id Marca"].Value.ToString() == idMarca &&
                        existingRow.Cells["Nome"].Value.ToString() == nomeMarca)
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
                    row.Cells[0].Value = idMarca;
                    row.Cells[1].Value = nomeMarca;
                    row.Cells[2].Value = descMarca;
                    row.Cells[3].Value = tipoMarca;
                    row.Cells[4].Value = false; // Valor padrão para "Selecionar" (desmarcado)

                    dataGridViewPesquisar.Rows.Add(row);
                }
            }
        }
        #endregion

        #region Listar tipos
        public void listarTipos()
        {
            controleMarca cMarca = new controleMarca();
            // Recebe os dados da consulta e salva no dataReader (Tipo)
            NpgsqlDataReader marca = cMarca.listarNovasMarca();

            // Criar e configurar o DataTable
            DataTable dtTipo = new DataTable();

            // Definir as colunas do DataTable
            dtTipo.Columns.Add("ID", typeof(int));  // Supondo que o ID seja um int
            dtTipo.Columns.Add("TIPOMARCA", typeof(string)); // Supondo que o tipo seja uma string

            // Adicionar itens pré-configurados
            dtTipo.Rows.Add(-1, "Peças Automotívas");
            dtTipo.Rows.Add(-2, "Óleos lubrificantes");
            dtTipo.Rows.Add(-3, "Pneus");
            dtTipo.Rows.Add(-4, "Ferramentas e Equipamentos para oficinas");
            dtTipo.Rows.Add(-5, "Veiculos");

            // Carregar os dados do NpgsqlDataReader
            dtTipo.Load(marca);

            // Preencher a ComboBox com os dados do DataTable
            comboBoxTipo.DataSource = dtTipo;

            // Define qual coluna do DataTable que será exibida (nome da coluna)
            comboBoxTipo.DisplayMember = "TIPOMARCA";
        }
        #endregion

        private void comboBoxTipo_Validating(object sender, CancelEventArgs e)
        {
            System.Windows.Forms.ComboBox comboBox = sender as System.Windows.Forms.ComboBox;
            string fornecedorDigitado = comboBox.Text;

            // Verifica se o valor digitado já existe na lista de itens da ComboBox
            bool fornecedorExiste = comboBox.Items.Cast<System.Data.DataRowView>()
                                       .Any(item => item["TIPOMARCA"].ToString()
                                       .Equals(fornecedorDigitado, StringComparison.OrdinalIgnoreCase));

            if (!fornecedorExiste && !string.IsNullOrEmpty(fornecedorDigitado))
            {
                // Exibe a mensagem com o aviso
                DialogResult result = MessageBox.Show("Aviso! Tipo não registrado",
                                                      "Aviso!",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Ação para adicionar um novo fornecedor (sem adicionar o valor na ComboBox diretamente)
                    MessageBox.Show("Para criar um novo tipo deve se criar uma marca primeiro!",
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

        private void comboBoxTipo_Click(object sender, EventArgs e)
        {
            listarTipos();
        }

        private void buttonSalvarA_Click(object sender, EventArgs e)
        {
            // Criação do objeto Marca e controleMarca
            Marca mMarca = new Marca();
            controleMarca cMarca = new controleMarca();

            //Definindo os valores nos atributos
            long ID;
            if (long.TryParse(maskedTextBoxID.Text, out ID))
            {
                mMarca.setIdMarca(ID);
            }

            mMarca.setNomeMarca(textBoxNome.Text);

            mMarca.setDescMarca(richTextBoxDesc.Text);

            mMarca.setTipoMarca(comboBox1.Text);

            //Chamada ao método de cadastro no ControleMarca
            string res = cMarca.atualizaMarca(mMarca);

            //Mostra o resultado
            MessageBox.Show(res);
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in dataGridViewPesquisar.Rows)
            {
                // Verifica se a linha contém pelo menos 6 células e se a célula "Selecionar" (índice 5) está marcada
                if (row.Cells.Count > 4 && Convert.ToBoolean(row.Cells[4].Value) == true)
                {
                    DialogResult res = MessageBox.Show("Deseja atualizar este registro?", "Atualização de registro",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                    if (res == DialogResult.OK)
                    {
                        maskedTextBoxID.Text = row.Cells[0].Value.ToString();
                        textBoxNome.Text = row.Cells[1].Value.ToString();
                        richTextBoxDesc.Text = row.Cells[2].Value.ToString();
                        comboBox1.Text = row.Cells[3].Value.ToString();

                        tabControl1.SelectedTab = tabPage2;
                    }
                }
            }


        }

        private void Deletar_Click(object sender, EventArgs e)
        {
            // Lista para armazenar os IDs dos pedidos a serem deletados
            List<long> marcasParaDeletar = new List<long>();

            // Percorrer todas as linhas do DataGridView
            foreach (DataGridViewRow row in dataGridViewPesquisar.Rows)
            {
                // Verifica se a checkbox está marcada na linha
                bool isSelected = Convert.ToBoolean(row.Cells["Selecionar"].Value);

                if (isSelected)
                {
                    // Recupera o ID do pedido da linha
                    long idMarca = Convert.ToInt64(row.Cells["Id Marca"].Value);
                    marcasParaDeletar.Add(idMarca);
                }
            }

            if (marcasParaDeletar.Count > 0)
            {
                // Inicializa o controlePedido para acessar o método de deletação
                controleMarca cMarca = new controleMarca();

                // Deletar cada pedido selecionado
                foreach (long idMarca in marcasParaDeletar)
                {
                    Marca mMarca = new Marca();
                    mMarca.setIdMarca(idMarca);

                    // Chama o método para deletar o pedido
                    string resultMessage = cMarca.deletarMarca(mMarca);

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
            listarTipos();
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            listarTipos();
        }
    }
}
