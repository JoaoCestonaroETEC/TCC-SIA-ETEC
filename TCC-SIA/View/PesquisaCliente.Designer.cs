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
            tabControlPesquisarClientes.Location = new Point(11, 12);
            tabControlPesquisarClientes.Name = "tabControlPesquisarClientes";
            tabControlPesquisarClientes.SelectedIndex = 0;
            tabControlPesquisarClientes.Size = new Size(854, 567);
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
            tabPagePesquisarClienteF.Location = new Point(4, 29);
            tabPagePesquisarClienteF.Name = "tabPagePesquisarClienteF";
            tabPagePesquisarClienteF.Padding = new Padding(3, 3, 3, 3);
            tabPagePesquisarClienteF.Size = new Size(846, 534);
            tabPagePesquisarClienteF.TabIndex = 0;
            tabPagePesquisarClienteF.Text = "Pesquisar Cliente Físico";
            tabPagePesquisarClienteF.UseVisualStyleBackColor = true;
            // 
            // btnDeletarF
            // 
            btnDeletarF.Location = new Point(709, 441);
            btnDeletarF.Name = "btnDeletarF";
            btnDeletarF.Size = new Size(131, 64);
            btnDeletarF.TabIndex = 9;
            btnDeletarF.Text = "Deletar";
            btnDeletarF.UseVisualStyleBackColor = true;
            btnDeletarF.Click += btnDeletar_Click;
            // 
            // btnAtualizarF
            // 
            btnAtualizarF.Location = new Point(562, 441);
            btnAtualizarF.Name = "btnAtualizarF";
            btnAtualizarF.Size = new Size(131, 64);
            btnAtualizarF.TabIndex = 8;
            btnAtualizarF.Text = "Editar";
            btnAtualizarF.UseVisualStyleBackColor = true;
            btnAtualizarF.Click += AtualizarCliente;
            // 
            // buttonPesquisarF
            // 
            buttonPesquisarF.Location = new Point(6, 441);
            buttonPesquisarF.Margin = new Padding(3, 4, 3, 4);
            buttonPesquisarF.Name = "buttonPesquisarF";
            buttonPesquisarF.Size = new Size(131, 64);
            buttonPesquisarF.TabIndex = 7;
            buttonPesquisarF.Text = "Pesquisar";
            buttonPesquisarF.UseVisualStyleBackColor = true;
            buttonPesquisarF.Click += buttonPesquisar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 12);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 6;
            label1.Text = "Pesquisar:";
            // 
            // textBoxPesquisarF
            // 
            textBoxPesquisarF.Location = new Point(93, 9);
            textBoxPesquisarF.Margin = new Padding(3, 4, 3, 4);
            textBoxPesquisarF.Name = "textBoxPesquisarF";
            textBoxPesquisarF.Size = new Size(747, 27);
            textBoxPesquisarF.TabIndex = 5;
            // 
            // dataGridViewPesquisarF
            // 
            dataGridViewPesquisarF.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPesquisarF.Location = new Point(6, 44);
            dataGridViewPesquisarF.Margin = new Padding(3, 4, 3, 4);
            dataGridViewPesquisarF.Name = "dataGridViewPesquisarF";
            dataGridViewPesquisarF.RowHeadersWidth = 51;
            dataGridViewPesquisarF.Size = new Size(834, 383);
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
            tabControlPesquisarClienteJ.Location = new Point(4, 29);
            tabControlPesquisarClienteJ.Name = "tabControlPesquisarClienteJ";
            tabControlPesquisarClienteJ.Padding = new Padding(3, 3, 3, 3);
            tabControlPesquisarClienteJ.Size = new Size(846, 534);
            tabControlPesquisarClienteJ.TabIndex = 1;
            tabControlPesquisarClienteJ.Text = "Pesquisar Cliente Júridico";
            tabControlPesquisarClienteJ.UseVisualStyleBackColor = true;
            // 
            // btnDeletarJ
            // 
            btnDeletarJ.Location = new Point(707, 448);
            btnDeletarJ.Name = "btnDeletarJ";
            btnDeletarJ.Size = new Size(131, 64);
            btnDeletarJ.TabIndex = 15;
            btnDeletarJ.Text = "Deletar";
            btnDeletarJ.UseVisualStyleBackColor = true;
            // 
            // btnAtualizarJ
            // 
            btnAtualizarJ.Location = new Point(561, 448);
            btnAtualizarJ.Name = "btnAtualizarJ";
            btnAtualizarJ.Size = new Size(131, 64);
            btnAtualizarJ.TabIndex = 14;
            btnAtualizarJ.Text = "Editar";
            btnAtualizarJ.UseVisualStyleBackColor = true;
            // 
            // buttonPesquisarJ
            // 
            buttonPesquisarJ.Location = new Point(5, 448);
            buttonPesquisarJ.Margin = new Padding(3, 4, 3, 4);
            buttonPesquisarJ.Name = "buttonPesquisarJ";
            buttonPesquisarJ.Size = new Size(131, 64);
            buttonPesquisarJ.TabIndex = 13;
            buttonPesquisarJ.Text = "Pesquisar";
            buttonPesquisarJ.UseVisualStyleBackColor = true;
            buttonPesquisarJ.Click += buttonPesquisarJ_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 9);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 12;
            label2.Text = "Pesquisar:";
            // 
            // textBoxPesquisarJ
            // 
            textBoxPesquisarJ.Location = new Point(91, 7);
            textBoxPesquisarJ.Margin = new Padding(3, 4, 3, 4);
            textBoxPesquisarJ.Name = "textBoxPesquisarJ";
            textBoxPesquisarJ.Size = new Size(747, 27);
            textBoxPesquisarJ.TabIndex = 11;
            // 
            // dataGridViewPesquisarJ
            // 
            dataGridViewPesquisarJ.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPesquisarJ.Location = new Point(5, 41);
            dataGridViewPesquisarJ.Margin = new Padding(3, 4, 3, 4);
            dataGridViewPesquisarJ.Name = "dataGridViewPesquisarJ";
            dataGridViewPesquisarJ.RowHeadersWidth = 51;
            dataGridViewPesquisarJ.Size = new Size(834, 383);
            dataGridViewPesquisarJ.TabIndex = 10;
            // 
            // PesquisaCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 593);
            Controls.Add(tabControlPesquisarClientes);
            Margin = new Padding(3, 4, 3, 4);
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