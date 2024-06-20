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
            textBoxNome.Location = new Point(112, 36);
            textBoxNome.Margin = new Padding(3, 4, 3, 4);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(238, 27);
            textBoxNome.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 40);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 19;
            label2.Text = "Nome:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 85);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 21;
            label1.Text = "Tipo:";
            // 
            // comboBoxTipo
            // 
            comboBoxTipo.FormattingEnabled = true;
            comboBoxTipo.Location = new Point(112, 81);
            comboBoxTipo.Margin = new Padding(3, 4, 3, 4);
            comboBoxTipo.Name = "comboBoxTipo";
            comboBoxTipo.Size = new Size(238, 28);
            comboBoxTipo.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(367, 40);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 23;
            label3.Text = "Descrição:";
            // 
            // richTextBoxDesc
            // 
            richTextBoxDesc.Location = new Point(443, 36);
            richTextBoxDesc.Margin = new Padding(3, 4, 3, 4);
            richTextBoxDesc.Name = "richTextBoxDesc";
            richTextBoxDesc.Size = new Size(428, 193);
            richTextBoxDesc.TabIndex = 24;
            richTextBoxDesc.Text = "";
            // 
            // maskedTextBoxValor
            // 
            maskedTextBoxValor.Location = new Point(112, 124);
            maskedTextBoxValor.Margin = new Padding(3, 4, 3, 4);
            maskedTextBoxValor.Mask = "0000.00";
            maskedTextBoxValor.Name = "maskedTextBoxValor";
            maskedTextBoxValor.Size = new Size(238, 27);
            maskedTextBoxValor.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(64, 128);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 26;
            label4.Text = "Valor:";
            // 
            // textBoxMarca
            // 
            textBoxMarca.Location = new Point(112, 161);
            textBoxMarca.Margin = new Padding(3, 4, 3, 4);
            textBoxMarca.Name = "textBoxMarca";
            textBoxMarca.Size = new Size(238, 27);
            textBoxMarca.TabIndex = 28;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(56, 165);
            label5.Name = "label5";
            label5.Size = new Size(53, 20);
            label5.TabIndex = 27;
            label5.Text = "Marca:";
            // 
            // numericUpDownQuant
            // 
            numericUpDownQuant.Location = new Point(112, 200);
            numericUpDownQuant.Margin = new Padding(3, 4, 3, 4);
            numericUpDownQuant.Name = "numericUpDownQuant";
            numericUpDownQuant.Size = new Size(239, 27);
            numericUpDownQuant.TabIndex = 29;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 203);
            label6.Name = "label6";
            label6.Size = new Size(90, 20);
            label6.TabIndex = 30;
            label6.Text = "Quantidade:";
            // 
            // button1
            // 
            button1.Location = new Point(230, 263);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(121, 100);
            button1.TabIndex = 31;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // CadastroPeça
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 416);
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
            Margin = new Padding(3, 4, 3, 4);
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