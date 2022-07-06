using acme.sistemas.compracoletiva.core.Interfaces.Service.Utils;
using acme.sistemas.compracoletiva.domain.Entity.Utils;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace acme.sistemas.compracoletiva.api.Controllers.Utils
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParametroController : BaseController<Parametro>
    {
        private readonly IParametroService _parametroService;

        public ParametroController(IParametroService parametroService) : base (parametroService)
        {
            _parametroService = parametroService;
        }
    }
}
