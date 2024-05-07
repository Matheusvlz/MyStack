using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStack.Pacotes.Entidades
{
    
            internal class Fornecedor
            {

            private int idfornecedor;
            private int idempresa;
            private string nomefornecedor;
            private string endereco;
            private string telefone;
            private string celular;
            private string cep;
            private string email;
            private string data;

            public Fornecedor()
            {
                this.idfornecedor = 0;
                this.idempresa = 0;
                this.nomefornecedor = null;
                this.endereco = null;
                this.telefone = null;
                this.celular = null;
                this.cep = null;
                this.email = null;
                this.data = null;
            }
            public void setIdfornecedor(int id)
            {
                this.idfornecedor = id;
            }
            public int getIdfornecedor()
            {
                return idfornecedor;
            }
            public void setIdempresa(int idempresa)
            {
                this.idempresa = idempresa;
            }
            public int getIdempresa()
            {
                return idempresa;
            }
            public void setNomefornecedor(string nomefornecedor)
            {
                this.nomefornecedor = nomefornecedor;
            }
            public string getNomefornecedor()
            {
                return nomefornecedor;
            }
            public void setEnderecofornecedor(string endereco)
            {
                this.endereco = endereco;
            }
            public string getEnderecofornecedor()
            {
                return endereco;
            }
            public void setTelefone(string telefone)
            {
                this.telefone = telefone;
            }
            public string getTelefone()
            {
                return telefone;
            }
            public void setCelular(string celular)
            {
                this.celular = celular;
            }
            public string getCelular()
            {
                return celular;
            }
            public void setCep(string cep)
            {
                this.cep = cep;
            }
            public string getCep()
            {
                return cep;
            }
            public void setEmail(string email)
            {
                this.email = email;
            }
            public string getEmail()
            {
                return email;
            }
            public void setData(string data)
            {
                this.data = data;
            }
            public string getData()
            {
                return data;
            }
        
    }
}
