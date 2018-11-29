using CervejariaZe.Application.Contracts.Services;
using CervejariaZe.Application.Entities.Produto;
using CervejariaZe.Domain.Contracts.Services;
using CervejariaZe.Domain.Entities;
using CervejariaZe.Domain.Services.Implementation;
using System;
using System.Collections.Generic;

namespace CervejariaZe.Application.Services.Implementation
{
    public class ProdutoAppService : IProdutoAppService
    {
        public readonly IProdutoService produtoService;
        public ProdutoAppService()
        {
            this.produtoService = new ProdutoService();
        }
        public void Cadastrar(ProdutoDTO produto)
        {
            this.produtoService.Cadastrar(new Produto
            {
                Marca = produto.Marca,
                Nome = produto.Nome,
                CaminhoImagem = produto.CaminhoImagem,
                Codigo = produto.Codigo,
                Tipo = produto.Tipo
            });
        }

        public IList<ProdutoDTO> Listar()
        {
            throw new NotImplementedException();
        }
    }
}