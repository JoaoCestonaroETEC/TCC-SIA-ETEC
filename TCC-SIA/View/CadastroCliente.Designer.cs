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
            textBoxEmail = new TextBox();
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
            textBoxSexo = new TextBox();
            textBoxRua = new TextBox();
            comboBoxUf = new ComboBox();
            maskedTextBoxNumero = new MaskedTextBox();
            SuspendLayout();
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.Location = new Point(25, 248);
            buttonCadastrar.Margin = new Padding(3, 2, 3, 2);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(178, 74);
            buttonCadastrar.TabIndex = 0;
            buttonCadastrar.Text = "Cadastrar";
            buttonCadastrar.UseVisualStyleBackColor = true;
            buttonCadastrar.Click += buttonCadastrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 44);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 1;
            label1.Text = "CPF:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 76);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 2;
            label2.Text = "Nome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 113);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 3;
            label3.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 146);
            label4.Name = "label4";
            label4.Size = new Size(117, 15);
            label4.TabIndex = 4;
            label4.Text = "Data de Nascimento:";
            // 
            // maskedTextBoxCPF
            // 
            maskedTextBoxCPF.Location = new Point(62, 41);
            maskedTextBoxCPF.Margin = new Padding(3, 2, 3, 2);
            maskedTextBoxCPF.Mask = "000000000-00";
            maskedTextBoxCPF.Name = "maskedTextBoxCPF";
            maskedTextBoxCPF.Size = new Size(308, 23);
            maskedTextBoxCPF.TabIndex = 5;
            maskedTextBoxCPF.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(74, 73);
            textBoxNome.Margin = new Padding(3, 2, 3, 2);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(296, 23);
            textBoxNome.TabIndex = 7;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(70, 110);
            textBoxEmail.Margin = new Padding(3, 2, 3, 2);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(300, 23);
            textBoxEmail.TabIndex = 8;
            // 
            // dateTimePickerNasc
            // 
            dateTimePickerNasc.Format = DateTimePickerFormat.Short;
            dateTimePickerNasc.Location = new Point(148, 142);
            dateTimePickerNasc.Margin = new Padding(3, 2, 3, 2);
            dateTimePickerNasc.Name = "dateTimePickerNasc";
            dateTimePickerNasc.Size = new Size(106, 23);
            dateTimePickerNasc.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 177);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 10;
            label5.Text = "Telefone:";
            // 
            // maskedTextBoxTelefone
            // 
            maskedTextBoxTelefone.Location = new Point(91, 175);
            maskedTextBoxTelefone.Margin = new Padding(3, 2, 3, 2);
            maskedTextBoxTelefone.Mask = "(99) 00000-0000";
            maskedTextBoxTelefone.Name = "maskedTextBoxTelefone";
            maskedTextBoxTelefone.Size = new Size(279, 23);
            maskedTextBoxTelefone.TabIndex = 11;
            maskedTextBoxTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(383, 78);
            label6.Name = "label6";
            label6.Size = new Size(96, 15);
            label6.TabIndex = 12;
            label6.Text = "Numero da casa:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(383, 111);
            label7.Name = "label7";
            label7.Size = new Size(30, 15);
            label7.TabIndex = 13;
            label7.Text = "Rua:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(383, 148);
            label8.Name = "label8";
            label8.Size = new Size(41, 15);
            label8.TabIndex = 14;
            label8.Text = "Bairro:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(383, 180);
            label9.Name = "label9";
            label9.Size = new Size(47, 15);
            label9.TabIndex = 15;
            label9.Text = "Cidade:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(720, 44);
            label10.Name = "label10";
            label10.Size = new Size(31, 15);
            label10.TabIndex = 16;
            label10.Text = "Cep:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(722, 76);
            label11.Name = "label11";
            label11.RightToLeft = RightToLeft.No;
            label11.Size = new Size(45, 15);
            label11.TabIndex = 17;
            label11.Text = "Estado:";
            // 
            // textBoxBairro
            // 
            textBoxBairro.Location = new Point(430, 145);
            textBoxBairro.Margin = new Padding(3, 2, 3, 2);
            textBoxBairro.Name = "textBoxBairro";
            textBoxBairro.Size = new Size(280, 23);
            textBoxBairro.TabIndex = 20;
            // 
            // textBoxCidade
            // 
            textBoxCidade.Location = new Point(436, 174);
            textBoxCidade.Margin = new Padding(3, 2, 3, 2);
            textBoxCidade.Name = "textBoxCidade";
            textBoxCidade.Size = new Size(274, 23);
            textBoxCidade.TabIndex = 21;
            // 
            // maskedTextBoxCep
            // 
            maskedTextBoxCep.Location = new Point(755, 41);
            maskedTextBoxCep.Margin = new Padding(3, 2, 3, 2);
            maskedTextBoxCep.Mask = "00000-000";
            maskedTextBoxCep.Name = "maskedTextBoxCep";
            maskedTextBoxCep.Size = new Size(97, 23);
            maskedTextBoxCep.TabIndex = 23;
            maskedTextBoxCep.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(383, 46);
            label12.Name = "label12";
            label12.Size = new Size(35, 15);
            label12.TabIndex = 24;
            label12.Text = "Sexo:";
            // 
            // textBoxSexo
            // 
            textBoxSexo.Location = new Point(424, 41);
            textBoxSexo.Margin = new Padding(3, 2, 3, 2);
            textBoxSexo.Name = "textBoxSexo";
            textBoxSexo.Size = new Size(286, 23);
            textBoxSexo.TabIndex = 25;
            // 
            // textBoxRua
            // 
            textBoxRua.Location = new Point(419, 110);
            textBoxRua.Name = "textBoxRua";
            textBoxRua.Size = new Size(291, 23);
            textBoxRua.TabIndex = 26;
            // 
            // comboBoxUf
            // 
            comboBoxUf.FormattingEnabled = true;
            comboBoxUf.Location = new Point(773, 73);
            comboBoxUf.Name = "comboBoxUf";
            comboBoxUf.Size = new Size(79, 23);
            comboBoxUf.TabIndex = 28;
            // 
            // maskedTextBoxNumero
            // 
            maskedTextBoxNumero.Location = new Point(485, 73);
            maskedTextBoxNumero.Name = "maskedTextBoxNumero";
            maskedTextBoxNumero.Size = new Size(225, 23);
            maskedTextBoxNumero.TabIndex = 29;
            maskedTextBoxNumero.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            maskedTextBoxNumero.KeyPress += maskedTextBoxNumero_KeyPress;
            // 
            // CadastroCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 382);
            Controls.Add(maskedTextBoxNumero);
            Controls.Add(comboBoxUf);
            Controls.Add(textBoxRua);
            Controls.Add(textBoxSexo);
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
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxNome);
            Controls.Add(maskedTextBoxCPF);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonCadastrar);
            Margin = new Padding(3, 2, 3, 2);
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
        private TextBox textBoxEmail;
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
        private TextBox textBoxSexo;
        private TextBox textBoxRua;
        private ComboBox comboBoxUf;
        private MaskedTextBox maskedTextBoxNumero;
    }
}