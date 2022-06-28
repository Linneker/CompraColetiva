using acme.sistemas.compracoletiva.domain.Entity.Utils;
using acme.sistemas.compracoletiva.domain.Interfaces.Repository.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acme.sistemas.compracoletiva.repository.Utils
{
    public class EnderecoPessoaRepository : BaseRepository<EnderecoPessoa>, IEnderecoPessoaRepository
    {
        private readonly IEnderecoPessoaRepository _enderecoPessoaRepository;

        public EnderecoPessoaRepository(IEnderecoPessoaRepository enderecoPessoaRepository) : base(enderecoPessoaRepository)
        {
            _enderecoPessoaRepository = enderecoPessoaRepository;
        }
    }
}
