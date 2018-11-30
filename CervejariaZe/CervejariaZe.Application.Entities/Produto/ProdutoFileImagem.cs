using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CervejariaZe.Application.Entities.Produto
{
    public class ProdutoFileImagem
    {
        public string name { get; set; }
        public byte[] stream { get; set; }
        public int tamanho { get; set; }
    }
}