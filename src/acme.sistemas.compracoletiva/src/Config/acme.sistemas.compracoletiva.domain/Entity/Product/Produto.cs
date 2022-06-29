using acme.sistemas.compracoletiva.domain.Interfaces.Aggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acme.sistemas.compracoletiva.domain.Entity.Product
{
    public class Produto : BaseEntity, IAggregateRoot
    {
        protected Produto()
        {

        }
        public Produto(string nome, decimal valorCompra, decimal valorVenda, int prazo, int ticketMedio, decimal valorUnitario)
        {
            Nome = nome;
            ValorCompra = valorCompra;
            ValorVenda = valorVenda;
            TicketMinimo = ticketMedio;
            Prazo = prazo;
            ValorUnitario = valorUnitario;
        }


        public string Nome { get; private set; }
        public decimal ValorCompra { get; private set; }
        public decimal ValorVenda { get; private set; }
        public int Prazo { get; private set; }
        public int TicketMinimo { get; private set; }
        public decimal ValorUnitario { get; private set; }
    }
    
}
