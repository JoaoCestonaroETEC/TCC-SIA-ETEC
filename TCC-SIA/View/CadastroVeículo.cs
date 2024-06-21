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
    public partial class CadastroVeículo : Form
    {
        public CadastroVeículo()
        {
            InitializeComponent();
            comboBoxCor.Items.Add("Branco");
            comboBoxCor.Items.Add("Preto");
            comboBoxCor.Items.Add("Prata");
            comboBoxCor.Items.Add("Cinza");
            comboBoxCor.Items.Add("Azul");
            comboBoxCor.Items.Add("Vermelho");

            comboBoxTipo.Items.Add("Carro");
            comboBoxTipo.Items.Add("Moto");
            comboBoxTipo.Items.Add("Bicileta");
            comboBoxTipo.Items.Add("Moto-cicleta");
            comboBoxTipo.Items.Add("Caminhão");
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            Veiculo mVeiculo = new Veiculo();
            controleVeiculo cVeiculo = new controleVeiculo();

            mVeiculo.setCpfCliente(Convert.ToInt64(maskedTextBoxCpf.Text));
            mVeiculo.setCor(comboBoxCor.Text);
            mVeiculo.setIdMarca(Convert.ToInt64(comboBoxMarca.Text));
            mVeiculo.setTipo(comboBoxTipo.Text);
            mVeiculo.setModelo(textBoxModelo.Text);
            mVeiculo.setPlaca(maskedTextBoxPlaca.Text);

            string res = cVeiculo.cadastroVeiculo(mVeiculo);
            MessageBox.Show(res);
        }

        private void CadastroVeículo_Load(object sender, EventArgs e)
        {

        }
    }
}
