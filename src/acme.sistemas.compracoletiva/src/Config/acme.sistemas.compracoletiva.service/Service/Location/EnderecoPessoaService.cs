﻿using acme.sistemas.compracoletiva.core.Interfaces.Service.Location;
using acme.sistemas.compracoletiva.domain.Entity.Location;
using acme.sistemas.compracoletiva.domain.Interfaces.Repository.Location;
using AutoMapper;

namespace acme.sistemas.compracoletiva.service.Service.Location
{
    public class EnderecoPessoaService : BaseService<EnderecoPessoa>, IEnderecoPessoaService
    {
        private readonly IEnderecoPessoaRepository _enderecoPessoaRepository;
        private readonly IMapper _mapper;

        public EnderecoPessoaService(IEnderecoPessoaRepository enderecoPessoaRepository,
            IMapper mapper) : base(enderecoPessoaRepository)
        {
            _enderecoPessoaRepository = enderecoPessoaRepository;
            _mapper = mapper;
        }
    }
}
