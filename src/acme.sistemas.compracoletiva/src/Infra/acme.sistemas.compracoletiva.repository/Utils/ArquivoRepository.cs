using acme.sistemas.compracoletiva.core.Utils;
using acme.sistemas.compracoletiva.domain.Entity.Utils;
using acme.sistemas.compracoletiva.domain.Interfaces.Repository.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acme.sistemas.compracoletiva.repository.Utils
{
    public class ArquivoRepository : BaseRepository<Arquivo>, IArquivoRepository
    {
        private readonly IArquivoRepository _arquivoRepository;

        public ArquivoRepository(IArquivoRepository arquivoRepository):base(arquivoRepository)
        {
            _arquivoRepository = arquivoRepository;
        }
    }
}
