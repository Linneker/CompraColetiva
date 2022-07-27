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
    public class Encomenda : BaseEntity, IAggregateRoot
    {
        protected Encomenda()
        {

        }

        public Encomenda(Guid usuarioClienteId, Guid produtoId)
        {
            UsuarioClienteId = usuarioClienteId;
            ProdutoId = produtoId; 
        }

        public Guid UsuarioClienteId { get; set; }
        public Guid UsuarioFornecedorId { get; set; }
        public Guid ProdutoId { get; set; }
        public DateTime Validade { get; private set; }

        public virtual Usuario UsuarioCliente { get; set; }
        public virtual Usuario UsuarioFornecedor { get; set; }
        public virtual Produto Produto { get; set; }

        public void Atualizar(Encomenda encomenda)
        {
            if (this.UsuarioClienteId != encomenda.UsuarioClienteId)
                UsuarioClienteId = encomenda.UsuarioClienteId;

            if (this.UsuarioFornecedorId != encomenda.UsuarioFornecedorId)
                UsuarioFornecedorId = encomenda.UsuarioFornecedorId;

            if (this.ProdutoId != encomenda.ProdutoId)
                ProdutoId = this.ProdutoId;

            if (this.Validade != encomenda.Validade)
                Validade = encomenda.Validade;

            base.Atualizar(encomenda.UsuarioModificacaoId);
        }

        public void Encomendar(Guid usuarioFornecedorId, Guid produtoId)
        {
            UsuarioFornecedorId = usuarioFornecedorId;
            ProdutoId = produtoId;
        }
    }
}
