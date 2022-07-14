using acme.sistemas.compracoletiva.core.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acme.sistemas.compracoletiva.domain.Entity.Utils
{
    public class Seguro : BaseEntity, IAggregateRoot
    {
        protected Seguro()
        {

        }

        public string Nome { get; set; }
        public string Empresa { get; set; }
        public decimal Taxa { get; set; }
    }
}
