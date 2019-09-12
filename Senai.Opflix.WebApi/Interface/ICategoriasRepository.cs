using Senai.Opflix.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Opflix.WebApi.Interface
{
   public interface ICategoriasRepository
    {
         void Cadastrar(Categorias categorias);

         List<Categorias> Listar();

         Categorias BuscarPorId(int id);

         void Atualizar(Categorias categorias);

         void Deletar(int Id);
    }
}
