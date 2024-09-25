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
            buttonCadastrar = new Button();
            dateTimePickerGarantia = new DateTimePicker();
            label2 = new Label();
            maskedTextBoxValor = new MaskedTextBox();
            richTextBoxDesc = new RichTextBox();
            textBoxNome = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            label11 = new Label();
            comboBoxFunc = new ComboBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.Location = new Point(16, 171);
            buttonCadastrar.Margin = new Padding(3, 4, 3, 4);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(165, 104);
            buttonCadastrar.TabIndex = 8;
            buttonCadastrar.Text = "Cadastrar";
            buttonCadastrar.UseVisualStyleBackColor = true;
            buttonCadastrar.Click += buttonCadastrar_Click;
            // 
            // dateTimePickerGarantia
            // 
            dateTimePickerGarantia.Format = DateTimePickerFormat.Short;
            dateTimePickerGarantia.Location = new Point(110, 103);
            dateTimePickerGarantia.Name = "dateTimePickerGarantia";
            dateTimePickerGarantia.Size = new Size(122, 27);
            dateTimePickerGarantia.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 103);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 17;
            label2.Text = "Garantia:";
            // 
            // maskedTextBoxValor
            // 
            maskedTextBoxValor.Location = new Point(110, 69);
            maskedTextBoxValor.Margin = new Padding(3, 4, 3, 4);
            maskedTextBoxValor.Name = "maskedTextBoxValor";
            maskedTextBoxValor.Size = new Size(269, 27);
            maskedTextBoxValor.TabIndex = 16;
            maskedTextBoxValor.Text = "0.00";
            maskedTextBoxValor.TextChanged += maskedTextBoxValor_TextChanged;
            maskedTextBoxValor.KeyPress += maskedTextBoxValor_KeyPress;
            // 
            // richTextBoxDesc
            // 
            richTextBoxDesc.Location = new Point(469, 29);
            richTextBoxDesc.Margin = new Padding(3, 4, 3, 4);
            richTextBoxDesc.Name = "richTextBoxDesc";
            richTextBoxDesc.Size = new Size(340, 246);
            richTextBoxDesc.TabIndex = 15;
            richTextBoxDesc.Text = "";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(111, 34);
            textBoxNome.Margin = new Padding(3, 4, 3, 4);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(269, 27);
            textBoxNome.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(386, 29);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 13;
            label4.Text = "Descrição:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(62, 67);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 12;
            label3.Text = "Valor:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 29);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 11;
            label1.Text = "Nome:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(386, 67);
            label11.Name = "label11";
            label11.Size = new Size(26, 20);
            label11.TabIndex = 86;
            label11.Text = "R$";
            // 
            // comboBoxFunc
            // 
            comboBoxFunc.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxFunc.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxFunc.FormattingEnabled = true;
            comboBoxFunc.Location = new Point(111, 136);
            comboBoxFunc.Name = "comboBoxFunc";
            comboBoxFunc.Size = new Size(269, 28);
            comboBoxFunc.TabIndex = 87;
            comboBoxFunc.DropDown += comboBoxFunc_DropDown;
            comboBoxFunc.Validating += comboBox1_Validating;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 139);
            label6.Name = "label6";
            label6.Size = new Size(89, 20);
            label6.TabIndex = 90;
            label6.Text = "Funcionário:";
            // 
            // CadastroServico
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(829, 295);
            Controls.Add(label6);
            Controls.Add(comboBoxFunc);
            Controls.Add(label11);
            Controls.Add(dateTimePickerGarantia);
            Controls.Add(label2);
            Controls.Add(maskedTextBoxValor);
            Controls.Add(richTextBoxDesc);
            Controls.Add(textBoxNome);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(buttonCadastrar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CadastroServico";
            Text = "CadastroServico";
            Load += CadastroServico_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonCadastrar;
        private DateTimePicker dateTimePickerGarantia;
        private Label label2;
        private MaskedTextBox maskedTextBoxValor;
        private RichTextBox richTextBoxDesc;
        private TextBox textBoxNome;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label11;
        private ComboBox comboBoxFunc;
        private Label label6;
    }
}