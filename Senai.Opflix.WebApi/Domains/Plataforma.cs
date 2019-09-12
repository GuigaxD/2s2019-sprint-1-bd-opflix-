using System;
using System.Collections.Generic;

namespace Senai.Opflix.WebApi.Domains
{
    public partial class Plataforma
    {
        public Plataforma()
        {
            Conteudo = new HashSet<Conteudo>();
        }

        public int IdPlataforma { get; set; }
        public string Nome { get; set; }

        public ICollection<Conteudo> Conteudo { get; set; }
    }
}
