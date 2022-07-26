using acme.sistemas.compracoletiva.domain.Entity.Sales;
using acme.sistemas.compracoletiva.service.Interfaces.Service.Sales;
using Microsoft.AspNetCore.Mvc;

namespace acme.sistemas.compracoletiva.api.Controllers.Sales
{
    [Route("api/[controller]")]
    [ApiController]
    public class EncomendaController : BaseController<Encomenda>
    {
        private readonly IEncomendaService _encomendaService;

        public EncomendaController(IEncomendaService encomendaService) : base(encomendaService)
        {
            _encomendaService = encomendaService;

        }

        
    }
}
