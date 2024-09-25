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
            maskedTextBoxID = new MaskedTextBox();
            label6 = new Label();
            buttonSalvarA = new Button();
            dateTimePickerGarantia = new DateTimePicker();
            label2 = new Label();
            maskedTextBoxValor = new MaskedTextBox();
            richTextBoxDesc = new RichTextBox();
            textBoxNome = new TextBox();
            label4 = new Label();
            label3 = new Label();
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
            dataGridViewPesquisar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPesquisar.Location = new Point(6, 50);
            dataGridViewPesquisar.Margin = new Padding(3, 4, 3, 4);
            dataGridViewPesquisar.Name = "dataGridViewPesquisar";
            dataGridViewPesquisar.RowHeadersWidth = 51;
            dataGridViewPesquisar.Size = new Size(572, 368);
            dataGridViewPesquisar.TabIndex = 16;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(maskedTextBoxID);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(buttonSalvarA);
            tabPage2.Controls.Add(dateTimePickerGarantia);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(maskedTextBoxValor);
            tabPage2.Controls.Add(richTextBoxDesc);
            tabPage2.Controls.Add(textBoxNome);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label5);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(585, 507);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Editar";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // maskedTextBoxID
            // 
            maskedTextBoxID.Enabled = false;
            maskedTextBoxID.Location = new Point(417, 18);
            maskedTextBoxID.Name = "maskedTextBoxID";
            maskedTextBoxID.Size = new Size(125, 27);
            maskedTextBoxID.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(384, 21);
            label6.Name = "label6";
            label6.Size = new Size(27, 20);
            label6.TabIndex = 20;
            label6.Text = "ID:";
            // 
            // buttonSalvarA
            // 
            buttonSalvarA.Location = new Point(22, 409);
            buttonSalvarA.Name = "buttonSalvarA";
            buttonSalvarA.Size = new Size(149, 76);
            buttonSalvarA.TabIndex = 19;
            buttonSalvarA.Text = "Salvar";
            buttonSalvarA.UseVisualStyleBackColor = true;
            buttonSalvarA.Click += buttonSalvarA_Click;
            // 
            // dateTimePickerGarantia
            // 
            dateTimePickerGarantia.Format = DateTimePickerFormat.Short;
            dateTimePickerGarantia.Location = new Point(93, 95);
            dateTimePickerGarantia.Name = "dateTimePickerGarantia";
            dateTimePickerGarantia.Size = new Size(122, 27);
            dateTimePickerGarantia.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 95);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 17;
            label2.Text = "Garantia:";
            // 
            // maskedTextBoxValor
            // 
            maskedTextBoxValor.Location = new Point(93, 55);
            maskedTextBoxValor.Margin = new Padding(3, 4, 3, 4);
            maskedTextBoxValor.Name = "maskedTextBoxValor";
            maskedTextBoxValor.Size = new Size(269, 27);
            maskedTextBoxValor.TabIndex = 16;
            // 
            // richTextBoxDesc
            // 
            richTextBoxDesc.Location = new Point(93, 129);
            richTextBoxDesc.Margin = new Padding(3, 4, 3, 4);
            richTextBoxDesc.Name = "richTextBoxDesc";
            richTextBoxDesc.Size = new Size(449, 244);
            richTextBoxDesc.TabIndex = 15;
            richTextBoxDesc.Text = "";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(93, 16);
            textBoxNome.Margin = new Padding(3, 4, 3, 4);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(269, 27);
            textBoxNome.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 133);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 13;
            label4.Text = "Descrição:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 59);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 12;
            label3.Text = "Valor:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(37, 20);
            label5.Name = "label5";
            label5.Size = new Size(53, 20);
            label5.TabIndex = 11;
            label5.Text = "Nome:";
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
        private DateTimePicker dateTimePickerGarantia;
        private Label label2;
        private MaskedTextBox maskedTextBoxValor;
        private RichTextBox richTextBoxDesc;
        private TextBox textBoxNome;
        private Label label4;
        private Label label3;
        private Label label5;
        private MaskedTextBox maskedTextBoxID;
        private Label label6;
    }
}