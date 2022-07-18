using acme.sistemas.compracoletiva.core.Base;
using acme.sistemas.compracoletiva.domain.Entity.Users;
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
        public Guid UsuarioId { get; set; }

        public DateTime Prazo { get; set; }
        public Produto Produto { get; set; }
        public Usuario Usuario { get; set; }

    }
}
