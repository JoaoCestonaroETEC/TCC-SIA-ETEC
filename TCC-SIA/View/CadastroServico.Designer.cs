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
            label3 = new Label();
            label4 = new Label();
            textBoxNome = new TextBox();
            richTextBoxDesc = new RichTextBox();
            maskedTextBoxValor = new MaskedTextBox();
            buttonCadastrar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 37);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 76);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 2;
            label3.Text = "Valor:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(358, 37);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 3;
            label4.Text = "Descrição:";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(82, 33);
            textBoxNome.Margin = new Padding(3, 4, 3, 4);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(269, 27);
            textBoxNome.TabIndex = 4;
            // 
            // richTextBoxDesc
            // 
            richTextBoxDesc.Location = new Point(434, 33);
            richTextBoxDesc.Margin = new Padding(3, 4, 3, 4);
            richTextBoxDesc.Name = "richTextBoxDesc";
            richTextBoxDesc.Size = new Size(340, 185);
            richTextBoxDesc.TabIndex = 6;
            richTextBoxDesc.Text = "";
            // 
            // maskedTextBoxValor
            // 
            maskedTextBoxValor.Location = new Point(82, 72);
            maskedTextBoxValor.Margin = new Padding(3, 4, 3, 4);
            maskedTextBoxValor.Name = "maskedTextBoxValor";
            maskedTextBoxValor.Size = new Size(269, 27);
            maskedTextBoxValor.TabIndex = 7;
            maskedTextBoxValor.KeyPress += maskedTextBoxValor_KeyPress;
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.Location = new Point(26, 114);
            buttonCadastrar.Margin = new Padding(3, 4, 3, 4);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(165, 104);
            buttonCadastrar.TabIndex = 8;
            buttonCadastrar.Text = "Cadastrar";
            buttonCadastrar.UseVisualStyleBackColor = true;
            buttonCadastrar.Click += buttonCadastrar_Click;
            // 
            // CadastroServico
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 249);
            Controls.Add(buttonCadastrar);
            Controls.Add(maskedTextBoxValor);
            Controls.Add(richTextBoxDesc);
            Controls.Add(textBoxNome);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CadastroServico";
            Text = "CadastroServico";
            Load += CadastroServico_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label4;
        private TextBox textBoxNome;
        private RichTextBox richTextBoxDesc;
        private MaskedTextBox maskedTextBoxValor;
        private Button buttonCadastrar;
    }
}