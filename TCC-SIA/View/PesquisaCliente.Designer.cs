namespace TCC_SIA.View
{
    partial class PesquisaCliente
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
            dataGridViewPesquisar = new DataGridView();
            textBoxPesquisar = new TextBox();
            label1 = new Label();
            buttonPesquisar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPesquisar).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewPesquisar
            // 
            dataGridViewPesquisar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPesquisar.Location = new Point(12, 43);
            dataGridViewPesquisar.Name = "dataGridViewPesquisar";
            dataGridViewPesquisar.Size = new Size(514, 295);
            dataGridViewPesquisar.TabIndex = 0;
            // 
            // textBoxPesquisar
            // 
            textBoxPesquisar.Location = new Point(78, 12);
            textBoxPesquisar.Name = "textBoxPesquisar";
            textBoxPesquisar.Size = new Size(448, 23);
            textBoxPesquisar.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 2;
            label1.Text = "Pesquisar:";
            // 
            // buttonPesquisar
            // 
            buttonPesquisar.Location = new Point(12, 344);
            buttonPesquisar.Name = "buttonPesquisar";
            buttonPesquisar.Size = new Size(119, 71);
            buttonPesquisar.TabIndex = 3;
            buttonPesquisar.Text = "Pesquisar";
            buttonPesquisar.UseVisualStyleBackColor = true;
            buttonPesquisar.Click += buttonPesquisar_Click;
            // 
            // PesquisaCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(538, 427);
            Controls.Add(buttonPesquisar);
            Controls.Add(label1);
            Controls.Add(textBoxPesquisar);
            Controls.Add(dataGridViewPesquisar);
            Name = "PesquisaCliente";
            Text = "PesquisarCliente";
            ((System.ComponentModel.ISupportInitialize)dataGridViewPesquisar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewPesquisar;
        private TextBox textBoxPesquisar;
        private Label label1;
        private Button buttonPesquisar;
    }
}