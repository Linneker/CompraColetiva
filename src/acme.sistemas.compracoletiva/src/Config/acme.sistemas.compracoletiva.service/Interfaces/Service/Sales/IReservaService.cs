using acme.sistemas.compracoletiva.domain.Entity.Sales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acme.sistemas.compracoletiva.service.Interfaces.Service.Sales
{
    public interface IReservaService : IBaseService<Reserva>
    {
        Task CriarReserva(DateTime prazo, int quantidade, DateTime expiracao,Guid produtoId, Guid clienteUsuarioId, Guid fornecedorUsuarioId);
    }
}
