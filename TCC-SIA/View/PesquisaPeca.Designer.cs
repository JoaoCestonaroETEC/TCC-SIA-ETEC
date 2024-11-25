namespace TCC_SIA.View
{
    partial class PesquisaPeca
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
            btnDeletar = new Button();
            btnAtualizar = new Button();
            buttonPesquisar = new Button();
            label1 = new Label();
            textBoxPesquisar = new TextBox();
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
            tabControl1.Location = new Point(10, 9);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(705, 409);
            tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnDeletar);
            tabPage1.Controls.Add(btnAtualizar);
            tabPage1.Controls.Add(buttonPesquisar);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(textBoxPesquisar);
            tabPage1.Controls.Add(dataGridViewPesquisar);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(3, 2, 3, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 2, 3, 2);
            tabPage1.Size = new Size(697, 381);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Pesquisar";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnDeletar
            // 
            btnDeletar.Location = new Point(542, 316);
            btnDeletar.Margin = new Padding(3, 2, 3, 2);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(151, 55);
            btnDeletar.TabIndex = 21;
            btnDeletar.Text = "Deletar";
            btnDeletar.UseVisualStyleBackColor = true;
            btnDeletar.Click += btnDeletar_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(374, 316);
            btnAtualizar.Margin = new Padding(3, 2, 3, 2);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(151, 55);
            btnAtualizar.TabIndex = 20;
            btnAtualizar.Text = "Editar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // buttonPesquisar
            // 
            buttonPesquisar.Location = new Point(6, 316);
            buttonPesquisar.Name = "buttonPesquisar";
            buttonPesquisar.Size = new Size(151, 55);
            buttonPesquisar.TabIndex = 19;
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
            label1.TabIndex = 18;
            label1.Text = "Pesquisar:";
            // 
            // textBoxPesquisar
            // 
            textBoxPesquisar.Location = new Point(71, 5);
            textBoxPesquisar.Name = "textBoxPesquisar";
            textBoxPesquisar.Size = new Size(623, 23);
            textBoxPesquisar.TabIndex = 17;
            // 
            // dataGridViewPesquisar
            // 
            dataGridViewPesquisar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPesquisar.Location = new Point(5, 36);
            dataGridViewPesquisar.Name = "dataGridViewPesquisar";
            dataGridViewPesquisar.RowHeadersWidth = 51;
            dataGridViewPesquisar.Size = new Size(688, 274);
            dataGridViewPesquisar.TabIndex = 16;
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
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(3, 2, 3, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 2, 3, 2);
            tabPage2.Size = new Size(697, 381);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Editar";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // maskedTextBoxID
            // 
            maskedTextBoxID.Enabled = false;
            maskedTextBoxID.Location = new Point(129, 263);
            maskedTextBoxID.Margin = new Padding(3, 2, 3, 2);
            maskedTextBoxID.Name = "maskedTextBoxID";
            maskedTextBoxID.Size = new Size(83, 23);
            maskedTextBoxID.TabIndex = 86;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 263);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 85;
            label2.Text = "idPeça:";
            // 
            // btnSalvarA
            // 
            btnSalvarA.Location = new Point(14, 315);
            btnSalvarA.Margin = new Padding(3, 2, 3, 2);
            btnSalvarA.Name = "btnSalvarA";
            btnSalvarA.Size = new Size(116, 58);
            btnSalvarA.TabIndex = 84;
            btnSalvarA.Text = "Salvar";
            btnSalvarA.UseVisualStyleBackColor = true;
            btnSalvarA.Click += btnSalvarA_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(50, 134);
            label11.Name = "label11";
            label11.Size = new Size(54, 15);
            label11.TabIndex = 83;
            label11.Text = "Unidade:";
            // 
            // numericUpDownUnidade
            // 
            numericUpDownUnidade.Location = new Point(121, 130);
            numericUpDownUnidade.Maximum = new decimal(new int[] { 1215752192, 23, 0, 0 });
            numericUpDownUnidade.Name = "numericUpDownUnidade";
            numericUpDownUnidade.Size = new Size(209, 23);
            numericUpDownUnidade.TabIndex = 82;
            // 
            // dateTimePickerAquisicao
            // 
            dateTimePickerAquisicao.Format = DateTimePickerFormat.Short;
            dateTimePickerAquisicao.Location = new Point(129, 238);
            dateTimePickerAquisicao.Margin = new Padding(3, 2, 3, 2);
            dateTimePickerAquisicao.Name = "dateTimePickerAquisicao";
            dateTimePickerAquisicao.Size = new Size(189, 23);
            dateTimePickerAquisicao.TabIndex = 81;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(12, 240);
            label12.Name = "label12";
            label12.Size = new Size(105, 15);
            label12.TabIndex = 80;
            label12.Text = "Data de Aquisição:";
            // 
            // comboBoxFornecedor
            // 
            comboBoxFornecedor.FormattingEnabled = true;
            comboBoxFornecedor.Location = new Point(129, 208);
            comboBoxFornecedor.Margin = new Padding(3, 2, 3, 2);
            comboBoxFornecedor.Name = "comboBoxFornecedor";
            comboBoxFornecedor.Size = new Size(188, 23);
            comboBoxFornecedor.TabIndex = 79;
            comboBoxFornecedor.DropDown += comboBoxFornecedor_DropDown;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(50, 212);
            label13.Name = "label13";
            label13.Size = new Size(70, 15);
            label13.TabIndex = 78;
            label13.Text = "Fornecedor:";
            // 
            // comboBoxTipo
            // 
            comboBoxTipo.FormattingEnabled = true;
            comboBoxTipo.Location = new Point(118, 45);
            comboBoxTipo.Name = "comboBoxTipo";
            comboBoxTipo.Size = new Size(209, 23);
            comboBoxTipo.TabIndex = 77;
            comboBoxTipo.DropDown += comboBoxTipo_DropDown;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(76, 51);
            label14.Name = "label14";
            label14.Size = new Size(33, 15);
            label14.TabIndex = 76;
            label14.Text = "Tipo:";
            // 
            // comboBoxMarca
            // 
            comboBoxMarca.FormattingEnabled = true;
            comboBoxMarca.Location = new Point(118, 17);
            comboBoxMarca.Name = "comboBoxMarca";
            comboBoxMarca.Size = new Size(209, 23);
            comboBoxMarca.TabIndex = 75;
            comboBoxMarca.DropDown += comboBoxMarca_DropDown;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(50, 186);
            label15.Name = "label15";
            label15.Size = new Size(54, 15);
            label15.TabIndex = 74;
            label15.Text = "Garantia:";
            // 
            // dateTimePickerGarantia
            // 
            dateTimePickerGarantia.Format = DateTimePickerFormat.Short;
            dateTimePickerGarantia.Location = new Point(119, 182);
            dateTimePickerGarantia.Name = "dateTimePickerGarantia";
            dateTimePickerGarantia.Size = new Size(209, 23);
            dateTimePickerGarantia.TabIndex = 73;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(37, 160);
            label16.Name = "label16";
            label16.Size = new Size(72, 15);
            label16.TabIndex = 72;
            label16.Text = "Quantidade:";
            // 
            // numericUpDownQuant
            // 
            numericUpDownQuant.Location = new Point(121, 156);
            numericUpDownQuant.Maximum = new decimal(new int[] { 1215752192, 23, 0, 0 });
            numericUpDownQuant.Name = "numericUpDownQuant";
            numericUpDownQuant.Size = new Size(209, 23);
            numericUpDownQuant.TabIndex = 71;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(66, 22);
            label17.Name = "label17";
            label17.Size = new Size(43, 15);
            label17.TabIndex = 70;
            label17.Text = "Marca:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(73, 109);
            label18.Name = "label18";
            label18.Size = new Size(36, 15);
            label18.TabIndex = 69;
            label18.Text = "Valor:";
            // 
            // maskedTextBoxValor
            // 
            maskedTextBoxValor.Location = new Point(119, 104);
            maskedTextBoxValor.Name = "maskedTextBoxValor";
            maskedTextBoxValor.Size = new Size(209, 23);
            maskedTextBoxValor.TabIndex = 68;
            maskedTextBoxValor.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            maskedTextBoxValor.TextChanged += maskedTextBoxValor_TextChanged;
            maskedTextBoxValor.KeyPress += maskedTextBoxValor_KeyPress_1;
            // 
            // richTextBoxDesc
            // 
            richTextBoxDesc.Location = new Point(395, 19);
            richTextBoxDesc.Name = "richTextBoxDesc";
            richTextBoxDesc.Size = new Size(299, 267);
            richTextBoxDesc.TabIndex = 67;
            richTextBoxDesc.Text = "";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(328, 22);
            label19.Name = "label19";
            label19.Size = new Size(61, 15);
            label19.TabIndex = 66;
            label19.Text = "Descrição:";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(118, 74);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(209, 23);
            textBoxNome.TabIndex = 65;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(66, 80);
            label20.Name = "label20";
            label20.Size = new Size(43, 15);
            label20.TabIndex = 64;
            label20.Text = "Nome:";
            // 
            // PesquisaPeca
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(726, 427);
            Controls.Add(tabControl1);
            Name = "PesquisaPeca";
            Text = "PesquisarPeca";
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
        private TabPage tabPage2;
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
        private Button buttonPesquisar;
        private Label label1;
        private TextBox textBoxPesquisar;
        private DataGridView dataGridViewPesquisar;
        private Button btnSalvarA;
        private Button btnDeletar;
        private Button btnAtualizar;
        private MaskedTextBox maskedTextBoxID;
        private Label label2;
    }
}