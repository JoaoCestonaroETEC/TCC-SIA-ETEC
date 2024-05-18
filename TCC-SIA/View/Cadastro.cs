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
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente mCliente = new Cliente();
            controleCliente cCliente = new controleCliente();

            mCliente.setNomeCliente(maskedTextBox1.Text);
            mCliente.setEmailCliente(maskedTextBox2.Text);
            mCliente.setSenhaCliente(maskedTextBox3.Text);

            string res = cCliente.cadastroCliente(mCliente);
            MessageBox.Show(res);
        }
    }
}
