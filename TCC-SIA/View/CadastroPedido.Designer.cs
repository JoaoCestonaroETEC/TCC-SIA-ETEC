namespace TCC_SIA.View
{
    partial class CadastroPedido
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
            AbaServico = new TabControl();
            tabPageServico = new TabPage();
            maskedTextBoxValor = new MaskedTextBox();
            linkLabel2 = new LinkLabel();
            linkLabel1 = new LinkLabel();
            label12 = new Label();
            label11 = new Label();
            comboBoxVeiculo = new ComboBox();
            comboBoxCliente = new ComboBox();
            dataTimePickerFim = new DateTimePicker();
            label10 = new Label();
            comboBoxPagamento = new ComboBox();
            label9 = new Label();
            dataTimePickerInicio = new DateTimePicker();
            richTextBoxObs = new RichTextBox();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            tabPagePecas = new TabPage();
            dataGridViewPecas = new DataGridView();
            tabPageServicos = new TabPage();
            buttonCadastrar = new Button();
            label1 = new Label();
            label2 = new Label();
            maskedTextBoxValorTotalPeca = new MaskedTextBox();
            maskedTextBoxValorTotalServico = new MaskedTextBox();
            textBoxPesquisaPeca = new TextBox();
            textBoxPesquisaServico = new TextBox();
            dataGridViewServicos = new DataGridView();
            AbaServico.SuspendLayout();
            tabPageServico.SuspendLayout();
            tabPagePecas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPecas).BeginInit();
            tabPageServicos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewServicos).BeginInit();
            SuspendLayout();
            // 
            // AbaServico
            // 
            AbaServico.Controls.Add(tabPageServico);
            AbaServico.Controls.Add(tabPagePecas);
            AbaServico.Controls.Add(tabPageServicos);
            AbaServico.Location = new Point(12, 12);
            AbaServico.Name = "AbaServico";
            AbaServico.SelectedIndex = 0;
            AbaServico.Size = new Size(1029, 396);
            AbaServico.TabIndex = 0;
            // 
            // tabPageServico
            // 
            tabPageServico.Controls.Add(maskedTextBoxValor);
            tabPageServico.Controls.Add(linkLabel2);
            tabPageServico.Controls.Add(linkLabel1);
            tabPageServico.Controls.Add(label12);
            tabPageServico.Controls.Add(label11);
            tabPageServico.Controls.Add(comboBoxVeiculo);
            tabPageServico.Controls.Add(comboBoxCliente);
            tabPageServico.Controls.Add(dataTimePickerFim);
            tabPageServico.Controls.Add(label10);
            tabPageServico.Controls.Add(comboBoxPagamento);
            tabPageServico.Controls.Add(label9);
            tabPageServico.Controls.Add(dataTimePickerInicio);
            tabPageServico.Controls.Add(richTextBoxObs);
            tabPageServico.Controls.Add(label6);
            tabPageServico.Controls.Add(label4);
            tabPageServico.Controls.Add(label3);
            tabPageServico.Location = new Point(4, 29);
            tabPageServico.Name = "tabPageServico";
            tabPageServico.Padding = new Padding(3);
            tabPageServico.Size = new Size(1021, 363);
            tabPageServico.TabIndex = 0;
            tabPageServico.Text = "Geral";
            tabPageServico.UseVisualStyleBackColor = true;
            // 
            // maskedTextBoxValor
            // 
            maskedTextBoxValor.Location = new Point(85, 93);
            maskedTextBoxValor.Name = "maskedTextBoxValor";
            maskedTextBoxValor.Size = new Size(152, 27);
            maskedTextBoxValor.TabIndex = 43;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(258, 62);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(128, 20);
            linkLabel2.TabIndex = 42;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Criar novo veículo";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(258, 23);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(125, 20);
            linkLabel1.TabIndex = 41;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Criar novo cliente";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(21, 62);
            label12.Name = "label12";
            label12.Size = new Size(60, 20);
            label12.TabIndex = 40;
            label12.Text = "Veículo:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(21, 23);
            label11.Name = "label11";
            label11.Size = new Size(58, 20);
            label11.TabIndex = 39;
            label11.Text = "Cliente:";
            // 
            // comboBoxVeiculo
            // 
            comboBoxVeiculo.FormattingEnabled = true;
            comboBoxVeiculo.Location = new Point(85, 59);
            comboBoxVeiculo.Name = "comboBoxVeiculo";
            comboBoxVeiculo.Size = new Size(151, 28);
            comboBoxVeiculo.TabIndex = 38;
            // 
            // comboBoxCliente
            // 
            comboBoxCliente.FormattingEnabled = true;
            comboBoxCliente.Location = new Point(85, 20);
            comboBoxCliente.Name = "comboBoxCliente";
            comboBoxCliente.Size = new Size(151, 28);
            comboBoxCliente.TabIndex = 37;
            // 
            // dataTimePickerFim
            // 
            dataTimePickerFim.Format = DateTimePickerFormat.Short;
            dataTimePickerFim.Location = new Point(100, 193);
            dataTimePickerFim.Name = "dataTimePickerFim";
            dataTimePickerFim.Size = new Size(125, 27);
            dataTimePickerFim.TabIndex = 36;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(22, 198);
            label10.Name = "label10";
            label10.Size = new Size(72, 20);
            label10.TabIndex = 35;
            label10.Text = "Data Fim:";
            // 
            // comboBoxPagamento
            // 
            comboBoxPagamento.FormattingEnabled = true;
            comboBoxPagamento.Items.AddRange(new object[] { "A VISTA", "A PRAZO", "30x" });
            comboBoxPagamento.Location = new Point(183, 126);
            comboBoxPagamento.Name = "comboBoxPagamento";
            comboBoxPagamento.Size = new Size(200, 28);
            comboBoxPagamento.TabIndex = 33;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(23, 129);
            label9.Name = "label9";
            label9.Size = new Size(154, 20);
            label9.TabIndex = 32;
            label9.Text = "Forma de Pagamento:";
            // 
            // dataTimePickerInicio
            // 
            dataTimePickerInicio.Format = DateTimePickerFormat.Short;
            dataTimePickerInicio.Location = new Point(112, 160);
            dataTimePickerInicio.Name = "dataTimePickerInicio";
            dataTimePickerInicio.Size = new Size(125, 27);
            dataTimePickerInicio.TabIndex = 26;
            // 
            // richTextBoxObs
            // 
            richTextBoxObs.Location = new Point(495, 20);
            richTextBoxObs.Name = "richTextBoxObs";
            richTextBoxObs.Size = new Size(500, 327);
            richTextBoxObs.TabIndex = 22;
            richTextBoxObs.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 165);
            label6.Name = "label6";
            label6.Size = new Size(84, 20);
            label6.TabIndex = 20;
            label6.Text = "Data Inicio:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(399, 25);
            label4.Name = "label4";
            label4.Size = new Size(90, 20);
            label4.TabIndex = 18;
            label4.Text = "Observação:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 100);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 17;
            label3.Text = "Valor:";
            // 
            // tabPagePecas
            // 
            tabPagePecas.Controls.Add(textBoxPesquisaPeca);
            tabPagePecas.Controls.Add(dataGridViewPecas);
            tabPagePecas.Location = new Point(4, 29);
            tabPagePecas.Name = "tabPagePecas";
            tabPagePecas.Padding = new Padding(3);
            tabPagePecas.Size = new Size(1021, 363);
            tabPagePecas.TabIndex = 1;
            tabPagePecas.Text = "Peças usadas";
            tabPagePecas.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPecas
            // 
            dataGridViewPecas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPecas.Location = new Point(9, 39);
            dataGridViewPecas.Name = "dataGridViewPecas";
            dataGridViewPecas.RowHeadersWidth = 51;
            dataGridViewPecas.Size = new Size(1009, 306);
            dataGridViewPecas.TabIndex = 0;
            // 
            // tabPageServicos
            // 
            tabPageServicos.Controls.Add(textBoxPesquisaServico);
            tabPageServicos.Controls.Add(dataGridViewServicos);
            tabPageServicos.Location = new Point(4, 29);
            tabPageServicos.Name = "tabPageServicos";
            tabPageServicos.Padding = new Padding(3);
            tabPageServicos.Size = new Size(1021, 363);
            tabPageServicos.TabIndex = 2;
            tabPageServicos.Text = "Serviços feitos";
            tabPageServicos.UseVisualStyleBackColor = true;
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.Location = new Point(16, 414);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(235, 106);
            buttonCadastrar.TabIndex = 1;
            buttonCadastrar.Text = "Cadastrar";
            buttonCadastrar.UseVisualStyleBackColor = true;
            buttonCadastrar.Click += buttonCadastrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(289, 457);
            label1.Name = "label1";
            label1.Size = new Size(148, 20);
            label1.TabIndex = 30;
            label1.Text = "Valor total das Peças:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(574, 457);
            label2.Name = "label2";
            label2.Size = new Size(164, 20);
            label2.TabIndex = 32;
            label2.Text = "Valor total dos Serviços";
            // 
            // maskedTextBoxValorTotalPeca
            // 
            maskedTextBoxValorTotalPeca.Location = new Point(443, 454);
            maskedTextBoxValorTotalPeca.Name = "maskedTextBoxValorTotalPeca";
            maskedTextBoxValorTotalPeca.Size = new Size(125, 27);
            maskedTextBoxValorTotalPeca.TabIndex = 33;
            // 
            // maskedTextBoxValorTotalServico
            // 
            maskedTextBoxValorTotalServico.Location = new Point(744, 454);
            maskedTextBoxValorTotalServico.Name = "maskedTextBoxValorTotalServico";
            maskedTextBoxValorTotalServico.Size = new Size(125, 27);
            maskedTextBoxValorTotalServico.TabIndex = 34;
            // 
            // textBoxPesquisaPeca
            // 
            textBoxPesquisaPeca.Location = new Point(9, 6);
            textBoxPesquisaPeca.Name = "textBoxPesquisaPeca";
            textBoxPesquisaPeca.Size = new Size(1006, 27);
            textBoxPesquisaPeca.TabIndex = 1;
            // 
            // textBoxPesquisaServico
            // 
            textBoxPesquisaServico.Location = new Point(6, 12);
            textBoxPesquisaServico.Name = "textBoxPesquisaServico";
            textBoxPesquisaServico.Size = new Size(1007, 27);
            textBoxPesquisaServico.TabIndex = 3;
            // 
            // dataGridViewServicos
            // 
            dataGridViewServicos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewServicos.Location = new Point(7, 45);
            dataGridViewServicos.Name = "dataGridViewServicos";
            dataGridViewServicos.RowHeadersWidth = 51;
            dataGridViewServicos.Size = new Size(1009, 306);
            dataGridViewServicos.TabIndex = 2;
            // 
            // CadastroPedido
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1058, 536);
            Controls.Add(maskedTextBoxValorTotalServico);
            Controls.Add(maskedTextBoxValorTotalPeca);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonCadastrar);
            Controls.Add(AbaServico);
            Name = "CadastroPedido";
            Text = "CadastroPedido";
            Load += CadastroPedido_Load;
            AbaServico.ResumeLayout(false);
            tabPageServico.ResumeLayout(false);
            tabPageServico.PerformLayout();
            tabPagePecas.ResumeLayout(false);
            tabPagePecas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPecas).EndInit();
            tabPageServicos.ResumeLayout(false);
            tabPageServicos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewServicos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl AbaServico;
        private TabPage tabPageServico;
        private DateTimePicker dataTimePickerInicio;
        private RichTextBox richTextBoxObs;
        private Label label6;
        private Label label4;
        private Label label3;
        private TabPage tabPagePecas;
        private DataGridView dataGridViewPecas;
        private Button buttonCadastrar;
        private ComboBox comboBoxPagamento;
        private Label label9;
        private DateTimePicker dataTimePickerFim;
        private Label label10;
        private ComboBox comboBoxVeiculo;
        private ComboBox comboBoxCliente;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel1;
        private Label label12;
        private Label label11;
        private MaskedTextBox maskedTextBoxValor;
        private Label label1;
        private Label label2;
        private TabPage tabPageServicos;
        private MaskedTextBox maskedTextBoxValorTotalPeca;
        private MaskedTextBox maskedTextBoxValorTotalServico;
        private TextBox textBoxPesquisaPeca;
        private TextBox textBoxPesquisaServico;
        private DataGridView dataGridViewServicos;
    }
}