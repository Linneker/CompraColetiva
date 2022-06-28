using acme.sistemas.compracoletiva.domain.Entity.Users;
using acme.sistemas.compracoletiva.domain.Interfaces.Repository.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acme.sistemas.compracoletiva.repository.Users
{
    public class PessoaRepository : BaseRepository<Pessoa>, IPessoaRepository
    {
        private readonly IPessoaRepository _pessoaRepository;

        public PessoaRepository(IPessoaRepository pessoaRepository) : base(pessoaRepository)
        {
            _pessoaRepository = pessoaRepository;
        }
    }
}
