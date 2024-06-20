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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TCC_SIA.View
{
    public partial class CadastroCliente : Form
    {
        public CadastroCliente()
        {
            InitializeComponent();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            Cliente mCliente = new Cliente();
            ControleCliente cCliente = new ControleCliente();

            mCliente.setCpfCliente(long.Parse(maskedTextBoxCPF.Text));
            mCliente.setNomeCliente(textBoxNome.Text);
            mCliente.setEmailCliente(textBoxEmail.Text);
            mCliente.setDataNascCliente(Convert.ToDateTime(dateTimePickerNasc.Text));
            mCliente.setTelefoneCliente(Convert.ToString(maskedTextBoxTelefone.Text));
            mCliente.setNumero(Convert.ToInt32(textBoxNumero.Text));
            mCliente.setRua(textBoxRua.Text);
            mCliente.setBairro(textBoxBairro.Text);
            mCliente.setCidade(textBoxCidade.Text);
            mCliente.setCep(Convert.ToInt32(maskedTextBoxCep.Text));
            mCliente.setUf(textBoxUF.Text);
            mCliente.setSexo(textBoxSexo.Text);

            string res = cCliente.cadastroCliente(mCliente);
            MessageBox.Show(res);
        }
    }
}
