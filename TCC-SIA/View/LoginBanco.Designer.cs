namespace TCC_SIA.View
{
    partial class LoginBanco
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
            maskedTextBoxServer = new MaskedTextBox();
            label2 = new Label();
            maskedTextBoxPort = new MaskedTextBox();
            label3 = new Label();
            maskedTextBoxUser = new MaskedTextBox();
            maskedTextBoxPassword = new MaskedTextBox();
            label4 = new Label();
            npgsqlCommandBuilder1 = new Npgsql.NpgsqlCommandBuilder();
            maskedTextBoxDB = new MaskedTextBox();
            label5 = new Label();
            buttonEntrar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 22);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "Server:";
            // 
            // maskedTextBoxServer
            // 
            maskedTextBoxServer.Enabled = false;
            maskedTextBoxServer.Location = new Point(74, 19);
            maskedTextBoxServer.Name = "maskedTextBoxServer";
            maskedTextBoxServer.Size = new Size(170, 23);
            maskedTextBoxServer.TabIndex = 1;
            maskedTextBoxServer.Text = "127.0.0.1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 51);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 2;
            label2.Text = "Porta:";
            // 
            // maskedTextBoxPort
            // 
            maskedTextBoxPort.Location = new Point(74, 48);
            maskedTextBoxPort.Name = "maskedTextBoxPort";
            maskedTextBoxPort.Size = new Size(170, 23);
            maskedTextBoxPort.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 79);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 4;
            label3.Text = "Usuário:";
            // 
            // maskedTextBoxUser
            // 
            maskedTextBoxUser.Enabled = false;
            maskedTextBoxUser.Location = new Point(74, 79);
            maskedTextBoxUser.Name = "maskedTextBoxUser";
            maskedTextBoxUser.Size = new Size(170, 23);
            maskedTextBoxUser.TabIndex = 5;
            maskedTextBoxUser.Text = "postgres";
            // 
            // maskedTextBoxPassword
            // 
            maskedTextBoxPassword.Location = new Point(74, 108);
            maskedTextBoxPassword.Name = "maskedTextBoxPassword";
            maskedTextBoxPassword.PasswordChar = '*';
            maskedTextBoxPassword.Size = new Size(170, 23);
            maskedTextBoxPassword.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 111);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 6;
            label4.Text = "Senha:";
            // 
            // npgsqlCommandBuilder1
            // 
            npgsqlCommandBuilder1.QuotePrefix = "\"";
            npgsqlCommandBuilder1.QuoteSuffix = "\"";
            // 
            // maskedTextBoxDB
            // 
            maskedTextBoxDB.Location = new Point(74, 137);
            maskedTextBoxDB.Name = "maskedTextBoxDB";
            maskedTextBoxDB.Size = new Size(170, 23);
            maskedTextBoxDB.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 140);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 8;
            label5.Text = "Banco:";
            // 
            // buttonEntrar
            // 
            buttonEntrar.Location = new Point(26, 166);
            buttonEntrar.Name = "buttonEntrar";
            buttonEntrar.Size = new Size(116, 64);
            buttonEntrar.TabIndex = 10;
            buttonEntrar.Text = "Entrar";
            buttonEntrar.UseVisualStyleBackColor = true;
            buttonEntrar.Click += buttonEntrar_Click;
            // 
            // LoginBanco
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(323, 276);
            Controls.Add(buttonEntrar);
            Controls.Add(maskedTextBoxDB);
            Controls.Add(label5);
            Controls.Add(maskedTextBoxPassword);
            Controls.Add(label4);
            Controls.Add(maskedTextBoxUser);
            Controls.Add(label3);
            Controls.Add(maskedTextBoxPort);
            Controls.Add(label2);
            Controls.Add(maskedTextBoxServer);
            Controls.Add(label1);
            Name = "LoginBanco";
            Text = "LoginBanco";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MaskedTextBox maskedTextBoxServer;
        private Label label2;
        private MaskedTextBox maskedTextBoxPort;
        private Label label3;
        private MaskedTextBox maskedTextBoxUser;
        private MaskedTextBox maskedTextBoxPassword;
        private Label label4;
        private Npgsql.NpgsqlCommandBuilder npgsqlCommandBuilder1;
        private MaskedTextBox maskedTextBoxDB;
        private Label label5;
        private Button buttonEntrar;
    }
}