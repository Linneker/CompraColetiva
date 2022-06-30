using acme.sistemas.compracoletiva.core.Interfaces.Order;
using acme.sistemas.compracoletiva.domain.Entity.Utils;
using acme.sistemas.compracoletiva.domain.Interfaces.Repository;
using acme.sistemas.compracoletiva.domain.Interfaces.Repository.Order;
using acme.sistemas.compracoletiva.domain.Interfaces.Repository.Purchase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acme.sistemas.compracoletiva.service.Order
{
    public class EncomendaService : BaseService<Encomenda>, IEncomendaService
    {
        private readonly IEncomendaRepository _encomendaRepository;

        public EncomendaService(IEncomendaRepository encomendaRepository) : base(encomendaRepository)
        {
            _encomendaRepository = encomendaRepository;
        }
    }
}
