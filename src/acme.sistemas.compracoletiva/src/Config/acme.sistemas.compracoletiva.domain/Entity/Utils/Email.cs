using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acme.sistemas.compracoletiva.domain.Entity.Utils
{
    public class Email : BaseEntity
    {
        protected Email()
        {

        }

        public string Nome { get; private set; }



        public virtual ICollection<EnvioEmail> EnvioEmails { get; set; } = new HashSet<EnvioEmail>();

    }
}
