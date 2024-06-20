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
            maskedTextBoxDate = new MaskedTextBox();
            textBoxNome = new TextBox();
            textBoxEmail = new TextBox();
            SuspendLayout();
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.Location = new Point(331, 296);
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
            label3.Location = new Point(110, 166);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 3;
            label3.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(110, 210);
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
            // maskedTextBoxDate
            // 
            maskedTextBoxDate.Location = new Point(264, 210);
            maskedTextBoxDate.Mask = "00/00/0000";
            maskedTextBoxDate.Name = "maskedTextBoxDate";
            maskedTextBoxDate.Size = new Size(99, 27);
            maskedTextBoxDate.TabIndex = 6;
            maskedTextBoxDate.ValidatingType = typeof(DateTime);
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
            textBoxEmail.Location = new Point(183, 163);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(351, 27);
            textBoxEmail.TabIndex = 8;
            textBoxEmail.Text = "exemplo@gmail.com";
            // 
            // CadastroCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxNome);
            Controls.Add(maskedTextBoxDate);
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
        private MaskedTextBox maskedTextBoxDate;
        private TextBox textBoxNome;
        private TextBox textBoxEmail;
    }
}