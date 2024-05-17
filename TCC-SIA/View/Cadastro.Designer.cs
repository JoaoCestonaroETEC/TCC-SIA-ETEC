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
            button1.Location = new Point(257, 148);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 9;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(87, 68);
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(264, 27);
            maskedTextBox2.TabIndex = 8;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(87, 30);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(264, 27);
            maskedTextBox1.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 71);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 6;
            label2.Text = "E-mail:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 33);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 5;
            label1.Text = "Nome:";
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Location = new Point(87, 101);
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(264, 27);
            maskedTextBox3.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 104);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 10;
            label3.Text = "Senha:";
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(maskedTextBox3);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(maskedTextBox2);
            Controls.Add(maskedTextBox1);
            Controls.Add(label2);
            Controls.Add(label1);
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