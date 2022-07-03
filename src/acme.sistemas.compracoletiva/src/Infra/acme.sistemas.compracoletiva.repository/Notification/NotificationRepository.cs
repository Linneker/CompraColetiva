﻿using acme.sistemas.compracoletiva.domain.Entity.Utils;
using acme.sistemas.compracoletiva.domain.Interfaces.Repository.Notification;
using acme.sistemas.compracoletiva.infra.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acme.sistemas.compracoletiva.repository.Notification
{
    public class NotificationRepository : BaseRepository<Notificacao>, INotificacaoRepository
    {
        public NotificationRepository(Context db) : base(db)
        {
        }
    }
}
