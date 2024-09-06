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
            tabControl1.Location = new Point(10, 9);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(747, 425);
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
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(3, 2, 3, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 2, 3, 2);
            tabPage1.Size = new Size(739, 397);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Pesquisar";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnDeletar
            // 
            btnDeletar.Location = new Point(620, 331);
            btnDeletar.Margin = new Padding(3, 2, 3, 2);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(115, 48);
            btnDeletar.TabIndex = 9;
            btnDeletar.Text = "Deletar";
            btnDeletar.UseVisualStyleBackColor = true;
            btnDeletar.Click += btnDeletar_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(492, 331);
            btnAtualizar.Margin = new Padding(3, 2, 3, 2);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(115, 48);
            btnAtualizar.TabIndex = 8;
            btnAtualizar.Text = "Editar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += AtualizarCliente;
            // 
            // buttonPesquisar
            // 
            buttonPesquisar.Location = new Point(5, 331);
            buttonPesquisar.Name = "buttonPesquisar";
            buttonPesquisar.Size = new Size(115, 48);
            buttonPesquisar.TabIndex = 7;
            buttonPesquisar.Text = "Pesquisar";
            buttonPesquisar.UseVisualStyleBackColor = true;
            buttonPesquisar.Click += buttonPesquisar_Click_1;
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
            // textBoxPesquisar
            // 
            textBoxPesquisar.Location = new Point(81, 7);
            textBoxPesquisar.Name = "textBoxPesquisar";
            textBoxPesquisar.Size = new Size(654, 23);
            textBoxPesquisar.TabIndex = 5;
            // 
            // dataGridViewPesquisar
            // 
            dataGridViewPesquisar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPesquisar.Location = new Point(5, 33);
            dataGridViewPesquisar.Name = "dataGridViewPesquisar";
            dataGridViewPesquisar.RowHeadersWidth = 51;
            dataGridViewPesquisar.Size = new Size(730, 287);
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
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(3, 2, 3, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 2, 3, 2);
            tabPage2.Size = new Size(739, 381);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Editar";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnSalvarA
            // 
            btnSalvarA.Location = new Point(19, 316);
            btnSalvarA.Margin = new Padding(3, 2, 3, 2);
            btnSalvarA.Name = "btnSalvarA";
            btnSalvarA.Size = new Size(130, 52);
            btnSalvarA.TabIndex = 27;
            btnSalvarA.Text = "Salvar";
            btnSalvarA.UseVisualStyleBackColor = true;
            btnSalvarA.Click += btnSalvarA_Click;
            // 
            // maskedID
            // 
            maskedID.Enabled = false;
            maskedID.Location = new Point(625, 130);
            maskedID.Margin = new Padding(3, 2, 3, 2);
            maskedID.Name = "maskedID";
            maskedID.Size = new Size(111, 23);
            maskedID.TabIndex = 26;
            // 
            // maskTelefone
            // 
            maskTelefone.Location = new Point(598, 92);
            maskTelefone.Margin = new Padding(3, 2, 3, 2);
            maskTelefone.Mask = "(00) 00000-0000";
            maskTelefone.Name = "maskTelefone";
            maskTelefone.Size = new Size(138, 23);
            maskTelefone.TabIndex = 25;
            // 
            // txbCidade
            // 
            txbCidade.Location = new Point(344, 130);
            txbCidade.Margin = new Padding(3, 2, 3, 2);
            txbCidade.Name = "txbCidade";
            txbCidade.Size = new Size(163, 23);
            txbCidade.TabIndex = 24;
            // 
            // cbEstado
            // 
            cbEstado.FormattingEnabled = true;
            cbEstado.Location = new Point(590, 55);
            cbEstado.Margin = new Padding(3, 2, 3, 2);
            cbEstado.Name = "cbEstado";
            cbEstado.Size = new Size(64, 23);
            cbEstado.TabIndex = 23;
            // 
            // txbBairro
            // 
            txbBairro.Location = new Point(347, 199);
            txbBairro.Margin = new Padding(3, 2, 3, 2);
            txbBairro.Name = "txbBairro";
            txbBairro.Size = new Size(160, 23);
            txbBairro.TabIndex = 22;
            // 
            // maskCep
            // 
            maskCep.Location = new Point(344, 163);
            maskCep.Margin = new Padding(3, 2, 3, 2);
            maskCep.Mask = "00000-000";
            maskCep.Name = "maskCep";
            maskCep.Size = new Size(163, 23);
            maskCep.TabIndex = 21;
            // 
            // txbRua
            // 
            txbRua.Location = new Point(326, 92);
            txbRua.Margin = new Padding(3, 2, 3, 2);
            txbRua.Name = "txbRua";
            txbRua.Size = new Size(182, 23);
            txbRua.TabIndex = 19;
            // 
            // maskNumero
            // 
            maskNumero.Location = new Point(397, 57);
            maskNumero.Margin = new Padding(3, 2, 3, 2);
            maskNumero.Name = "maskNumero";
            maskNumero.Size = new Size(110, 23);
            maskNumero.TabIndex = 18;
            // 
            // cbSexo
            // 
            cbSexo.FormattingEnabled = true;
            cbSexo.Location = new Point(68, 199);
            cbSexo.Margin = new Padding(3, 2, 3, 2);
            cbSexo.Name = "cbSexo";
            cbSexo.Size = new Size(93, 23);
            cbSexo.TabIndex = 17;
            // 
            // dtpNasc
            // 
            dtpNasc.Format = DateTimePickerFormat.Custom;
            dtpNasc.Location = new Point(154, 161);
            dtpNasc.Margin = new Padding(3, 2, 3, 2);
            dtpNasc.Name = "dtpNasc";
            dtpNasc.Size = new Size(87, 23);
            dtpNasc.TabIndex = 16;
            // 
            // txbEmail
            // 
            txbEmail.Location = new Point(68, 130);
            txbEmail.Margin = new Padding(3, 2, 3, 2);
            txbEmail.Name = "txbEmail";
            txbEmail.Size = new Size(173, 23);
            txbEmail.TabIndex = 15;
            // 
            // txbNome
            // 
            txbNome.Location = new Point(68, 92);
            txbNome.Margin = new Padding(3, 2, 3, 2);
            txbNome.Name = "txbNome";
            txbNome.Size = new Size(173, 23);
            txbNome.TabIndex = 14;
            // 
            // maskedCPF
            // 
            maskedCPF.Location = new Point(68, 57);
            maskedCPF.Margin = new Padding(3, 2, 3, 2);
            maskedCPF.Mask = "000000000-00";
            maskedCPF.Name = "maskedCPF";
            maskedCPF.Size = new Size(173, 23);
            maskedCPF.TabIndex = 13;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(535, 94);
            label14.Name = "label14";
            label14.Size = new Size(54, 15);
            label14.TabIndex = 12;
            label14.Text = "Telefone:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(535, 57);
            label13.Name = "label13";
            label13.Size = new Size(45, 15);
            label13.TabIndex = 11;
            label13.Text = "Estado:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(288, 201);
            label12.Name = "label12";
            label12.Size = new Size(41, 15);
            label12.TabIndex = 10;
            label12.Text = "Bairro:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(535, 132);
            label11.Name = "label11";
            label11.Size = new Size(77, 15);
            label11.TabIndex = 9;
            label11.Text = "Id do Cliente:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(288, 165);
            label10.Name = "label10";
            label10.Size = new Size(31, 15);
            label10.TabIndex = 8;
            label10.Text = "Cep:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(288, 132);
            label9.Name = "label9";
            label9.Size = new Size(47, 15);
            label9.TabIndex = 7;
            label9.Text = "Cidade:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(288, 94);
            label8.Name = "label8";
            label8.Size = new Size(30, 15);
            label8.TabIndex = 6;
            label8.Text = "Rua:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(288, 57);
            label7.Name = "label7";
            label7.Size = new Size(98, 15);
            label7.TabIndex = 5;
            label7.Text = "Numero da Casa:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 201);
            label6.Name = "label6";
            label6.Size = new Size(35, 15);
            label6.TabIndex = 4;
            label6.Text = "Sexo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 165);
            label5.Name = "label5";
            label5.Size = new Size(117, 15);
            label5.TabIndex = 3;
            label5.Text = "Data de Nascimento:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 132);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 2;
            label4.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 94);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 1;
            label3.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 57);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 0;
            label2.Text = "CPF:";
            // 
            // PesquisaCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(768, 445);
            Controls.Add(tabControl1);
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