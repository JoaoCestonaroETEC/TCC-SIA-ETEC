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
            controleLogin cCliente = new controleLogin();

            mIdLogin.setUsuario(maskedTextBox1.Text);
            mIdLogin.setEmail(maskedTextBox1.Text);
            mIdLogin.setSenha(maskedTextBox2.Text);

            string res = cCliente.loginCadastro(mIdLogin);
            MessageBox.Show(res);
        }
    }
}
