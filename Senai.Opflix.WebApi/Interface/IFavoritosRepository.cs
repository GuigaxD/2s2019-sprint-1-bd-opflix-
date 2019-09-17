using Senai.Opflix.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Opflix.WebApi.Interface
{
    interface IFavoritosRepository
    {
        List<Favoritos> Listar();

        void Cadastrar(Favoritos favoritos);
    };
}
