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
        #region Inicializa o formulário
        public CadastroServico()
        {
            InitializeComponent();
        }
        #endregion

        #region Cadastrar serviço
        //Evento de cadastrar serviço
        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            // Verifica se os campos obrigatórios foram preenchidos
            if (string.IsNullOrWhiteSpace(textBoxNome.Text) ||
                string.IsNullOrWhiteSpace(maskedTextBoxValor.Text))

            {
                MessageBox.Show("Insira pelo menos o nome e o valor!");
                return;
            }

            // Criação do objeto Servico e controleServico
            Servico mServico = new Servico();
            controleServico cServico = new controleServico();

            //Definindo os valores nos atributos
            mServico.setNomeServico(textBoxNome.Text);
            mServico.setGarantiaServico(Convert.ToDateTime(dateTimePickerGarantia.Text));


            //Faz uma verificação para tentar enviar o valor para o atributo, se existiver vazia ele envia vazia sem dar erro
            decimal valor;
            if (decimal.TryParse(maskedTextBoxValor.Text, out valor))
            {
                mServico.setValorServico(valor);
            }

            mServico.setDescServico(richTextBoxDesc.Text);
            mServico.setStatus(comboBoxStatus.Text);

            //Chamada ao método de cadastro no ControleServico
            string res = cServico.cadastroServico(mServico);

            //Mostra o resultado
            MessageBox.Show(res);
        }
        #endregion

        #region Carrega o formulário
        private void CadastroServico_Load(object sender, EventArgs e)
        {
            //Definir eventos para validar a entrada
            maskedTextBoxValor.KeyPress += new KeyPressEventHandler(maskedTextBoxValor_KeyPress);
        }
        #endregion

        #region Método de aceitar apenas números
        private void maskedTextBoxValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Verifica se a tecla pressionada é um dígito ou uma tecla de controle (como Backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; //Impede a entrada de caracteres não numéricos
            }
        }
        #endregion
    }
}
