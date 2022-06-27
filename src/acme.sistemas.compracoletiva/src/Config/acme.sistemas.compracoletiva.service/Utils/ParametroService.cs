using acme.sistemas.compracoletiva.core.Interfaces.Utils;
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
    public class ParametroService : BaseService<Parametro>, IParametroService
    {
        private readonly IParametroRepository _parametroRepository;

        public ParametroService(IParametroRepository parametroRepository) : base(parametroRepository)
        {
            _parametroRepository = parametroRepository;
        }
    }
}
