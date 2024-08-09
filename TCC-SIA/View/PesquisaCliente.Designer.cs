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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnDeletar = new Button();
            btnAtualizar = new Button();
            buttonPesquisar = new Button();
            label1 = new Label();
            textBoxPesquisar = new TextBox();
            dataGridViewPesquisar = new DataGridView();
            tabPage2 = new TabPage();
            btnSalvarA = new Button();
            maskedID = new MaskedTextBox();
            maskTelefone = new MaskedTextBox();
            txbCidade = new TextBox();
            cbEstado = new ComboBox();
            txbBairro = new TextBox();
            maskCep = new MaskedTextBox();
            txbRua = new TextBox();
            maskNumero = new MaskedTextBox();
            cbSexo = new ComboBox();
            dtpNasc = new DateTimePicker();
            txbEmail = new TextBox();
            txbNome = new TextBox();
            maskedCPF = new MaskedTextBox();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPesquisar).BeginInit();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(854, 545);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnDeletar);
            tabPage1.Controls.Add(btnAtualizar);
            tabPage1.Controls.Add(buttonPesquisar);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(textBoxPesquisar);
            tabPage1.Controls.Add(dataGridViewPesquisar);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(846, 512);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Pesquisar";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnDeletar
            // 
            btnDeletar.Location = new Point(709, 441);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(131, 64);
            btnDeletar.TabIndex = 9;
            btnDeletar.Text = "Deletar";
            btnDeletar.UseVisualStyleBackColor = true;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(562, 441);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(131, 64);
            btnAtualizar.TabIndex = 8;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += AtualizarCliente;
            // 
            // buttonPesquisar
            // 
            buttonPesquisar.Location = new Point(6, 441);
            buttonPesquisar.Margin = new Padding(3, 4, 3, 4);
            buttonPesquisar.Name = "buttonPesquisar";
            buttonPesquisar.Size = new Size(131, 64);
            buttonPesquisar.TabIndex = 7;
            buttonPesquisar.Text = "Pesquisar";
            buttonPesquisar.UseVisualStyleBackColor = true;
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
            // textBoxPesquisar
            // 
            textBoxPesquisar.Location = new Point(93, 9);
            textBoxPesquisar.Margin = new Padding(3, 4, 3, 4);
            textBoxPesquisar.Name = "textBoxPesquisar";
            textBoxPesquisar.Size = new Size(747, 27);
            textBoxPesquisar.TabIndex = 5;
            // 
            // dataGridViewPesquisar
            // 
            dataGridViewPesquisar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPesquisar.Location = new Point(6, 44);
            dataGridViewPesquisar.Margin = new Padding(3, 4, 3, 4);
            dataGridViewPesquisar.Name = "dataGridViewPesquisar";
            dataGridViewPesquisar.RowHeadersWidth = 51;
            dataGridViewPesquisar.Size = new Size(834, 383);
            dataGridViewPesquisar.TabIndex = 4;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnSalvarA);
            tabPage2.Controls.Add(maskedID);
            tabPage2.Controls.Add(maskTelefone);
            tabPage2.Controls.Add(txbCidade);
            tabPage2.Controls.Add(cbEstado);
            tabPage2.Controls.Add(txbBairro);
            tabPage2.Controls.Add(maskCep);
            tabPage2.Controls.Add(txbRua);
            tabPage2.Controls.Add(maskNumero);
            tabPage2.Controls.Add(cbSexo);
            tabPage2.Controls.Add(dtpNasc);
            tabPage2.Controls.Add(txbEmail);
            tabPage2.Controls.Add(txbNome);
            tabPage2.Controls.Add(maskedCPF);
            tabPage2.Controls.Add(label14);
            tabPage2.Controls.Add(label13);
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(846, 512);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Atualizar";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnSalvarA
            // 
            btnSalvarA.Location = new Point(22, 421);
            btnSalvarA.Name = "btnSalvarA";
            btnSalvarA.Size = new Size(148, 70);
            btnSalvarA.TabIndex = 27;
            btnSalvarA.Text = "Salvar";
            btnSalvarA.UseVisualStyleBackColor = true;
            // 
            // maskedID
            // 
            maskedID.Enabled = false;
            maskedID.Location = new Point(714, 173);
            maskedID.Name = "maskedID";
            maskedID.Size = new Size(126, 27);
            maskedID.TabIndex = 26;
            // 
            // maskTelefone
            // 
            maskTelefone.Location = new Point(683, 122);
            maskTelefone.Mask = "(00) 00000-0000";
            maskTelefone.Name = "maskTelefone";
            maskTelefone.Size = new Size(157, 27);
            maskTelefone.TabIndex = 25;
            // 
            // txbCidade
            // 
            txbCidade.Location = new Point(393, 173);
            txbCidade.Name = "txbCidade";
            txbCidade.Size = new Size(186, 27);
            txbCidade.TabIndex = 24;
            // 
            // cbEstado
            // 
            cbEstado.FormattingEnabled = true;
            cbEstado.Location = new Point(674, 73);
            cbEstado.Name = "cbEstado";
            cbEstado.Size = new Size(72, 28);
            cbEstado.TabIndex = 23;
            // 
            // txbBairro
            // 
            txbBairro.Location = new Point(397, 265);
            txbBairro.Name = "txbBairro";
            txbBairro.Size = new Size(182, 27);
            txbBairro.TabIndex = 22;
            // 
            // maskCep
            // 
            maskCep.Location = new Point(393, 217);
            maskCep.Mask = "00000-000";
            maskCep.Name = "maskCep";
            maskCep.Size = new Size(186, 27);
            maskCep.TabIndex = 21;
            // 
            // txbRua
            // 
            txbRua.Location = new Point(372, 122);
            txbRua.Name = "txbRua";
            txbRua.Size = new Size(207, 27);
            txbRua.TabIndex = 19;
            // 
            // maskNumero
            // 
            maskNumero.Location = new Point(454, 76);
            maskNumero.Name = "maskNumero";
            maskNumero.Size = new Size(125, 27);
            maskNumero.TabIndex = 18;
            // 
            // cbSexo
            // 
            cbSexo.FormattingEnabled = true;
            cbSexo.Location = new Point(78, 265);
            cbSexo.Name = "cbSexo";
            cbSexo.Size = new Size(106, 28);
            cbSexo.TabIndex = 17;
            // 
            // dtpNasc
            // 
            dtpNasc.Format = DateTimePickerFormat.Custom;
            dtpNasc.Location = new Point(176, 215);
            dtpNasc.Name = "dtpNasc";
            dtpNasc.Size = new Size(99, 27);
            dtpNasc.TabIndex = 16;
            // 
            // txbEmail
            // 
            txbEmail.Location = new Point(78, 173);
            txbEmail.Name = "txbEmail";
            txbEmail.Size = new Size(197, 27);
            txbEmail.TabIndex = 15;
            // 
            // txbNome
            // 
            txbNome.Location = new Point(78, 122);
            txbNome.Name = "txbNome";
            txbNome.Size = new Size(197, 27);
            txbNome.TabIndex = 14;
            // 
            // maskedCPF
            // 
            maskedCPF.Location = new Point(78, 76);
            maskedCPF.Mask = "000000000-00";
            maskedCPF.Name = "maskedCPF";
            maskedCPF.Size = new Size(197, 27);
            maskedCPF.TabIndex = 13;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(611, 125);
            label14.Name = "label14";
            label14.Size = new Size(69, 20);
            label14.TabIndex = 12;
            label14.Text = "Telefone:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(611, 76);
            label13.Name = "label13";
            label13.Size = new Size(57, 20);
            label13.TabIndex = 11;
            label13.Text = "Estado:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(329, 268);
            label12.Name = "label12";
            label12.Size = new Size(52, 20);
            label12.TabIndex = 10;
            label12.Text = "Bairro:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(611, 176);
            label11.Name = "label11";
            label11.Size = new Size(97, 20);
            label11.TabIndex = 9;
            label11.Text = "Id do Cliente:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(329, 220);
            label10.Name = "label10";
            label10.Size = new Size(38, 20);
            label10.TabIndex = 8;
            label10.Text = "Cep:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(329, 176);
            label9.Name = "label9";
            label9.Size = new Size(59, 20);
            label9.TabIndex = 7;
            label9.Text = "Cidade:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(329, 125);
            label8.Name = "label8";
            label8.Size = new Size(37, 20);
            label8.TabIndex = 6;
            label8.Text = "Rua:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(329, 76);
            label7.Name = "label7";
            label7.Size = new Size(122, 20);
            label7.TabIndex = 5;
            label7.Text = "Numero da Casa:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 268);
            label6.Name = "label6";
            label6.Size = new Size(44, 20);
            label6.TabIndex = 4;
            label6.Text = "Sexo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 220);
            label5.Name = "label5";
            label5.Size = new Size(148, 20);
            label5.TabIndex = 3;
            label5.Text = "Data de Nascimento:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 176);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 2;
            label4.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 125);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 1;
            label3.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 76);
            label2.Name = "label2";
            label2.Size = new Size(36, 20);
            label2.TabIndex = 0;
            label2.Text = "CPF:";
            // 
            // PesquisaCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 569);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PesquisaCliente";
            Text = "PesquisarCliente";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPesquisar).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button buttonPesquisar;
        private Label label1;
        private TextBox textBoxPesquisar;
        private DataGridView dataGridViewPesquisar;
        private TabPage tabPage2;
        private Button btnAtualizar;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnDeletar;
        private TextBox txbRua;
        private MaskedTextBox maskNumero;
        private ComboBox cbSexo;
        private DateTimePicker dtpNasc;
        private TextBox txbEmail;
        private TextBox txbNome;
        private MaskedTextBox maskedCPF;
        private MaskedTextBox maskedID;
        private MaskedTextBox maskTelefone;
        private TextBox txbCidade;
        private ComboBox cbEstado;
        private TextBox txbBairro;
        private MaskedTextBox maskCep;
        private Button btnSalvarA;
    }
}