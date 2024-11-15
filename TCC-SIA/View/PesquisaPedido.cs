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
    public partial class PesquisaPedido : Form
    {
        public PesquisaPedido()
        {
            InitializeComponent();
            listarCliente();
            listarVeiculo();

            #region Carrega os dados de pesquisa de pedidos
            // Criação do objeto NpgsqlDataReader pedido e controlePedido
            controlePedido cPedido = new controlePedido();
            NpgsqlDataReader pedido = cPedido.listarPedido();

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
            dataGridViewPesquisar.ColumnCount = 7;

            // Definindo as colunas na DataGridView para exibir as descrições
            dataGridViewPesquisar.Columns[0].Name = "Id Pedido";
            dataGridViewPesquisar.Columns[0].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisar.Columns[1].Name = "Veículo";
            dataGridViewPesquisar.Columns[1].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisar.Columns[2].Name = "Cliente";
            dataGridViewPesquisar.Columns[2].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisar.Columns[3].Name = "Valor Total";
            dataGridViewPesquisar.Columns[3].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisar.Columns[4].Name = "Observação";
            dataGridViewPesquisar.Columns[4].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisar.Columns[5].Name = "Data de início";
            dataGridViewPesquisar.Columns[5].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisar.Columns[6].Name = "Data de termíno";
            dataGridViewPesquisar.Columns[6].ReadOnly = true; // Definindo como somente leitura

            // Criando a coluna de botão de peças
            DataGridViewButtonColumn buttonColumnPeça = new DataGridViewButtonColumn();
            buttonColumnPeça.Name = "Peças";
            buttonColumnPeça.ReadOnly = true; // Deixando a checkbox editável
            dataGridViewPesquisar.Columns.Add(buttonColumnPeça);

            // Criando a coluna de botão de serviços
            DataGridViewButtonColumn buttonColumnServiços = new DataGridViewButtonColumn();
            buttonColumnServiços.Name = "Serviços";
            buttonColumnServiços.ReadOnly = true; // Deixando a checkbox editável
            dataGridViewPesquisar.Columns.Add(buttonColumnServiços);

            // Criando a coluna de checkbox para marcação (editável)
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.Name = "Selecionar";
            checkBoxColumn.ReadOnly = false; // Deixando a checkbox editável
            dataGridViewPesquisar.Columns.Add(checkBoxColumn);

            // Adicionando as descrições dos serviços
            while (pedido.Read())
            {
                string idPedido = pedido["IDPEDIDO"].ToString();
                string idVeiculo = pedido["IDVEICULO"].ToString();
                string idCliente = pedido["IDCLIENTE"].ToString();
                string valorTotal = pedido["VALORTOTALPEDIDO"].ToString();
                string obs = pedido["OBSERVACAO"].ToString();
                string dataInicio = pedido["DATAINICIO"].ToString();
                string dataFim = pedido["DATAFIM"].ToString();

                //Consulta o nome da marca pelo id
                string NomeVeiculo = cPedido.pesquisarVeiculoPorId(idVeiculo);
                string NomeCliente = cPedido.pesquisarClientePorId(idCliente);

                // Verifique se a linha já existe
                bool exists = false;
                foreach (DataGridViewRow existingRow in dataGridViewPesquisar.Rows)
                {
                    if (!existingRow.IsNewRow &&
                        existingRow.Cells["Id Pedido"].Value.ToString() == idPedido &&
                        existingRow.Cells["Cliente"].Value.ToString() == idCliente)
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
                    row.Cells[0].Value = idPedido;
                    row.Cells[1].Value = NomeVeiculo;
                    row.Cells[2].Value = NomeCliente;
                    row.Cells[3].Value = valorTotal;
                    row.Cells[4].Value = obs;
                    row.Cells[5].Value = dataInicio;
                    row.Cells[6].Value = dataFim;
                    row.Cells[7].Value = "Abrir Lista";
                    row.Cells[8].Value = "Abrir Lista";
                    row.Cells[9].Value = false; // Valor padrão para "Selecionar" (desmarcado)

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
            comboBoxClienteP.DataSource = dtCliente;

            //Define qual coluna do DataTable que será exibida (nome da coluna)
            comboBoxCliente.DisplayMember = "NOMECLIENTE";
            comboBoxClienteP.DisplayMember = "NOMECLIENTE";

            //Define qual o valor da linha será utilizado ao selecionar um valor
            comboBoxCliente.ValueMember = "IDCLIENTE";
            comboBoxClienteP.ValueMember = "IDCLIENTE";

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
            comboBoxVeiculoP.DataSource = dtVeiculo;

            //Define qual coluna do DataTable que será exibida (nome da coluna)
            comboBoxVeiculo.DisplayMember = "NOMEVEICULO";
            comboBoxVeiculoP.DisplayMember = "NOMEVEICULO";

            //Define qual o valor da linha será utilizado ao selecionar um valor
            comboBoxVeiculo.ValueMember = "IDVEICULO";
            comboBoxVeiculoP.ValueMember = "IDVEICULO";
        }
        #endregion

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            #region Carrega os dados de pesquisa de pedidos
            // Criação do objeto NpgsqlDataReader pedido e controlePedido
            controlePedido cPedido = new controlePedido();
            NpgsqlDataReader pedido = cPedido.pesquisaPedido(Convert.ToInt32(comboBoxCliente.SelectedValue), Convert.ToInt32(comboBoxVeiculo.SelectedValue));

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
            dataGridViewPesquisar.ColumnCount = 7;

            // Definindo as colunas na DataGridView para exibir as descrições
            dataGridViewPesquisar.Columns[0].Name = "Id Pedido";
            dataGridViewPesquisar.Columns[0].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisar.Columns[1].Name = "Veículo";
            dataGridViewPesquisar.Columns[1].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisar.Columns[2].Name = "Cliente";
            dataGridViewPesquisar.Columns[2].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisar.Columns[3].Name = "Valor Total";
            dataGridViewPesquisar.Columns[3].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisar.Columns[4].Name = "Observação";
            dataGridViewPesquisar.Columns[4].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisar.Columns[5].Name = "Data de início";
            dataGridViewPesquisar.Columns[5].ReadOnly = true; // Definindo como somente leitura

            dataGridViewPesquisar.Columns[6].Name = "Data de termíno";
            dataGridViewPesquisar.Columns[6].ReadOnly = true; // Definindo como somente leitura

            // Criando a coluna de botão de peças
            DataGridViewButtonColumn buttonColumnPeça = new DataGridViewButtonColumn();
            buttonColumnPeça.Name = "Peças";
            buttonColumnPeça.ReadOnly = true; // Deixando a checkbox editável
            dataGridViewPesquisar.Columns.Add(buttonColumnPeça);

            // Criando a coluna de botão de serviços
            DataGridViewButtonColumn buttonColumnServiços = new DataGridViewButtonColumn();
            buttonColumnServiços.Name = "Serviços";
            buttonColumnServiços.ReadOnly = true; // Deixando a checkbox editável
            dataGridViewPesquisar.Columns.Add(buttonColumnServiços);

            // Criando a coluna de checkbox para marcação (editável)
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.Name = "Selecionar";
            checkBoxColumn.ReadOnly = false; // Deixando a checkbox editável
            dataGridViewPesquisar.Columns.Add(checkBoxColumn);

            // Adicionando as descrições dos serviços
            while (pedido.Read())
            {
                string idPedido = pedido["IDPEDIDO"].ToString();
                string idVeiculo = pedido["IDVEICULO"].ToString();
                string idCliente = pedido["IDCLIENTE"].ToString();
                string valorTotal = pedido["VALORTOTALPEDIDO"].ToString();
                string obs = pedido["OBSERVACAO"].ToString();
                string dataInicio = pedido["DATAINICIO"].ToString();
                string dataFim = pedido["DATAFIM"].ToString();

                //Consulta o nome da marca pelo id
                string NomeVeiculo = cPedido.pesquisarVeiculoPorId(idVeiculo);
                string NomeCliente = cPedido.pesquisarClientePorId(idCliente);

                // Verifique se a linha já existe
                bool exists = false;
                foreach (DataGridViewRow existingRow in dataGridViewPesquisar.Rows)
                {
                    if (!existingRow.IsNewRow &&
                        existingRow.Cells["Id Pedido"].Value.ToString() == idPedido &&
                        existingRow.Cells["Cliente"].Value.ToString() == idCliente)
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
                    row.Cells[0].Value = idPedido;
                    row.Cells[1].Value = NomeVeiculo;
                    row.Cells[2].Value = NomeCliente;
                    row.Cells[3].Value = valorTotal;
                    row.Cells[4].Value = obs;
                    row.Cells[5].Value = dataInicio;
                    row.Cells[6].Value = dataFim;
                    row.Cells[7].Value = "Abrir Lista";
                    row.Cells[8].Value = "Abrir Lista";
                    row.Cells[9].Value = false; // Valor padrão para "Selecionar" (desmarcado)

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

        private void comboBoxVeiculo_DropDown(object sender, EventArgs e)
        {
            listarVeiculo();
        }

        private void dataGridViewPesquisar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica se o índice da linha é válido
            if (e.RowIndex < 0) return;

            // Verifica se a coluna clicada é a coluna "Peças"
            if (dataGridViewPesquisar.Columns[e.ColumnIndex].Name == "Peças")
            {
                Pedido MPedido = new Pedido();

                // Obtém o ID do pedido da linha selecionada
                long idPedido = Convert.ToInt64(dataGridViewPesquisar.Rows[e.RowIndex].Cells["Id Pedido"].Value);

                // Chama o método para abrir o formulário com a lista de peças
                AbrirFormularioPecas(idPedido);
            }
            // Verifica se a coluna clicada é a coluna "Serviços"
            else if (dataGridViewPesquisar.Columns[e.ColumnIndex].Name == "Serviços")
            {
                // Obtém o ID do pedido da linha selecionada
                long idPedido = Convert.ToInt64(dataGridViewPesquisar.Rows[e.RowIndex].Cells["Id Pedido"].Value);

                // Chama o método para abrir o formulário com a lista de serviços
                AbrirFormularioServicos(idPedido);
            }
        }

        private void AbrirFormularioPecas(long idPedido)
        {
            // Cria uma nova instância do formulário de peças
            ListaPecas formPecas = new ListaPecas();

            // Carrega os dados de peças para o pedido específico
            formPecas.CarregarDadosPecas(idPedido); // CarregarDadosPecas é um método que você deve implementar no formulário

            // Exibe o formulário
            formPecas.ShowDialog();
        }

        private void AbrirFormularioServicos(long idPedido)
        {
            // Cria uma nova instância do formulário de serviços
            ListaServicos formServicos = new ListaServicos();

            // Carrega os dados de serviços para o pedido específico
            formServicos.CarregarDadosServicos(idPedido); // CarregarDadosServicos é um método que você deve implementar no formulário

            // Exibe o formulário
            formServicos.ShowDialog();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {


            DialogResult res = MessageBox.Show("Deseja atualizar este registro?", "Atualização de registro",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (res == DialogResult.OK)
            {
                maskedTextBoxID.Text = dataGridViewPesquisar.CurrentRow.Cells[0].Value.ToString();

                comboBoxVeiculoP.Text = dataGridViewPesquisar.CurrentRow.Cells[1].Value.ToString();

                comboBoxClienteP.Text = dataGridViewPesquisar.CurrentRow.Cells[2].Value.ToString();

                maskedTextBoxValorTotal.Text = dataGridViewPesquisar.CurrentRow.Cells[3].Value.ToString();

                richTextBoxObs.Text = dataGridViewPesquisar.CurrentRow.Cells[4].Value.ToString();

                dateTimePickerDataInicio.Text = dataGridViewPesquisar.CurrentRow.Cells[5].Value.ToString();

                dateTimePickerDataFim.Text = dataGridViewPesquisar.CurrentRow.Cells[6].Value.ToString();

                tabControl1.SelectedTab = tabPage2;
            }



        }

        private void btnSalvarA_Click(object sender, EventArgs e)
        {
            controlePedido cPedido = new controlePedido();

            Pedido mPedido = new Pedido();

            //Definindo os valores nos atributos

            //Faz uma verificação para tentar enviar o valor para o atributo, se existiver vazia ele envia vazia sem dar erro

            long IDC;
            if (long.TryParse(comboBoxClienteP.SelectedValue?.ToString(), out IDC))
            {
                mPedido.setIdCliente(IDC);
            }
            long IDV;
            if (long.TryParse(comboBoxVeiculoP.SelectedValue?.ToString(), out IDV))
            {
                mPedido.setIdVeiculo(IDV);
            }

            mPedido.setIdPedido(Convert.ToInt32(maskedTextBoxID.Text));
            mPedido.setValorTotalPedido(Convert.ToDecimal(maskedTextBoxValorTotal.Text));
            mPedido.setObservacao(richTextBoxObs.Text);
            mPedido.setDataInicio(Convert.ToDateTime(dateTimePickerDataInicio.Text));
            mPedido.setDataFim(Convert.ToDateTime(dateTimePickerDataFim.Text));



            //Chamada ao método de cadastro no ControleCliente
            string res = cPedido.atualizarPedido(mPedido);

            //Mostra o resultado
            MessageBox.Show(res);
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            // Lista para armazenar os IDs dos pedidos a serem deletados
            List<long> pedidosParaDeletar = new List<long>();

            // Percorrer todas as linhas do DataGridView
            foreach (DataGridViewRow row in dataGridViewPesquisar.Rows)
            {
                // Verifica se a checkbox está marcada na linha
                bool isSelected = Convert.ToBoolean(row.Cells["Selecionar"].Value);

                if (isSelected)
                {
                    // Recupera o ID do pedido da linha
                    long idPedido = Convert.ToInt64(row.Cells["Id Pedido"].Value);
                    pedidosParaDeletar.Add(idPedido);
                }
            }

            if (pedidosParaDeletar.Count > 0)
            {
                // Inicializa o controlePedido para acessar o método de deletação
                controlePedido cPedido = new controlePedido();

                // Deletar cada pedido selecionado
                foreach (long idPedido in pedidosParaDeletar)
                {
                    Pedido mPedido = new Pedido();
                    mPedido.setIdPedido(idPedido);

                    // Chama o método para deletar o pedido
                    string resultMessage = cPedido.deletarPedido(mPedido);

                    // Exibe o resultado da exclusão
                    MessageBox.Show(resultMessage);
                }
            }
            else
            {
                MessageBox.Show("Please select at least one order to delete.");
            }

        }
    }
    
}

