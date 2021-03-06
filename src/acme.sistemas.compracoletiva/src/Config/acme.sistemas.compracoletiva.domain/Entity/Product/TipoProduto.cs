using acme.sistemas.compracoletiva.domain.Entity.Product;
using acme.sistemas.compracoletiva.core.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acme.sistemas.compracoletiva.domain.Entity.Product
{
    public class TipoProduto : BaseEntity , IAggregateRoot
    {
        protected TipoProduto()
        {

        }

        public TipoProduto(string nome, string descricao, ICollection<Produto> produtos)
        {
            Nome = nome;
            Descricao = descricao;
            Produtos = produtos;
        }

        public string Nome { get; set; }
        public string Descricao { get; set; }
        public ICollection<Produto> Produtos { get; set; } = new HashSet<Produto>();
    }
}
