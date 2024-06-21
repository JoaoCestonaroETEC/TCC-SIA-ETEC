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
    public partial class CadastroTipo : Form
    {
        public CadastroTipo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tipo mTipo = new Tipo();
            controleTipo cTipo = new controleTipo();

            mTipo.setNomeTipo(textBox1.Text);

            string res = cTipo.cadastroTipo(mTipo);
            MessageBox.Show(res);
        }
    }
}
