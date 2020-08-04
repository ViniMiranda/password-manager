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
    public partial class frm_cadastro : Form
    {
        public frm_cadastro()
        {
            InitializeComponent();
            txt_senha.PasswordChar = '*';
            txt_confirmar.PasswordChar = '*';
        }
        //variaveis
        Classes.conexao conn = new Classes.conexao();
        private string sql;
        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_login login = new frm_login();
            login.ShowDialog();
            this.Close();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            if (!txt_senha.Text.Equals(txt_confirmar.Text))
            {
                MessageBox.Show("Senhas não coincidem", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txt_senha.Clear();
                txt_confirmar.Clear();
            }
            else if(string.IsNullOrEmpty(txt_nome.Text) || string.IsNullOrEmpty(txt_username.Text))
            {
                MessageBox.Show("Preencha as informações corretamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                sql = string.Format("select * from usuario where usuario = '{0}'", txt_username.Text);

                if (conn.ConsultarTabelas(sql).Rows.Count > 0)
                {
                    MessageBox.Show("Este nome de usuário já existe","Erro",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                else
                {
                    Classes.hash crypt = new Classes.hash();
                    //passando txt de string para byte
                    byte[] senhaCrypto = new UTF8Encoding().GetBytes(txt_senha.Text);
                    //passando array de bytes como parametro e armazenando na variavel
                    string senhaMd5 = crypt.Md5(senhaCrypto).ToString();

                    sql = string.Format("insert into usuario(usuario_id,usuario,senha,nome,data_cadastro) values(null,'{0}','{1}','{2}',now())", txt_username.Text, senhaMd5, txt_nome.Text);

                    conn.AlterarTabelas(sql);

                    this.Hide();
                    frm_login login = new frm_login();
                    login.ShowDialog();
                    this.Close();
                }

            }

        }
    }
}
