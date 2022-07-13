<<<<<<<< HEAD:src/acme.sistemas.compracoletiva/src/Config/acme.sistemas.compracoletiva.service/Service/Payment/PagamentoService.cs
﻿using acme.sistemas.compracoletiva.core.Interfaces.Service.Payment;
using acme.sistemas.compracoletiva.domain.Entity.Utils;
using acme.sistemas.compracoletiva.domain.Interfaces.Repository.Payment;
using AutoMapper;
========
﻿using acme.sistemas.compracoletiva.core.Interfaces.Service.Utils;
using acme.sistemas.compracoletiva.domain.Entity.Utils;
using acme.sistemas.compracoletiva.domain.Interfaces.Repository.Utils;
>>>>>>>> d92261d239de20e7456eff4e939cb2f22c03fb79:src/acme.sistemas.compracoletiva/src/Config/acme.sistemas.compracoletiva.service/Service/Utils/PagamentoService.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

<<<<<<<< HEAD:src/acme.sistemas.compracoletiva/src/Config/acme.sistemas.compracoletiva.service/Service/Payment/PagamentoService.cs
namespace acme.sistemas.compracoletiva.service.Service.Payment
========
namespace acme.sistemas.compracoletiva.service.Service.Utils
>>>>>>>> d92261d239de20e7456eff4e939cb2f22c03fb79:src/acme.sistemas.compracoletiva/src/Config/acme.sistemas.compracoletiva.service/Service/Utils/PagamentoService.cs
{
    internal class PagamentoService : BaseService<Pagamento>, IPagamentoService
    {
        private readonly IPagamentoRepository _pagamentoRepository;
        private readonly IMapper mapper;

<<<<<<<< HEAD:src/acme.sistemas.compracoletiva/src/Config/acme.sistemas.compracoletiva.service/Service/Payment/PagamentoService.cs
        public PagamentoService(IPagamentoRepository pagamentoRepository, IMapper mapper) : base(pagamentoRepository)
========
        public PagamentoService(IPagamentoRepository pagamentoRepository) : base(pagamentoRepository)
>>>>>>>> d92261d239de20e7456eff4e939cb2f22c03fb79:src/acme.sistemas.compracoletiva/src/Config/acme.sistemas.compracoletiva.service/Service/Utils/PagamentoService.cs
        {
            _pagamentoRepository = pagamentoRepository;
            this.mapper = mapper;
        }
    }
}
