using acme.sistemas.compracoletiva.core.Base;

namespace acme.sistemas.compracoletiva.domain.Entity.Security
{
    public class ConfiguracaoToken : BaseEntity
    {
        public ConfiguracaoToken(string accessKey, int? expiracao)
        {
            AccessKey = accessKey;
            Expiracao = expiracao;
        }

        public string AccessKey { get; private set; }
        public int? Expiracao { get; private set; }
        public virtual ICollection<ConfiguracaoTokenSistema> AutenticacoesSistemas { get; private set; }
    }
}
