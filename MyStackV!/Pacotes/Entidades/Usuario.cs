using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStack.Pacotes.Entidades
{
    internal class Usuario
    {
        private static string nome { get; set;}
        private static string senha { get; set;}
        private static int nivel { get; set;}
        private static int idusuario { get; set;}
        private static int idempresa { get; set;}
        private static string logar {  get; set;}

        public Usuario()
        {
            idempresa = 0;
            nome = "";
            senha = "";
            nivel = 0;
            idusuario = 0;
            logar = "";
        }
        public  Usuario(string Nome, string Senha, string Logar)
        {
            nome = Nome;
            senha = Senha;
            logar = Logar;

        }
        public void setSenha(string Senha)
        {
          senha = Senha;
        }
        public string getSenha()
        {
            return senha;
        }
        public void setNomeusuario(string Nome)
        {
            nome = Nome;
        }
        public string getNomeusuario()
        {
            return nome;
        }
        public void setNivel(int Nivel)
        {
         nivel = Nivel;
        }
        public int getNivel()
        {

            return nivel;

        }
        public void setIdempresa(int Idempresa)
        {
          idempresa = Idempresa;
        }
        public int getIdempresa()
        {
            return idempresa;
        }
        public void setIdusuario(int Idusuario)
        {
         idusuario = Idusuario;
        }
        public int getIdusuario()
        {
            return idusuario;
        }
        public void setLogar(string Logar)
        {
        logar = Logar;
        }
        public string getLogar()
        {
            return logar;
        }


    }
}
