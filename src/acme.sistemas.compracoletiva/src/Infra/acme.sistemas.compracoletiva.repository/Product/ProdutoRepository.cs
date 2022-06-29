using acme.sistemas.compracoletiva.domain.Entity;
using acme.sistemas.compracoletiva.domain.Interfaces.Aggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acme.sistemas.compracoletiva.repository.Product
{
    public class ProdutoRepository : BaseEntity, IAggregateRoot
    {
        protected ProdutoRepository()
        {

        }
        public ProdutoRepository(string nome, decimal valorCompra, decimal valorVenda, int quantidade, int ticketMedio)
        {
            Nome = nome;
            ValorCompra = valorCompra;
            ValorVenda = valorVenda;
            TicketMedio = ticketMedio;
            Quantidade = quantidade;
        }
        public string Nome { get; private set; }
        public decimal ValorCompra { get; private set; }
        public decimal ValorVenda { get; private set; }
        public int Quantidade { get; private set; }
        public int TicketMedio { get; private set; }
    }
}
