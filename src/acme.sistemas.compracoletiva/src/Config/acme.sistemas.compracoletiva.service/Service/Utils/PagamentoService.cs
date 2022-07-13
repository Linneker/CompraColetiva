using acme.sistemas.compracoletiva.service.Interfaces.Service.Utils;
using acme.sistemas.compracoletiva.domain.Entity.Utils;
using acme.sistemas.compracoletiva.domain.Interfaces.Repository.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace acme.sistemas.compracoletiva.service.Service.Utils
{
    internal class PagamentoService : BaseService<Pagamento>, IPagamentoService
    {
        private readonly IPagamentoRepository _pagamentoRepository;
        private readonly IMapper mapper;

        public PagamentoService(IPagamentoRepository pagamentoRepository) : base(pagamentoRepository)
        {
            _pagamentoRepository = pagamentoRepository;
            this.mapper = mapper;
        }
    }
}
