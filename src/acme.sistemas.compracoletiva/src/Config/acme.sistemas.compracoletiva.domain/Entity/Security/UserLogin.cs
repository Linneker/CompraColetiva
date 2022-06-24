using Microsoft.AspNetCore.Identity;

namespace acme.sistemas.compracoletiva.domain.Entity.Security
{
    public class UserLogin : IdentityUserLogin<Guid>
    {
        public Guid Id { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataModificacao { get; set; }
        public bool Ativo { get; set; }
        public Guid? UsuarioCriacaoId { get; set; }
        public Guid? UsuarioModificacaoId { get; set; }
    }
}
