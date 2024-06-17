namespace TCC_SIA.View
{
    partial class CadastroServiço
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
            btnSalvar = new Button();
            txbNomeServ = new TextBox();
            label1 = new Label();
            label2 = new Label();
            maskValor = new MaskedTextBox();
            SuspendLayout();
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(175, 406);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(211, 102);
            btnSalvar.TabIndex = 0;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += cadastrarServico;
            // 
            // txbNomeServ
            // 
            txbNomeServ.Location = new Point(159, 54);
            txbNomeServ.Name = "txbNomeServ";
            txbNomeServ.Size = new Size(347, 27);
            txbNomeServ.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 57);
            label1.Name = "label1";
            label1.Size = new Size(124, 20);
            label1.TabIndex = 3;
            label1.Text = "Nome do Serviço";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 131);
            label2.Name = "label2";
            label2.Size = new Size(43, 20);
            label2.TabIndex = 4;
            label2.Text = "Valor";
            // 
            // maskValor
            // 
            maskValor.Location = new Point(159, 128);
            maskValor.Mask = "0000000,00";
            maskValor.Name = "maskValor";
            maskValor.Size = new Size(125, 27);
            maskValor.TabIndex = 5;
            // 
            // CadastroServiço
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 585);
            Controls.Add(maskValor);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txbNomeServ);
            Controls.Add(btnSalvar);
            Name = "CadastroServiço";
            Text = "CadastroServiço";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalvar;
        private TextBox txbNomeServ;
        private Label label1;
        private Label label2;
        private MaskedTextBox maskValor;
    }
}