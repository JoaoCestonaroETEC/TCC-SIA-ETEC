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
            label10 = new Label();
            numericUpDownUnid = new NumericUpDown();
            dateTimePickerAquis = new DateTimePicker();
            label9 = new Label();
            comboBoxFornecedor = new ComboBox();
            label8 = new Label();
            comboBoxTIpo = new ComboBox();
            label7 = new Label();
            comboBoxMarca = new ComboBox();
            label1 = new Label();
            dateTimePickerGarantia = new DateTimePicker();
            buttonCadastrar = new Button();
            label6 = new Label();
            numericUpDownQuant = new NumericUpDown();
            label5 = new Label();
            label4 = new Label();
            maskedTextBoxValor = new MaskedTextBox();
            richTextBoxDesc = new RichTextBox();
            label3 = new Label();
            textBoxNome = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownUnid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuant).BeginInit();
            SuspendLayout();
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(54, 138);
            label10.Name = "label10";
            label10.Size = new Size(54, 15);
            label10.TabIndex = 84;
            label10.Text = "Unidade:";
            // 
            // numericUpDownUnid
            // 
            numericUpDownUnid.Location = new Point(119, 136);
            numericUpDownUnid.Name = "numericUpDownUnid";
            numericUpDownUnid.Size = new Size(209, 23);
            numericUpDownUnid.TabIndex = 83;
            // 
            // dateTimePickerAquis
            // 
            dateTimePickerAquis.Format = DateTimePickerFormat.Short;
            dateTimePickerAquis.Location = new Point(136, 244);
            dateTimePickerAquis.Margin = new Padding(3, 2, 3, 2);
            dateTimePickerAquis.Name = "dateTimePickerAquis";
            dateTimePickerAquis.Size = new Size(189, 23);
            dateTimePickerAquis.TabIndex = 82;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(17, 244);
            label9.Name = "label9";
            label9.Size = new Size(102, 15);
            label9.TabIndex = 81;
            label9.Text = "Data de Aquisição";
            // 
            // comboBoxFornecedor
            // 
            comboBoxFornecedor.FormattingEnabled = true;
            comboBoxFornecedor.Location = new Point(136, 214);
            comboBoxFornecedor.Margin = new Padding(3, 2, 3, 2);
            comboBoxFornecedor.Name = "comboBoxFornecedor";
            comboBoxFornecedor.Size = new Size(188, 23);
            comboBoxFornecedor.TabIndex = 80;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(55, 217);
            label8.Name = "label8";
            label8.Size = new Size(70, 15);
            label8.TabIndex = 79;
            label8.Text = "Fornecedor:";
            // 
            // comboBoxTIpo
            // 
            comboBoxTIpo.FormattingEnabled = true;
            comboBoxTIpo.Location = new Point(120, 52);
            comboBoxTIpo.Name = "comboBoxTIpo";
            comboBoxTIpo.Size = new Size(209, 23);
            comboBoxTIpo.TabIndex = 78;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(80, 56);
            label7.Name = "label7";
            label7.Size = new Size(33, 15);
            label7.TabIndex = 77;
            label7.Text = "Tipo:";
            // 
            // comboBoxMarca
            // 
            comboBoxMarca.FormattingEnabled = true;
            comboBoxMarca.Location = new Point(120, 23);
            comboBoxMarca.Name = "comboBoxMarca";
            comboBoxMarca.Size = new Size(209, 23);
            comboBoxMarca.TabIndex = 76;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 190);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 75;
            label1.Text = "Garantia:";
            // 
            // dateTimePickerGarantia
            // 
            dateTimePickerGarantia.Format = DateTimePickerFormat.Short;
            dateTimePickerGarantia.Location = new Point(120, 189);
            dateTimePickerGarantia.Name = "dateTimePickerGarantia";
            dateTimePickerGarantia.Size = new Size(209, 23);
            dateTimePickerGarantia.TabIndex = 74;
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.Location = new Point(17, 276);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(130, 58);
            buttonCadastrar.TabIndex = 73;
            buttonCadastrar.Text = "Cadastrar";
            buttonCadastrar.UseVisualStyleBackColor = true;
            buttonCadastrar.Click += buttonCadastrar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(42, 164);
            label6.Name = "label6";
            label6.Size = new Size(72, 15);
            label6.TabIndex = 72;
            label6.Text = "Quantidade:";
            // 
            // numericUpDownQuant
            // 
            numericUpDownQuant.Location = new Point(120, 163);
            numericUpDownQuant.Name = "numericUpDownQuant";
            numericUpDownQuant.Size = new Size(209, 23);
            numericUpDownQuant.TabIndex = 71;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(71, 26);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 70;
            label5.Text = "Marca:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(78, 113);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 69;
            label4.Text = "Valor:";
            // 
            // maskedTextBoxValor
            // 
            maskedTextBoxValor.Location = new Point(120, 110);
            maskedTextBoxValor.Name = "maskedTextBoxValor";
            maskedTextBoxValor.Size = new Size(209, 23);
            maskedTextBoxValor.TabIndex = 68;
            maskedTextBoxValor.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // richTextBoxDesc
            // 
            richTextBoxDesc.Location = new Point(400, 23);
            richTextBoxDesc.Name = "richTextBoxDesc";
            richTextBoxDesc.Size = new Size(290, 312);
            richTextBoxDesc.TabIndex = 67;
            richTextBoxDesc.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(333, 26);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 66;
            label3.Text = "Descrição:";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(120, 81);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(209, 23);
            textBoxNome.TabIndex = 65;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 84);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 64;
            label2.Text = "Nome:";
            // 
            // CadastroPeca
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(718, 364);
            Controls.Add(label10);
            Controls.Add(numericUpDownUnid);
            Controls.Add(dateTimePickerAquis);
            Controls.Add(label9);
            Controls.Add(comboBoxFornecedor);
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
            Name = "CadastroPeca";
            Text = "CadastroPeça";
            Load += CadastroPeça_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownUnid).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuant).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label10;
        private NumericUpDown numericUpDownUnid;
        private DateTimePicker dateTimePickerAquis;
        private Label label9;
        private ComboBox comboBoxFornecedor;
        private Label label8;
        private ComboBox comboBoxTIpo;
        private Label label7;
        private ComboBox comboBoxMarca;
        private Label label1;
        private DateTimePicker dateTimePickerGarantia;
        private Button buttonCadastrar;
        private Label label6;
        private NumericUpDown numericUpDownQuant;
        private Label label5;
        private Label label4;
        private MaskedTextBox maskedTextBoxValor;
        private RichTextBox richTextBoxDesc;
        private Label label3;
        private TextBox textBoxNome;
        private Label label2;
    }
}