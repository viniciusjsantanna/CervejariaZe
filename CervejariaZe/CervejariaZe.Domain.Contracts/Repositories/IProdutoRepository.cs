using CervejariaZe.Domain.Entities;
using System.Collections.Generic;

namespace CervejariaZe.Domain.Contracts.Repositories
{
    public interface IProdutoRepository
    {
        void Cadastrar(Produto produto);
        IList<Produto> Listar();
    }
}
