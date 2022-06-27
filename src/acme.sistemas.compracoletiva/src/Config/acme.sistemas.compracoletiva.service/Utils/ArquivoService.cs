﻿using acme.sistemas.compracoletiva.core.Utils;
using acme.sistemas.compracoletiva.domain.Entity.Utils;
using acme.sistemas.compracoletiva.domain.Interfaces.Repository.Utils;
using acme.sistemas.compracoletiva.service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acme.sistemas.compracoletiva.domain.Entity.Classes.Utils
{
    public class ArquivoService : BaseService<Arquivo>, IArquivoService
    {
        private readonly IArquivoRepository _arquivoRepository;

        public ArquivoService(IArquivoRepository arquivoRepository): base(arquivoRepository)
        {
            _arquivoRepository = arquivoRepository;
        }
    }
}
