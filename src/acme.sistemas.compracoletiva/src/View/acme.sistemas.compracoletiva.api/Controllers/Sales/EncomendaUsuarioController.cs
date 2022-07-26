using acme.sistemas.compracoletiva.domain.Entity.Sales;
using acme.sistemas.compracoletiva.service.Interfaces.Service.Sales;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace acme.sistemas.compracoletiva.api.Controllers.Sales
{
    [Route("api/[controller]")]
    [ApiController]
    public class EncomendaUsuarioController : BaseController<EncomendaUsuario>
    {
        private readonly IEncomendaUsuarioService _encomendaUsuarioService;

        public EncomendaUsuarioController(IEncomendaUsuarioService encomendaUsuarioService) : base (encomendaUsuarioService)
        {
            _encomendaUsuarioService = encomendaUsuarioService;
        }
    }
}
