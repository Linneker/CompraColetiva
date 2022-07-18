using acme.sistemas.compracoletiva.core.Base;
using acme.sistemas.compracoletiva.domain.Entity.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acme.sistemas.compracoletiva.domain.Entity.Sales
{
    public class Compra : BaseEntity, IAggregateRoot
    {
        protected Compra()
        {

        }

        public Compra(int quantitdade, int valor)
        {
            Quantidade = quantitdade;
            Valor = valor;

        }

        public int Quantidade { get; set; }
        public int Valor { get; set; }
        public virtual ICollection<CompraProduto> CompraProduto { get; set; } = new HashSet<CompraProduto>();
        public virtual ICollection<Encomenda> Encomendas { get; set; } = new HashSet<Encomenda>();
        
    }
}
