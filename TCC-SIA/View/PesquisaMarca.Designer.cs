﻿namespace TCC_SIA.View
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
            buttonPesquisar.Location = new Point(12, 344);
            buttonPesquisar.Name = "buttonPesquisar";
            buttonPesquisar.Size = new Size(119, 71);
            buttonPesquisar.TabIndex = 15;
            buttonPesquisar.Text = "Pesquisar";
            buttonPesquisar.UseVisualStyleBackColor = true;
            buttonPesquisar.Click += buttonPesquisar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 14;
            label1.Text = "Pesquisar:";
            // 
            // textBoxPesquisar
            // 
            textBoxPesquisar.Location = new Point(78, 12);
            textBoxPesquisar.Name = "textBoxPesquisar";
            textBoxPesquisar.Size = new Size(448, 23);
            textBoxPesquisar.TabIndex = 13;
            // 
            // dataGridViewPesquisar
            // 
            dataGridViewPesquisar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPesquisar.Location = new Point(12, 43);
            dataGridViewPesquisar.Name = "dataGridViewPesquisar";
            dataGridViewPesquisar.Size = new Size(514, 295);
            dataGridViewPesquisar.TabIndex = 12;
            // 
            // checkBoxVeiculo
            // 
            checkBoxVeiculo.AutoSize = true;
            checkBoxVeiculo.Location = new Point(339, 371);
            checkBoxVeiculo.Name = "checkBoxVeiculo";
            checkBoxVeiculo.Size = new Size(64, 19);
            checkBoxVeiculo.TabIndex = 16;
            checkBoxVeiculo.Text = "Veículo";
            checkBoxVeiculo.UseVisualStyleBackColor = true;
            // 
            // checkBoxPeca
            // 
            checkBoxPeca.AutoSize = true;
            checkBoxPeca.Location = new Point(409, 371);
            checkBoxPeca.Name = "checkBoxPeca";
            checkBoxPeca.Size = new Size(51, 19);
            checkBoxPeca.TabIndex = 17;
            checkBoxPeca.Text = "Peça";
            checkBoxPeca.UseVisualStyleBackColor = true;
            // 
            // PesquisaMarca
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(553, 421);
            Controls.Add(checkBoxPeca);
            Controls.Add(checkBoxVeiculo);
            Controls.Add(buttonPesquisar);
            Controls.Add(label1);
            Controls.Add(textBoxPesquisar);
            Controls.Add(dataGridViewPesquisar);
            Name = "PesquisaMarca";
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
        private CheckBox checkBoxVeiculo;
        private CheckBox checkBoxPeca;
    }
}