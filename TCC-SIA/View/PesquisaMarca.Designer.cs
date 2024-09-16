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
            buttonPesquisar = new Button();
            label1 = new Label();
            textBoxPesquisar = new TextBox();
            dataGridViewPesquisar = new DataGridView();
            comboBoxTipo = new ComboBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPesquisar).BeginInit();
            SuspendLayout();
            // 
            // buttonPesquisar
            // 
            buttonPesquisar.Location = new Point(14, 459);
            buttonPesquisar.Margin = new Padding(3, 4, 3, 4);
            buttonPesquisar.Name = "buttonPesquisar";
            buttonPesquisar.Size = new Size(136, 95);
            buttonPesquisar.TabIndex = 15;
            buttonPesquisar.Text = "Pesquisar";
            buttonPesquisar.UseVisualStyleBackColor = true;
            buttonPesquisar.Click += buttonPesquisar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 20);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 14;
            label1.Text = "Pesquisar:";
            // 
            // textBoxPesquisar
            // 
            textBoxPesquisar.Location = new Point(89, 16);
            textBoxPesquisar.Margin = new Padding(3, 4, 3, 4);
            textBoxPesquisar.Name = "textBoxPesquisar";
            textBoxPesquisar.Size = new Size(511, 27);
            textBoxPesquisar.TabIndex = 13;
            // 
            // dataGridViewPesquisar
            // 
            dataGridViewPesquisar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPesquisar.Location = new Point(14, 57);
            dataGridViewPesquisar.Margin = new Padding(3, 4, 3, 4);
            dataGridViewPesquisar.Name = "dataGridViewPesquisar";
            dataGridViewPesquisar.RowHeadersWidth = 51;
            dataGridViewPesquisar.Size = new Size(587, 393);
            dataGridViewPesquisar.TabIndex = 12;
            // 
            // comboBoxTipo
            // 
            comboBoxTipo.FormattingEnabled = true;
            comboBoxTipo.Items.AddRange(new object[] { "Peças Automotívas", "Óleos lubrificantes", "Pneus", "Ferramentas e Equipamentos para oficinas", "Veiculos", "Outro" });
            comboBoxTipo.Location = new Point(462, 493);
            comboBoxTipo.Margin = new Padding(3, 4, 3, 4);
            comboBoxTipo.Name = "comboBoxTipo";
            comboBoxTipo.Size = new Size(138, 28);
            comboBoxTipo.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(417, 497);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 23;
            label3.Text = "Tipo:";
            // 
            // PesquisaMarca
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 561);
            Controls.Add(comboBoxTipo);
            Controls.Add(label3);
            Controls.Add(buttonPesquisar);
            Controls.Add(label1);
            Controls.Add(textBoxPesquisar);
            Controls.Add(dataGridViewPesquisar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PesquisaMarca";
            Text = "PesquisarMarca";
            ControlRemoved += buttonPesquisar_Click;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPesquisar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonPesquisar;
        private Label label1;
        private TextBox textBoxPesquisar;
        private DataGridView dataGridViewPesquisar;
        private ComboBox comboBoxTipo;
        private Label label3;
    }
}