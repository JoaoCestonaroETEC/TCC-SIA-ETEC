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
            modeloServ mServico = new modeloServ(); // criei variavel para receber as informações da classe "modeloServ"

            //Abaixo estou pegando info dos campos e setando nas variaveis do modeloServ
            mServico.setNomeServ(txbNomeServ.Text);
            mServico.setValorServ(Convert.ToDecimal(maskValor.Text));

            MessageBox.Show'Aparentemente tudo certo'; //poha o texto

        }
    }
}
