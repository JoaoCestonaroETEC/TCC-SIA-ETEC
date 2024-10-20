namespace TCC_SIA.View
{
    partial class PesquisaVeiculo
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            buttonEditar = new Button();
            buttonPesquisar = new Button();
            label1 = new Label();
            textBoxPesquisar = new TextBox();
            dataGridViewPesquisar = new DataGridView();
            tabPage2 = new TabPage();
            label9 = new Label();
            maskedTextBoxChassi = new MaskedTextBox();
            label8 = new Label();
            comboBoxSeguro = new ComboBox();
            label7 = new Label();
            dateTimePickerData = new DateTimePicker();
            label6 = new Label();
            comboBoxCombustivel = new ComboBox();
            label5 = new Label();
            maskedTextBoxMotor = new MaskedTextBox();
            label4 = new Label();
            maskedTextBoxQuilo = new MaskedTextBox();
            dateTimePickerFab = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            comboBoxIdCliente = new ComboBox();
            textBoxNome = new TextBox();
            label10 = new Label();
            maskedTextBoxPlaca = new MaskedTextBox();
            comboBoxMarca = new ComboBox();
            comboBoxTipo = new ComboBox();
            comboBoxCor = new ComboBox();
            textBoxModelo = new TextBox();
            labelTipo = new Label();
            labelPlaca = new Label();
            labelModelo = new Label();
            labelCpf = new Label();
            labelMarca = new Label();
            labelCor = new Label();
            buttonSalvarA = new Button();
            maskedTextBoxID = new MaskedTextBox();
            label11 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPesquisar).BeginInit();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(714, 547);
            tabControl1.TabIndex = 20;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(buttonEditar);
            tabPage1.Controls.Add(buttonPesquisar);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(textBoxPesquisar);
            tabPage1.Controls.Add(dataGridViewPesquisar);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(706, 514);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Pesquisar";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonEditar
            // 
            buttonEditar.Location = new Point(564, 402);
            buttonEditar.Margin = new Padding(3, 4, 3, 4);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(136, 95);
            buttonEditar.TabIndex = 24;
            buttonEditar.Text = "Editar";
            buttonEditar.UseVisualStyleBackColor = true;
            buttonEditar.Click += buttonEditar_Click;
            // 
            // buttonPesquisar
            // 
            buttonPesquisar.Location = new Point(6, 402);
            buttonPesquisar.Margin = new Padding(3, 4, 3, 4);
            buttonPesquisar.Name = "buttonPesquisar";
            buttonPesquisar.Size = new Size(136, 95);
            buttonPesquisar.TabIndex = 23;
            buttonPesquisar.Text = "Pesquisar";
            buttonPesquisar.UseVisualStyleBackColor = true;
            buttonPesquisar.Click += buttonPesquisar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 10);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 22;
            label1.Text = "Pesquisar:";
            // 
            // textBoxPesquisar
            // 
            textBoxPesquisar.Location = new Point(85, 7);
            textBoxPesquisar.Margin = new Padding(3, 4, 3, 4);
            textBoxPesquisar.Name = "textBoxPesquisar";
            textBoxPesquisar.Size = new Size(615, 27);
            textBoxPesquisar.TabIndex = 21;
            // 
            // dataGridViewPesquisar
            // 
            dataGridViewPesquisar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPesquisar.Location = new Point(6, 49);
            dataGridViewPesquisar.Margin = new Padding(3, 4, 3, 4);
            dataGridViewPesquisar.Name = "dataGridViewPesquisar";
            dataGridViewPesquisar.RowHeadersWidth = 51;
            dataGridViewPesquisar.Size = new Size(694, 345);
            dataGridViewPesquisar.TabIndex = 20;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(maskedTextBoxID);
            tabPage2.Controls.Add(buttonSalvarA);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(maskedTextBoxChassi);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(comboBoxSeguro);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(dateTimePickerData);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(comboBoxCombustivel);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(maskedTextBoxMotor);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(maskedTextBoxQuilo);
            tabPage2.Controls.Add(dateTimePickerFab);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(comboBoxIdCliente);
            tabPage2.Controls.Add(textBoxNome);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(maskedTextBoxPlaca);
            tabPage2.Controls.Add(comboBoxMarca);
            tabPage2.Controls.Add(comboBoxTipo);
            tabPage2.Controls.Add(comboBoxCor);
            tabPage2.Controls.Add(textBoxModelo);
            tabPage2.Controls.Add(labelTipo);
            tabPage2.Controls.Add(labelPlaca);
            tabPage2.Controls.Add(labelModelo);
            tabPage2.Controls.Add(labelCpf);
            tabPage2.Controls.Add(labelMarca);
            tabPage2.Controls.Add(labelCor);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(706, 514);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Editar";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(369, 276);
            label9.Name = "label9";
            label9.Size = new Size(31, 20);
            label9.TabIndex = 86;
            label9.Text = "KM";
            // 
            // maskedTextBoxChassi
            // 
            maskedTextBoxChassi.Location = new Point(70, 315);
            maskedTextBoxChassi.Margin = new Padding(2, 3, 2, 3);
            maskedTextBoxChassi.Mask = "0LLAAAAAA00000000";
            maskedTextBoxChassi.Name = "maskedTextBoxChassi";
            maskedTextBoxChassi.Size = new Size(269, 27);
            maskedTextBoxChassi.TabIndex = 85;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(416, 183);
            label8.Name = "label8";
            label8.Size = new Size(59, 20);
            label8.TabIndex = 84;
            label8.Text = "Seguro:";
            // 
            // comboBoxSeguro
            // 
            comboBoxSeguro.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxSeguro.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxSeguro.FormattingEnabled = true;
            comboBoxSeguro.Location = new Point(486, 184);
            comboBoxSeguro.Margin = new Padding(3, 5, 3, 5);
            comboBoxSeguro.Name = "comboBoxSeguro";
            comboBoxSeguro.Size = new Size(180, 28);
            comboBoxSeguro.TabIndex = 83;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(416, 147);
            label7.Name = "label7";
            label7.Size = new Size(44, 20);
            label7.TabIndex = 82;
            label7.Text = "Data:";
            // 
            // dateTimePickerData
            // 
            dateTimePickerData.Enabled = false;
            dateTimePickerData.Format = DateTimePickerFormat.Short;
            dateTimePickerData.Location = new Point(471, 140);
            dateTimePickerData.Margin = new Padding(3, 5, 3, 5);
            dateTimePickerData.Name = "dateTimePickerData";
            dateTimePickerData.Size = new Size(151, 27);
            dateTimePickerData.TabIndex = 81;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(416, 105);
            label6.Name = "label6";
            label6.Size = new Size(94, 20);
            label6.TabIndex = 80;
            label6.Text = "Combustível:";
            // 
            // comboBoxCombustivel
            // 
            comboBoxCombustivel.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxCombustivel.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxCombustivel.FormattingEnabled = true;
            comboBoxCombustivel.Location = new Point(516, 101);
            comboBoxCombustivel.Margin = new Padding(3, 5, 3, 5);
            comboBoxCombustivel.Name = "comboBoxCombustivel";
            comboBoxCombustivel.Size = new Size(180, 28);
            comboBoxCombustivel.TabIndex = 79;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(416, 63);
            label5.Name = "label5";
            label5.Size = new Size(53, 20);
            label5.TabIndex = 78;
            label5.Text = "Motor:";
            // 
            // maskedTextBoxMotor
            // 
            maskedTextBoxMotor.Location = new Point(475, 60);
            maskedTextBoxMotor.Margin = new Padding(3, 5, 3, 5);
            maskedTextBoxMotor.Name = "maskedTextBoxMotor";
            maskedTextBoxMotor.Size = new Size(173, 27);
            maskedTextBoxMotor.TabIndex = 77;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(74, 276);
            label4.Name = "label4";
            label4.Size = new Size(117, 20);
            label4.TabIndex = 76;
            label4.Text = "Quilometragem:";
            // 
            // maskedTextBoxQuilo
            // 
            maskedTextBoxQuilo.Location = new Point(188, 269);
            maskedTextBoxQuilo.Margin = new Padding(3, 5, 3, 5);
            maskedTextBoxQuilo.Name = "maskedTextBoxQuilo";
            maskedTextBoxQuilo.Size = new Size(173, 27);
            maskedTextBoxQuilo.TabIndex = 75;
            maskedTextBoxQuilo.Text = "1";
            // 
            // dateTimePickerFab
            // 
            dateTimePickerFab.Format = DateTimePickerFormat.Short;
            dateTimePickerFab.Location = new Point(188, 354);
            dateTimePickerFab.Margin = new Padding(3, 5, 3, 5);
            dateTimePickerFab.Name = "dateTimePickerFab";
            dateTimePickerFab.Size = new Size(151, 27);
            dateTimePickerFab.TabIndex = 74;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 358);
            label3.Name = "label3";
            label3.Size = new Size(135, 20);
            label3.TabIndex = 73;
            label3.Text = "Ano de Fabricação:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 319);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 72;
            label2.Text = "Chassi:";
            // 
            // comboBoxIdCliente
            // 
            comboBoxIdCliente.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxIdCliente.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxIdCliente.FormattingEnabled = true;
            comboBoxIdCliente.Location = new Point(64, 18);
            comboBoxIdCliente.Margin = new Padding(3, 5, 3, 5);
            comboBoxIdCliente.Name = "comboBoxIdCliente";
            comboBoxIdCliente.Size = new Size(293, 28);
            comboBoxIdCliente.TabIndex = 71;
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(64, 142);
            textBoxNome.Margin = new Padding(3, 5, 3, 5);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(293, 27);
            textBoxNome.TabIndex = 70;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 145);
            label10.Name = "label10";
            label10.Size = new Size(53, 20);
            label10.TabIndex = 69;
            label10.Text = "Nome:";
            // 
            // maskedTextBoxPlaca
            // 
            maskedTextBoxPlaca.CutCopyMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            maskedTextBoxPlaca.Location = new Point(244, 228);
            maskedTextBoxPlaca.Margin = new Padding(3, 5, 3, 5);
            maskedTextBoxPlaca.Mask = "AAAAAAA";
            maskedTextBoxPlaca.Name = "maskedTextBoxPlaca";
            maskedTextBoxPlaca.Size = new Size(117, 27);
            maskedTextBoxPlaca.TabIndex = 68;
            // 
            // comboBoxMarca
            // 
            comboBoxMarca.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxMarca.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxMarca.FormattingEnabled = true;
            comboBoxMarca.Location = new Point(58, 63);
            comboBoxMarca.Margin = new Padding(3, 5, 3, 5);
            comboBoxMarca.Name = "comboBoxMarca";
            comboBoxMarca.Size = new Size(289, 28);
            comboBoxMarca.TabIndex = 67;
            // 
            // comboBoxTipo
            // 
            comboBoxTipo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxTipo.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxTipo.FormattingEnabled = true;
            comboBoxTipo.Location = new Point(54, 102);
            comboBoxTipo.Margin = new Padding(3, 5, 3, 5);
            comboBoxTipo.Name = "comboBoxTipo";
            comboBoxTipo.Size = new Size(293, 28);
            comboBoxTipo.TabIndex = 66;
            // 
            // comboBoxCor
            // 
            comboBoxCor.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxCor.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxCor.FormattingEnabled = true;
            comboBoxCor.Location = new Point(47, 183);
            comboBoxCor.Margin = new Padding(3, 5, 3, 5);
            comboBoxCor.Name = "comboBoxCor";
            comboBoxCor.Size = new Size(289, 28);
            comboBoxCor.TabIndex = 65;
            // 
            // textBoxModelo
            // 
            textBoxModelo.Location = new Point(486, 18);
            textBoxModelo.Margin = new Padding(3, 5, 3, 5);
            textBoxModelo.Name = "textBoxModelo";
            textBoxModelo.Size = new Size(173, 27);
            textBoxModelo.TabIndex = 64;
            // 
            // labelTipo
            // 
            labelTipo.AutoSize = true;
            labelTipo.Location = new Point(6, 105);
            labelTipo.Name = "labelTipo";
            labelTipo.Size = new Size(42, 20);
            labelTipo.TabIndex = 63;
            labelTipo.Text = "Tipo:";
            // 
            // labelPlaca
            // 
            labelPlaca.AutoSize = true;
            labelPlaca.Location = new Point(180, 232);
            labelPlaca.Name = "labelPlaca";
            labelPlaca.Size = new Size(47, 20);
            labelPlaca.TabIndex = 62;
            labelPlaca.Text = "Placa:";
            // 
            // labelModelo
            // 
            labelModelo.AutoSize = true;
            labelModelo.Location = new Point(416, 21);
            labelModelo.Name = "labelModelo";
            labelModelo.Size = new Size(64, 20);
            labelModelo.TabIndex = 61;
            labelModelo.Text = "Modelo:";
            // 
            // labelCpf
            // 
            labelCpf.AutoSize = true;
            labelCpf.Location = new Point(6, 21);
            labelCpf.Name = "labelCpf";
            labelCpf.Size = new Size(58, 20);
            labelCpf.TabIndex = 60;
            labelCpf.Text = "Cliente:";
            // 
            // labelMarca
            // 
            labelMarca.AutoSize = true;
            labelMarca.Location = new Point(6, 66);
            labelMarca.Name = "labelMarca";
            labelMarca.Size = new Size(53, 20);
            labelMarca.TabIndex = 59;
            labelMarca.Text = "Marca:";
            // 
            // labelCor
            // 
            labelCor.AutoSize = true;
            labelCor.Location = new Point(6, 187);
            labelCor.Name = "labelCor";
            labelCor.Size = new Size(35, 20);
            labelCor.TabIndex = 58;
            labelCor.Text = "Cor:";
            // 
            // buttonSalvarA
            // 
            buttonSalvarA.Location = new Point(6, 398);
            buttonSalvarA.Margin = new Padding(3, 4, 3, 4);
            buttonSalvarA.Name = "buttonSalvarA";
            buttonSalvarA.Size = new Size(136, 95);
            buttonSalvarA.TabIndex = 87;
            buttonSalvarA.Text = "Salvar";
            buttonSalvarA.UseVisualStyleBackColor = true;
            buttonSalvarA.Click += buttonSalvarA_Click;
            // 
            // maskedTextBoxID
            // 
            maskedTextBoxID.Enabled = false;
            maskedTextBoxID.Location = new Point(449, 229);
            maskedTextBoxID.Name = "maskedTextBoxID";
            maskedTextBoxID.Size = new Size(84, 27);
            maskedTextBoxID.TabIndex = 88;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(416, 235);
            label11.Name = "label11";
            label11.Size = new Size(27, 20);
            label11.TabIndex = 89;
            label11.Text = "ID:";
            // 
            // PesquisaVeiculo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(735, 571);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PesquisaVeiculo";
            Text = "PesquisaVeiculo";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPesquisar).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button buttonEditar;
        private Button buttonPesquisar;
        private Label label1;
        private TextBox textBoxPesquisar;
        private DataGridView dataGridViewPesquisar;
        private TabPage tabPage2;
        private Label label9;
        private MaskedTextBox maskedTextBoxChassi;
        private Label label8;
        private ComboBox comboBoxSeguro;
        private Label label7;
        private DateTimePicker dateTimePickerData;
        private Label label6;
        private ComboBox comboBoxCombustivel;
        private Label label5;
        private MaskedTextBox maskedTextBoxMotor;
        private Label label4;
        private MaskedTextBox maskedTextBoxQuilo;
        private DateTimePicker dateTimePickerFab;
        private Label label3;
        private Label label2;
        private ComboBox comboBoxIdCliente;
        private TextBox textBoxNome;
        private Label label10;
        private MaskedTextBox maskedTextBoxPlaca;
        private ComboBox comboBoxMarca;
        private ComboBox comboBoxTipo;
        private ComboBox comboBoxCor;
        private TextBox textBoxModelo;
        private Label labelTipo;
        private Label labelPlaca;
        private Label labelModelo;
        private Label labelCpf;
        private Label labelMarca;
        private Label labelCor;
        private Button buttonSalvarA;
        private Label label11;
        private MaskedTextBox maskedTextBoxID;
    }
}