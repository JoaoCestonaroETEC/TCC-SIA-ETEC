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
            btnDeletar.Click += btnDeletar_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(427, 422);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(173, 73);
            btnAtualizar.TabIndex = 20;
            btnAtualizar.Text = "Editar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
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
            dataGridViewPesquisar.AllowUserToAddRows = false;
            dataGridViewPesquisar.AllowUserToDeleteRows = false;
            dataGridViewPesquisar.AllowUserToResizeColumns = false;
            dataGridViewPesquisar.AllowUserToResizeRows = false;
            dataGridViewPesquisar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPesquisar.Location = new Point(0, 49);
            dataGridViewPesquisar.Margin = new Padding(3, 4, 3, 4);
            dataGridViewPesquisar.Name = "dataGridViewPesquisar";
            dataGridViewPesquisar.RowHeadersVisible = false;
            dataGridViewPesquisar.RowHeadersWidth = 51;
            dataGridViewPesquisar.Size = new Size(786, 366);
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
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(798, 512);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Editar";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // comboBoxVeiculoP
            // 
            comboBoxVeiculoP.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxVeiculoP.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxVeiculoP.FormattingEnabled = true;
            comboBoxVeiculoP.Location = new Point(76, 201);
            comboBoxVeiculoP.Margin = new Padding(3, 4, 3, 4);
            comboBoxVeiculoP.Name = "comboBoxVeiculoP";
            comboBoxVeiculoP.Size = new Size(154, 28);
            comboBoxVeiculoP.TabIndex = 102;
            // 
            // comboBoxClienteP
            // 
            comboBoxClienteP.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxClienteP.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxClienteP.FormattingEnabled = true;
            comboBoxClienteP.Location = new Point(76, 156);
            comboBoxClienteP.Margin = new Padding(3, 4, 3, 4);
            comboBoxClienteP.Name = "comboBoxClienteP";
            comboBoxClienteP.Size = new Size(154, 28);
            comboBoxClienteP.TabIndex = 101;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 201);
            label6.Name = "label6";
            label6.Size = new Size(60, 20);
            label6.TabIndex = 100;
            label6.Text = "Veículo:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(18, 160);
            label9.Name = "label9";
            label9.Size = new Size(58, 20);
            label9.TabIndex = 99;
            label9.Text = "Cliente:";
            // 
            // maskedTextBoxID
            // 
            maskedTextBoxID.Location = new Point(49, 122);
            maskedTextBoxID.Name = "maskedTextBoxID";
            maskedTextBoxID.Size = new Size(45, 27);
            maskedTextBoxID.TabIndex = 98;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 125);
            label5.Name = "label5";
            label5.Size = new Size(27, 20);
            label5.TabIndex = 97;
            label5.Text = "ID:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 84);
            label7.Name = "label7";
            label7.Size = new Size(81, 20);
            label7.TabIndex = 96;
            label7.Text = "Valor total:";
            // 
            // maskedTextBoxValorTotal
            // 
            maskedTextBoxValorTotal.Location = new Point(100, 81);
            maskedTextBoxValorTotal.Margin = new Padding(3, 4, 3, 4);
            maskedTextBoxValorTotal.Name = "maskedTextBoxValorTotal";
            maskedTextBoxValorTotal.Size = new Size(153, 27);
            maskedTextBoxValorTotal.TabIndex = 95;
            maskedTextBoxValorTotal.Text = "0.00";
            maskedTextBoxValorTotal.TextMaskFormat = MaskFormat.IncludePrompt;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(248, 11);
            label8.Name = "label8";
            label8.Size = new Size(90, 20);
            label8.TabIndex = 94;
            label8.Text = "Observação:";
            // 
            // richTextBoxObs
            // 
            richTextBoxObs.Location = new Point(337, 7);
            richTextBoxObs.Margin = new Padding(3, 4, 3, 4);
            richTextBoxObs.Name = "richTextBoxObs";
            richTextBoxObs.Size = new Size(455, 429);
            richTextBoxObs.TabIndex = 93;
            richTextBoxObs.Text = "";
            // 
            // dateTimePickerDataFim
            // 
            dateTimePickerDataFim.Format = DateTimePickerFormat.Short;
            dateTimePickerDataFim.Location = new Point(155, 46);
            dateTimePickerDataFim.Margin = new Padding(3, 4, 3, 4);
            dateTimePickerDataFim.Name = "dateTimePickerDataFim";
            dateTimePickerDataFim.Size = new Size(98, 27);
            dateTimePickerDataFim.TabIndex = 92;
            // 
            // dateTimePickerDataInicio
            // 
            dateTimePickerDataInicio.Format = DateTimePickerFormat.Short;
            dateTimePickerDataInicio.Location = new Point(124, 11);
            dateTimePickerDataInicio.Margin = new Padding(3, 4, 3, 4);
            dateTimePickerDataInicio.Name = "dateTimePickerDataInicio";
            dateTimePickerDataInicio.Size = new Size(106, 27);
            dateTimePickerDataInicio.TabIndex = 91;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 51);
            label4.Name = "label4";
            label4.Size = new Size(138, 20);
            label4.TabIndex = 88;
            label4.Text = "Data de finalização";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 16);
            label2.Name = "label2";
            label2.Size = new Size(102, 20);
            label2.TabIndex = 87;
            label2.Text = "Data de início";
            // 
            // btnSalvarA
            // 
            btnSalvarA.Location = new Point(16, 420);
            btnSalvarA.Name = "btnSalvarA";
            btnSalvarA.Size = new Size(132, 77);
            btnSalvarA.TabIndex = 84;
            btnSalvarA.Text = "Salvar";
            btnSalvarA.UseVisualStyleBackColor = true;
            btnSalvarA.Click += btnSalvarA_Click;
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