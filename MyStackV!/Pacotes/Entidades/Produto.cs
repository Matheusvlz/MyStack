using System;

namespace MyStack.Pacotes.Entidades
{
    internal class Produto
    {
        private static int idproduto;
        private static int idprodutosaida;
        private static int idempresa;
        private static string nomeproduto;
        private static string nomeprodutosaida;
        private static int quantidade;
        private static int quantidadesaida;
        private static string tipo;
        private static double preco;
        private static double precosaida;
        private static int idmercadoria;
        private static string descricao;
        private static string fornecedor;

        public Produto()
        {
            idempresa = 0;
            idprodutosaida = 0;
            precosaida = 0;
            quantidadesaida = 0;
            nomeprodutosaida = null;
            idmercadoria = 0;
            idproduto = 0;
            nomeproduto = null;
            preco = 0;
            quantidade = 0;
            tipo = null;
            fornecedor = null;
            descricao = null;
        }

        public void SetDescricao(string descricao)
        {
            Produto.descricao = descricao;
        }

        public string GetDescricao()
        {
            return descricao;
        }

        public int GetQuantidade()
        {
            return quantidade;
        }

        public void SetNomeprodutosaida(string nomeprodutosaida)
        {
            Produto.nomeprodutosaida = nomeprodutosaida;
        }

        public string GetNomeprodutosaida()
        {
            return nomeprodutosaida;
        }

        public void SetIdproduto(int idproduto)
        {
            Produto.idproduto = idproduto;
        }

        public int GetIdproduto()
        {
            return idproduto;
        }

        public void SetQuantidadesaida(int quantidadesaida)
        {
            Produto.quantidadesaida = quantidadesaida;
        }

        public int GetQuantidadesaida()
        {
            return quantidadesaida;
        }

        public void SetIdprodutosaida(int idprodutosaida)
        {
            Produto.idprodutosaida = idprodutosaida;
        }

        public int GetIdprodutosaida()
        {
            return idprodutosaida;
        }

        public void SetIdmercadoria(int idmercadoria)
        {
            Produto.idmercadoria = idmercadoria;
        }

        public int GetIdmercadoria()
        {
            return idmercadoria;
        }

        public void SetQuantidade(int quantidade)
        {
            Produto.quantidade = quantidade;
        }

        public void SetNomeproduto(string nomeproduto)
        {
            Produto.nomeproduto = nomeproduto;
        }

        public string GetNomeproduto()
        {
            return nomeproduto;
        }

        public void SetTipo(string tipo)
        {
            Produto.tipo = tipo;
        }

        public string GetTipo()
        {
            return tipo;
        }

        public void SetPreco(double preco)
        {
            Produto.preco = preco;
        }

        public double GetPreco()
        {
            return preco;
        }

        public void SetPrecosaida(double precosaida)
        {
            Produto.precosaida = precosaida;
        }

        public double GetPrecosaida()
        {
            return precosaida;
        }

        public int GetIdempresaentrada()
        {
            return idempresa;
        }

        public void SetIdempresaentrada(int idempresa)
        {
            Produto.idempresa = idempresa;
        }

        public int GetIdempresasaida()
        {
            return idprodutosaida;
        }

        public void SetIdempresasaida(int idprodutosaida)
        {
            Produto.idprodutosaida = idprodutosaida;
        }

        public void SetFornecedor(string fornecedor)
        {
            Produto.fornecedor = fornecedor;
        }

        public string GetFornecedor()
        {
            return fornecedor;
        }
    }
}
