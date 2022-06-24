using Microsoft.AspNetCore.Identity;

namespace acme.sistemas.compracoletiva.domain.Entity.Security
{
    public class PermissaoUsuario : IdentityUserRole<Guid>
    {
        public Guid Id { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataModificacao { get; set; }
        public bool Ativo { get; set; }
        public Guid? UsuarioCriacaoId { get; set; }
        public Guid? UsuarioModificacaoId { get; set; }

        public bool Add { get; set; }
        public bool Update { get; set; }
        public bool Delete { get; set; }
        public bool Read { get; set; }
    }
}
