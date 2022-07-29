using acme.sistemas.compracoletiva.core.Dtos.Utils;
using acme.sistemas.compracoletiva.domain.Entity.Utils;
using acme.sistemas.compracoletiva.service.Interfaces.Service.Utils;
using Microsoft.AspNetCore.Mvc;

namespace acme.sistemas.compracoletiva.api.Controllers.Utils
{
    [Route("api/[controller]")]
    [ApiController]
    public class PagamentoController : BaseController<Pagamento>
    {
        private readonly IPagamentoService _pagamentoService;

        public PagamentoController(IPagamentoService pagamentoService) : base(pagamentoService)
        {
            _pagamentoService = pagamentoService;
        }


        [HttpPost("Pagar")]
        public IActionResult Pagar(PagamentoDto PagamentoDto)
        {
            try
            {
                _pagamentoService.RealizarPagamento(PagamentoDto);
                return Ok();
            }
            catch (Exception e)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, e);
            }
        }


        [HttpPost]
        public  override async Task<IActionResult> AddAsync(Pagamento pagamento)
        {
            try
            {
                await _pagamentoService.AddAsync(pagamento);
                return Ok();
            }
            catch (Exception e)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, e);
            }
        }


        [HttpGet]
        public  async Task<IActionResult> GetAllAsync()
        {
            try
            {
                var pagamentos = await _pagamentoService.GetAllAsync<Pagamento, Pagamento>();
                return Ok();
            }
            catch (Exception e)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, e);
            }
        }


        [HttpGet("{id}")]
        public  async Task<IActionResult> GetByIdAsync(Guid id)
        {
            try
            {

                var pagamento = await _pagamentoService.GetByIdAsync<Pagamento, Pagamento>(id);
                return Ok(id);
            }
            catch (Exception e)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, e);
            }
        }


        [HttpPut("{id}")]
        public  IActionResult Update(Pagamento pagamento, Guid id)
        {
            try
            {
                pagamento.Id = id;

                _pagamentoService.Update(pagamento);
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
                var pagamento = await _pagamentoService.GetByIdAsync<Pagamento, Pagamento>(id);

                _pagamentoService.Remove(pagamento);
                return Ok();
            }
            catch (Exception e)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, e);
            }
        }
    }
}
