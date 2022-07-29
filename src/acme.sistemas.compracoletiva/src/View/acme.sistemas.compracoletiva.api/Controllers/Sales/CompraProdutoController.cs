using acme.sistemas.compracoletiva.domain.Entity.Sales;
using acme.sistemas.compracoletiva.service.Interfaces.Service.Sales;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace acme.sistemas.compracoletiva.api.Controllers.Sales
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompraProdutoController : BaseController<CompraProduto>
    {
        private readonly ICompraProdutoService _compraProdutoService;

        public CompraProdutoController(ICompraProdutoService compraProdutoService) : base(compraProdutoService)
        {
            _compraProdutoService = compraProdutoService;
        }


        [HttpPost]
        public async Task<IActionResult> AddAsync(CompraProduto compraProduto)
        {
            try
            {
                await _compraProdutoService.AddAsync(compraProduto);
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
                var compraProduto = _compraProdutoService.GetAll<CompraProduto, CompraProduto>();
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

                var compraProduto = await _compraProdutoService.GetByIdAsync<CompraProduto, CompraProduto>(id);
                return Ok(id);
            }
            catch (Exception e)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, e);
            }
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsync(CompraProduto compraProduto, Guid id)
        {
            try
            {

                _compraProdutoService.Update(compraProduto);
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
                var compraProduto = await _compraProdutoService.GetByIdAsync<CompraProduto, CompraProduto>(id);

                _compraProdutoService.Remove(compraProduto);
                return Ok();
            }
            catch (Exception e)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, e);
            }
        }
    }
}
