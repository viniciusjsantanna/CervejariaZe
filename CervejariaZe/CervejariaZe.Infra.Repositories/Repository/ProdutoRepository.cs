using CervejariaZe.Domain.Contracts.Repositories;
using CervejariaZe.Domain.Entities;
using CervejariaZe.Infra.Repositories.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace CervejariaZe.Infra.Repositories.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {
        public readonly CervejariaContext context;
        public ProdutoRepository()
        {
            this.context = new CervejariaContext();
        }

        public void Cadastrar(Produto produto)
        {
            this.context.Produto.Add(produto);
            this.context.SaveChanges();
        }

        public IList<Produto> Listar()
        {
            return this.context.Produto.ToList();
        }
    }
}