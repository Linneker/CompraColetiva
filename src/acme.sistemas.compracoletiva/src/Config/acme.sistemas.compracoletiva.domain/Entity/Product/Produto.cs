using acme.sistemas.compracoletiva.domain.Entity.Utils;
using acme.sistemas.compracoletiva.core.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using acme.sistemas.compracoletiva.domain.Entity.Sales;

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


        public string Nome { get; set; }
        public decimal ValorCompra { get; set; }
        public decimal ValorVenda { get; set; }
        public int Prazo { get; set; }
        public int TicketMinimo { get; set; }
        public decimal ValorUnitario { get; set; }
        public int Quantidade { get; set; }
        public int QuantidadeTotalDisponivel { get; set; }
        public Guid TipoProdutoId { get; set; }

        public TipoProduto TipoProduto { get; set; }
        public virtual ICollection<Reserva> ListaDeReserva { get; set; } = new HashSet<Reserva>();
        public virtual ICollection<ProdutoUsuario> ProdutoUsuarios { get; set; } = new HashSet<ProdutoUsuario>();
        public virtual ICollection<CompraProduto> CompraProduto { get; set; } = new HashSet<CompraProduto>();
        public virtual ICollection<Encomenda> Encomendas { get; set; } = new HashSet<Encomenda>();
    }

}
