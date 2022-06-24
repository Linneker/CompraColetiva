namespace acme.sistemas.compracoletiva.domain.Security
{
    public class ConfiguracaoToken : BaseEntity
    {
        public string AccessKey { get; set; }
        public int? Expiracao { get; set; }
        public virtual ICollection<ConfiguracaoTokenSistema> AutenticacoesSistemas { get; set; }
    }
}
