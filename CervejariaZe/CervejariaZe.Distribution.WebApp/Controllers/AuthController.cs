using CervejariaZe.Application.Contracts.Services;
using CervejariaZe.Application.Entities.User;
using CervejariaZe.Application.Services.Implementation;
using System.Web.Http;
using System.Web.Http.Cors;

namespace CervejariaZe.Distribution.WebApp.Controllers
{
    //[EnableCors(origins: "*", headers: "*", methods: "*")] //Habilitar acesso de outra origem
    [RoutePrefix("api")]
    //[DisableCors]
    public class AuthController : ApiController
    {
        public readonly IUsarioAppService usuarioService;
        public AuthController()
        {
            this.usuarioService = new UsarioAppService();
        }
        //POST: api/Auth
        [AcceptVerbs("Post")]
        [Route("auth")]
        public UsarioOutputDTO Autenticar([FromBody] UsarioInputDTO usuario)
        {
            return this.usuarioService.Autenticar(usuario);
        }
    }
}
