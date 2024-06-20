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
            dateTimePicker1 = new DateTimePicker();
            comboBox2 = new ComboBox();
            maskedTextBox2 = new MaskedTextBox();
            comboBox1 = new ComboBox();
            richTextBox1 = new RichTextBox();
            textBox1 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPagePecas = new TabPage();
            dataGridView1 = new DataGridView();
            button1 = new Button();
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
            AbaServico.Size = new Size(972, 341);
            AbaServico.TabIndex = 0;
            // 
            // tabPageServico
            // 
            tabPageServico.Controls.Add(dateTimePicker1);
            tabPageServico.Controls.Add(comboBox2);
            tabPageServico.Controls.Add(maskedTextBox2);
            tabPageServico.Controls.Add(comboBox1);
            tabPageServico.Controls.Add(richTextBox1);
            tabPageServico.Controls.Add(textBox1);
            tabPageServico.Controls.Add(label6);
            tabPageServico.Controls.Add(label5);
            tabPageServico.Controls.Add(label4);
            tabPageServico.Controls.Add(label3);
            tabPageServico.Controls.Add(label2);
            tabPageServico.Controls.Add(label1);
            tabPageServico.Location = new Point(4, 29);
            tabPageServico.Name = "tabPageServico";
            tabPageServico.Padding = new Padding(3);
            tabPageServico.Size = new Size(964, 308);
            tabPageServico.TabIndex = 0;
            tabPageServico.Text = "Pedido";
            tabPageServico.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(82, 157);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(340, 27);
            dateTimePicker1.TabIndex = 26;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(82, 123);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(340, 28);
            comboBox2.TabIndex = 25;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(82, 90);
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(340, 27);
            maskedTextBox2.TabIndex = 24;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(82, 56);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(340, 28);
            comboBox1.TabIndex = 23;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(558, 23);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(385, 269);
            richTextBox1.TabIndex = 22;
            richTextBox1.Text = "";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(82, 23);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(340, 27);
            textBox1.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(32, 162);
            label6.Name = "label6";
            label6.Size = new Size(44, 20);
            label6.TabIndex = 20;
            label6.Text = "Data:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 126);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 19;
            label5.Text = "Veículo:";
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
            label3.Location = new Point(30, 93);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 17;
            label3.Text = "Valor:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 59);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 16;
            label2.Text = "Tipo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 26);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 15;
            label1.Text = "Nome:";
            // 
            // tabPagePecas
            // 
            tabPagePecas.Controls.Add(dataGridView1);
            tabPagePecas.Location = new Point(4, 29);
            tabPagePecas.Name = "tabPagePecas";
            tabPagePecas.Padding = new Padding(3);
            tabPagePecas.Size = new Size(964, 308);
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
            dataGridView1.Size = new Size(952, 303);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(16, 355);
            button1.Name = "button1";
            button1.Size = new Size(232, 106);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // CadastroPedido
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(996, 542);
            Controls.Add(button1);
            Controls.Add(AbaServico);
            Name = "CadastroPedido";
            Text = "CadastroServiço";
            Load += Cadastrar_Load;
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
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox2;
        private MaskedTextBox maskedTextBox2;
        private ComboBox comboBox1;
        private RichTextBox richTextBox1;
        private TextBox textBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TabPage tabPagePecas;
        private DataGridView dataGridView1;
        private Button button1;
    }
}