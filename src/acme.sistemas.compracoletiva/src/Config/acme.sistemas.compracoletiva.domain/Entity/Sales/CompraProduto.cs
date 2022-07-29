using acme.sistemas.compracoletiva.core.Base;
using acme.sistemas.compracoletiva.domain.Entity.Product;
using acme.sistemas.compracoletiva.domain.Entity.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acme.sistemas.compracoletiva.domain.Entity.Sales
{
    public class CompraProduto : BaseEntity, IAggregateRoot
    {
        public decimal ValorUnitario { get; set; }
        public decimal Quantidade { get; set; }
        public decimal ValorTotal { get => ValorUnitario * Quantidade; set { } }


        public Guid ProdutoId { get; set; }
        public Guid CompraId { get; set; }
        public Guid UsuarioVendaId { get; set; }
        public Guid UsuarioCompraId { get; set; }


        public Produto Produto { get; set; }
        public Compra Compra { get; set; }
        public Usuario UsuarioVenda { get; set; }
        public Usuario UsuarioCompra { get; set; }



        public void Comprar(Reserva reserva)
        {
            ProdutoId = reserva.ProdutoId;
            ValorUnitario = reserva.Produto.ValorUnitario;
            Quantidade = reserva.Quantidade;
            UsuarioCompraId = reserva.ClienteUsuarioId;
            UsuarioVendaId = reserva.FornecedorUsuarioId;
            Compra = new Compra(Quantidade, ValorTotal);
        }

        public void Atulizar(CompraProduto compraProduto)
        {
            if(this.ValorUnitario != compraProduto.ValorUnitario)
                ValorUnitario = compraProduto.ValorUnitario;

            if (this.Quantidade != compraProduto.Quantidade)
                Quantidade = compraProduto.Quantidade;

            if (this.ValorTotal != compraProduto.ValorTotal)
                ValorTotal = compraProduto.ValorTotal;

            if (this.ProdutoId != compraProduto.ProdutoId)
                ProdutoId = compraProduto.ProdutoId;

            if (this.CompraId != compraProduto.CompraId)
                CompraId = compraProduto.CompraId;

            if (this.UsuarioVendaId != compraProduto.UsuarioVendaId)
                UsuarioVendaId = compraProduto.UsuarioVendaId;

            if (this.UsuarioCompraId != compraProduto.UsuarioCompraId)
                UsuarioCompraId = compraProduto.UsuarioCompraId;

            base.Atualizar(compraProduto.UsuarioModificacaoId);
        }
    }
}
