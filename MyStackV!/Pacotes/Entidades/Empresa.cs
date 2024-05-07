using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStack.Pacotes.Entidades
{
    internal class Empresa
    {
        public static string  NomeEmpresa { get; set; }
        public static string Email { get; set; }
        public static string Senha { get; set; }

        public static int Idempresa { get; set; }  

  
        public Empresa()
        {
            Idempresa = 0;
            NomeEmpresa = "";
            Email = "";
            Senha = "";
        }

        
        public Empresa(string nomeEmpresa, string email, string senha)
        {
            NomeEmpresa = nomeEmpresa;
            Email = email;
            Senha = senha;
        }

   
        public string getNomeEmpresa()
        {
            return NomeEmpresa;
        }

        public void setNomeEmpresa(string nomeEmpresa)
        {
            NomeEmpresa = nomeEmpresa;
        }

       
        public string getEmail()
        {
            return Email;
        }

        public void setEmail(string email)
        {
            Email = email;
        }

  
        public string getSenhaempresa()
        {
            return Senha;
        }

        public void setSenhaempresa(string senha)
        {
            Senha = senha;
        }
        public int getIdempresa()
        {
            return Idempresa;
        }
        public void setIdempresa(int idempresa)
        {
            Idempresa = idempresa;
        }
    }
}
