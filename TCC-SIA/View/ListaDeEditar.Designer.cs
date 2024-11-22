namespace TCC_SIA.View
{
    partial class ListaDeEditar
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
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(153, 174, 230);
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button6.ForeColor = Color.White;
            button6.Location = new Point(12, 322);
            button6.Name = "button6";
            button6.Size = new Size(302, 56);
            button6.TabIndex = 11;
            button6.Text = "Pedido";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(153, 174, 230);
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button5.ForeColor = Color.White;
            button5.Location = new Point(12, 260);
            button5.Name = "button5";
            button5.Size = new Size(302, 56);
            button5.TabIndex = 10;
            button5.Text = "Veículo";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(153, 174, 230);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button4.ForeColor = Color.White;
            button4.Location = new Point(12, 198);
            button4.Name = "button4";
            button4.Size = new Size(302, 56);
            button4.TabIndex = 9;
            button4.Text = "Peça";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(153, 174, 230);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Location = new Point(12, 136);
            button3.Name = "button3";
            button3.Size = new Size(302, 56);
            button3.TabIndex = 8;
            button3.Text = "Serviço";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(153, 174, 230);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(12, 74);
            button2.Name = "button2";
            button2.Size = new Size(302, 56);
            button2.TabIndex = 7;
            button2.Text = "Marca";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(153, 174, 230);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(302, 56);
            button1.TabIndex = 6;
            button1.Text = "Cliente";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ListaDeEditar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 91, 166);
            ClientSize = new Size(325, 389);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "ListaDeEditar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ListaDeEditar";
            ResumeLayout(false);
        }

        #endregion

        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}