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
            buttonPesquisarPeca = new Button();
            dataGridViewPeca = new DataGridView();
            comboBoxPeca = new ComboBox();
            tabPageServiçosUtilizados = new TabPage();
            buttonPesquisarServico = new Button();
            dataGridViewServico = new DataGridView();
            comboBoxServico = new ComboBox();
            buttonCadastrar = new Button();
            maskedTextBoxValorTotal = new MaskedTextBox();
            maskedTextBoxValorTotalPecas = new MaskedTextBox();
            maskedTextBoxValorTotalServicos = new MaskedTextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
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
            tabControlPedido.Location = new Point(12, 12);
            tabControlPedido.Name = "tabControlPedido";
            tabControlPedido.SelectedIndex = 0;
            tabControlPedido.Size = new Size(651, 387);
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
            tabPagePedido.Location = new Point(4, 24);
            tabPagePedido.Name = "tabPagePedido";
            tabPagePedido.Padding = new Padding(3);
            tabPagePedido.Size = new Size(643, 359);
            tabPagePedido.TabIndex = 0;
            tabPagePedido.Text = "Pedido";
            tabPagePedido.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(217, 22);
            label8.Name = "label8";
            label8.Size = new Size(72, 15);
            label8.TabIndex = 9;
            label8.Text = "Observação:";
            // 
            // richTextBoxObs
            // 
            richTextBoxObs.Location = new Point(295, 19);
            richTextBoxObs.Name = "richTextBoxObs";
            richTextBoxObs.Size = new Size(327, 323);
            richTextBoxObs.TabIndex = 8;
            richTextBoxObs.Text = "";
            // 
            // dateTimePickerDataFim
            // 
            dateTimePickerDataFim.Format = DateTimePickerFormat.Short;
            dateTimePickerDataFim.Location = new Point(124, 180);
            dateTimePickerDataFim.Name = "dateTimePickerDataFim";
            dateTimePickerDataFim.Size = new Size(76, 23);
            dateTimePickerDataFim.TabIndex = 7;
            // 
            // dateTimePickerDataInicio
            // 
            dateTimePickerDataInicio.Format = DateTimePickerFormat.Short;
            dateTimePickerDataInicio.Location = new Point(97, 129);
            dateTimePickerDataInicio.Name = "dateTimePickerDataInicio";
            dateTimePickerDataInicio.Size = new Size(103, 23);
            dateTimePickerDataInicio.TabIndex = 6;
            // 
            // comboBoxVeiculo
            // 
            comboBoxVeiculo.FormattingEnabled = true;
            comboBoxVeiculo.Location = new Point(65, 76);
            comboBoxVeiculo.Name = "comboBoxVeiculo";
            comboBoxVeiculo.Size = new Size(135, 23);
            comboBoxVeiculo.TabIndex = 5;
            comboBoxVeiculo.Click += comboBoxVeiculo_Click;
            // 
            // comboBoxCliente
            // 
            comboBoxCliente.FormattingEnabled = true;
            comboBoxCliente.Location = new Point(65, 19);
            comboBoxCliente.Name = "comboBoxCliente";
            comboBoxCliente.Size = new Size(135, 23);
            comboBoxCliente.TabIndex = 4;
            comboBoxCliente.Click += comboBoxCliente_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 186);
            label4.Name = "label4";
            label4.Size = new Size(106, 15);
            label4.TabIndex = 3;
            label4.Text = "Data de finalização";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 129);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 2;
            label3.Text = "Data de início";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 76);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 1;
            label2.Text = "Veículo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 22);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "Cliente:";
            // 
            // tabPagePecasUsadas
            // 
            tabPagePecasUsadas.Controls.Add(buttonPesquisarPeca);
            tabPagePecasUsadas.Controls.Add(dataGridViewPeca);
            tabPagePecasUsadas.Controls.Add(comboBoxPeca);
            tabPagePecasUsadas.Location = new Point(4, 24);
            tabPagePecasUsadas.Name = "tabPagePecasUsadas";
            tabPagePecasUsadas.Padding = new Padding(3);
            tabPagePecasUsadas.Size = new Size(643, 359);
            tabPagePecasUsadas.TabIndex = 1;
            tabPagePecasUsadas.Text = "Peças usadas";
            tabPagePecasUsadas.UseVisualStyleBackColor = true;
            // 
            // buttonPesquisarPeca
            // 
            buttonPesquisarPeca.Location = new Point(6, 322);
            buttonPesquisarPeca.Name = "buttonPesquisarPeca";
            buttonPesquisarPeca.Size = new Size(86, 31);
            buttonPesquisarPeca.TabIndex = 2;
            buttonPesquisarPeca.Text = "Pesquisar";
            buttonPesquisarPeca.UseVisualStyleBackColor = true;
            buttonPesquisarPeca.Click += buttonPesquisarPeca_Click;
            // 
            // dataGridViewPeca
            // 
            dataGridViewPeca.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPeca.Location = new Point(6, 35);
            dataGridViewPeca.Name = "dataGridViewPeca";
            dataGridViewPeca.Size = new Size(631, 281);
            dataGridViewPeca.TabIndex = 1;
            // 
            // comboBoxPeca
            // 
            comboBoxPeca.FormattingEnabled = true;
            comboBoxPeca.Location = new Point(6, 6);
            comboBoxPeca.Name = "comboBoxPeca";
            comboBoxPeca.Size = new Size(631, 23);
            comboBoxPeca.TabIndex = 0;
            comboBoxPeca.Click += comboBoxPeca_Click;
            // 
            // tabPageServiçosUtilizados
            // 
            tabPageServiçosUtilizados.Controls.Add(buttonPesquisarServico);
            tabPageServiçosUtilizados.Controls.Add(dataGridViewServico);
            tabPageServiçosUtilizados.Controls.Add(comboBoxServico);
            tabPageServiçosUtilizados.Location = new Point(4, 24);
            tabPageServiçosUtilizados.Name = "tabPageServiçosUtilizados";
            tabPageServiçosUtilizados.Padding = new Padding(3);
            tabPageServiçosUtilizados.Size = new Size(643, 359);
            tabPageServiçosUtilizados.TabIndex = 2;
            tabPageServiçosUtilizados.Text = "Serviços Usados";
            tabPageServiçosUtilizados.UseVisualStyleBackColor = true;
            // 
            // buttonPesquisarServico
            // 
            buttonPesquisarServico.Location = new Point(6, 322);
            buttonPesquisarServico.Name = "buttonPesquisarServico";
            buttonPesquisarServico.Size = new Size(86, 31);
            buttonPesquisarServico.TabIndex = 5;
            buttonPesquisarServico.Text = "Pesquisar";
            buttonPesquisarServico.UseVisualStyleBackColor = true;
            buttonPesquisarServico.Click += buttonPesquisarServico_Click;
            // 
            // dataGridViewServico
            // 
            dataGridViewServico.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewServico.Location = new Point(6, 35);
            dataGridViewServico.Name = "dataGridViewServico";
            dataGridViewServico.Size = new Size(631, 281);
            dataGridViewServico.TabIndex = 4;
            // 
            // comboBoxServico
            // 
            comboBoxServico.FormattingEnabled = true;
            comboBoxServico.Location = new Point(6, 6);
            comboBoxServico.Name = "comboBoxServico";
            comboBoxServico.Size = new Size(631, 23);
            comboBoxServico.TabIndex = 3;
            comboBoxServico.Click += comboBoxServico_Click;
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.Location = new Point(7, 405);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(147, 99);
            buttonCadastrar.TabIndex = 1;
            buttonCadastrar.Text = "Cadastrar";
            buttonCadastrar.UseVisualStyleBackColor = true;
            buttonCadastrar.Click += buttonCadastrar_Click;
            // 
            // maskedTextBoxValorTotal
            // 
            maskedTextBoxValorTotal.Location = new Point(242, 409);
            maskedTextBoxValorTotal.Name = "maskedTextBoxValorTotal";
            maskedTextBoxValorTotal.Size = new Size(100, 23);
            maskedTextBoxValorTotal.TabIndex = 2;
            // 
            // maskedTextBoxValorTotalPecas
            // 
            maskedTextBoxValorTotalPecas.Location = new Point(466, 409);
            maskedTextBoxValorTotalPecas.Name = "maskedTextBoxValorTotalPecas";
            maskedTextBoxValorTotalPecas.Size = new Size(100, 23);
            maskedTextBoxValorTotalPecas.TabIndex = 3;
            // 
            // maskedTextBoxValorTotalServicos
            // 
            maskedTextBoxValorTotalServicos.Location = new Point(302, 438);
            maskedTextBoxValorTotalServicos.Name = "maskedTextBoxValorTotalServicos";
            maskedTextBoxValorTotalServicos.Size = new Size(100, 23);
            maskedTextBoxValorTotalServicos.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(173, 412);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 5;
            label5.Text = "Valor total:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(348, 412);
            label6.Name = "label6";
            label6.Size = new Size(112, 15);
            label6.TabIndex = 6;
            label6.Text = "Valor total de peças:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(172, 443);
            label7.Name = "label7";
            label7.Size = new Size(124, 15);
            label7.TabIndex = 7;
            label7.Text = "Valor total de serviços:";
            // 
            // CadastroPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(677, 513);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(maskedTextBoxValorTotalServicos);
            Controls.Add(maskedTextBoxValorTotalPecas);
            Controls.Add(maskedTextBoxValorTotal);
            Controls.Add(buttonCadastrar);
            Controls.Add(tabControlPedido);
            Name = "CadastroPedido";
            Text = "CadastroPedido";
            tabControlPedido.ResumeLayout(false);
            tabPagePedido.ResumeLayout(false);
            tabPagePedido.PerformLayout();
            tabPagePecasUsadas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewPeca).EndInit();
            tabPageServiçosUtilizados.ResumeLayout(false);
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
        private DataGridView dataGridViewPeca;
        private ComboBox comboBoxPeca;
        private Button buttonPesquisarServico;
        private DataGridView dataGridViewServico;
        private ComboBox comboBoxServico;
    }
}