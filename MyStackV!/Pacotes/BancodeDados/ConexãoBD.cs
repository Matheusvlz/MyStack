using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows;

namespace MyStackV_.Pacotes.BancodeDados
{
    internal class ConexãoBD
    {
        private string rede = "server=127.0.0.1;port=3306;database=mystack;uid=matheus;password=123";

        public MySqlConnection ObterConexao()
        {
            return new MySqlConnection(rede); 
        }
        public MySqlConnection TestarConexao()
        {
            using (MySqlConnection connection = new MySqlConnection(rede))
            {
                try
                {
                    connection.Open();
                    MessageBox.Show("tudo certo");
                    Console.WriteLine("Conexão bem sucedida!");
                    return connection;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("conexao erro");
                    Console.WriteLine("Erro ao conectar ao banco de dados: " + ex.Message);
                    return connection;
                }
            }
        }


    }
}
