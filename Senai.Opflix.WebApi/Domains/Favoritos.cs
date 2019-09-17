using System;
using System.Collections.Generic;

namespace Senai.Opflix.WebApi.Domains
{
    public partial class Favoritos
    {
        public int IdPadrao { get; set; }
        public int? IdConteudo { get; set; }
        public int? IdUsuario { get; set; }

        public Conteudo IdConteudoNavigation { get; set; }
        public Usuarios IdUsuarioNavigation { get; set; }
    }
}
