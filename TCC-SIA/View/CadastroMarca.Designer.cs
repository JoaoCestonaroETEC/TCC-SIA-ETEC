namespace TCC_SIA.View
{
    partial class CadastroMarca
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
            label2 = new Label();
            richTextBoxDesc = new RichTextBox();
            buttonCadastrar = new Button();
            textBoxNome = new TextBox();
            label3 = new Label();
            comboBoxTipo = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 24);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 51);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 1;
            label2.Text = "Descrição:";
            // 
            // richTextBoxDesc
            // 
            richTextBoxDesc.Location = new Point(94, 51);
            richTextBoxDesc.Margin = new Padding(3, 2, 3, 2);
            richTextBoxDesc.Name = "richTextBoxDesc";
            richTextBoxDesc.Size = new Size(274, 168);
            richTextBoxDesc.TabIndex = 3;
            richTextBoxDesc.Text = "";
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.Location = new Point(12, 223);
            buttonCadastrar.Margin = new Padding(3, 2, 3, 2);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(150, 73);
            buttonCadastrar.TabIndex = 4;
            buttonCadastrar.Text = "Cadastrar";
            buttonCadastrar.UseVisualStyleBackColor = true;
            buttonCadastrar.Click += buttonCadastrar_Click;
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(94, 21);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(274, 23);
            textBoxNome.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(374, 24);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 21;
            label3.Text = "Tipo:";
            // 
            // comboBoxTipo
            // 
            comboBoxTipo.FormattingEnabled = true;
            comboBoxTipo.Location = new Point(413, 21);
            comboBoxTipo.Name = "comboBoxTipo";
            comboBoxTipo.Size = new Size(121, 23);
            comboBoxTipo.TabIndex = 22;
            comboBoxTipo.DropDown += comboBoxTipo_DropDown;
            comboBoxTipo.Validating += comboBoxTipo_Validating;
            // 
            // CadastroMarca
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 304);
            Controls.Add(comboBoxTipo);
            Controls.Add(label3);
            Controls.Add(textBoxNome);
            Controls.Add(buttonCadastrar);
            Controls.Add(richTextBoxDesc);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "CadastroMarca";
            Text = "CadastroMarca";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private RichTextBox richTextBoxDesc;
        private Button buttonCadastrar;
        private TextBox textBoxNome;
        private Label label3;
        private ComboBox comboBoxTipo;
    }
}