using acme.sistemas.compracoletiva.core.Interfaces.Payment;
using acme.sistemas.compracoletiva.domain.Entity.Utils;
using acme.sistemas.compracoletiva.domain.Interfaces.Repository.Payment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acme.sistemas.compracoletiva.service.Payment
{
    internal class PagamentoService : BaseService<Pagamento>, IPagamentoService
    {
        private readonly IPagamentoRepository _pagamentoRepository;

        public PagamentoService(IPagamentoRepository pagamentoRepository) : base (pagamentoRepository)
        {
            _pagamentoRepository = pagamentoRepository;
        }
    }
}
