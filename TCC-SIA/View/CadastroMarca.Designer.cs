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
            label1.Location = new Point(48, 32);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 68);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 1;
            label2.Text = "Descrição:";
            // 
            // richTextBoxDesc
            // 
            richTextBoxDesc.Location = new Point(107, 68);
            richTextBoxDesc.Name = "richTextBoxDesc";
            richTextBoxDesc.Size = new Size(313, 223);
            richTextBoxDesc.TabIndex = 3;
            richTextBoxDesc.Text = "";
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.Location = new Point(14, 297);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(171, 97);
            buttonCadastrar.TabIndex = 4;
            buttonCadastrar.Text = "Cadastrar";
            buttonCadastrar.UseVisualStyleBackColor = true;
            buttonCadastrar.Click += buttonCadastrar_Click;
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(107, 28);
            textBoxNome.Margin = new Padding(3, 4, 3, 4);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(313, 27);
            textBoxNome.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(427, 32);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 21;
            label3.Text = "Tipo:";
            // 
            // comboBoxTipo
            // 
            comboBoxTipo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxTipo.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxTipo.FormattingEnabled = true;
            comboBoxTipo.Location = new Point(472, 28);
            comboBoxTipo.Margin = new Padding(3, 4, 3, 4);
            comboBoxTipo.Name = "comboBoxTipo";
            comboBoxTipo.Size = new Size(138, 28);
            comboBoxTipo.TabIndex = 22;
            comboBoxTipo.DropDown += comboBoxTipo_DropDown;
            comboBoxTipo.Validating += comboBoxTipo_Validating;
            // 
            // CadastroMarca
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(645, 405);
            Controls.Add(comboBoxTipo);
            Controls.Add(label3);
            Controls.Add(textBoxNome);
            Controls.Add(buttonCadastrar);
            Controls.Add(richTextBoxDesc);
            Controls.Add(label2);
            Controls.Add(label1);
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