using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acme.sistemas.compracoletiva.domain.Entity.Utils
{
    public class EnvioEmail : BaseEntity
    {
        protected EnvioEmail()
        {

        }

        public string Titulo { get; private set; }
        public string Corpo { get; private set; }
        public Guid RemetenteId { get; private set; }
        public Email Remetente { get; private set; }






        public virtual ICollection<Email> EmailsCopias { get; set; } = new HashSet<Email>();
    }
}
