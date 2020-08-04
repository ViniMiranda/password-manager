namespace GetPass
{
    partial class frm_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_login));
            this.pnl_header = new System.Windows.Forms.Panel();
            this.lbl_headerText = new System.Windows.Forms.Label();
            this.pbx_logo = new System.Windows.Forms.PictureBox();
            this.btn_entrar = new System.Windows.Forms.Button();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.lbl_erro = new System.Windows.Forms.Label();
            this.lbl_cadastro = new System.Windows.Forms.Label();
            this.llbl_cadastrar = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pbx_senha = new System.Windows.Forms.PictureBox();
            this.pbx_user = new System.Windows.Forms.PictureBox();
            this.pnl_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_senha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_user)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_header
            // 
            this.pnl_header.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnl_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(14)))), ((int)(((byte)(125)))));
            this.pnl_header.Controls.Add(this.lbl_headerText);
            this.pnl_header.Controls.Add(this.pbx_logo);
            this.pnl_header.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnl_header.Location = new System.Drawing.Point(-6, -2);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(354, 117);
            this.pnl_header.TabIndex = 10;
            // 
            // lbl_headerText
            // 
            this.lbl_headerText.AutoSize = true;
            this.lbl_headerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_headerText.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_headerText.Location = new System.Drawing.Point(131, 51);
            this.lbl_headerText.Name = "lbl_headerText";
            this.lbl_headerText.Size = new System.Drawing.Size(161, 25);
            this.lbl_headerText.TabIndex = 12;
            this.lbl_headerText.Text = "Realize o Login";
            // 
            // pbx_logo
            // 
            this.pbx_logo.Image = global::GetPass.Properties.Resources.LogoNova;
            this.pbx_logo.Location = new System.Drawing.Point(3, 3);
            this.pbx_logo.Name = "pbx_logo";
            this.pbx_logo.Size = new System.Drawing.Size(117, 114);
            this.pbx_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_logo.TabIndex = 11;
            this.pbx_logo.TabStop = false;
            // 
            // btn_entrar
            // 
            this.btn_entrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_entrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(14)))), ((int)(((byte)(125)))));
            this.btn_entrar.FlatAppearance.BorderSize = 0;
            this.btn_entrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_entrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_entrar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_entrar.Location = new System.Drawing.Point(55, 399);
            this.btn_entrar.Name = "btn_entrar";
            this.btn_entrar.Size = new System.Drawing.Size(230, 40);
            this.btn_entrar.TabIndex = 1;
            this.btn_entrar.Text = "Entrar";
            this.btn_entrar.UseVisualStyleBackColor = false;
            this.btn_entrar.Click += new System.EventHandler(this.btn_entrar_Click);
            // 
            // txt_username
            // 
            this.txt_username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.txt_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txt_username.Location = new System.Drawing.Point(100, 187);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(191, 17);
            this.txt_username.TabIndex = 3;
            this.txt_username.Text = "Usuário";
            this.txt_username.Enter += new System.EventHandler(this.txt_username_Enter);
            this.txt_username.Leave += new System.EventHandler(this.txt_username_Leave);
            // 
            // txt_senha
            // 
            this.txt_senha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_senha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.txt_senha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_senha.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txt_senha.Location = new System.Drawing.Point(100, 240);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.Size = new System.Drawing.Size(191, 17);
            this.txt_senha.TabIndex = 6;
            this.txt_senha.Text = "Senha";
            this.txt_senha.Enter += new System.EventHandler(this.txt_senha_Enter);
            this.txt_senha.Leave += new System.EventHandler(this.txt_senha_Leave);
            // 
            // lbl_erro
            // 
            this.lbl_erro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_erro.AutoSize = true;
            this.lbl_erro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_erro.ForeColor = System.Drawing.Color.Red;
            this.lbl_erro.Location = new System.Drawing.Point(36, 278);
            this.lbl_erro.Name = "lbl_erro";
            this.lbl_erro.Size = new System.Drawing.Size(0, 20);
            this.lbl_erro.TabIndex = 11;
            // 
            // lbl_cadastro
            // 
            this.lbl_cadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_cadastro.AutoSize = true;
            this.lbl_cadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cadastro.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_cadastro.Location = new System.Drawing.Point(36, 356);
            this.lbl_cadastro.Name = "lbl_cadastro";
            this.lbl_cadastro.Size = new System.Drawing.Size(184, 20);
            this.lbl_cadastro.TabIndex = 12;
            this.lbl_cadastro.Text = "Ainda não possui conta?";
            // 
            // llbl_cadastrar
            // 
            this.llbl_cadastrar.ActiveLinkColor = System.Drawing.Color.Navy;
            this.llbl_cadastrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.llbl_cadastrar.AutoSize = true;
            this.llbl_cadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbl_cadastrar.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.llbl_cadastrar.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(126)))), ((int)(((byte)(219)))));
            this.llbl_cadastrar.Location = new System.Drawing.Point(217, 356);
            this.llbl_cadastrar.Name = "llbl_cadastrar";
            this.llbl_cadastrar.Size = new System.Drawing.Size(83, 20);
            this.llbl_cadastrar.TabIndex = 13;
            this.llbl_cadastrar.TabStop = true;
            this.llbl_cadastrar.Text = " Cadastrar";
            this.llbl_cadastrar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbl_cadastrar_LinkClicked);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(100, 205);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(191, 1);
            this.panel2.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(100, 259);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(191, 1);
            this.panel3.TabIndex = 17;
            // 
            // pbx_senha
            // 
            this.pbx_senha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbx_senha.Image = global::GetPass.Properties.Resources.senha;
            this.pbx_senha.Location = new System.Drawing.Point(41, 232);
            this.pbx_senha.Name = "pbx_senha";
            this.pbx_senha.Size = new System.Drawing.Size(33, 28);
            this.pbx_senha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_senha.TabIndex = 15;
            this.pbx_senha.TabStop = false;
            // 
            // pbx_user
            // 
            this.pbx_user.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbx_user.Image = global::GetPass.Properties.Resources.user;
            this.pbx_user.Location = new System.Drawing.Point(40, 187);
            this.pbx_user.Name = "pbx_user";
            this.pbx_user.Size = new System.Drawing.Size(34, 28);
            this.pbx_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_user.TabIndex = 14;
            this.pbx_user.TabStop = false;
            // 
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(344, 501);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pbx_senha);
            this.Controls.Add(this.pbx_user);
            this.Controls.Add(this.llbl_cadastrar);
            this.Controls.Add(this.lbl_cadastro);
            this.Controls.Add(this.lbl_erro);
            this.Controls.Add(this.pnl_header);
            this.Controls.Add(this.btn_entrar);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.txt_username);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(360, 540);
            this.MinimumSize = new System.Drawing.Size(360, 540);
            this.Name = "frm_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GetPass - Login";
            this.pnl_header.ResumeLayout(false);
            this.pnl_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_senha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_user)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.Button btn_entrar;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.Label lbl_erro;
        private System.Windows.Forms.PictureBox pbx_logo;
        private System.Windows.Forms.Label lbl_cadastro;
        private System.Windows.Forms.LinkLabel llbl_cadastrar;
        private System.Windows.Forms.PictureBox pbx_user;
        private System.Windows.Forms.PictureBox pbx_senha;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_headerText;
    }
}

