using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCC_SIA.Controller;
using TCC_SIA.Model;

namespace TCC_SIA.View
{
    public partial class CadastroCliente : Form
    {
        public CadastroCliente()
        {
            InitializeComponent();
        }

        private void buttonCadastrarF_Click(object sender, EventArgs e)
        {
            // Verifica se os campos obrigatórios foram preenchidos
            if (string.IsNullOrWhiteSpace(maskedTextBoxCPFF.Text) ||
                string.IsNullOrWhiteSpace(textBoxNomeF.Text) ||
                string.IsNullOrWhiteSpace(maskedTextBoxNumeroF.Text) ||
                string.IsNullOrWhiteSpace(maskedTextBoxCepF.Text) ||
                string.IsNullOrWhiteSpace(textBoxBairroF.Text) ||
                string.IsNullOrWhiteSpace(textBoxCidadeF.Text) ||
                string.IsNullOrWhiteSpace(textBoxRuaF.Text) ||
                string.IsNullOrWhiteSpace(comboBoxUfF.Text) ||
                string.IsNullOrWhiteSpace(comboBoxSexoF.Text) ||
                string.IsNullOrWhiteSpace(maskedTextBoxTelefoneF.Text) ||
                string.IsNullOrWhiteSpace(dateTimePickerNascF.Text))
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            Cliente mCliente = new Cliente();
            controleCliente cCliente = new controleCliente();

            mCliente.setCpfCliente(maskedTextBoxCPFF.Text);
            mCliente.setNomeCliente(textBoxNomeF.Text);
            mCliente.setEmailCliente(maskedTextBoxEmailF.Text);
            mCliente.setDataNascCliente(Convert.ToDateTime(dateTimePickerNascF.Value));
            mCliente.setData(Convert.ToDateTime(dateTimePickerDataF.Value));
            mCliente.setSexo(comboBoxSexoF.Text);
            mCliente.setTelefone(maskedTextBoxTelefoneF.Text);
            mCliente.setObs(richTextBoxObsF.Text);

            if (long.TryParse(maskedTextBoxNumeroF.Text, out long numero))
            {
                mCliente.setNumero(numero);
            }

            mCliente.setRua(textBoxRuaF.Text);
            mCliente.setCidade(textBoxCidadeF.Text);

            if (long.TryParse(maskedTextBoxCepF.Text, out long cep))
            {
                mCliente.setCep(cep);
            }

            mCliente.setBairro(textBoxBairroF.Text);
            mCliente.setUf(comboBoxUfF.Text);
            mCliente.setStatus(comboBoxStatusF.Text);

            string res = cCliente.cadastroClienteF(mCliente);
            MessageBox.Show(res);
        }

        private void buttonCadastrarJ_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(maskedTextBoxCNPJ.Text) ||
                string.IsNullOrWhiteSpace(textBoxNomeJ.Text) ||
                string.IsNullOrWhiteSpace(maskedTextBoxNumeroJ.Text) ||
                string.IsNullOrWhiteSpace(maskedTextBoxCepJ.Text) ||
                string.IsNullOrWhiteSpace(textBoxBairroJ.Text) ||
                string.IsNullOrWhiteSpace(textBoxCidadeJ.Text) ||
                string.IsNullOrWhiteSpace(textBoxRuaJ.Text) ||
                string.IsNullOrWhiteSpace(comboBoxUfJ.Text) ||
                string.IsNullOrWhiteSpace(maskedTextBoxTelefoneJ.Text))
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            Cliente mCliente = new Cliente();
            controleCliente cCliente = new controleCliente();

            mCliente.setCNPJCLiente(maskedTextBoxCNPJ.Text);
            mCliente.setNomeCliente(textBoxNomeJ.Text);
            mCliente.setEmailCliente(maskedTextBoxEmailJ.Text);
            mCliente.setTelefone(maskedTextBoxTelefoneJ.Text);
            mCliente.setRazao(richTextBoxRazao.Text);
            mCliente.setData(Convert.ToDateTime(dateTimePickerDataJ.Value));

            if (long.TryParse(maskedTextBoxNumeroJ.Text, out long numero))
            {
                mCliente.setNumero(numero);
            }

            mCliente.setRua(textBoxRuaJ.Text);
            mCliente.setCidade(textBoxCidadeJ.Text);

            if (long.TryParse(maskedTextBoxCepJ.Text, out long cep))
            {
                mCliente.setCep(cep);
            }

            mCliente.setBairro(textBoxBairroJ.Text);
            mCliente.setUf(comboBoxUfJ.Text);
            mCliente.setStatus(comboBoxStatusJ.Text);

            string res = cCliente.cadastroClienteJ(mCliente);
            MessageBox.Show(res);
        }

        private void CadastroCliente_Load(object sender, EventArgs e)
        {
            maskedTextBoxNumeroF.KeyPress += new KeyPressEventHandler(maskedTextBoxNumero_KeyPress);
        }

        private void maskedTextBoxNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void comboBoxUfF_Validated(object sender, EventArgs e)
        {
            System.Windows.Forms.ComboBox comboBox = sender as System.Windows.Forms.ComboBox;
            string fornecedorDigitado = comboBox.Text;

            // Verifica se o valor digitado já existe na lista de itens da ComboBox
            bool fornecedorExiste = comboBox.Items.Cast<System.Data.DataRowView>()
                                       .Any(item => item.ToString()
                                       .Equals(fornecedorDigitado, StringComparison.OrdinalIgnoreCase));

            if (!fornecedorExiste && !string.IsNullOrEmpty(fornecedorDigitado))
            {
                // Exibe a mensagem com o aviso
                DialogResult result = MessageBox.Show("Selecione um Estado!",
                                                      "Aviso!",
                                                      MessageBoxButtons.OK,
                                                      MessageBoxIcon.Warning);

                if (result == DialogResult.No)
                {
                    // Ação para adicionar um novo fornecedor (sem adicionar o valor na ComboBox diretamente)
                    MessageBox.Show("Mantenha o valor digitado para cadastrar um novo tipo de peça",
                                    "Ação Necessária",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                else
                {
                    // Limpa o texto da ComboBox
                    comboBox.Text = string.Empty;
                }
            }
        }
    }
}
