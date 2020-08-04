using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetPass
{
    public partial class frm_login : Form
    {
        //variaveis
        private string sql;
        public static string id;
        public static string usuario;
        //instacia classe conexao
        Classes.conexao conn = new Classes.conexao();
        
        
        public frm_login()
        {       
            InitializeComponent();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            Classes.hash crypt = new Classes.hash();
            //passando txt de string para byte
            byte[] senhaCrypto = new UTF8Encoding().GetBytes(txt_senha.Text);
            //passando array de bytes como parametro e armazenando na variavel
            string senhaMd5 = crypt.Md5(senhaCrypto).ToString();



             sql = string.Format("select usuario from usuario where usuario = '{0}' and senha = '{1}'", txt_username.Text, senhaMd5);

            //validar usuario
            try
            {
                if (conn.login(sql) == 0)
                {
                    lbl_erro.Text = "Nome de usuário ou senha inválidos!";
                }
                else
                {
                    //pegar id e nome do usuario
                    sql = string.Format("select usuario_id,usuario from usuario where usuario = '{0}'", txt_username.Text);
                    DataTable result = new DataTable();
                    result = conn.ConsultarTabelas(sql);
                    id = result.Rows[0]["usuario_id"].ToString();
                    usuario = result.Rows[0]["usuario"].ToString();
                    //abrir formulario index
                    this.Hide();
                    frm_index index = new frm_index();
                    index.ShowDialog();
                    this.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Um erro inesperado ocorreu\nPedimos desculpas pela inconveniência.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void txt_username_Enter(object sender, EventArgs e)
        {
            txt_username.Text = "";
        }
        private void txt_senha_Enter(object sender, EventArgs e)
        {
            txt_senha.Text = "";
            txt_senha.PasswordChar = '*';
        }
        private void txt_username_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_username.Text))
            {
                txt_username.Text = "Usuário";
            }
        }
        private void txt_senha_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_senha.Text))
            {
                txt_senha.Text = "Senha";
            }
        }

        private void llbl_cadastrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            this.Hide();
            frm_cadastro cadastro = new frm_cadastro();
            cadastro.ShowDialog();
            this.Close();
        }
    }
}
