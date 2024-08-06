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
            linkLabel1 = new LinkLabel();
            buttonPesquisar = new Button();
            label1 = new Label();
            textBoxPesquisar = new TextBox();
            dataGridViewPesquisar = new DataGridView();
            tabPage2 = new TabPage();
            label14 = new Label();
            maskedTextBoxID = new MaskedTextBox();
            button1 = new Button();
            maskedTextBoxEmail = new MaskedTextBox();
            comboBoxSexo = new ComboBox();
            maskedTextBoxNumero = new MaskedTextBox();
            comboBoxEstado = new ComboBox();
            textBoxRua = new TextBox();
            label12 = new Label();
            maskedTextBoxCep = new MaskedTextBox();
            textBoxCidade = new TextBox();
            textBoxBairro = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            maskedTextBoxTelefone = new MaskedTextBox();
            label5 = new Label();
            dateTimePickerNasc = new DateTimePicker();
            textBoxNome = new TextBox();
            maskedTextBoxCPF = new MaskedTextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label13 = new Label();
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
            tabControl1.Size = new Size(727, 545);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(linkLabel1);
            tabPage1.Controls.Add(buttonPesquisar);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(textBoxPesquisar);
            tabPage1.Controls.Add(dataGridViewPesquisar);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(719, 512);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Pesquisar";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(3, 46);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(68, 20);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Atualizar";
            linkLabel1.LinkClicked += atualiza_Cliente;
            // 
            // buttonPesquisar
            // 
            buttonPesquisar.Location = new Point(6, 410);
            buttonPesquisar.Margin = new Padding(3, 4, 3, 4);
            buttonPesquisar.Name = "buttonPesquisar";
            buttonPesquisar.Size = new Size(133, 95);
            buttonPesquisar.TabIndex = 7;
            buttonPesquisar.Text = "Pesquisar";
            buttonPesquisar.UseVisualStyleBackColor = true;
            buttonPesquisar.Click += buttonPesquisar_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 6;
            label1.Text = "Pesquisar:";
            // 
            // textBoxPesquisar
            // 
            textBoxPesquisar.Location = new Point(78, 5);
            textBoxPesquisar.Margin = new Padding(3, 4, 3, 4);
            textBoxPesquisar.Name = "textBoxPesquisar";
            textBoxPesquisar.Size = new Size(635, 27);
            textBoxPesquisar.TabIndex = 5;
            // 
            // dataGridViewPesquisar
            // 
            dataGridViewPesquisar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPesquisar.Location = new Point(3, 61);
            dataGridViewPesquisar.Margin = new Padding(3, 4, 3, 4);
            dataGridViewPesquisar.Name = "dataGridViewPesquisar";
            dataGridViewPesquisar.RowHeadersWidth = 51;
            dataGridViewPesquisar.Size = new Size(710, 341);
            dataGridViewPesquisar.TabIndex = 4;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label14);
            tabPage2.Controls.Add(maskedTextBoxID);
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(maskedTextBoxEmail);
            tabPage2.Controls.Add(comboBoxSexo);
            tabPage2.Controls.Add(maskedTextBoxNumero);
            tabPage2.Controls.Add(comboBoxEstado);
            tabPage2.Controls.Add(textBoxRua);
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(maskedTextBoxCep);
            tabPage2.Controls.Add(textBoxCidade);
            tabPage2.Controls.Add(textBoxBairro);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(maskedTextBoxTelefone);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(dateTimePickerNasc);
            tabPage2.Controls.Add(textBoxNome);
            tabPage2.Controls.Add(maskedTextBoxCPF);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(label13);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(719, 512);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Atualizar";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(12, 255);
            label14.Name = "label14";
            label14.Size = new Size(27, 20);
            label14.TabIndex = 58;
            label14.Text = "ID:";
            // 
            // maskedTextBoxID
            // 
            maskedTextBoxID.Enabled = false;
            maskedTextBoxID.Location = new Point(45, 252);
            maskedTextBoxID.Name = "maskedTextBoxID";
            maskedTextBoxID.Size = new Size(125, 27);
            maskedTextBoxID.TabIndex = 57;
            // 
            // button1
            // 
            button1.Location = new Point(12, 370);
            button1.Name = "button1";
            button1.Size = new Size(163, 79);
            button1.TabIndex = 56;
            button1.Text = "Salvar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // maskedTextBoxEmail
            // 
            maskedTextBoxEmail.Location = new Point(66, 94);
            maskedTextBoxEmail.Margin = new Padding(3, 4, 3, 4);
            maskedTextBoxEmail.Name = "maskedTextBoxEmail";
            maskedTextBoxEmail.Size = new Size(205, 27);
            maskedTextBoxEmail.TabIndex = 55;
            // 
            // comboBoxSexo
            // 
            comboBoxSexo.Location = new Point(52, 168);
            comboBoxSexo.Margin = new Padding(3, 4, 3, 4);
            comboBoxSexo.Name = "comboBoxSexo";
            comboBoxSexo.Size = new Size(123, 28);
            comboBoxSexo.TabIndex = 54;
            // 
            // maskedTextBoxNumero
            // 
            maskedTextBoxNumero.Location = new Point(407, 23);
            maskedTextBoxNumero.Margin = new Padding(3, 4, 3, 4);
            maskedTextBoxNumero.Name = "maskedTextBoxNumero";
            maskedTextBoxNumero.Size = new Size(259, 27);
            maskedTextBoxNumero.TabIndex = 53;
            maskedTextBoxNumero.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // comboBoxEstado
            // 
            comboBoxEstado.FormattingEnabled = true;
            comboBoxEstado.Location = new Point(324, 209);
            comboBoxEstado.Margin = new Padding(3, 4, 3, 4);
            comboBoxEstado.Name = "comboBoxEstado";
            comboBoxEstado.Size = new Size(54, 28);
            comboBoxEstado.TabIndex = 52;
            // 
            // textBoxRua
            // 
            textBoxRua.Location = new Point(324, 61);
            textBoxRua.Margin = new Padding(3, 4, 3, 4);
            textBoxRua.Name = "textBoxRua";
            textBoxRua.Size = new Size(332, 27);
            textBoxRua.TabIndex = 51;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(10, 172);
            label12.Name = "label12";
            label12.Size = new Size(44, 20);
            label12.TabIndex = 50;
            label12.Text = "Sexo:";
            // 
            // maskedTextBoxCep
            // 
            maskedTextBoxCep.CutCopyMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            maskedTextBoxCep.Location = new Point(339, 134);
            maskedTextBoxCep.Mask = "00000-000";
            maskedTextBoxCep.Name = "maskedTextBoxCep";
            maskedTextBoxCep.Size = new Size(110, 27);
            maskedTextBoxCep.TabIndex = 49;
            maskedTextBoxCep.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // textBoxCidade
            // 
            textBoxCidade.Location = new Point(350, 98);
            textBoxCidade.Name = "textBoxCidade";
            textBoxCidade.Size = new Size(307, 27);
            textBoxCidade.TabIndex = 48;
            // 
            // textBoxBairro
            // 
            textBoxBairro.Location = new Point(347, 174);
            textBoxBairro.Name = "textBoxBairro";
            textBoxBairro.Size = new Size(319, 27);
            textBoxBairro.TabIndex = 47;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(266, 213);
            label11.Name = "label11";
            label11.RightToLeft = RightToLeft.No;
            label11.Size = new Size(57, 20);
            label11.TabIndex = 46;
            label11.Text = "Estado:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(297, 138);
            label10.Name = "label10";
            label10.Size = new Size(38, 20);
            label10.TabIndex = 45;
            label10.Text = "Cep:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(289, 102);
            label9.Name = "label9";
            label9.Size = new Size(59, 20);
            label9.TabIndex = 44;
            label9.Text = "Cidade:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(289, 174);
            label8.Name = "label8";
            label8.Size = new Size(52, 20);
            label8.TabIndex = 43;
            label8.Text = "Bairro:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(283, 62);
            label7.Name = "label7";
            label7.Size = new Size(37, 20);
            label7.TabIndex = 42;
            label7.Text = "Rua:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(281, 26);
            label6.Name = "label6";
            label6.Size = new Size(120, 20);
            label6.TabIndex = 41;
            label6.Text = "Numero da casa:";
            // 
            // maskedTextBoxTelefone
            // 
            maskedTextBoxTelefone.CutCopyMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            maskedTextBoxTelefone.Location = new Point(79, 205);
            maskedTextBoxTelefone.Mask = "(99) 00000-0000";
            maskedTextBoxTelefone.Name = "maskedTextBoxTelefone";
            maskedTextBoxTelefone.Size = new Size(157, 27);
            maskedTextBoxTelefone.TabIndex = 40;
            maskedTextBoxTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 209);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 39;
            label5.Text = "Telefone:";
            // 
            // dateTimePickerNasc
            // 
            dateTimePickerNasc.Format = DateTimePickerFormat.Short;
            dateTimePickerNasc.Location = new Point(151, 130);
            dateTimePickerNasc.Name = "dateTimePickerNasc";
            dateTimePickerNasc.Size = new Size(121, 27);
            dateTimePickerNasc.TabIndex = 38;
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(66, 58);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.PlaceholderText = "Insira seu nome";
            textBoxNome.Size = new Size(205, 27);
            textBoxNome.TabIndex = 37;
            // 
            // maskedTextBoxCPF
            // 
            maskedTextBoxCPF.CutCopyMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            maskedTextBoxCPF.Location = new Point(55, 22);
            maskedTextBoxCPF.Mask = "000000000-00";
            maskedTextBoxCPF.Name = "maskedTextBoxCPF";
            maskedTextBoxCPF.Size = new Size(219, 27);
            maskedTextBoxCPF.TabIndex = 36;
            maskedTextBoxCPF.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 138);
            label4.Name = "label4";
            label4.Size = new Size(148, 20);
            label4.TabIndex = 35;
            label4.Text = "Data de Nascimento:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 98);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 34;
            label3.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 62);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 33;
            label2.Text = "Nome:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(12, 26);
            label13.Name = "label13";
            label13.Size = new Size(36, 20);
            label13.TabIndex = 32;
            label13.Text = "CPF:";
            // 
            // PesquisaCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(751, 569);
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
        private TabPage tabPage2;
        private Button buttonPesquisar;
        private Label label1;
        private TextBox textBoxPesquisar;
        private DataGridView dataGridViewPesquisar;
        private MaskedTextBox maskedTextBoxEmail;
        private ComboBox comboBoxSexo;
        private MaskedTextBox maskedTextBoxNumero;
        private ComboBox comboBoxEstado;
        private TextBox textBoxRua;
        private Label label12;
        private MaskedTextBox maskedTextBoxCep;
        private TextBox textBoxCidade;
        private TextBox textBoxBairro;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private MaskedTextBox maskedTextBoxTelefone;
        private Label label5;
        private DateTimePicker dateTimePickerNasc;
        private TextBox textBoxNome;
        private MaskedTextBox maskedTextBoxCPF;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label13;
        private Button button1;
        private LinkLabel linkLabel1;
        private Label label14;
        private MaskedTextBox maskedTextBoxID;
    }
}