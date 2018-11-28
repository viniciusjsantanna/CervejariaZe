using CervejariaZe.Application.Contracts.Services;
using CervejariaZe.Application.Entities.User;
using CervejariaZe.Application.Services.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CervejariaZe.Distribution.WebApp.Controllers
{
    public class AuthController : ApiController
    {
        public IUsarioAppService usuarioService;
        public AuthController()
        {
            this.usuarioService = new UsarioAppService();
        }
        //POST: api/Auth
        public UsarioOutputDTO Autenticar(UsarioInputDTO usuario)
        {
            return this.usuarioService.Autenticar(usuario);
        }
    }
}
