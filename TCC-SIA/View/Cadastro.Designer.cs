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
            maskedTextBoxNome = new MaskedTextBox();
            label2 = new Label();
            label1 = new Label();
            maskedTextBoxSenha = new MaskedTextBox();
            label3 = new Label();
            maskedTextBoxCpf = new MaskedTextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.Location = new Point(265, 164);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(94, 29);
            buttonCadastrar.TabIndex = 9;
            buttonCadastrar.Text = "Cadastrar";
            buttonCadastrar.UseVisualStyleBackColor = true;
            buttonCadastrar.Click += Cadastar_Cliente;
            // 
            // maskedTextBoxEmail
            // 
            maskedTextBoxEmail.Location = new Point(95, 84);
            maskedTextBoxEmail.Name = "maskedTextBoxEmail";
            maskedTextBoxEmail.Size = new Size(265, 27);
            maskedTextBoxEmail.TabIndex = 8;
            // 
            // maskedTextBoxNome
            // 
            maskedTextBoxNome.Location = new Point(95, 45);
            maskedTextBoxNome.Name = "maskedTextBoxNome";
            maskedTextBoxNome.Size = new Size(265, 27);
            maskedTextBoxNome.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 87);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 6;
            label2.Text = "E-mail:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 49);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 5;
            label1.Text = "Nome:";
            // 
            // maskedTextBoxSenha
            // 
            maskedTextBoxSenha.Location = new Point(95, 117);
            maskedTextBoxSenha.Name = "maskedTextBoxSenha";
            maskedTextBoxSenha.Size = new Size(265, 27);
            maskedTextBoxSenha.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 120);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 10;
            label3.Text = "Senha:";
            // 
            // maskedTextBoxCpf
            // 
            maskedTextBoxCpf.Location = new Point(95, 12);
            maskedTextBoxCpf.Mask = "000.000.000-00";
            maskedTextBoxCpf.Name = "maskedTextBoxCpf";
            maskedTextBoxCpf.Size = new Size(265, 27);
            maskedTextBoxCpf.TabIndex = 13;
            maskedTextBoxCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 15);
            label4.Name = "label4";
            label4.Size = new Size(35, 20);
            label4.TabIndex = 12;
            label4.Text = "Cpf:";
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(392, 201);
            Controls.Add(maskedTextBoxCpf);
            Controls.Add(label4);
            Controls.Add(maskedTextBoxSenha);
            Controls.Add(label3);
            Controls.Add(buttonCadastrar);
            Controls.Add(maskedTextBoxEmail);
            Controls.Add(maskedTextBoxNome);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Cadastro";
            Text = "Cadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCadastrar;
        private MaskedTextBox maskedTextBoxEmail;
        private MaskedTextBox maskedTextBoxNome;
        private Label label2;
        private Label label1;
        private MaskedTextBox maskedTextBoxSenha;
        private Label label3;
        private MaskedTextBox maskedTextBoxCpf;
        private Label label4;
    }
}