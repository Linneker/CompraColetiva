using acme.sistemas.compracoletiva.domain.Entity.Location;
using acme.sistemas.compracoletiva.domain.Interfaces.Repository.Utils;
using acme.sistemas.compracoletiva.infra.Config;

namespace acme.sistemas.compracoletiva.repository.Utils
{
    public class EnderecoRepository : BaseRepository<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(Context db) : base(db)
        {
        }
    }
}
