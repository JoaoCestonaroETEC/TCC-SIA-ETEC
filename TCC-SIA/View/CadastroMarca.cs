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
        public CadastroMarca()
        {
            InitializeComponent();
        }

        //Evento de cadastrar marca
        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
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
    }
}
