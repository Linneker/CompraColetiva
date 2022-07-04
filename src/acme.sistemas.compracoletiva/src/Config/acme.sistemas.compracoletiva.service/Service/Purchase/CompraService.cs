﻿using acme.sistemas.compracoletiva.core.Interfaces.Service.Purchase;
using acme.sistemas.compracoletiva.domain.Entity.Sales;
using acme.sistemas.compracoletiva.domain.Interfaces.Repository.Purchase;
using AutoMapper;

namespace acme.sistemas.compracoletiva.service.Service.Purchase
{
    public class CompraService : BaseService<Compra>, ICompraService
    {
        private readonly ICompraRepository _compraRepository;
        private readonly IMapper _mapper;

        public CompraService(ICompraRepository compraRepository,
            IMapper mapper) : base(compraRepository, mapper)
        {
            _compraRepository = compraRepository;
            _mapper = mapper;
        }
    }
}
