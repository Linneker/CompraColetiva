using acme.sistemas.compracoletiva.core.Interfaces.Service.Package;
using acme.sistemas.compracoletiva.domain.Entity.SalesInternal;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace acme.sistemas.compracoletiva.api.Controllers.Package
{
    [Route("api/[controller]")]
    [ApiController]
    public class PacoteController : BaseController<Pacote>
    {
        private readonly IPacoteService _pacoteService;

        public PacoteController(IPacoteService pacoteService) : base(pacoteService)
        {
            _pacoteService = pacoteService;
        }
    }
}
