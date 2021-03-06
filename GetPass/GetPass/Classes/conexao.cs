﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;


namespace GetPass.Classes
{
    class conexao
    {
        private MySqlConnection conexaoDB;
        public void Conectar()
        {
                conexaoDB = new MySqlConnection("persist security info = false;server=localhost;database=login;uid=root;pwd=root;");
                     if (conexaoDB.State == ConnectionState.Closed)
                     conexaoDB.Open();
        }
        public void AlterarTabelas(string sql)
        {
                Conectar();
                MySqlCommand comandosAlt = new MySqlCommand(sql, conexaoDB);
                comandosAlt.ExecuteNonQuery();
                conexaoDB.Close();
        }
        public DataTable ConsultarTabelas(string sql)
        {
                Conectar();
                MySqlDataAdapter consulta = new MySqlDataAdapter(sql, conexaoDB);
                DataTable resultado = new DataTable();
                consulta.Fill(resultado);
                conexaoDB.Close();
                return resultado;
        }
        public int login(string sql)
        {
                Conectar();
                int i;
                MySqlCommand command = conexaoDB.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = sql;
                command.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(command);
                da.Fill(dt);
                i = Convert.ToInt32(dt.Rows.Count.ToString());
                conexaoDB.Close();
                return i;
        }
        

       
    }
}
