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
            CadastroPeça formPeça = new CadastroPeça();
            formPeça.Show();
        }

        private void vEÍCULOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroVeículo formVeiculo = new CadastroVeículo();
            formVeiculo.Show();
        }

        private void cLIENTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroCliente cadastroCliente = new CadastroCliente();
            cadastroCliente.Show();
        }
    }
}
