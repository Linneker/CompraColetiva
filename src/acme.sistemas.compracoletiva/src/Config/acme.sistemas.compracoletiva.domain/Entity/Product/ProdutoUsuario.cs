using acme.sistemas.compracoletiva.domain.Interfaces.Aggregate;
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

        public string Nome { get; private set; }
        public Guid ProdutoId { get; private set; }
        public DateTime Prazo { get; private set; }
    }
}
