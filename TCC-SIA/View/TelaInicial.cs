using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCC_SIA.Model;
using static System.Windows.Forms.DataFormats;

namespace TCC_SIA.View
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void sERVIÇOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroServico formServico = new CadastroServico();
            formServico.Show();
        }

        private void pEÇAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroPeca formPeça = new CadastroPeca();
            formPeça.Show();
        }

        private void vEÍCULOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroVeiculo formVeiculo = new CadastroVeiculo();
            formVeiculo.Show();
        }

        private void cLIENTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroCliente formCliente = new CadastroCliente();
            formCliente.Show();
        }

        private void tIPOToolStripMenuItem3_Click(object sender, EventArgs e)
        {
        }

        private void mARCAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroMarca formMarca = new CadastroMarca();
            formMarca.Show();
        }
    }
}
