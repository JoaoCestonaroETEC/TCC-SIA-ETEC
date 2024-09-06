using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TCC_SIA.Controller;
using TCC_SIA.Model;

namespace TCC_SIA.View
{
    public partial class LoginBanco : Form
    {
        public LoginBanco()
        {
            InitializeComponent();
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            #region Logar Banco
            //Evento de cadastrar cliente

            // Verifica se os campos obrigatórios foram preenchidos
            if (string.IsNullOrWhiteSpace(maskedTextBoxServer.Text) &&
                string.IsNullOrWhiteSpace(maskedTextBoxPort.Text) &&
                string.IsNullOrWhiteSpace(maskedTextBoxUser.Text) &&
                string.IsNullOrWhiteSpace(maskedTextBoxPassword.Text) &&
                string.IsNullOrWhiteSpace(maskedTextBoxPort.Text))

            {
                    MessageBox.Show("Preencha todos os campos!");
                    return;
            }

            //Criação do objeto Cliente e controleCliente
            Banco mLogin = new Banco();
            conexaoBD ControleBanco = new conexaoBD();

            mLogin.SetServer(maskedTextBoxServer.Text);
            mLogin.SetPort(Convert.ToInt32(maskedTextBoxPort.Text));
            mLogin.SetUser(maskedTextBoxUser.Text);
            mLogin.SetSenha(maskedTextBoxPassword.Text);
            mLogin.SetBanco(maskedTextBoxDB.Text);
               
                MessageBox.Show(res);
            #endregion
        }
    }
}
