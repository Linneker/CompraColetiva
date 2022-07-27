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
        public Produto(string nome, decimal valorCompra, int prazo, int ticketMinimo, decimal valorUnitario,
            int quantidade, int quantidadeTotalDisponivel)
        {
            Nome = nome;
            Valor = valorCompra;
            TicketMinimo = ticketMinimo;
            Prazo = prazo;
            ValorUnitario = valorUnitario;
            QuantidadeTotalDisponivel = quantidadeTotalDisponivel;
            Quantidade = quantidade;

        }


        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public int Prazo { get; set; }
        public int TicketMinimo { get; set; }
        public decimal ValorUnitario { get; set; }
        public int Quantidade { get; set; }
        public int QuantidadeTotalDisponivel { get; set; }
        public Guid TipoProdutoId { get; set; }

        public TipoProduto TipoProduto { get; set; }
        public virtual ICollection<Reserva> ListaDeReserva { get; set; } = new HashSet<Reserva>();
        public virtual ICollection<ProdutoUsuario> ProdutoUsuarios { get; set; } = new HashSet<ProdutoUsuario>();
        public virtual ICollection<CompraProduto> CompraProdutos { get; set; } = new HashSet<CompraProduto>();
        public virtual ICollection<Encomenda> Encomendas { get; set; } = new HashSet<Encomenda>();


        public void Atualizar(Produto produto)
        {
            if (this.Nome != produto.Nome)
                Nome = produto.Nome;

            if(this.Valor != produto.Valor)
                Valor = produto.Valor;

            if (this.Prazo != produto.Prazo)
                Prazo = produto.Prazo;

            base.Atualizar(produto.UsuarioModificacaoId);
        }
    }

}
