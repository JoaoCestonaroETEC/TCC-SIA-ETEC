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
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuant).BeginInit();
            SuspendLayout();
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(98, 85);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(209, 23);
            textBoxNome.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 88);
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
            richTextBoxDesc.Size = new Size(221, 273);
            richTextBoxDesc.TabIndex = 24;
            richTextBoxDesc.Text = "";
            // 
            // maskedTextBoxValor
            // 
            maskedTextBoxValor.Location = new Point(98, 114);
            maskedTextBoxValor.Name = "maskedTextBoxValor";
            maskedTextBoxValor.Size = new Size(209, 23);
            maskedTextBoxValor.TabIndex = 25;
            maskedTextBoxValor.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            maskedTextBoxValor.KeyPress += maskedTextBoxValor_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(56, 117);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 26;
            label4.Text = "Valor:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(49, 30);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 27;
            label5.Text = "Marca:";
            // 
            // numericUpDownQuant
            // 
            numericUpDownQuant.Location = new Point(98, 143);
            numericUpDownQuant.Name = "numericUpDownQuant";
            numericUpDownQuant.Size = new Size(209, 23);
            numericUpDownQuant.TabIndex = 29;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 145);
            label6.Name = "label6";
            label6.Size = new Size(72, 15);
            label6.TabIndex = 30;
            label6.Text = "Quantidade:";
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.Location = new Point(20, 225);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(106, 75);
            buttonCadastrar.TabIndex = 31;
            buttonCadastrar.Text = "Cadastrar";
            buttonCadastrar.UseVisualStyleBackColor = true;
            buttonCadastrar.Click += buttonCadastrar_Click;
            // 
            // dateTimePickerGarantia
            // 
            dateTimePickerGarantia.Format = DateTimePickerFormat.Short;
            dateTimePickerGarantia.Location = new Point(98, 171);
            dateTimePickerGarantia.Name = "dateTimePickerGarantia";
            dateTimePickerGarantia.Size = new Size(209, 23);
            dateTimePickerGarantia.TabIndex = 32;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 171);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 33;
            label1.Text = "Garantia:";
            // 
            // comboBoxMarca
            // 
            comboBoxMarca.FormattingEnabled = true;
            comboBoxMarca.Location = new Point(98, 27);
            comboBoxMarca.Name = "comboBoxMarca";
            comboBoxMarca.Size = new Size(209, 23);
            comboBoxMarca.TabIndex = 34;
            // 
            // comboBoxTIpo
            // 
            comboBoxTIpo.FormattingEnabled = true;
            comboBoxTIpo.Location = new Point(98, 56);
            comboBoxTIpo.Name = "comboBoxTIpo";
            comboBoxTIpo.Size = new Size(209, 23);
            comboBoxTIpo.TabIndex = 36;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(59, 59);
            label7.Name = "label7";
            label7.Size = new Size(33, 15);
            label7.TabIndex = 35;
            label7.Text = "Tipo:";
            // 
            // CadastroPeca
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(631, 312);
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
    }
}