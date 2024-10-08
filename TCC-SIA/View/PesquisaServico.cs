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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TCC_SIA.View
{
    public partial class PesquisaServico : Form
    {
        #region Inicializa o formulário
        public PesquisaServico()
        {
            InitializeComponent();


            #region Carrega os dados de pesquisa de serviços
            // Criação do objeto NpgsqlDataReader servico e controleServico
            controleServico cServico = new controleServico();
            NpgsqlDataReader servico = cServico.pesquisaServico(textBoxPesquisar.Text);

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
            dataGridViewPesquisar.ColumnCount = 6;

            // Definindo as colunas na DataGridView para exibir as descrições
            dataGridViewPesquisar.Columns[0].Name = "Id Serviço";
            dataGridViewPesquisar.Columns[0].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisar.Columns[1].Name = "Nome";
            dataGridViewPesquisar.Columns[1].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisar.Columns[2].Name = "Valor";
            dataGridViewPesquisar.Columns[2].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisar.Columns[3].Name = "Descrição";
            dataGridViewPesquisar.Columns[3].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisar.Columns[4].Name = "Garantia";
            dataGridViewPesquisar.Columns[4].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisar.Columns[5].Name = "Funcionário";
            dataGridViewPesquisar.Columns[5].ReadOnly = true; // Definindo como somente leitura

            // Criando a coluna de checkbox para marcação (editável)
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.Name = "Selecionar";
            checkBoxColumn.ReadOnly = false; // Deixando a checkbox editável
            dataGridViewPesquisar.Columns.Add(checkBoxColumn);

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
                foreach (DataGridViewRow existingRow in dataGridViewPesquisar.Rows)
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
                    row.CreateCells(dataGridViewPesquisar); // Define a grid para onde a linha vai

                    // Preenchendo a linha com os valores
                    row.Cells[0].Value = idServico;
                    row.Cells[1].Value = nomeServico;
                    row.Cells[2].Value = valorServico;
                    row.Cells[3].Value = descServico;
                    row.Cells[4].Value = garantiaServico;
                    row.Cells[5].Value = funcionarioServico;
                    row.Cells[6].Value = false; // Valor padrão para "Selecionar" (desmarcado)

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

        #region Pesquisar serviço
        //Evento de pesquisar serviço
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
            controleServico cServico = new controleServico();
            NpgsqlDataReader servico = cServico.pesquisaServico(textBoxPesquisar.Text);

            // Definindo a quantidade de colunas que a grid terá
            dataGridViewPesquisar.ColumnCount = 6;

            // Definindo as colunas na DataGridView para exibir as descrições
            dataGridViewPesquisar.Columns[0].Name = "Id Serviço";
            dataGridViewPesquisar.Columns[0].ReadOnly = true;

            dataGridViewPesquisar.Columns[1].Name = "Nome";
            dataGridViewPesquisar.Columns[1].ReadOnly = true;

            dataGridViewPesquisar.Columns[2].Name = "Valor";
            dataGridViewPesquisar.Columns[2].ReadOnly = true;

            dataGridViewPesquisar.Columns[3].Name = "Descrição";
            dataGridViewPesquisar.Columns[3].ReadOnly = true;

            dataGridViewPesquisar.Columns[4].Name = "Garantia";
            dataGridViewPesquisar.Columns[4].ReadOnly = true;

            dataGridViewPesquisar.Columns[5].Name = "Funcionário";
            dataGridViewPesquisar.Columns[5].ReadOnly = true;

            // Criando a coluna de checkbox para marcação (editável)
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.Name = "Selecionar";
            checkBoxColumn.ReadOnly = false; // Deixando a checkbox editável
            dataGridViewPesquisar.Columns.Add(checkBoxColumn);

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
                foreach (DataGridViewRow existingRow in dataGridViewPesquisar.Rows)
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
                    row.CreateCells(dataGridViewPesquisar); // Define a grid para onde a linha vai

                    // Preenchendo a linha com os valores
                    row.Cells[0].Value = idServico;
                    row.Cells[1].Value = nomeServico;
                    row.Cells[2].Value = valorServico;
                    row.Cells[3].Value = descServico;
                    row.Cells[4].Value = garantiaServico;
                    row.Cells[5].Value = funcionarioServico;
                    row.Cells[6].Value = false; // Valor padrão para "Selecionar" (desmarcado)

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
        }
        #endregion

        private void btnSalvarAtulizar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewPesquisar.Rows)
            {
                // Verifica se a linha contém pelo menos 7 células e se a célula "Selecionar" (índice 6) está marcada
                if (row.Cells.Count > 6 && Convert.ToBoolean(row.Cells[6].Value) == true)
                {
                    DialogResult res = MessageBox.Show("Deseja atualizar este registro?", "Atualização de registro",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                    if (res == DialogResult.OK)
                    {
                        maskedTextBoxID.Text = row.Cells[0].Value.ToString();
                        textBoxNome.Text = row.Cells[1].Value.ToString();
                        maskedTextBoxValor.Text = row.Cells[2].Value.ToString();
                        richTextBoxDesc.Text = row.Cells[3].Value.ToString();
                        dateTimePickerGarantia.Value = Convert.ToDateTime(row.Cells[4].Value.ToString());
                        comboBoxFunc.Text = row.Cells[5].Value.ToString();

                        tabControl1.SelectedTab = tabPage2;
                    }
                }
            }


        }

        private void buttonSalvarA_Click(object sender, EventArgs e)
        {
            // Criação do objeto Servico e controleServico
            Servico mServico = new Servico();
            controleServico cServico = new controleServico();

            //Definindo os valores nos atributos
            long ID;
            if (long.TryParse(maskedTextBoxID.Text, out ID))
            {
                mServico.setIDServico(ID);
            }
            mServico.setNomeServico(textBoxNome.Text);
            mServico.setGarantiaServico(Convert.ToDateTime(dateTimePickerGarantia.Text)); ;


            //Faz uma verificação para tentar enviar o valor para o atributo, se existiver vazia ele envia vazia sem dar erro
            decimal valor;
            if (decimal.TryParse(maskedTextBoxValor.Text, out valor))
            {
                mServico.setValorServico(valor);
            }

            mServico.setDescServico(richTextBoxDesc.Text);

            mServico.setFuncionario(comboBoxFunc.Text);

            //Chamada ao método de cadastro no ControleServico
            string res = cServico.atualizaServico(mServico);

            //Mostra o resultado
            MessageBox.Show(res);
        }

      
    }
}
