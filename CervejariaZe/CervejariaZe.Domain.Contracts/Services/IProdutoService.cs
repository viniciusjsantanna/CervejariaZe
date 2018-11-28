using CervejariaZe.Domain.Entities;
using System.Collections.Generic;

namespace CervejariaZe.Domain.Contracts.Services
{
    public interface IProdutoService
    {
        void Cadastrar(Produto produto);
        IList<Produto> Listar();
    }
}
