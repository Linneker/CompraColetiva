using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acme.sistemas.compracoletiva.domain.Entity.Utils
{
    public class EmailConfiguracaoEmail : BaseEntity
    {
        public string Senha { get; private set; }
        public Guid EmailEnvioId { get; private set; }
        public Guid EmailEnviadorId { get; private set; }
        public Guid ConfiguracaoEmailId { get; private set; }
        public Email EmailEnvio { get; private set; }
        public Email EmailEnviador { get; private set; }
        public ConfiguracaoEmail ConfiguracaoEmail { get; private set; }
    }
}
