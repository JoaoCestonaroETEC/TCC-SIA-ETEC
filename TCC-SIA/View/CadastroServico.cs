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
    public partial class CadastroServico : Form
    {
        public CadastroServico()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Servico mServico = new Servico();
            controleServico cServico = new controleServico();

            mServico.NomeServico = textBox1.Text;
            mServico.TipoServico = comboBox1.Text;
            mServico.ValorServico = Convert.ToInt32(maskedTextBox1.Text);
            mServico.DescServico = richTextBox1.Text;

            string res = cServico.cadastroServico(mServico);
            MessageBox.Show(res);
        }
    }
}
