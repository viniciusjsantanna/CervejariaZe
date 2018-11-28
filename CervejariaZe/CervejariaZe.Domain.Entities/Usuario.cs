using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CervejariaZe.Domain.Entities
{
    public class Usuario : BaseEntity<int>
    {
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
    }
}