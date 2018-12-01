using CervejariaZe.Domain.Entities;
using System.Collections.Generic;

namespace CervejariaZe.Domain.Contracts.Services
{
    public interface IProdutoService
    {
        string Cadastrar(Produto produto);
        IList<Produto> Listar();
        IList<Produto> Filtrar(string filtro);
    }
}
