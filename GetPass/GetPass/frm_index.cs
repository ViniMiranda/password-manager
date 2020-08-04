using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetPass
{
    public partial class frm_index : Form
    {

        public frm_index()
        {
            InitializeComponent();
        }
        //var & stuff
        Classes.conexao conn = new Classes.conexao();
        private string sql;
        //adicionar
        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txt_nome.Text) || string.IsNullOrWhiteSpace(txt_nomesite.Text)|| string.IsNullOrWhiteSpace(txt_senha.Text))
            {
                lbl_erro.Text = "Todos os campos devem ser preenchidos";
            }
            else
            {
                try
                {
                    sql = string.Format("insert into gerenciador values(null,'{0}','{1}','{2}','{3}')", txt_nomesite.Text, txt_nome.Text, txt_senha.Text, frm_login.id);

                    conn.AlterarTabelas(sql);

                    MessageBox.Show("Senha registrada com sucesso", "Registrar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Limpar();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ops algo deu errado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        //btn visualizar
        private void btn_visualizar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_gerenciador geren = new frm_gerenciador();
            geren.ShowDialog();
            this.Close();
        }
        private void btn_visualizar_MouseHover(object sender, EventArgs e)
        {
            btn_visualizar.BackColor = Color.FromArgb(29, 126, 219);
            btn_visualizar.FlatStyle = FlatStyle.Popup;
        }

        private void btn_visualizar_MouseLeave(object sender, EventArgs e)
        {
            btn_visualizar.BackColor = Color.FromArgb(10, 10, 10);
            btn_visualizar.FlatStyle = FlatStyle.Standard;
        }
        //btn sair

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_login login = new frm_login();
            login.ShowDialog();
            this.Close();
        }
        private void btn_configuracoes_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_config config = new frm_config();
            config.ShowDialog();
            this.Close();
        }
        //metodos
        public void Limpar()
        {
            txt_nome.Clear();
            txt_nomesite.Clear();
            txt_senha.Clear();
            txt_nomesite.Focus();
        }
    }
}
