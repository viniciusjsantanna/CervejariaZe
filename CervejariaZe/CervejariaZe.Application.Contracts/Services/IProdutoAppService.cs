using CervejariaZe.Application.Entities.Produto;
using System.Collections.Generic;

namespace CervejariaZe.Application.Contracts.Services
{
    public interface IProdutoAppService
    {
        string Cadastrar();
        IList<ProdutoDTO> Listar();
        IList<ProdutoDTO> Filtrar(string filtro);
    }
}
