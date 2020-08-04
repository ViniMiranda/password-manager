namespace GetPass
{
    partial class frm_index
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_index));
            this.btn_guardar = new System.Windows.Forms.Button();
            this.txt_nomesite = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.lbl_nomesite = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_senha = new System.Windows.Forms.Label();
            this.btn_visualizar = new System.Windows.Forms.Button();
            this.lbl_erro = new System.Windows.Forms.Label();
            this.pnl_header = new System.Windows.Forms.Panel();
            this.btn_sair = new System.Windows.Forms.Button();
            this.lbl_headerText = new System.Windows.Forms.Label();
            this.btn_configuracoes = new System.Windows.Forms.Button();
            this.pnl_header.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_guardar
            // 
            this.btn_guardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(14)))), ((int)(((byte)(125)))));
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_guardar.Location = new System.Drawing.Point(59, 329);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(230, 40);
            this.btn_guardar.TabIndex = 0;
            this.btn_guardar.Text = "Adicionar";
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // txt_nomesite
            // 
            this.txt_nomesite.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_nomesite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.txt_nomesite.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nomesite.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txt_nomesite.Location = new System.Drawing.Point(59, 149);
            this.txt_nomesite.Name = "txt_nomesite";
            this.txt_nomesite.Size = new System.Drawing.Size(230, 24);
            this.txt_nomesite.TabIndex = 5;
            // 
            // txt_nome
            // 
            this.txt_nome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_nome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.txt_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nome.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txt_nome.Location = new System.Drawing.Point(59, 212);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(230, 24);
            this.txt_nome.TabIndex = 6;
            // 
            // txt_senha
            // 
            this.txt_senha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_senha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.txt_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_senha.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txt_senha.Location = new System.Drawing.Point(59, 278);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.Size = new System.Drawing.Size(230, 24);
            this.txt_senha.TabIndex = 7;
            // 
            // lbl_nomesite
            // 
            this.lbl_nomesite.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_nomesite.AutoSize = true;
            this.lbl_nomesite.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nomesite.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_nomesite.Location = new System.Drawing.Point(56, 128);
            this.lbl_nomesite.Name = "lbl_nomesite";
            this.lbl_nomesite.Size = new System.Drawing.Size(126, 18);
            this.lbl_nomesite.TabIndex = 8;
            this.lbl_nomesite.Text = "Nome do serviço:";
            // 
            // lbl_nome
            // 
            this.lbl_nome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_nome.Location = new System.Drawing.Point(56, 191);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(126, 18);
            this.lbl_nome.TabIndex = 9;
            this.lbl_nome.Text = "Nome de usuário:";
            // 
            // lbl_senha
            // 
            this.lbl_senha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_senha.AutoSize = true;
            this.lbl_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_senha.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_senha.Location = new System.Drawing.Point(62, 257);
            this.lbl_senha.Name = "lbl_senha";
            this.lbl_senha.Size = new System.Drawing.Size(140, 18);
            this.lbl_senha.TabIndex = 11;
            this.lbl_senha.Text = "Senha a se guardar:";
            // 
            // btn_visualizar
            // 
            this.btn_visualizar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_visualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btn_visualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_visualizar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_visualizar.Location = new System.Drawing.Point(59, 380);
            this.btn_visualizar.Name = "btn_visualizar";
            this.btn_visualizar.Size = new System.Drawing.Size(230, 43);
            this.btn_visualizar.TabIndex = 14;
            this.btn_visualizar.Text = "Visualizar";
            this.btn_visualizar.UseVisualStyleBackColor = false;
            this.btn_visualizar.Click += new System.EventHandler(this.btn_visualizar_Click);
            this.btn_visualizar.MouseLeave += new System.EventHandler(this.btn_visualizar_MouseLeave);
            this.btn_visualizar.MouseHover += new System.EventHandler(this.btn_visualizar_MouseHover);
            // 
            // lbl_erro
            // 
            this.lbl_erro.AutoSize = true;
            this.lbl_erro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_erro.ForeColor = System.Drawing.Color.Red;
            this.lbl_erro.Location = new System.Drawing.Point(20, 101);
            this.lbl_erro.Name = "lbl_erro";
            this.lbl_erro.Size = new System.Drawing.Size(0, 20);
            this.lbl_erro.TabIndex = 15;
            // 
            // pnl_header
            // 
            this.pnl_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(14)))), ((int)(((byte)(125)))));
            this.pnl_header.Controls.Add(this.btn_sair);
            this.pnl_header.Controls.Add(this.lbl_headerText);
            this.pnl_header.Location = new System.Drawing.Point(-2, -2);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(346, 100);
            this.pnl_header.TabIndex = 16;
            // 
            // btn_sair
            // 
            this.btn_sair.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_sair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(14)))), ((int)(((byte)(125)))));
            this.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_sair.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_sair.Image = global::GetPass.Properties.Resources.back;
            this.btn_sair.Location = new System.Drawing.Point(3, 0);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(47, 45);
            this.btn_sair.TabIndex = 24;
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // lbl_headerText
            // 
            this.lbl_headerText.AutoSize = true;
            this.lbl_headerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_headerText.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_headerText.Location = new System.Drawing.Point(38, 48);
            this.lbl_headerText.Name = "lbl_headerText";
            this.lbl_headerText.Size = new System.Drawing.Size(280, 29);
            this.lbl_headerText.TabIndex = 0;
            this.lbl_headerText.Text = "Guardar uma nova senha";
            // 
            // btn_configuracoes
            // 
            this.btn_configuracoes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_configuracoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(14)))), ((int)(((byte)(125)))));
            this.btn_configuracoes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_configuracoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_configuracoes.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_configuracoes.Location = new System.Drawing.Point(59, 433);
            this.btn_configuracoes.Name = "btn_configuracoes";
            this.btn_configuracoes.Size = new System.Drawing.Size(230, 40);
            this.btn_configuracoes.TabIndex = 17;
            this.btn_configuracoes.Text = "Configurações";
            this.btn_configuracoes.UseVisualStyleBackColor = false;
            this.btn_configuracoes.Click += new System.EventHandler(this.btn_configuracoes_Click);
            // 
            // frm_index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(344, 501);
            this.Controls.Add(this.btn_configuracoes);
            this.Controls.Add(this.pnl_header);
            this.Controls.Add(this.lbl_erro);
            this.Controls.Add(this.btn_visualizar);
            this.Controls.Add(this.lbl_senha);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.txt_nomesite);
            this.Controls.Add(this.lbl_nomesite);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.txt_senha);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(360, 540);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(360, 540);
            this.Name = "frm_index";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar";
            this.pnl_header.ResumeLayout(false);
            this.pnl_header.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.TextBox txt_nomesite;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.Label lbl_nomesite;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_senha;
        private System.Windows.Forms.Button btn_visualizar;
        private System.Windows.Forms.Label lbl_erro;
        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.Label lbl_headerText;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_configuracoes;
    }
}