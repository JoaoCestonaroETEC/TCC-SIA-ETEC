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
            #endregion

            #region Campos de gêneros
            //Adiciona gêneros
            comboBoxSexo.Items.AddRange(new string[]
            {
                "Masculino",
                "Feminino",
                "Outro"
            });
            #endregion
        }
        #endregion

        #region Cadastrar cliente
        //Evento de cadastrar cliente
        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            // Verifica se os campos obrigatórios foram preenchidos
            if (string.IsNullOrWhiteSpace(maskedTextBoxCPF.Text) &&
                string.IsNullOrWhiteSpace(textBoxNome.Text) &&
                string.IsNullOrWhiteSpace(maskedTextBoxNumero.Text) &&
                string.IsNullOrWhiteSpace(maskedTextBoxCep.Text) &&
                string.IsNullOrWhiteSpace(textBoxBairro.Text) &&
                string.IsNullOrWhiteSpace(textBoxCidade.Text) &&
                string.IsNullOrWhiteSpace(textBoxRua.Text) &&
                string.IsNullOrWhiteSpace(comboBoxUf.Text) &&
                string.IsNullOrWhiteSpace(comboBoxSexo.Text) &&
                string.IsNullOrWhiteSpace(maskedTextBoxTelefone.Text) &&
                string.IsNullOrWhiteSpace(dateTimePickerNasc.Text)
                )
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            //Criação do objeto Cliente e controleCliente
            Cliente mCliente = new Cliente();
            controleCliente cCliente = new controleCliente();

            //Definindo os valores nos atributos

            //Faz uma verificação para tentar enviar o valor para o atributo, se existiver vazia ele envia vazia sem dar erro
            string CNPJ = "00000000000";
            string Razao = "Indefinido";

            mCliente.setCNPJCLiente(CNPJ);
            mCliente.setRazao(Razao);

            mCliente.setCpfCliente(maskedTextBoxCPF.Text);
            mCliente.setNomeCliente(textBoxNome.Text);
            mCliente.setEmailCliente(maskedTextBoxEmail.Text);
            mCliente.setDataNascCliente(Convert.ToDateTime(dateTimePickerNasc.Text));
            mCliente.setData(Convert.ToDateTime(dateTimePickerData.Text));
            mCliente.setSexo(comboBoxSexo.Text);
            mCliente.setTelefone(maskedTextBoxTelefone.Text);
            mCliente.setObs(richTextBoxObs.Text);

            //Faz uma verificação para tentar enviar o valor para o atributo, se existiver vazia ele envia vazia sem dar erro
            long numero;
            if (long.TryParse(maskedTextBoxNumero.Text, out numero))
            {
                mCliente.setNumero(numero);
            }

            mCliente.setRua(textBoxRua.Text);
            mCliente.setCidade(textBoxCidade.Text);

            //Faz uma verificação para tentar enviar o valor para o atributo, se existiver vazia ele envia vazia sem dar erro
            long cep;
            if (long.TryParse(maskedTextBoxCep.Text, out cep))
            {
                mCliente.setCep(cep);
            }

            mCliente.setBairro(textBoxBairro.Text);
            mCliente.setUf(comboBoxUf.Text);

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
                string.IsNullOrWhiteSpace(maskedTextBoxTelefone.Text) &&
                string.IsNullOrWhiteSpace(dateTimePickerNasc.Text)
                )
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            //Criação do objeto Cliente e controleCliente
            Cliente mClienteJ = new Cliente();
            controleCliente cClienteJ = new controleCliente();

            //Definindo os valores nos atributos

            //Faz uma verificação para tentar enviar o valor para o atributo, se existiver vazia ele envia vazia sem dar erro
            string CPF = "00000000000000";
            string DataNasc = "01/01/0001";
            string Sexo = "Indefinido";
            string Razao = "Indefinido";

            mClienteJ.setCpfCliente(CPF);
            mClienteJ.setDataNascCliente(Convert.ToDateTime(DataNasc));
            mClienteJ.setSexo(Sexo);
            mClienteJ.setRazao(Razao);

            mClienteJ.setCNPJCLiente(maskedTextBoxCPF.Text);
            mClienteJ.setNomeCliente(textBoxNome.Text);
            mClienteJ.setEmailCliente(maskedTextBoxEmail.Text);
            mClienteJ.setTelefone(maskedTextBoxTelefone.Text);
            mClienteJ.setObs(richTextBoxRazao.Text);
            mClienteJ.setData(Convert.ToDateTime(dateTimePickerDataJ.Text));

            //Faz uma verificação para tentar enviar o valor para o atributo, se existiver vazia ele envia vazia sem dar erro
            long numero;
            if (long.TryParse(maskedTextBoxNumeroJ.Text, out numero))
            {
                {
                    mClienteJ.setNumero(numero);
                }

                mClienteJ.setRua(textBoxRuaJ.Text);
                mClienteJ.setCidade(textBoxCidadeJ.Text);

                //Faz uma verificação para tentar enviar o valor para o atributo, se existiver vazia ele envia vazia sem dar erro
                long cep;
                if (long.TryParse(maskedTextBoxCepJ.Text, out cep))
                {
                    mClienteJ.setCep(cep);
                }

                mClienteJ.setBairro(textBoxBairroJ.Text);
                mClienteJ.setUf(comboBoxUfJ.Text);

                //Chamada ao método de cadastro no ControleCliente
                string res = cClienteJ.cadastroClienteJ(mClienteJ);

                //Mostra o resultado
                MessageBox.Show(res);
            }
        }
        #endregion

        #region Carrega o formulário
        private void CadastroCliente_Load(object sender, EventArgs e)
        {
            //Definir eventos para validar a entrada
            maskedTextBoxNumero.KeyPress += new KeyPressEventHandler(maskedTextBoxNumero_KeyPress);
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
