using CervejariaZe.Domain.Contracts.Repositories;
using CervejariaZe.Domain.Contracts.Services;
using CervejariaZe.Domain.Entities;
using CervejariaZe.Infra.Repositories.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CervejariaZe.Domain.Services.Implementation
{
    public class UsuarioService : IUsarioService
    {
        public IUsuarioRepository usuarioRepository;
        public UsuarioService()
        {
            this.usuarioRepository = new UsuarioRepository();
        }
        public Usuario Autenticar(Usuario usuario)
        {
            if (ValidarUsuario(usuario))
            {

            }
            return null;
        }

        private bool ValidarUsuario(Usuario usuario)
        {
            if (usuario.Login != "" && usuario.Senha != "")
            {
                return true;
            }
            return false;
        }
    }
}