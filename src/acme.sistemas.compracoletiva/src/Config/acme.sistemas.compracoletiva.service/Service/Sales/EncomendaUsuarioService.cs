using acme.sistemas.compracoletiva.domain.Entity.Sales;
using acme.sistemas.compracoletiva.domain.Interfaces.Repository.Sales;
using acme.sistemas.compracoletiva.service.Interfaces.Service.Sales;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acme.sistemas.compracoletiva.service.Service.Sales
{
    public class EncomendaUsuarioService : BaseService<EncomendaUsuario>, IEncomendaUsuarioService
    {
        private readonly IEncomendaUsuarioRepository _encomendaUsuarioRepository;
        private readonly IMapper _Mapper;

        public EncomendaUsuarioService(IEncomendaUsuarioRepository encomendaUsuarioRepository, IMapper mapper) : base (encomendaUsuarioRepository)
        {
            _encomendaUsuarioRepository = encomendaUsuarioRepository;
            _Mapper = mapper;
        }


    }
}
