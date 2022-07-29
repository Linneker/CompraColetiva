using acme.sistemas.compracoletiva.domain.Entity.Product;
using acme.sistemas.compracoletiva.domain.Entity.Users;
using acme.sistemas.compracoletiva.core.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acme.sistemas.compracoletiva.domain.Entity.Sales
{
    public class Reserva : BaseEntity, IAggregateRoot
    {
        protected Reserva()
        {

        }
        public Reserva(DateTime prazo, int quantidade, DateTime expiracao)
        {
            Prazo = prazo;
            Quantidade = quantidade;
            Expiracao = expiracao;
        }

        public Reserva(   Guid fornecedorUsuarioId, Guid produtoId, Guid clienteUsuarioId) 
        {
            FornecedorUsuarioId = fornecedorUsuarioId;
            ProdutoId = produtoId;
            ClienteUsuarioId = clienteUsuarioId;
        }

        public DateTime Prazo { get; set; }
        public int Quantidade { get; set; }
        public DateTime Expiracao { get; set; }
        public Guid FornecedorUsuarioId { get; set; }
        public Guid ProdutoId { get; set; }
        public Guid ClienteUsuarioId { get; private set; }

        public virtual Usuario ForncedorUsuario { get; set; }
        public virtual Produto Produto { get; set; }
        public virtual Usuario ClienteUsuario { get; set; }

        public void Atualizar(Reserva reserva)
        {
            if (this.Prazo != reserva.Prazo)
                Prazo = reserva.Prazo;
            if(this.Expiracao != reserva.Expiracao)
                Expiracao = reserva.Expiracao;
            if(this.Quantidade != reserva.Quantidade)
                Quantidade = reserva.Quantidade;
            if(this.ClienteUsuarioId != reserva.ClienteUsuarioId)
                ClienteUsuarioId = reserva.ClienteUsuarioId;
            if(this.FornecedorUsuarioId != reserva.FornecedorUsuarioId)
                FornecedorUsuarioId= reserva.FornecedorUsuarioId;
            if(this.ProdutoId != reserva.ProdutoId)
                ProdutoId = reserva.ProdutoId;

            base.Atualizar(reserva.UsuarioModificacaoId);
        }
        public void ReservarProduto(Guid produtoId, Guid clienteUsuarioId,Guid fornecedorUsuarioId)
        {
            ProdutoId = produtoId;
            ClienteUsuarioId = clienteUsuarioId;
            FornecedorUsuarioId = fornecedorUsuarioId;
        }
    }
    
}
