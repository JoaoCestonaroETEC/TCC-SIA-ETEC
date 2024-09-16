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
            tabControlPesquisarClientes = new TabControl();
            tabPagePesquisarClienteF = new TabPage();
            btnDeletarF = new Button();
            btnAtualizarF = new Button();
            buttonPesquisarF = new Button();
            label1 = new Label();
            textBoxPesquisarF = new TextBox();
            dataGridViewPesquisarF = new DataGridView();
            tabControlPesquisarClienteJ = new TabPage();
            btnDeletarJ = new Button();
            btnAtualizarJ = new Button();
            buttonPesquisarJ = new Button();
            label2 = new Label();
            textBoxPesquisarJ = new TextBox();
            dataGridViewPesquisarJ = new DataGridView();
            tabControlPesquisarClientes.SuspendLayout();
            tabPagePesquisarClienteF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPesquisarF).BeginInit();
            tabControlPesquisarClienteJ.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPesquisarJ).BeginInit();
            SuspendLayout();
            // 
            // tabControlPesquisarClientes
            // 
            tabControlPesquisarClientes.Controls.Add(tabPagePesquisarClienteF);
            tabControlPesquisarClientes.Controls.Add(tabControlPesquisarClienteJ);
            tabControlPesquisarClientes.Location = new Point(10, 9);
            tabControlPesquisarClientes.Margin = new Padding(3, 2, 3, 2);
            tabControlPesquisarClientes.Name = "tabControlPesquisarClientes";
            tabControlPesquisarClientes.SelectedIndex = 0;
            tabControlPesquisarClientes.Size = new Size(747, 425);
            tabControlPesquisarClientes.TabIndex = 0;
            // 
            // tabPagePesquisarClienteF
            // 
            tabPagePesquisarClienteF.Controls.Add(btnDeletarF);
            tabPagePesquisarClienteF.Controls.Add(btnAtualizarF);
            tabPagePesquisarClienteF.Controls.Add(buttonPesquisarF);
            tabPagePesquisarClienteF.Controls.Add(label1);
            tabPagePesquisarClienteF.Controls.Add(textBoxPesquisarF);
            tabPagePesquisarClienteF.Controls.Add(dataGridViewPesquisarF);
            tabPagePesquisarClienteF.Location = new Point(4, 24);
            tabPagePesquisarClienteF.Margin = new Padding(3, 2, 3, 2);
            tabPagePesquisarClienteF.Name = "tabPagePesquisarClienteF";
            tabPagePesquisarClienteF.Padding = new Padding(3, 2, 3, 2);
            tabPagePesquisarClienteF.Size = new Size(739, 397);
            tabPagePesquisarClienteF.TabIndex = 0;
            tabPagePesquisarClienteF.Text = "Pesquisar Cliente Físico";
            tabPagePesquisarClienteF.UseVisualStyleBackColor = true;
            // 
            // btnDeletarF
            // 
            btnDeletarF.Location = new Point(620, 331);
            btnDeletarF.Margin = new Padding(3, 2, 3, 2);
            btnDeletarF.Name = "btnDeletarF";
            btnDeletarF.Size = new Size(115, 48);
            btnDeletarF.TabIndex = 9;
            btnDeletarF.Text = "Deletar";
            btnDeletarF.UseVisualStyleBackColor = true;
            btnDeletarF.Click += btnDeletar_Click;
            // 
            // btnAtualizarF
            // 
            btnAtualizarF.Location = new Point(492, 331);
            btnAtualizarF.Margin = new Padding(3, 2, 3, 2);
            btnAtualizarF.Name = "btnAtualizarF";
            btnAtualizarF.Size = new Size(115, 48);
            btnAtualizarF.TabIndex = 8;
            btnAtualizarF.Text = "Editar";
            btnAtualizarF.UseVisualStyleBackColor = true;
            btnAtualizarF.Click += AtualizarCliente;
            // 
            // buttonPesquisarF
            // 
            buttonPesquisarF.Location = new Point(5, 331);
            buttonPesquisarF.Name = "buttonPesquisarF";
            buttonPesquisarF.Size = new Size(115, 48);
            buttonPesquisarF.TabIndex = 7;
            buttonPesquisarF.Text = "Pesquisar";
            buttonPesquisarF.UseVisualStyleBackColor = true;
            buttonPesquisarF.Click += buttonPesquisar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 9);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 6;
            label1.Text = "Pesquisar:";
            // 
            // textBoxPesquisarF
            // 
            textBoxPesquisarF.Location = new Point(81, 7);
            textBoxPesquisarF.Name = "textBoxPesquisarF";
            textBoxPesquisarF.Size = new Size(654, 23);
            textBoxPesquisarF.TabIndex = 5;
            // 
            // dataGridViewPesquisarF
            // 
            dataGridViewPesquisarF.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPesquisarF.Location = new Point(5, 33);
            dataGridViewPesquisarF.Name = "dataGridViewPesquisarF";
            dataGridViewPesquisarF.RowHeadersWidth = 51;
            dataGridViewPesquisarF.Size = new Size(730, 287);
            dataGridViewPesquisarF.TabIndex = 4;
            // 
            // tabControlPesquisarClienteJ
            // 
            tabControlPesquisarClienteJ.Controls.Add(btnDeletarJ);
            tabControlPesquisarClienteJ.Controls.Add(btnAtualizarJ);
            tabControlPesquisarClienteJ.Controls.Add(buttonPesquisarJ);
            tabControlPesquisarClienteJ.Controls.Add(label2);
            tabControlPesquisarClienteJ.Controls.Add(textBoxPesquisarJ);
            tabControlPesquisarClienteJ.Controls.Add(dataGridViewPesquisarJ);
            tabControlPesquisarClienteJ.Location = new Point(4, 24);
            tabControlPesquisarClienteJ.Margin = new Padding(3, 2, 3, 2);
            tabControlPesquisarClienteJ.Name = "tabControlPesquisarClienteJ";
            tabControlPesquisarClienteJ.Padding = new Padding(3, 2, 3, 2);
            tabControlPesquisarClienteJ.Size = new Size(739, 397);
            tabControlPesquisarClienteJ.TabIndex = 1;
            tabControlPesquisarClienteJ.Text = "Pesquisar Cliente Júridico";
            tabControlPesquisarClienteJ.UseVisualStyleBackColor = true;
            // 
            // btnDeletarJ
            // 
            btnDeletarJ.Location = new Point(619, 336);
            btnDeletarJ.Margin = new Padding(3, 2, 3, 2);
            btnDeletarJ.Name = "btnDeletarJ";
            btnDeletarJ.Size = new Size(115, 48);
            btnDeletarJ.TabIndex = 15;
            btnDeletarJ.Text = "Deletar";
            btnDeletarJ.UseVisualStyleBackColor = true;
            // 
            // btnAtualizarJ
            // 
            btnAtualizarJ.Location = new Point(491, 336);
            btnAtualizarJ.Margin = new Padding(3, 2, 3, 2);
            btnAtualizarJ.Name = "btnAtualizarJ";
            btnAtualizarJ.Size = new Size(115, 48);
            btnAtualizarJ.TabIndex = 14;
            btnAtualizarJ.Text = "Editar";
            btnAtualizarJ.UseVisualStyleBackColor = true;
            // 
            // buttonPesquisarJ
            // 
            buttonPesquisarJ.Location = new Point(4, 336);
            buttonPesquisarJ.Name = "buttonPesquisarJ";
            buttonPesquisarJ.Size = new Size(115, 48);
            buttonPesquisarJ.TabIndex = 13;
            buttonPesquisarJ.Text = "Pesquisar";
            buttonPesquisarJ.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 7);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 12;
            label2.Text = "Pesquisar:";
            // 
            // textBoxPesquisarJ
            // 
            textBoxPesquisarJ.Location = new Point(80, 5);
            textBoxPesquisarJ.Name = "textBoxPesquisarJ";
            textBoxPesquisarJ.Size = new Size(654, 23);
            textBoxPesquisarJ.TabIndex = 11;
            // 
            // dataGridViewPesquisarJ
            // 
            dataGridViewPesquisarJ.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPesquisarJ.Location = new Point(4, 31);
            dataGridViewPesquisarJ.Name = "dataGridViewPesquisarJ";
            dataGridViewPesquisarJ.RowHeadersWidth = 51;
            dataGridViewPesquisarJ.Size = new Size(730, 287);
            dataGridViewPesquisarJ.TabIndex = 10;
            // 
            // PesquisaCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(768, 445);
            Controls.Add(tabControlPesquisarClientes);
            Name = "PesquisaCliente";
            Text = "PesquisarCliente";
            tabControlPesquisarClientes.ResumeLayout(false);
            tabPagePesquisarClienteF.ResumeLayout(false);
            tabPagePesquisarClienteF.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPesquisarF).EndInit();
            tabControlPesquisarClienteJ.ResumeLayout(false);
            tabControlPesquisarClienteJ.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPesquisarJ).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlPesquisarClientes;
        private TabPage tabPagePesquisarClienteF;
        private Button buttonPesquisarF;
        private Label label1;
        private TextBox textBoxPesquisarF;
        private DataGridView dataGridViewPesquisarF;
        private TabPage tabControlPesquisarClienteJ;
        private Button btnAtualizarF;
        private Button btnDeletarF;
        private Button btnDeletarJ;
        private Button btnAtualizarJ;
        private Button buttonPesquisarJ;
        private Label label2;
        private TextBox textBoxPesquisarJ;
        private DataGridView dataGridViewPesquisarJ;
    }
}