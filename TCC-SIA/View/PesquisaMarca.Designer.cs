namespace TCC_SIA.View
{
    partial class PesquisaMarca
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
            buttonEditar = new Model.ButtonDesign();
            comboBoxTipo = new ComboBox();
            label3 = new Label();
            buttonPesquisar = new Button();
            label1 = new Label();
            textBoxPesquisar = new TextBox();
            dataGridViewPesquisar = new DataGridView();
            tabPage2 = new TabPage();
            maskedTextBoxID = new MaskedTextBox();
            label6 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            textBoxNome = new TextBox();
            buttonSalvarA = new Button();
            richTextBoxDesc = new RichTextBox();
            label4 = new Label();
            label5 = new Label();
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
            tabControl1.Size = new Size(608, 537);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(buttonEditar);
            tabPage1.Controls.Add(comboBoxTipo);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(buttonPesquisar);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(textBoxPesquisar);
            tabPage1.Controls.Add(dataGridViewPesquisar);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(600, 504);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Pesquisar";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonEditar
            // 
            buttonEditar.BackColor = Color.White;
            buttonEditar.FlatAppearance.BorderSize = 0;
            buttonEditar.FlatStyle = FlatStyle.Flat;
            buttonEditar.Location = new Point(203, 394);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(136, 95);
            buttonEditar.TabIndex = 32;
            buttonEditar.Text = "Editar";
            buttonEditar.UseVisualStyleBackColor = false;
            buttonEditar.Click += buttonEditar_Click;
            // 
            // comboBoxTipo
            // 
            comboBoxTipo.FormattingEnabled = true;
            comboBoxTipo.Items.AddRange(new object[] { "Peças Automotívas", "Óleos lubrificantes", "Pneus", "Ferramentas e Equipamentos para oficinas", "Veiculos", "Outro" });
            comboBoxTipo.Location = new Point(455, 427);
            comboBoxTipo.Margin = new Padding(3, 4, 3, 4);
            comboBoxTipo.Name = "comboBoxTipo";
            comboBoxTipo.Size = new Size(138, 28);
            comboBoxTipo.TabIndex = 30;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(410, 431);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 29;
            label3.Text = "Tipo:";
            // 
            // buttonPesquisar
            // 
            buttonPesquisar.Location = new Point(16, 393);
            buttonPesquisar.Margin = new Padding(3, 4, 3, 4);
            buttonPesquisar.Name = "buttonPesquisar";
            buttonPesquisar.Size = new Size(136, 95);
            buttonPesquisar.TabIndex = 28;
            buttonPesquisar.Text = "Pesquisar";
            buttonPesquisar.UseVisualStyleBackColor = true;
            buttonPesquisar.Click += buttonPesquisar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 14);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 27;
            label1.Text = "Pesquisar:";
            // 
            // textBoxPesquisar
            // 
            textBoxPesquisar.Location = new Point(82, 10);
            textBoxPesquisar.Margin = new Padding(3, 4, 3, 4);
            textBoxPesquisar.Name = "textBoxPesquisar";
            textBoxPesquisar.Size = new Size(511, 27);
            textBoxPesquisar.TabIndex = 26;
            // 
            // dataGridViewPesquisar
            // 
            dataGridViewPesquisar.AllowUserToAddRows = false;
            dataGridViewPesquisar.AllowUserToDeleteRows = false;
            dataGridViewPesquisar.AllowUserToResizeColumns = false;
            dataGridViewPesquisar.AllowUserToResizeRows = false;
            dataGridViewPesquisar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPesquisar.Location = new Point(7, 51);
            dataGridViewPesquisar.Margin = new Padding(3, 4, 3, 4);
            dataGridViewPesquisar.MultiSelect = false;
            dataGridViewPesquisar.Name = "dataGridViewPesquisar";
            dataGridViewPesquisar.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewPesquisar.RowHeadersVisible = false;
            dataGridViewPesquisar.RowHeadersWidth = 51;
            dataGridViewPesquisar.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewPesquisar.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridViewPesquisar.Size = new Size(587, 334);
            dataGridViewPesquisar.TabIndex = 25;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(maskedTextBoxID);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(comboBox1);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(textBoxNome);
            tabPage2.Controls.Add(buttonSalvarA);
            tabPage2.Controls.Add(richTextBoxDesc);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label5);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(600, 504);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Editar";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // maskedTextBoxID
            // 
            maskedTextBoxID.Enabled = false;
            maskedTextBoxID.Location = new Point(517, 24);
            maskedTextBoxID.Name = "maskedTextBoxID";
            maskedTextBoxID.Size = new Size(48, 27);
            maskedTextBoxID.TabIndex = 31;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(484, 27);
            label6.Name = "label6";
            label6.Size = new Size(27, 20);
            label6.TabIndex = 30;
            label6.Text = "ID:";
            // 
            // comboBox1
            // 
            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(438, 420);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(138, 28);
            comboBox1.TabIndex = 29;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(393, 424);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 28;
            label2.Text = "Tipo:";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(65, 24);
            textBoxNome.Margin = new Padding(3, 4, 3, 4);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(403, 27);
            textBoxNome.TabIndex = 27;
            // 
            // buttonSalvarA
            // 
            buttonSalvarA.Location = new Point(24, 385);
            buttonSalvarA.Name = "buttonSalvarA";
            buttonSalvarA.Size = new Size(171, 97);
            buttonSalvarA.TabIndex = 26;
            buttonSalvarA.Text = "Salvar";
            buttonSalvarA.UseVisualStyleBackColor = true;
            buttonSalvarA.Click += buttonSalvarA_Click;
            // 
            // richTextBoxDesc
            // 
            richTextBoxDesc.Location = new Point(89, 61);
            richTextBoxDesc.Name = "richTextBoxDesc";
            richTextBoxDesc.Size = new Size(476, 276);
            richTextBoxDesc.TabIndex = 25;
            richTextBoxDesc.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 64);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 24;
            label4.Text = "Descrição:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 27);
            label5.Name = "label5";
            label5.Size = new Size(53, 20);
            label5.TabIndex = 23;
            label5.Text = "Nome:";
            // 
            // PesquisaMarca
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 561);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PesquisaMarca";
            Text = "PesquisarMarca";
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
        private ComboBox comboBoxTipo;
        private Label label3;
        private Button buttonPesquisar;
        private Label label1;
        private TextBox textBoxPesquisar;
        private DataGridView dataGridViewPesquisar;
        private TabPage tabPage2;
        private ComboBox comboBox1;
        private Label label2;
        private TextBox textBoxNome;
        private Button buttonSalvarA;
        private RichTextBox richTextBoxDesc;
        private Label label4;
        private Label label5;
        private MaskedTextBox maskedTextBoxID;
        private Label label6;
        private Model.ButtonDesign buttonEditar;
    }
}