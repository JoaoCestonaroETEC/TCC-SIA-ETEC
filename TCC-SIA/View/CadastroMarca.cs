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
            if (string.IsNullOrWhiteSpace(textBoxNome.Text) ||
               string.IsNullOrWhiteSpace(comboBoxTipo.Text)
                )
            {
                MessageBox.Show("Insira pelo menos o nome!");
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

            //Chamada ao método de cadastro no ControleMarca
            string res = cMarca.cadastroMarca(mMarca);
            MessageBox.Show(res);
        }
        #endregion
    }
}
