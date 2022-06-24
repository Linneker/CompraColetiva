﻿using System.Collections.Generic;

namespace acme.sistemas.compracoletiva.domain.Users
{
    public class TipoUsuario : BaseEntity
    {
        public string Nome { get; set; }

        public virtual ICollection<Usuario> Usuarios { get; set; } = new HashSet<Usuario>();

        protected TipoUsuario() { }

        public TipoUsuario(string nome) : base()
        {
            Nome = nome;
        }
    }
}
