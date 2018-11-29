using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CervejariaZe.Domain.Entities
{
    public class Usuario : BaseEntity<int>
    {
        [Column("Usuario")]
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
    }
}