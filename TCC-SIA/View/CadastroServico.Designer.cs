namespace TCC_SIA.View
{
    partial class CadastroServico
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
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            richTextBox1 = new RichTextBox();
            maskedTextBox1 = new MaskedTextBox();
            button1 = new Button();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 57);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 1;
            label2.Text = "Tipo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 86);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 2;
            label3.Text = "Valor:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(298, 28);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 3;
            label4.Text = "Descrição:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(56, 25);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(236, 23);
            textBox1.TabIndex = 4;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(365, 25);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(298, 140);
            richTextBox1.TabIndex = 6;
            richTextBox1.Text = "";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(56, 83);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(236, 23);
            maskedTextBox1.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(12, 112);
            button1.Name = "button1";
            button1.Size = new Size(144, 78);
            button1.TabIndex = 8;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(56, 54);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(236, 23);
            comboBox1.TabIndex = 9;
            // 
            // CadastroServico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(maskedTextBox1);
            Controls.Add(richTextBox1);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CadastroServico";
            Text = "CadastroServico";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private RichTextBox richTextBox1;
        private MaskedTextBox maskedTextBox1;
        private Button button1;
        private ComboBox comboBox1;
    }
}