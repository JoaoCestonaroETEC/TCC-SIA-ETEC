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
            menuStrip1 = new MenuStrip();
            cADASTRARToolStripMenuItem = new ToolStripMenuItem();
            sERVIÇOToolStripMenuItem = new ToolStripMenuItem();
            pEÇAToolStripMenuItem = new ToolStripMenuItem();
            cLIENTEToolStripMenuItem = new ToolStripMenuItem();
            vEÍCULOToolStripMenuItem = new ToolStripMenuItem();
            mARCAToolStripMenuItem = new ToolStripMenuItem();
            pEDIDOToolStripMenuItem = new ToolStripMenuItem();
            pESQUISARToolStripMenuItem = new ToolStripMenuItem();
            sERVIÇOToolStripMenuItem1 = new ToolStripMenuItem();
            pEÇAToolStripMenuItem1 = new ToolStripMenuItem();
            cLIENTEToolStripMenuItem1 = new ToolStripMenuItem();
            vEÍCULOToolStripMenuItem1 = new ToolStripMenuItem();
            mARCAToolStripMenuItem1 = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            contextMenuStrip1 = new ContextMenuStrip(components);
            cadastroToolStripMenuItem = new ToolStripMenuItem();
            editarDeletarToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            pEDIDOToolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            panel2.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(65, 90, 245);
            menuStrip1.Font = new Font("Segoe UI", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { cADASTRARToolStripMenuItem, pESQUISARToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(10, 4, 0, 4);
            menuStrip1.Size = new Size(900, 53);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cADASTRARToolStripMenuItem
            // 
            cADASTRARToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sERVIÇOToolStripMenuItem, pEÇAToolStripMenuItem, cLIENTEToolStripMenuItem, vEÍCULOToolStripMenuItem, mARCAToolStripMenuItem, pEDIDOToolStripMenuItem });
            cADASTRARToolStripMenuItem.ForeColor = Color.White;
            cADASTRARToolStripMenuItem.Name = "cADASTRARToolStripMenuItem";
            cADASTRARToolStripMenuItem.Size = new Size(194, 45);
            cADASTRARToolStripMenuItem.Text = "CADASTRAR";
            // 
            // sERVIÇOToolStripMenuItem
            // 
            sERVIÇOToolStripMenuItem.Name = "sERVIÇOToolStripMenuItem";
            sERVIÇOToolStripMenuItem.Size = new Size(229, 46);
            sERVIÇOToolStripMenuItem.Text = "SERVIÇO";
            sERVIÇOToolStripMenuItem.Click += sERVIÇOToolStripMenuItem_Click;
            // 
            // pEÇAToolStripMenuItem
            // 
            pEÇAToolStripMenuItem.Name = "pEÇAToolStripMenuItem";
            pEÇAToolStripMenuItem.Size = new Size(229, 46);
            pEÇAToolStripMenuItem.Text = "PEÇA";
            pEÇAToolStripMenuItem.Click += pEÇAToolStripMenuItem_Click;
            // 
            // cLIENTEToolStripMenuItem
            // 
            cLIENTEToolStripMenuItem.Name = "cLIENTEToolStripMenuItem";
            cLIENTEToolStripMenuItem.Size = new Size(229, 46);
            cLIENTEToolStripMenuItem.Text = "CLIENTE";
            cLIENTEToolStripMenuItem.Click += cLIENTEToolStripMenuItem_Click;
            // 
            // vEÍCULOToolStripMenuItem
            // 
            vEÍCULOToolStripMenuItem.Name = "vEÍCULOToolStripMenuItem";
            vEÍCULOToolStripMenuItem.Size = new Size(229, 46);
            vEÍCULOToolStripMenuItem.Text = "VEÍCULO";
            vEÍCULOToolStripMenuItem.Click += vEÍCULOToolStripMenuItem_Click;
            // 
            // mARCAToolStripMenuItem
            // 
            mARCAToolStripMenuItem.Name = "mARCAToolStripMenuItem";
            mARCAToolStripMenuItem.Size = new Size(229, 46);
            mARCAToolStripMenuItem.Text = "MARCA";
            mARCAToolStripMenuItem.Click += mARCAToolStripMenuItem_Click;
            // 
            // pEDIDOToolStripMenuItem
            // 
            pEDIDOToolStripMenuItem.Name = "pEDIDOToolStripMenuItem";
            pEDIDOToolStripMenuItem.Size = new Size(229, 46);
            pEDIDOToolStripMenuItem.Text = "PEDIDO";
            pEDIDOToolStripMenuItem.Click += pEDIDOToolStripMenuItem_Click;
            // 
            // pESQUISARToolStripMenuItem
            // 
            pESQUISARToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sERVIÇOToolStripMenuItem1, pEÇAToolStripMenuItem1, cLIENTEToolStripMenuItem1, vEÍCULOToolStripMenuItem1, mARCAToolStripMenuItem1, pEDIDOToolStripMenuItem1 });
            pESQUISARToolStripMenuItem.ForeColor = Color.White;
            pESQUISARToolStripMenuItem.Name = "pESQUISARToolStripMenuItem";
            pESQUISARToolStripMenuItem.Size = new Size(290, 45);
            pESQUISARToolStripMenuItem.Text = "PESQUISAR/EDITAR";
            // 
            // sERVIÇOToolStripMenuItem1
            // 
            sERVIÇOToolStripMenuItem1.Name = "sERVIÇOToolStripMenuItem1";
            sERVIÇOToolStripMenuItem1.Size = new Size(229, 46);
            sERVIÇOToolStripMenuItem1.Text = "SERVIÇO";
            sERVIÇOToolStripMenuItem1.Click += sERVIÇOToolStripMenuItem1_Click;
            // 
            // pEÇAToolStripMenuItem1
            // 
            pEÇAToolStripMenuItem1.Name = "pEÇAToolStripMenuItem1";
            pEÇAToolStripMenuItem1.Size = new Size(229, 46);
            pEÇAToolStripMenuItem1.Text = "PEÇA";
            pEÇAToolStripMenuItem1.Click += pEÇAToolStripMenuItem1_Click;
            // 
            // cLIENTEToolStripMenuItem1
            // 
            cLIENTEToolStripMenuItem1.Name = "cLIENTEToolStripMenuItem1";
            cLIENTEToolStripMenuItem1.Size = new Size(229, 46);
            cLIENTEToolStripMenuItem1.Text = "CLIENTE";
            cLIENTEToolStripMenuItem1.Click += cLIENTEToolStripMenuItem1_Click;
            // 
            // vEÍCULOToolStripMenuItem1
            // 
            vEÍCULOToolStripMenuItem1.Name = "vEÍCULOToolStripMenuItem1";
            vEÍCULOToolStripMenuItem1.Size = new Size(229, 46);
            vEÍCULOToolStripMenuItem1.Text = "VEÍCULO";
            vEÍCULOToolStripMenuItem1.Click += vEÍCULOToolStripMenuItem1_Click;
            // 
            // mARCAToolStripMenuItem1
            // 
            mARCAToolStripMenuItem1.Name = "mARCAToolStripMenuItem1";
            mARCAToolStripMenuItem1.Size = new Size(229, 46);
            mARCAToolStripMenuItem1.Text = "MARCA";
            mARCAToolStripMenuItem1.Click += mARCAToolStripMenuItem1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(15, 19);
            label1.Name = "label1";
            label1.Size = new Size(344, 81);
            label1.TabIndex = 0;
            label1.Text = "Bem Vindo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(17, 114);
            label2.Name = "label2";
            label2.Size = new Size(585, 54);
            label2.TabIndex = 1;
            label2.Text = "Ao Sistema de informatização";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(17, 174);
            label4.Name = "label4";
            label4.Size = new Size(443, 54);
            label4.TabIndex = 3;
            label4.Text = "e Gestão para Oficinas";
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel2.ForeColor = Color.RoyalBlue;
            panel2.Location = new Point(11, 74);
            panel2.Name = "panel2";
            panel2.Size = new Size(605, 388);
            panel2.TabIndex = 3;
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
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 60);
            panel1.Location = new Point(0, 501);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 40);
            panel1.TabIndex = 5;
            // 
            // pEDIDOToolStripMenuItem1
            // 
            pEDIDOToolStripMenuItem1.Name = "pEDIDOToolStripMenuItem1";
            pEDIDOToolStripMenuItem1.Size = new Size(229, 46);
            pEDIDOToolStripMenuItem1.Text = "PEDIDO";
            pEDIDOToolStripMenuItem1.Click += pEDIDOToolStripMenuItem1_Click;
            // 
            // TelaInicial
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(900, 542);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.Control;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "TelaInicial";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela Inicial";
            WindowState = FormWindowState.Minimized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cADASTRARToolStripMenuItem;
        private ToolStripMenuItem sERVIÇOToolStripMenuItem;
        private ToolStripMenuItem pEÇAToolStripMenuItem;
        private ToolStripMenuItem cLIENTEToolStripMenuItem;
        private ToolStripMenuItem vEÍCULOToolStripMenuItem;
        private ToolStripMenuItem pESQUISARToolStripMenuItem;
        private ToolStripMenuItem sERVIÇOToolStripMenuItem1;
        private ToolStripMenuItem pEÇAToolStripMenuItem1;
        private ToolStripMenuItem cLIENTEToolStripMenuItem1;
        private ToolStripMenuItem vEÍCULOToolStripMenuItem1;
        private ToolStripMenuItem mARCAToolStripMenuItem;
        private ToolStripMenuItem mARCAToolStripMenuItem1;
        private ToolStripMenuItem pEDIDOToolStripMenuItem;
        private Label label1;
        private Label label2;
        private Label label4;
        private Panel panel2;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem cadastroToolStripMenuItem;
        private ToolStripMenuItem editarDeletarToolStripMenuItem;
        private Panel panel1;
        private ToolStripMenuItem pEDIDOToolStripMenuItem1;
    }
}