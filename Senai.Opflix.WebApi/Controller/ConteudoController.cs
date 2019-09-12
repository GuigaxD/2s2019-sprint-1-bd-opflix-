using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Opflix.WebApi.Domains;
using Senai.Opflix.WebApi.Interface;
using Senai.Opflix.WebApi.Repositories;

namespace Senai.Opflix.WebApi.Controller
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class ConteudoController : ControllerBase
    {
        private ILancamentosRepository conteudoRepository { get; set; }

        public ConteudoController()
        {
            conteudoRepository = new ConteudoRepository();

        }
        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(conteudoRepository.Listar());
        }
        [HttpGet("{Id}")]
        public IActionResult BuscarPorId(int Id)
        {
            return Ok(conteudoRepository.BuscarPorId(Id));
        }
        [HttpPost]
        public void Cadastrar(Conteudo conteudo)
        {
            using (OpflixContext ctx = new OpflixContext())
            {
                ctx.Conteudo.Add(conteudo);
                ctx.SaveChanges();

            }
        }
        [HttpPut]
        public IActionResult Atualizar(Conteudo conteudo)
        {
            try
            {
               Conteudo conteudobuscado = conteudoRepository.BuscarPorId(conteudo.IdConteudo);
                if (conteudo == null)
                    return NotFound();
                conteudoRepository.Atualizar(conteudo);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(new { mensagem = "Errooouuu, ~Silva, Fausto" + ex.Message });
            }
        }
    }   
}