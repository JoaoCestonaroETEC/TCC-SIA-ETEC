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
        }
        #endregion

        #region Cadastrar marca
        //Evento de cadastrar marca
        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            // Verifica se os campos obrigatórios foram preenchidos
            if (string.IsNullOrWhiteSpace(comboBoxNome.Text))
            {
                MessageBox.Show("Insira pelo menos o nome!");
                return;
            }

            //Criação do objeto Marca e ControleMarca
            Marca mMarca = new Marca();
            controleMarca cMarca = new controleMarca();

            //Definindo os valores nos atributos
            mMarca.setNomeMarca(comboBoxNome.Text);
            mMarca.setDescMarca(richTextBoxDesc.Text);

            //Chamada ao método de cadastro no ControleMarca
            string res = cMarca.cadastroMarca(mMarca);

            //Mostra o resultado
            MessageBox.Show(res);
        }
        #endregion

        private void CadastroMarca_Load(object sender, EventArgs e)
        {

        }
    }
}
