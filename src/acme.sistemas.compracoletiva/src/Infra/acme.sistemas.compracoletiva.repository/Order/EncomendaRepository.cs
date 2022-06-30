using acme.sistemas.compracoletiva.domain.Entity.Utils;
using acme.sistemas.compracoletiva.domain.Interfaces.Repository.Order;
using acme.sistemas.compracoletiva.infra.Config;
using acme.sistemas.compracoletiva.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acme.sistemas.compracoletiva.service.Order
{
    public class EncomendaRepository : BaseRepository<Encomenda>, IEncomendaRepository
    {
        public EncomendaRepository(Context db) : base(db)
        {
        }
    }
}
