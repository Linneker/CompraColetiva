using acme.sistemas.compracoletiva.core.Interfaces.Service.Utils;
using acme.sistemas.compracoletiva.domain.Entity.Utils;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace acme.sistemas.compracoletiva.api.Controllers.Utils
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeguroController : BaseController<Seguro>
    {
        private readonly ISeguroService _seguroService;

        public SeguroController(ISeguroService seguroService) : base(seguroService)
        {
            _seguroService = seguroService;
        }
    }
}
