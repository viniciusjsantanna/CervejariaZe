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
        public void Cadastrar(Produto produto)
        {
            this.produtoRepository.Cadastrar(produto);
        }

        public IList<Produto> Listar()
        {
            throw new System.NotImplementedException();
        }
    }
}