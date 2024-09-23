﻿namespace TCC_SIA.View
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
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownUnid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuant).BeginInit();
            SuspendLayout();
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(62, 184);
            label10.Name = "label10";
            label10.Size = new Size(68, 20);
            label10.TabIndex = 84;
            label10.Text = "Unidade:";
            // 
            // numericUpDownUnid
            // 
            numericUpDownUnid.Location = new Point(136, 181);
            numericUpDownUnid.Margin = new Padding(3, 4, 3, 4);
            numericUpDownUnid.Maximum = new decimal(new int[] { 1215752192, 23, 0, 0 });
            numericUpDownUnid.Name = "numericUpDownUnid";
            numericUpDownUnid.Size = new Size(239, 27);
            numericUpDownUnid.TabIndex = 83;
            numericUpDownUnid.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownUnid.ValueChanged += numericUpDownUnid_ValueChanged;
            numericUpDownUnid.Validating += numericUpDownUnid_Validating;
            // 
            // dateTimePickerAquis
            // 
            dateTimePickerAquis.Format = DateTimePickerFormat.Short;
            dateTimePickerAquis.Location = new Point(155, 325);
            dateTimePickerAquis.Name = "dateTimePickerAquis";
            dateTimePickerAquis.Size = new Size(215, 27);
            dateTimePickerAquis.TabIndex = 82;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(19, 325);
            label9.Name = "label9";
            label9.Size = new Size(131, 20);
            label9.TabIndex = 81;
            label9.Text = "Data de Aquisição";
            // 
            // comboBoxFornecedor
            // 
            comboBoxFornecedor.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxFornecedor.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxFornecedor.FormattingEnabled = true;
            comboBoxFornecedor.Location = new Point(155, 285);
            comboBoxFornecedor.Name = "comboBoxFornecedor";
            comboBoxFornecedor.Size = new Size(214, 28);
            comboBoxFornecedor.TabIndex = 80;
            comboBoxFornecedor.DropDown += comboBoxFornecedor_DropDown;
            comboBoxFornecedor.Validating += comboBoxFornecedor_Validating;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(63, 289);
            label8.Name = "label8";
            label8.Size = new Size(87, 20);
            label8.TabIndex = 79;
            label8.Text = "Fornecedor:";
            // 
            // comboBoxTIpo
            // 
            comboBoxTIpo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxTIpo.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxTIpo.FormattingEnabled = true;
            comboBoxTIpo.Items.AddRange(new object[] { "Motor", "Suspensão e Direção", "Freio", "Transmissão", "Elétrica", "Arrefecimento", "Escape", "Estética e Acabamento", "Combustível", "Pneumáticos", "Outro" });
            comboBoxTIpo.Location = new Point(137, 69);
            comboBoxTIpo.Margin = new Padding(3, 4, 3, 4);
            comboBoxTIpo.Name = "comboBoxTIpo";
            comboBoxTIpo.Size = new Size(238, 28);
            comboBoxTIpo.TabIndex = 78;
            comboBoxTIpo.DropDown += comboBoxTIpo_DropDown;
            comboBoxTIpo.Validating += comboBoxTIpo_Validating;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(91, 75);
            label7.Name = "label7";
            label7.Size = new Size(42, 20);
            label7.TabIndex = 77;
            label7.Text = "Tipo:";
            // 
            // comboBoxMarca
            // 
            comboBoxMarca.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxMarca.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxMarca.FormattingEnabled = true;
            comboBoxMarca.Location = new Point(137, 31);
            comboBoxMarca.Margin = new Padding(3, 4, 3, 4);
            comboBoxMarca.Name = "comboBoxMarca";
            comboBoxMarca.Size = new Size(238, 28);
            comboBoxMarca.TabIndex = 76;
            comboBoxMarca.DropDown += comboBoxMarca_DropDown;
            comboBoxMarca.Validating += comboBoxMarca_Validating;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 253);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 75;
            label1.Text = "Garantia:";
            // 
            // dateTimePickerGarantia
            // 
            dateTimePickerGarantia.Format = DateTimePickerFormat.Short;
            dateTimePickerGarantia.Location = new Point(137, 252);
            dateTimePickerGarantia.Margin = new Padding(3, 4, 3, 4);
            dateTimePickerGarantia.Name = "dateTimePickerGarantia";
            dateTimePickerGarantia.Size = new Size(238, 27);
            dateTimePickerGarantia.TabIndex = 74;
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.Location = new Point(19, 368);
            buttonCadastrar.Margin = new Padding(3, 4, 3, 4);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(149, 77);
            buttonCadastrar.TabIndex = 73;
            buttonCadastrar.Text = "Cadastrar";
            buttonCadastrar.UseVisualStyleBackColor = true;
            buttonCadastrar.Click += buttonCadastrar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(48, 219);
            label6.Name = "label6";
            label6.Size = new Size(90, 20);
            label6.TabIndex = 72;
            label6.Text = "Quantidade:";
            // 
            // numericUpDownQuant
            // 
            numericUpDownQuant.Location = new Point(137, 217);
            numericUpDownQuant.Margin = new Padding(3, 4, 3, 4);
            numericUpDownQuant.Maximum = new decimal(new int[] { 1215752192, 23, 0, 0 });
            numericUpDownQuant.Name = "numericUpDownQuant";
            numericUpDownQuant.Size = new Size(239, 27);
            numericUpDownQuant.TabIndex = 71;
            numericUpDownQuant.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownQuant.ValueChanged += numericUpDownQuant_ValueChanged;
            numericUpDownQuant.Validating += numericUpDownQuant_Validating;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(81, 35);
            label5.Name = "label5";
            label5.Size = new Size(53, 20);
            label5.TabIndex = 70;
            label5.Text = "Marca:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(89, 151);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 69;
            label4.Text = "Valor:";
            // 
            // maskedTextBoxValor
            // 
            maskedTextBoxValor.Location = new Point(137, 147);
            maskedTextBoxValor.Margin = new Padding(3, 4, 3, 4);
            maskedTextBoxValor.Name = "maskedTextBoxValor";
            maskedTextBoxValor.Size = new Size(238, 27);
            maskedTextBoxValor.TabIndex = 68;
            maskedTextBoxValor.Text = "0.00";
            maskedTextBoxValor.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            maskedTextBoxValor.TextChanged += maskedTextBoxValor_TextChanged;
            maskedTextBoxValor.KeyPress += maskedTextBoxValor_KeyPress;
            // 
            // richTextBoxDesc
            // 
            richTextBoxDesc.Location = new Point(457, 31);
            richTextBoxDesc.Margin = new Padding(3, 4, 3, 4);
            richTextBoxDesc.Name = "richTextBoxDesc";
            richTextBoxDesc.Size = new Size(331, 415);
            richTextBoxDesc.TabIndex = 67;
            richTextBoxDesc.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(381, 35);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 66;
            label3.Text = "Descrição:";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(137, 108);
            textBoxNome.Margin = new Padding(3, 4, 3, 4);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(238, 27);
            textBoxNome.TabIndex = 65;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 112);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 64;
            label2.Text = "Nome:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(383, 151);
            label11.Name = "label11";
            label11.Size = new Size(26, 20);
            label11.TabIndex = 85;
            label11.Text = "R$";
            // 
            // CadastroPeca
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(821, 485);
            Controls.Add(label11);
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
            Margin = new Padding(3, 4, 3, 4);
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
        private Label label11;
    }
}