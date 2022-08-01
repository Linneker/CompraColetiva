﻿using acme.sistemas.compracoletiva.api.Configurations.Filtler;
using acme.sistemas.compracoletiva.domain.Entity.Sales;
using acme.sistemas.compracoletiva.service.Interfaces.Service.Sales;
using Microsoft.AspNetCore.Mvc;

namespace acme.sistemas.compracoletiva.api.Controllers.Sales
{
    [Route("api/[controller]")]
    [ApiController]
    public class EncomendaController : ControllerBase
    {
        private readonly IEncomendaService _encomendaService;
       

        public EncomendaController(IEncomendaService encomendaService ) 
        {
            _encomendaService = encomendaService;
        }

        [UnitOfWorkFilter]
        [HttpPost]
        public async Task<IActionResult> AddAsync(Encomenda encomenda)
        {
            try
            {
                await _encomendaService.AddAsync(encomenda);
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
                var encomenda = _encomendaService.GetAll<Encomenda, Encomenda>();
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
                
                var encomenda = await _encomendaService.GetByIdAsync<Encomenda, Encomenda>(id);
                return Ok(id);
            }
            catch (Exception e)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, e);
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsync(Encomenda encomenda, Guid id)
        {
            try
            {

                _encomendaService.Update(encomenda);
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

                var encomenda = await _encomendaService.GetByIdAsync<Encomenda, Encomenda>(id);
                
                _encomendaService.Remove(encomenda);
                return Ok();
            }
            catch (Exception e)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, e);
            }
        }
    }
}
