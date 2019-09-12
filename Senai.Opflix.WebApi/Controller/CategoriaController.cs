using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Opflix.WebApi.Domains;
using Senai.Opflix.WebApi.Interface;
using Senai.OpFlix.WebApi.Repositories;

namespace Senai.OpFlix.WebApi.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class CategoriasController : ControllerBase
    {
        private ICategoriasRepository  CategoriaRepository { get; set; }

        public CategoriasController()
        {
            CategoriaRepository = new CategoriaRepository();
        }
        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(CategoriaRepository.Listar());
        }

        [HttpPost]
        public void Cadastrar(Categorias Categorias)
        {
            using (OpflixContext ctx = new OpflixContext())
            {
                ctx.Categorias.Add(Categorias);
                ctx.SaveChanges();
            }
        }

        [HttpGet("{id}")]
        public IActionResult BuscarPorId(int id)
        {
            Categorias Categorias = CategoriaRepository.BuscarPorId(id);
            if (Categorias == null)
                return NotFound();
            return Ok(Categorias);
        }

        [HttpPut]
        public IActionResult Atualizar(Categorias categorias)
        {
            try
            {
                Categorias CategoriaBuscada = CategoriaRepository.BuscarPorId(categorias.IdCategoria);
                if (CategoriaBuscada == null)
                    return NotFound();
                CategoriaRepository.Atualizar(categorias);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(new { mensagem = "Errooouuu, ~Silva, Fausto" + ex.Message });  
            }
        }
        [HttpDelete("{Id}")]
        public IActionResult Deletar(int Id)
        {
            CategoriaRepository.Deletar(Id);
            return Ok();
        }
    }   
}
