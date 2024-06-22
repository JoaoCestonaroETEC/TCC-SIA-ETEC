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
        #region Inicializa o formulário
        public Cadastro()
        {
            InitializeComponent();
        }
        #endregion

        #region Cadastrar login
        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            LoginEmpresa mLogin = new LoginEmpresa();
            controleLogin cCliente = new controleLogin();

            mLogin.setCnpj(Convert.ToInt64(maskedTextBoxCnpj.Text));
            mLogin.setNome(textBoxNome.Text);
            mLogin.setEmail(maskedTextBoxEmail.Text);
            mLogin.setSenha(maskedTextBoxSenha.Text);
            mLogin.setTelefone(Convert.ToInt64(maskedTextBoxTelefone.Text));

            string res = cCliente.cadastroLogin(mLogin);
            MessageBox.Show(res);
        }
        #endregion
    }
}
