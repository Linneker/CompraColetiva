using acme.sistemas.compracoletiva.domain.Interfaces.Aggregate;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acme.sistemas.compracoletiva.domain.Entity.Users
{
    public class Usuario : IdentityUser<Guid>, IAggregateRoot
    {
        public DateTime DataCriacao { get; set; }
        public DateTime DataModificacao { get; set; }
        public bool Ativo { get; set; }
        public Guid? UsuarioCriacaoId { get; set; }
        public Guid? UsuarioModificacaoId { get; set; }

        public Guid PessoaId { get; set; }
        public Guid TipoUsuarioId { get; set; }

        public Pessoa Pessoa { get; set; }
        public TipoUsuario TipoUsuario { get; set; }


        protected Usuario() { }

        public Usuario(Pessoa pessoa) : base()
        {
            Pessoa = pessoa;
        }

        public Usuario(Pessoa pessoa, TipoUsuario tipoUsuario) : this(pessoa)
        {
            TipoUsuario = tipoUsuario;
        }

        public Usuario(Pessoa pessoa, Guid tipoUsuarioId) : this(pessoa)
        {
            TipoUsuarioId = tipoUsuarioId;
        }

    }
}
