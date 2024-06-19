namespace TCC_SIA.View
{
    partial class CadastroPeça
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
            textBoxNome = new TextBox();
            label2 = new Label();
            label1 = new Label();
            comboBoxTipo = new ComboBox();
            label3 = new Label();
            richTextBoxDesc = new RichTextBox();
            maskedTextBoxValor = new MaskedTextBox();
            label4 = new Label();
            textBoxMarca = new TextBox();
            label5 = new Label();
            numericUpDownQuant = new NumericUpDown();
            label6 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuant).BeginInit();
            SuspendLayout();
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(98, 27);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(209, 23);
            textBoxNome.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 30);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 19;
            label2.Text = "Nome:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 64);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 21;
            label1.Text = "Tipo:";
            // 
            // comboBoxTipo
            // 
            comboBoxTipo.FormattingEnabled = true;
            comboBoxTipo.Location = new Point(98, 61);
            comboBoxTipo.Name = "comboBoxTipo";
            comboBoxTipo.Size = new Size(209, 23);
            comboBoxTipo.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(321, 30);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 23;
            label3.Text = "Descrição:";
            // 
            // richTextBoxDesc
            // 
            richTextBoxDesc.Location = new Point(388, 27);
            richTextBoxDesc.Name = "richTextBoxDesc";
            richTextBoxDesc.Size = new Size(375, 146);
            richTextBoxDesc.TabIndex = 24;
            richTextBoxDesc.Text = "";
            // 
            // maskedTextBoxValor
            // 
            maskedTextBoxValor.Location = new Point(98, 93);
            maskedTextBoxValor.Mask = "0000.00";
            maskedTextBoxValor.Name = "maskedTextBoxValor";
            maskedTextBoxValor.Size = new Size(209, 23);
            maskedTextBoxValor.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(56, 96);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 26;
            label4.Text = "Valor:";
            // 
            // textBoxMarca
            // 
            textBoxMarca.Location = new Point(98, 121);
            textBoxMarca.Name = "textBoxMarca";
            textBoxMarca.Size = new Size(209, 23);
            textBoxMarca.TabIndex = 28;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(49, 124);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 27;
            label5.Text = "Marca:";
            // 
            // numericUpDownQuant
            // 
            numericUpDownQuant.Location = new Point(98, 150);
            numericUpDownQuant.Name = "numericUpDownQuant";
            numericUpDownQuant.Size = new Size(209, 23);
            numericUpDownQuant.TabIndex = 29;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 152);
            label6.Name = "label6";
            label6.Size = new Size(72, 15);
            label6.TabIndex = 30;
            label6.Text = "Quantidade:";
            // 
            // button1
            // 
            button1.Location = new Point(201, 197);
            button1.Name = "button1";
            button1.Size = new Size(106, 75);
            button1.TabIndex = 31;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // CadastroPeça
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 312);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(numericUpDownQuant);
            Controls.Add(textBoxMarca);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(maskedTextBoxValor);
            Controls.Add(richTextBoxDesc);
            Controls.Add(label3);
            Controls.Add(comboBoxTipo);
            Controls.Add(label1);
            Controls.Add(textBoxNome);
            Controls.Add(label2);
            Name = "CadastroPeça";
            Text = "CadastroPeça";
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuant).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNome;
        private Label label2;
        private Label label1;
        private ComboBox comboBoxTipo;
        private Label label3;
        private RichTextBox richTextBoxDesc;
        private MaskedTextBox maskedTextBoxValor;
        private Label label4;
        private TextBox textBoxMarca;
        private Label label5;
        private NumericUpDown numericUpDownQuant;
        private Label label6;
        private Button button1;
    }
}