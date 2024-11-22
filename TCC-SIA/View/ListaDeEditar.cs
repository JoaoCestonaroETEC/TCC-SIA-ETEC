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
    public partial class ListaDeEditar : Form
    {
        public ListaDeEditar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PesquisaCliente formPeça = new PesquisaCliente();
            formPeça.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PesquisaMarca formPeça = new PesquisaMarca();
            formPeça.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PesquisaServico formPeça = new PesquisaServico();
            formPeça.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PesquisaPeca formPeça = new PesquisaPeca();
            formPeça.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PesquisaVeiculo formPeça = new PesquisaVeiculo();
            formPeça.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PesquisaPedido formPeça = new PesquisaPedido();
            formPeça.Show();
        }
    }
}
