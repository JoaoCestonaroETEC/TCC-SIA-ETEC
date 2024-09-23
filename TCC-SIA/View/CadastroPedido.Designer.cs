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
            components = new System.ComponentModel.Container();
            tabControlPedido = new TabControl();
            tabPagePedido = new TabPage();
            label8 = new Label();
            richTextBoxObs = new RichTextBox();
            dateTimePickerDataFim = new DateTimePicker();
            dateTimePickerDataInicio = new DateTimePicker();
            comboBoxVeiculo = new ComboBox();
            comboBoxCliente = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPagePecasUsadas = new TabPage();
            textBoxPesquisarP = new TextBox();
            dataGridViewPeca = new DataGridView();
            maskedTextBoxDescontoPPeca = new MaskedTextBox();
            label14 = new Label();
            maskedTextBoxDescontoRPeca = new MaskedTextBox();
            label13 = new Label();
            label12 = new Label();
            buttonPesquisarPeca = new Button();
            tabPageServiçosUtilizados = new TabPage();
            textBoxPesquisarS = new TextBox();
            maskedTextBoxDescontoPServico = new MaskedTextBox();
            label15 = new Label();
            maskedTextBoxDescontoRServico = new MaskedTextBox();
            label16 = new Label();
            label17 = new Label();
            buttonPesquisarServico = new Button();
            dataGridViewServico = new DataGridView();
            buttonCadastrar = new Button();
            maskedTextBoxValorTotal = new MaskedTextBox();
            maskedTextBoxValorTotalPecas = new MaskedTextBox();
            maskedTextBoxValorTotalServicos = new MaskedTextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label9 = new Label();
            label10 = new Label();
            maskedTextBoxDescontoReais = new MaskedTextBox();
            label11 = new Label();
            maskedTextBoxDescontoPorc = new MaskedTextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            tabControlPedido.SuspendLayout();
            tabPagePedido.SuspendLayout();
            tabPagePecasUsadas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPeca).BeginInit();
            tabPageServiçosUtilizados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewServico).BeginInit();
            SuspendLayout();
            // 
            // tabControlPedido
            // 
            tabControlPedido.Controls.Add(tabPagePedido);
            tabControlPedido.Controls.Add(tabPagePecasUsadas);
            tabControlPedido.Controls.Add(tabPageServiçosUtilizados);
            tabControlPedido.Location = new Point(14, 16);
            tabControlPedido.Margin = new Padding(3, 4, 3, 4);
            tabControlPedido.Name = "tabControlPedido";
            tabControlPedido.SelectedIndex = 0;
            tabControlPedido.Size = new Size(792, 516);
            tabControlPedido.TabIndex = 0;
            // 
            // tabPagePedido
            // 
            tabPagePedido.Controls.Add(label8);
            tabPagePedido.Controls.Add(richTextBoxObs);
            tabPagePedido.Controls.Add(dateTimePickerDataFim);
            tabPagePedido.Controls.Add(dateTimePickerDataInicio);
            tabPagePedido.Controls.Add(comboBoxVeiculo);
            tabPagePedido.Controls.Add(comboBoxCliente);
            tabPagePedido.Controls.Add(label4);
            tabPagePedido.Controls.Add(label3);
            tabPagePedido.Controls.Add(label2);
            tabPagePedido.Controls.Add(label1);
            tabPagePedido.Location = new Point(4, 29);
            tabPagePedido.Margin = new Padding(3, 4, 3, 4);
            tabPagePedido.Name = "tabPagePedido";
            tabPagePedido.Padding = new Padding(3, 4, 3, 4);
            tabPagePedido.Size = new Size(784, 483);
            tabPagePedido.TabIndex = 0;
            tabPagePedido.Text = "Pedido";
            tabPagePedido.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(248, 29);
            label8.Name = "label8";
            label8.Size = new Size(90, 20);
            label8.TabIndex = 9;
            label8.Text = "Observação:";
            // 
            // richTextBoxObs
            // 
            richTextBoxObs.Location = new Point(337, 25);
            richTextBoxObs.Margin = new Padding(3, 4, 3, 4);
            richTextBoxObs.Name = "richTextBoxObs";
            richTextBoxObs.Size = new Size(430, 429);
            richTextBoxObs.TabIndex = 8;
            richTextBoxObs.Text = "";
            // 
            // dateTimePickerDataFim
            // 
            dateTimePickerDataFim.Format = DateTimePickerFormat.Short;
            dateTimePickerDataFim.Location = new Point(142, 237);
            dateTimePickerDataFim.Margin = new Padding(3, 4, 3, 4);
            dateTimePickerDataFim.Name = "dateTimePickerDataFim";
            dateTimePickerDataFim.Size = new Size(86, 27);
            dateTimePickerDataFim.TabIndex = 7;
            // 
            // dateTimePickerDataInicio
            // 
            dateTimePickerDataInicio.Format = DateTimePickerFormat.Short;
            dateTimePickerDataInicio.Location = new Point(111, 169);
            dateTimePickerDataInicio.Margin = new Padding(3, 4, 3, 4);
            dateTimePickerDataInicio.Name = "dateTimePickerDataInicio";
            dateTimePickerDataInicio.Size = new Size(117, 27);
            dateTimePickerDataInicio.TabIndex = 6;
            // 
            // comboBoxVeiculo
            // 
            comboBoxVeiculo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxVeiculo.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxVeiculo.FormattingEnabled = true;
            comboBoxVeiculo.Location = new Point(74, 101);
            comboBoxVeiculo.Margin = new Padding(3, 4, 3, 4);
            comboBoxVeiculo.Name = "comboBoxVeiculo";
            comboBoxVeiculo.Size = new Size(154, 28);
            comboBoxVeiculo.TabIndex = 5;
            comboBoxVeiculo.DropDown += comboBoxVeiculo_DropDown;
            comboBoxVeiculo.Validating += comboBoxVeiculo_Validating;
            // 
            // comboBoxCliente
            // 
            comboBoxCliente.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxCliente.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxCliente.FormattingEnabled = true;
            comboBoxCliente.Location = new Point(74, 25);
            comboBoxCliente.Margin = new Padding(3, 4, 3, 4);
            comboBoxCliente.Name = "comboBoxCliente";
            comboBoxCliente.Size = new Size(154, 28);
            comboBoxCliente.TabIndex = 4;
            comboBoxCliente.DropDown += comboBoxCliente_DropDown;
            comboBoxCliente.Validating += comboBoxCliente_Validating;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 245);
            label4.Name = "label4";
            label4.Size = new Size(138, 20);
            label4.TabIndex = 3;
            label4.Text = "Data de finalização";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 169);
            label3.Name = "label3";
            label3.Size = new Size(102, 20);
            label3.TabIndex = 2;
            label3.Text = "Data de início";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 101);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 1;
            label2.Text = "Veículo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 29);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 0;
            label1.Text = "Cliente:";
            // 
            // tabPagePecasUsadas
            // 
            tabPagePecasUsadas.Controls.Add(textBoxPesquisarP);
            tabPagePecasUsadas.Controls.Add(dataGridViewPeca);
            tabPagePecasUsadas.Controls.Add(maskedTextBoxDescontoPPeca);
            tabPagePecasUsadas.Controls.Add(label14);
            tabPagePecasUsadas.Controls.Add(maskedTextBoxDescontoRPeca);
            tabPagePecasUsadas.Controls.Add(label13);
            tabPagePecasUsadas.Controls.Add(label12);
            tabPagePecasUsadas.Controls.Add(buttonPesquisarPeca);
            tabPagePecasUsadas.Location = new Point(4, 29);
            tabPagePecasUsadas.Margin = new Padding(3, 4, 3, 4);
            tabPagePecasUsadas.Name = "tabPagePecasUsadas";
            tabPagePecasUsadas.Padding = new Padding(3, 4, 3, 4);
            tabPagePecasUsadas.Size = new Size(784, 483);
            tabPagePecasUsadas.TabIndex = 1;
            tabPagePecasUsadas.Text = "Peças usadas";
            tabPagePecasUsadas.UseVisualStyleBackColor = true;
            // 
            // textBoxPesquisarP
            // 
            textBoxPesquisarP.Location = new Point(7, 8);
            textBoxPesquisarP.Margin = new Padding(3, 4, 3, 4);
            textBoxPesquisarP.Name = "textBoxPesquisarP";
            textBoxPesquisarP.Size = new Size(769, 27);
            textBoxPesquisarP.TabIndex = 17;
            // 
            // dataGridViewPeca
            // 
            dataGridViewPeca.AllowUserToAddRows = false;
            dataGridViewPeca.AllowUserToDeleteRows = false;
            dataGridViewPeca.AllowUserToResizeColumns = false;
            dataGridViewPeca.AllowUserToResizeRows = false;
            dataGridViewPeca.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPeca.Location = new Point(7, 47);
            dataGridViewPeca.Margin = new Padding(3, 4, 3, 4);
            dataGridViewPeca.Name = "dataGridViewPeca";
            dataGridViewPeca.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewPeca.RowHeadersVisible = false;
            dataGridViewPeca.RowHeadersWidth = 51;
            dataGridViewPeca.Size = new Size(769, 375);
            dataGridViewPeca.TabIndex = 16;
            dataGridViewPeca.CellClick += dataGridViewPeca_CellClick;
            // 
            // maskedTextBoxDescontoPPeca
            // 
            maskedTextBoxDescontoPPeca.Location = new Point(391, 436);
            maskedTextBoxDescontoPPeca.Margin = new Padding(3, 4, 3, 4);
            maskedTextBoxDescontoPPeca.Name = "maskedTextBoxDescontoPPeca";
            maskedTextBoxDescontoPPeca.Size = new Size(62, 27);
            maskedTextBoxDescontoPPeca.TabIndex = 15;
            maskedTextBoxDescontoPPeca.Text = "0.00";
            maskedTextBoxDescontoPPeca.TextChanged += maskedTextBoxDescontoPPeca_TextChanged;
            maskedTextBoxDescontoPPeca.KeyPress += maskedTextBoxDescontoPPeca_KeyPress;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(361, 440);
            label14.Name = "label14";
            label14.Size = new Size(26, 20);
            label14.TabIndex = 14;
            label14.Text = "R$";
            // 
            // maskedTextBoxDescontoRPeca
            // 
            maskedTextBoxDescontoRPeca.Location = new Point(295, 436);
            maskedTextBoxDescontoRPeca.Margin = new Padding(3, 4, 3, 4);
            maskedTextBoxDescontoRPeca.Name = "maskedTextBoxDescontoRPeca";
            maskedTextBoxDescontoRPeca.Size = new Size(62, 27);
            maskedTextBoxDescontoRPeca.TabIndex = 13;
            maskedTextBoxDescontoRPeca.Text = "0";
            maskedTextBoxDescontoRPeca.TextChanged += maskedTextBoxDescontoRPeca_TextChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(269, 440);
            label13.Name = "label13";
            label13.Size = new Size(21, 20);
            label13.TabIndex = 12;
            label13.Text = "%";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(193, 440);
            label12.Name = "label12";
            label12.Size = new Size(75, 20);
            label12.TabIndex = 9;
            label12.Text = "Desconto:";
            // 
            // buttonPesquisarPeca
            // 
            buttonPesquisarPeca.Location = new Point(7, 429);
            buttonPesquisarPeca.Margin = new Padding(3, 4, 3, 4);
            buttonPesquisarPeca.Name = "buttonPesquisarPeca";
            buttonPesquisarPeca.Size = new Size(98, 41);
            buttonPesquisarPeca.TabIndex = 2;
            buttonPesquisarPeca.Text = "Pesquisar";
            buttonPesquisarPeca.UseVisualStyleBackColor = true;
            buttonPesquisarPeca.Click += buttonPesquisarPeca_Click;
            // 
            // tabPageServiçosUtilizados
            // 
            tabPageServiçosUtilizados.Controls.Add(textBoxPesquisarS);
            tabPageServiçosUtilizados.Controls.Add(maskedTextBoxDescontoPServico);
            tabPageServiçosUtilizados.Controls.Add(label15);
            tabPageServiçosUtilizados.Controls.Add(maskedTextBoxDescontoRServico);
            tabPageServiçosUtilizados.Controls.Add(label16);
            tabPageServiçosUtilizados.Controls.Add(label17);
            tabPageServiçosUtilizados.Controls.Add(buttonPesquisarServico);
            tabPageServiçosUtilizados.Controls.Add(dataGridViewServico);
            tabPageServiçosUtilizados.Location = new Point(4, 29);
            tabPageServiçosUtilizados.Margin = new Padding(3, 4, 3, 4);
            tabPageServiçosUtilizados.Name = "tabPageServiçosUtilizados";
            tabPageServiçosUtilizados.Padding = new Padding(3, 4, 3, 4);
            tabPageServiçosUtilizados.Size = new Size(784, 483);
            tabPageServiçosUtilizados.TabIndex = 2;
            tabPageServiçosUtilizados.Text = "Serviços Usados";
            tabPageServiçosUtilizados.UseVisualStyleBackColor = true;
            // 
            // textBoxPesquisarS
            // 
            textBoxPesquisarS.Location = new Point(7, 8);
            textBoxPesquisarS.Margin = new Padding(3, 4, 3, 4);
            textBoxPesquisarS.Name = "textBoxPesquisarS";
            textBoxPesquisarS.Size = new Size(769, 27);
            textBoxPesquisarS.TabIndex = 18;
            // 
            // maskedTextBoxDescontoPServico
            // 
            maskedTextBoxDescontoPServico.Location = new Point(391, 436);
            maskedTextBoxDescontoPServico.Margin = new Padding(3, 4, 3, 4);
            maskedTextBoxDescontoPServico.Name = "maskedTextBoxDescontoPServico";
            maskedTextBoxDescontoPServico.Size = new Size(62, 27);
            maskedTextBoxDescontoPServico.TabIndex = 20;
            maskedTextBoxDescontoPServico.Text = "0.00";
            maskedTextBoxDescontoPServico.KeyPress += maskedTextBoxDescontoPServico_KeyPress;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(361, 440);
            label15.Name = "label15";
            label15.Size = new Size(26, 20);
            label15.TabIndex = 19;
            label15.Text = "R$";
            // 
            // maskedTextBoxDescontoRServico
            // 
            maskedTextBoxDescontoRServico.Location = new Point(295, 436);
            maskedTextBoxDescontoRServico.Margin = new Padding(3, 4, 3, 4);
            maskedTextBoxDescontoRServico.Name = "maskedTextBoxDescontoRServico";
            maskedTextBoxDescontoRServico.Size = new Size(62, 27);
            maskedTextBoxDescontoRServico.TabIndex = 18;
            maskedTextBoxDescontoRServico.Text = "0";
            maskedTextBoxDescontoRServico.TextChanged += maskedTextBoxDescontoRServico_TextChanged;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(269, 440);
            label16.Name = "label16";
            label16.Size = new Size(21, 20);
            label16.TabIndex = 17;
            label16.Text = "%";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(193, 440);
            label17.Name = "label17";
            label17.Size = new Size(75, 20);
            label17.TabIndex = 16;
            label17.Text = "Desconto:";
            // 
            // buttonPesquisarServico
            // 
            buttonPesquisarServico.Location = new Point(7, 429);
            buttonPesquisarServico.Margin = new Padding(3, 4, 3, 4);
            buttonPesquisarServico.Name = "buttonPesquisarServico";
            buttonPesquisarServico.Size = new Size(98, 41);
            buttonPesquisarServico.TabIndex = 5;
            buttonPesquisarServico.Text = "Pesquisar";
            buttonPesquisarServico.UseVisualStyleBackColor = true;
            buttonPesquisarServico.Click += buttonPesquisarServico_Click;
            // 
            // dataGridViewServico
            // 
            dataGridViewServico.AllowUserToAddRows = false;
            dataGridViewServico.AllowUserToDeleteRows = false;
            dataGridViewServico.AllowUserToResizeColumns = false;
            dataGridViewServico.AllowUserToResizeRows = false;
            dataGridViewServico.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewServico.Location = new Point(7, 47);
            dataGridViewServico.Margin = new Padding(3, 4, 3, 4);
            dataGridViewServico.Name = "dataGridViewServico";
            dataGridViewServico.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewServico.RowHeadersVisible = false;
            dataGridViewServico.RowHeadersWidth = 10;
            dataGridViewServico.Size = new Size(769, 375);
            dataGridViewServico.TabIndex = 4;
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.Location = new Point(8, 540);
            buttonCadastrar.Margin = new Padding(3, 4, 3, 4);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(168, 132);
            buttonCadastrar.TabIndex = 1;
            buttonCadastrar.Text = "Cadastrar";
            buttonCadastrar.UseVisualStyleBackColor = true;
            buttonCadastrar.Click += buttonCadastrar_Click;
            // 
            // maskedTextBoxValorTotal
            // 
            maskedTextBoxValorTotal.Location = new Point(345, 545);
            maskedTextBoxValorTotal.Margin = new Padding(3, 4, 3, 4);
            maskedTextBoxValorTotal.Name = "maskedTextBoxValorTotal";
            maskedTextBoxValorTotal.Size = new Size(153, 27);
            maskedTextBoxValorTotal.TabIndex = 2;
            maskedTextBoxValorTotal.Text = "0.00";
            maskedTextBoxValorTotal.TextMaskFormat = MaskFormat.IncludePrompt;
            maskedTextBoxValorTotal.TextChanged += maskedTextBoxValorTotal_TextChanged;
            maskedTextBoxValorTotal.KeyPress += maskedTextBoxValorTotal_KeyPress;
            // 
            // maskedTextBoxValorTotalPecas
            // 
            maskedTextBoxValorTotalPecas.Location = new Point(345, 623);
            maskedTextBoxValorTotalPecas.Margin = new Padding(3, 4, 3, 4);
            maskedTextBoxValorTotalPecas.Name = "maskedTextBoxValorTotalPecas";
            maskedTextBoxValorTotalPecas.Size = new Size(153, 27);
            maskedTextBoxValorTotalPecas.TabIndex = 3;
            maskedTextBoxValorTotalPecas.Text = "0.00";
            maskedTextBoxValorTotalPecas.TextChanged += maskedTextBoxValorTotalPecas_TextChanged;
            maskedTextBoxValorTotalPecas.KeyPress += maskedTextBoxValorTotalPecas_KeyPress;
            // 
            // maskedTextBoxValorTotalServicos
            // 
            maskedTextBoxValorTotalServicos.Location = new Point(345, 584);
            maskedTextBoxValorTotalServicos.Margin = new Padding(3, 4, 3, 4);
            maskedTextBoxValorTotalServicos.Name = "maskedTextBoxValorTotalServicos";
            maskedTextBoxValorTotalServicos.Size = new Size(153, 27);
            maskedTextBoxValorTotalServicos.TabIndex = 4;
            maskedTextBoxValorTotalServicos.Text = "0.00";
            maskedTextBoxValorTotalServicos.TextChanged += maskedTextBoxValorTotalServicos_TextChanged;
            maskedTextBoxValorTotalServicos.KeyPress += maskedTextBoxValorTotalServicos_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(266, 549);
            label5.Name = "label5";
            label5.Size = new Size(81, 20);
            label5.TabIndex = 5;
            label5.Text = "Valor total:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(210, 627);
            label6.Name = "label6";
            label6.Size = new Size(144, 20);
            label6.TabIndex = 6;
            label6.Text = "Valor total de peças:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(197, 591);
            label7.Name = "label7";
            label7.Size = new Size(158, 20);
            label7.TabIndex = 7;
            label7.Text = "Valor total de serviços:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(558, 549);
            label9.Name = "label9";
            label9.Size = new Size(75, 20);
            label9.TabIndex = 8;
            label9.Text = "Desconto:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(638, 549);
            label10.Name = "label10";
            label10.Size = new Size(21, 20);
            label10.TabIndex = 10;
            label10.Text = "%";
            // 
            // maskedTextBoxDescontoReais
            // 
            maskedTextBoxDescontoReais.Location = new Point(664, 545);
            maskedTextBoxDescontoReais.Margin = new Padding(3, 4, 3, 4);
            maskedTextBoxDescontoReais.Name = "maskedTextBoxDescontoReais";
            maskedTextBoxDescontoReais.Size = new Size(62, 27);
            maskedTextBoxDescontoReais.TabIndex = 11;
            maskedTextBoxDescontoReais.Text = "0";
            maskedTextBoxDescontoReais.TextChanged += maskedTextBoxDescontoReais_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(634, 589);
            label11.Name = "label11";
            label11.Size = new Size(26, 20);
            label11.TabIndex = 12;
            label11.Text = "R$";
            // 
            // maskedTextBoxDescontoPorc
            // 
            maskedTextBoxDescontoPorc.Location = new Point(664, 585);
            maskedTextBoxDescontoPorc.Margin = new Padding(3, 4, 3, 4);
            maskedTextBoxDescontoPorc.Name = "maskedTextBoxDescontoPorc";
            maskedTextBoxDescontoPorc.Size = new Size(62, 27);
            maskedTextBoxDescontoPorc.TabIndex = 13;
            maskedTextBoxDescontoPorc.Text = "0,00";
            maskedTextBoxDescontoPorc.TextChanged += maskedTextBoxDescontoPorc_TextChanged;
            maskedTextBoxDescontoPorc.KeyPress += maskedTextBoxDescontoPorc_KeyPress;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // CadastroPedido
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(819, 684);
            Controls.Add(maskedTextBoxDescontoPorc);
            Controls.Add(label11);
            Controls.Add(maskedTextBoxDescontoReais);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(maskedTextBoxValorTotalServicos);
            Controls.Add(maskedTextBoxValorTotalPecas);
            Controls.Add(maskedTextBoxValorTotal);
            Controls.Add(buttonCadastrar);
            Controls.Add(tabControlPedido);
            ForeColor = Color.Black;
            Margin = new Padding(3, 4, 3, 4);
            Name = "CadastroPedido";
            Text = "CadastroPedido";
            Load += CadastroPedido_Load;
            tabControlPedido.ResumeLayout(false);
            tabPagePedido.ResumeLayout(false);
            tabPagePedido.PerformLayout();
            tabPagePecasUsadas.ResumeLayout(false);
            tabPagePecasUsadas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPeca).EndInit();
            tabPageServiçosUtilizados.ResumeLayout(false);
            tabPageServiçosUtilizados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewServico).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControlPedido;
        private TabPage tabPagePedido;
        private Label label1;
        private TabPage tabPagePecasUsadas;
        private TabPage tabPageServiçosUtilizados;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label8;
        private RichTextBox richTextBoxObs;
        private DateTimePicker dateTimePickerDataFim;
        private DateTimePicker dateTimePickerDataInicio;
        private ComboBox comboBoxVeiculo;
        private ComboBox comboBoxCliente;
        private Button buttonCadastrar;
        private MaskedTextBox maskedTextBoxValorTotal;
        private MaskedTextBox maskedTextBoxValorTotalPecas;
        private MaskedTextBox maskedTextBoxValorTotalServicos;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button buttonPesquisarPeca;
        private Button buttonPesquisarServico;
        private DataGridView dataGridViewServico;
        private Label label9;
        private Label label10;
        private MaskedTextBox maskedTextBoxDescontoReais;
        private Label label11;
        private MaskedTextBox maskedTextBoxDescontoPorc;
        private MaskedTextBox maskedTextBoxDescontoPPeca;
        private Label label14;
        private MaskedTextBox maskedTextBoxDescontoRPeca;
        private Label label13;
        private Label label12;
        private DataGridView dataGridViewPeca;
        private MaskedTextBox maskedTextBoxDescontoPServico;
        private Label label15;
        private MaskedTextBox maskedTextBoxDescontoRServico;
        private Label label16;
        private Label label17;
        private TextBox textBoxPesquisarP;
        private TextBox textBoxPesquisarS;
        private ContextMenuStrip contextMenuStrip1;
    }
}