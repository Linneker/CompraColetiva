using acme.sistemas.compracoletiva.domain.Entity.Utils;
using acme.sistemas.compracoletiva.domain.Interfaces.Repository.Package;
using acme.sistemas.compracoletiva.infra.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acme.sistemas.compracoletiva.repository.Package
{
    public class PacoteRepository : BaseRepository<Pacote>, IPacoteRepository
    {
        public PacoteRepository(Context db) : base(db)
        {

        }
    }
}
