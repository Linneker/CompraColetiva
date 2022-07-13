using acme.sistemas.compracoletiva.domain.Entity.Utils;
using acme.sistemas.compracoletiva.core.Base;
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
        public Produto(string nome, decimal valorCompra, decimal valorVenda, int prazo, int ticketMinimo, decimal valorUnitario,
            int quantidade, int quantidadeTotalDisponivel)
        {
            Nome = nome;
            ValorCompra = valorCompra;
            ValorVenda = valorVenda;
            TicketMinimo = ticketMinimo;
            Prazo = prazo;
            ValorUnitario = valorUnitario;
            QuantidadeTotalDisponivel = quantidadeTotalDisponivel;
            Quantidade = quantidade;

        }


        public string Nome { get; private set; }
        public decimal ValorCompra { get; private set; }
        public decimal ValorVenda { get; private set; }
        public int Prazo { get; private set; }
        public int TicketMinimo { get; private set; }
        public decimal ValorUnitario { get; private set; }
        public int Quantidade { get; private set; }
        public int QuantidadeTotalDisponivel { get; private set; }
        public TipoProduto TipoProduto { get; private set; }
        public Guid TipoProdutoId { get; private set; }
        public virtual ICollection<Reserva> ListaDeReserva { get; private set; } = new HashSet<Reserva>();

    }
    
}
