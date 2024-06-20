namespace TCC_SIA.View
{
    partial class CadastroVeículo
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
            labelCpf = new Label();
            labelMarca = new Label();
            buttonCadastrar = new Button();
            labelCor = new Label();
            labelTipo = new Label();
            labelPlaca = new Label();
            labelModelo = new Label();
            textBoxMarca = new TextBox();
            textBoxModelo = new TextBox();
            textBoxPlaca = new TextBox();
            maskedTextBoxCpf = new MaskedTextBox();
            comboBoxCor = new ComboBox();
            comboBoxTipo = new ComboBox();
            SuspendLayout();
            // 
            // labelCpf
            // 
            labelCpf.AutoSize = true;
            labelCpf.Location = new Point(27, 28);
            labelCpf.Name = "labelCpf";
            labelCpf.Size = new Size(107, 20);
            labelCpf.TabIndex = 19;
            labelCpf.Text = "Cpf do Cliente:";
            // 
            // labelMarca
            // 
            labelMarca.AutoSize = true;
            labelMarca.Location = new Point(81, 104);
            labelMarca.Name = "labelMarca";
            labelMarca.Size = new Size(53, 20);
            labelMarca.TabIndex = 17;
            labelMarca.Text = "Marca:";
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.Location = new Point(229, 245);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(157, 101);
            buttonCadastrar.TabIndex = 16;
            buttonCadastrar.Text = "Cadastrar";
            buttonCadastrar.UseVisualStyleBackColor = true;
            buttonCadastrar.Click += buttonCadastrar_Click;
            // 
            // labelCor
            // 
            labelCor.AutoSize = true;
            labelCor.Location = new Point(99, 64);
            labelCor.Name = "labelCor";
            labelCor.Size = new Size(35, 20);
            labelCor.TabIndex = 14;
            labelCor.Text = "Cor:";
            // 
            // labelTipo
            // 
            labelTipo.AutoSize = true;
            labelTipo.Location = new Point(95, 137);
            labelTipo.Name = "labelTipo";
            labelTipo.Size = new Size(39, 20);
            labelTipo.TabIndex = 25;
            labelTipo.Text = "Tipo";
            // 
            // labelPlaca
            // 
            labelPlaca.AutoSize = true;
            labelPlaca.Location = new Point(81, 203);
            labelPlaca.Name = "labelPlaca";
            labelPlaca.Size = new Size(47, 20);
            labelPlaca.TabIndex = 23;
            labelPlaca.Text = "Placa:";
            // 
            // labelModelo
            // 
            labelModelo.AutoSize = true;
            labelModelo.Location = new Point(70, 169);
            labelModelo.Name = "labelModelo";
            labelModelo.Size = new Size(64, 20);
            labelModelo.TabIndex = 21;
            labelModelo.Text = "Modelo:";
            // 
            // textBoxMarca
            // 
            textBoxMarca.Location = new Point(139, 100);
            textBoxMarca.Name = "textBoxMarca";
            textBoxMarca.Size = new Size(245, 27);
            textBoxMarca.TabIndex = 28;
            // 
            // textBoxModelo
            // 
            textBoxModelo.Location = new Point(139, 167);
            textBoxModelo.Name = "textBoxModelo";
            textBoxModelo.Size = new Size(245, 27);
            textBoxModelo.TabIndex = 30;
            // 
            // textBoxPlaca
            // 
            textBoxPlaca.Location = new Point(139, 200);
            textBoxPlaca.Name = "textBoxPlaca";
            textBoxPlaca.Size = new Size(245, 27);
            textBoxPlaca.TabIndex = 31;
            // 
            // maskedTextBoxCpf
            // 
            maskedTextBoxCpf.Location = new Point(139, 25);
            maskedTextBoxCpf.Mask = "00000000000";
            maskedTextBoxCpf.Name = "maskedTextBoxCpf";
            maskedTextBoxCpf.Size = new Size(245, 27);
            maskedTextBoxCpf.TabIndex = 32;
            maskedTextBoxCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // comboBoxCor
            // 
            comboBoxCor.FormattingEnabled = true;
            comboBoxCor.Location = new Point(139, 63);
            comboBoxCor.Margin = new Padding(3, 4, 3, 4);
            comboBoxCor.Name = "comboBoxCor";
            comboBoxCor.Size = new Size(245, 28);
            comboBoxCor.TabIndex = 33;
            // 
            // comboBoxTipo
            // 
            comboBoxTipo.FormattingEnabled = true;
            comboBoxTipo.Location = new Point(139, 133);
            comboBoxTipo.Margin = new Padding(3, 4, 3, 4);
            comboBoxTipo.Name = "comboBoxTipo";
            comboBoxTipo.Size = new Size(245, 28);
            comboBoxTipo.TabIndex = 34;
            // 
            // CadastroVeículo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(447, 376);
            Controls.Add(comboBoxTipo);
            Controls.Add(comboBoxCor);
            Controls.Add(maskedTextBoxCpf);
            Controls.Add(textBoxPlaca);
            Controls.Add(textBoxModelo);
            Controls.Add(textBoxMarca);
            Controls.Add(labelTipo);
            Controls.Add(labelPlaca);
            Controls.Add(labelModelo);
            Controls.Add(labelCpf);
            Controls.Add(labelMarca);
            Controls.Add(buttonCadastrar);
            Controls.Add(labelCor);
            Name = "CadastroVeículo";
            Text = "CadastroVeículo";
            Load += CadastroVeículo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelCpf;
        private Label labelMarca;
        private Button buttonCadastrar;
        private Label labelCor;
        private Label labelTipo;
        private Label labelPlaca;
        private Label labelModelo;
        private TextBox textBoxMarca;
        private TextBox textBoxModelo;
        private TextBox textBoxPlaca;
        private MaskedTextBox maskedTextBoxCpf;
        private ComboBox comboBoxCor;
        private ComboBox comboBoxTipo;
    }
}