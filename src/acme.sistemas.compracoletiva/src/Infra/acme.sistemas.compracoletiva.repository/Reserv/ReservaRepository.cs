﻿using acme.sistemas.compracoletiva.domain.Entity.Utils;
using acme.sistemas.compracoletiva.domain.Interfaces.Repository.Reserv;
using acme.sistemas.compracoletiva.infra.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acme.sistemas.compracoletiva.repository.Reserv
{
    public class ReservaRepository : BaseRepository<Reserva>, IReservaRepository
    {
        public ReservaRepository(Context db) : base(db)
        {
        }
    }
}