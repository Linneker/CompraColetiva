using acme.sistemas.compracoletiva.domain.Entity.Sales;
using acme.sistemas.compracoletiva.service.Interfaces.Service.Sales;
using Microsoft.AspNetCore.Mvc;

namespace acme.sistemas.compracoletiva.api.Controllers.Utils
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservaController : BaseController<Reserva>
    {
        private readonly IReservaService _reservaService;

        public ReservaController(IReservaService reservaService) : base(reservaService)
        {
            _reservaService = reservaService;
        }
    }
}
