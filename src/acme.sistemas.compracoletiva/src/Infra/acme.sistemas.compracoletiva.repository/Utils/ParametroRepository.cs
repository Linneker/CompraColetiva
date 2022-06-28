using acme.sistemas.compracoletiva.domain.Entity.Utils;
using acme.sistemas.compracoletiva.domain.Interfaces.Repository.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acme.sistemas.compracoletiva.repository.Utils
{
    public class ParametroRepository : BaseRepository<Parametro>, IParametroRepository
    {
        private readonly IParametroRepository _parametroRepository;

        public ParametroRepository(IParametroRepository parametroRepository): base(parametroRepository)
        {
            _parametroRepository = parametroRepository;
        }
    }
}
