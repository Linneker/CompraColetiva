using acme.sistemas.compracoletiva.domain.Entity.Location;
using acme.sistemas.compracoletiva.domain.Interfaces.Repository.Utils;
using acme.sistemas.compracoletiva.infra.Config;

namespace acme.sistemas.compracoletiva.repository.Utils
{
    public class EnderecoPessoaRepository : BaseRepository<EnderecoPessoa>, IEnderecoPessoaRepository
    {
        public EnderecoPessoaRepository(Context db) : base(db)
        {
        }
    }
}
