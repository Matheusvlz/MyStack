using MySql.Data.MySqlClient;
using MyStack.Pacotes.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MyStackV_.Pacotes.BancodeDados
{
    internal class UsuarioBD
    {
        ConexãoBD conex;
        Usuario usuario;
        public UsuarioBD()
        {
        conex = new ConexãoBD();
        usuario = new Usuario();
        }

        public bool IncluirUsuario()
        {
         
            bool status = true;
            try
            {
                using (MySqlConnection conectar = conex.ObterConexao())
                {

                    
                    string query = "INSERT INTO usuario (Nome, Senha, Idempresa, Nivel, Usuario) VALUES (@Nome, @Senha, @Idempresa, @Nivel, @Usuario)";
                    MySqlCommand command = new MySqlCommand(query, conectar);
                    command.Parameters.AddWithValue("@Nome", usuario.getNomeusuario() );
                    command.Parameters.AddWithValue("@Senha", usuario.getSenha());
                    command.Parameters.AddWithValue("@Idempresa", usuario.getIdempresa());
                    command.Parameters.AddWithValue("@Nivel", usuario.getNivel());
                    command.Parameters.AddWithValue("@Usuario", usuario.getLogar() );
                    conectar.Open();
                    command.ExecuteNonQuery();
                   
                    return status;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro: " + e.Message);
                return false;
            }

        }
        public bool ValidarAcesso(string user, string senha)
        {
            bool status = true;

            try
            {
                using (MySqlConnection conectar = conex.ObterConexao())
                {
                    conectar.Open();
                    string query = "SELECT COUNT(*) FROM usuario WHERE Usuario = @Usuario AND Senha = @Senha";
                    MySqlCommand command = new MySqlCommand(query, conectar);
                    command.Parameters.AddWithValue("@Usuario", user);
                    command.Parameters.AddWithValue("@Senha", senha);


                    int resultado = Convert.ToInt32(command.ExecuteScalar());
                    if (resultado > 0)
                    {
                        return status;
                    }
                    else
                    {
                        MessageBox.Show("Dados Nao Coinsidem.");
                        return status = false;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro: " + e.Message);
                return status = false;
            }
        }
        public int ColocarIdUsuario(string email)
        {
            try
            {
                using (MySqlConnection conectar = conex.ObterConexao())
                {
                    string query = "SELECT IdEmpresa FROM usuario WHERE Usuario = @Usuario";
                    MySqlCommand command = new MySqlCommand(query, conectar);
                    command.Parameters.AddWithValue("@Usuario", email);

                    conectar.Open();
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        int idempresa = Convert.ToInt32(result);
                        usuario.setIdempresa(idempresa);
                        return idempresa;
                    
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível encontrar uma empresa com o email fornecido.");
                        return 0;
                       
                    }
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("Erro: " + e.Message);
                return 0;
              
            }
        }
        public void ExcluirUsuario()
        {

        }
        public void EditarUsuario()
        {

        }
    }
}
