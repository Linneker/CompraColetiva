using acme.sistemas.compracoletiva.core.Interfaces.Service.ProductType;
using acme.sistemas.compracoletiva.domain.Entity.Product;
using acme.sistemas.compracoletiva.domain.Interfaces.Repository.ProductType;
using AutoMapper;

namespace acme.sistemas.compracoletiva.service.Service.Product
{
    public class TipoProdutoService : BaseService<TipoProduto>, ITipoProdutoService
    {
        private readonly ITipoProdutoRepository _tipoProdutoRepository;
        private readonly IMapper _mapper;

        public TipoProdutoService(ITipoProdutoRepository tipoProdutoRepository,
            IMapper mapper) : base(tipoProdutoRepository)
        {
            _tipoProdutoRepository = tipoProdutoRepository;
            _mapper = mapper;
        }
    }
}
