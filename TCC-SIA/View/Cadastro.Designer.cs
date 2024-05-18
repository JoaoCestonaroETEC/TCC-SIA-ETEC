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
            button1 = new Button();
            maskedTextBox2 = new MaskedTextBox();
            maskedTextBox1 = new MaskedTextBox();
            label2 = new Label();
            label1 = new Label();
            maskedTextBox3 = new MaskedTextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(225, 111);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 9;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(76, 51);
            maskedTextBox2.Margin = new Padding(3, 2, 3, 2);
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(232, 23);
            maskedTextBox2.TabIndex = 8;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(76, 22);
            maskedTextBox1.Margin = new Padding(3, 2, 3, 2);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(232, 23);
            maskedTextBox1.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 53);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 6;
            label2.Text = "E-mail:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 25);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 5;
            label1.Text = "Nome:";
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Location = new Point(76, 76);
            maskedTextBox3.Margin = new Padding(3, 2, 3, 2);
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(232, 23);
            maskedTextBox3.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 78);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 10;
            label3.Text = "Senha:";
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            ClientSize = new Size(343, 151);
            Controls.Add(maskedTextBox3);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(maskedTextBox2);
            Controls.Add(maskedTextBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Cadastro";
            Text = "Cadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private MaskedTextBox maskedTextBox2;
        private MaskedTextBox maskedTextBox1;
        private Label label2;
        private Label label1;
        private MaskedTextBox maskedTextBox3;
        private Label label3;
    }
}