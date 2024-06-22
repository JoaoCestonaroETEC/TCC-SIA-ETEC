namespace TCC_SIA.View
{
    partial class Login
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
            label1 = new Label();
            label2 = new Label();
            buttonCadastrar = new Button();
            textBoxNomeOuEmail = new TextBox();
            textBoxSenha = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 23);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome ou E-mail:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(82, 52);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 1;
            label2.Text = "Senha:";
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.Location = new Point(287, 91);
            buttonCadastrar.Margin = new Padding(3, 2, 3, 2);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(82, 22);
            buttonCadastrar.TabIndex = 4;
            buttonCadastrar.Text = "Login";
            buttonCadastrar.UseVisualStyleBackColor = true;
            buttonCadastrar.Click += buttonCadastrar_Click;
            // 
            // textBoxNomeOuEmail
            // 
            textBoxNomeOuEmail.Location = new Point(130, 20);
            textBoxNomeOuEmail.Name = "textBoxNomeOuEmail";
            textBoxNomeOuEmail.PlaceholderText = "Nome ou Email";
            textBoxNomeOuEmail.ReadOnly = true;
            textBoxNomeOuEmail.Size = new Size(239, 23);
            textBoxNomeOuEmail.TabIndex = 5;
            // 
            // textBoxSenha
            // 
            textBoxSenha.Location = new Point(130, 49);
            textBoxSenha.Name = "textBoxSenha";
            textBoxSenha.PasswordChar = '*';
            textBoxSenha.PlaceholderText = "Senha";
            textBoxSenha.ReadOnly = true;
            textBoxSenha.Size = new Size(239, 23);
            textBoxSenha.TabIndex = 6;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(393, 134);
            Controls.Add(textBoxSenha);
            Controls.Add(textBoxNomeOuEmail);
            Controls.Add(buttonCadastrar);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button buttonCadastrar;
        private TextBox textBoxNomeOuEmail;
        private TextBox textBoxSenha;
    }
}