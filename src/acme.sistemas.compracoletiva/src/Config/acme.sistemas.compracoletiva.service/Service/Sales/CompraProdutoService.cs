using acme.sistemas.compracoletiva.domain.Entity.Sales;
using acme.sistemas.compracoletiva.domain.Interfaces.Repository.Sales;
using acme.sistemas.compracoletiva.service.Interfaces.Service.Sales;
using AutoMapper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acme.sistemas.compracoletiva.service.Service.Sales
{
    public class CompraProdutoService : BaseService<CompraProduto>, ICompraProdutoService
    {
        private readonly ICompraProdutoRepository _compraRepository;
        private readonly IMapper _mapper;

        public CompraProdutoService(ICompraProdutoRepository compraProdutoRepository, IMapper mapper) : base(compraProdutoRepository)
        {
            _compraRepository = compraProdutoRepository;
            _mapper = mapper;
        }


        public void Comprar(Reserva reserva) 
        {
            CompraProduto compraProduto = new CompraProduto();
            compraProduto.Comprar(reserva);
            _compraRepository.Add(compraProduto);
        }
    }
}
