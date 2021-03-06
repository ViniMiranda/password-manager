﻿using System;
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
    public partial class frm_gerenciador : Form
    {
        
        public frm_gerenciador()
        {
            InitializeComponent();
        }
        private string sql;
        private string msgError = "O ID não pode ser nulo ou negativo";
        Classes.conexao conn = new Classes.conexao();
        
        //btn alterar
        private void btn_alterar_Click(object sender, EventArgs e)
        {
            if(nud_id.Value <= 0)
            {
                lbl_erro.Text = msgError;
            }
            else
            {
                this.Hide();
                frm_alterar alterar = new frm_alterar(nud_id.Value);
                alterar.ShowDialog();
                this.Close();
            }

        }
        //excluir
        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if(nud_id.Value <= 0)
            {
                lbl_erro.Text = msgError;
            }
            else
            {
                try
                {
                    sql = "delete from gerenciador where id = '" + nud_id.Value + "' and usuario = '" + frm_login.id + "'";

                    conn.AlterarTabelas(sql);
                    MessageBox.Show("Campo excluido", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Listar();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ops algo deu errado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }
        //voltar
        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_index index = new frm_index();
            index.ShowDialog();
            this.Close();
        }
        //listar datagrid ao carregar o formulario
        private void Frm_gerenciador_Load(object sender, EventArgs e)
        {
            Listar();
        }
        //metodos
        public void Listar()
        {
            sql = "select id,siteNome,login,senha from gerenciador where usuario = '"+frm_login.id+"'";
            dgv_info.DataSource = conn.ConsultarTabelas(sql);
        }
    }
}
