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
        #region Inicializa o formulário
        public CadastroCliente()
        {
            InitializeComponent();

            #region Campos dos estados
            //Adiciona campos de estados do Brasil
            comboBoxUfF.Items.AddRange(new string[]
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
            #endregion

            #region Campos de gêneros
            //Adiciona gêneros
            comboBoxSexoF.Items.AddRange(new string[]
            {
                "Masculino",
                "Feminino",
                "Outro"
            });
            #endregion
        }
        #endregion

        #region Cadastrar cliente físico
        //Evento de cadastrar cliente físico
        private void buttonCadastrarF_Click(object sender, EventArgs e)
        {
            // Verifica se os campos obrigatórios foram preenchidos
            if (string.IsNullOrWhiteSpace(maskedTextBoxCPFF.Text) &&
                string.IsNullOrWhiteSpace(textBoxNomeF.Text) &&
                string.IsNullOrWhiteSpace(maskedTextBoxNumeroF.Text) &&
                string.IsNullOrWhiteSpace(maskedTextBoxCepF.Text) &&
                string.IsNullOrWhiteSpace(textBoxBairroF.Text) &&
                string.IsNullOrWhiteSpace(textBoxCidadeF.Text) &&
                string.IsNullOrWhiteSpace(textBoxRuaF.Text) &&
                string.IsNullOrWhiteSpace(comboBoxUfF.Text) &&
                string.IsNullOrWhiteSpace(comboBoxSexoF.Text) &&
                string.IsNullOrWhiteSpace(maskedTextBoxTelefoneF.Text) &&
                string.IsNullOrWhiteSpace(dateTimePickerNascF.Text)
                )
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            //Criação do objeto Cliente e controleCliente
            ClienteF mCliente = new ClienteF();
            controleCliente cCliente = new controleCliente();

            //Definindo os valores nos atributos

            //Faz uma verificação para tentar enviar o valor para o atributo, se existiver vazia ele envia vazia sem dar erro

            mCliente.setCpfCliente(maskedTextBoxCPFF.Text);
            mCliente.setNomeCliente(textBoxNomeF.Text);
            mCliente.setEmailCliente(maskedTextBoxEmailF.Text);
            mCliente.setDataNascCliente(Convert.ToDateTime(dateTimePickerNascF.Text));
            mCliente.setData(Convert.ToDateTime(dateTimePickerDataF.Text));
            mCliente.setSexo(comboBoxSexoF.Text);
            mCliente.setTelefone(maskedTextBoxTelefoneF.Text);
            mCliente.setObs(richTextBoxObsF.Text);

            //Faz uma verificação para tentar enviar o valor para o atributo, se existiver vazia ele envia vazia sem dar erro
            long numero;
            if (long.TryParse(maskedTextBoxNumeroF.Text, out numero))
            {
                mCliente.setNumero(numero);
            }

            mCliente.setRua(textBoxRuaF.Text);
            mCliente.setCidade(textBoxCidadeF.Text);

            //Faz uma verificação para tentar enviar o valor para o atributo, se existiver vazia ele envia vazia sem dar erro
            long cep;
            if (long.TryParse(maskedTextBoxCepF.Text, out cep))
            {
                mCliente.setCep(cep);
            }

            mCliente.setBairro(textBoxBairroF.Text);
            mCliente.setUf(comboBoxUfF.Text);

            //Chamada ao método de cadastro no ControleCliente
            string res = cCliente.cadastroCliente(mCliente);

            //Mostra o resultado
            MessageBox.Show(res);
        }
        #endregion

        #region Cadastrar cliente jurídico
        //Evento de cadastrar cliente jurídico
        private void buttonCadastrarJ_Click(object sender, EventArgs e)
        {
            // Verifica se os campos obrigatórios foram preenchidos
            if (string.IsNullOrWhiteSpace(maskedTextBoxCNPJ.Text) &&
                string.IsNullOrWhiteSpace(textBoxNomeJ.Text) &&
                string.IsNullOrWhiteSpace(maskedTextBoxNumeroJ.Text) &&
                string.IsNullOrWhiteSpace(maskedTextBoxCepJ.Text) &&
                string.IsNullOrWhiteSpace(textBoxBairroJ.Text) &&
                string.IsNullOrWhiteSpace(textBoxCidadeJ.Text) &&
                string.IsNullOrWhiteSpace(textBoxRuaJ.Text) &&
                string.IsNullOrWhiteSpace(comboBoxUfJ.Text) &&
                string.IsNullOrWhiteSpace(maskedTextBoxTelefoneF.Text) &&
                string.IsNullOrWhiteSpace(dateTimePickerNascF.Text)
                )
            {
                MessageBox.Show("Preencha todos os campos!");
                return;

                //Criação do objeto Cliente e controleCliente
                Cliente mCliente = new Cliente();
                controleCliente cCliente = new controleCliente();

                //Definindo os valores nos atributos

                //Faz uma verificação para tentar enviar o valor para o atributo, se existiver vazia ele envia vazia sem dar erro

                mCliente.setCNPJCLiente(maskedTextBoxCPFF.Text);
                mCliente.setNomeCliente(textBoxNomeF.Text);
                mCliente.setEmailCliente(maskedTextBoxEmailF.Text);
                mCliente.setTelefone(maskedTextBoxTelefoneF.Text);
                mCliente.setObs(richTextBoxRazao.Text);
                mCliente.setData(Convert.ToDateTime(dateTimePickerDataJ.Text));

                //Faz uma verificação para tentar enviar o valor para o atributo, se existiver vazia ele envia vazia sem dar erro
                long numero;
                if (long.TryParse(maskedTextBoxNumeroJ.Text, out numero))
                {
                    mCliente.setNumero(numero);
                }

                mCliente.setRua(textBoxRuaJ.Text);
                mCliente.setCidade(textBoxCidadeJ.Text);

                //Faz uma verificação para tentar enviar o valor para o atributo, se existiver vazia ele envia vazia sem dar erro
                long cep;
                if (long.TryParse(maskedTextBoxCepJ.Text, out cep))
                {
                    mCliente.setCep(cep);
                }

                mCliente.setBairro(textBoxBairroJ.Text);
                mCliente.setUf(comboBoxUfJ.Text);

                //Chamada ao método de cadastro no ControleCliente
                string res = cCliente.cadastroCliente(mCliente);

                //Mostra o resultado
                MessageBox.Show(res);
            }
        }
        #endregion

        #region Carrega o formulário
        private void CadastroCliente_Load(object sender, EventArgs e)
        {
            //Definir eventos para validar a entrada
            maskedTextBoxNumeroF.KeyPress += new KeyPressEventHandler(maskedTextBoxNumero_KeyPress);
        }
        #endregion

        #region Método de aceitar apenas números
        private void maskedTextBoxNumero_KeyPress(object sender, KeyPressEventArgs e)
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
