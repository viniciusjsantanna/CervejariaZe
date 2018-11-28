using CervejariaZe.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CervejariaZe.Domain.Contracts.Services
{
    public interface IUsarioService
    {
        Usuario Autenticar(Usuario usario);
    }
}
