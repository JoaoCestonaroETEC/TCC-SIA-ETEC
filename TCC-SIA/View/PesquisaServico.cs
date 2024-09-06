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
    public partial class PesquisaServico : Form
    {
        #region Inicializa o formulário
        public PesquisaServico()
        {
            InitializeComponent();

            #region Carrega as informações gerais dos serviços
            //Criação do objeto NpgsqlDataReader servico e controleServico
            controleServico cServico = new controleServico();
            NpgsqlDataReader servico = cServico.listaServico();

            //Apaga as colunas da datagridview
            dataGridViewPesquisar.Columns.Clear();

            //Definindo a quant. de colunas que a grid terá
            dataGridViewPesquisar.ColumnCount = servico.FieldCount;

            //Definindo três colunas na DataGridView para exibir as descrições
            dataGridViewPesquisar.ColumnCount = 5;
            dataGridViewPesquisar.Columns[0].Name = "Id";
            dataGridViewPesquisar.Columns[1].Name = "Nome";
            dataGridViewPesquisar.Columns[2].Name = "Descricao";
            dataGridViewPesquisar.Columns[3].Name = "Valor";
            dataGridViewPesquisar.Columns[4].Name = "Garantia";


            //Adicionando as descrições dos serviços
            while (servico.Read())
            {
                string idServico = servico["IDSERVICO"].ToString();
                string nomeServico = servico["NOMESERVICO"].ToString();
                string descServico = servico["DESCSERVICO"].ToString();
                string valorServico = servico["VALORSERVICO"].ToString();
                string garantiaServico = servico["GARANTIASERVICO"].ToString();

                dataGridViewPesquisar.Rows.Add(idServico, nomeServico, descServico, valorServico, garantiaServico);
            }
            #endregion
        }
        #endregion

        #region Pesquisar serviço
        //Evento de pesquisar serviço
        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            //Criação do objeto NpgsqlDataReader servico e controleServico
            controleServico cServico = new controleServico();
            NpgsqlDataReader servico = cServico.pesquisaServico(textBoxPesquisar.Text);

            //Apaga as colunas da datagridview
            dataGridViewPesquisar.Columns.Clear();

            //Definindo a quant. de colunas que a grid terá
            dataGridViewPesquisar.ColumnCount = servico.FieldCount;

            //Definindo três colunas na DataGridView para exibir as descrições
            dataGridViewPesquisar.ColumnCount = 5;
            dataGridViewPesquisar.Columns[0].Name = "Id";
            dataGridViewPesquisar.Columns[1].Name = "Nome";
            dataGridViewPesquisar.Columns[2].Name = "Descricao";
            dataGridViewPesquisar.Columns[3].Name = "Valor";
            dataGridViewPesquisar.Columns[4].Name = "Garantia";

            //Adicionando as descrições dos serviços
            while (servico.Read())
            {
                string idServico = servico["IDSERVICO"].ToString();
                string nomeServico = servico["NOMESERVICO"].ToString();
                string descServico = servico["DESCSERVICO"].ToString();
                string valorServico = servico["VALORSERVICO"].ToString();
                string garantiaServico = servico["GARANTIASERVICO"].ToString();
                dataGridViewPesquisar.Rows.Add(idServico, nomeServico, descServico, valorServico, garantiaServico);
            }
        }
        #endregion

        private void btnSalvarAtulizar_Click(object sender, EventArgs e)
        {
            if (dataGridViewPesquisar.SelectedRows.Count > 0)
            {
                DialogResult res = MessageBox.Show("Deseja atualizar este registro?", "Atualização de registro",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (res == DialogResult.OK)
                {
                    maskedTextBoxID.Text = dataGridViewPesquisar.CurrentRow.Cells[0].Value.ToString();
                    textBoxNome.Text = dataGridViewPesquisar.CurrentRow.Cells[1].Value.ToString();
                    richTextBoxDesc.Text = dataGridViewPesquisar.CurrentRow.Cells[2].Value.ToString();
                    maskedTextBoxValor.Text = dataGridViewPesquisar.CurrentRow.Cells[3].Value.ToString();
                    dateTimePickerGarantia.Value = Convert.ToDateTime(dataGridViewPesquisar.CurrentRow.Cells[4].Value.ToString());
                    tabControl1.SelectedTab = tabPage2;
                }
            }
        }

        private void buttonSalvarA_Click(object sender, EventArgs e)
        {
            controleServico cServico = new controleServico();

            Servico mServico = new Servico();

            //Definindo os valores nos atributos

            //Faz uma verificação para tentar enviar o valor para o atributo, se existiver vazia ele envia vazia sem dar erro

            mServico.setIDServico(Convert.ToInt32(maskedTextBoxID.Text));
            mServico.setNomeServico(textBoxNome.Text);
            mServico.setDescServico(richTextBoxDesc.Text);
            mServico.setValorServico(Convert.ToInt32(maskedTextBoxValor.Text));
            mServico.setGarantiaServico(Convert.ToDateTime(dateTimePickerGarantia.Text));

            //Chamada ao método de cadastro no ControleServico
            string res = cServico.atualizaServico(mServico);

            //Mostra o resultado
            MessageBox.Show(res);
        }

      
    }
}
