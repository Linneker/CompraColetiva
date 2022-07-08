﻿using acme.sistemas.compracoletiva.domain.Interfaces.Aggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acme.sistemas.compracoletiva.domain.Entity.Sales
{
    public class UnidadeMedidaCompra : BaseEntity, IAggregateRoot
    {
        protected UnidadeMedidaCompra()
        {

        }

        public string Nome { get; private set; }
        public string Descricao { get; private set; }

    }
}