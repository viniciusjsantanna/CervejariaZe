using CervejariaZe.Domain.Entities;
using System.Collections.Generic;

namespace CervejariaZe.Domain.Contracts.Repositories
{
    public interface IProdutoRepository
    {
        string Cadastrar(Produto produto);
        IList<Produto> Listar();
        IList<Produto> Filtrar(string filtro);
    }
}
