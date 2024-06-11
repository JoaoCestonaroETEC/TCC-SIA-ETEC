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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IdLogin mIdLogin = new IdLogin();
            controleCliente cCliente = new controleCliente();

            mIdLogin.setUsuario(maskedTextBox1.Text);
            mIdLogin.setSenha(maskedTextBox2.Text);

            string res = cCliente.compararSenha(mIdLogin);
            MessageBox.Show(res);
        }
    }
}
