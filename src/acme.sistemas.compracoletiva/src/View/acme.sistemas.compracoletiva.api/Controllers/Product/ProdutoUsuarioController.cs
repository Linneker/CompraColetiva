using acme.sistemas.compracoletiva.core.Interfaces.Service.Product;
using acme.sistemas.compracoletiva.domain.Entity.Product;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace acme.sistemas.compracoletiva.api.Controllers.Product
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoUsuarioController : BaseController<ProdutoUsuario>
    {
        private readonly IProdutoUsuarioService _produtoUsuarioService;

        public ProdutoUsuarioController(IProdutoUsuarioService produtoUsuarioService) : base(produtoUsuarioService)
        {
            _produtoUsuarioService = produtoUsuarioService;
        }
    }
}
