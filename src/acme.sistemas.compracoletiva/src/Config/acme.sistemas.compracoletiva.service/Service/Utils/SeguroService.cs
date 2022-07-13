using acme.sistemas.compracoletiva.core.Interfaces;
<<<<<<<< HEAD:src/acme.sistemas.compracoletiva/src/Config/acme.sistemas.compracoletiva.service/Service/Insurance/SeguroService.cs
using acme.sistemas.compracoletiva.core.Interfaces.Service.Insurance;
========
using acme.sistemas.compracoletiva.core.Interfaces.Service.Utils;
>>>>>>>> d92261d239de20e7456eff4e939cb2f22c03fb79:src/acme.sistemas.compracoletiva/src/Config/acme.sistemas.compracoletiva.service/Service/Utils/SeguroService.cs
using acme.sistemas.compracoletiva.domain.Entity.Utils;
using acme.sistemas.compracoletiva.domain.Interfaces.Repository;
using acme.sistemas.compracoletiva.domain.Interfaces.Repository.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

<<<<<<<< HEAD:src/acme.sistemas.compracoletiva/src/Config/acme.sistemas.compracoletiva.service/Service/Insurance/SeguroService.cs
namespace acme.sistemas.compracoletiva.service.Service.Insurance
========
namespace acme.sistemas.compracoletiva.service.Service.Utils
>>>>>>>> d92261d239de20e7456eff4e939cb2f22c03fb79:src/acme.sistemas.compracoletiva/src/Config/acme.sistemas.compracoletiva.service/Service/Utils/SeguroService.cs
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
