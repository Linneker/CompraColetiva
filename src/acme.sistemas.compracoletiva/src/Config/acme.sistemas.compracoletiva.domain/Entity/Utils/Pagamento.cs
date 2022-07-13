using acme.sistemas.compracoletiva.core.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acme.sistemas.compracoletiva.domain.Entity.Utils
{
    public class Pagamento : BaseEntity, IAggregateRoot
    {
        protected Pagamento()
        {

        }

        public DateTime DataPagamento { get; private set; }
        public DateTime DataEmQueDinheiroCaiNaConta { get; private set; }
        public string NomePagador { get; private set; }
        public decimal ValorRecebido { get; private set; }
        public decimal ValorAReceber { get; private set; }
        public DateTime DataPrevistaPagamento { get; private set; }
        public DateTime DataVencimento { get; private set; }
        public Guid? UsuarioId { get; private set; }
    }
}
