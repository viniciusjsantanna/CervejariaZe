using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CervejariaZe.Domain.Entities
{
    public class Produto : BaseEntity<int>
    {
        public string Marca { get; set; }
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public string Codigo { get; set; }
        public string CaminhoImagem { get; set; }
    }
}