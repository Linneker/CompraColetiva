using acme.sistemas.compracoletiva.core.Interfaces.Service.User;
using acme.sistemas.compracoletiva.domain.Entity.Users;
using acme.sistemas.compracoletiva.domain.Interfaces.Repository.User;
using AutoMapper;

namespace acme.sistemas.compracoletiva.service.Service.Users
{
    public class PessoaService : BaseService<Pessoa>, IPessoaService
    {
        private readonly IPessoaRepository _pessoaRepository;
        private readonly IMapper _mapper;

        public PessoaService(IPessoaRepository pessoaRepository,
            IMapper mapper) : base(pessoaRepository, mapper)
        {
            _pessoaRepository = pessoaRepository;
            _mapper = mapper;
        }
    }
}
