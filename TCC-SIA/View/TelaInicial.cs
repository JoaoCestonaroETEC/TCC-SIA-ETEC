﻿using System;
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
        #region Inicializa o formulário
        public TelaInicial()
        {
            InitializeComponent();
        }
        #endregion

        #region Abrir cadastro de serviço
        private void sERVIÇOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroServico formServico = new CadastroServico();
            formServico.Show();
        }
        #endregion

        #region Abrir cadastro de peça
        private void pEÇAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroPeca formPeça = new CadastroPeca();
            formPeça.Show();
        }
        #endregion

        #region Abrir cadastro de cliente
        private void cLIENTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroCliente formCliente = new CadastroCliente();
            formCliente.Show();
        }
        #endregion

        #region Abrir cadastro de veículo
        private void vEÍCULOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroVeiculo formVeiculo = new CadastroVeiculo();
            formVeiculo.Show();
        }
        #endregion

        #region Abrir cadastro de marca
        private void mARCAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroMarca formMarca = new CadastroMarca();
            formMarca.Show();
        }
        #endregion

        #region Abrir cadastro de pedido
        private void pEDIDOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroPedido formPedido = new CadastroPedido();
            formPedido.Show();
        }
        #endregion

        #region Pesquisar serviço
        private void sERVIÇOToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PesquisaServico formServico = new PesquisaServico();
            formServico.Show();
        }
        #endregion

        #region Pesquisar peça
        private void pEÇAToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PesquisaPeca formPeca = new PesquisaPeca();
            formPeca.Show();
        }
        #endregion

        #region Pesquisar cliente
        private void cLIENTEToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PesquisaCliente formCliente = new PesquisaCliente();
            formCliente.Show();
        }
        #endregion

        #region Pesquisar veículo
        private void vEÍCULOToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PesquisaVeiculo formVeiculo = new PesquisaVeiculo();
            formVeiculo.Show();
        }
        #endregion

        #region Pesquisar veículo
        private void mARCAToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PesquisaMarca formMarca = new PesquisaMarca();
            formMarca.Show();
        }
        #endregion
    }
}
