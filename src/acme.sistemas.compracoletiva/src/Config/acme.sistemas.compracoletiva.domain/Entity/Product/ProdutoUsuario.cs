using acme.sistemas.compracoletiva.core.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acme.sistemas.compracoletiva.domain.Entity.Product
{
    public class ProdutoUsuario : BaseEntity, IAggregateRoot
    {
        protected ProdutoUsuario()
        {

        }

        public string Nome { get; set; }
        public Guid ProdutoId { get; set; }
        public DateTime Prazo { get; set; }
    }
}
