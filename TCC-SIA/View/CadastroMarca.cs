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

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            Marca mMarca = new Marca();
            controleMarca cMarca = new controleMarca();

            mMarca.setNomeMarca(comboBoxNome.Text);
            mMarca.setDescMarca(richTextBoxDesc.Text);

            string res = cMarca.cadastroMarca(mMarca);
            MessageBox.Show(res);
        }
    }
}
