using Microsoft.AspNetCore.Identity;

namespace acme.sistemas.compracoletiva.domain.Security
{
    public class UserToken : IdentityUserToken<Guid>
    {
        public Guid Id { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataModificacao { get; set; }
        public bool Ativo { get; set; }
        public Guid? UsuarioCriacaoId { get; set; }
        public Guid? UsuarioModificacaoId { get; set; }
    }
}
