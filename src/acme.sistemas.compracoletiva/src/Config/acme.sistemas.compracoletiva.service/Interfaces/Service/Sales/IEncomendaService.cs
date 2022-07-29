﻿using acme.sistemas.compracoletiva.domain.Entity.Sales;

namespace acme.sistemas.compracoletiva.service.Interfaces.Service.Sales
{
    public interface IEncomendaService : IBaseService<Encomenda>
    {
        void Encomendar(Guid usuarioFornecedorId, Guid produtoId);
        
    }
}
