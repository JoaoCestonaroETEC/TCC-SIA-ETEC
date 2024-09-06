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
            comboBoxIdCliente = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            dateTimePickerFab = new DateTimePicker();
            maskedTextBoxQuilo = new MaskedTextBox();
            label4 = new Label();
            maskedTextBoxMotor = new MaskedTextBox();
            label5 = new Label();
            comboBoxCombustivel = new ComboBox();
            label6 = new Label();
            dateTimePickerData = new DateTimePicker();
            label7 = new Label();
            comboBoxSeguro = new ComboBox();
            label8 = new Label();
            maskedTextBoxChassi = new MaskedTextBox();
            label9 = new Label();
            SuspendLayout();
            // 
            // labelCpf
            // 
            labelCpf.AutoSize = true;
            labelCpf.Location = new Point(31, 18);
            labelCpf.Name = "labelCpf";
            labelCpf.Size = new Size(47, 15);
            labelCpf.TabIndex = 19;
            labelCpf.Text = "Cliente:";
            // 
            // labelMarca
            // 
            labelMarca.AutoSize = true;
            labelMarca.Location = new Point(39, 51);
            labelMarca.Name = "labelMarca";
            labelMarca.Size = new Size(43, 15);
            labelMarca.TabIndex = 17;
            labelMarca.Text = "Marca:";
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.Location = new Point(12, 235);
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
            labelCor.Location = new Point(45, 143);
            labelCor.Name = "labelCor";
            labelCor.Size = new Size(29, 15);
            labelCor.TabIndex = 14;
            labelCor.Text = "Cor:";
            // 
            // labelTipo
            // 
            labelTipo.AutoSize = true;
            labelTipo.Location = new Point(46, 81);
            labelTipo.Name = "labelTipo";
            labelTipo.Size = new Size(33, 15);
            labelTipo.TabIndex = 25;
            labelTipo.Text = "Tipo:";
            // 
            // labelPlaca
            // 
            labelPlaca.AutoSize = true;
            labelPlaca.Location = new Point(183, 176);
            labelPlaca.Name = "labelPlaca";
            labelPlaca.Size = new Size(38, 15);
            labelPlaca.TabIndex = 23;
            labelPlaca.Text = "Placa:";
            // 
            // labelModelo
            // 
            labelModelo.AutoSize = true;
            labelModelo.Location = new Point(34, 210);
            labelModelo.Name = "labelModelo";
            labelModelo.Size = new Size(51, 15);
            labelModelo.TabIndex = 21;
            labelModelo.Text = "Modelo:";
            // 
            // textBoxModelo
            // 
            textBoxModelo.Location = new Point(85, 204);
            textBoxModelo.Margin = new Padding(3, 4, 3, 4);
            textBoxModelo.Name = "textBoxModelo";
            textBoxModelo.Size = new Size(257, 23);
            textBoxModelo.TabIndex = 30;
            // 
            // comboBoxCor
            // 
            comboBoxCor.FormattingEnabled = true;
            comboBoxCor.Location = new Point(88, 140);
            comboBoxCor.Margin = new Padding(3, 4, 3, 4);
            comboBoxCor.Name = "comboBoxCor";
            comboBoxCor.Size = new Size(253, 23);
            comboBoxCor.TabIndex = 33;
            // 
            // comboBoxTipo
            // 
            comboBoxTipo.FormattingEnabled = true;
            comboBoxTipo.Location = new Point(85, 78);
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
            comboBoxMarca.Size = new Size(253, 23);
            comboBoxMarca.TabIndex = 35;
            // 
            // maskedTextBoxPlaca
            // 
            maskedTextBoxPlaca.CutCopyMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            maskedTextBoxPlaca.Location = new Point(239, 173);
            maskedTextBoxPlaca.Margin = new Padding(3, 4, 3, 4);
            maskedTextBoxPlaca.Mask = "AAAAAAA";
            maskedTextBoxPlaca.Name = "maskedTextBoxPlaca";
            maskedTextBoxPlaca.Size = new Size(103, 23);
            maskedTextBoxPlaca.TabIndex = 36;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 112);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 37;
            label1.Text = "Nome:";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(84, 109);
            textBoxNome.Margin = new Padding(3, 4, 3, 4);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(257, 23);
            textBoxNome.TabIndex = 38;
            // 
            // comboBoxIdCliente
            // 
            comboBoxIdCliente.FormattingEnabled = true;
            comboBoxIdCliente.Location = new Point(84, 15);
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
            label3.Location = new Point(394, 46);
            label3.Name = "label3";
            label3.Size = new Size(108, 15);
            label3.TabIndex = 42;
            label3.Text = "Ano de Fabricação:";
            // 
            // dateTimePickerFab
            // 
            dateTimePickerFab.Format = DateTimePickerFormat.Short;
            dateTimePickerFab.Location = new Point(508, 43);
            dateTimePickerFab.Margin = new Padding(3, 4, 3, 4);
            dateTimePickerFab.Name = "dateTimePickerFab";
            dateTimePickerFab.Size = new Size(133, 23);
            dateTimePickerFab.TabIndex = 43;
            // 
            // maskedTextBoxQuilo
            // 
            maskedTextBoxQuilo.Location = new Point(489, 76);
            maskedTextBoxQuilo.Margin = new Padding(3, 4, 3, 4);
            maskedTextBoxQuilo.Name = "maskedTextBoxQuilo";
            maskedTextBoxQuilo.Size = new Size(152, 23);
            maskedTextBoxQuilo.TabIndex = 44;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(389, 81);
            label4.Name = "label4";
            label4.Size = new Size(94, 15);
            label4.TabIndex = 45;
            label4.Text = "Quilometragem:";
            // 
            // maskedTextBoxMotor
            // 
            maskedTextBoxMotor.Location = new Point(489, 109);
            maskedTextBoxMotor.Margin = new Padding(3, 4, 3, 4);
            maskedTextBoxMotor.Name = "maskedTextBoxMotor";
            maskedTextBoxMotor.Size = new Size(152, 23);
            maskedTextBoxMotor.TabIndex = 46;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(440, 112);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 47;
            label5.Text = "Motor:";
            // 
            // comboBoxCombustivel
            // 
            comboBoxCombustivel.FormattingEnabled = true;
            comboBoxCombustivel.Location = new Point(483, 141);
            comboBoxCombustivel.Margin = new Padding(3, 4, 3, 4);
            comboBoxCombustivel.Name = "comboBoxCombustivel";
            comboBoxCombustivel.Size = new Size(158, 23);
            comboBoxCombustivel.TabIndex = 48;
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
            // dateTimePickerData
            // 
            dateTimePickerData.Enabled = false;
            dateTimePickerData.Format = DateTimePickerFormat.Short;
            dateTimePickerData.Location = new Point(508, 176);
            dateTimePickerData.Margin = new Padding(3, 4, 3, 4);
            dateTimePickerData.Name = "dateTimePickerData";
            dateTimePickerData.Size = new Size(133, 23);
            dateTimePickerData.TabIndex = 50;
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
            // comboBoxSeguro
            // 
            comboBoxSeguro.FormattingEnabled = true;
            comboBoxSeguro.Location = new Point(483, 209);
            comboBoxSeguro.Margin = new Padding(3, 4, 3, 4);
            comboBoxSeguro.Name = "comboBoxSeguro";
            comboBoxSeguro.Size = new Size(158, 23);
            comboBoxSeguro.TabIndex = 52;
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
            // maskedTextBoxChassi
            // 
            maskedTextBoxChassi.Location = new Point(405, 10);
            maskedTextBoxChassi.Margin = new Padding(2);
            maskedTextBoxChassi.Name = "maskedTextBoxChassi";
            maskedTextBoxChassi.Size = new Size(236, 23);
            maskedTextBoxChassi.TabIndex = 56;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(647, 81);
            label9.Name = "label9";
            label9.Size = new Size(25, 15);
            label9.TabIndex = 57;
            label9.Text = "KM";
            // 
            // CadastroVeiculo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 317);
            Controls.Add(label9);
            Controls.Add(maskedTextBoxChassi);
            Controls.Add(label8);
            Controls.Add(comboBoxSeguro);
            Controls.Add(label7);
            Controls.Add(dateTimePickerData);
            Controls.Add(label6);
            Controls.Add(comboBoxCombustivel);
            Controls.Add(label5);
            Controls.Add(maskedTextBoxMotor);
            Controls.Add(label4);
            Controls.Add(maskedTextBoxQuilo);
            Controls.Add(dateTimePickerFab);
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
        private DateTimePicker dateTimePickerFab;
        private MaskedTextBox maskedTextBoxQuilo;
        private Label label4;
        private MaskedTextBox maskedTextBoxMotor;
        private Label label5;
        private ComboBox comboBoxCombustivel;
        private Label label6;
        private DateTimePicker dateTimePickerData;
        private Label label7;
        private ComboBox comboBoxSeguro;
        private Label label8;
        private MaskedTextBox maskedTextBoxChassi;
        private Label label9;
    }
}