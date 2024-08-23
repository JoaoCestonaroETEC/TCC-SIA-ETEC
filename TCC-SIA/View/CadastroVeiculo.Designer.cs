namespace TCC_SIA.View
{
    partial class CadastroVeiculo
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
            textBoxModelo = new TextBox();
            comboBoxCor = new ComboBox();
            comboBoxTipo = new ComboBox();
            comboBoxMarca = new ComboBox();
            maskedTextBoxPlaca = new MaskedTextBox();
            label1 = new Label();
            textBoxNome = new TextBox();
            comboBoxCpf = new ComboBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            maskedTextBox1 = new MaskedTextBox();
            label4 = new Label();
            maskedTextBox2 = new MaskedTextBox();
            label5 = new Label();
            comboBox1 = new ComboBox();
            label6 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label7 = new Label();
            comboBox2 = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            comboBox3 = new ComboBox();
            SuspendLayout();
            // 
            // labelCpf
            // 
            labelCpf.AutoSize = true;
            labelCpf.Location = new Point(26, 41);
            labelCpf.Margin = new Padding(4, 0, 4, 0);
            labelCpf.Name = "labelCpf";
            labelCpf.Size = new Size(151, 28);
            labelCpf.TabIndex = 19;
            labelCpf.Text = "Cpf do Cliente:";
            // 
            // labelMarca
            // 
            labelMarca.AutoSize = true;
            labelMarca.Location = new Point(99, 89);
            labelMarca.Margin = new Padding(4, 0, 4, 0);
            labelMarca.Name = "labelMarca";
            labelMarca.Size = new Size(76, 28);
            labelMarca.TabIndex = 17;
            labelMarca.Text = "Marca:";
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.Location = new Point(86, 412);
            buttonCadastrar.Margin = new Padding(4, 5, 4, 5);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(236, 142);
            buttonCadastrar.TabIndex = 16;
            buttonCadastrar.Text = "Cadastrar";
            buttonCadastrar.UseVisualStyleBackColor = true;
            buttonCadastrar.Click += buttonCadastrar_Click;
            // 
            // labelCor
            // 
            labelCor.AutoSize = true;
            labelCor.Location = new Point(123, 239);
            labelCor.Margin = new Padding(4, 0, 4, 0);
            labelCor.Name = "labelCor";
            labelCor.Size = new Size(50, 28);
            labelCor.TabIndex = 14;
            labelCor.Text = "Cor:";
            // 
            // labelTipo
            // 
            labelTipo.AutoSize = true;
            labelTipo.Location = new Point(111, 140);
            labelTipo.Margin = new Padding(4, 0, 4, 0);
            labelTipo.Name = "labelTipo";
            labelTipo.Size = new Size(59, 28);
            labelTipo.TabIndex = 25;
            labelTipo.Text = "Tipo:";
            // 
            // labelPlaca
            // 
            labelPlaca.AutoSize = true;
            labelPlaca.Location = new Point(328, 290);
            labelPlaca.Margin = new Padding(4, 0, 4, 0);
            labelPlaca.Name = "labelPlaca";
            labelPlaca.Size = new Size(67, 28);
            labelPlaca.TabIndex = 23;
            labelPlaca.Text = "Placa:";
            // 
            // labelModelo
            // 
            labelModelo.AutoSize = true;
            labelModelo.Location = new Point(90, 338);
            labelModelo.Margin = new Padding(4, 0, 4, 0);
            labelModelo.Name = "labelModelo";
            labelModelo.Size = new Size(89, 28);
            labelModelo.TabIndex = 21;
            labelModelo.Text = "Modelo:";
            // 
            // textBoxModelo
            // 
            textBoxModelo.Location = new Point(188, 333);
            textBoxModelo.Margin = new Padding(4, 5, 4, 5);
            textBoxModelo.Name = "textBoxModelo";
            textBoxModelo.Size = new Size(366, 34);
            textBoxModelo.TabIndex = 30;
            // 
            // comboBoxCor
            // 
            comboBoxCor.FormattingEnabled = true;
            comboBoxCor.Location = new Point(184, 235);
            comboBoxCor.Margin = new Padding(4, 5, 4, 5);
            comboBoxCor.Name = "comboBoxCor";
            comboBoxCor.Size = new Size(366, 36);
            comboBoxCor.TabIndex = 33;
            // 
            // comboBoxTipo
            // 
            comboBoxTipo.FormattingEnabled = true;
            comboBoxTipo.Location = new Point(183, 135);
            comboBoxTipo.Margin = new Padding(4, 5, 4, 5);
            comboBoxTipo.Name = "comboBoxTipo";
            comboBoxTipo.Size = new Size(366, 36);
            comboBoxTipo.TabIndex = 34;
            // 
            // comboBoxMarca
            // 
            comboBoxMarca.FormattingEnabled = true;
            comboBoxMarca.Location = new Point(188, 86);
            comboBoxMarca.Margin = new Padding(4, 5, 4, 5);
            comboBoxMarca.Name = "comboBoxMarca";
            comboBoxMarca.Size = new Size(366, 36);
            comboBoxMarca.TabIndex = 35;
            // 
            // maskedTextBoxPlaca
            // 
            maskedTextBoxPlaca.CutCopyMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            maskedTextBoxPlaca.Location = new Point(408, 285);
            maskedTextBoxPlaca.Margin = new Padding(4, 5, 4, 5);
            maskedTextBoxPlaca.Mask = "AAAAAAA";
            maskedTextBoxPlaca.Name = "maskedTextBoxPlaca";
            maskedTextBoxPlaca.Size = new Size(145, 34);
            maskedTextBoxPlaca.TabIndex = 36;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(105, 191);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(74, 28);
            label1.TabIndex = 37;
            label1.Text = "Nome:";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(183, 186);
            textBoxNome.Margin = new Padding(4, 5, 4, 5);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(366, 34);
            textBoxNome.TabIndex = 38;
            // 
            // comboBoxCpf
            // 
            comboBoxCpf.FormattingEnabled = true;
            comboBoxCpf.Location = new Point(183, 35);
            comboBoxCpf.Margin = new Padding(4, 5, 4, 5);
            comboBoxCpf.Name = "comboBoxCpf";
            comboBoxCpf.Size = new Size(366, 36);
            comboBoxCpf.TabIndex = 39;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(573, 39);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(76, 28);
            label2.TabIndex = 40;
            label2.Text = "Chassi:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(662, 35);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(316, 34);
            textBox1.TabIndex = 41;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(578, 89);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(190, 28);
            label3.TabIndex = 42;
            label3.Text = "Ano de Fabricação:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(789, 81);
            dateTimePicker1.Margin = new Padding(4, 5, 4, 5);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(188, 34);
            dateTimePicker1.TabIndex = 43;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(762, 127);
            maskedTextBox1.Margin = new Padding(4, 5, 4, 5);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(216, 34);
            maskedTextBox1.TabIndex = 44;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(578, 132);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(165, 28);
            label4.TabIndex = 45;
            label4.Text = "Quilometragem:";
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(762, 173);
            maskedTextBox2.Margin = new Padding(4, 5, 4, 5);
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(216, 34);
            maskedTextBox2.TabIndex = 46;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(674, 178);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(77, 28);
            label5.TabIndex = 47;
            label5.Text = "Motor:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(753, 219);
            comboBox1.Margin = new Padding(4, 5, 4, 5);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(224, 36);
            comboBox1.TabIndex = 48;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(612, 224);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(134, 28);
            label6.TabIndex = 49;
            label6.Text = "Combustível:";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(789, 267);
            dateTimePicker2.Margin = new Padding(4, 5, 4, 5);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(188, 34);
            dateTimePicker2.TabIndex = 50;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(714, 275);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(62, 28);
            label7.TabIndex = 51;
            label7.Text = "Data:";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(753, 313);
            comboBox2.Margin = new Padding(4, 5, 4, 5);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(224, 36);
            comboBox2.TabIndex = 52;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(669, 318);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(83, 28);
            label8.TabIndex = 53;
            label8.Text = "Seguro:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(674, 364);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(108, 28);
            label9.TabIndex = 54;
            label9.Text = "Categoria:";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(798, 359);
            comboBox3.Margin = new Padding(4, 5, 4, 5);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(180, 36);
            comboBox3.TabIndex = 55;
            // 
            // CadastroVeiculo
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1156, 623);
            Controls.Add(comboBox3);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(comboBox2);
            Controls.Add(label7);
            Controls.Add(dateTimePicker2);
            Controls.Add(label6);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(maskedTextBox2);
            Controls.Add(label4);
            Controls.Add(maskedTextBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(comboBoxCpf);
            Controls.Add(textBoxNome);
            Controls.Add(label1);
            Controls.Add(maskedTextBoxPlaca);
            Controls.Add(comboBoxMarca);
            Controls.Add(comboBoxTipo);
            Controls.Add(comboBoxCor);
            Controls.Add(textBoxModelo);
            Controls.Add(labelTipo);
            Controls.Add(labelPlaca);
            Controls.Add(labelModelo);
            Controls.Add(labelCpf);
            Controls.Add(labelMarca);
            Controls.Add(buttonCadastrar);
            Controls.Add(labelCor);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 5, 4, 5);
            Name = "CadastroVeiculo";
            Text = "CadastroVeículo";
            Load += CadastroVeiculo_Load;
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
        private TextBox textBoxModelo;
        private ComboBox comboBoxCor;
        private ComboBox comboBoxTipo;
        private ComboBox comboBoxMarca;
        private MaskedTextBox maskedTextBoxPlaca;
        private Label label1;
        private TextBox textBoxNome;
        private ComboBox comboBoxCpf;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private MaskedTextBox maskedTextBox1;
        private Label label4;
        private MaskedTextBox maskedTextBox2;
        private Label label5;
        private ComboBox comboBox1;
        private Label label6;
        private DateTimePicker dateTimePicker2;
        private Label label7;
        private ComboBox comboBox2;
        private Label label8;
        private Label label9;
        private ComboBox comboBox3;
    }
}