﻿namespace TCC_SIA.View
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
            comboBoxIdCliente = new ComboBox();
            label2 = new Label();
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
            maskedTextBox3 = new MaskedTextBox();
            SuspendLayout();
            // 
            // labelCpf
            // 
            labelCpf.AutoSize = true;
            labelCpf.Location = new Point(16, 13);
            labelCpf.Name = "labelCpf";
            labelCpf.Size = new Size(47, 15);
            labelCpf.TabIndex = 19;
            labelCpf.Text = "Cliente:";
            // 
            // labelMarca
            // 
            labelMarca.AutoSize = true;
            labelMarca.Location = new Point(25, 49);
            labelMarca.Name = "labelMarca";
            labelMarca.Size = new Size(43, 15);
            labelMarca.TabIndex = 17;
            labelMarca.Text = "Marca:";
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.Location = new Point(19, 264);
            buttonCadastrar.Margin = new Padding(3, 4, 3, 4);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(115, 66);
            buttonCadastrar.TabIndex = 16;
            buttonCadastrar.Text = "Cadastrar";
            buttonCadastrar.UseVisualStyleBackColor = true;
            buttonCadastrar.Click += buttonCadastrar_Click;
            // 
            // labelCor
            // 
            labelCor.AutoSize = true;
            labelCor.Location = new Point(42, 156);
            labelCor.Name = "labelCor";
            labelCor.Size = new Size(29, 15);
            labelCor.TabIndex = 14;
            labelCor.Text = "Cor:";
            // 
            // labelTipo
            // 
            labelTipo.AutoSize = true;
            labelTipo.Location = new Point(34, 85);
            labelTipo.Name = "labelTipo";
            labelTipo.Size = new Size(33, 15);
            labelTipo.TabIndex = 25;
            labelTipo.Text = "Tipo:";
            // 
            // labelPlaca
            // 
            labelPlaca.AutoSize = true;
            labelPlaca.Location = new Point(186, 192);
            labelPlaca.Name = "labelPlaca";
            labelPlaca.Size = new Size(38, 15);
            labelPlaca.TabIndex = 23;
            labelPlaca.Text = "Placa:";
            // 
            // labelModelo
            // 
            labelModelo.AutoSize = true;
            labelModelo.Location = new Point(19, 226);
            labelModelo.Name = "labelModelo";
            labelModelo.Size = new Size(51, 15);
            labelModelo.TabIndex = 21;
            labelModelo.Text = "Modelo:";
            // 
            // textBoxModelo
            // 
            textBoxModelo.Location = new Point(88, 223);
            textBoxModelo.Margin = new Padding(3, 4, 3, 4);
            textBoxModelo.Name = "textBoxModelo";
            textBoxModelo.Size = new Size(257, 23);
            textBoxModelo.TabIndex = 30;
            // 
            // comboBoxCor
            // 
            comboBoxCor.FormattingEnabled = true;
            comboBoxCor.Location = new Point(85, 153);
            comboBoxCor.Margin = new Padding(3, 4, 3, 4);
            comboBoxCor.Name = "comboBoxCor";
            comboBoxCor.Size = new Size(257, 23);
            comboBoxCor.TabIndex = 33;
            // 
            // comboBoxTipo
            // 
            comboBoxTipo.FormattingEnabled = true;
            comboBoxTipo.Location = new Point(84, 81);
            comboBoxTipo.Margin = new Padding(3, 4, 3, 4);
            comboBoxTipo.Name = "comboBoxTipo";
            comboBoxTipo.Size = new Size(257, 23);
            comboBoxTipo.TabIndex = 34;
            // 
            // comboBoxMarca
            // 
            comboBoxMarca.FormattingEnabled = true;
            comboBoxMarca.Location = new Point(88, 46);
            comboBoxMarca.Margin = new Padding(3, 4, 3, 4);
            comboBoxMarca.Name = "comboBoxMarca";
            comboBoxMarca.Size = new Size(257, 23);
            comboBoxMarca.TabIndex = 35;
            // 
            // maskedTextBoxPlaca
            // 
            maskedTextBoxPlaca.CutCopyMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            maskedTextBoxPlaca.Location = new Point(242, 189);
            maskedTextBoxPlaca.Margin = new Padding(3, 4, 3, 4);
            maskedTextBoxPlaca.Mask = "AAAAAAA";
            maskedTextBoxPlaca.Name = "maskedTextBoxPlaca";
            maskedTextBoxPlaca.Size = new Size(103, 23);
            maskedTextBoxPlaca.TabIndex = 36;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 121);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 37;
            label1.Text = "Nome:";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(84, 118);
            textBoxNome.Margin = new Padding(3, 4, 3, 4);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(257, 23);
            textBoxNome.TabIndex = 38;
            // 
            // comboBoxIdCliente
            // 
            comboBoxIdCliente.FormattingEnabled = true;
            comboBoxIdCliente.Location = new Point(84, 10);
            comboBoxIdCliente.Margin = new Padding(3, 4, 3, 4);
            comboBoxIdCliente.Name = "comboBoxIdCliente";
            comboBoxIdCliente.Size = new Size(257, 23);
            comboBoxIdCliente.TabIndex = 39;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(357, 13);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 40;
            label2.Text = "Chassi:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(360, 49);
            label3.Name = "label3";
            label3.Size = new Size(108, 15);
            label3.TabIndex = 42;
            label3.Text = "Ano de Fabricação:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(508, 43);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(133, 23);
            dateTimePicker1.TabIndex = 43;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(489, 76);
            maskedTextBox1.Margin = new Padding(3, 4, 3, 4);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(152, 23);
            maskedTextBox1.TabIndex = 44;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(360, 79);
            label4.Name = "label4";
            label4.Size = new Size(94, 15);
            label4.TabIndex = 45;
            label4.Text = "Quilometragem:";
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(489, 109);
            maskedTextBox2.Margin = new Padding(3, 4, 3, 4);
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(152, 23);
            maskedTextBox2.TabIndex = 46;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(428, 112);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 47;
            label5.Text = "Motor:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(483, 141);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(158, 23);
            comboBox1.TabIndex = 48;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(384, 145);
            label6.Name = "label6";
            label6.Size = new Size(77, 15);
            label6.TabIndex = 49;
            label6.Text = "Combustível:";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Enabled = false;
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(508, 176);
            dateTimePicker2.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(133, 23);
            dateTimePicker2.TabIndex = 50;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(456, 181);
            label7.Name = "label7";
            label7.Size = new Size(34, 15);
            label7.TabIndex = 51;
            label7.Text = "Data:";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(483, 209);
            comboBox2.Margin = new Padding(3, 4, 3, 4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(158, 23);
            comboBox2.TabIndex = 52;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(424, 212);
            label8.Name = "label8";
            label8.Size = new Size(47, 15);
            label8.TabIndex = 53;
            label8.Text = "Seguro:";
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Location = new Point(405, 10);
            maskedTextBox3.Margin = new Padding(2, 2, 2, 2);
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(236, 23);
            maskedTextBox3.TabIndex = 56;
            // 
            // CadastroVeiculo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 359);
            Controls.Add(maskedTextBox3);
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
            Controls.Add(label2);
            Controls.Add(comboBoxIdCliente);
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
            Font = new Font("Segoe UI", 9F);
            Margin = new Padding(3, 4, 3, 4);
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
        private ComboBox comboBoxIdCliente;
        private Label label2;
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
        private MaskedTextBox maskedTextBox3;
    }
}