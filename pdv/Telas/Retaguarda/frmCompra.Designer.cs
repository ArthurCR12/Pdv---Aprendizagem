namespace pdv.Telas.Retaguarda
{
    partial class frmCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCompra));
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnCadProd = new System.Windows.Forms.Button();
            this.btnCadForn = new System.Windows.Forms.Button();
            this.panelDireita = new System.Windows.Forms.Panel();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.splitter8 = new System.Windows.Forms.Splitter();
            this.splitter6 = new System.Windows.Forms.Splitter();
            this.splitter4 = new System.Windows.Forms.Splitter();
            this.splitter7 = new System.Windows.Forms.Splitter();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnDelAll = new System.Windows.Forms.Button();
            this.splitter5 = new System.Windows.Forms.Splitter();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btnDelItem = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPreço = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQuant = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProd = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtForn = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.colForn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPreco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOBS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.panelBottom.SuspendLayout();
            this.panelDireita.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Controls.Add(this.Grid);
            this.panelPrincipal.Controls.Add(this.panelBottom);
            this.panelPrincipal.Controls.Add(this.panelDireita);
            this.panelPrincipal.Controls.Add(this.panelTop);
            this.panelPrincipal.Controls.Add(this.panel2);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(1209, 670);
            this.panelPrincipal.TabIndex = 0;
            // 
            // Grid
            // 
            this.Grid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colForn,
            this.colProd,
            this.colQtd,
            this.colPreco,
            this.colTot,
            this.colOBS});
            this.Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid.Location = new System.Drawing.Point(0, 122);
            this.Grid.Name = "Grid";
            this.Grid.Size = new System.Drawing.Size(1020, 506);
            this.Grid.TabIndex = 69;
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.Gainsboro;
            this.panelBottom.Controls.Add(this.btnCadProd);
            this.panelBottom.Controls.Add(this.btnCadForn);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 628);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1020, 42);
            this.panelBottom.TabIndex = 69;
            // 
            // btnCadProd
            // 
            this.btnCadProd.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCadProd.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnCadProd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCadProd.Location = new System.Drawing.Point(189, 0);
            this.btnCadProd.Name = "btnCadProd";
            this.btnCadProd.Size = new System.Drawing.Size(189, 42);
            this.btnCadProd.TabIndex = 95;
            this.btnCadProd.Text = "Cadastrar Produto";
            this.btnCadProd.UseVisualStyleBackColor = true;
            // 
            // btnCadForn
            // 
            this.btnCadForn.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCadForn.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnCadForn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCadForn.Location = new System.Drawing.Point(0, 0);
            this.btnCadForn.Name = "btnCadForn";
            this.btnCadForn.Size = new System.Drawing.Size(189, 42);
            this.btnCadForn.TabIndex = 94;
            this.btnCadForn.Text = "Cadastrar Fornecedor";
            this.btnCadForn.UseVisualStyleBackColor = true;
            // 
            // panelDireita
            // 
            this.panelDireita.BackColor = System.Drawing.Color.Gainsboro;
            this.panelDireita.Controls.Add(this.btnSalvar);
            this.panelDireita.Controls.Add(this.splitter8);
            this.panelDireita.Controls.Add(this.splitter6);
            this.panelDireita.Controls.Add(this.splitter4);
            this.panelDireita.Controls.Add(this.splitter7);
            this.panelDireita.Controls.Add(this.btnFechar);
            this.panelDireita.Controls.Add(this.btnDelAll);
            this.panelDireita.Controls.Add(this.splitter5);
            this.panelDireita.Controls.Add(this.splitter3);
            this.panelDireita.Controls.Add(this.splitter2);
            this.panelDireita.Controls.Add(this.splitter1);
            this.panelDireita.Controls.Add(this.btnDelItem);
            this.panelDireita.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelDireita.Location = new System.Drawing.Point(1020, 122);
            this.panelDireita.Name = "panelDireita";
            this.panelDireita.Size = new System.Drawing.Size(189, 548);
            this.panelDireita.TabIndex = 68;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSalvar.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSalvar.Location = new System.Drawing.Point(0, 482);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(189, 27);
            this.btnSalvar.TabIndex = 87;
            this.btnSalvar.Text = "Salvar [F6]";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // splitter8
            // 
            this.splitter8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter8.Location = new System.Drawing.Point(0, 509);
            this.splitter8.Name = "splitter8";
            this.splitter8.Size = new System.Drawing.Size(189, 3);
            this.splitter8.TabIndex = 93;
            this.splitter8.TabStop = false;
            // 
            // splitter6
            // 
            this.splitter6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter6.Location = new System.Drawing.Point(0, 512);
            this.splitter6.Name = "splitter6";
            this.splitter6.Size = new System.Drawing.Size(189, 3);
            this.splitter6.TabIndex = 92;
            this.splitter6.TabStop = false;
            // 
            // splitter4
            // 
            this.splitter4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter4.Location = new System.Drawing.Point(0, 515);
            this.splitter4.Name = "splitter4";
            this.splitter4.Size = new System.Drawing.Size(189, 3);
            this.splitter4.TabIndex = 91;
            this.splitter4.TabStop = false;
            // 
            // splitter7
            // 
            this.splitter7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter7.Location = new System.Drawing.Point(0, 518);
            this.splitter7.Name = "splitter7";
            this.splitter7.Size = new System.Drawing.Size(189, 3);
            this.splitter7.TabIndex = 90;
            this.splitter7.TabStop = false;
            // 
            // btnFechar
            // 
            this.btnFechar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnFechar.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnFechar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnFechar.Location = new System.Drawing.Point(0, 521);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(189, 27);
            this.btnFechar.TabIndex = 80;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            // 
            // btnDelAll
            // 
            this.btnDelAll.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDelAll.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnDelAll.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDelAll.Location = new System.Drawing.Point(0, 52);
            this.btnDelAll.Name = "btnDelAll";
            this.btnDelAll.Size = new System.Drawing.Size(189, 40);
            this.btnDelAll.TabIndex = 81;
            this.btnDelAll.Text = "Deletar Lançamento";
            this.btnDelAll.UseVisualStyleBackColor = true;
            // 
            // splitter5
            // 
            this.splitter5.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter5.Location = new System.Drawing.Point(0, 49);
            this.splitter5.Name = "splitter5";
            this.splitter5.Size = new System.Drawing.Size(189, 3);
            this.splitter5.TabIndex = 86;
            this.splitter5.TabStop = false;
            // 
            // splitter3
            // 
            this.splitter3.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter3.Location = new System.Drawing.Point(0, 46);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(189, 3);
            this.splitter3.TabIndex = 84;
            this.splitter3.TabStop = false;
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter2.Location = new System.Drawing.Point(0, 43);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(189, 3);
            this.splitter2.TabIndex = 83;
            this.splitter2.TabStop = false;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 40);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(189, 3);
            this.splitter1.TabIndex = 82;
            this.splitter1.TabStop = false;
            // 
            // btnDelItem
            // 
            this.btnDelItem.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDelItem.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnDelItem.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDelItem.Location = new System.Drawing.Point(0, 0);
            this.btnDelItem.Name = "btnDelItem";
            this.btnDelItem.Size = new System.Drawing.Size(189, 40);
            this.btnDelItem.TabIndex = 80;
            this.btnDelItem.Text = "Deletar Item";
            this.btnDelItem.UseVisualStyleBackColor = true;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Gainsboro;
            this.panelTop.Controls.Add(this.btnAdd);
            this.panelTop.Controls.Add(this.label5);
            this.panelTop.Controls.Add(this.txtObs);
            this.panelTop.Controls.Add(this.label4);
            this.panelTop.Controls.Add(this.txtPreço);
            this.panelTop.Controls.Add(this.label3);
            this.panelTop.Controls.Add(this.txtQuant);
            this.panelTop.Controls.Add(this.label2);
            this.panelTop.Controls.Add(this.txtProd);
            this.panelTop.Controls.Add(this.dateTimePicker1);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Controls.Add(this.txtForn);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 33);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1209, 89);
            this.panelTop.TabIndex = 67;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Corbel", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnAdd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAdd.Location = new System.Drawing.Point(373, 45);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(87, 27);
            this.btnAdd.TabIndex = 79;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 12.25F, System.Drawing.FontStyle.Bold);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(12, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "OBS :";
            // 
            // txtObs
            // 
            this.txtObs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObs.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObs.Location = new System.Drawing.Point(70, 45);
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(274, 27);
            this.txtObs.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 12.25F, System.Drawing.FontStyle.Bold);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(953, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Preço :";
            // 
            // txtPreço
            // 
            this.txtPreço.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPreço.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreço.Location = new System.Drawing.Point(1020, 6);
            this.txtPreço.Name = "txtPreço";
            this.txtPreço.Size = new System.Drawing.Size(62, 27);
            this.txtPreço.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 12.25F, System.Drawing.FontStyle.Bold);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(814, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Quant :";
            // 
            // txtQuant
            // 
            this.txtQuant.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtQuant.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuant.Location = new System.Drawing.Point(885, 6);
            this.txtQuant.Name = "txtQuant";
            this.txtQuant.Size = new System.Drawing.Size(62, 27);
            this.txtQuant.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 12.25F, System.Drawing.FontStyle.Bold);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(484, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Prod :";
            // 
            // txtProd
            // 
            this.txtProd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProd.Location = new System.Drawing.Point(543, 6);
            this.txtProd.Name = "txtProd";
            this.txtProd.Size = new System.Drawing.Size(265, 27);
            this.txtProd.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Calibri", 12.25F, System.Drawing.FontStyle.Italic);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 6);
            this.dateTimePicker1.MaxDate = new System.DateTime(2040, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(157, 27);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.Value = new System.DateTime(2023, 6, 5, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 12.25F, System.Drawing.FontStyle.Bold);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(199, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Forn :";
            // 
            // txtForn
            // 
            this.txtForn.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtForn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtForn.Location = new System.Drawing.Point(257, 6);
            this.txtForn.Name = "txtForn";
            this.txtForn.Size = new System.Drawing.Size(221, 27);
            this.txtForn.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.panel2.Controls.Add(this.label15);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1209, 33);
            this.panel2.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(480, 5);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(242, 23);
            this.label15.TabIndex = 1;
            this.label15.Text = "LANÇAMENTO DE COMPRA";
            // 
            // colForn
            // 
            this.colForn.HeaderText = "Fornecedor";
            this.colForn.Name = "colForn";
            // 
            // colProd
            // 
            this.colProd.HeaderText = "Produto";
            this.colProd.Name = "colProd";
            // 
            // colQtd
            // 
            this.colQtd.HeaderText = "Quantidade";
            this.colQtd.Name = "colQtd";
            // 
            // colPreco
            // 
            this.colPreco.HeaderText = "Preço";
            this.colPreco.Name = "colPreco";
            // 
            // colTot
            // 
            this.colTot.HeaderText = "Total";
            this.colTot.Name = "colTot";
            // 
            // colOBS
            // 
            this.colOBS.HeaderText = "Obeservação";
            this.colOBS.Name = "colOBS";
            // 
            // frmCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 670);
            this.Controls.Add(this.panelPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Lançamento de Compra";
            this.panelPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.panelBottom.ResumeLayout(false);
            this.panelDireita.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtForn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQuant;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPreço;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.Panel panelDireita;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button btnDelItem;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Splitter splitter5;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Splitter splitter8;
        private System.Windows.Forms.Splitter splitter6;
        private System.Windows.Forms.Splitter splitter4;
        private System.Windows.Forms.Splitter splitter7;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnDelAll;
        private System.Windows.Forms.Button btnCadProd;
        private System.Windows.Forms.Button btnCadForn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colForn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPreco;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTot;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOBS;
    }
}