using CervejariaZe.Application.Contracts.Services;
using CervejariaZe.Application.Entities.User;
using CervejariaZe.Application.Services.Implementation.Jwt;
using CervejariaZe.Domain.Contracts.Services;
using CervejariaZe.Domain.Entities;
using CervejariaZe.Domain.Services.Implementation;

namespace CervejariaZe.Application.Services.Implementation
{
    public class UsarioAppService : IUsarioAppService
    {
        public IUsarioService usuarioService;

        public UsarioAppService()
        {
            this.usuarioService = new UsuarioService();
        }

        public UsarioOutputDTO Autenticar(UsarioInputDTO usuarioDTO)
        {
            var usuario = this.usuarioService.Autenticar(new Usuario()
            {
                Login = usuarioDTO.Usuario,
                Senha = usuarioDTO.Senha
            });

            if (usuario != null)
            {
                //var token = JwtManager.GenerateToken(usuario.Login);
                return new UsarioOutputDTO()
                {
                    Usuario = usuario.Login,
                    Nome = usuario.Nome,
                    //Token = token
                };
            }
            return null;
        }
    }
}