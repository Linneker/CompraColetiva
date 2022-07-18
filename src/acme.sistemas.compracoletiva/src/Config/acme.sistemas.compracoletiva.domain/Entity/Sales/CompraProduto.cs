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
    public class CompraProduto: BaseEntity
    {
        public decimal ValorUnitario { get; set; }
        public decimal Quantidade { get; set; }
        public decimal ValorTotal { get => ValorUnitario * Quantidade;  }

        public Guid ProdutoId { get; set; }
        public Guid CompraId { get; set; }
        public Guid UsuarioVendaId { get; set; }
        public Guid UsuarioCompraId { get; set; }


        public Produto Produto { get; set; }
        public Compra Compra { get; set; }
        public Usuario UsuarioVenda { get; set; }
        public Usuario UsuarioCompra { get; set; }

    }
}
