namespace MyWallet
{
    partial class SetupForm
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
            this.btnClose = new System.Windows.Forms.Button();
            this.topBar = new System.Windows.Forms.Panel();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.txtNomePrograma = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtPrograma = new System.Windows.Forms.Label();
            this.btnAtualizacoes = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLimparht = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnSHistorico = new System.Windows.Forms.Button();
            this.btnZerarsaldo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnTemaE = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnTemaC = new System.Windows.Forms.Button();
            this.topBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
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
            this.btnClose.Location = new System.Drawing.Point(494, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 27);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            this.topBar.Size = new System.Drawing.Size(529, 27);
            this.topBar.TabIndex = 1;
            this.topBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topBar_MouseDown);
            this.topBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topBar_MouseMove);
            this.topBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.topBar_MouseUp);
            // 
            // imgLogo
            // 
            this.imgLogo.Image = global::MyWallet.Properties.Resources.engrenagem;
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
            this.txtNomePrograma.Size = new System.Drawing.Size(75, 13);
            this.txtNomePrograma.TabIndex = 1;
            this.txtNomePrograma.Text = "Configurações";
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnOK.FlatAppearance.BorderSize = 0;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOK.Location = new System.Drawing.Point(390, 12);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(127, 33);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkRed;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(255, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 33);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancelar\r\n";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // txtPrograma
            // 
            this.txtPrograma.AutoSize = true;
            this.txtPrograma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(27)))), ((int)(((byte)(31)))));
            this.txtPrograma.ForeColor = System.Drawing.Color.Gold;
            this.txtPrograma.Location = new System.Drawing.Point(38, 66);
            this.txtPrograma.Name = "txtPrograma";
            this.txtPrograma.Size = new System.Drawing.Size(51, 13);
            this.txtPrograma.TabIndex = 4;
            this.txtPrograma.Text = "MyWallet";
            // 
            // btnAtualizacoes
            // 
            this.btnAtualizacoes.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAtualizacoes.FlatAppearance.BorderSize = 0;
            this.btnAtualizacoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizacoes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAtualizacoes.Location = new System.Drawing.Point(327, 56);
            this.btnAtualizacoes.Name = "btnAtualizacoes";
            this.btnAtualizacoes.Size = new System.Drawing.Size(177, 33);
            this.btnAtualizacoes.TabIndex = 5;
            this.btnAtualizacoes.Text = "Verificar Atualizações";
            this.btnAtualizacoes.UseVisualStyleBackColor = false;
            this.btnAtualizacoes.Click += new System.EventHandler(this.btnAtualizacoes_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(27)))), ((int)(((byte)(31)))));
            this.pictureBox1.Location = new System.Drawing.Point(25, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(303, 33);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 243);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(529, 57);
            this.panel1.TabIndex = 8;
            // 
            // btnLimparht
            // 
            this.btnLimparht.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnLimparht.FlatAppearance.BorderSize = 0;
            this.btnLimparht.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimparht.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLimparht.Location = new System.Drawing.Point(378, 98);
            this.btnLimparht.Name = "btnLimparht";
            this.btnLimparht.Size = new System.Drawing.Size(126, 33);
            this.btnLimparht.TabIndex = 10;
            this.btnLimparht.Text = "Limpar Histórico";
            this.btnLimparht.UseVisualStyleBackColor = false;
            this.btnLimparht.Click += new System.EventHandler(this.btnLimparht_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(27)))), ((int)(((byte)(31)))));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(38, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Histórico";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(27)))), ((int)(((byte)(31)))));
            this.pictureBox2.Location = new System.Drawing.Point(25, 98);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(479, 33);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // btnSHistorico
            // 
            this.btnSHistorico.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSHistorico.FlatAppearance.BorderSize = 0;
            this.btnSHistorico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSHistorico.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSHistorico.Location = new System.Drawing.Point(246, 98);
            this.btnSHistorico.Name = "btnSHistorico";
            this.btnSHistorico.Size = new System.Drawing.Size(126, 33);
            this.btnSHistorico.TabIndex = 12;
            this.btnSHistorico.Text = "Salvar Histórico";
            this.btnSHistorico.UseVisualStyleBackColor = false;
            this.btnSHistorico.Click += new System.EventHandler(this.btnSHistorico_Click);
            // 
            // btnZerarsaldo
            // 
            this.btnZerarsaldo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnZerarsaldo.FlatAppearance.BorderSize = 0;
            this.btnZerarsaldo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZerarsaldo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnZerarsaldo.Location = new System.Drawing.Point(327, 140);
            this.btnZerarsaldo.Name = "btnZerarsaldo";
            this.btnZerarsaldo.Size = new System.Drawing.Size(177, 33);
            this.btnZerarsaldo.TabIndex = 14;
            this.btnZerarsaldo.Text = "Zerar Saldo";
            this.btnZerarsaldo.UseVisualStyleBackColor = false;
            this.btnZerarsaldo.Click += new System.EventHandler(this.btnZerarsaldo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(27)))), ((int)(((byte)(31)))));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(38, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Saldo";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(27)))), ((int)(((byte)(31)))));
            this.pictureBox3.Location = new System.Drawing.Point(25, 140);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(303, 33);
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // btnTemaE
            // 
            this.btnTemaE.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnTemaE.FlatAppearance.BorderSize = 0;
            this.btnTemaE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemaE.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTemaE.Location = new System.Drawing.Point(378, 183);
            this.btnTemaE.Name = "btnTemaE";
            this.btnTemaE.Size = new System.Drawing.Size(126, 33);
            this.btnTemaE.TabIndex = 17;
            this.btnTemaE.Text = "Tema Escuro";
            this.btnTemaE.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(27)))), ((int)(((byte)(31)))));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(38, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Tema";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(27)))), ((int)(((byte)(31)))));
            this.pictureBox4.Location = new System.Drawing.Point(25, 183);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(479, 33);
            this.pictureBox4.TabIndex = 18;
            this.pictureBox4.TabStop = false;
            // 
            // btnTemaC
            // 
            this.btnTemaC.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnTemaC.FlatAppearance.BorderSize = 0;
            this.btnTemaC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemaC.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTemaC.Location = new System.Drawing.Point(246, 183);
            this.btnTemaC.Name = "btnTemaC";
            this.btnTemaC.Size = new System.Drawing.Size(126, 33);
            this.btnTemaC.TabIndex = 19;
            this.btnTemaC.Text = "Tema Claro";
            this.btnTemaC.UseVisualStyleBackColor = false;
            this.btnTemaC.Click += new System.EventHandler(this.btnTemaC_Click);
            // 
            // SetupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(529, 300);
            this.Controls.Add(this.btnTemaC);
            this.Controls.Add(this.btnTemaE);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.btnZerarsaldo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnSHistorico);
            this.Controls.Add(this.btnLimparht);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAtualizacoes);
            this.Controls.Add(this.txtPrograma);
            this.Controls.Add(this.topBar);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SetupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurações";
            this.topBar.ResumeLayout(false);
            this.topBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel topBar;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Label txtNomePrograma;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label txtPrograma;
        private System.Windows.Forms.Button btnAtualizacoes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLimparht;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnSHistorico;
        private System.Windows.Forms.Button btnZerarsaldo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnTemaE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnTemaC;
    }
}