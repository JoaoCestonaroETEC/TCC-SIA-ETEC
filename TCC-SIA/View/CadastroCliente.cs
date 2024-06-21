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
    public partial class CadastroCliente : Form
    {
        public CadastroCliente()
        {
            InitializeComponent();
            comboBoxUf.Items.AddRange(new string[]
            {
                "AC",
                "AL",
                "AP",
                "AM",
                "BA",
                "CE",
                "DF",
                "ES",
                "GO",
                "MA",
                "MT",
                "MS",
                "MG",
                "PA",
                "PB",
                "PR",
                "PE",
                "PI",
                "RJ",
                "RN",
                "RS",
                "RO",
                "RR",
                "SC",
                "SP",
                "SE",
                "TO"
            });
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            // Verifica se os campos obrigatórios foram preenchidos
            if (string.IsNullOrWhiteSpace(maskedTextBoxCPF.Text) ||
                string.IsNullOrWhiteSpace(maskedTextBoxTelefone.Text) ||
                string.IsNullOrWhiteSpace(textBoxNome.Text))
            {
                MessageBox.Show("CPF, telefone e nome são campos obrigatórios.");
                return;
            }

            // Criação do objeto Cliente e ControleCliente
            Cliente mCliente = new Cliente();
            ControleCliente cCliente = new ControleCliente();

            // Validação e atribuição dos campos obrigatórios
            long cpf;
            if (!long.TryParse(maskedTextBoxCPF.Text, out cpf))
            {
                MessageBox.Show("CPF inválido.");
                return;
            }
            mCliente.setCpfCliente(cpf);

            mCliente.setTelefoneCliente(maskedTextBoxTelefone.Text);
            mCliente.setNomeCliente(textBoxNome.Text);

            // Atribuição dos demais campos
            mCliente.setEmailCliente(textBoxEmail.Text);

            DateTime dataNascimento;
            if (DateTime.TryParse(dateTimePickerNasc.Text, out dataNascimento))
            {
                mCliente.setDataNascCliente(dataNascimento);
            }

            int numero;
            if (int.TryParse(maskedTextBoxNumero.Text, out numero))
            {
                mCliente.setNumero(numero);
            }

            mCliente.setRua(textBoxRua.Text);
            mCliente.setBairro(textBoxBairro.Text);
            mCliente.setCidade(textBoxCidade.Text);

            int cep;
            if (int.TryParse(maskedTextBoxCep.Text, out cep))
            {
                mCliente.setCep(cep);
            }

            mCliente.setUf(comboBoxUf.Text);
            mCliente.setSexo(textBoxSexo.Text);

            // Chamada ao método de cadastro no ControleCliente
            string res = cCliente.cadastroCliente(mCliente);
            MessageBox.Show(res);
        }

        private void CadastroCliente_Load(object sender, EventArgs e)
        {
            // Definir eventos para validar a entrada
            maskedTextBoxNumero.KeyPress += new KeyPressEventHandler(maskedTextBoxNumero_KeyPress);
        }

        private void maskedTextBoxNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica se a tecla pressionada é um dígito ou uma tecla de controle (como Backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Impede a entrada de caracteres não numéricos
            }
        }
    }
}
