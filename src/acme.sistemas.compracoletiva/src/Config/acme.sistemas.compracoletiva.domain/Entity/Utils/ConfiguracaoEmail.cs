using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acme.sistemas.compracoletiva.domain.Entity.Utils
{
    public class ConfiguracaoEmail: BaseEntity
    {
        public string ConfigSet { get; set; }
        public string Host { get; set; }
        public int Porta { get; set; }
        public bool Ssl { get; set; }
        public virtual ICollection<EmailConfiguracaoEmail> EmailConfiguracaoEmail { get; private set; }
    }
}
