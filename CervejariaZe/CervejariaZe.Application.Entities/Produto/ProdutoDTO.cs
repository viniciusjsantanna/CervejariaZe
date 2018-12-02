using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CervejariaZe.Application.Entities.Produto
{
    public class ProdutoDTO
    {
        public string Marca { get; set; }
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public string Codigo { get; set; }
        public string CaminhoImagem { get; set; }
    }
}