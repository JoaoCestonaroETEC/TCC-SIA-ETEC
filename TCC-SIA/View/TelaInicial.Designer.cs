namespace TCC_SIA.View
{
    partial class TelaInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaInicial));
            contextMenuStrip1 = new ContextMenuStrip(components);
            cadastroToolStripMenuItem = new ToolStripMenuItem();
            editarDeletarToolStripMenuItem = new ToolStripMenuItem();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            button2 = new Button();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            contextMenuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { cadastroToolStripMenuItem, editarDeletarToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(173, 52);
            // 
            // cadastroToolStripMenuItem
            // 
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Size = new Size(172, 24);
            cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // editarDeletarToolStripMenuItem
            // 
            editarDeletarToolStripMenuItem.Name = "editarDeletarToolStripMenuItem";
            editarDeletarToolStripMenuItem.Size = new Size(172, 24);
            editarDeletarToolStripMenuItem.Text = "Editar/Deletar";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(64, 91, 166);
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(17, 12);
            button1.Name = "button1";
            button1.Size = new Size(158, 138);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(304, 97);
            label2.Name = "label2";
            label2.Size = new Size(207, 46);
            label2.TabIndex = 3;
            label2.Text = "Bem Vindo!";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(76, 143);
            label3.Name = "label3";
            label3.Size = new Size(668, 38);
            label3.TabIndex = 4;
            label3.Text = "Ao Sistema de Informatização e Gestão Para Oficinas";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(64, 91, 166);
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(31, 16);
            button2.Name = "button2";
            button2.Size = new Size(127, 131);
            button2.TabIndex = 5;
            button2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(56, 9);
            label1.Name = "label1";
            label1.Size = new Size(81, 38);
            label1.TabIndex = 6;
            label1.Text = "SIGO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(31, 150);
            label4.Name = "label4";
            label4.Size = new Size(133, 38);
            label4.TabIndex = 7;
            label4.Text = "Cadastrar";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(0, 150);
            label5.Name = "label5";
            label5.Size = new Size(188, 38);
            label5.TabIndex = 8;
            label5.Text = "Editar/Deletar";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoSize = true;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(197, 210);
            panel1.Name = "panel1";
            panel1.Size = new Size(198, 188);
            panel1.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.Controls.Add(button2);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(457, 210);
            panel2.Name = "panel2";
            panel2.Size = new Size(191, 196);
            panel2.TabIndex = 10;
            // 
            // TelaInicial
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(64, 91, 166);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(838, 460);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label2);
            Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.Control;
            Margin = new Padding(4);
            Name = "TelaInicial";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela Inicial";
            WindowState = FormWindowState.Minimized;
            contextMenuStrip1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem cadastroToolStripMenuItem;
        private ToolStripMenuItem editarDeletarToolStripMenuItem;
        private Button button1;
        private Label label2;
        private Label label3;
        private Button button2;
        private Label label1;
        private Label label4;
        private Label label5;
        private Panel panel1;
        private Panel panel2;
    }
}