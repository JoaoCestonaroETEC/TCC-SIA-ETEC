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
    public partial class CadastroPeça : Form
    {
        public CadastroPeça()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Peca mPeca = new Peca();
            controlePeca cPeca = new controlePeca();

            mPeca.setNomePeca(textBoxNome.Text);
            mPeca.setGarantiaPeca(Convert.ToDateTime(dateTimePickerPeca.Text);
            mPeca.setDescPeca(richTextBoxDesc.Text);
            mPeca.setValorPeca(Convert.ToInt64(maskedTextBoxValor.Text));
            mPeca.setMarcaPeca(comboBoxMarca.Text);
            mPeca.setQuantPeca(Convert.ToInt32(numericUpDownQuant.Text));

            string res = cPeca.cadastroPeca(mPeca);
            MessageBox.Show(res);
        }
    }
}
