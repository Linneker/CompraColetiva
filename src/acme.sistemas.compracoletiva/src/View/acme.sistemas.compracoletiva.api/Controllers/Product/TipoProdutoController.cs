
using acme.sistemas.compracoletiva.core.Interfaces.Service.Product;
using acme.sistemas.compracoletiva.domain.Entity.Product;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace acme.sistemas.compracoletiva.api.Controllers.Product
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoProdutoController : BaseController<TipoProduto>
    {
        private readonly ITipoProdutoService _tipoProdutoService;

        public TipoProdutoController(ITipoProdutoService tipoProdutoService) : base(tipoProdutoService)
        {
            _tipoProdutoService = tipoProdutoService;
        }
    }
}
