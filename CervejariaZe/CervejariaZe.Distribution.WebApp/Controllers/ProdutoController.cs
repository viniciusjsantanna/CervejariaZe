using CervejariaZe.Application.Contracts.Services;
using CervejariaZe.Application.Entities.Produto;
using CervejariaZe.Application.Services.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace CervejariaZe.Distribution.WebApp.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")] //Habilitar acesso de outra origem
    [RoutePrefix("api")]
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
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Produto
        [AcceptVerbs("Post")]
        [Route("produto")]
        public void Cadastrar([FromBody] ProdutoDTO produto)
        {
            if(GerarArquivo() != "")
            {
                this.produtoService.Cadastrar(produto);
            }
        }   
        
        public string GerarArquivo()
        {
            return "Caminho";
        }
    }
}
