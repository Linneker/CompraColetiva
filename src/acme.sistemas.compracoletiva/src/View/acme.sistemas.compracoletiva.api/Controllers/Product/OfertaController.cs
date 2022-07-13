using acme.sistemas.compracoletiva.domain.Entity.Product;
using acme.sistemas.compracoletiva.service.Interfaces.Service.Product;
using Microsoft.AspNetCore.Mvc;

namespace acme.sistemas.compracoletiva.api.Controllers.Product
{
    [Route("api/[controller]")]
    [ApiController]
    public class OfertaController : BaseController<Oferta>
    {
        private readonly IOfertaService _ofertaService;

        public OfertaController(IOfertaService ofertaService) : base(ofertaService)
        {
            _ofertaService = ofertaService;
        }
    }
}
