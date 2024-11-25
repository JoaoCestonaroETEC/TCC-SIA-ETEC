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
            Deletar = new Button();
            buttonEditar = new Button();
            buttonPesquisar = new Button();
            label1 = new Label();
            textBoxPesquisar = new TextBox();
            dataGridViewPesquisar = new DataGridView();
            tabPage2 = new TabPage();
            label11 = new Label();
            maskedTextBoxID = new MaskedTextBox();
            buttonSalvarA = new Button();
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
            comboBoxIdClienteE = new ComboBox();
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
            tabControl1.Location = new Point(10, 9);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(625, 410);
            tabControl1.TabIndex = 20;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(Deletar);
            tabPage1.Controls.Add(buttonEditar);
            tabPage1.Controls.Add(buttonPesquisar);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(textBoxPesquisar);
            tabPage1.Controls.Add(dataGridViewPesquisar);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(3, 2, 3, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 2, 3, 2);
            tabPage1.Size = new Size(617, 382);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Pesquisar";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // Deletar
            // 
            Deletar.Location = new Point(348, 302);
            Deletar.Name = "Deletar";
            Deletar.Size = new Size(119, 71);
            Deletar.TabIndex = 25;
            Deletar.Text = "Deletar";
            Deletar.UseVisualStyleBackColor = true;
            Deletar.Click += Deletar_Click;
            // 
            // buttonEditar
            // 
            buttonEditar.Location = new Point(494, 302);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(119, 71);
            buttonEditar.TabIndex = 24;
            buttonEditar.Text = "Editar";
            buttonEditar.UseVisualStyleBackColor = true;
            buttonEditar.Click += buttonEditar_Click;
            // 
            // buttonPesquisar
            // 
            buttonPesquisar.Location = new Point(5, 302);
            buttonPesquisar.Name = "buttonPesquisar";
            buttonPesquisar.Size = new Size(119, 71);
            buttonPesquisar.TabIndex = 23;
            buttonPesquisar.Text = "Pesquisar";
            buttonPesquisar.UseVisualStyleBackColor = true;
            buttonPesquisar.Click += buttonPesquisar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 8);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 22;
            label1.Text = "Pesquisar:";
            // 
            // textBoxPesquisar
            // 
            textBoxPesquisar.Location = new Point(74, 5);
            textBoxPesquisar.Name = "textBoxPesquisar";
            textBoxPesquisar.Size = new Size(539, 23);
            textBoxPesquisar.TabIndex = 21;
            // 
            // dataGridViewPesquisar
            // 
            dataGridViewPesquisar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPesquisar.Location = new Point(5, 37);
            dataGridViewPesquisar.Name = "dataGridViewPesquisar";
            dataGridViewPesquisar.RowHeadersWidth = 51;
            dataGridViewPesquisar.Size = new Size(607, 259);
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
            tabPage2.Controls.Add(comboBoxIdClienteE);
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
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(3, 2, 3, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 2, 3, 2);
            tabPage2.Size = new Size(617, 382);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Editar";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(366, 171);
            label11.Name = "label11";
            label11.Size = new Size(21, 15);
            label11.TabIndex = 89;
            label11.Text = "ID:";
            // 
            // maskedTextBoxID
            // 
            maskedTextBoxID.Enabled = false;
            maskedTextBoxID.Location = new Point(395, 167);
            maskedTextBoxID.Margin = new Padding(3, 2, 3, 2);
            maskedTextBoxID.Name = "maskedTextBoxID";
            maskedTextBoxID.Size = new Size(74, 23);
            maskedTextBoxID.TabIndex = 88;
            // 
            // buttonSalvarA
            // 
            buttonSalvarA.Location = new Point(6, 315);
            buttonSalvarA.Name = "buttonSalvarA";
            buttonSalvarA.Size = new Size(119, 62);
            buttonSalvarA.TabIndex = 87;
            buttonSalvarA.Text = "Salvar";
            buttonSalvarA.UseVisualStyleBackColor = true;
            buttonSalvarA.Click += buttonSalvarA_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(269, 204);
            label9.Name = "label9";
            label9.Size = new Size(25, 15);
            label9.TabIndex = 86;
            label9.Text = "KM";
            // 
            // maskedTextBoxChassi
            // 
            maskedTextBoxChassi.Location = new Point(58, 228);
            maskedTextBoxChassi.Margin = new Padding(2);
            maskedTextBoxChassi.Mask = "0LLAAAAAA00000000";
            maskedTextBoxChassi.Name = "maskedTextBoxChassi";
            maskedTextBoxChassi.Size = new Size(236, 23);
            maskedTextBoxChassi.TabIndex = 85;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(364, 137);
            label8.Name = "label8";
            label8.Size = new Size(47, 15);
            label8.TabIndex = 84;
            label8.Text = "Seguro:";
            // 
            // comboBoxSeguro
            // 
            comboBoxSeguro.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxSeguro.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxSeguro.FormattingEnabled = true;
            comboBoxSeguro.Location = new Point(425, 138);
            comboBoxSeguro.Margin = new Padding(3, 4, 3, 4);
            comboBoxSeguro.Name = "comboBoxSeguro";
            comboBoxSeguro.Size = new Size(158, 23);
            comboBoxSeguro.TabIndex = 83;
            comboBoxSeguro.DropDown += comboBoxSeguro_DropDown;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(364, 110);
            label7.Name = "label7";
            label7.Size = new Size(34, 15);
            label7.TabIndex = 82;
            label7.Text = "Data:";
            // 
            // dateTimePickerData
            // 
            dateTimePickerData.Enabled = false;
            dateTimePickerData.Format = DateTimePickerFormat.Short;
            dateTimePickerData.Location = new Point(412, 105);
            dateTimePickerData.Margin = new Padding(3, 4, 3, 4);
            dateTimePickerData.Name = "dateTimePickerData";
            dateTimePickerData.Size = new Size(133, 23);
            dateTimePickerData.TabIndex = 81;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(364, 79);
            label6.Name = "label6";
            label6.Size = new Size(77, 15);
            label6.TabIndex = 80;
            label6.Text = "Combustível:";
            // 
            // comboBoxCombustivel
            // 
            comboBoxCombustivel.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxCombustivel.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxCombustivel.FormattingEnabled = true;
            comboBoxCombustivel.Location = new Point(452, 76);
            comboBoxCombustivel.Margin = new Padding(3, 4, 3, 4);
            comboBoxCombustivel.Name = "comboBoxCombustivel";
            comboBoxCombustivel.Size = new Size(158, 23);
            comboBoxCombustivel.TabIndex = 79;
            comboBoxCombustivel.DropDown += comboBoxCombustivel_DropDown;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(364, 47);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 78;
            label5.Text = "Motor:";
            // 
            // maskedTextBoxMotor
            // 
            maskedTextBoxMotor.Location = new Point(416, 45);
            maskedTextBoxMotor.Margin = new Padding(3, 4, 3, 4);
            maskedTextBoxMotor.Name = "maskedTextBoxMotor";
            maskedTextBoxMotor.Size = new Size(152, 23);
            maskedTextBoxMotor.TabIndex = 77;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 204);
            label4.Name = "label4";
            label4.Size = new Size(94, 15);
            label4.TabIndex = 76;
            label4.Text = "Quilometragem:";
            // 
            // maskedTextBoxQuilo
            // 
            maskedTextBoxQuilo.Location = new Point(110, 199);
            maskedTextBoxQuilo.Margin = new Padding(3, 4, 3, 4);
            maskedTextBoxQuilo.Name = "maskedTextBoxQuilo";
            maskedTextBoxQuilo.Size = new Size(152, 23);
            maskedTextBoxQuilo.TabIndex = 75;
            maskedTextBoxQuilo.Text = "1";
            // 
            // dateTimePickerFab
            // 
            dateTimePickerFab.Format = DateTimePickerFormat.Short;
            dateTimePickerFab.Location = new Point(161, 258);
            dateTimePickerFab.Margin = new Padding(3, 4, 3, 4);
            dateTimePickerFab.Name = "dateTimePickerFab";
            dateTimePickerFab.Size = new Size(133, 23);
            dateTimePickerFab.TabIndex = 74;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 260);
            label3.Name = "label3";
            label3.Size = new Size(108, 15);
            label3.TabIndex = 73;
            label3.Text = "Ano de Fabricação:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 231);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 72;
            label2.Text = "Chassi:";
            // 
            // comboBoxIdClienteE
            // 
            comboBoxIdClienteE.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxIdClienteE.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxIdClienteE.FormattingEnabled = true;
            comboBoxIdClienteE.Location = new Point(56, 14);
            comboBoxIdClienteE.Margin = new Padding(3, 4, 3, 4);
            comboBoxIdClienteE.Name = "comboBoxIdClienteE";
            comboBoxIdClienteE.Size = new Size(228, 23);
            comboBoxIdClienteE.TabIndex = 71;
            comboBoxIdClienteE.DropDown += comboBoxIdClienteE_DropDown;
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(56, 106);
            textBoxNome.Margin = new Padding(3, 4, 3, 4);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(192, 23);
            textBoxNome.TabIndex = 70;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(5, 109);
            label10.Name = "label10";
            label10.Size = new Size(43, 15);
            label10.TabIndex = 69;
            label10.Text = "Nome:";
            // 
            // maskedTextBoxPlaca
            // 
            maskedTextBoxPlaca.CutCopyMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            maskedTextBoxPlaca.Location = new Point(65, 168);
            maskedTextBoxPlaca.Margin = new Padding(3, 4, 3, 4);
            maskedTextBoxPlaca.Mask = "AAAAAAA";
            maskedTextBoxPlaca.Name = "maskedTextBoxPlaca";
            maskedTextBoxPlaca.Size = new Size(103, 23);
            maskedTextBoxPlaca.TabIndex = 68;
            // 
            // comboBoxMarca
            // 
            comboBoxMarca.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxMarca.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxMarca.FormattingEnabled = true;
            comboBoxMarca.Location = new Point(51, 47);
            comboBoxMarca.Margin = new Padding(3, 4, 3, 4);
            comboBoxMarca.Name = "comboBoxMarca";
            comboBoxMarca.Size = new Size(132, 23);
            comboBoxMarca.TabIndex = 67;
            comboBoxMarca.DropDown += comboBoxMarca_DropDown;
            // 
            // comboBoxTipo
            // 
            comboBoxTipo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxTipo.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxTipo.FormattingEnabled = true;
            comboBoxTipo.Location = new Point(47, 76);
            comboBoxTipo.Margin = new Padding(3, 4, 3, 4);
            comboBoxTipo.Name = "comboBoxTipo";
            comboBoxTipo.Size = new Size(237, 23);
            comboBoxTipo.TabIndex = 66;
            comboBoxTipo.DropDown += comboBoxTipo_DropDown;
            // 
            // comboBoxCor
            // 
            comboBoxCor.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxCor.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxCor.FormattingEnabled = true;
            comboBoxCor.Location = new Point(56, 137);
            comboBoxCor.Margin = new Padding(3, 4, 3, 4);
            comboBoxCor.Name = "comboBoxCor";
            comboBoxCor.Size = new Size(127, 23);
            comboBoxCor.TabIndex = 65;
            comboBoxCor.DropDown += comboBoxCor_DropDown;
            // 
            // textBoxModelo
            // 
            textBoxModelo.Location = new Point(425, 14);
            textBoxModelo.Margin = new Padding(3, 4, 3, 4);
            textBoxModelo.Name = "textBoxModelo";
            textBoxModelo.Size = new Size(152, 23);
            textBoxModelo.TabIndex = 64;
            // 
            // labelTipo
            // 
            labelTipo.AutoSize = true;
            labelTipo.Location = new Point(5, 79);
            labelTipo.Name = "labelTipo";
            labelTipo.Size = new Size(33, 15);
            labelTipo.TabIndex = 63;
            labelTipo.Text = "Tipo:";
            // 
            // labelPlaca
            // 
            labelPlaca.AutoSize = true;
            labelPlaca.Location = new Point(9, 171);
            labelPlaca.Name = "labelPlaca";
            labelPlaca.Size = new Size(38, 15);
            labelPlaca.TabIndex = 62;
            labelPlaca.Text = "Placa:";
            // 
            // labelModelo
            // 
            labelModelo.AutoSize = true;
            labelModelo.Location = new Point(364, 16);
            labelModelo.Name = "labelModelo";
            labelModelo.Size = new Size(51, 15);
            labelModelo.TabIndex = 61;
            labelModelo.Text = "Modelo:";
            // 
            // labelCpf
            // 
            labelCpf.AutoSize = true;
            labelCpf.Location = new Point(5, 16);
            labelCpf.Name = "labelCpf";
            labelCpf.Size = new Size(47, 15);
            labelCpf.TabIndex = 60;
            labelCpf.Text = "Cliente:";
            // 
            // labelMarca
            // 
            labelMarca.AutoSize = true;
            labelMarca.Location = new Point(5, 50);
            labelMarca.Name = "labelMarca";
            labelMarca.Size = new Size(43, 15);
            labelMarca.TabIndex = 59;
            labelMarca.Text = "Marca:";
            // 
            // labelCor
            // 
            labelCor.AutoSize = true;
            labelCor.Location = new Point(5, 140);
            labelCor.Name = "labelCor";
            labelCor.Size = new Size(29, 15);
            labelCor.TabIndex = 58;
            labelCor.Text = "Cor:";
            // 
            // PesquisaVeiculo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(643, 428);
            Controls.Add(tabControl1);
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
        private ComboBox comboBoxIdClienteE;
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
        private Button Deletar;
    }
}