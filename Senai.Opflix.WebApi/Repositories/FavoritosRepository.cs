using Senai.Opflix.WebApi.Domains;
using Senai.Opflix.WebApi.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Opflix.WebApi.Repositories
{
    public class FavoritosRepository : IFavoritosRepository
    {

        public void Cadastrar(Favoritos favoritos)
        {
            using (opflixContext ctx = new opflixContext())
            {
                ctx.Favoritos.Add(favoritos);
                ctx.SaveChanges();
            }
        }

     public List<Favoritos> Listar()
     {
            using (opflixContext ctx = new opflixContext())
            {
                return ctx.Favoritos.ToList();
            }

        }
    }
}
