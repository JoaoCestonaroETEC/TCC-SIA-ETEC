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

        private void Cadastar_Cliente(object sender, EventArgs e)
        {
            CadastroLogin MLogin = new CadastroLogin();
            controleCliente cCliente = new controleCliente();

            MLogin.setCnpj(maskedTextBoxCnpj.Text);
            MLogin.setNome(maskedTextBoxNome.Text);
            MLogin.setSenha(maskedTextBoxSenha.Text);

            string res = cCliente.cadastroLogin(MLogin);
            MessageBox.Show(res);
        }
    }
}
