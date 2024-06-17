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
using TCC_SIA.Controller;
//adiciona importação do Model e controll

namespace TCC_SIA.View
{
    public partial class CadastroServiço : Form
    {
        public CadastroServiço()
        {
            InitializeComponent();
        }

        private void cadastrarServico(object sender, EventArgs e)
        {
            modeloServ mServico = new modeloServ();

            mServico.setNomeServ(txbNomeServ.Text);
            mServico.setValorServ(Convert.ToDecimal(maskValor.Text));

        }
    }
}
