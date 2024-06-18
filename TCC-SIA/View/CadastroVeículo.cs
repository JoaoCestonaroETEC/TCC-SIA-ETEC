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
    public partial class CadastroVeículo : Form
    {
        public CadastroVeículo()
        {
            InitializeComponent();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            Veiculo mVeiculo = new Veiculo();
            controleVeiculo cVeiculo = new controleVeiculo();

            mVeiculo.setCpfCliente(Convert.ToInt32(textBoxCpf.Text));
            mVeiculo.setCor(textBoxCor.Text);
            mVeiculo.setMarca(textBoxMarca.Text);
            mVeiculo.setTipo(textBoxTipo.Text);
            mVeiculo.setModelo(textBoxModelo.Text);
            mVeiculo.setPlaca(textBoxPlaca.Text);

            string res = cVeiculo.cadastroVeiculo(mVeiculo);
            MessageBox.Show(res);
        }
    }
}
