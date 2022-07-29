using acme.sistemas.compracoletiva.domain.Entity.Sales;
using acme.sistemas.compracoletiva.service.Interfaces.Service.Sales;
using Microsoft.AspNetCore.Mvc;

namespace acme.sistemas.compracoletiva.api.Controllers.Sales
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


        [HttpPost]
        public async Task<IActionResult> AddAsync(Reserva reserva)
        {
            try
            {
                await _reservaService.AddAsync(reserva);
                return Ok();
            }
            catch (Exception e)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, e);

            }
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            try
            {
                var reservas = _reservaService.GetAll<Reserva, Reserva>();
                return Ok();
            }
            catch (Exception e)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, e);

            }
        }



        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(Guid id)
        {
            try
            {

                var reserva = await _reservaService.GetByIdAsync<Reserva, Reserva>(id);
                return Ok(id);
            }
            catch (Exception e)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, e);
            }
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsync(Reserva reserva, Guid id)
        {
            try
            {

                _reservaService.Update(reserva);
                return Ok();
            }
            catch (Exception e)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, e);
            }
        }



        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(Guid id)
        {
            try
            {
                var reserva = await _reservaService.GetByIdAsync<Reserva, Reserva>(id);

                _reservaService.Remove(reserva);
                return Ok();
            }
            catch (Exception e)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, e);
            }
        }
    }
}


