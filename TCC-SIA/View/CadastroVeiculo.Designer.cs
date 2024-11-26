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
            labelCpf.Location = new Point(35, 24);
            labelCpf.Name = "labelCpf";
            labelCpf.Size = new Size(58, 20);
            labelCpf.TabIndex = 19;
            labelCpf.Text = "Cliente:";
            // 
            // labelMarca
            // 
            labelMarca.AutoSize = true;
            labelMarca.Location = new Point(45, 68);
            labelMarca.Name = "labelMarca";
            labelMarca.Size = new Size(53, 20);
            labelMarca.TabIndex = 17;
            labelMarca.Text = "Marca:";
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.Location = new Point(14, 313);
            buttonCadastrar.Margin = new Padding(3, 5, 3, 5);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(171, 96);
            buttonCadastrar.TabIndex = 16;
            buttonCadastrar.Text = "Cadastrar";
            buttonCadastrar.UseVisualStyleBackColor = true;
            buttonCadastrar.Click += buttonCadastrar_Click;
            // 
            // labelCor
            // 
            labelCor.AutoSize = true;
            labelCor.Location = new Point(51, 191);
            labelCor.Name = "labelCor";
            labelCor.Size = new Size(35, 20);
            labelCor.TabIndex = 14;
            labelCor.Text = "Cor:";
            // 
            // labelTipo
            // 
            labelTipo.AutoSize = true;
            labelTipo.Location = new Point(53, 108);
            labelTipo.Name = "labelTipo";
            labelTipo.Size = new Size(42, 20);
            labelTipo.TabIndex = 25;
            labelTipo.Text = "Tipo:";
            // 
            // labelPlaca
            // 
            labelPlaca.AutoSize = true;
            labelPlaca.Location = new Point(209, 235);
            labelPlaca.Name = "labelPlaca";
            labelPlaca.Size = new Size(47, 20);
            labelPlaca.TabIndex = 23;
            labelPlaca.Text = "Placa:";
            // 
            // labelModelo
            // 
            labelModelo.AutoSize = true;
            labelModelo.Location = new Point(518, 104);
            labelModelo.Name = "labelModelo";
            labelModelo.Size = new Size(64, 20);
            labelModelo.TabIndex = 21;
            labelModelo.Text = "Modelo:";
            // 
            // textBoxModelo
            // 
            textBoxModelo.Location = new Point(583, 100);
            textBoxModelo.Margin = new Padding(3, 5, 3, 5);
            textBoxModelo.Name = "textBoxModelo";
            textBoxModelo.Size = new Size(173, 27);
            textBoxModelo.TabIndex = 30;
            // 
            // comboBoxCor
            // 
            comboBoxCor.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxCor.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxCor.FormattingEnabled = true;
            comboBoxCor.Location = new Point(101, 187);
            comboBoxCor.Margin = new Padding(3, 5, 3, 5);
            comboBoxCor.Name = "comboBoxCor";
            comboBoxCor.Size = new Size(289, 28);
            comboBoxCor.TabIndex = 33;
            comboBoxCor.DropDown += comboBoxCor_DropDown;
            comboBoxCor.Validating += comboBoxCor_Validating;
            // 
            // comboBoxTipo
            // 
            comboBoxTipo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxTipo.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxTipo.FormattingEnabled = true;
            comboBoxTipo.Location = new Point(97, 104);
            comboBoxTipo.Margin = new Padding(3, 5, 3, 5);
            comboBoxTipo.Name = "comboBoxTipo";
            comboBoxTipo.Size = new Size(293, 28);
            comboBoxTipo.TabIndex = 34;
            comboBoxTipo.DropDown += comboBoxTipo_DropDown;
            comboBoxTipo.Validating += comboBoxTipo_Validating;
            // 
            // comboBoxMarca
            // 
            comboBoxMarca.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxMarca.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxMarca.FormattingEnabled = true;
            comboBoxMarca.Location = new Point(101, 61);
            comboBoxMarca.Margin = new Padding(3, 5, 3, 5);
            comboBoxMarca.Name = "comboBoxMarca";
            comboBoxMarca.Size = new Size(289, 28);
            comboBoxMarca.TabIndex = 35;
            comboBoxMarca.DropDown += comboBoxMarca_DropDown;
            comboBoxMarca.Validating += comboBoxMarca_Validating;
            // 
            // maskedTextBoxPlaca
            // 
            maskedTextBoxPlaca.CutCopyMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            maskedTextBoxPlaca.Location = new Point(273, 231);
            maskedTextBoxPlaca.Margin = new Padding(3, 5, 3, 5);
            maskedTextBoxPlaca.Mask = "AAAAAAA";
            maskedTextBoxPlaca.Name = "maskedTextBoxPlaca";
            maskedTextBoxPlaca.Size = new Size(117, 27);
            maskedTextBoxPlaca.TabIndex = 36;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 149);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 37;
            label1.Text = "Nome:";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(96, 145);
            textBoxNome.Margin = new Padding(3, 5, 3, 5);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(293, 27);
            textBoxNome.TabIndex = 38;
            // 
            // comboBoxIdCliente
            // 
            comboBoxIdCliente.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxIdCliente.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxIdCliente.FormattingEnabled = true;
            comboBoxIdCliente.Location = new Point(96, 20);
            comboBoxIdCliente.Margin = new Padding(3, 5, 3, 5);
            comboBoxIdCliente.Name = "comboBoxIdCliente";
            comboBoxIdCliente.Size = new Size(293, 28);
            comboBoxIdCliente.TabIndex = 39;
            comboBoxIdCliente.Validating += comboBoxIdCliente_Validating;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(432, 24);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 40;
            label2.Text = "Chassi:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(474, 63);
            label3.Name = "label3";
            label3.Size = new Size(135, 20);
            label3.TabIndex = 42;
            label3.Text = "Ano de Fabricação:";
            // 
            // dateTimePickerFab
            // 
            dateTimePickerFab.Format = DateTimePickerFormat.Short;
            dateTimePickerFab.Location = new Point(605, 59);
            dateTimePickerFab.Margin = new Padding(3, 5, 3, 5);
            dateTimePickerFab.Name = "dateTimePickerFab";
            dateTimePickerFab.Size = new Size(151, 27);
            dateTimePickerFab.TabIndex = 43;
            // 
            // maskedTextBoxQuilo
            // 
            maskedTextBoxQuilo.Location = new Point(217, 272);
            maskedTextBoxQuilo.Margin = new Padding(3, 5, 3, 5);
            maskedTextBoxQuilo.Name = "maskedTextBoxQuilo";
            maskedTextBoxQuilo.Size = new Size(173, 27);
            maskedTextBoxQuilo.TabIndex = 44;
            maskedTextBoxQuilo.Text = "1";
            maskedTextBoxQuilo.TextChanged += maskedTextBoxQuilo_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(103, 279);
            label4.Name = "label4";
            label4.Size = new Size(117, 20);
            label4.TabIndex = 45;
            label4.Text = "Quilometragem:";
            // 
            // maskedTextBoxMotor
            // 
            maskedTextBoxMotor.Location = new Point(583, 141);
            maskedTextBoxMotor.Margin = new Padding(3, 5, 3, 5);
            maskedTextBoxMotor.Name = "maskedTextBoxMotor";
            maskedTextBoxMotor.Size = new Size(173, 27);
            maskedTextBoxMotor.TabIndex = 46;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(527, 145);
            label5.Name = "label5";
            label5.Size = new Size(53, 20);
            label5.TabIndex = 47;
            label5.Text = "Motor:";
            // 
            // comboBoxCombustivel
            // 
            comboBoxCombustivel.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxCombustivel.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxCombustivel.FormattingEnabled = true;
            comboBoxCombustivel.Location = new Point(576, 183);
            comboBoxCombustivel.Margin = new Padding(3, 5, 3, 5);
            comboBoxCombustivel.Name = "comboBoxCombustivel";
            comboBoxCombustivel.Size = new Size(180, 28);
            comboBoxCombustivel.TabIndex = 48;
            comboBoxCombustivel.DropDown += comboBoxCombustivel_DropDown;
            comboBoxCombustivel.Validating += comboBoxCombustivel_Validating;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(481, 187);
            label6.Name = "label6";
            label6.Size = new Size(94, 20);
            label6.TabIndex = 49;
            label6.Text = "Combustível:";
            // 
            // dateTimePickerData
            // 
            dateTimePickerData.Enabled = false;
            dateTimePickerData.Format = DateTimePickerFormat.Short;
            dateTimePickerData.Location = new Point(605, 224);
            dateTimePickerData.Margin = new Padding(3, 5, 3, 5);
            dateTimePickerData.Name = "dateTimePickerData";
            dateTimePickerData.Size = new Size(151, 27);
            dateTimePickerData.TabIndex = 50;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(559, 232);
            label7.Name = "label7";
            label7.Size = new Size(44, 20);
            label7.TabIndex = 51;
            label7.Text = "Data:";
            // 
            // comboBoxSeguro
            // 
            comboBoxSeguro.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxSeguro.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxSeguro.FormattingEnabled = true;
            comboBoxSeguro.Location = new Point(576, 265);
            comboBoxSeguro.Margin = new Padding(3, 5, 3, 5);
            comboBoxSeguro.Name = "comboBoxSeguro";
            comboBoxSeguro.Size = new Size(180, 28);
            comboBoxSeguro.TabIndex = 52;
            comboBoxSeguro.DropDown += comboBoxSeguro_DropDown;
            comboBoxSeguro.Validating += comboBoxSeguro_Validating;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(515, 269);
            label8.Name = "label8";
            label8.Size = new Size(59, 20);
            label8.TabIndex = 53;
            label8.Text = "Seguro:";
            // 
            // maskedTextBoxChassi
            // 
            maskedTextBoxChassi.Location = new Point(487, 20);
            maskedTextBoxChassi.Margin = new Padding(2, 3, 2, 3);
            maskedTextBoxChassi.Mask = "0LLAAAAAA00000000";
            maskedTextBoxChassi.Name = "maskedTextBoxChassi";
            maskedTextBoxChassi.Size = new Size(269, 27);
            maskedTextBoxChassi.TabIndex = 56;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(396, 275);
            label9.Name = "label9";
            label9.Size = new Size(31, 20);
            label9.TabIndex = 57;
            label9.Text = "KM";
            // 
            // CadastroVeiculo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(779, 423);
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
            Margin = new Padding(3, 5, 3, 5);
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