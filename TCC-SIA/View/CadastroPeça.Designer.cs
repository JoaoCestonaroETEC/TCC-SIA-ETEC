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
            label3 = new Label();
            richTextBoxDesc = new RichTextBox();
            maskedTextBoxValor = new MaskedTextBox();
            label4 = new Label();
            label5 = new Label();
            numericUpDownQuant = new NumericUpDown();
            label6 = new Label();
            button1 = new Button();
            dateTimePickerPeca = new DateTimePicker();
            label1 = new Label();
            comboBoxMarca = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuant).BeginInit();
            SuspendLayout();
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(98, 32);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(209, 23);
            textBoxNome.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 35);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 19;
            label2.Text = "Nome:";
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
            maskedTextBoxValor.Location = new Point(98, 64);
            maskedTextBoxValor.Name = "maskedTextBoxValor";
            maskedTextBoxValor.Size = new Size(209, 23);
            maskedTextBoxValor.TabIndex = 25;
            maskedTextBoxValor.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            maskedTextBoxValor.KeyPress += maskedTextBoxValor_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(56, 64);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 26;
            label4.Text = "Valor:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(49, 92);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 27;
            label5.Text = "Marca:";
            // 
            // numericUpDownQuant
            // 
            numericUpDownQuant.Location = new Point(98, 122);
            numericUpDownQuant.Name = "numericUpDownQuant";
            numericUpDownQuant.Size = new Size(209, 23);
            numericUpDownQuant.TabIndex = 29;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 121);
            label6.Name = "label6";
            label6.Size = new Size(72, 15);
            label6.TabIndex = 30;
            label6.Text = "Quantidade:";
            // 
            // button1
            // 
            button1.Location = new Point(201, 199);
            button1.Name = "button1";
            button1.Size = new Size(106, 75);
            button1.TabIndex = 31;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dateTimePickerPeca
            // 
            dateTimePickerPeca.Format = DateTimePickerFormat.Short;
            dateTimePickerPeca.Location = new Point(98, 150);
            dateTimePickerPeca.Name = "dateTimePickerPeca";
            dateTimePickerPeca.Size = new Size(200, 23);
            dateTimePickerPeca.TabIndex = 32;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 148);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 33;
            label1.Text = "Garantia:";
            // 
            // comboBoxMarca
            // 
            comboBoxMarca.FormattingEnabled = true;
            comboBoxMarca.Location = new Point(98, 93);
            comboBoxMarca.Name = "comboBoxMarca";
            comboBoxMarca.Size = new Size(209, 23);
            comboBoxMarca.TabIndex = 34;
            // 
            // CadastroPeça
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 312);
            Controls.Add(comboBoxMarca);
            Controls.Add(label1);
            Controls.Add(dateTimePickerPeca);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(numericUpDownQuant);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(maskedTextBoxValor);
            Controls.Add(richTextBoxDesc);
            Controls.Add(label3);
            Controls.Add(textBoxNome);
            Controls.Add(label2);
            Name = "CadastroPeça";
            Text = "CadastroPeça";
            Load += CadastroPeça_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuant).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNome;
        private Label label2;
        private Label label3;
        private RichTextBox richTextBoxDesc;
        private MaskedTextBox maskedTextBoxValor;
        private Label label4;
        private Label label5;
        private NumericUpDown numericUpDownQuant;
        private Label label6;
        private Button button1;
        private DateTimePicker dateTimePickerPeca;
        private Label label1;
        private ComboBox comboBoxMarca;
    }
}