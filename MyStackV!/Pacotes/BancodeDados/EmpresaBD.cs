using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using MyStack.Pacotes.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MyStackV_.Pacotes.BancodeDados
{
    internal class EmpresaBD
    {
        ConexãoBD conex;
        Empresa empresa;
        Usuario usuario;
        public EmpresaBD() 
        {
            usuario = new Usuario();
            conex = new ConexãoBD();
            empresa = new Empresa();
        }
        public bool IncluirEmpresa()
        {
            bool status = true;
            try
            {
                using (MySqlConnection conectar = conex.ObterConexao())
                {
                   
                 
                    string query = "INSERT INTO empresa (NomeEmpresa, Email, Senha) VALUES (@NomeEmpresa, @Email, @Senha)";
                    MySqlCommand command = new MySqlCommand(query, conectar);
                    command.Parameters.AddWithValue("@NomeEmpresa", empresa.getNomeEmpresa());
                    command.Parameters.AddWithValue("@Email", empresa.getEmail());
                    command.Parameters.AddWithValue("@Senha", empresa.getSenhaempresa());

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
        public int ColocarIdEmpresa(string email)
        {
            try
            {
                using (MySqlConnection conectar = conex.ObterConexao())
                {
                    string query = "SELECT IdEmpresa FROM empresa WHERE Email = @Email";
                    MySqlCommand command = new MySqlCommand(query, conectar);
                    command.Parameters.AddWithValue("@Email", email);

                    conectar.Open();
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        int idempresa = Convert.ToInt32(result);
                        return idempresa;
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível encontrar uma empresa com o email fornecido.");
                        return 0;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro: " + e.Message);
                return 0;
            }
        }


        public void ExcluirEmpresa()
        {

        }
        public void EditarEmpresa()
        {

        }
    }
}
