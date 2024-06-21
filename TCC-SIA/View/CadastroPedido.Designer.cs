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
            dataTimeFim = new DateTimePicker();
            label10 = new Label();
            maskPlaca = new MaskedTextBox();
            cbbFormaPagamento = new ComboBox();
            label9 = new Label();
            cbbCor = new ComboBox();
            label8 = new Label();
            txbValorTotal = new TextBox();
            cbbMarca = new ComboBox();
            label7 = new Label();
            dataTimeInicio = new DateTimePicker();
            cbbModelo = new ComboBox();
            cbbTipoVeiculo = new ComboBox();
            richTextBox1 = new RichTextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPagePecas = new TabPage();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            AbaServico.SuspendLayout();
            tabPageServico.SuspendLayout();
            tabPagePecas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // AbaServico
            // 
            AbaServico.Controls.Add(tabPageServico);
            AbaServico.Controls.Add(tabPagePecas);
            AbaServico.Location = new Point(12, 12);
            AbaServico.Name = "AbaServico";
            AbaServico.SelectedIndex = 0;
            AbaServico.Size = new Size(1327, 396);
            AbaServico.TabIndex = 0;
            // 
            // tabPageServico
            // 
            tabPageServico.Controls.Add(comboBox2);
            tabPageServico.Controls.Add(comboBox1);
            tabPageServico.Controls.Add(dataTimeFim);
            tabPageServico.Controls.Add(label10);
            tabPageServico.Controls.Add(maskPlaca);
            tabPageServico.Controls.Add(cbbFormaPagamento);
            tabPageServico.Controls.Add(label9);
            tabPageServico.Controls.Add(cbbCor);
            tabPageServico.Controls.Add(label8);
            tabPageServico.Controls.Add(txbValorTotal);
            tabPageServico.Controls.Add(cbbMarca);
            tabPageServico.Controls.Add(label7);
            tabPageServico.Controls.Add(dataTimeInicio);
            tabPageServico.Controls.Add(cbbModelo);
            tabPageServico.Controls.Add(cbbTipoVeiculo);
            tabPageServico.Controls.Add(richTextBox1);
            tabPageServico.Controls.Add(label6);
            tabPageServico.Controls.Add(label5);
            tabPageServico.Controls.Add(label4);
            tabPageServico.Controls.Add(label3);
            tabPageServico.Controls.Add(label2);
            tabPageServico.Controls.Add(label1);
            tabPageServico.Location = new Point(4, 29);
            tabPageServico.Name = "tabPageServico";
            tabPageServico.Padding = new Padding(3);
            tabPageServico.Size = new Size(1319, 363);
            tabPageServico.TabIndex = 0;
            tabPageServico.Text = "Geral";
            tabPageServico.UseVisualStyleBackColor = true;
            // 
            // dataTimeFim
            // 
            dataTimeFim.Format = DateTimePickerFormat.Short;
            dataTimeFim.Location = new Point(777, 313);
            dataTimeFim.Name = "dataTimeFim";
            dataTimeFim.Size = new Size(125, 27);
            dataTimeFim.TabIndex = 36;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(727, 295);
            label10.Name = "label10";
            label10.Size = new Size(72, 20);
            label10.TabIndex = 35;
            label10.Text = "Data Fim:";
            // 
            // maskPlaca
            // 
            maskPlaca.Location = new Point(110, 26);
            maskPlaca.Mask = "aaaaaaa";
            maskPlaca.Name = "maskPlaca";
            maskPlaca.Size = new Size(80, 27);
            maskPlaca.TabIndex = 34;
            // 
            // cbbFormaPagamento
            // 
            cbbFormaPagamento.FormattingEnabled = true;
            cbbFormaPagamento.Items.AddRange(new object[] { "A VISTA", "A PRAZO", "30x" });
            cbbFormaPagamento.Location = new Point(322, 238);
            cbbFormaPagamento.Name = "cbbFormaPagamento";
            cbbFormaPagamento.Size = new Size(213, 28);
            cbbFormaPagamento.TabIndex = 33;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(322, 215);
            label9.Name = "label9";
            label9.Size = new Size(154, 20);
            label9.TabIndex = 32;
            label9.Text = "Forma de Pagamento:";
            // 
            // cbbCor
            // 
            cbbCor.FormattingEnabled = true;
            cbbCor.Items.AddRange(new object[] { "PRETO", "BRANCO", "PRATA", "VERMELHO", "CINZA", "AZUL", "AFINS" });
            cbbCor.Location = new Point(110, 163);
            cbbCor.Name = "cbbCor";
            cbbCor.Size = new Size(340, 28);
            cbbCor.TabIndex = 31;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(9, 163);
            label8.Name = "label8";
            label8.Size = new Size(35, 20);
            label8.TabIndex = 30;
            label8.Text = "Cor:";
            // 
            // txbValorTotal
            // 
            txbValorTotal.Location = new Point(110, 238);
            txbValorTotal.Name = "txbValorTotal";
            txbValorTotal.Size = new Size(125, 27);
            txbValorTotal.TabIndex = 29;
            // 
            // cbbMarca
            // 
            cbbMarca.FormattingEnabled = true;
            cbbMarca.Items.AddRange(new object[] { "FIAT", "BMW", "CHEVROLET", "AFINS" });
            cbbMarca.Location = new Point(110, 93);
            cbbMarca.Name = "cbbMarca";
            cbbMarca.Size = new Size(340, 28);
            cbbMarca.TabIndex = 28;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(9, 93);
            label7.Name = "label7";
            label7.Size = new Size(53, 20);
            label7.TabIndex = 27;
            label7.Text = "Marca:";
            // 
            // dataTimeInicio
            // 
            dataTimeInicio.Format = DateTimePickerFormat.Short;
            dataTimeInicio.Location = new Point(596, 313);
            dataTimeInicio.Name = "dataTimeInicio";
            dataTimeInicio.Size = new Size(125, 27);
            dataTimeInicio.TabIndex = 26;
            // 
            // cbbModelo
            // 
            cbbModelo.FormattingEnabled = true;
            cbbModelo.Items.AddRange(new object[] { "UNO", "COROLLA", "GOL", "PALIO", "FIESTA", "GOLF", "ONIX", "AFINS" });
            cbbModelo.Location = new Point(110, 126);
            cbbModelo.Name = "cbbModelo";
            cbbModelo.Size = new Size(340, 28);
            cbbModelo.TabIndex = 25;
            // 
            // cbbTipoVeiculo
            // 
            cbbTipoVeiculo.FormattingEnabled = true;
            cbbTipoVeiculo.Items.AddRange(new object[] { "Carro", "Moto", "Camionete", "Afins" });
            cbbTipoVeiculo.Location = new Point(110, 59);
            cbbTipoVeiculo.Name = "cbbTipoVeiculo";
            cbbTipoVeiculo.Size = new Size(340, 28);
            cbbTipoVeiculo.TabIndex = 23;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(558, 23);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(385, 269);
            richTextBox1.TabIndex = 22;
            richTextBox1.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(529, 295);
            label6.Name = "label6";
            label6.Size = new Size(84, 20);
            label6.TabIndex = 20;
            label6.Text = "Data Inicio:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 126);
            label5.Name = "label5";
            label5.Size = new Size(64, 20);
            label5.TabIndex = 19;
            label5.Text = "Modelo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(478, 26);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 18;
            label4.Text = "Descrição:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(110, 215);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 17;
            label3.Text = "Valor:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 62);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 16;
            label2.Text = "Tipo Veiculo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 26);
            label1.Name = "label1";
            label1.Size = new Size(47, 20);
            label1.TabIndex = 15;
            label1.Text = "Placa:";
            // 
            // tabPagePecas
            // 
            tabPagePecas.Controls.Add(dataGridView1);
            tabPagePecas.Location = new Point(4, 29);
            tabPagePecas.Name = "tabPagePecas";
            tabPagePecas.Padding = new Padding(3);
            tabPagePecas.Size = new Size(964, 363);
            tabPagePecas.TabIndex = 1;
            tabPagePecas.Text = "Peças usadas";
            tabPagePecas.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(952, 351);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(16, 414);
            button1.Name = "button1";
            button1.Size = new Size(235, 106);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Cadastrar_Pedidos;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(1150, 25);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 37;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(1150, 64);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 38;
            // 
            // CadastroPedido
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1351, 702);
            Controls.Add(button1);
            Controls.Add(AbaServico);
            Name = "CadastroPedido";
            Text = "CadastroPedido";
            Load += Pedido_Load;
            AbaServico.ResumeLayout(false);
            tabPageServico.ResumeLayout(false);
            tabPageServico.PerformLayout();
            tabPagePecas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl AbaServico;
        private TabPage tabPageServico;
        private DateTimePicker dataTimeInicio;
        private ComboBox cbbModelo;
        private ComboBox cbbTipoVeiculo;
        private RichTextBox richTextBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TabPage tabPagePecas;
        private DataGridView dataGridView1;
        private Button button1;
        private ComboBox cbbMarca;
        private Label label7;
        private TextBox txbValorTotal;
        private ComboBox cbbCor;
        private Label label8;
        private ComboBox cbbFormaPagamento;
        private Label label9;
        private MaskedTextBox maskPlaca;
        private DateTimePicker dataTimeFim;
        private Label label10;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
    }
}