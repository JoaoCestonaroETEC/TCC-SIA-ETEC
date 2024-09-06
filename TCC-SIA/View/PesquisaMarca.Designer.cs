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
            checkBoxVeiculo = new CheckBox();
            checkBoxPeca = new CheckBox();
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
            // checkBoxVeiculo
            // 
            checkBoxVeiculo.AutoSize = true;
            checkBoxVeiculo.Location = new Point(387, 495);
            checkBoxVeiculo.Margin = new Padding(3, 4, 3, 4);
            checkBoxVeiculo.Name = "checkBoxVeiculo";
            checkBoxVeiculo.Size = new Size(79, 24);
            checkBoxVeiculo.TabIndex = 16;
            checkBoxVeiculo.Text = "Veículo";
            checkBoxVeiculo.UseVisualStyleBackColor = true;
            // 
            // checkBoxPeca
            // 
            checkBoxPeca.AutoSize = true;
            checkBoxPeca.Location = new Point(467, 495);
            checkBoxPeca.Margin = new Padding(3, 4, 3, 4);
            checkBoxPeca.Name = "checkBoxPeca";
            checkBoxPeca.Size = new Size(61, 24);
            checkBoxPeca.TabIndex = 17;
            checkBoxPeca.Text = "Peça";
            checkBoxPeca.UseVisualStyleBackColor = true;
            // 
            // PesquisaMarca
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 561);
            Controls.Add(checkBoxPeca);
            Controls.Add(checkBoxVeiculo);
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
        private CheckBox checkBoxVeiculo;
        private CheckBox checkBoxPeca;
    }
}