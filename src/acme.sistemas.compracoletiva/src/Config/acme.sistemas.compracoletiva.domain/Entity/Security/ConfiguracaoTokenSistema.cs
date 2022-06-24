namespace acme.sistemas.compracoletiva.domain.Entity.Security
{
    public class ConfiguracaoTokenSistema : BaseEntity
    {
        public string SistemaEmissao { get; set; }
        public string ValidoEm { get; set; }

        public Guid AutenticacaoId { get; set; }
        public ConfiguracaoToken Autorizacao { get; set; }
    }
}
