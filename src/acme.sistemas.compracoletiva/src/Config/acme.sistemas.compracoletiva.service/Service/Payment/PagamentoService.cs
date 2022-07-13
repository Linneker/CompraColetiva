using acme.sistemas.compracoletiva.domain.Entity.Utils;
using acme.sistemas.compracoletiva.domain.Interfaces.Repository.Utils;
using acme.sistemas.compracoletiva.service.Interfaces.Service.Utils;
using AutoMapper;

namespace acme.sistemas.compracoletiva.service.Service.Utils
{
    public class PagamentoService : BaseService<Pagamento>, IPagamentoService
    {
        private readonly IPagamentoRepository _pagamentoRepository;
        private readonly IMapper _mapper;

        public PagamentoService(IPagamentoRepository pagamentoRepository, IMapper mapper, IPagamentoRepository pagamentoRepository, IMapper mapper) : this(pagamentoRepository)
        {
            this.mapper = mapper;
            this._pagamentoRepository = pagamentoRepository;
            _mapper = mapper;
        }
    }
}
