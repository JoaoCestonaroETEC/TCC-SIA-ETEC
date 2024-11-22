using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCC_SIA.View
{
    public partial class ListaDeCadastrar : Form
    {
        public ListaDeCadastrar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastroCliente formPeça = new CadastroCliente();
            formPeça.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CadastroMarca formPeça = new CadastroMarca();
            formPeça.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CadastroServico formPeça = new CadastroServico();
            formPeça.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CadastroPeca formPeça = new CadastroPeca();
            formPeça.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CadastroVeiculo formPeça = new CadastroVeiculo();
            formPeça.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CadastroPedido formPeça = new CadastroPedido();
            formPeça.Show();
        }
    }
}
