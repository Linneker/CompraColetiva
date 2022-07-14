using acme.sistemas.compracoletiva.core.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acme.sistemas.compracoletiva.domain.Entity.Utils
{
    public class EnvioEmail : BaseEntity , IAggregateRoot
    {
        protected EnvioEmail()
        {

        }

        public string Titulo { get; set; }
        public string Corpo { get; set; }
        public Guid DestinatarioId { get; set; }
        public Email Destinatario { get; set; }

        public virtual ICollection<Email> EmailsCopias { get; set; } = new HashSet<Email>();
    }
}
