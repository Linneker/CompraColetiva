using acme.sistemas.compracoletiva.domain.Entity.SalesInternal;
using acme.sistemas.compracoletiva.domain.Interfaces.Repository.Package;
using acme.sistemas.compracoletiva.infra.Config;

namespace acme.sistemas.compracoletiva.repository.Package
{
    public class PacoteRepository : BaseRepository<Pacote>, IPacoteRepository
    {
        public PacoteRepository(Context db) : base(db)
        {

        }
    }
}
