using acme.sistemas.compracoletiva.core.Interfaces.Product;
using acme.sistemas.compracoletiva.domain.Entity.Product;
using acme.sistemas.compracoletiva.domain.Interfaces.Repository.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acme.sistemas.compracoletiva.service.Package
{
    public class PacoteService : BaseService<Produto>, IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public PacoteService(IProdutoRepository produtoRepository) : base (produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }
    }
}
