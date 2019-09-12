using System;
using System.Collections.Generic;

namespace Senai.Opflix.WebApi.Domains
{
    public partial class Fs
    {
        public Fs()
        {
            Conteudo = new HashSet<Conteudo>();
        }

        public int IdFs { get; set; }
        public string Qual { get; set; }

        public ICollection<Conteudo> Conteudo { get; set; }
    }
}
