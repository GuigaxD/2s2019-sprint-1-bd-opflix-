using System;
using System.Collections.Generic;

namespace Senai.Opflix.WebApi.Domains
{
    public partial class Conteudo
    {
        public Conteudo()
        {
            Favoritos = new HashSet<Favoritos>();
        }

        public int IdConteudo { get; set; }
        public string Titulo { get; set; }
        public string Sinopse { get; set; }
        public DateTime Dlanc { get; set; }
        public TimeSpan Duracao { get; set; }
        public int? IdCategoria { get; set; }
        public int? IdFs { get; set; }
        public int? IdPlataforma { get; set; }

        public Categorias IdCategoriaNavigation { get; set; }
        public Fs IdFsNavigation { get; set; }
        public Plataforma IdPlataformaNavigation { get; set; }
        public ICollection<Favoritos> Favoritos { get; set; }
    }
}
