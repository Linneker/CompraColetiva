using acme.sistemas.compracoletiva.core.Interfaces.Service.Sales;
using acme.sistemas.compracoletiva.domain.Entity.Sales;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace acme.sistemas.compracoletiva.api.Controllers.Sales
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompraController : BaseController<Compra>
    {
        private readonly ICompraService _compraService;

        public CompraController(ICompraService compraService) : base(compraService)
        {
            _compraService = compraService;
        }
    }
}
