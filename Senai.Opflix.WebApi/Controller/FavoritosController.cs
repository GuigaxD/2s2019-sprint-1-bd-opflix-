using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
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
    public class FavoritosController : ControllerBase
    {
        private IFavoritosRepository favoritosRepository { get; set; }

        public FavoritosController()
        {
            favoritosRepository = new FavoritosRepository();
        }
        [Authorize]
        [HttpGet]
        public IActionResult Listar()
        {  
            return Ok(favoritosRepository.Listar());
        }
        [Authorize]
        [HttpGet]
        public IActionResult Cadastrar(Favoritos favoritos)
        {
            favoritosRepository.Cadastrar(favoritos);
            return Ok();
        }
    }
}

    

