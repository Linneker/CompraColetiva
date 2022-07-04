﻿using acme.sistemas.compracoletiva.core.Interfaces.Notification;
using acme.sistemas.compracoletiva.domain.Entity.Utils;
using acme.sistemas.compracoletiva.domain.Interfaces.Repository.Notification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acme.sistemas.compracoletiva.service.Notification
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
