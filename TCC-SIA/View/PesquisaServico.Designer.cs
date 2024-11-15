namespace TCC_SIA.View
{
    partial class PesquisaServico
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
            btnSalvarAtulizar = new Button();
            buttonPesquisar = new Button();
            label1 = new Label();
            textBoxPesquisar = new TextBox();
            dataGridViewPesquisar = new DataGridView();
            tabPage2 = new TabPage();
            buttonDesign1 = new Model.ButtonDesign();
            label7 = new Label();
            maskedTextBoxID = new MaskedTextBox();
            label6 = new Label();
            buttonSalvarA = new Button();
            comboBoxFunc = new ComboBox();
            richTextBoxDesc = new RichTextBox();
            label11 = new Label();
            label5 = new Label();
            dateTimePickerGarantia = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            maskedTextBoxValor = new MaskedTextBox();
            textBoxNome = new TextBox();
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
            tabControl1.Size = new Size(593, 540);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnDeletar);
            tabPage1.Controls.Add(btnSalvarAtulizar);
            tabPage1.Controls.Add(buttonPesquisar);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(textBoxPesquisar);
            tabPage1.Controls.Add(dataGridViewPesquisar);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(585, 507);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Pesquisar";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnDeletar
            // 
            btnDeletar.Location = new Point(448, 425);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(130, 74);
            btnDeletar.TabIndex = 21;
            btnDeletar.Text = "Deletar";
            btnDeletar.UseVisualStyleBackColor = true;
            btnDeletar.Click += btnDeletar_Click;
            // 
            // btnSalvarAtulizar
            // 
            btnSalvarAtulizar.Location = new Point(302, 425);
            btnSalvarAtulizar.Name = "btnSalvarAtulizar";
            btnSalvarAtulizar.Size = new Size(130, 74);
            btnSalvarAtulizar.TabIndex = 20;
            btnSalvarAtulizar.Text = "Editar";
            btnSalvarAtulizar.UseVisualStyleBackColor = true;
            btnSalvarAtulizar.Click += btnSalvarAtulizar_Click;
            // 
            // buttonPesquisar
            // 
            buttonPesquisar.Location = new Point(6, 426);
            buttonPesquisar.Margin = new Padding(3, 4, 3, 4);
            buttonPesquisar.Name = "buttonPesquisar";
            buttonPesquisar.Size = new Size(130, 74);
            buttonPesquisar.TabIndex = 19;
            buttonPesquisar.Text = "Pesquisar";
            buttonPesquisar.UseVisualStyleBackColor = true;
            buttonPesquisar.Click += buttonPesquisar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 13);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 18;
            label1.Text = "Pesquisar:";
            // 
            // textBoxPesquisar
            // 
            textBoxPesquisar.Location = new Point(78, 9);
            textBoxPesquisar.Margin = new Padding(3, 4, 3, 4);
            textBoxPesquisar.Name = "textBoxPesquisar";
            textBoxPesquisar.Size = new Size(500, 27);
            textBoxPesquisar.TabIndex = 17;
            // 
            // dataGridViewPesquisar
            // 
            dataGridViewPesquisar.AllowUserToAddRows = false;
            dataGridViewPesquisar.AllowUserToDeleteRows = false;
            dataGridViewPesquisar.AllowUserToResizeColumns = false;
            dataGridViewPesquisar.AllowUserToResizeRows = false;
            dataGridViewPesquisar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPesquisar.ImeMode = ImeMode.NoControl;
            dataGridViewPesquisar.Location = new Point(6, 50);
            dataGridViewPesquisar.Margin = new Padding(3, 4, 3, 4);
            dataGridViewPesquisar.MultiSelect = false;
            dataGridViewPesquisar.Name = "dataGridViewPesquisar";
            dataGridViewPesquisar.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewPesquisar.RowHeadersVisible = false;
            dataGridViewPesquisar.RowHeadersWidth = 51;
            dataGridViewPesquisar.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewPesquisar.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridViewPesquisar.Size = new Size(572, 368);
            dataGridViewPesquisar.TabIndex = 16;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(buttonDesign1);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(maskedTextBoxID);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(buttonSalvarA);
            tabPage2.Controls.Add(comboBoxFunc);
            tabPage2.Controls.Add(richTextBoxDesc);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(dateTimePickerGarantia);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(maskedTextBoxValor);
            tabPage2.Controls.Add(textBoxNome);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(585, 507);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Editar";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonDesign1
            // 
            buttonDesign1.BackColor = Color.White;
            buttonDesign1.FlatAppearance.BorderColor = SystemColors.HotTrack;
            buttonDesign1.FlatStyle = FlatStyle.Flat;
            buttonDesign1.Location = new Point(428, 425);
            buttonDesign1.Name = "buttonDesign1";
            buttonDesign1.Size = new Size(151, 76);
            buttonDesign1.TabIndex = 104;
            buttonDesign1.Text = "Cancelar";
            buttonDesign1.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(452, 10);
            label7.Name = "label7";
            label7.Size = new Size(27, 20);
            label7.TabIndex = 103;
            label7.Text = "ID:";
            // 
            // maskedTextBoxID
            // 
            maskedTextBoxID.Enabled = false;
            maskedTextBoxID.Location = new Point(485, 7);
            maskedTextBoxID.Name = "maskedTextBoxID";
            maskedTextBoxID.Size = new Size(58, 27);
            maskedTextBoxID.TabIndex = 102;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 112);
            label6.Name = "label6";
            label6.Size = new Size(89, 20);
            label6.TabIndex = 101;
            label6.Text = "Funcionário:";
            // 
            // buttonSalvarA
            // 
            buttonSalvarA.Location = new Point(6, 425);
            buttonSalvarA.Name = "buttonSalvarA";
            buttonSalvarA.Size = new Size(149, 76);
            buttonSalvarA.TabIndex = 19;
            buttonSalvarA.Text = "Salvar";
            buttonSalvarA.UseVisualStyleBackColor = true;
            buttonSalvarA.Click += buttonSalvarA_Click;
            // 
            // comboBoxFunc
            // 
            comboBoxFunc.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxFunc.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxFunc.FormattingEnabled = true;
            comboBoxFunc.Location = new Point(113, 109);
            comboBoxFunc.Name = "comboBoxFunc";
            comboBoxFunc.Size = new Size(269, 28);
            comboBoxFunc.TabIndex = 100;
            // 
            // richTextBoxDesc
            // 
            richTextBoxDesc.Location = new Point(112, 156);
            richTextBoxDesc.Margin = new Padding(3, 4, 3, 4);
            richTextBoxDesc.Name = "richTextBoxDesc";
            richTextBoxDesc.Size = new Size(340, 246);
            richTextBoxDesc.TabIndex = 95;
            richTextBoxDesc.Text = "";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(388, 40);
            label11.Name = "label11";
            label11.Size = new Size(26, 20);
            label11.TabIndex = 99;
            label11.Text = "R$";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(54, 10);
            label5.Name = "label5";
            label5.Size = new Size(53, 20);
            label5.TabIndex = 91;
            label5.Text = "Nome:";
            // 
            // dateTimePickerGarantia
            // 
            dateTimePickerGarantia.Format = DateTimePickerFormat.Short;
            dateTimePickerGarantia.Location = new Point(112, 76);
            dateTimePickerGarantia.Name = "dateTimePickerGarantia";
            dateTimePickerGarantia.Size = new Size(122, 27);
            dateTimePickerGarantia.TabIndex = 98;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(60, 45);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 92;
            label3.Text = "Valor:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 81);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 97;
            label2.Text = "Garantia:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 156);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 93;
            label4.Text = "Descrição:";
            // 
            // maskedTextBoxValor
            // 
            maskedTextBoxValor.CutCopyMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            maskedTextBoxValor.Location = new Point(112, 42);
            maskedTextBoxValor.Margin = new Padding(3, 4, 3, 4);
            maskedTextBoxValor.Name = "maskedTextBoxValor";
            maskedTextBoxValor.Size = new Size(269, 27);
            maskedTextBoxValor.TabIndex = 96;
            maskedTextBoxValor.Text = "0.00";
            maskedTextBoxValor.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            maskedTextBoxValor.TextChanged += maskedTextBoxValor_TextChanged;
            maskedTextBoxValor.KeyPress += maskedTextBoxValor_KeyPress;
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(112, 7);
            textBoxNome.Margin = new Padding(3, 4, 3, 4);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(269, 27);
            textBoxNome.TabIndex = 94;
            // 
            // PesquisaServico
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(607, 564);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PesquisaServico";
            Text = "PesquisaServico";
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
        private Button btnDeletar;
        private Button btnSalvarAtulizar;
        private Button buttonPesquisar;
        private Label label1;
        private TextBox textBoxPesquisar;
        private DataGridView dataGridViewPesquisar;
        private TabPage tabPage2;
        private Button buttonSalvarA;
        private Label label6;
        private ComboBox comboBoxFunc;
        private Label label11;
        private DateTimePicker dateTimePickerGarantia;
        private Label label2;
        private MaskedTextBox maskedTextBoxValor;
        private RichTextBox richTextBoxDesc;
        private TextBox textBoxNome;
        private Label label4;
        private Label label3;
        private Label label5;
        private Label label7;
        private MaskedTextBox maskedTextBoxID;
        private Model.ButtonDesign buttonDesign1;
    }
}