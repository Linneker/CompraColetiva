using acme.sistemas.compracoletiva.domain.Entity.Product;
using acme.sistemas.compracoletiva.domain.Interfaces.Aggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acme.sistemas.compracoletiva.domain.Entity.Utils
{
    public class Reserva : BaseEntity, IAggregateRoot
    {
        protected Reserva()
        {

        }

        public DateTime Prazo { get; private set; }
        public Guid UsuarioId { get; private set; }
        public int Quantidade { get; private set; }
        public Produto Produto { get; private set; }
        public DateTime Expiracao { get; private set; }
        public Guid ProdutoId { get; private set; }


    }
}
