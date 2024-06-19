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

        private void button1_Click(object sender, EventArgs e)
        {
            Cadastro formCadastro = new Cadastro();
            formCadastro.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login formLogin = new Login();
            formLogin.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CadastroVeículo formVeiculo = new CadastroVeículo();
            formVeiculo.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CadastroPeça formPeça = new CadastroPeça();
            formPeça.Show();
        }
    }
}
