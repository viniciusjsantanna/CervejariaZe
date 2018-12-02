using CervejariaZe.Application.Contracts.Services;
using CervejariaZe.Application.Entities.Produto;
using CervejariaZe.Domain.Contracts.Services;
using CervejariaZe.Domain.Entities;
using CervejariaZe.Domain.Services.Implementation;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace CervejariaZe.Application.Services.Implementation
{
    public class ProdutoAppService : IProdutoAppService
    {
        public readonly IProdutoService produtoService;
        public ProdutoAppService()
        {
            this.produtoService = new ProdutoService();
        }

        public string Cadastrar()
        {
            var produto = GerarArquivo();
            if (produto != null)
            {
                return this.produtoService.Cadastrar(produto);
            }
            return null;
        }

        public IList<ProdutoDTO> Filtrar(string filtro)
        {
            if(filtro == null)
            {
                return this.Listar();
            }
            var listaProdutoDTO = new List<ProdutoDTO>();
            var produto = this.produtoService.Filtrar(filtro);
            produto.ToList().ForEach(e =>
            {
                var produtoDTO = new ProdutoDTO()
                {
                    CaminhoImagem = e.CaminhoImagem,
                    Codigo = e.Codigo,
                    Marca = e.Marca,
                    Nome = e.Nome,
                    Tipo = e.Tipo
                };
                listaProdutoDTO.Add(produtoDTO);
            });

            return listaProdutoDTO;
        }

        public IList<ProdutoDTO> Listar()
        {
            var listaProdutoDTO = new List<ProdutoDTO>();
            var produto = this.produtoService.Listar();
            produto.ToList().ForEach(e =>
            {
                var produtoDTO = new ProdutoDTO()
                {
                    CaminhoImagem = e.CaminhoImagem,
                    Codigo = e.Codigo,
                    Marca = e.Marca,
                    Nome = e.Nome,
                    Tipo = e.Tipo
                };
                listaProdutoDTO.Add(produtoDTO);
            });

            return listaProdutoDTO;
        }

        // Metodo pra gerar arquivo no diretorio especificado e retorna o caminho para ser salvo na tabela produto
        private Produto GerarArquivo()
        {
            string path = string.Empty;
            Produto produto = new Produto();

            if (HttpContext.Current.Request.Form.Count > 0)
            {
                var formContent = HttpContext.Current.Request.Form["produto"];
                produto = JsonConvert.DeserializeObject<Produto>(formContent);

                foreach (string file in HttpContext.Current.Request.Files)
                {
                    var fileContent = HttpContext.Current.Request.Files[file];

                    if (fileContent != null && fileContent.ContentLength > 0)
                    {
                        var stream = fileContent.InputStream;

                        string nomeArquivo = fileContent.FileName;

                        path = Path.Combine("C:\\Users\\Vinicius Santana\\Desktop\\Cervejaria\\CervejariaZe-Angular\\CervejariaZe-Angular\\src\\assets\\img\\", nomeArquivo);

                        using (var fileStream = System.IO.File.Create(path))
                        {
                            stream.CopyTo(fileStream);
                            var otherPath = path.Substring(path.IndexOf("assets"));
                            produto.CaminhoImagem = otherPath;
                        }
                    }
                }
            }

            return produto;
        }
    }
}