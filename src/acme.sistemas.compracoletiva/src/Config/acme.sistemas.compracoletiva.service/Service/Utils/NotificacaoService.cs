<<<<<<<< HEAD:src/acme.sistemas.compracoletiva/src/Config/acme.sistemas.compracoletiva.service/Service/Notification/NotificacaoService.cs
﻿using acme.sistemas.compracoletiva.core.Interfaces.Service.Notification;
========
﻿using acme.sistemas.compracoletiva.core.Interfaces.Service.Utils;
>>>>>>>> d92261d239de20e7456eff4e939cb2f22c03fb79:src/acme.sistemas.compracoletiva/src/Config/acme.sistemas.compracoletiva.service/Service/Utils/NotificacaoService.cs
using acme.sistemas.compracoletiva.domain.Entity.Utils;
using acme.sistemas.compracoletiva.domain.Interfaces.Repository.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

<<<<<<<< HEAD:src/acme.sistemas.compracoletiva/src/Config/acme.sistemas.compracoletiva.service/Service/Notification/NotificacaoService.cs
namespace acme.sistemas.compracoletiva.service.Service.Notification
========
namespace acme.sistemas.compracoletiva.service.Service.Utils
>>>>>>>> d92261d239de20e7456eff4e939cb2f22c03fb79:src/acme.sistemas.compracoletiva/src/Config/acme.sistemas.compracoletiva.service/Service/Utils/NotificacaoService.cs
{
    public class NotificacaoService : BaseService<Notificacao>, INotificacaoService
    {
        private readonly INotificacaoRepository _notificacaoRepository;

        public NotificacaoService(INotificacaoRepository notificacaoRepository) : base(notificacaoRepository)
        {
            _notificacaoRepository = notificacaoRepository;
        }
    }
}
