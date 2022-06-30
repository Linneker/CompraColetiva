using acme.sistemas.compracoletiva.core.Interfaces.Purchase;
using acme.sistemas.compracoletiva.domain.Entity.Utils;
using acme.sistemas.compracoletiva.domain.Interfaces.Repository.Purchase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acme.sistemas.compracoletiva.service.Purchase
{
    public class CompraService : BaseService<Compra>, ICompraService
    {
        private readonly ICompraRepository _compraRepository;

        public CompraService(ICompraRepository compraRepository) : base(compraRepository)
        {
            _compraRepository = compraRepository;
        }
    }
}
