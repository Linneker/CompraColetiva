using acme.sistemas.compracoletiva.core.Base;
using acme.sistemas.compracoletiva.domain.Entity.Product;
using acme.sistemas.compracoletiva.domain.Entity.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acme.sistemas.compracoletiva.domain.Entity.Sales
{   
    public class Encomenda : BaseEntity, IAggregateRoot
    {
        protected Encomenda()
        {

        }

        public Encomenda(Guid usuarioClienteId, Guid compraId, Guid produtoId)
        {
            UsuarioClienteId = usuarioClienteId;
            CompraId = compraId;
            ProdutoId = produtoId; 
        }

        public Guid UsuarioClienteId { get; set; }
        public Guid UsuarioFornecedorId { get; set; }
        public Guid CompraId { get; set; }
        public Guid ProdutoId { get; set; }

        public virtual Usuario UsuarioCliente { get; set; }
        public virtual Usuario UsuarioFornecedor { get; set; }
        public virtual Compra Compra { get; set; }
        public virtual Produto Produto { get; set; }
    }
}
