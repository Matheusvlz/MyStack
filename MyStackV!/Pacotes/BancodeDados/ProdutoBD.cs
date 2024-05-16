using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using MyStack.Pacotes.Telas;
using MyStack.Pacotes.Entidades;
namespace MyStackV_.Pacotes.BancodeDados
{
  
    internal class ProdutoBD
    {
        Produto produto;
        Login login;
        ConexãoBD conex;

        public ProdutoBD()
        {
            produto = new Produto();    
            conex = new ConexãoBD();
            login = new Login();
        }
        public bool ValidarProduto(string produto)
        {
            int idempresa = login.ColocarId();
            bool status = true;

            try
            {
                using (MySqlConnection conectar = conex.ObterConexao())
                {
                    conectar.Open();
                    string query = "SELECT COUNT(*) FROM categoria WHERE nomeProduto = @nomeProduto AND Idempresa = @Idempresa";
                    MySqlCommand command = new MySqlCommand(query, conectar);
                    command.Parameters.AddWithValue("@Nomeproduto", produto);
                    command.Parameters.AddWithValue("@Idempresa", idempresa);


                    int resultado = Convert.ToInt32(command.ExecuteScalar());
                    if (resultado > 0)
                    {
                        return status = false;
                    }
                    else
                    {
                        MessageBox.Show("Deu Certo");
                        return status;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro: " + e.Message);
                return status = false;
            }
        }
        public void CadastrarProduto()
        {
            int valor = login.ColocarId();  
            try
            {
                using (MySqlConnection conectar = conex.ObterConexao())
                {


                    string query = "INSERT INTO categoria (nomeProduto, Idempresa, Descricao) VALUES (@nomeProduto, @Idempresa, @Descricao)";
                    MySqlCommand command = new MySqlCommand(query, conectar);
                    command.Parameters.AddWithValue("@nomeProduto", produto.GetNomeproduto() );
                    command.Parameters.AddWithValue("@Idempresa", valor );
                    command.Parameters.AddWithValue("@Descricao", produto.GetDescricao());

                    conectar.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Cadastro Realizado");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro: " + e.Message);
             
            }
        }
    }
}
