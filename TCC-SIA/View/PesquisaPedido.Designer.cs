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
            comboBoxVeiculoP = new ComboBox();
            comboBoxClienteP = new ComboBox();
            label6 = new Label();
            label9 = new Label();
            maskedTextBoxID = new MaskedTextBox();
            label5 = new Label();
            label7 = new Label();
            maskedTextBoxValorTotal = new MaskedTextBox();
            label8 = new Label();
            richTextBoxObs = new RichTextBox();
            dateTimePickerDataFim = new DateTimePicker();
            dateTimePickerDataInicio = new DateTimePicker();
            label4 = new Label();
            label2 = new Label();
            btnSalvarA = new Button();
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
            tabControl1.Size = new Size(705, 409);
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
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(3, 2, 3, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 2, 3, 2);
            tabPage1.Size = new Size(697, 381);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Pesquisar";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // comboBoxVeiculo
            // 
            comboBoxVeiculo.FormattingEnabled = true;
            comboBoxVeiculo.Location = new Point(411, 8);
            comboBoxVeiculo.Margin = new Padding(3, 2, 3, 2);
            comboBoxVeiculo.Name = "comboBoxVeiculo";
            comboBoxVeiculo.Size = new Size(282, 23);
            comboBoxVeiculo.TabIndex = 25;
            comboBoxVeiculo.DropDown += comboBoxVeiculo_DropDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(355, 10);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 24;
            label3.Text = "Veículo:";
            // 
            // comboBoxCliente
            // 
            comboBoxCliente.FormattingEnabled = true;
            comboBoxCliente.Location = new Point(61, 8);
            comboBoxCliente.Margin = new Padding(3, 2, 3, 2);
            comboBoxCliente.Name = "comboBoxCliente";
            comboBoxCliente.Size = new Size(282, 23);
            comboBoxCliente.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 10);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 22;
            label1.Text = "Cliente:";
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
            buttonPesquisar.Location = new Point(15, 316);
            buttonPesquisar.Name = "buttonPesquisar";
            buttonPesquisar.Size = new Size(151, 55);
            buttonPesquisar.TabIndex = 19;
            buttonPesquisar.Text = "Pesquisar";
            buttonPesquisar.UseVisualStyleBackColor = true;
            buttonPesquisar.Click += buttonPesquisar_Click;
            // 
            // dataGridViewPesquisar
            // 
            dataGridViewPesquisar.AllowUserToAddRows = false;
            dataGridViewPesquisar.AllowUserToDeleteRows = false;
            dataGridViewPesquisar.AllowUserToResizeColumns = false;
            dataGridViewPesquisar.AllowUserToResizeRows = false;
            dataGridViewPesquisar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPesquisar.Location = new Point(0, 37);
            dataGridViewPesquisar.Name = "dataGridViewPesquisar";
            dataGridViewPesquisar.RowHeadersVisible = false;
            dataGridViewPesquisar.RowHeadersWidth = 51;
            dataGridViewPesquisar.Size = new Size(688, 274);
            dataGridViewPesquisar.TabIndex = 16;
            dataGridViewPesquisar.CellClick += dataGridViewPesquisar_CellClick;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(comboBoxVeiculoP);
            tabPage2.Controls.Add(comboBoxClienteP);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(maskedTextBoxID);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(maskedTextBoxValorTotal);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(richTextBoxObs);
            tabPage2.Controls.Add(dateTimePickerDataFim);
            tabPage2.Controls.Add(dateTimePickerDataInicio);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(btnSalvarA);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(3, 2, 3, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 2, 3, 2);
            tabPage2.Size = new Size(697, 381);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Editar";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // comboBoxVeiculoP
            // 
            comboBoxVeiculoP.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxVeiculoP.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxVeiculoP.FormattingEnabled = true;
            comboBoxVeiculoP.Location = new Point(66, 151);
            comboBoxVeiculoP.Name = "comboBoxVeiculoP";
            comboBoxVeiculoP.Size = new Size(135, 23);
            comboBoxVeiculoP.TabIndex = 102;
            comboBoxVeiculoP.DropDown += comboBoxVeiculoP_DropDown;
            // 
            // comboBoxClienteP
            // 
            comboBoxClienteP.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxClienteP.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxClienteP.FormattingEnabled = true;
            comboBoxClienteP.Location = new Point(66, 117);
            comboBoxClienteP.Name = "comboBoxClienteP";
            comboBoxClienteP.Size = new Size(135, 23);
            comboBoxClienteP.TabIndex = 101;
            comboBoxClienteP.DropDown += comboBoxClienteP_DropDown;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 151);
            label6.Name = "label6";
            label6.Size = new Size(48, 15);
            label6.TabIndex = 100;
            label6.Text = "Veículo:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(16, 120);
            label9.Name = "label9";
            label9.Size = new Size(47, 15);
            label9.TabIndex = 99;
            label9.Text = "Cliente:";
            // 
            // maskedTextBoxID
            // 
            maskedTextBoxID.Enabled = false;
            maskedTextBoxID.Location = new Point(43, 92);
            maskedTextBoxID.Margin = new Padding(3, 2, 3, 2);
            maskedTextBoxID.Name = "maskedTextBoxID";
            maskedTextBoxID.Size = new Size(40, 23);
            maskedTextBoxID.TabIndex = 98;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 94);
            label5.Name = "label5";
            label5.Size = new Size(21, 15);
            label5.TabIndex = 97;
            label5.Text = "ID:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(11, 63);
            label7.Name = "label7";
            label7.Size = new Size(63, 15);
            label7.TabIndex = 96;
            label7.Text = "Valor total:";
            // 
            // maskedTextBoxValorTotal
            // 
            maskedTextBoxValorTotal.Location = new Point(88, 61);
            maskedTextBoxValorTotal.Name = "maskedTextBoxValorTotal";
            maskedTextBoxValorTotal.Size = new Size(134, 23);
            maskedTextBoxValorTotal.TabIndex = 95;
            maskedTextBoxValorTotal.Text = "0.00";
            maskedTextBoxValorTotal.TextMaskFormat = MaskFormat.IncludePrompt;
            maskedTextBoxValorTotal.TextChanged += maskedTextBoxValorTotal_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(217, 8);
            label8.Name = "label8";
            label8.Size = new Size(72, 15);
            label8.TabIndex = 94;
            label8.Text = "Observação:";
            // 
            // richTextBoxObs
            // 
            richTextBoxObs.Location = new Point(295, 5);
            richTextBoxObs.Name = "richTextBoxObs";
            richTextBoxObs.Size = new Size(399, 323);
            richTextBoxObs.TabIndex = 93;
            richTextBoxObs.Text = "";
            // 
            // dateTimePickerDataFim
            // 
            dateTimePickerDataFim.Format = DateTimePickerFormat.Short;
            dateTimePickerDataFim.Location = new Point(136, 34);
            dateTimePickerDataFim.Name = "dateTimePickerDataFim";
            dateTimePickerDataFim.Size = new Size(86, 23);
            dateTimePickerDataFim.TabIndex = 92;
            // 
            // dateTimePickerDataInicio
            // 
            dateTimePickerDataInicio.Format = DateTimePickerFormat.Short;
            dateTimePickerDataInicio.Location = new Point(108, 8);
            dateTimePickerDataInicio.Name = "dateTimePickerDataInicio";
            dateTimePickerDataInicio.Size = new Size(93, 23);
            dateTimePickerDataInicio.TabIndex = 91;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 38);
            label4.Name = "label4";
            label4.Size = new Size(106, 15);
            label4.TabIndex = 88;
            label4.Text = "Data de finalização";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 12);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 87;
            label2.Text = "Data de início";
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
            // PesquisaPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(726, 428);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "PesquisaPedido";
            Text = "PesquisaPedido";
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
        private ComboBox comboBoxVeiculo;
        private Label label3;
        private ComboBox comboBoxCliente;
        private Label label1;
        private Button btnDeletar;
        private Button btnAtualizar;
        private Button buttonPesquisar;
        private DataGridView dataGridViewPesquisar;
        private TabPage tabPage2;
        private Button btnSalvarA;
        private Label label8;
        private RichTextBox richTextBoxObs;
        private DateTimePicker dateTimePickerDataFim;
        private DateTimePicker dateTimePickerDataInicio;
        private Label label4;
        private Label label2;
        private Label label7;
        private MaskedTextBox maskedTextBoxValorTotal;
        private MaskedTextBox maskedTextBoxID;
        private Label label5;
        private ComboBox comboBoxVeiculoP;
        private ComboBox comboBoxClienteP;
        private Label label6;
        private Label label9;
    }
}