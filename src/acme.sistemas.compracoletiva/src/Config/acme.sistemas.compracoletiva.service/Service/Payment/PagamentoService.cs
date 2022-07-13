using acme.sistemas.compracoletiva.core.Interfaces.Service.Payment;
using acme.sistemas.compracoletiva.domain.Entity.Utils;
using acme.sistemas.compracoletiva.domain.Interfaces.Repository.Payment;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acme.sistemas.compracoletiva.service.Service.Payment
{
    internal class PagamentoService : BaseService<Pagamento>, IPagamentoService
    {
        private readonly IPagamentoRepository _pagamentoRepository;
        private readonly IMapper mapper;

        public PagamentoService(IPagamentoRepository pagamentoRepository, IMapper mapper) : base(pagamentoRepository)
        {
            _pagamentoRepository = pagamentoRepository;
            this.mapper = mapper;
        }
    }
}
