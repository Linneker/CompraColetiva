using acme.sistemas.compracoletiva.core.Interfaces.Service.Utils;
using acme.sistemas.compracoletiva.domain.Entity.Utils;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace acme.sistemas.compracoletiva.api.Controllers.Utils
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArquivoController : BaseController<Arquivo>
    {
        private readonly IArquivoService _arquivoService;

        public ArquivoController (IArquivoService arquivoService) : base (arquivoService)
        {
            _arquivoService = arquivoService;
        }
    }
}
