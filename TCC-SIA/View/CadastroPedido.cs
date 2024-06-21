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
    public partial class CadastroPedido : Form
    {
        public CadastroPedido()
        {
            InitializeComponent();
        }


        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            Pedido mPedido = new Pedido();
            controlePedido cPedido = new controlePedido();

            mPedido.setIdVeiculo(Convert.ToInt64(comboBoxVeiculo.Text));
            mPedido.setCpfCliente(Convert.ToInt64(comboBoxCliente.Text));

            mPedido.setValorTotalPedido(Convert.ToInt64(maskedTextBoxValor.Text));
            mPedido.setValorTotalPeca(Convert.ToInt64(maskedTextBoxValorTotalPeca.Text));
            mPedido.setValorTotalServico(Convert.ToInt64(maskedTextBoxValorTotalServico.Text));
            mPedido.setObservacao(richTextBoxObs.Text);
            mPedido.setDataInicio(Convert.ToDateTime(dataTimePickerInicio.Text));
            mPedido.setDataFim(Convert.ToDateTime(dataTimePickerFim.Text));


            string res = cPedido.cadastroPedido(mPedido);
            MessageBox.Show(res);

        }

        private void CadastroPedido_Load(object sender, EventArgs e)
        {
            Pedido mPedido = new Pedido();
            controlePedido cPedido = new controlePedido();
            int res = cPedido.ProximoIdPedido(mPedido);
            MessageBox.Show(Convert.ToString(res));
            mPedido.setIdVeiculo(Convert.ToInt64(res));
        }
    }
}
