namespace TCC_SIA.View
{
    partial class Cadastro
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
            maskedTextBoxEmail = new MaskedTextBox();
            label1 = new Label();
            maskedTextBoxSenha = new MaskedTextBox();
            label3 = new Label();
            maskedTextBoxCnpj = new MaskedTextBox();
            label4 = new Label();
            label2 = new Label();
            maskedTextBoxTelefone = new MaskedTextBox();
            label5 = new Label();
            textBoxNome = new TextBox();
            SuspendLayout();
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.Location = new Point(233, 168);
            buttonCadastrar.Margin = new Padding(3, 2, 3, 2);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(82, 22);
            buttonCadastrar.TabIndex = 9;
            buttonCadastrar.Text = "Cadastrar";
            buttonCadastrar.UseVisualStyleBackColor = true;
            buttonCadastrar.Click += Cadastar_Cliente;
            // 
            // maskedTextBoxEmail
            // 
            maskedTextBoxEmail.Location = new Point(83, 63);
            maskedTextBoxEmail.Margin = new Padding(3, 2, 3, 2);
            maskedTextBoxEmail.Name = "maskedTextBoxEmail";
            maskedTextBoxEmail.Size = new Size(232, 23);
            maskedTextBoxEmail.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 66);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 5;
            label1.Text = "Email:";
            // 
            // maskedTextBoxSenha
            // 
            maskedTextBoxSenha.Location = new Point(83, 90);
            maskedTextBoxSenha.Margin = new Padding(3, 2, 3, 2);
            maskedTextBoxSenha.Name = "maskedTextBoxSenha";
            maskedTextBoxSenha.PasswordChar = '*';
            maskedTextBoxSenha.Size = new Size(232, 23);
            maskedTextBoxSenha.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 93);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 10;
            label3.Text = "Senha:";
            // 
            // maskedTextBoxCnpj
            // 
            maskedTextBoxCnpj.Location = new Point(83, 9);
            maskedTextBoxCnpj.Margin = new Padding(3, 2, 3, 2);
            maskedTextBoxCnpj.Mask = "00000000000000";
            maskedTextBoxCnpj.Name = "maskedTextBoxCnpj";
            maskedTextBoxCnpj.Size = new Size(232, 23);
            maskedTextBoxCnpj.TabIndex = 13;
            maskedTextBoxCnpj.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 12);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 12;
            label4.Text = "Cnpj:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 39);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 14;
            label2.Text = "Nome:";
            // 
            // maskedTextBoxTelefone
            // 
            maskedTextBoxTelefone.Location = new Point(83, 117);
            maskedTextBoxTelefone.Margin = new Padding(3, 2, 3, 2);
            maskedTextBoxTelefone.Mask = "(999) 000-0000";
            maskedTextBoxTelefone.Name = "maskedTextBoxTelefone";
            maskedTextBoxTelefone.Size = new Size(232, 23);
            maskedTextBoxTelefone.TabIndex = 17;
            maskedTextBoxTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 120);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 16;
            label5.Text = "Telefone:";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(83, 36);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(232, 23);
            textBoxNome.TabIndex = 18;
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(343, 247);
            Controls.Add(textBoxNome);
            Controls.Add(maskedTextBoxTelefone);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(maskedTextBoxCnpj);
            Controls.Add(label4);
            Controls.Add(maskedTextBoxSenha);
            Controls.Add(label3);
            Controls.Add(buttonCadastrar);
            Controls.Add(maskedTextBoxEmail);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Cadastro";
            Text = "Cadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCadastrar;
        private MaskedTextBox maskedTextBoxEmail;
        private Label label1;
        private MaskedTextBox maskedTextBoxSenha;
        private Label label3;
        private MaskedTextBox maskedTextBoxCnpj;
        private Label label4;
        private Label label2;
        private MaskedTextBox maskedTextBoxTelefone;
        private Label label5;
        private TextBox textBoxNome;
    }
}