using Senai.Opflix.WebApi.Domains;
using Senai.Opflix.WebApi.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Opflix.WebApi.Repositories
{
    public class ConteudoRepository : ILancamentosRepository
    {
        public void Atualizar(Conteudo conteudo)
        {
            using (OpflixContext ctx = new OpflixContext())
            {
                //achar
                Conteudo conteudobuscado = ctx.Conteudo.FirstOrDefault(x => x.IdConteudo == conteudo.IdConteudo);
                //modificar
                conteudobuscado.Sinopse = conteudo.Sinopse;
                conteudobuscado.Titulo = conteudo.Titulo;
                conteudobuscado.Dlanc = conteudo.Dlanc;
                conteudobuscado.Duracao = conteudo.Duracao;
                conteudobuscado.IdCategoria = conteudo.IdCategoria;
                conteudobuscado.IdFs = conteudo.IdFs;
                conteudobuscado.IdPlataforma = conteudo.IdPlataforma;
                //enviar
                ctx.Update();
                //salvar
                ctx.SaveChanges();
            }
        }

        public Conteudo BuscarPorId(int id)
        {
            using (OpflixContext ctx = new OpflixContext())
            {
                return ctx.Conteudo.FirstOrDefault(x => x.IdCategoria == id);
            }
        }

        public void Cadastrar(Conteudo conteudo)
        {
            using (OpflixContext ctx = new OpflixContext())
            {
                ctx.Conteudo.Add(conteudo);
                ctx.SaveChanges();
            }
        }

        public List<Conteudo> Listar()
        {
            using (OpflixContext ctx = new OpflixContext())
            {
               return ctx.Conteudo.ToList();
            }
        }
        public void Deletar(int Id)
        {
            using (OpflixContext ctx = new OpflixContext())
            {
                //buscar
                Conteudo conteudobuscado = ctx.Conteudo.Find(Id);
                //deletar
                ctx.Conteudo.Remove(conteudobuscado);
                //salvar
                ctx.SaveChanges();
            }
        }
    }
}
