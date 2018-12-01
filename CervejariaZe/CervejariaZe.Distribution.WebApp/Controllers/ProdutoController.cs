using CervejariaZe.Application.Contracts.Services;
using CervejariaZe.Application.Entities.Produto;
using CervejariaZe.Application.Services.Implementation;
using CervejariaZe.Application.Services.Implementation.Jwt;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;

namespace CervejariaZe.Distribution.WebApp.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")] //Habilitar acesso de outra origem
    [RoutePrefix("api")]
    [JwtAuthentication]
    public class ProdutoController : ApiController
    {
        public readonly IProdutoAppService produtoService;

        public ProdutoController()
        {
            this.produtoService = new ProdutoAppService();
        }
        // GET: api/Produto
        [AcceptVerbs("Get")]
        [Route("produto")]
        public IList<ProdutoDTO> Listar()
        {
            return this.produtoService.Listar();
        }

        // GET: api/Produto/5
        [AcceptVerbs("Get")]
        [Route("produto/filtro")]
        public IList<ProdutoDTO> Filtrar(string filtro)
        {
            return this.produtoService.Filtrar(filtro);
        }

        // POST: api/Produto
        [AcceptVerbs("Post")]
        [Route("produto")]
        public string Cadastrar()
        {
            return this.produtoService.Cadastrar();
        }

    }
}
