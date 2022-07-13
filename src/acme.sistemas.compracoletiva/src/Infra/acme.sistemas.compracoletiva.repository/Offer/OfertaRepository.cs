﻿using acme.sistemas.compracoletiva.domain.Entity.Sales;
using acme.sistemas.compracoletiva.infra.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acme.sistemas.compracoletiva.repository.Offer
{
    public class OfertaRepository : BaseRepository<Oferta>
    {
        public OfertaRepository(Context db) : base(db)
        {
        }
    }
}