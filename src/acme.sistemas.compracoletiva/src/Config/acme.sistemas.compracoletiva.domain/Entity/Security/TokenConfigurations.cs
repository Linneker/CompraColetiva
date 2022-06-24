using System.ComponentModel.DataAnnotations.Schema;

namespace acme.sistemas.compracoletiva.domain.Security
{
    [NotMapped]
    public class TokenConfigurations
    {
        public string Audience { get; set; }
        public string Issuer { get; set; }
        public int Seconds { get; set; }
    }
}
