namespace MyWallet20
{
    partial class JanelaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JanelaPrincipal));
            this.topBar = new System.Windows.Forms.Panel();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.txtNomePrograma = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.painelHistorico = new System.Windows.Forms.Panel();
            this.txbHistorico = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSetup = new System.Windows.Forms.Button();
            this.lblHistorico = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.imgBackMoney = new System.Windows.Forms.PictureBox();
            this.txbDinheiro = new Windows.Forms.HintTextBox(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.imgBackComplemento = new System.Windows.Forms.PictureBox();
            this.imgBackGasto = new System.Windows.Forms.PictureBox();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.txbGastoForn = new Windows.Forms.HintTextBox(this.components);
            this.imgBarGastoForn = new System.Windows.Forms.PictureBox();
            this.btnIndicador = new System.Windows.Forms.Button();
            this.lblGasto = new System.Windows.Forms.Label();
            this.cmbOperacao = new System.Windows.Forms.ComboBox();
            this.imgBackOperacao = new System.Windows.Forms.PictureBox();
            this.lblOperacao = new System.Windows.Forms.Label();
            this.imgBarOperacao = new System.Windows.Forms.PictureBox();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.txbComplemento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblProgressoComp = new System.Windows.Forms.Label();
            this.topBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.painelHistorico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBackMoney)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBackComplemento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBackGasto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBarGastoForn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBackOperacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBarOperacao)).BeginInit();
            this.SuspendLayout();
            // 
            // topBar
            // 
            this.topBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.topBar.Controls.Add(this.imgLogo);
            this.topBar.Controls.Add(this.txtNomePrograma);
            this.topBar.Controls.Add(this.btnClose);
            this.topBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBar.Location = new System.Drawing.Point(0, 0);
            this.topBar.Name = "topBar";
            this.topBar.Size = new System.Drawing.Size(800, 27);
            this.topBar.TabIndex = 0;
            this.topBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topBar_MouseDown);
            this.topBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topBar_MouseMove);
            this.topBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.topBar_MouseUp);
            // 
            // imgLogo
            // 
            this.imgLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogo.Image")));
            this.imgLogo.Location = new System.Drawing.Point(7, 5);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(18, 18);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogo.TabIndex = 3;
            this.imgLogo.TabStop = false;
            // 
            // txtNomePrograma
            // 
            this.txtNomePrograma.AutoSize = true;
            this.txtNomePrograma.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtNomePrograma.Location = new System.Drawing.Point(31, 7);
            this.txtNomePrograma.Name = "txtNomePrograma";
            this.txtNomePrograma.Size = new System.Drawing.Size(51, 13);
            this.txtNomePrograma.TabIndex = 1;
            this.txtNomePrograma.Text = "MyWallet";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Firebrick;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(765, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 27);
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // painelHistorico
            // 
            this.painelHistorico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.painelHistorico.Controls.Add(this.txbHistorico);
            this.painelHistorico.Controls.Add(this.label1);
            this.painelHistorico.Controls.Add(this.btnSetup);
            this.painelHistorico.Controls.Add(this.lblHistorico);
            this.painelHistorico.Controls.Add(this.lblSaldo);
            this.painelHistorico.Controls.Add(this.imgBackMoney);
            this.painelHistorico.Dock = System.Windows.Forms.DockStyle.Left;
            this.painelHistorico.Location = new System.Drawing.Point(0, 27);
            this.painelHistorico.Name = "painelHistorico";
            this.painelHistorico.Size = new System.Drawing.Size(217, 423);
            this.painelHistorico.TabIndex = 2;
            // 
            // txbHistorico
            // 
            this.txbHistorico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.txbHistorico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbHistorico.ForeColor = System.Drawing.SystemColors.Window;
            this.txbHistorico.Location = new System.Drawing.Point(15, 146);
            this.txbHistorico.Name = "txbHistorico";
            this.txbHistorico.ReadOnly = true;
            this.txbHistorico.Size = new System.Drawing.Size(202, 244);
            this.txbHistorico.TabIndex = 5;
            this.txbHistorico.TabStop = false;
            this.txbHistorico.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(27)))), ((int)(((byte)(31)))));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(77, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Meu Saldo";
            // 
            // btnSetup
            // 
            this.btnSetup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(73)))), ((int)(((byte)(171)))));
            this.btnSetup.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSetup.BackgroundImage")));
            this.btnSetup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSetup.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnSetup.FlatAppearance.BorderSize = 0;
            this.btnSetup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetup.Location = new System.Drawing.Point(0, 393);
            this.btnSetup.Name = "btnSetup";
            this.btnSetup.Size = new System.Drawing.Size(30, 30);
            this.btnSetup.TabIndex = 3;
            this.btnSetup.TabStop = false;
            this.btnSetup.UseVisualStyleBackColor = false;
            this.btnSetup.Click += new System.EventHandler(this.btnSetup_Click);
            // 
            // lblHistorico
            // 
            this.lblHistorico.AutoSize = true;
            this.lblHistorico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistorico.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblHistorico.Location = new System.Drawing.Point(68, 125);
            this.lblHistorico.Name = "lblHistorico";
            this.lblHistorico.Size = new System.Drawing.Size(75, 13);
            this.lblHistorico.TabIndex = 2;
            this.lblHistorico.Text = "HISTÓRICO";
            // 
            // lblSaldo
            // 
            this.lblSaldo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(27)))), ((int)(((byte)(31)))));
            this.lblSaldo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(83)))));
            this.lblSaldo.Location = new System.Drawing.Point(0, 47);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(214, 23);
            this.lblSaldo.TabIndex = 1;
            this.lblSaldo.Text = "0,00 R$";
            this.lblSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imgBackMoney
            // 
            this.imgBackMoney.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(27)))), ((int)(((byte)(31)))));
            this.imgBackMoney.Dock = System.Windows.Forms.DockStyle.Top;
            this.imgBackMoney.Location = new System.Drawing.Point(0, 0);
            this.imgBackMoney.Name = "imgBackMoney";
            this.imgBackMoney.Size = new System.Drawing.Size(217, 115);
            this.imgBackMoney.TabIndex = 0;
            this.imgBackMoney.TabStop = false;
            // 
            // txbDinheiro
            // 
            this.txbDinheiro.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.txbDinheiro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbDinheiro.EnterToTab = false;
            this.txbDinheiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDinheiro.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txbDinheiro.HintColor = System.Drawing.Color.WhiteSmoke;
            this.txbDinheiro.HintValue = "R$ 0,00";
            this.txbDinheiro.IsNumerical = true;
            this.txbDinheiro.Location = new System.Drawing.Point(290, 47);
            this.txbDinheiro.MaxLength = 11;
            this.txbDinheiro.Name = "txbDinheiro";
            this.txbDinheiro.Size = new System.Drawing.Size(439, 73);
            this.txbDinheiro.TabIndex = 1;
            this.txbDinheiro.Text = "R$ 0,00";
            this.txbDinheiro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbDinheiro.TextForeColor = System.Drawing.Color.WhiteSmoke;
            this.txbDinheiro.Value = "";
            this.txbDinheiro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbDinheiro_KeyPress);
            this.txbDinheiro.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txbDinheiro_KeyUp);
            this.txbDinheiro.Leave += new System.EventHandler(this.txbDinheiro_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gold;
            this.pictureBox1.Location = new System.Drawing.Point(290, 120);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(441, 4);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.pictureBox5.Location = new System.Drawing.Point(217, 27);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(583, 115);
            this.pictureBox5.TabIndex = 24;
            this.pictureBox5.TabStop = false;
            // 
            // imgBackComplemento
            // 
            this.imgBackComplemento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.imgBackComplemento.Location = new System.Drawing.Point(252, 266);
            this.imgBackComplemento.Name = "imgBackComplemento";
            this.imgBackComplemento.Size = new System.Drawing.Size(122, 31);
            this.imgBackComplemento.TabIndex = 19;
            this.imgBackComplemento.TabStop = false;
            // 
            // imgBackGasto
            // 
            this.imgBackGasto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.imgBackGasto.Location = new System.Drawing.Point(252, 225);
            this.imgBackGasto.Name = "imgBackGasto";
            this.imgBackGasto.Size = new System.Drawing.Size(122, 24);
            this.imgBackGasto.TabIndex = 17;
            this.imgBackGasto.TabStop = false;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(73)))), ((int)(((byte)(171)))));
            this.btnFinalizar.FlatAppearance.BorderSize = 0;
            this.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnFinalizar.Location = new System.Drawing.Point(535, 394);
            this.btnFinalizar.Margin = new System.Windows.Forms.Padding(6);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(235, 38);
            this.btnFinalizar.TabIndex = 5;
            this.btnFinalizar.Text = "FINALIZAR";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // txbGastoForn
            // 
            this.txbGastoForn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(27)))), ((int)(((byte)(31)))));
            this.txbGastoForn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbGastoForn.EnterToTab = false;
            this.txbGastoForn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbGastoForn.ForeColor = System.Drawing.Color.Gray;
            this.txbGastoForn.HintColor = System.Drawing.Color.Gray;
            this.txbGastoForn.HintValue = "Ex\': Câmera Fotográfica";
            this.txbGastoForn.Location = new System.Drawing.Point(374, 225);
            this.txbGastoForn.MaxLength = 27;
            this.txbGastoForn.Name = "txbGastoForn";
            this.txbGastoForn.Size = new System.Drawing.Size(395, 24);
            this.txbGastoForn.TabIndex = 3;
            this.txbGastoForn.Text = "Ex\': Câmera Fotográfica";
            this.txbGastoForn.TextForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txbGastoForn.Value = "";
            this.txbGastoForn.TextChanged += new System.EventHandler(this.txbGastoForn_TextChanged);
            // 
            // imgBarGastoForn
            // 
            this.imgBarGastoForn.BackColor = System.Drawing.Color.DarkRed;
            this.imgBarGastoForn.Location = new System.Drawing.Point(252, 249);
            this.imgBarGastoForn.Name = "imgBarGastoForn";
            this.imgBarGastoForn.Size = new System.Drawing.Size(518, 2);
            this.imgBarGastoForn.TabIndex = 8;
            this.imgBarGastoForn.TabStop = false;
            // 
            // btnIndicador
            // 
            this.btnIndicador.BackColor = System.Drawing.Color.DarkRed;
            this.btnIndicador.FlatAppearance.BorderSize = 0;
            this.btnIndicador.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnIndicador.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnIndicador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIndicador.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIndicador.ForeColor = System.Drawing.Color.White;
            this.btnIndicador.Location = new System.Drawing.Point(733, 224);
            this.btnIndicador.Name = "btnIndicador";
            this.btnIndicador.Size = new System.Drawing.Size(37, 25);
            this.btnIndicador.TabIndex = 10;
            this.btnIndicador.TabStop = false;
            this.btnIndicador.Text = "X";
            this.btnIndicador.UseVisualStyleBackColor = false;
            // 
            // lblGasto
            // 
            this.lblGasto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.lblGasto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGasto.ForeColor = System.Drawing.Color.Gold;
            this.lblGasto.Location = new System.Drawing.Point(259, 230);
            this.lblGasto.Name = "lblGasto";
            this.lblGasto.Size = new System.Drawing.Size(106, 19);
            this.lblGasto.TabIndex = 11;
            this.lblGasto.Text = "GASTO:";
            this.lblGasto.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cmbOperacao
            // 
            this.cmbOperacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(27)))), ((int)(((byte)(31)))));
            this.cmbOperacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbOperacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.cmbOperacao.ForeColor = System.Drawing.Color.FloralWhite;
            this.cmbOperacao.FormattingEnabled = true;
            this.cmbOperacao.Items.AddRange(new object[] {
            "SAQUE",
            "DEPÓSITO"});
            this.cmbOperacao.Location = new System.Drawing.Point(374, 175);
            this.cmbOperacao.Name = "cmbOperacao";
            this.cmbOperacao.Size = new System.Drawing.Size(395, 33);
            this.cmbOperacao.TabIndex = 2;
            this.cmbOperacao.SelectedIndexChanged += new System.EventHandler(this.cmbOperacao_SelectedIndexChanged);
            // 
            // imgBackOperacao
            // 
            this.imgBackOperacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.imgBackOperacao.Location = new System.Drawing.Point(252, 175);
            this.imgBackOperacao.Name = "imgBackOperacao";
            this.imgBackOperacao.Size = new System.Drawing.Size(122, 33);
            this.imgBackOperacao.TabIndex = 13;
            this.imgBackOperacao.TabStop = false;
            // 
            // lblOperacao
            // 
            this.lblOperacao.AutoSize = true;
            this.lblOperacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.lblOperacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperacao.ForeColor = System.Drawing.Color.Gold;
            this.lblOperacao.Location = new System.Drawing.Point(287, 185);
            this.lblOperacao.Name = "lblOperacao";
            this.lblOperacao.Size = new System.Drawing.Size(78, 13);
            this.lblOperacao.TabIndex = 14;
            this.lblOperacao.Text = "OPERAÇÃO:";
            // 
            // imgBarOperacao
            // 
            this.imgBarOperacao.BackColor = System.Drawing.Color.DarkRed;
            this.imgBarOperacao.Location = new System.Drawing.Point(252, 208);
            this.imgBarOperacao.Name = "imgBarOperacao";
            this.imgBarOperacao.Size = new System.Drawing.Size(518, 2);
            this.imgBarOperacao.TabIndex = 15;
            this.imgBarOperacao.TabStop = false;
            // 
            // lblComplemento
            // 
            this.lblComplemento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.lblComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComplemento.ForeColor = System.Drawing.Color.Gold;
            this.lblComplemento.Location = new System.Drawing.Point(256, 275);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(109, 13);
            this.lblComplemento.TabIndex = 18;
            this.lblComplemento.Text = "COMPLEMENTO:";
            this.lblComplemento.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txbComplemento
            // 
            this.txbComplemento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(27)))), ((int)(((byte)(31)))));
            this.txbComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbComplemento.ForeColor = System.Drawing.Color.White;
            this.txbComplemento.Location = new System.Drawing.Point(374, 267);
            this.txbComplemento.MaxLength = 120;
            this.txbComplemento.Multiline = true;
            this.txbComplemento.Name = "txbComplemento";
            this.txbComplemento.Size = new System.Drawing.Size(395, 92);
            this.txbComplemento.TabIndex = 4;
            this.txbComplemento.TextChanged += new System.EventHandler(this.txbComplemento_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(372, 366);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "OBS: O Complemento é opcional.";
            // 
            // lblProgressoComp
            // 
            this.lblProgressoComp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.lblProgressoComp.ForeColor = System.Drawing.Color.Gray;
            this.lblProgressoComp.Location = new System.Drawing.Point(717, 363);
            this.lblProgressoComp.Name = "lblProgressoComp";
            this.lblProgressoComp.Size = new System.Drawing.Size(54, 13);
            this.lblProgressoComp.TabIndex = 23;
            this.lblProgressoComp.Text = "0 / 120";
            this.lblProgressoComp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // JanelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblProgressoComp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbComplemento);
            this.Controls.Add(this.lblComplemento);
            this.Controls.Add(this.imgBarOperacao);
            this.Controls.Add(this.lblOperacao);
            this.Controls.Add(this.imgBackOperacao);
            this.Controls.Add(this.cmbOperacao);
            this.Controls.Add(this.lblGasto);
            this.Controls.Add(this.btnIndicador);
            this.Controls.Add(this.imgBarGastoForn);
            this.Controls.Add(this.txbGastoForn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txbDinheiro);
            this.Controls.Add(this.painelHistorico);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.topBar);
            this.Controls.Add(this.imgBackGasto);
            this.Controls.Add(this.imgBackComplemento);
            this.Controls.Add(this.pictureBox5);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "JanelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyWallet";
            this.topBar.ResumeLayout(false);
            this.topBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.painelHistorico.ResumeLayout(false);
            this.painelHistorico.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBackMoney)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBackComplemento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBackGasto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBarGastoForn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBackOperacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBarOperacao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel topBar;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label txtNomePrograma;
        private System.Windows.Forms.Panel painelHistorico;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.PictureBox imgBackMoney;
        private System.Windows.Forms.Label lblHistorico;
        private System.Windows.Forms.Button btnSetup;
        private Windows.Forms.HintTextBox txbDinheiro;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox5;
        public System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.RichTextBox txbHistorico;
        private System.Windows.Forms.PictureBox imgBackComplemento;
        private System.Windows.Forms.PictureBox imgBackGasto;
        private System.Windows.Forms.Button btnFinalizar;
        private Windows.Forms.HintTextBox txbGastoForn;
        private System.Windows.Forms.PictureBox imgBarGastoForn;
        private System.Windows.Forms.Button btnIndicador;
        private System.Windows.Forms.Label lblGasto;
        private System.Windows.Forms.ComboBox cmbOperacao;
        private System.Windows.Forms.PictureBox imgBackOperacao;
        private System.Windows.Forms.Label lblOperacao;
        private System.Windows.Forms.PictureBox imgBarOperacao;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.TextBox txbComplemento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblProgressoComp;
    }
}

