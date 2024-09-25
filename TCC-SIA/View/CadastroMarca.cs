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
    public partial class CadastroMarca : Form
    {
        #region Inicializa o formulário
        public CadastroMarca()
        {
            InitializeComponent();
            listarTipos();
        }
        #endregion

        #region Cadastrar marca
        //Evento de cadastrar marca
        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            // Verifica se os campos obrigatórios foram preenchidos
            if (string.IsNullOrWhiteSpace(textBoxNome.Text) ||
               string.IsNullOrWhiteSpace(comboBoxTipo.Text)
                )
            {
                MessageBox.Show("Insira pelo menos o nome e qual o tipo de marca!");
                return;
            }

            //Criação de cadastro de marca

            //Criação do objeto Marca e controleMarca
            Marca mMarca = new Marca();
            controleMarca cMarca = new controleMarca();

            //Definindo os valores nos atributos
            mMarca.setNomeMarca(textBoxNome.Text);
            mMarca.setDescMarca(richTextBoxDesc.Text);
            mMarca.setTipoMarca(comboBoxTipo.Text);

            //Chamada ao método de cadastro no ControleMarcaVeiculo
            string res = cMarca.cadastroMarcaVeiculo(mMarca);
            MessageBox.Show(res);
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
                DialogResult result = MessageBox.Show("Aviso! Tipo não registrado, deseja adicionar um novo?",
                                                      "Aviso!",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Ação para adicionar um novo fornecedor (sem adicionar o valor na ComboBox diretamente)
                    MessageBox.Show("Mantenha o valor digitado para cadastrar um novo tipo de marca",
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

        private void comboBoxTipo_DropDown(object sender, EventArgs e)
        {
            listarTipos();
        }
    }
}
