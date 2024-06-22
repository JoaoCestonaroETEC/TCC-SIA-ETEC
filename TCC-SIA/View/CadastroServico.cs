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
    public partial class CadastroServico : Form
    {
        public CadastroServico()
        {
            InitializeComponent();
        }

        //Evento de cadastrar serviço
        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            // Criação do objeto Servico e ControleServico
            Servico mServico = new Servico();
            controleServico cServico = new controleServico();

            //Definindo os valores nos atributos
            mServico.setNomeServico(textBoxNome.Text);
            mServico.setValorServico(Convert.ToInt32(maskedTextBoxValor.Text));
            mServico.setDescServico(richTextBoxDesc.Text);

            //Chamada ao método de cadastro no ControleServico
            string res = cServico.cadastroServico(mServico);

            //Mostra o resultado
            MessageBox.Show(res);
        }

        private void CadastroServico_Load(object sender, EventArgs e)
        {
            //Definir eventos para validar a entrada
            maskedTextBoxValor.KeyPress += new KeyPressEventHandler(maskedTextBoxValor_KeyPress);
        }

        private void maskedTextBoxValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Verifica se a tecla pressionada é um dígito ou uma tecla de controle (como Backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; //Impede a entrada de caracteres não numéricos
            }
        }
    }
}
