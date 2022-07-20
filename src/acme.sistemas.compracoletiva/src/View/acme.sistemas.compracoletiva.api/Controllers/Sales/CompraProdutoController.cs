using acme.sistemas.compracoletiva.domain.Entity.Sales;
using acme.sistemas.compracoletiva.service.Interfaces.Service.Sales;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace acme.sistemas.compracoletiva.api.Controllers.Sales
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompraProdutoController : BaseController<CompraProduto>
    {
        private readonly ICompraProdutoService _compraProdutoService;

        public CompraProdutoController(ICompraProdutoService compraProdutoService) : base(compraProdutoService)
        {
            _compraProdutoService = compraProdutoService;
        }
    }
}
