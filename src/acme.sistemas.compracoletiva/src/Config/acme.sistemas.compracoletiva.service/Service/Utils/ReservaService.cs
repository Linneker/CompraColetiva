using acme.sistemas.compracoletiva.domain.Interfaces.Repository.Utils;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using acme.sistemas.compracoletiva.domain.Entity.Sales;
using acme.sistemas.compracoletiva.service.Interfaces.Service.Sales;

namespace acme.sistemas.compracoletiva.service.Service.Utils
{
    public class ReservaService : BaseService<Reserva>, IReservaService
    {
        private readonly IReservaRepository _reservaRepository;
        private readonly IMapper mapper;

        public ReservaService(IReservaRepository reservaRepository, IMapper mapper) : base(reservaRepository)
        {
            _reservaRepository = reservaRepository;
            this.mapper = mapper;
        }

        public Task CriarReserva(DateTime prazo, int quantidade, DateTime expiracao, Guid produtoId, Guid clienteUsuarioId, Guid fornecedorUsuarioId)
        {
            CriarReserva C
        }
    }
}
