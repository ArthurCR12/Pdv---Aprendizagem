namespace pdv.Telas.Cadastros
{
    partial class frmCadClientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadClientes));
            this.txtTel = new System.Windows.Forms.MaskedTextBox();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.grid = new System.Windows.Forms.DataGridView();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.rbtnFisica = new System.Windows.Forms.RadioButton();
            this.rbtnJurudica = new System.Windows.Forms.RadioButton();
            this.txtCnpj = new System.Windows.Forms.MaskedTextBox();
            this.groupBoxPessoa = new System.Windows.Forms.GroupBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMunicipio = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBoxStatus = new System.Windows.Forms.GroupBox();
            this.rbtnDesbloquado = new System.Windows.Forms.RadioButton();
            this.rbtnBloqueado = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNasc = new System.Windows.Forms.MaskedTextBox();
            this.txtLimiteCredito = new System.Windows.Forms.TextBox();
            this.painel = new System.Windows.Forms.Panel();
            this.lbvalorAberto = new System.Windows.Forms.Label();
            this.comboInadiplente = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.groupBoxPessoa.SuspendLayout();
            this.groupBoxStatus.SuspendLayout();
            this.painel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTel
            // 
            this.txtTel.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTel.Location = new System.Drawing.Point(487, 11);
            this.txtTel.Mask = "(99) 00000-0000";
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(221, 22);
            this.txtTel.TabIndex = 3;
            // 
            // txtCPF
            // 
            this.txtCPF.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPF.Location = new System.Drawing.Point(180, 106);
            this.txtCPF.Mask = "000,000,000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(175, 22);
            this.txtCPF.TabIndex = 50;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(364, 221);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(78, 36);
            this.btnCancelar.TabIndex = 35;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(910, 508);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(78, 36);
            this.btnFechar.TabIndex = 19;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(280, 221);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(78, 36);
            this.btnExcluir.TabIndex = 18;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(196, 221);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(78, 36);
            this.btnEditar.TabIndex = 17;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(28, 221);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(78, 36);
            this.btnNovo.TabIndex = 1;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.AllowUserToResizeColumns = false;
            this.grid.AllowUserToResizeRows = false;
            this.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid.BackgroundColor = System.Drawing.Color.White;
            this.grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid.ColumnHeadersHeight = 30;
            this.grid.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid.DefaultCellStyle = dataGridViewCellStyle2;
            this.grid.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.grid.Location = new System.Drawing.Point(12, 264);
            this.grid.MultiSelect = false;
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grid.RowHeadersVisible = false;
            this.grid.RowTemplate.DividerHeight = 1;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(976, 238);
            this.grid.TabIndex = 30;
            this.grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellClick);
            // 
            // txtRua
            // 
            this.txtRua.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRua.Font = new System.Drawing.Font("Corbel", 9.25F, System.Drawing.FontStyle.Bold);
            this.txtRua.Location = new System.Drawing.Point(79, 41);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(330, 23);
            this.txtRua.TabIndex = 6;
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Font = new System.Drawing.Font("Corbel", 9.25F, System.Drawing.FontStyle.Bold);
            this.txtNome.Location = new System.Drawing.Point(79, 10);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(330, 23);
            this.txtNome.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 9.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(37, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 15);
            this.label5.TabIndex = 28;
            this.label5.Text = "Rua :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 9.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(419, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 24;
            this.label3.Text = "Telefone :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 9.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(90, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "CPF / CNPJ :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 9.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(25, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "Nome :";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(112, 221);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(78, 36);
            this.btnSalvar.TabIndex = 16;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // rbtnFisica
            // 
            this.rbtnFisica.AutoSize = true;
            this.rbtnFisica.Checked = true;
            this.rbtnFisica.Font = new System.Drawing.Font("Verdana", 7.25F, System.Drawing.FontStyle.Bold);
            this.rbtnFisica.Location = new System.Drawing.Point(6, 19);
            this.rbtnFisica.Name = "rbtnFisica";
            this.rbtnFisica.Size = new System.Drawing.Size(55, 16);
            this.rbtnFisica.TabIndex = 36;
            this.rbtnFisica.TabStop = true;
            this.rbtnFisica.Text = "Fisíca";
            this.rbtnFisica.UseVisualStyleBackColor = true;
            this.rbtnFisica.CheckedChanged += new System.EventHandler(this.rbtnFisica_CheckedChanged);
            // 
            // rbtnJurudica
            // 
            this.rbtnJurudica.AutoSize = true;
            this.rbtnJurudica.Font = new System.Drawing.Font("Verdana", 7.25F, System.Drawing.FontStyle.Bold);
            this.rbtnJurudica.Location = new System.Drawing.Point(6, 41);
            this.rbtnJurudica.Name = "rbtnJurudica";
            this.rbtnJurudica.Size = new System.Drawing.Size(67, 16);
            this.rbtnJurudica.TabIndex = 37;
            this.rbtnJurudica.Text = "Juridica";
            this.rbtnJurudica.UseVisualStyleBackColor = true;
            this.rbtnJurudica.CheckedChanged += new System.EventHandler(this.rbtnJurudica_CheckedChanged);
            // 
            // txtCnpj
            // 
            this.txtCnpj.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCnpj.Location = new System.Drawing.Point(180, 106);
            this.txtCnpj.Mask = "00,000,000/0000-00";
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(175, 22);
            this.txtCnpj.TabIndex = 14;
            // 
            // groupBoxPessoa
            // 
            this.groupBoxPessoa.Controls.Add(this.rbtnFisica);
            this.groupBoxPessoa.Controls.Add(this.rbtnJurudica);
            this.groupBoxPessoa.Location = new System.Drawing.Point(12, 108);
            this.groupBoxPessoa.Name = "groupBoxPessoa";
            this.groupBoxPessoa.Size = new System.Drawing.Size(72, 61);
            this.groupBoxPessoa.TabIndex = 13;
            this.groupBoxPessoa.TabStop = false;
            this.groupBoxPessoa.Text = "Pessoa";
            // 
            // txtBairro
            // 
            this.txtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBairro.Font = new System.Drawing.Font("Corbel", 9.25F, System.Drawing.FontStyle.Bold);
            this.txtBairro.Location = new System.Drawing.Point(487, 41);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(248, 23);
            this.txtBairro.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 9.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(432, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 41;
            this.label4.Text = "Bairro :";
            // 
            // txtNum
            // 
            this.txtNum.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNum.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum.Location = new System.Drawing.Point(788, 41);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(58, 22);
            this.txtNum.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Corbel", 9.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(741, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 15);
            this.label6.TabIndex = 43;
            this.label6.Text = "Num :";
            // 
            // txtUF
            // 
            this.txtUF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUF.Font = new System.Drawing.Font("Corbel", 9.25F, System.Drawing.FontStyle.Bold);
            this.txtUF.Location = new System.Drawing.Point(312, 71);
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(97, 23);
            this.txtUF.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Corbel", 9.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(276, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 15);
            this.label7.TabIndex = 45;
            this.label7.Text = "UF :";
            // 
            // txtMunicipio
            // 
            this.txtMunicipio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMunicipio.Font = new System.Drawing.Font("Corbel", 9.25F, System.Drawing.FontStyle.Bold);
            this.txtMunicipio.Location = new System.Drawing.Point(79, 71);
            this.txtMunicipio.Name = "txtMunicipio";
            this.txtMunicipio.Size = new System.Drawing.Size(191, 23);
            this.txtMunicipio.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Corbel", 9.25F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(5, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 15);
            this.label8.TabIndex = 47;
            this.label8.Text = "Municipio :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Corbel", 9.25F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(444, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 15);
            this.label9.TabIndex = 49;
            this.label9.Text = "CEP :";
            // 
            // groupBoxStatus
            // 
            this.groupBoxStatus.Controls.Add(this.rbtnDesbloquado);
            this.groupBoxStatus.Controls.Add(this.rbtnBloqueado);
            this.groupBoxStatus.Location = new System.Drawing.Point(364, 104);
            this.groupBoxStatus.Name = "groupBoxStatus";
            this.groupBoxStatus.Size = new System.Drawing.Size(117, 61);
            this.groupBoxStatus.TabIndex = 16;
            this.groupBoxStatus.TabStop = false;
            this.groupBoxStatus.Text = "Status do Cliente";
            // 
            // rbtnDesbloquado
            // 
            this.rbtnDesbloquado.AutoSize = true;
            this.rbtnDesbloquado.Checked = true;
            this.rbtnDesbloquado.Font = new System.Drawing.Font("Verdana", 7.25F, System.Drawing.FontStyle.Bold);
            this.rbtnDesbloquado.Location = new System.Drawing.Point(6, 19);
            this.rbtnDesbloquado.Name = "rbtnDesbloquado";
            this.rbtnDesbloquado.Size = new System.Drawing.Size(104, 16);
            this.rbtnDesbloquado.TabIndex = 36;
            this.rbtnDesbloquado.TabStop = true;
            this.rbtnDesbloquado.Text = "Desbloqueado";
            this.rbtnDesbloquado.UseVisualStyleBackColor = true;
            // 
            // rbtnBloqueado
            // 
            this.rbtnBloqueado.AutoSize = true;
            this.rbtnBloqueado.Font = new System.Drawing.Font("Verdana", 7.25F, System.Drawing.FontStyle.Bold);
            this.rbtnBloqueado.Location = new System.Drawing.Point(6, 41);
            this.rbtnBloqueado.Name = "rbtnBloqueado";
            this.rbtnBloqueado.Size = new System.Drawing.Size(83, 16);
            this.rbtnBloqueado.TabIndex = 37;
            this.rbtnBloqueado.Text = "Bloqueado";
            this.rbtnBloqueado.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Corbel", 8.25F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(842, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 51;
            this.label10.Text = "Inadiplente  :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Corbel", 8.25F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(584, 78);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 13);
            this.label11.TabIndex = 53;
            this.label11.Text = "Limite de Crédito :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Corbel", 9.25F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(714, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 15);
            this.label12.TabIndex = 55;
            this.label12.Text = "Nasc :";
            // 
            // txtNasc
            // 
            this.txtNasc.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNasc.Location = new System.Drawing.Point(758, 11);
            this.txtNasc.Mask = "00/00/0000";
            this.txtNasc.Name = "txtNasc";
            this.txtNasc.Size = new System.Drawing.Size(78, 22);
            this.txtNasc.TabIndex = 4;
            this.txtNasc.ValidatingType = typeof(System.DateTime);
            // 
            // txtLimiteCredito
            // 
            this.txtLimiteCredito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLimiteCredito.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLimiteCredito.Location = new System.Drawing.Point(684, 72);
            this.txtLimiteCredito.Name = "txtLimiteCredito";
            this.txtLimiteCredito.Size = new System.Drawing.Size(115, 22);
            this.txtLimiteCredito.TabIndex = 12;
            // 
            // painel
            // 
            this.painel.Controls.Add(this.lbvalorAberto);
            this.painel.Controls.Add(this.comboInadiplente);
            this.painel.Controls.Add(this.label14);
            this.painel.Controls.Add(this.label13);
            this.painel.Controls.Add(this.txtEmail);
            this.painel.Controls.Add(this.txtCep);
            this.painel.Controls.Add(this.label1);
            this.painel.Controls.Add(this.txtLimiteCredito);
            this.painel.Controls.Add(this.txtNasc);
            this.painel.Controls.Add(this.label2);
            this.painel.Controls.Add(this.label12);
            this.painel.Controls.Add(this.label3);
            this.painel.Controls.Add(this.label11);
            this.painel.Controls.Add(this.label5);
            this.painel.Controls.Add(this.label10);
            this.painel.Controls.Add(this.txtNome);
            this.painel.Controls.Add(this.txtRua);
            this.painel.Controls.Add(this.groupBoxStatus);
            this.painel.Controls.Add(this.txtCPF);
            this.painel.Controls.Add(this.txtTel);
            this.painel.Controls.Add(this.label9);
            this.painel.Controls.Add(this.groupBoxPessoa);
            this.painel.Controls.Add(this.txtMunicipio);
            this.painel.Controls.Add(this.label4);
            this.painel.Controls.Add(this.label8);
            this.painel.Controls.Add(this.txtBairro);
            this.painel.Controls.Add(this.txtUF);
            this.painel.Controls.Add(this.label6);
            this.painel.Controls.Add(this.label7);
            this.painel.Controls.Add(this.txtNum);
            this.painel.Controls.Add(this.txtCnpj);
            this.painel.Enabled = false;
            this.painel.Location = new System.Drawing.Point(12, 39);
            this.painel.Name = "painel";
            this.painel.Size = new System.Drawing.Size(976, 176);
            this.painel.TabIndex = 58;
            // 
            // lbvalorAberto
            // 
            this.lbvalorAberto.AutoSize = true;
            this.lbvalorAberto.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbvalorAberto.Location = new System.Drawing.Point(898, 150);
            this.lbvalorAberto.Name = "lbvalorAberto";
            this.lbvalorAberto.Size = new System.Drawing.Size(23, 17);
            this.lbvalorAberto.TabIndex = 60;
            this.lbvalorAberto.Text = "---";
            this.lbvalorAberto.TextChanged += new System.EventHandler(this.lbvalorAberto_TextChanged);
            // 
            // comboInadiplente
            // 
            this.comboInadiplente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboInadiplente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboInadiplente.ForeColor = System.Drawing.Color.Blue;
            this.comboInadiplente.FormattingEnabled = true;
            this.comboInadiplente.Items.AddRange(new object[] {
            "Sim",
            "Nao"});
            this.comboInadiplente.Location = new System.Drawing.Point(917, 13);
            this.comboInadiplente.Name = "comboInadiplente";
            this.comboInadiplente.Size = new System.Drawing.Size(56, 21);
            this.comboInadiplente.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Corbel", 9.25F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(785, 150);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(107, 15);
            this.label14.TabIndex = 59;
            this.label14.Text = "Valor em Aberto :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Corbel", 9.25F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(487, 108);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 15);
            this.label13.TabIndex = 57;
            this.label13.Text = "Email :";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Corbel", 9.25F, System.Drawing.FontStyle.Bold);
            this.txtEmail.Location = new System.Drawing.Point(538, 105);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(330, 23);
            this.txtEmail.TabIndex = 15;
            // 
            // txtCep
            // 
            this.txtCep.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCep.Location = new System.Drawing.Point(487, 72);
            this.txtCep.Mask = "00000-000";
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(85, 22);
            this.txtCep.TabIndex = 11;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Corbel", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnPesquisar.Location = new System.Drawing.Point(834, 235);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(89, 22);
            this.btnPesquisar.TabIndex = 21;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPesquisar.Font = new System.Drawing.Font("Corbel", 9.25F, System.Drawing.FontStyle.Bold);
            this.txtPesquisar.Location = new System.Drawing.Point(657, 235);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(172, 23);
            this.txtPesquisar.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.panel2.Controls.Add(this.label15);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1000, 33);
            this.panel2.TabIndex = 65;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(359, 5);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(221, 23);
            this.label15.TabIndex = 62;
            this.label15.Text = "CADASTRO DE CLIENTES";
            // 
            // frmCadClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 556);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.painel);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.btnSalvar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(1016, 595);
            this.MinimumSize = new System.Drawing.Size(1016, 595);
            this.Name = "frmCadClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro de Clientes";
            this.Load += new System.EventHandler(this.frmCadClientes_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCadClientes_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.groupBoxPessoa.ResumeLayout(false);
            this.groupBoxPessoa.PerformLayout();
            this.groupBoxStatus.ResumeLayout(false);
            this.groupBoxStatus.PerformLayout();
            this.painel.ResumeLayout(false);
            this.painel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtTel;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.RadioButton rbtnFisica;
        private System.Windows.Forms.RadioButton rbtnJurudica;
        private System.Windows.Forms.MaskedTextBox txtCnpj;
        private System.Windows.Forms.GroupBox groupBoxPessoa;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUF;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMunicipio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBoxStatus;
        private System.Windows.Forms.RadioButton rbtnDesbloquado;
        private System.Windows.Forms.RadioButton rbtnBloqueado;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox txtNasc;
        private System.Windows.Forms.TextBox txtLimiteCredito;
        private System.Windows.Forms.Panel painel;
        private System.Windows.Forms.MaskedTextBox txtCep;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboInadiplente;
        private System.Windows.Forms.Label lbvalorAberto;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label15;
    }
}