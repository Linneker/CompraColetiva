﻿using acme.sistemas.compracoletiva.core.Interfaces.Service.Utils;
using acme.sistemas.compracoletiva.domain.Entity.Utils;
using Microsoft.AspNetCore.Mvc;

namespace acme.sistemas.compracoletiva.api.Controllers.Utils
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : BaseController<Email>
    {
        private readonly IEmailService _emailService;

        public EmailController (IEmailService emailService) : base(emailService)
        {
            _emailService = emailService;
        }
    }
}
