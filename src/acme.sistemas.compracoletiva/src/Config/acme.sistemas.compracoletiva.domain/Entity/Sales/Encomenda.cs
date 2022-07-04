﻿using acme.sistemas.compracoletiva.domain.Interfaces.Aggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acme.sistemas.compracoletiva.domain.Entity.Sales
{   
    public class Encomenda : BaseEntity, IAggregateRoot
    {
        protected Encomenda()
        {

        }

        public Encomenda(Guid pessoaId, Guid compraId, Guid produtoId)
        {
            PessoaId = pessoaId;
            CompraId = compraId;
            ProdutoId = produtoId; 
        }

        public Guid PessoaId { get; private set; }
        public Guid CompraId { get; private set; }
        public Guid ProdutoId { get; private set; }
    }
}