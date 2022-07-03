using acme.sistemas.compracoletiva.core.Interfaces.Service.Utils;
using acme.sistemas.compracoletiva.domain.Entity.Location;
using acme.sistemas.compracoletiva.domain.Interfaces.Repository.Utils;
using AutoMapper;

namespace acme.sistemas.compracoletiva.service.Service.Location
{
    public class EnderecoService : BaseService<Endereco>, IEnderecoService
    {
        private readonly IEnderecoRepository _enderecoRepository;
        private readonly IMapper _mapper;

        public EnderecoService(IEnderecoRepository enderecoRepository, IMapper mapper) : base(enderecoRepository, mapper)
        {
            _enderecoRepository = enderecoRepository;
            _mapper = mapper;
        }
    }
}
