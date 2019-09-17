
using Senai.Opflix.WebApi.Domains;
using Senai.Opflix.WebApi.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.OpFlix.WebApi.Repositories
{
    public class CategoriaRepository : ICategoriasRepository
    {
        public void Cadastrar(Categorias categorias)
        {
            using (opflixContext ctx = new opflixContext())
            {
                ctx.Categorias.Add(categorias);
                ctx.SaveChanges();
            }
        }

        public List<Categorias> Listar()
        {
            using (opflixContext ctx = new opflixContext())
            {
                return ctx.Categorias.ToList();
            }
        }


        public Categorias BuscarPorId(int id)
        {
            using (opflixContext ctx = new opflixContext())
            {
                return ctx.Categorias.FirstOrDefault(x => x.IdCategoria == id);
            }
        }

        public void Atualizar(Categorias categorias)
        {
            using (opflixContext ctx = new opflixContext())
            {
                Categorias CategoriaBuscada = ctx.Categorias.FirstOrDefault(x => x.IdCategoria == categorias.IdCategoria);
                CategoriaBuscada.Nome = categorias.Nome;
                ctx.Categorias.Update(CategoriaBuscada);
                ctx.SaveChanges();
            }
        
        }
        public void Deletar(int Id)
        {
            using (opflixContext ctx = new opflixContext())
            {
                //buscar
                Categorias categorias = ctx.Categorias.Find(Id);
                //deletar
                ctx.Remove(categorias);
                //salva
                ctx.SaveChanges();
            }
        }
    }
}
