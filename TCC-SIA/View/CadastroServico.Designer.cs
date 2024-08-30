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
            SuspendLayout();
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.Location = new Point(26, 173);
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
            dateTimePickerGarantia.Location = new Point(93, 101);
            dateTimePickerGarantia.Name = "dateTimePickerGarantia";
            dateTimePickerGarantia.Size = new Size(122, 27);
            dateTimePickerGarantia.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 101);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 17;
            label2.Text = "Garantia:";
            // 
            // maskedTextBoxValor
            // 
            maskedTextBoxValor.Location = new Point(93, 61);
            maskedTextBoxValor.Margin = new Padding(3, 4, 3, 4);
            maskedTextBoxValor.Name = "maskedTextBoxValor";
            maskedTextBoxValor.Size = new Size(269, 27);
            maskedTextBoxValor.TabIndex = 16;
            // 
            // richTextBoxDesc
            // 
            richTextBoxDesc.Location = new Point(445, 22);
            richTextBoxDesc.Margin = new Padding(3, 4, 3, 4);
            richTextBoxDesc.Name = "richTextBoxDesc";
            richTextBoxDesc.Size = new Size(340, 244);
            richTextBoxDesc.TabIndex = 15;
            richTextBoxDesc.Text = "";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(93, 22);
            textBoxNome.Margin = new Padding(3, 4, 3, 4);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(269, 27);
            textBoxNome.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(369, 26);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 13;
            label4.Text = "Descrição:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 65);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 12;
            label3.Text = "Valor:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 26);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 11;
            label1.Text = "Nome:";
            // 
            // CadastroServico
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 289);
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
    }
}