namespace pdv.Telas.Cadastros
{
    partial class frmCadFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadFuncionario));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFuncNome = new System.Windows.Forms.TextBox();
            this.txtFuncEnd = new System.Windows.Forms.TextBox();
            this.comboFuncCargo = new System.Windows.Forms.ComboBox();
            this.gridFunc = new System.Windows.Forms.DataGridView();
            this.btnFuncNovo = new System.Windows.Forms.Button();
            this.btnFuncSalvar = new System.Windows.Forms.Button();
            this.btnFuncEditar = new System.Windows.Forms.Button();
            this.btnFuncExcluir = new System.Windows.Forms.Button();
            this.btnFuncFechar = new System.Windows.Forms.Button();
            this.btnFunCancelar = new System.Windows.Forms.Button();
            this.btn_foto = new System.Windows.Forms.Button();
            this.txtFuncCPF = new System.Windows.Forms.MaskedTextBox();
            this.txtFuncTel = new System.Windows.Forms.MaskedTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBoxFuncionario = new System.Windows.Forms.PictureBox();
            this.btnCadCargo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridFunc)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(343, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cpf :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefone :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(327, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cargo :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Endereço :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(567, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Foto :";
            // 
            // txtFuncNome
            // 
            this.txtFuncNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFuncNome.Enabled = false;
            this.txtFuncNome.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFuncNome.Location = new System.Drawing.Point(92, 44);
            this.txtFuncNome.Name = "txtFuncNome";
            this.txtFuncNome.Size = new System.Drawing.Size(221, 26);
            this.txtFuncNome.TabIndex = 0;
            this.txtFuncNome.UseWaitCursor = true;
            // 
            // txtFuncEnd
            // 
            this.txtFuncEnd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFuncEnd.Enabled = false;
            this.txtFuncEnd.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFuncEnd.Location = new System.Drawing.Point(92, 125);
            this.txtFuncEnd.Name = "txtFuncEnd";
            this.txtFuncEnd.Size = new System.Drawing.Size(469, 26);
            this.txtFuncEnd.TabIndex = 4;
            // 
            // comboFuncCargo
            // 
            this.comboFuncCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFuncCargo.Enabled = false;
            this.comboFuncCargo.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboFuncCargo.FormattingEnabled = true;
            this.comboFuncCargo.Location = new System.Drawing.Point(386, 84);
            this.comboFuncCargo.Name = "comboFuncCargo";
            this.comboFuncCargo.Size = new System.Drawing.Size(175, 26);
            this.comboFuncCargo.TabIndex = 3;
            // 
            // gridFunc
            // 
            this.gridFunc.AllowUserToAddRows = false;
            this.gridFunc.AllowUserToDeleteRows = false;
            this.gridFunc.AllowUserToResizeColumns = false;
            this.gridFunc.AllowUserToResizeRows = false;
            this.gridFunc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridFunc.BackgroundColor = System.Drawing.Color.White;
            this.gridFunc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridFunc.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridFunc.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridFunc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridFunc.ColumnHeadersHeight = 30;
            this.gridFunc.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridFunc.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridFunc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gridFunc.Location = new System.Drawing.Point(12, 243);
            this.gridFunc.MultiSelect = false;
            this.gridFunc.Name = "gridFunc";
            this.gridFunc.ReadOnly = true;
            this.gridFunc.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridFunc.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridFunc.RowHeadersVisible = false;
            this.gridFunc.RowTemplate.DividerHeight = 1;
            this.gridFunc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridFunc.Size = new System.Drawing.Size(776, 195);
            this.gridFunc.TabIndex = 12;
            this.gridFunc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridFunc_CellClick);
            // 
            // btnFuncNovo
            // 
            this.btnFuncNovo.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFuncNovo.Location = new System.Drawing.Point(8, 177);
            this.btnFuncNovo.Name = "btnFuncNovo";
            this.btnFuncNovo.Size = new System.Drawing.Size(78, 36);
            this.btnFuncNovo.TabIndex = 13;
            this.btnFuncNovo.Text = "Novo";
            this.btnFuncNovo.UseVisualStyleBackColor = true;
            this.btnFuncNovo.Click += new System.EventHandler(this.btnFuncNovo_Click);
            // 
            // btnFuncSalvar
            // 
            this.btnFuncSalvar.Enabled = false;
            this.btnFuncSalvar.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFuncSalvar.Location = new System.Drawing.Point(92, 177);
            this.btnFuncSalvar.Name = "btnFuncSalvar";
            this.btnFuncSalvar.Size = new System.Drawing.Size(78, 36);
            this.btnFuncSalvar.TabIndex = 5;
            this.btnFuncSalvar.Text = "Salvar";
            this.btnFuncSalvar.UseVisualStyleBackColor = true;
            this.btnFuncSalvar.Click += new System.EventHandler(this.btnFuncSalvar_Click);
            // 
            // btnFuncEditar
            // 
            this.btnFuncEditar.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFuncEditar.Location = new System.Drawing.Point(176, 177);
            this.btnFuncEditar.Name = "btnFuncEditar";
            this.btnFuncEditar.Size = new System.Drawing.Size(78, 36);
            this.btnFuncEditar.TabIndex = 15;
            this.btnFuncEditar.Text = "Editar";
            this.btnFuncEditar.UseVisualStyleBackColor = true;
            this.btnFuncEditar.Click += new System.EventHandler(this.btnFuncEditar_Click);
            // 
            // btnFuncExcluir
            // 
            this.btnFuncExcluir.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFuncExcluir.Location = new System.Drawing.Point(260, 177);
            this.btnFuncExcluir.Name = "btnFuncExcluir";
            this.btnFuncExcluir.Size = new System.Drawing.Size(78, 36);
            this.btnFuncExcluir.TabIndex = 16;
            this.btnFuncExcluir.Text = "Excluir";
            this.btnFuncExcluir.UseVisualStyleBackColor = true;
            this.btnFuncExcluir.Click += new System.EventHandler(this.btnFuncExcluir_Click);
            // 
            // btnFuncFechar
            // 
            this.btnFuncFechar.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFuncFechar.Location = new System.Drawing.Point(710, 444);
            this.btnFuncFechar.Name = "btnFuncFechar";
            this.btnFuncFechar.Size = new System.Drawing.Size(78, 36);
            this.btnFuncFechar.TabIndex = 17;
            this.btnFuncFechar.Text = "Fechar";
            this.btnFuncFechar.UseVisualStyleBackColor = true;
            this.btnFuncFechar.Click += new System.EventHandler(this.btnFuncFechar_Click);
            // 
            // btnFunCancelar
            // 
            this.btnFunCancelar.Enabled = false;
            this.btnFunCancelar.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFunCancelar.Location = new System.Drawing.Point(344, 177);
            this.btnFunCancelar.Name = "btnFunCancelar";
            this.btnFunCancelar.Size = new System.Drawing.Size(78, 36);
            this.btnFunCancelar.TabIndex = 18;
            this.btnFunCancelar.Text = "Cancelar";
            this.btnFunCancelar.UseVisualStyleBackColor = true;
            this.btnFunCancelar.Click += new System.EventHandler(this.btnFunCancelar_Click);
            // 
            // btn_foto
            // 
            this.btn_foto.Enabled = false;
            this.btn_foto.Font = new System.Drawing.Font("Corbel", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_foto.Location = new System.Drawing.Point(623, 217);
            this.btn_foto.Name = "btn_foto";
            this.btn_foto.Size = new System.Drawing.Size(165, 20);
            this.btn_foto.TabIndex = 19;
            this.btn_foto.Text = "Buscar foto";
            this.btn_foto.UseVisualStyleBackColor = true;
            this.btn_foto.Click += new System.EventHandler(this.btn_foto_Click);
            // 
            // txtFuncCPF
            // 
            this.txtFuncCPF.Enabled = false;
            this.txtFuncCPF.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFuncCPF.Location = new System.Drawing.Point(386, 44);
            this.txtFuncCPF.Mask = "000,000,000-00";
            this.txtFuncCPF.Name = "txtFuncCPF";
            this.txtFuncCPF.Size = new System.Drawing.Size(175, 22);
            this.txtFuncCPF.TabIndex = 1;
            // 
            // txtFuncTel
            // 
            this.txtFuncTel.Enabled = false;
            this.txtFuncTel.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFuncTel.Location = new System.Drawing.Point(92, 84);
            this.txtFuncTel.Mask = "(99) 00000-0000";
            this.txtFuncTel.Name = "txtFuncTel";
            this.txtFuncTel.Size = new System.Drawing.Size(221, 22);
            this.txtFuncTel.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.panel2.Controls.Add(this.label7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 33);
            this.panel2.TabIndex = 65;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(270, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(273, 23);
            this.label7.TabIndex = 62;
            this.label7.Text = "CADASTRO DE FUNCIONARIOS";
            // 
            // pictureBoxFuncionario
            // 
            this.pictureBoxFuncionario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxFuncionario.Location = new System.Drawing.Point(623, 44);
            this.pictureBoxFuncionario.Name = "pictureBoxFuncionario";
            this.pictureBoxFuncionario.Size = new System.Drawing.Size(165, 167);
            this.pictureBoxFuncionario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFuncionario.TabIndex = 11;
            this.pictureBoxFuncionario.TabStop = false;
            // 
            // btnCadCargo
            // 
            this.btnCadCargo.Enabled = false;
            this.btnCadCargo.Font = new System.Drawing.Font("Corbel", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadCargo.Location = new System.Drawing.Point(570, 84);
            this.btnCadCargo.Name = "btnCadCargo";
            this.btnCadCargo.Size = new System.Drawing.Size(49, 20);
            this.btnCadCargo.TabIndex = 66;
            this.btnCadCargo.Text = "Cargos";
            this.btnCadCargo.UseVisualStyleBackColor = true;
            this.btnCadCargo.Click += new System.EventHandler(this.btnCadCargo_Click);
            // 
            // frmCadFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 486);
            this.Controls.Add(this.btnCadCargo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtFuncTel);
            this.Controls.Add(this.txtFuncCPF);
            this.Controls.Add(this.btn_foto);
            this.Controls.Add(this.btnFunCancelar);
            this.Controls.Add(this.btnFuncFechar);
            this.Controls.Add(this.btnFuncExcluir);
            this.Controls.Add(this.btnFuncEditar);
            this.Controls.Add(this.btnFuncNovo);
            this.Controls.Add(this.gridFunc);
            this.Controls.Add(this.pictureBoxFuncionario);
            this.Controls.Add(this.comboFuncCargo);
            this.Controls.Add(this.txtFuncEnd);
            this.Controls.Add(this.txtFuncNome);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFuncSalvar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 525);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(816, 525);
            this.Name = "frmCadFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro de Funcionario";
            this.Load += new System.EventHandler(this.frmCadFuncionario_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCadFuncionario_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.gridFunc)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFuncionario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFuncNome;
        private System.Windows.Forms.TextBox txtFuncEnd;
        private System.Windows.Forms.ComboBox comboFuncCargo;
        private System.Windows.Forms.PictureBox pictureBoxFuncionario;
        private System.Windows.Forms.DataGridView gridFunc;
        private System.Windows.Forms.Button btnFuncNovo;
        private System.Windows.Forms.Button btnFuncSalvar;
        private System.Windows.Forms.Button btnFuncEditar;
        private System.Windows.Forms.Button btnFuncExcluir;
        private System.Windows.Forms.Button btnFuncFechar;
        private System.Windows.Forms.Button btnFunCancelar;
        private System.Windows.Forms.Button btn_foto;
        private System.Windows.Forms.MaskedTextBox txtFuncCPF;
        private System.Windows.Forms.MaskedTextBox txtFuncTel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCadCargo;
    }
}