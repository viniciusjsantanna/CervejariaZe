using CervejariaZe.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CervejariaZe.Domain.Contracts.Repositories
{
    public interface IUsuarioRepository
    {
        Usuario Autenticar(Usuario usuario);
    }
}
