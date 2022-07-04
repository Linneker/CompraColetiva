using acme.sistemas.compracoletiva.core.Interfaces.Service.Offer;
using acme.sistemas.compracoletiva.domain.Entity.Sales;
using acme.sistemas.compracoletiva.domain.Interfaces.Repository.Offer;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acme.sistemas.compracoletiva.service.Service.Offer
{
    public class OfertaService : BaseService<Oferta>, IOfertaService
    {
        private readonly IOfertaRepository _ofertaRepository;
        private readonly IMapper _mapper;

        public OfertaService(IOfertaRepository ofertaRepository, IMapper mapper) : base(ofertaRepository)
        {
            _ofertaRepository = ofertaRepository;
            _mapper = mapper;
        }
    }
}
