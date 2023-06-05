namespace pdv
{
    partial class frmTelaPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTelaPrincipal));
            this.menuTop = new System.Windows.Forms.MenuStrip();
            this.menuCadastros = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadUser = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadCargos = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeGruposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMovimentacoes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMovFluxo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMovLancaVenda = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMovEntrSaida = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMovDespesas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRel = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRelListProd = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRelVenda = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRelMovimento = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRelEntrSaida = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRelDespesas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.btn_CadFuncionarios = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_CadForn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_CadCli = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_CadProd = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.logoPanelLogo = new System.Windows.Forms.PictureBox();
            this.panelTop = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btnCompra = new System.Windows.Forms.Button();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.dataHotaStripLB = new System.Windows.Forms.ToolStripLabel();
            this.horaStripLB = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.nomeUserStripLB = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.cargoStripLB = new System.Windows.Forms.ToolStripLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.menuTop.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPanelLogo)).BeginInit();
            this.panelTop.SuspendLayout();
            this.panelPrincipal.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuTop
            // 
            this.menuTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastros,
            this.menuMovimentacoes,
            this.menuRel,
            this.menuSair});
            this.menuTop.Location = new System.Drawing.Point(0, 0);
            this.menuTop.Name = "menuTop";
            this.menuTop.Size = new System.Drawing.Size(1184, 24);
            this.menuTop.TabIndex = 0;
            this.menuTop.Text = "menuStrip1";
            // 
            // menuCadastros
            // 
            this.menuCadastros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadUser,
            this.menuCadCargos,
            this.cadastroDeGruposToolStripMenuItem});
            this.menuCadastros.Name = "menuCadastros";
            this.menuCadastros.Size = new System.Drawing.Size(76, 20);
            this.menuCadastros.Text = "Casdastros";
            // 
            // menuCadUser
            // 
            this.menuCadUser.Name = "menuCadUser";
            this.menuCadUser.Size = new System.Drawing.Size(185, 22);
            this.menuCadUser.Text = "Cadastro de Usuários";
            this.menuCadUser.Click += new System.EventHandler(this.menuCadUser_Click);
            // 
            // menuCadCargos
            // 
            this.menuCadCargos.Name = "menuCadCargos";
            this.menuCadCargos.Size = new System.Drawing.Size(185, 22);
            this.menuCadCargos.Text = "Cadastro de Cargos";
            this.menuCadCargos.Click += new System.EventHandler(this.menuCadCargos_Click);
            // 
            // cadastroDeGruposToolStripMenuItem
            // 
            this.cadastroDeGruposToolStripMenuItem.Name = "cadastroDeGruposToolStripMenuItem";
            this.cadastroDeGruposToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.cadastroDeGruposToolStripMenuItem.Text = "Cadastro de Grupos";
            this.cadastroDeGruposToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeGruposToolStripMenuItem_Click);
            // 
            // menuMovimentacoes
            // 
            this.menuMovimentacoes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuMovFluxo,
            this.menuMovLancaVenda,
            this.menuMovEntrSaida,
            this.menuMovDespesas});
            this.menuMovimentacoes.Name = "menuMovimentacoes";
            this.menuMovimentacoes.Size = new System.Drawing.Size(104, 20);
            this.menuMovimentacoes.Text = "Movimentações";
            // 
            // menuMovFluxo
            // 
            this.menuMovFluxo.Name = "menuMovFluxo";
            this.menuMovFluxo.Size = new System.Drawing.Size(163, 22);
            this.menuMovFluxo.Text = "Fluxo de Caixa";
            // 
            // menuMovLancaVenda
            // 
            this.menuMovLancaVenda.Name = "menuMovLancaVenda";
            this.menuMovLancaVenda.Size = new System.Drawing.Size(163, 22);
            this.menuMovLancaVenda.Text = "Lançar Venda";
            // 
            // menuMovEntrSaida
            // 
            this.menuMovEntrSaida.Name = "menuMovEntrSaida";
            this.menuMovEntrSaida.Size = new System.Drawing.Size(163, 22);
            this.menuMovEntrSaida.Text = "Entradas / Saídas";
            // 
            // menuMovDespesas
            // 
            this.menuMovDespesas.Name = "menuMovDespesas";
            this.menuMovDespesas.Size = new System.Drawing.Size(163, 22);
            this.menuMovDespesas.Text = "Despesas";
            // 
            // menuRel
            // 
            this.menuRel.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuRelListProd,
            this.menuRelVenda,
            this.menuRelMovimento,
            this.menuRelEntrSaida,
            this.menuRelDespesas});
            this.menuRel.Name = "menuRel";
            this.menuRel.Size = new System.Drawing.Size(71, 20);
            this.menuRel.Text = "Relatórios";
            // 
            // menuRelListProd
            // 
            this.menuRelListProd.Name = "menuRelListProd";
            this.menuRelListProd.Size = new System.Drawing.Size(165, 22);
            this.menuRelListProd.Text = "Lista de Produtos";
            // 
            // menuRelVenda
            // 
            this.menuRelVenda.Name = "menuRelVenda";
            this.menuRelVenda.Size = new System.Drawing.Size(165, 22);
            this.menuRelVenda.Text = "Vendas";
            // 
            // menuRelMovimento
            // 
            this.menuRelMovimento.Name = "menuRelMovimento";
            this.menuRelMovimento.Size = new System.Drawing.Size(165, 22);
            this.menuRelMovimento.Text = "Movimentos";
            // 
            // menuRelEntrSaida
            // 
            this.menuRelEntrSaida.Name = "menuRelEntrSaida";
            this.menuRelEntrSaida.Size = new System.Drawing.Size(165, 22);
            this.menuRelEntrSaida.Text = "Entradas / Saídas";
            // 
            // menuRelDespesas
            // 
            this.menuRelDespesas.Name = "menuRelDespesas";
            this.menuRelDespesas.Size = new System.Drawing.Size(165, 22);
            this.menuRelDespesas.Text = "Despesas";
            // 
            // menuSair
            // 
            this.menuSair.Name = "menuSair";
            this.menuSair.Size = new System.Drawing.Size(38, 20);
            this.menuSair.Text = "Sair";
            this.menuSair.Click += new System.EventHandler(this.menuSair_Click);
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.panelLeft.Controls.Add(this.btn_CadFuncionarios);
            this.panelLeft.Controls.Add(this.label1);
            this.panelLeft.Controls.Add(this.btn_CadForn);
            this.panelLeft.Controls.Add(this.label3);
            this.panelLeft.Controls.Add(this.btn_CadCli);
            this.panelLeft.Controls.Add(this.label2);
            this.panelLeft.Controls.Add(this.btn_CadProd);
            this.panelLeft.Controls.Add(this.panelLogo);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 24);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(295, 737);
            this.panelLeft.TabIndex = 5;
            // 
            // btn_CadFuncionarios
            // 
            this.btn_CadFuncionarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_CadFuncionarios.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btn_CadFuncionarios.FlatAppearance.BorderSize = 0;
            this.btn_CadFuncionarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_CadFuncionarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_CadFuncionarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CadFuncionarios.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold);
            this.btn_CadFuncionarios.ForeColor = System.Drawing.Color.White;
            this.btn_CadFuncionarios.Image = global::pdv.Properties.Resources.adicionar_usuario;
            this.btn_CadFuncionarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CadFuncionarios.Location = new System.Drawing.Point(0, 350);
            this.btn_CadFuncionarios.Name = "btn_CadFuncionarios";
            this.btn_CadFuncionarios.Size = new System.Drawing.Size(295, 70);
            this.btn_CadFuncionarios.TabIndex = 9;
            this.btn_CadFuncionarios.Text = "Cadastro de Funcionarios";
            this.btn_CadFuncionarios.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_CadFuncionarios.UseVisualStyleBackColor = true;
            this.btn_CadFuncionarios.Click += new System.EventHandler(this.btn_CadFuncionarios_Click);
            this.btn_CadFuncionarios.MouseEnter += new System.EventHandler(this.btn_CadFuncionarios_MouseEnter);
            this.btn_CadFuncionarios.MouseLeave += new System.EventHandler(this.btn_CadFuncionarios_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(0, 337);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "________________________________________________";
            // 
            // btn_CadForn
            // 
            this.btn_CadForn.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_CadForn.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btn_CadForn.FlatAppearance.BorderSize = 0;
            this.btn_CadForn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_CadForn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_CadForn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CadForn.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold);
            this.btn_CadForn.ForeColor = System.Drawing.Color.White;
            this.btn_CadForn.Image = global::pdv.Properties.Resources._3forn;
            this.btn_CadForn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CadForn.Location = new System.Drawing.Point(0, 267);
            this.btn_CadForn.Name = "btn_CadForn";
            this.btn_CadForn.Size = new System.Drawing.Size(295, 70);
            this.btn_CadForn.TabIndex = 8;
            this.btn_CadForn.Text = "Cadastro de Forncedor";
            this.btn_CadForn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_CadForn.UseVisualStyleBackColor = true;
            this.btn_CadForn.Click += new System.EventHandler(this.btn_CadForn_Click);
            this.btn_CadForn.MouseEnter += new System.EventHandler(this.btn_CadForn_MouseEnter);
            this.btn_CadForn.MouseLeave += new System.EventHandler(this.btn_CadForn_MouseLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(0, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(295, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "________________________________________________";
            // 
            // btn_CadCli
            // 
            this.btn_CadCli.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_CadCli.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btn_CadCli.FlatAppearance.BorderSize = 0;
            this.btn_CadCli.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_CadCli.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_CadCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CadCli.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Bold);
            this.btn_CadCli.ForeColor = System.Drawing.Color.White;
            this.btn_CadCli.Image = global::pdv.Properties.Resources.cli2;
            this.btn_CadCli.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CadCli.Location = new System.Drawing.Point(0, 184);
            this.btn_CadCli.Name = "btn_CadCli";
            this.btn_CadCli.Size = new System.Drawing.Size(295, 70);
            this.btn_CadCli.TabIndex = 7;
            this.btn_CadCli.Text = "Cadastro de Clientes";
            this.btn_CadCli.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_CadCli.UseVisualStyleBackColor = true;
            this.btn_CadCli.Click += new System.EventHandler(this.btn_CadCli_Click);
            this.btn_CadCli.MouseEnter += new System.EventHandler(this.btn_CadCli_MouseEnter);
            this.btn_CadCli.MouseLeave += new System.EventHandler(this.btn_CadCli_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(0, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(295, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "________________________________________________";
            // 
            // btn_CadProd
            // 
            this.btn_CadProd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_CadProd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_CadProd.FlatAppearance.BorderSize = 0;
            this.btn_CadProd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_CadProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_CadProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CadProd.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Bold);
            this.btn_CadProd.ForeColor = System.Drawing.Color.White;
            this.btn_CadProd.Image = global::pdv.Properties.Resources._2Cadprod2_cópia;
            this.btn_CadProd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CadProd.Location = new System.Drawing.Point(0, 101);
            this.btn_CadProd.Name = "btn_CadProd";
            this.btn_CadProd.Size = new System.Drawing.Size(295, 70);
            this.btn_CadProd.TabIndex = 7;
            this.btn_CadProd.Text = "Cadastro de Produtos";
            this.btn_CadProd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_CadProd.UseVisualStyleBackColor = true;
            this.btn_CadProd.Click += new System.EventHandler(this.btn_CadProd_Click);
            this.btn_CadProd.MouseEnter += new System.EventHandler(this.btn_CadProd_MouseEnter);
            this.btn_CadProd.MouseLeave += new System.EventHandler(this.btn_CadProd_MouseLeave);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.panelLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLogo.Controls.Add(this.logoPanelLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(295, 101);
            this.panelLogo.TabIndex = 7;
            // 
            // logoPanelLogo
            // 
            this.logoPanelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.logoPanelLogo.Location = new System.Drawing.Point(12, 3);
            this.logoPanelLogo.Name = "logoPanelLogo";
            this.logoPanelLogo.Size = new System.Drawing.Size(277, 91);
            this.logoPanelLogo.TabIndex = 7;
            this.logoPanelLogo.TabStop = false;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.panelTop.Controls.Add(this.splitter1);
            this.panelTop.Controls.Add(this.btnCompra);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(295, 24);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(889, 101);
            this.panelTop.TabIndex = 6;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.Blue;
            this.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitter1.Location = new System.Drawing.Point(193, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 101);
            this.splitter1.TabIndex = 14;
            this.splitter1.TabStop = false;
            // 
            // btnCompra
            // 
            this.btnCompra.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCompra.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCompra.FlatAppearance.BorderSize = 0;
            this.btnCompra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCompra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompra.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Bold);
            this.btnCompra.ForeColor = System.Drawing.Color.White;
            this.btnCompra.Image = global::pdv.Properties.Resources.carrinho_de_compras__2_;
            this.btnCompra.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCompra.Location = new System.Drawing.Point(0, 0);
            this.btnCompra.Name = "btnCompra";
            this.btnCompra.Size = new System.Drawing.Size(193, 101);
            this.btnCompra.TabIndex = 13;
            this.btnCompra.Text = "Compra";
            this.btnCompra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompra.UseVisualStyleBackColor = true;
            this.btnCompra.Click += new System.EventHandler(this.btnCompra_Click);
            this.btnCompra.MouseEnter += new System.EventHandler(this.btnCompra_MouseEnter);
            this.btnCompra.MouseLeave += new System.EventHandler(this.btnCompra_MouseLeave);
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.Color.Gray;
            this.panelPrincipal.Controls.Add(this.toolStrip1);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(295, 125);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(889, 636);
            this.panelPrincipal.TabIndex = 7;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Gray;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.dataHotaStripLB,
            this.horaStripLB,
            this.toolStripSeparator1,
            this.toolStripLabel3,
            this.nomeUserStripLB,
            this.toolStripSeparator2,
            this.toolStripLabel2,
            this.cargoStripLB});
            this.toolStrip1.Location = new System.Drawing.Point(0, 611);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(889, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.ForeColor = System.Drawing.Color.White;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(65, 22);
            this.toolStripLabel1.Text = "Data/Hora:";
            // 
            // dataHotaStripLB
            // 
            this.dataHotaStripLB.ForeColor = System.Drawing.Color.White;
            this.dataHotaStripLB.Name = "dataHotaStripLB";
            this.dataHotaStripLB.Size = new System.Drawing.Size(68, 22);
            this.dataHotaStripLB.Text = "00/00/0000 ";
            // 
            // horaStripLB
            // 
            this.horaStripLB.ForeColor = System.Drawing.Color.White;
            this.horaStripLB.Name = "horaStripLB";
            this.horaStripLB.Size = new System.Drawing.Size(49, 22);
            this.horaStripLB.Text = "00:00:00";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.ForeColor = System.Drawing.Color.White;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(50, 22);
            this.toolStripLabel3.Text = "Usuário:";
            // 
            // nomeUserStripLB
            // 
            this.nomeUserStripLB.Name = "nomeUserStripLB";
            this.nomeUserStripLB.Size = new System.Drawing.Size(0, 22);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.ForeColor = System.Drawing.Color.White;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(42, 22);
            this.toolStripLabel2.Text = "Cargo:";
            // 
            // cargoStripLB
            // 
            this.cargoStripLB.Name = "cargoStripLB";
            this.cargoStripLB.Size = new System.Drawing.Size(0, 22);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // frmTelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.menuTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuTop;
            this.Name = "frmTelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDV - BETA";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTelaPrincipal_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmTelaPrincipal_KeyDown);
            this.menuTop.ResumeLayout(false);
            this.menuTop.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPanelLogo)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelPrincipal.ResumeLayout(false);
            this.panelPrincipal.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuTop;
        private System.Windows.Forms.ToolStripMenuItem menuCadastros;
        private System.Windows.Forms.ToolStripMenuItem menuCadUser;
        private System.Windows.Forms.ToolStripMenuItem menuMovimentacoes;
        private System.Windows.Forms.ToolStripMenuItem menuRel;
        private System.Windows.Forms.ToolStripMenuItem menuSair;
        private System.Windows.Forms.ToolStripMenuItem menuCadCargos;
        private System.Windows.Forms.ToolStripMenuItem menuMovFluxo;
        private System.Windows.Forms.ToolStripMenuItem menuMovLancaVenda;
        private System.Windows.Forms.ToolStripMenuItem menuMovEntrSaida;
        private System.Windows.Forms.ToolStripMenuItem menuMovDespesas;
        private System.Windows.Forms.ToolStripMenuItem menuRelListProd;
        private System.Windows.Forms.ToolStripMenuItem menuRelVenda;
        private System.Windows.Forms.ToolStripMenuItem menuRelMovimento;
        private System.Windows.Forms.ToolStripMenuItem menuRelEntrSaida;
        private System.Windows.Forms.ToolStripMenuItem menuRelDespesas;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btn_CadForn;
        private System.Windows.Forms.Button btn_CadProd;
        private System.Windows.Forms.Button btn_CadCli;
        private System.Windows.Forms.PictureBox logoPanelLogo;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeGruposToolStripMenuItem;
        private System.Windows.Forms.Button btn_CadFuncionarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel dataHotaStripLB;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripLabel nomeUserStripLB;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel cargoStripLB;
        private System.Windows.Forms.ToolStripLabel horaStripLB;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btnCompra;
        private System.Windows.Forms.Splitter splitter1;
    }
}

