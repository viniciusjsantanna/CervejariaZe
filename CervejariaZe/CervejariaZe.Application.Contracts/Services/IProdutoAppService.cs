using CervejariaZe.Application.Entities.Produto;
using System.Collections.Generic;

namespace CervejariaZe.Application.Contracts.Services
{
    public interface IProdutoAppService
    {
        void Cadastrar(ProdutoDTO produto);
        IList<ProdutoDTO> Listar();
    }
}
