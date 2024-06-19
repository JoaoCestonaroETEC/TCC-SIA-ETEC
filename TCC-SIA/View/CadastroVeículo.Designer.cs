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
            labelCpf.Location = new Point(24, 21);
            labelCpf.Name = "labelCpf";
            labelCpf.Size = new Size(86, 15);
            labelCpf.TabIndex = 19;
            labelCpf.Text = "Cpf do Cliente:";
            // 
            // labelMarca
            // 
            labelMarca.AutoSize = true;
            labelMarca.Location = new Point(71, 78);
            labelMarca.Name = "labelMarca";
            labelMarca.Size = new Size(43, 15);
            labelMarca.TabIndex = 17;
            labelMarca.Text = "Marca:";
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.Location = new Point(200, 184);
            buttonCadastrar.Margin = new Padding(3, 2, 3, 2);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(137, 76);
            buttonCadastrar.TabIndex = 16;
            buttonCadastrar.Text = "Cadastrar";
            buttonCadastrar.UseVisualStyleBackColor = true;
            buttonCadastrar.Click += buttonCadastrar_Click;
            // 
            // labelCor
            // 
            labelCor.AutoSize = true;
            labelCor.Location = new Point(87, 48);
            labelCor.Name = "labelCor";
            labelCor.Size = new Size(29, 15);
            labelCor.TabIndex = 14;
            labelCor.Text = "Cor:";
            // 
            // labelTipo
            // 
            labelTipo.AutoSize = true;
            labelTipo.Location = new Point(83, 103);
            labelTipo.Name = "labelTipo";
            labelTipo.Size = new Size(30, 15);
            labelTipo.TabIndex = 25;
            labelTipo.Text = "Tipo";
            // 
            // labelPlaca
            // 
            labelPlaca.AutoSize = true;
            labelPlaca.Location = new Point(71, 152);
            labelPlaca.Name = "labelPlaca";
            labelPlaca.Size = new Size(38, 15);
            labelPlaca.TabIndex = 23;
            labelPlaca.Text = "Placa:";
            // 
            // labelModelo
            // 
            labelModelo.AutoSize = true;
            labelModelo.Location = new Point(61, 127);
            labelModelo.Name = "labelModelo";
            labelModelo.Size = new Size(51, 15);
            labelModelo.TabIndex = 21;
            labelModelo.Text = "Modelo:";
            // 
            // textBoxMarca
            // 
            textBoxMarca.Location = new Point(122, 75);
            textBoxMarca.Margin = new Padding(3, 2, 3, 2);
            textBoxMarca.Name = "textBoxMarca";
            textBoxMarca.Size = new Size(215, 23);
            textBoxMarca.TabIndex = 28;
            // 
            // textBoxModelo
            // 
            textBoxModelo.Location = new Point(122, 125);
            textBoxModelo.Margin = new Padding(3, 2, 3, 2);
            textBoxModelo.Name = "textBoxModelo";
            textBoxModelo.Size = new Size(215, 23);
            textBoxModelo.TabIndex = 30;
            // 
            // textBoxPlaca
            // 
            textBoxPlaca.Location = new Point(122, 150);
            textBoxPlaca.Margin = new Padding(3, 2, 3, 2);
            textBoxPlaca.Name = "textBoxPlaca";
            textBoxPlaca.Size = new Size(215, 23);
            textBoxPlaca.TabIndex = 31;
            // 
            // maskedTextBoxCpf
            // 
            maskedTextBoxCpf.Location = new Point(122, 19);
            maskedTextBoxCpf.Margin = new Padding(3, 2, 3, 2);
            maskedTextBoxCpf.Mask = "00000000000";
            maskedTextBoxCpf.Name = "maskedTextBoxCpf";
            maskedTextBoxCpf.Size = new Size(215, 23);
            maskedTextBoxCpf.TabIndex = 32;
            maskedTextBoxCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // comboBoxCor
            // 
            comboBoxCor.FormattingEnabled = true;
            comboBoxCor.Location = new Point(122, 47);
            comboBoxCor.Name = "comboBoxCor";
            comboBoxCor.Size = new Size(215, 23);
            comboBoxCor.TabIndex = 33;
            // 
            // comboBoxTipo
            // 
            comboBoxTipo.FormattingEnabled = true;
            comboBoxTipo.Location = new Point(122, 100);
            comboBoxTipo.Name = "comboBoxTipo";
            comboBoxTipo.Size = new Size(215, 23);
            comboBoxTipo.TabIndex = 34;
            // 
            // CadastroVeículo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 282);
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
            Margin = new Padding(3, 2, 3, 2);
            Name = "CadastroVeículo";
            Text = "CadastroVeículo";
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