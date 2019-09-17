
using Senai.Opflix.WebApi.Domains;
using Senai.Opflix.WebApi.Interface;
using Senai.Opflix.WebApi.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Opflix.WebApi.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public Usuarios BuscarPorEmaileCPF(LoginViewModel login)
        {
            using (opflixContext ctx = new opflixContext())
            {
                Usuarios usuario = ctx.Usuarios.FirstOrDefault(x => x.Email == login.Email && x.Nome == login.Nome);
                if (usuario == null)
                    return null;
                return usuario;
            }
        }
    }
}