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
        #region Inicializa o formulário
        public Login()
        {
            InitializeComponent();
        }
        #endregion

        #region Efetuar login
        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            IdLogin mIdLogin = new IdLogin();
            controleLogin cCliente = new controleLogin();

            mIdLogin.setUsuarioLogin(maskedTextBox1.Text);
            mIdLogin.setEmailLogin(maskedTextBox1.Text);
            mIdLogin.setSenhaLogin(maskedTextBox2.Text);

            string res = cCliente.efetuarLogin(mIdLogin);
            MessageBox.Show(res);
        }
        #endregion
    }
}
