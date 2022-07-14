using acme.sistemas.compracoletiva.core.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acme.sistemas.compracoletiva.domain.Entity.Utils
{
    public class EmailConfiguracaoEmail : BaseEntity, IAggregateRoot
    {
        public EmailConfiguracaoEmail(string senha)
        {
            Senha = senha;
        }

        protected EmailConfiguracaoEmail()
        {
        }

        public string Senha { get; set; }
        public Guid EmailEnvioId { get; set; }
        public Guid EmailRemetenteId { get; set; }
        public Guid ConfiguracaoEmailId { get; set; }
       
        public Email EmailEnvio { get; set; }
        
        public Email EmailRemetente { get; set; }

        public ConfiguracaoEmail ConfiguracaoEmail { get; set; }
    }
}
