using Senai.Opflix.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Opflix.WebApi.Interface
{
    interface ILancamentosRepository
    {
        void Cadastrar(Conteudo conteudo);

        List<Conteudo> Listar();

        Conteudo BuscarPorId(int id);

        void Atualizar(Conteudo conteudo);

        void Deletar(int Id);
    }
}
