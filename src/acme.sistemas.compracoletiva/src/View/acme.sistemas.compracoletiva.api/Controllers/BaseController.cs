using acme.sistemas.compracoletiva.core.Interfaces.Service;
using acme.sistemas.compracoletiva.domain.Entity;
using acme.sistemas.compracoletiva.domain.Interfaces.Aggregate;
using acme.sistemas.compracoletiva.infra.Config;
using acme.sistemas.compracoletiva.service.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace acme.sistemas.compracoletiva.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<TEntity> : ControllerBase where TEntity : IAggregateRoot
    {
        private readonly IBaseService<TEntity> _baseService;

        public BaseController(IBaseService<TEntity> baseService)
        {
            _baseService = baseService;
        }


        [HttpPost]
        public async Task<IActionResult> AddAsync(TEntity baseService)
        {
            try
            {
                await _baseService.AddAsync(baseService);
                return Ok();
            }
            catch (Exception e)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, e);
            }
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove<Entity>(TEntity entity) where Entity : BaseEntity
        {

            try
            {
                _baseService.Remove(entity);
                return Ok();
            }
            catch (Exception e)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, e);
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, TEntity entity)
        {
            try
            {
                _baseService.Update(entity);
                return Ok();
            }
            catch (Exception e)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, e); ;
            }
        }
    }
}
