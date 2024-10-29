namespace TCC_SIA.View
{
    partial class ListaPecas
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
            ((System.ComponentModel.ISupportInitialize)dataGridViewPesquisar).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewPesquisar
            // 
            dataGridViewPesquisar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPesquisar.Location = new Point(12, 13);
            dataGridViewPesquisar.Margin = new Padding(3, 4, 3, 4);
            dataGridViewPesquisar.Name = "dataGridViewPesquisar";
            dataGridViewPesquisar.RowHeadersWidth = 51;
            dataGridViewPesquisar.Size = new Size(786, 486);
            dataGridViewPesquisar.TabIndex = 20;
            // 
            // ListaPecas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(814, 512);
            Controls.Add(dataGridViewPesquisar);
            Name = "ListaPecas";
            Text = "ListaPecas";
            ((System.ComponentModel.ISupportInitialize)dataGridViewPesquisar).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridViewPesquisar;
    }
}