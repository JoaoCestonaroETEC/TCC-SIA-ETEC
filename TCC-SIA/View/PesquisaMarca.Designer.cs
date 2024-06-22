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
            ((System.ComponentModel.ISupportInitialize)dataGridViewPesquisar).BeginInit();
            SuspendLayout();
            // 
            // buttonPesquisar
            // 
            buttonPesquisar.Location = new Point(12, 341);
            buttonPesquisar.Name = "buttonPesquisar";
            buttonPesquisar.Size = new Size(119, 71);
            buttonPesquisar.TabIndex = 7;
            buttonPesquisar.Text = "Pesquisar";
            buttonPesquisar.UseVisualStyleBackColor = true;
            buttonPesquisar.Click += buttonPesquisar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 6;
            label1.Text = "Pesquisar:";
            // 
            // textBoxPesquisar
            // 
            textBoxPesquisar.Location = new Point(78, 9);
            textBoxPesquisar.Name = "textBoxPesquisar";
            textBoxPesquisar.Size = new Size(448, 23);
            textBoxPesquisar.TabIndex = 5;
            // 
            // dataGridViewPesquisar
            // 
            dataGridViewPesquisar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPesquisar.Location = new Point(12, 40);
            dataGridViewPesquisar.Name = "dataGridViewPesquisar";
            dataGridViewPesquisar.Size = new Size(514, 295);
            dataGridViewPesquisar.TabIndex = 4;
            // 
            // PesquisarMarca
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(539, 421);
            Controls.Add(buttonPesquisar);
            Controls.Add(label1);
            Controls.Add(textBoxPesquisar);
            Controls.Add(dataGridViewPesquisar);
            Name = "PesquisarMarca";
            Text = "PesquisarMarca";
            ((System.ComponentModel.ISupportInitialize)dataGridViewPesquisar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonPesquisar;
        private Label label1;
        private TextBox textBoxPesquisar;
        private DataGridView dataGridViewPesquisar;
    }
}