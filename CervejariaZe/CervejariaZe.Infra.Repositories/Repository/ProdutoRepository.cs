using CervejariaZe.Domain.Contracts.Repositories;
using CervejariaZe.Domain.Entities;
using System;
using System.Collections.Generic;

namespace CervejariaZe.Infra.Repositories.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {
        public void Cadastrar(Produto produto)
        {
            throw new NotImplementedException();
        }

        public IList<Produto> Listar()
        {
            throw new NotImplementedException();
        }
    }
}