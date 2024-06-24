namespace TCC_SIA.View
{
    partial class CadastroCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonCadastrar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            maskedTextBoxCPF = new MaskedTextBox();
            textBoxNome = new TextBox();
            dateTimePickerNasc = new DateTimePicker();
            label5 = new Label();
            maskedTextBoxTelefone = new MaskedTextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            textBoxBairro = new TextBox();
            textBoxCidade = new TextBox();
            maskedTextBoxCep = new MaskedTextBox();
            label12 = new Label();
            textBoxRua = new TextBox();
            comboBoxUf = new ComboBox();
            maskedTextBoxNumero = new MaskedTextBox();
            comboBoxSexo = new ComboBox();
            maskedTextBoxEmail = new MaskedTextBox();
            SuspendLayout();
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.Location = new Point(29, 331);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(203, 99);
            buttonCadastrar.TabIndex = 0;
            buttonCadastrar.Text = "Cadastrar";
            buttonCadastrar.UseVisualStyleBackColor = true;
            buttonCadastrar.Click += buttonCadastrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 65);
            label1.Name = "label1";
            label1.Size = new Size(36, 20);
            label1.TabIndex = 1;
            label1.Text = "CPF:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 101);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 2;
            label2.Text = "Nome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 137);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 3;
            label3.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 177);
            label4.Name = "label4";
            label4.Size = new Size(148, 20);
            label4.TabIndex = 4;
            label4.Text = "Data de Nascimento:";
            // 
            // maskedTextBoxCPF
            // 
            maskedTextBoxCPF.CutCopyMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            maskedTextBoxCPF.Location = new Point(78, 61);
            maskedTextBoxCPF.Mask = "000000000-00";
            maskedTextBoxCPF.Name = "maskedTextBoxCPF";
            maskedTextBoxCPF.Size = new Size(219, 27);
            maskedTextBoxCPF.TabIndex = 5;
            maskedTextBoxCPF.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(89, 97);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.PlaceholderText = "Insira seu nome";
            textBoxNome.Size = new Size(205, 27);
            textBoxNome.TabIndex = 7;
            // 
            // dateTimePickerNasc
            // 
            dateTimePickerNasc.Format = DateTimePickerFormat.Short;
            dateTimePickerNasc.Location = new Point(174, 169);
            dateTimePickerNasc.Name = "dateTimePickerNasc";
            dateTimePickerNasc.Size = new Size(121, 27);
            dateTimePickerNasc.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 254);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 10;
            label5.Text = "Telefone:";
            // 
            // maskedTextBoxTelefone
            // 
            maskedTextBoxTelefone.CutCopyMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            maskedTextBoxTelefone.Location = new Point(105, 250);
            maskedTextBoxTelefone.Mask = "(99) 00000-0000";
            maskedTextBoxTelefone.Name = "maskedTextBoxTelefone";
            maskedTextBoxTelefone.Size = new Size(97, 27);
            maskedTextBoxTelefone.TabIndex = 11;
            maskedTextBoxTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(304, 65);
            label6.Name = "label6";
            label6.Size = new Size(120, 20);
            label6.TabIndex = 12;
            label6.Text = "Numero da casa:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(306, 101);
            label7.Name = "label7";
            label7.Size = new Size(37, 20);
            label7.TabIndex = 13;
            label7.Text = "Rua:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(312, 213);
            label8.Name = "label8";
            label8.Size = new Size(52, 20);
            label8.TabIndex = 14;
            label8.Text = "Bairro:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(312, 141);
            label9.Name = "label9";
            label9.Size = new Size(59, 20);
            label9.TabIndex = 15;
            label9.Text = "Cidade:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(320, 177);
            label10.Name = "label10";
            label10.Size = new Size(38, 20);
            label10.TabIndex = 16;
            label10.Text = "Cep:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(289, 252);
            label11.Name = "label11";
            label11.RightToLeft = RightToLeft.No;
            label11.Size = new Size(57, 20);
            label11.TabIndex = 17;
            label11.Text = "Estado:";
            // 
            // textBoxBairro
            // 
            textBoxBairro.Location = new Point(360, 211);
            textBoxBairro.Name = "textBoxBairro";
            textBoxBairro.Size = new Size(319, 27);
            textBoxBairro.TabIndex = 20;
            // 
            // textBoxCidade
            // 
            textBoxCidade.Location = new Point(373, 137);
            textBoxCidade.Name = "textBoxCidade";
            textBoxCidade.Size = new Size(307, 27);
            textBoxCidade.TabIndex = 21;
            // 
            // maskedTextBoxCep
            // 
            maskedTextBoxCep.CutCopyMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            maskedTextBoxCep.Location = new Point(362, 173);
            maskedTextBoxCep.Mask = "00000-000";
            maskedTextBoxCep.Name = "maskedTextBoxCep";
            maskedTextBoxCep.Size = new Size(110, 27);
            maskedTextBoxCep.TabIndex = 23;
            maskedTextBoxCep.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(36, 217);
            label12.Name = "label12";
            label12.Size = new Size(44, 20);
            label12.TabIndex = 24;
            label12.Text = "Sexo:";
            // 
            // textBoxRua
            // 
            textBoxRua.Location = new Point(347, 100);
            textBoxRua.Margin = new Padding(3, 4, 3, 4);
            textBoxRua.Name = "textBoxRua";
            textBoxRua.Size = new Size(332, 27);
            textBoxRua.TabIndex = 26;
            // 
            // comboBoxUf
            // 
            comboBoxUf.FormattingEnabled = true;
            comboBoxUf.Location = new Point(347, 248);
            comboBoxUf.Margin = new Padding(3, 4, 3, 4);
            comboBoxUf.Name = "comboBoxUf";
            comboBoxUf.Size = new Size(54, 28);
            comboBoxUf.TabIndex = 28;
            // 
            // maskedTextBoxNumero
            // 
            maskedTextBoxNumero.Location = new Point(421, 61);
            maskedTextBoxNumero.Margin = new Padding(3, 4, 3, 4);
            maskedTextBoxNumero.Name = "maskedTextBoxNumero";
            maskedTextBoxNumero.Size = new Size(259, 27);
            maskedTextBoxNumero.TabIndex = 29;
            maskedTextBoxNumero.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            maskedTextBoxNumero.KeyPress += maskedTextBoxNumero_KeyPress;
            // 
            // comboBoxSexo
            // 
            comboBoxSexo.Location = new Point(78, 213);
            comboBoxSexo.Margin = new Padding(3, 4, 3, 4);
            comboBoxSexo.Name = "comboBoxSexo";
            comboBoxSexo.Size = new Size(123, 28);
            comboBoxSexo.TabIndex = 30;
            // 
            // maskedTextBoxEmail
            // 
            maskedTextBoxEmail.Location = new Point(89, 133);
            maskedTextBoxEmail.Margin = new Padding(3, 4, 3, 4);
            maskedTextBoxEmail.Name = "maskedTextBoxEmail";
            maskedTextBoxEmail.Size = new Size(205, 27);
            maskedTextBoxEmail.TabIndex = 31;
            // 
            // CadastroCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(727, 457);
            Controls.Add(maskedTextBoxEmail);
            Controls.Add(comboBoxSexo);
            Controls.Add(maskedTextBoxNumero);
            Controls.Add(comboBoxUf);
            Controls.Add(textBoxRua);
            Controls.Add(label12);
            Controls.Add(maskedTextBoxCep);
            Controls.Add(textBoxCidade);
            Controls.Add(textBoxBairro);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(maskedTextBoxTelefone);
            Controls.Add(label5);
            Controls.Add(dateTimePickerNasc);
            Controls.Add(textBoxNome);
            Controls.Add(maskedTextBoxCPF);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonCadastrar);
            Name = "CadastroCliente";
            Text = "CadastroCliente";
            Load += CadastroCliente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCadastrar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private MaskedTextBox maskedTextBoxCPF;
        private TextBox textBoxNome;
        private DateTimePicker dateTimePickerNasc;
        private Label label5;
        private MaskedTextBox maskedTextBoxTelefone;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox textBoxBairro;
        private TextBox textBoxCidade;
        private MaskedTextBox maskedTextBoxCep;
        private Label label12;
        private TextBox textBoxRua;
        private ComboBox comboBoxUf;
        private MaskedTextBox maskedTextBoxNumero;
        private ComboBox comboBoxSexo;
        private MaskedTextBox maskedTextBoxEmail;
    }
}