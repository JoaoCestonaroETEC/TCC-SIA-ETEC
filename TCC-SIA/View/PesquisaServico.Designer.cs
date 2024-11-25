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
            tabControl1.Location = new Point(10, 9);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(519, 405);
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
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(3, 2, 3, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 2, 3, 2);
            tabPage1.Size = new Size(511, 377);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Pesquisar";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnDeletar
            // 
            btnDeletar.Location = new Point(392, 319);
            btnDeletar.Margin = new Padding(3, 2, 3, 2);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(114, 56);
            btnDeletar.TabIndex = 21;
            btnDeletar.Text = "Deletar";
            btnDeletar.UseVisualStyleBackColor = true;
            btnDeletar.Click += btnDeletar_Click;
            // 
            // btnSalvarAtulizar
            // 
            btnSalvarAtulizar.Location = new Point(264, 319);
            btnSalvarAtulizar.Margin = new Padding(3, 2, 3, 2);
            btnSalvarAtulizar.Name = "btnSalvarAtulizar";
            btnSalvarAtulizar.Size = new Size(114, 56);
            btnSalvarAtulizar.TabIndex = 20;
            btnSalvarAtulizar.Text = "Editar";
            btnSalvarAtulizar.UseVisualStyleBackColor = true;
            btnSalvarAtulizar.Click += btnSalvarAtulizar_Click;
            // 
            // buttonPesquisar
            // 
            buttonPesquisar.Location = new Point(5, 320);
            buttonPesquisar.Name = "buttonPesquisar";
            buttonPesquisar.Size = new Size(114, 56);
            buttonPesquisar.TabIndex = 19;
            buttonPesquisar.Text = "Pesquisar";
            buttonPesquisar.UseVisualStyleBackColor = true;
            buttonPesquisar.Click += buttonPesquisar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 10);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 18;
            label1.Text = "Pesquisar:";
            // 
            // textBoxPesquisar
            // 
            textBoxPesquisar.Location = new Point(68, 7);
            textBoxPesquisar.Name = "textBoxPesquisar";
            textBoxPesquisar.Size = new Size(438, 23);
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
            dataGridViewPesquisar.Location = new Point(5, 38);
            dataGridViewPesquisar.MultiSelect = false;
            dataGridViewPesquisar.Name = "dataGridViewPesquisar";
            dataGridViewPesquisar.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewPesquisar.RowHeadersVisible = false;
            dataGridViewPesquisar.RowHeadersWidth = 51;
            dataGridViewPesquisar.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewPesquisar.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridViewPesquisar.Size = new Size(500, 276);
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
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(3, 2, 3, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 2, 3, 2);
            tabPage2.Size = new Size(511, 377);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Editar";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonDesign1
            // 
            buttonDesign1.BackColor = Color.White;
            buttonDesign1.FlatAppearance.BorderColor = SystemColors.HotTrack;
            buttonDesign1.FlatStyle = FlatStyle.Flat;
            buttonDesign1.Location = new Point(374, 319);
            buttonDesign1.Margin = new Padding(3, 2, 3, 2);
            buttonDesign1.Name = "buttonDesign1";
            buttonDesign1.Size = new Size(132, 57);
            buttonDesign1.TabIndex = 104;
            buttonDesign1.Text = "Cancelar";
            buttonDesign1.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(396, 8);
            label7.Name = "label7";
            label7.Size = new Size(21, 15);
            label7.TabIndex = 103;
            label7.Text = "ID:";
            // 
            // maskedTextBoxID
            // 
            maskedTextBoxID.Enabled = false;
            maskedTextBoxID.Location = new Point(424, 5);
            maskedTextBoxID.Margin = new Padding(3, 2, 3, 2);
            maskedTextBoxID.Name = "maskedTextBoxID";
            maskedTextBoxID.Size = new Size(51, 23);
            maskedTextBoxID.TabIndex = 102;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 84);
            label6.Name = "label6";
            label6.Size = new Size(73, 15);
            label6.TabIndex = 101;
            label6.Text = "Funcionário:";
            // 
            // buttonSalvarA
            // 
            buttonSalvarA.FlatAppearance.BorderSize = 0;
            buttonSalvarA.FlatStyle = FlatStyle.Flat;
            buttonSalvarA.Location = new Point(5, 319);
            buttonSalvarA.Margin = new Padding(3, 2, 3, 2);
            buttonSalvarA.Name = "buttonSalvarA";
            buttonSalvarA.Size = new Size(130, 57);
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
            comboBoxFunc.Location = new Point(99, 82);
            comboBoxFunc.Margin = new Padding(3, 2, 3, 2);
            comboBoxFunc.Name = "comboBoxFunc";
            comboBoxFunc.Size = new Size(236, 23);
            comboBoxFunc.TabIndex = 100;
            comboBoxFunc.DropDown += comboBoxFunc_DropDown;
            // 
            // richTextBoxDesc
            // 
            richTextBoxDesc.Location = new Point(98, 117);
            richTextBoxDesc.Name = "richTextBoxDesc";
            richTextBoxDesc.Size = new Size(298, 186);
            richTextBoxDesc.TabIndex = 95;
            richTextBoxDesc.Text = "";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(340, 30);
            label11.Name = "label11";
            label11.Size = new Size(20, 15);
            label11.TabIndex = 99;
            label11.Text = "R$";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(47, 8);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 91;
            label5.Text = "Nome:";
            // 
            // dateTimePickerGarantia
            // 
            dateTimePickerGarantia.Format = DateTimePickerFormat.Short;
            dateTimePickerGarantia.Location = new Point(98, 57);
            dateTimePickerGarantia.Margin = new Padding(3, 2, 3, 2);
            dateTimePickerGarantia.Name = "dateTimePickerGarantia";
            dateTimePickerGarantia.Size = new Size(107, 23);
            dateTimePickerGarantia.TabIndex = 98;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 34);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 92;
            label3.Text = "Valor:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 61);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 97;
            label2.Text = "Garantia:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 117);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 93;
            label4.Text = "Descrição:";
            // 
            // maskedTextBoxValor
            // 
            maskedTextBoxValor.CutCopyMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            maskedTextBoxValor.Location = new Point(98, 32);
            maskedTextBoxValor.Name = "maskedTextBoxValor";
            maskedTextBoxValor.Size = new Size(236, 23);
            maskedTextBoxValor.TabIndex = 96;
            maskedTextBoxValor.Text = "0.00";
            maskedTextBoxValor.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            maskedTextBoxValor.TextChanged += maskedTextBoxValor_TextChanged;
            maskedTextBoxValor.KeyPress += maskedTextBoxValor_KeyPress;
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(98, 5);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(236, 23);
            textBoxNome.TabIndex = 94;
            // 
            // PesquisaServico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 423);
            Controls.Add(tabControl1);
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