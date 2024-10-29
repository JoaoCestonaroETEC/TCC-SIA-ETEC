namespace TCC_SIA.View
{
    partial class PesquisaPedido
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
            comboBoxVeiculo = new ComboBox();
            label3 = new Label();
            comboBoxCliente = new ComboBox();
            label1 = new Label();
            btnDeletar = new Button();
            btnAtualizar = new Button();
            buttonPesquisar = new Button();
            dataGridViewPesquisar = new DataGridView();
            tabPage2 = new TabPage();
            maskedTextBoxID = new MaskedTextBox();
            label2 = new Label();
            btnSalvarA = new Button();
            label11 = new Label();
            numericUpDownUnidade = new NumericUpDown();
            dateTimePickerAquisicao = new DateTimePicker();
            label12 = new Label();
            comboBoxFornecedor = new ComboBox();
            label13 = new Label();
            comboBoxTipo = new ComboBox();
            label14 = new Label();
            comboBoxMarca = new ComboBox();
            label15 = new Label();
            dateTimePickerGarantia = new DateTimePicker();
            label16 = new Label();
            numericUpDownQuant = new NumericUpDown();
            label17 = new Label();
            label18 = new Label();
            maskedTextBoxValor = new MaskedTextBox();
            richTextBoxDesc = new RichTextBox();
            label19 = new Label();
            textBoxNome = new TextBox();
            label20 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPesquisar).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownUnidade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuant).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(806, 545);
            tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(comboBoxVeiculo);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(comboBoxCliente);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(btnDeletar);
            tabPage1.Controls.Add(btnAtualizar);
            tabPage1.Controls.Add(buttonPesquisar);
            tabPage1.Controls.Add(dataGridViewPesquisar);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(798, 512);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Pesquisar";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // comboBoxVeiculo
            // 
            comboBoxVeiculo.FormattingEnabled = true;
            comboBoxVeiculo.Location = new Point(470, 11);
            comboBoxVeiculo.Name = "comboBoxVeiculo";
            comboBoxVeiculo.Size = new Size(322, 28);
            comboBoxVeiculo.TabIndex = 25;
            comboBoxVeiculo.DropDown += comboBoxVeiculo_DropDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(406, 14);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 24;
            label3.Text = "Veículo:";
            // 
            // comboBoxCliente
            // 
            comboBoxCliente.FormattingEnabled = true;
            comboBoxCliente.Location = new Point(70, 11);
            comboBoxCliente.Name = "comboBoxCliente";
            comboBoxCliente.Size = new Size(322, 28);
            comboBoxCliente.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 14);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 22;
            label1.Text = "Cliente:";
            // 
            // btnDeletar
            // 
            btnDeletar.Location = new Point(619, 422);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(173, 73);
            btnDeletar.TabIndex = 21;
            btnDeletar.Text = "Deletar";
            btnDeletar.UseVisualStyleBackColor = true;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(427, 422);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(173, 73);
            btnAtualizar.TabIndex = 20;
            btnAtualizar.Text = "Editar";
            btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // buttonPesquisar
            // 
            buttonPesquisar.Location = new Point(17, 422);
            buttonPesquisar.Margin = new Padding(3, 4, 3, 4);
            buttonPesquisar.Name = "buttonPesquisar";
            buttonPesquisar.Size = new Size(173, 73);
            buttonPesquisar.TabIndex = 19;
            buttonPesquisar.Text = "Pesquisar";
            buttonPesquisar.UseVisualStyleBackColor = true;
            buttonPesquisar.Click += buttonPesquisar_Click;
            // 
            // dataGridViewPesquisar
            // 
            dataGridViewPesquisar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPesquisar.Location = new Point(0, 49);
            dataGridViewPesquisar.Margin = new Padding(3, 4, 3, 4);
            dataGridViewPesquisar.Name = "dataGridViewPesquisar";
            dataGridViewPesquisar.RowHeadersWidth = 51;
            dataGridViewPesquisar.Size = new Size(786, 366);
            dataGridViewPesquisar.TabIndex = 16;
            dataGridViewPesquisar.CellClick += dataGridViewPesquisar_CellClick;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(maskedTextBoxID);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(btnSalvarA);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(numericUpDownUnidade);
            tabPage2.Controls.Add(dateTimePickerAquisicao);
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(comboBoxFornecedor);
            tabPage2.Controls.Add(label13);
            tabPage2.Controls.Add(comboBoxTipo);
            tabPage2.Controls.Add(label14);
            tabPage2.Controls.Add(comboBoxMarca);
            tabPage2.Controls.Add(label15);
            tabPage2.Controls.Add(dateTimePickerGarantia);
            tabPage2.Controls.Add(label16);
            tabPage2.Controls.Add(numericUpDownQuant);
            tabPage2.Controls.Add(label17);
            tabPage2.Controls.Add(label18);
            tabPage2.Controls.Add(maskedTextBoxValor);
            tabPage2.Controls.Add(richTextBoxDesc);
            tabPage2.Controls.Add(label19);
            tabPage2.Controls.Add(textBoxNome);
            tabPage2.Controls.Add(label20);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(798, 512);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Editar";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // maskedTextBoxID
            // 
            maskedTextBoxID.Enabled = false;
            maskedTextBoxID.Location = new Point(150, 369);
            maskedTextBoxID.Name = "maskedTextBoxID";
            maskedTextBoxID.Size = new Size(94, 27);
            maskedTextBoxID.TabIndex = 86;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(89, 372);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 85;
            label2.Text = "idPeça:";
            // 
            // btnSalvarA
            // 
            btnSalvarA.Location = new Point(16, 420);
            btnSalvarA.Name = "btnSalvarA";
            btnSalvarA.Size = new Size(132, 77);
            btnSalvarA.TabIndex = 84;
            btnSalvarA.Text = "Salvar";
            btnSalvarA.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(62, 200);
            label11.Name = "label11";
            label11.Size = new Size(68, 20);
            label11.TabIndex = 83;
            label11.Text = "Unidade:";
            // 
            // numericUpDownUnidade
            // 
            numericUpDownUnidade.Location = new Point(141, 192);
            numericUpDownUnidade.Margin = new Padding(3, 4, 3, 4);
            numericUpDownUnidade.Name = "numericUpDownUnidade";
            numericUpDownUnidade.Size = new Size(239, 27);
            numericUpDownUnidade.TabIndex = 82;
            // 
            // dateTimePickerAquisicao
            // 
            dateTimePickerAquisicao.Format = DateTimePickerFormat.Short;
            dateTimePickerAquisicao.Location = new Point(150, 336);
            dateTimePickerAquisicao.Name = "dateTimePickerAquisicao";
            dateTimePickerAquisicao.Size = new Size(215, 27);
            dateTimePickerAquisicao.TabIndex = 81;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(19, 342);
            label12.Name = "label12";
            label12.Size = new Size(134, 20);
            label12.TabIndex = 80;
            label12.Text = "Data de Aquisição:";
            // 
            // comboBoxFornecedor
            // 
            comboBoxFornecedor.FormattingEnabled = true;
            comboBoxFornecedor.Location = new Point(150, 296);
            comboBoxFornecedor.Name = "comboBoxFornecedor";
            comboBoxFornecedor.Size = new Size(214, 28);
            comboBoxFornecedor.TabIndex = 79;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(63, 305);
            label13.Name = "label13";
            label13.Size = new Size(87, 20);
            label13.TabIndex = 78;
            label13.Text = "Fornecedor:";
            // 
            // comboBoxTipo
            // 
            comboBoxTipo.FormattingEnabled = true;
            comboBoxTipo.Location = new Point(137, 79);
            comboBoxTipo.Margin = new Padding(3, 4, 3, 4);
            comboBoxTipo.Name = "comboBoxTipo";
            comboBoxTipo.Size = new Size(238, 28);
            comboBoxTipo.TabIndex = 77;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(92, 90);
            label14.Name = "label14";
            label14.Size = new Size(42, 20);
            label14.TabIndex = 76;
            label14.Text = "Tipo:";
            // 
            // comboBoxMarca
            // 
            comboBoxMarca.FormattingEnabled = true;
            comboBoxMarca.Location = new Point(137, 41);
            comboBoxMarca.Margin = new Padding(3, 4, 3, 4);
            comboBoxMarca.Name = "comboBoxMarca";
            comboBoxMarca.Size = new Size(238, 28);
            comboBoxMarca.TabIndex = 75;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(63, 269);
            label15.Name = "label15";
            label15.Size = new Size(68, 20);
            label15.TabIndex = 74;
            label15.Text = "Garantia:";
            // 
            // dateTimePickerGarantia
            // 
            dateTimePickerGarantia.Format = DateTimePickerFormat.Short;
            dateTimePickerGarantia.Location = new Point(138, 262);
            dateTimePickerGarantia.Margin = new Padding(3, 4, 3, 4);
            dateTimePickerGarantia.Name = "dateTimePickerGarantia";
            dateTimePickerGarantia.Size = new Size(238, 27);
            dateTimePickerGarantia.TabIndex = 73;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(48, 235);
            label16.Name = "label16";
            label16.Size = new Size(90, 20);
            label16.TabIndex = 72;
            label16.Text = "Quantidade:";
            // 
            // numericUpDownQuant
            // 
            numericUpDownQuant.Location = new Point(141, 227);
            numericUpDownQuant.Margin = new Padding(3, 4, 3, 4);
            numericUpDownQuant.Name = "numericUpDownQuant";
            numericUpDownQuant.Size = new Size(239, 27);
            numericUpDownQuant.TabIndex = 71;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(81, 51);
            label17.Name = "label17";
            label17.Size = new Size(53, 20);
            label17.TabIndex = 70;
            label17.Text = "Marca:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(89, 167);
            label18.Name = "label18";
            label18.Size = new Size(46, 20);
            label18.TabIndex = 69;
            label18.Text = "Valor:";
            // 
            // maskedTextBoxValor
            // 
            maskedTextBoxValor.Location = new Point(138, 157);
            maskedTextBoxValor.Margin = new Padding(3, 4, 3, 4);
            maskedTextBoxValor.Name = "maskedTextBoxValor";
            maskedTextBoxValor.Size = new Size(238, 27);
            maskedTextBoxValor.TabIndex = 68;
            maskedTextBoxValor.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // richTextBoxDesc
            // 
            richTextBoxDesc.Location = new Point(451, 41);
            richTextBoxDesc.Margin = new Padding(3, 4, 3, 4);
            richTextBoxDesc.Name = "richTextBoxDesc";
            richTextBoxDesc.Size = new Size(341, 446);
            richTextBoxDesc.TabIndex = 67;
            richTextBoxDesc.Text = "";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(381, 51);
            label19.Name = "label19";
            label19.Size = new Size(77, 20);
            label19.TabIndex = 66;
            label19.Text = "Descrição:";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(137, 118);
            textBoxNome.Margin = new Padding(3, 4, 3, 4);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(238, 27);
            textBoxNome.TabIndex = 65;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(81, 128);
            label20.Name = "label20";
            label20.Size = new Size(53, 20);
            label20.TabIndex = 64;
            label20.Text = "Nome:";
            // 
            // PesquisaPedido
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(830, 571);
            Controls.Add(tabControl1);
            Name = "PesquisaPedido";
            Text = "PesquisaPedido";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPesquisar).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownUnidade).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuant).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private ComboBox comboBoxVeiculo;
        private Label label3;
        private ComboBox comboBoxCliente;
        private Label label1;
        private Button btnDeletar;
        private Button btnAtualizar;
        private Button buttonPesquisar;
        private DataGridView dataGridViewPesquisar;
        private TabPage tabPage2;
        private MaskedTextBox maskedTextBoxID;
        private Label label2;
        private Button btnSalvarA;
        private Label label11;
        private NumericUpDown numericUpDownUnidade;
        private DateTimePicker dateTimePickerAquisicao;
        private Label label12;
        private ComboBox comboBoxFornecedor;
        private Label label13;
        private ComboBox comboBoxTipo;
        private Label label14;
        private ComboBox comboBoxMarca;
        private Label label15;
        private DateTimePicker dateTimePickerGarantia;
        private Label label16;
        private NumericUpDown numericUpDownQuant;
        private Label label17;
        private Label label18;
        private MaskedTextBox maskedTextBoxValor;
        private RichTextBox richTextBoxDesc;
        private Label label19;
        private TextBox textBoxNome;
        private Label label20;
    }
}