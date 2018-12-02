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

        public string Cadastrar(Produto produto)
        {
            if (!exist(produto))
            {
                this.context.Produto.Add(produto);
                this.context.SaveChanges();
                return Mensagens.MensagemCadastroSucesso;
            }
            return Mensagens.RegistroExistente;
        }

        private bool exist(Produto produto)
        {
            return this.context.Produto.Any(e => e.Codigo.Equals(produto.Codigo));
        }

        public IList<Produto> Listar()
        {
            return this.context.Produto.ToList();
        }

        public IList<Produto> Filtrar(string filtro)
        {
            return this.context.Produto.Where(e => e.Nome.Contains(filtro) || e.Marca.Contains(filtro)).ToList();
        }
    }
}