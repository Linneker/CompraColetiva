using acme.sistemas.compracoletiva.core.Interfaces.Service.Order;
using acme.sistemas.compracoletiva.domain.Entity.Sales;
using acme.sistemas.compracoletiva.domain.Interfaces.Repository.Order;
using AutoMapper;

namespace acme.sistemas.compracoletiva.service.Service.Order
{
    public class EncomendaService : BaseService<Encomenda>, IEncomendaService
    {
        private readonly IEncomendaRepository _encomendaRepository;
        private readonly IMapper _mapper;


        public EncomendaService(IEncomendaRepository encomendaRepository,
            IMapper mapper) : base(encomendaRepository, mapper)
        {
            _encomendaRepository = encomendaRepository;
            _mapper = mapper;
        }
    }
}
