namespace TCC_SIA.View
{
    partial class CadastroPeca
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
            buttonCadastrar = new Button();
            dateTimePickerGarantia = new DateTimePicker();
            label1 = new Label();
            comboBoxMarca = new ComboBox();
            comboBoxTIpo = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            comboBox1 = new ComboBox();
            label9 = new Label();
            dateTimePicker1 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuant).BeginInit();
            SuspendLayout();
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(123, 113);
            textBoxNome.Margin = new Padding(3, 4, 3, 4);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(238, 27);
            textBoxNome.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 117);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 19;
            label2.Text = "Nome:";
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
            richTextBoxDesc.Size = new Size(331, 363);
            richTextBoxDesc.TabIndex = 24;
            richTextBoxDesc.Text = "";
            // 
            // maskedTextBoxValor
            // 
            maskedTextBoxValor.Location = new Point(123, 152);
            maskedTextBoxValor.Margin = new Padding(3, 4, 3, 4);
            maskedTextBoxValor.Name = "maskedTextBoxValor";
            maskedTextBoxValor.Size = new Size(238, 27);
            maskedTextBoxValor.TabIndex = 25;
            maskedTextBoxValor.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            maskedTextBoxValor.KeyPress += maskedTextBoxValor_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(75, 156);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 26;
            label4.Text = "Valor:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(67, 40);
            label5.Name = "label5";
            label5.Size = new Size(53, 20);
            label5.TabIndex = 27;
            label5.Text = "Marca:";
            // 
            // numericUpDownQuant
            // 
            numericUpDownQuant.Location = new Point(123, 191);
            numericUpDownQuant.Margin = new Padding(3, 4, 3, 4);
            numericUpDownQuant.Name = "numericUpDownQuant";
            numericUpDownQuant.Size = new Size(239, 27);
            numericUpDownQuant.TabIndex = 29;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(34, 193);
            label6.Name = "label6";
            label6.Size = new Size(90, 20);
            label6.TabIndex = 30;
            label6.Text = "Quantidade:";
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.Location = new Point(23, 373);
            buttonCadastrar.Margin = new Padding(3, 4, 3, 4);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(168, 100);
            buttonCadastrar.TabIndex = 31;
            buttonCadastrar.Text = "Cadastrar";
            buttonCadastrar.UseVisualStyleBackColor = true;
            buttonCadastrar.Click += buttonCadastrar_Click;
            // 
            // dateTimePickerGarantia
            // 
            dateTimePickerGarantia.Format = DateTimePickerFormat.Short;
            dateTimePickerGarantia.Location = new Point(123, 228);
            dateTimePickerGarantia.Margin = new Padding(3, 4, 3, 4);
            dateTimePickerGarantia.Name = "dateTimePickerGarantia";
            dateTimePickerGarantia.Size = new Size(238, 27);
            dateTimePickerGarantia.TabIndex = 32;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 236);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 33;
            label1.Text = "Garantia:";
            // 
            // comboBoxMarca
            // 
            comboBoxMarca.FormattingEnabled = true;
            comboBoxMarca.Location = new Point(123, 36);
            comboBoxMarca.Margin = new Padding(3, 4, 3, 4);
            comboBoxMarca.Name = "comboBoxMarca";
            comboBoxMarca.Size = new Size(238, 28);
            comboBoxMarca.TabIndex = 34;
            // 
            // comboBoxTIpo
            // 
            comboBoxTIpo.FormattingEnabled = true;
            comboBoxTIpo.Location = new Point(123, 75);
            comboBoxTIpo.Margin = new Padding(3, 4, 3, 4);
            comboBoxTIpo.Name = "comboBoxTIpo";
            comboBoxTIpo.Size = new Size(238, 28);
            comboBoxTIpo.TabIndex = 36;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(78, 79);
            label7.Name = "label7";
            label7.Size = new Size(42, 20);
            label7.TabIndex = 35;
            label7.Text = "Tipo:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(54, 272);
            label8.Name = "label8";
            label8.Size = new Size(87, 20);
            label8.TabIndex = 37;
            label8.Text = "Fornecedor:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(147, 269);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(214, 28);
            comboBox1.TabIndex = 38;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(10, 309);
            label9.Name = "label9";
            label9.Size = new Size(131, 20);
            label9.TabIndex = 39;
            label9.Text = "Data de Aquisição";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(147, 309);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(215, 27);
            dateTimePicker1.TabIndex = 40;
            // 
            // CadastroPeca
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 486);
            Controls.Add(dateTimePicker1);
            Controls.Add(label9);
            Controls.Add(comboBox1);
            Controls.Add(label8);
            Controls.Add(comboBoxTIpo);
            Controls.Add(label7);
            Controls.Add(comboBoxMarca);
            Controls.Add(label1);
            Controls.Add(dateTimePickerGarantia);
            Controls.Add(buttonCadastrar);
            Controls.Add(label6);
            Controls.Add(numericUpDownQuant);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(maskedTextBoxValor);
            Controls.Add(richTextBoxDesc);
            Controls.Add(label3);
            Controls.Add(textBoxNome);
            Controls.Add(label2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CadastroPeca";
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
        private Button buttonCadastrar;
        private DateTimePicker dateTimePickerGarantia;
        private Label label1;
        private ComboBox comboBoxMarca;
        private ComboBox comboBoxTIpo;
        private Label label7;
        private Label label8;
        private ComboBox comboBox1;
        private Label label9;
        private DateTimePicker dateTimePicker1;
    }
}