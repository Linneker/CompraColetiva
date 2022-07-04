using acme.sistemas.compracoletiva.core.Interfaces;
using acme.sistemas.compracoletiva.core.Interfaces.Insurance;
using acme.sistemas.compracoletiva.domain.Entity.Utils;
using acme.sistemas.compracoletiva.domain.Interfaces.Repository;
using acme.sistemas.compracoletiva.domain.Interfaces.Repository.Insurance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acme.sistemas.compracoletiva.service.Insurance
{
    public class SeguroService : BaseService<Seguro>, ISeguroService
    {
        private readonly ISeguroRepository _seguroRepository;

        public SeguroService(ISeguroRepository seguroRepository) : base(seguroRepository)
        {
            _seguroRepository = seguroRepository;
        }
    }
}
