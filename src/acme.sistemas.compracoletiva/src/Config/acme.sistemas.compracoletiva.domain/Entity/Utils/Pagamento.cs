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

        public DateTime DataPagamento { get; set; }
        public DateTime DataEmQueDinheiroCaiNaConta { get; set; }
        public string NomePagador { get; set; }
        public decimal ValorRecebido { get; set; }
        public decimal ValorAReceber { get; set; }
        public DateTime DataPrevistaPagamento { get; set; }
        public DateTime DataVencimento { get; set; }
        public Guid? UsuarioId { get; set; }
    }
}
