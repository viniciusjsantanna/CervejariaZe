using CervejariaZe.Domain.Contracts.Repositories;
using CervejariaZe.Domain.Entities;
using System;
using CervejariaZe.Infra.Repositories.Context;
using System.Data.SqlClient;
using System.Linq;

namespace CervejariaZe.Infra.Repositories.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        SqlConnection connection = null;
        CervejariaContext context = null;
        public UsuarioRepository()
        {
            context = new CervejariaContext();
        }

        public Usuario Autenticar(Usuario usuario)
        {
            var user = context.Usuario.Where(e => e.Login.Equals(usuario.Login) && e.Senha.Equals(usuario.Senha)).FirstOrDefault();
            return user;
        }
    }
}