using CervejariaZe.Application.Entities.User;

namespace CervejariaZe.Application.Contracts.Services
{
    public interface IUsarioAppService
    {
        UsarioOutputDTO Autenticar(UsarioInputDTO usuarioDTO); 
    }
}
