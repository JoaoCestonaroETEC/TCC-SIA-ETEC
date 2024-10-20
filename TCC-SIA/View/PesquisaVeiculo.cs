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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TCC_SIA.View
{
    public partial class PesquisaVeiculo : Form
    {
        #region Inicializa o formulário
        public PesquisaVeiculo()
        {
            InitializeComponent();

            #region Carrega os dados de pesquisa de serviços
            // Criação do objeto NpgsqlDataReader servico e controleServico
            controleVeiculo cVeiculo = new controleVeiculo();
            NpgsqlDataReader veiculo = cVeiculo.pesquisaVeiculo(textBoxPesquisar.Text);

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
            dataGridViewPesquisar.ColumnCount = 15;

            // Definindo as colunas na DataGridView para exibir as descrições
            dataGridViewPesquisar.Columns[0].Name = "Id Veiculo";
            dataGridViewPesquisar.Columns[0].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisar.Columns[1].Name = "Cliente";
            dataGridViewPesquisar.Columns[1].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisar.Columns[2].Name = "Marca";
            dataGridViewPesquisar.Columns[2].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisar.Columns[3].Name = "Nome";
            dataGridViewPesquisar.Columns[3].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisar.Columns[4].Name = "Tipo";
            dataGridViewPesquisar.Columns[4].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisar.Columns[5].Name = "Cor";
            dataGridViewPesquisar.Columns[5].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisar.Columns[6].Name = "Placa";
            dataGridViewPesquisar.Columns[6].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisar.Columns[7].Name = "Modelo";
            dataGridViewPesquisar.Columns[7].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisar.Columns[8].Name = "Chassi";
            dataGridViewPesquisar.Columns[8].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisar.Columns[9].Name = "Ano de Fabricação";
            dataGridViewPesquisar.Columns[9].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisar.Columns[10].Name = "Quilometragem";
            dataGridViewPesquisar.Columns[10].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisar.Columns[11].Name = "Motor";
            dataGridViewPesquisar.Columns[11].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisar.Columns[12].Name = "Combustivel";
            dataGridViewPesquisar.Columns[12].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisar.Columns[13].Name = "Data";
            dataGridViewPesquisar.Columns[13].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisar.Columns[14].Name = "Seguro";
            dataGridViewPesquisar.Columns[14].ReadOnly = true; // Definindo como somente leitura

            // Criando a coluna de checkbox para marcação (editável)
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.Name = "Selecionar";
            checkBoxColumn.ReadOnly = false; // Deixando a checkbox editável
            dataGridViewPesquisar.Columns.Add(checkBoxColumn);

            // Adicionando as descrições dos serviços
            while (veiculo.Read())
            {
                string idVeiculo = veiculo["IDVEICULO"].ToString();
                string idcliente = veiculo["IDCLIENTE"].ToString();
                string idmarca = veiculo["IDMARCA"].ToString();
                string nomeVeiculo = veiculo["NOMEVEICULO"].ToString();
                string tipoVeiculo = veiculo["TIPOVEICULO"].ToString();
                string corVeiculo = veiculo["CORVEICULO"].ToString();
                string placaVeiculo = veiculo["PLACAVEICULO"].ToString();
                string modeloVeiculo = veiculo["MODELOVEICULO"].ToString();
                string chassi = veiculo["CHASSI"].ToString();
                string anofab = veiculo["ANOFAB"].ToString();
                string quilometragem = veiculo["QUILOMETRAGEM"].ToString();
                string motor = veiculo["MOTOR"].ToString();
                string combustivel = veiculo["COMBUSTIVEL"].ToString();
                string data = veiculo["DATA"].ToString();
                string seguro = veiculo["SEGURO"].ToString();

                // Consulta o nome da marca pelo id
                string marca = cVeiculo.pesquisaMarcaVeiculoPorId(idmarca);
                string cliente = cVeiculo.pesquisaClienteVeiculoPorId(idcliente);

                // Verifique se a linha já existe
                bool exists = false;
                foreach (DataGridViewRow existingRow in dataGridViewPesquisar.Rows)
                {
                    if (!existingRow.IsNewRow &&
                        existingRow.Cells["Id Veiculo"].Value.ToString() == idVeiculo &&
                        existingRow.Cells["Nome"].Value.ToString() == nomeVeiculo)
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
                    row.Cells[0].Value = idVeiculo;
                    row.Cells[1].Value = cliente;
                    row.Cells[2].Value = marca;
                    row.Cells[3].Value = nomeVeiculo;
                    row.Cells[4].Value = tipoVeiculo;
                    row.Cells[5].Value = corVeiculo;
                    row.Cells[6].Value = placaVeiculo;
                    row.Cells[7].Value = modeloVeiculo;
                    row.Cells[8].Value = chassi;
                    row.Cells[9].Value = anofab;
                    row.Cells[10].Value = quilometragem;
                    row.Cells[11].Value = motor;
                    row.Cells[12].Value = combustivel;
                    row.Cells[13].Value = data;
                    row.Cells[14].Value = seguro;
                    row.Cells[15].Value = false; // Valor padrão para "Selecionar" (desmarcado)

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
            comboBoxIdCliente.DataSource = dtCliente;

            //Define qual coluna do DataTable que será exibida (nome da coluna)
            comboBoxIdCliente.DisplayMember = "NOMECLIENTE";

            //Define qual o valor da linha será utilizado ao selecionar um valor
            comboBoxIdCliente.ValueMember = "IDCLIENTE";
        }
        #endregion

        #region Listar marca
        public void listarMarca()
        {
            controleMarca cMarca = new controleMarca();
            //Recebe os dados da consulta e salva no dataReader (Tipo)
            NpgsqlDataReader marca = cMarca.listarMarcaVeiculos();

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

        #region Pesquisar veículo
        //Evento de pesquisar veículo
        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            // Criação do objeto NpgsqlDataReader servico e controleServico
            controleVeiculo cVeiculo = new controleVeiculo();
            NpgsqlDataReader veiculo = cVeiculo.pesquisaVeiculo(textBoxPesquisar.Text);

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
            dataGridViewPesquisar.ColumnCount = 15;

            // Definindo as colunas na DataGridView para exibir as descrições
            dataGridViewPesquisar.Columns[0].Name = "Id Veiculo";
            dataGridViewPesquisar.Columns[0].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisar.Columns[1].Name = "Cliente";
            dataGridViewPesquisar.Columns[1].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisar.Columns[2].Name = "Marca";
            dataGridViewPesquisar.Columns[2].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisar.Columns[3].Name = "Nome";
            dataGridViewPesquisar.Columns[3].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisar.Columns[4].Name = "Tipo";
            dataGridViewPesquisar.Columns[4].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisar.Columns[5].Name = "Cor";
            dataGridViewPesquisar.Columns[5].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisar.Columns[6].Name = "Placa";
            dataGridViewPesquisar.Columns[6].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisar.Columns[7].Name = "Modelo";
            dataGridViewPesquisar.Columns[7].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisar.Columns[8].Name = "Chassi";
            dataGridViewPesquisar.Columns[8].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisar.Columns[9].Name = "Ano de Fabricação";
            dataGridViewPesquisar.Columns[9].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisar.Columns[10].Name = "Quilometragem";
            dataGridViewPesquisar.Columns[10].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisar.Columns[11].Name = "Motor";
            dataGridViewPesquisar.Columns[11].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisar.Columns[12].Name = "Combustivel";
            dataGridViewPesquisar.Columns[12].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisar.Columns[13].Name = "Data";
            dataGridViewPesquisar.Columns[13].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisar.Columns[14].Name = "Seguro";
            dataGridViewPesquisar.Columns[14].ReadOnly = true; // Definindo como somente leitura

            // Criando a coluna de checkbox para marcação (editável)
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.Name = "Selecionar";
            checkBoxColumn.ReadOnly = false; // Deixando a checkbox editável
            dataGridViewPesquisar.Columns.Add(checkBoxColumn);

            // Adicionando as descrições dos serviços
            while (veiculo.Read())
            {
                string idVeiculo = veiculo["IDVEICULO"].ToString();
                string idcliente = veiculo["IDCLIENTE"].ToString();
                string idmarca = veiculo["IDMARCA"].ToString();
                string nomeVeiculo = veiculo["NOMEVEICULO"].ToString();
                string tipoVeiculo = veiculo["TIPOVEICULO"].ToString();
                string corVeiculo = veiculo["CORVEICULO"].ToString();
                string placaVeiculo = veiculo["PLACAVEICULO"].ToString();
                string modeloVeiculo = veiculo["MODELOVEICULO"].ToString();
                string chassi = veiculo["CHASSI"].ToString();
                string anofab = veiculo["ANOFAB"].ToString();
                string quilometragem = veiculo["QUILOMETRAGEM"].ToString();
                string motor = veiculo["MOTOR"].ToString();
                string combustivel = veiculo["COMBUSTIVEL"].ToString();
                string data = veiculo["DATA"].ToString();
                string seguro = veiculo["SEGURO"].ToString();

                // Consulta o nome da marca pelo id
                string marca = cVeiculo.pesquisaMarcaVeiculoPorId(idmarca);
                string cliente = cVeiculo.pesquisaClienteVeiculoPorId(idcliente);

                // Verifique se a linha já existe
                bool exists = false;
                foreach (DataGridViewRow existingRow in dataGridViewPesquisar.Rows)
                {
                    if (!existingRow.IsNewRow &&
                        existingRow.Cells["Id Veiculo"].Value.ToString() == idVeiculo &&
                        existingRow.Cells["Nome"].Value.ToString() == nomeVeiculo)
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
                    row.Cells[0].Value = idVeiculo;
                    row.Cells[1].Value = cliente;
                    row.Cells[2].Value = marca;
                    row.Cells[3].Value = nomeVeiculo;
                    row.Cells[4].Value = tipoVeiculo;
                    row.Cells[5].Value = corVeiculo;
                    row.Cells[6].Value = placaVeiculo;
                    row.Cells[7].Value = modeloVeiculo;
                    row.Cells[8].Value = chassi;
                    row.Cells[9].Value = anofab;
                    row.Cells[10].Value = quilometragem;
                    row.Cells[11].Value = motor;
                    row.Cells[12].Value = combustivel;
                    row.Cells[13].Value = data;
                    row.Cells[14].Value = seguro;
                    row.Cells[15].Value = false; // Valor padrão para "Selecionar" (desmarcado)

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

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewPesquisar.Rows)
            {
                // Verifica se a linha contém pelo menos 7 células e se a célula "Selecionar" (índice 6) está marcada
                if (row.Cells.Count > 15 && Convert.ToBoolean(row.Cells[15].Value) == true)
                {
                    DialogResult res = MessageBox.Show("Deseja atualizar este registro?", "Atualização de registro",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                    if (res == DialogResult.OK)
                    {
                        maskedTextBoxID.Text = row.Cells[0].Value.ToString();
                        comboBoxIdCliente.Text = row.Cells[1].Value.ToString();
                        comboBoxMarca.Text = row.Cells[2].Value.ToString();
                        textBoxNome.Text = row.Cells[3].Value.ToString();
                        comboBoxTipo.Text = row.Cells[4].Value.ToString();
                        comboBoxCor.Text = row.Cells[5].Value.ToString();
                        maskedTextBoxPlaca.Text = row.Cells[6].Value.ToString();
                        textBoxModelo.Text = row.Cells[7].Value.ToString();
                        maskedTextBoxChassi.Text = row.Cells[8].Value.ToString();
                        dateTimePickerFab.Text = row.Cells[9].Value.ToString();
                        maskedTextBoxQuilo.Text = row.Cells[10].Value.ToString();
                        maskedTextBoxMotor.Text = row.Cells[11].Value.ToString();
                        comboBoxCombustivel.Text = row.Cells[12].Value.ToString();
                        dateTimePickerData.Text = row.Cells[13].Value.ToString();
                        comboBoxSeguro.Text = row.Cells[14].Value.ToString();

                        tabControl1.SelectedTab = tabPage2;
                    }
                }
            }
        }

        private void buttonSalvarA_Click(object sender, EventArgs e)
        {
            // Criação do objeto Servico e controleServico
            Veiculo mVeiculo = new Veiculo();
            controleVeiculo cVeiculo = new controleVeiculo();

            //Definindo os valores nos atributos
            long ID;
            if (long.TryParse(maskedTextBoxID.Text, out ID))
            {
                mVeiculo.setIdVeiculo(ID);
            }

            long IDC;
            if (long.TryParse(comboBoxIdCliente.SelectedValue?.ToString(), out IDC))
            {
                mVeiculo.setIdCliente(IDC);
            }

            long IDM;
            if (long.TryParse(comboBoxMarca.SelectedValue?.ToString(), out IDM))
            {
                mVeiculo.setIdMarca(IDM);
            }

            mVeiculo.setNomeVeiculo(textBoxNome.Text);
            mVeiculo.setTipoVeiculo(comboBoxTipo.Text);
            mVeiculo.setCorVeiculo(comboBoxCor.Text);
            mVeiculo.setPlacaVeiculo(maskedTextBoxPlaca.Text);
            mVeiculo.setModeloVeiculo(textBoxModelo.Text);
            mVeiculo.setChassi(maskedTextBoxChassi.Text);
            mVeiculo.setAnoFabricacao(Convert.ToDateTime(dateTimePickerFab.Text));
            mVeiculo.setQuilometragem(Convert.ToInt32(maskedTextBoxQuilo.Text));
            mVeiculo.setMotor(maskedTextBoxMotor.Text);
            mVeiculo.setCombustivel(maskedTextBoxMotor.Text);
            mVeiculo.setData(Convert.ToDateTime(dateTimePickerData.Text));
            mVeiculo.setSeguro(comboBoxSeguro.Text);

            //Chamada ao método de cadastro no ControleServico
            string res = cVeiculo.atualizarVeiculo(mVeiculo);

            //Mostra o resultado
            MessageBox.Show(res);
        }
    }
}
