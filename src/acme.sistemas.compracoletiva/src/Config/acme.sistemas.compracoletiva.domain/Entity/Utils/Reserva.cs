using acme.sistemas.compracoletiva.domain.Entity.Product;
using acme.sistemas.compracoletiva.domain.Entity.Users;
using acme.sistemas.compracoletiva.core.Base;
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

        public DateTime Prazo { get; set; }
        public Guid UsuarioId { get; set; }
        public int Quantidade { get; set; }
        public virtual Produto Produto { get; set; }
        public DateTime Expiracao { get; set; }
        public Guid ProdutoId { get; set; }
        public virtual Usuario Usuario { get; set; }
         


    }
}
