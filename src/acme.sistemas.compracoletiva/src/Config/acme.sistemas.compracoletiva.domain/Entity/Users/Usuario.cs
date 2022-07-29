using acme.sistemas.compracoletiva.domain.Entity.Product;
using acme.sistemas.compracoletiva.domain.Entity.Utils;
using acme.sistemas.compracoletiva.core.Base;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using acme.sistemas.compracoletiva.domain.Entity.Sales;

namespace acme.sistemas.compracoletiva.domain.Entity.Users
{
    public class Usuario : IdentityUser<Guid>, IAggregateRoot
    {
        
        public DateTime DataCriacao { get; set; }
        public DateTime DataModificacao { get; set; }
        public bool Ativo { get; set; }
        public Guid? UsuarioCriacaoId { get; set; }
        public Guid? UsuarioModificacaoId { get; set; }

        public Guid PessoaId { get; set; }
        public Guid TipoUsuarioId { get; set; }

        public virtual Pessoa Pessoa { get; set; }
        public virtual TipoUsuario TipoUsuario { get; set; }

        public virtual ICollection<Oferta> Ofertas { get; set; } = new HashSet<Oferta>();
        public virtual ICollection<Reserva> ReservasClientes { get; set; } = new HashSet<Reserva>();
        public virtual ICollection<ProdutoUsuario> ProdutoUsuarios { get; set; } = new HashSet<ProdutoUsuario>();
        public virtual ICollection<CompraProduto> UsuariosVendas { get; set; } = new HashSet<CompraProduto>();
        public virtual ICollection<CompraProduto> UsuariosCompras { get; set; } = new HashSet<CompraProduto>();
        public virtual ICollection<Pagamento> Pagamentos { get; set; } = new HashSet<Pagamento>();
        public virtual ICollection<Notificacao> Notificacoes { get; set; } = new HashSet<Notificacao>();
        public virtual ICollection<Encomenda> RealizaEncomendas { get; set; } = new HashSet<Encomenda>();
        public virtual ICollection<Encomenda> ForneceEncomendas { get; set; } = new HashSet<Encomenda>();
        public virtual ICollection<Reserva> ReservasFornecedores { get; set; } = new HashSet<Reserva>();
        
        
        protected Usuario() { }

        public Usuario(Pessoa pessoa) : base()
        {
            Pessoa = pessoa;
        }

        public Usuario(Pessoa pessoa, TipoUsuario tipoUsuario) : this(pessoa)
        {
            TipoUsuario = tipoUsuario;
        }

        public Usuario(Pessoa pessoa, Guid tipoUsuarioId) : this(pessoa)
        {
            TipoUsuarioId = tipoUsuarioId;
        }
    }
}
