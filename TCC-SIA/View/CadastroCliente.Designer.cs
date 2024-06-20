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
            textBoxNumero = new TextBox();
            textBoxRua = new TextBox();
            textBoxBairro = new TextBox();
            textBoxCidade = new TextBox();
            textBoxUF = new TextBox();
            maskedTextBoxCep = new MaskedTextBox();
            label12 = new Label();
            textBoxSexo = new TextBox();
            SuspendLayout();
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.Location = new Point(110, 339);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(203, 98);
            buttonCadastrar.TabIndex = 0;
            buttonCadastrar.Text = "Cadastrar";
            buttonCadastrar.UseVisualStyleBackColor = true;
            buttonCadastrar.Click += buttonCadastrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(110, 67);
            label1.Name = "label1";
            label1.Size = new Size(36, 20);
            label1.TabIndex = 1;
            label1.Text = "CPF:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(110, 110);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 2;
            label2.Text = "Nome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(110, 159);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 3;
            label3.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(110, 203);
            label4.Name = "label4";
            label4.Size = new Size(148, 20);
            label4.TabIndex = 4;
            label4.Text = "Data de Nascimento:";
            // 
            // maskedTextBoxCPF
            // 
            maskedTextBoxCPF.Location = new Point(183, 64);
            maskedTextBoxCPF.Mask = "000000000/00";
            maskedTextBoxCPF.Name = "maskedTextBoxCPF";
            maskedTextBoxCPF.Size = new Size(351, 27);
            maskedTextBoxCPF.TabIndex = 5;
            maskedTextBoxCPF.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(183, 107);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(351, 27);
            textBoxNome.TabIndex = 7;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(183, 156);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(351, 27);
            textBoxEmail.TabIndex = 8;
            // 
            // dateTimePickerNasc
            // 
            dateTimePickerNasc.Format = DateTimePickerFormat.Short;
            dateTimePickerNasc.Location = new Point(264, 198);
            dateTimePickerNasc.Name = "dateTimePickerNasc";
            dateTimePickerNasc.Size = new Size(120, 27);
            dateTimePickerNasc.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(110, 244);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 10;
            label5.Text = "Telefone:";
            // 
            // maskedTextBoxTelefone
            // 
            maskedTextBoxTelefone.Location = new Point(185, 241);
            maskedTextBoxTelefone.Mask = "(99) 00000-0000";
            maskedTextBoxTelefone.Name = "maskedTextBoxTelefone";
            maskedTextBoxTelefone.Size = new Size(351, 27);
            maskedTextBoxTelefone.TabIndex = 11;
            maskedTextBoxTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(669, 110);
            label6.Name = "label6";
            label6.Size = new Size(120, 20);
            label6.TabIndex = 12;
            label6.Text = "Numero da casa:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(669, 153);
            label7.Name = "label7";
            label7.Size = new Size(37, 20);
            label7.TabIndex = 13;
            label7.Text = "Rua:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(669, 202);
            label8.Name = "label8";
            label8.Size = new Size(52, 20);
            label8.TabIndex = 14;
            label8.Text = "Bairro:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(669, 246);
            label9.Name = "label9";
            label9.Size = new Size(59, 20);
            label9.TabIndex = 15;
            label9.Text = "Cidade:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(1138, 67);
            label10.Name = "label10";
            label10.Size = new Size(38, 20);
            label10.TabIndex = 16;
            label10.Text = "Cep:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(1140, 110);
            label11.Name = "label11";
            label11.RightToLeft = RightToLeft.No;
            label11.Size = new Size(57, 20);
            label11.TabIndex = 17;
            label11.Text = "Estado:";
            // 
            // textBoxNumero
            // 
            textBoxNumero.Location = new Point(795, 107);
            textBoxNumero.Name = "textBoxNumero";
            textBoxNumero.Size = new Size(257, 27);
            textBoxNumero.TabIndex = 18;
            // 
            // textBoxRua
            // 
            textBoxRua.Location = new Point(713, 150);
            textBoxRua.Name = "textBoxRua";
            textBoxRua.Size = new Size(339, 27);
            textBoxRua.TabIndex = 19;
            // 
            // textBoxBairro
            // 
            textBoxBairro.Location = new Point(727, 199);
            textBoxBairro.Name = "textBoxBairro";
            textBoxBairro.Size = new Size(325, 27);
            textBoxBairro.TabIndex = 20;
            // 
            // textBoxCidade
            // 
            textBoxCidade.Location = new Point(734, 243);
            textBoxCidade.Name = "textBoxCidade";
            textBoxCidade.Size = new Size(318, 27);
            textBoxCidade.TabIndex = 21;
            // 
            // textBoxUF
            // 
            textBoxUF.Location = new Point(1203, 107);
            textBoxUF.Name = "textBoxUF";
            textBoxUF.Size = new Size(247, 27);
            textBoxUF.TabIndex = 22;
            // 
            // maskedTextBoxCep
            // 
            maskedTextBoxCep.Location = new Point(1182, 64);
            maskedTextBoxCep.Mask = "00000-000";
            maskedTextBoxCep.Name = "maskedTextBoxCep";
            maskedTextBoxCep.Size = new Size(268, 27);
            maskedTextBoxCep.TabIndex = 23;
            maskedTextBoxCep.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(669, 67);
            label12.Name = "label12";
            label12.Size = new Size(44, 20);
            label12.TabIndex = 24;
            label12.Text = "Sexo:";
            // 
            // textBoxSexo
            // 
            textBoxSexo.Location = new Point(719, 64);
            textBoxSexo.Name = "textBoxSexo";
            textBoxSexo.Size = new Size(333, 27);
            textBoxSexo.TabIndex = 25;
            // 
            // CadastroCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1503, 509);
            Controls.Add(textBoxSexo);
            Controls.Add(label12);
            Controls.Add(maskedTextBoxCep);
            Controls.Add(textBoxUF);
            Controls.Add(textBoxCidade);
            Controls.Add(textBoxBairro);
            Controls.Add(textBoxRua);
            Controls.Add(textBoxNumero);
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
            Name = "CadastroCliente";
            Text = "CadastroCliente";
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
        private TextBox textBoxNumero;
        private TextBox textBoxRua;
        private TextBox textBoxBairro;
        private TextBox textBoxCidade;
        private TextBox textBoxUF;
        private MaskedTextBox maskedTextBoxCep;
        private Label label12;
        private TextBox textBoxSexo;
    }
}