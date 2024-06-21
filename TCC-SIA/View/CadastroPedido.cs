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

        private void Pedido_Load(object sender, EventArgs e)
        {
            Pedido mPedido = new Pedido();
            controlePedido cPedido = new controlePedido();

            string res = cPedido.verificarPedidoCliente(mPedido);
            MessageBox.Show(res);
        }

        private void Cadastrar_Pedidos(object sender, EventArgs e)
        {
            Pedido mPedido = new Pedido();
            controlePedido cPedido = new controlePedido();

            try
            {
                mPedido.setPlacaVeiculo(maskPlaca.Text);
                mPedido.setTipoVeiculo(Convert.ToString(cbbTipoVeiculo.SelectedValue));
                mPedido.setMarcaVeiculo(Convert.ToString(cbbMarca.SelectedValue));
                mPedido.setModeloVeiculo(Convert.ToString(cbbModelo.SelectedValue));
                mPedido.setCorVeiculo(Convert.ToString(cbbCor.SelectedValue));
                mPedido.setObservacao(richTextBox1.Text);
                mPedido.setValorTotal(Convert.ToDecimal(txbValorTotal.Text));
                mPedido.setDataInicio(Convert.ToDateTime(dataTimeInicio.Text));
                mPedido.setDataFim(Convert.ToDateTime(dataTimeFim.Text));


                string res = cPedido.cadastroPedido(mPedido);
                MessageBox.Show(res);
            }catch
            {
                MessageBox.Show("Pô Eduardo, preenche tudo certo men!!!");
            }
        }
    }
}
