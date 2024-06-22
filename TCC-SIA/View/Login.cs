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
            // Verifica se os campos obrigatórios foram preenchidos
            if (string.IsNullOrWhiteSpace(textBoxNomeOuEmail.Text) ||
                string.IsNullOrWhiteSpace(textBoxSenha.Text))

            {
                MessageBox.Show("Insira pelo menos o nome e o valor!");
                return;
            }
            IdLogin mIdLogin = new IdLogin();
            controleLogin cCliente = new controleLogin();

            mIdLogin.setUsuarioLogin(textBoxNomeOuEmail.Text);
            mIdLogin.setEmailLogin(textBoxNomeOuEmail.Text);
            mIdLogin.setSenhaLogin(textBoxSenha.Text);

            string res = cCliente.efetuarLogin(mIdLogin);
            MessageBox.Show(res);
        }
        #endregion
    }
}
