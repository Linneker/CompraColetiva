using acme.sistemas.compracoletiva.core.Interfaces.Service.User;
using acme.sistemas.compracoletiva.domain.Entity.Users;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace acme.sistemas.compracoletiva.api.Controllers.User
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoUsuarioController : ControllerBase
    {
        private readonly ITipoUsuarioService _tipoUsarioController;

        public TipoUsuarioController(ITipoUsuarioService tipoUsuarioService)
        {
            _tipoUsarioController = tipoUsuarioService;
        }


        [HttpPost("Add")]
        public async Task<IActionResult> Add(TipoUsuario tipoUsuario)
        {
            _tipoUsarioController.Add(tipoUsuario);

            return Ok();
        }
    }
}
