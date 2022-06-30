using acme.sistemas.compracoletiva.core.Interfaces.ProductType;
using acme.sistemas.compracoletiva.domain.Entity;
using acme.sistemas.compracoletiva.domain.Entity.Product;
using acme.sistemas.compracoletiva.domain.Entity.Utils;
using acme.sistemas.compracoletiva.domain.Interfaces.Aggregate;
using acme.sistemas.compracoletiva.domain.Interfaces.Repository;
using acme.sistemas.compracoletiva.domain.Interfaces.Repository.ProductType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acme.sistemas.compracoletiva.service.ProductType
{
    public class TipoProdutoService : BaseService<TipoProduto>, ITipoProdutoService
    {
      private readonly ITipoProdutoRepository  _tipoProdutoRepository;

        public TipoProdutoService(ITipoProdutoRepository tipoProdutoRepository) : base(tipoProdutoRepository)
        {
            _tipoProdutoRepository = tipoProdutoRepository;
        }
    }
}
