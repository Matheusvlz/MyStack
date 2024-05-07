using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStack.Pacotes.Entidades
{
    internal class Produto
    {
        private int idproduto;
        private int idprodutosaida;
        private int idempresa;
        private string nomeproduto;
        private string nomeprodutosaida;
        private string dataentrada;
        private string horaentrada;
        private string datasaida;
        private string horasaida;
        private int unidade;
        private int quantidade;
        private int quantidadesaida;
        private string tipo;
        private double preco;
        private double precosaida;
        private int idmercadoria;
        private string fornecedor;

        public Produto()
        {
            this.idempresa = 0;
            this.idprodutosaida = 0;
            this.precosaida = 0;
            this.quantidadesaida = 0;
            this.nomeprodutosaida = null;
            this.dataentrada = null;
            this.datasaida = null;
            this.idmercadoria = 0;
            this.idproduto = 0;
            this.nomeproduto = null;
            this.preco = 0;
            this.quantidade = 0;
            this.unidade = 0;
            this.tipo = null;
            this.horaentrada = null;
            this.horasaida = null;
            this.fornecedor = null;
            

        }

        public int getQuantidade()
        {
            return quantidade;
        }
        public void setUnidade(int unidade)
        {
            this.unidade = unidade;
        }
        public void setDataentrada(string dataentrada)
        {
            this.dataentrada = dataentrada;
        }
        public string getDataentrada()
        {
            return dataentrada;
        }
        public void setNomeprodutosaida(string nomeprodutosaida)
        {
            this.nomeprodutosaida = nomeprodutosaida;
        }
        public string getNomeprodutosaida()
        {
            return nomeprodutosaida;
        }
        public void setDatasaida(string datasaida)
        {
            this.datasaida = datasaida;
        }
        public string getDatasaida()
        {
            return datasaida;
        }
        public void setIdproduto(int idproduto)
        {
            this.idproduto = idproduto;
        }
        public int getIdproduto()
        {
            return idproduto;
        }

        public void setQuantidadesaida(int quantidadesaida)
        {
            this.quantidadesaida = quantidadesaida;
        }
        public int getQuantidadesaida()
        {
            return quantidadesaida;
        }
        public void setIdprodutosaida(int idprodutosaida)
        {
            this.idprodutosaida = idprodutosaida;
        }
        public int getIdprodutosaida()
        {
            return idprodutosaida;
        }
        public void setidmercadoria(int idmercadoria)
        {
            this.idmercadoria = idmercadoria;
        }
        public int getIdmercadoria()
        {
            return idmercadoria;
        }
        public void setQuantidade(int quantidade)
        {
            this.quantidade = quantidade;
        }
        public int getUnidade()
        {
            return unidade;
        }
        public void setHorasaida(string horasaida)
        {
            this.horasaida = horasaida;
        }
        public string getHorasaida()
        {
            return horasaida;
        }
        public void setNomeproduto(string nomeproduto)
        {
            this.nomeproduto = nomeproduto;
        }
        public string getNomeproduto()
        {
            return nomeproduto;
        }
        public void setTipo(string tipo)
        {
            this.tipo = tipo;
        }
        public string getTipo()
        {
            return tipo;
        }
        public void setPreco(double preco)
        {
            this.preco = preco;
        }
        public double getPreco()
        {
            return preco;
        }
        public void setHoraentrada(string horaentrada)
        {
            this.horaentrada = horaentrada;
        }
        public string getHoraentrada()
        {
            return horaentrada;
        }
        public void setPrecosaida(double precosaida)
        {
            this.precosaida = precosaida;
        }
        public double getPrecosaida()
        {
            return precosaida;
        }
        public int getIdempresaentrada()
        {
            return idempresa;
        }
        public void setIdempresaentrada(int idempresa)
        {
            this.idempresa = idempresa;
        }
        public int getIdempresasaida()
        {
            return idprodutosaida;
        }
        public void setIdempresasaida(int idprodutosaida)
        {
            this.idprodutosaida = idprodutosaida;
        }
        public void setFornecedor(string fornecedor)
        {
            this.fornecedor = fornecedor;
        }
        public string getFornecedor()
        {
            return fornecedor;
        }
    }
}
