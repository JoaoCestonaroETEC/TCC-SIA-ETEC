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
            LoginEmpresa MLogin = new LoginEmpresa();
            controleCliente cCliente = new controleCliente();

            MLogin.setCnpj(Convert.ToInt32(maskedTextBoxCnpj.Text));
            MLogin.setNome(maskedTextBoxNome.Text);
            MLogin.setSenha(maskedTextBoxSenha.Text);

            string res = cCliente.cadastroCliente(MLogin);
            MessageBox.Show(res);
        }
    }
}
