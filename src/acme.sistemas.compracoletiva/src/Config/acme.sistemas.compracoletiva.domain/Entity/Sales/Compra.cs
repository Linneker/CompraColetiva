﻿using acme.sistemas.compracoletiva.core.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acme.sistemas.compracoletiva.domain.Entity.Sales
{
    public class Compra : BaseEntity, IAggregateRoot
    {
        protected Compra()
        {

        }

        public Compra(int quantitdade, int valor, string produto)
        {
            Quantidade = quantitdade;
            Valor = valor;
            Produto = produto;
        }

        public int Quantidade { get; set; }
        public int Valor { get; set; }
        public string Produto { get; set; }
    }
}
