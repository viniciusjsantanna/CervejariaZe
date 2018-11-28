using CervejariaZe.Application.Contracts.Services;
using CervejariaZe.Application.Entities.User;
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

            return new UsarioOutputDTO
            {
                usuario = usuario.Login,
                Nome = usuario.Nome
            };

        }
    }
}