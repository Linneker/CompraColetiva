using acme.sistemas.compracoletiva.core.Interfaces.Service.Utils;
using acme.sistemas.compracoletiva.domain.Entity.Utils;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace acme.sistemas.compracoletiva.api.Controllers.Utils
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificacaoController : BaseController<Notificacao>
    {
        private readonly INotificacaoService _notificacao;

        public NotificacaoController (INotificacaoService notificacao) : base (notificacao)
        {
           _notificacao = notificacao;
        }
    }
}
