using System.Collections.Generic;
using CervejariaZe.Domain.Contracts.Repositories;
using CervejariaZe.Domain.Contracts.Services;
using CervejariaZe.Domain.Entities;
using CervejariaZe.Infra.Repositories.Repository;

namespace CervejariaZe.Domain.Services.Implementation
{
    public class ProdutoService : IProdutoService
    {
        public readonly IProdutoRepository produtoRepository;
        public ProdutoService()
        {
            this.produtoRepository = new ProdutoRepository();
        }
        public string Cadastrar(Produto produto)
        {
            return this.produtoRepository.Cadastrar(produto);
        }

        public IList<Produto> Filtrar(string filtro)
        {
            return this.produtoRepository.Filtrar(filtro);
        }

        public IList<Produto> Listar()
        {
            return this.produtoRepository.Listar();
        }
    }
}