using System;
using System.Collections.Generic;

namespace Senai.Opflix.WebApi.Domains
{
    public partial class Categorias
    {
        public Categorias()
        {
            Conteudo = new HashSet<Conteudo>();
        }

        public int IdCategoria { get; set; }
        public string Nome { get; set; }

        public ICollection<Conteudo> Conteudo { get; set; }
    }
}
