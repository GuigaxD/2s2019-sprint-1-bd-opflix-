using Senai.Opflix.WebApi.Domains;
using Senai.Opflix.WebApi.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Opflix.WebApi.Interface
{
   public interface IUsuarioRepository
    {
        Usuarios BuscarPorEmaileCPF(LoginViewModel login);
    }
}
