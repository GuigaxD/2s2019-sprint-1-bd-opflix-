﻿using System;
using System.Collections.Generic;

namespace Senai.Opflix.WebApi.Domains
{
    public partial class Usuarios
    {
        public Usuarios()
        {
            Favoritos = new HashSet<Favoritos>();
        }

        public int IdUsuario { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Permissao { get; set; }
        public long Cpf { get; set; }

        public ICollection<Favoritos> Favoritos { get; set; }
    }
}
