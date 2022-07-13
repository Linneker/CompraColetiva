using acme.sistemas.compracoletiva.domain.Entity.Users;
using acme.sistemas.compracoletiva.core.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acme.sistemas.compracoletiva.domain.Entity.Product
{
    public class Oferta : BaseEntity, IAggregateRoot
    {
        public Oferta()
        {

        }

        public string Titulo { get; private set; }
        public Usuario Usuario { get; private set; }
        public Guid UsuarioId { get; private set; }
        public string Descricao { get; private set; }
        public string Condicao { get; private set; }
        public string PalavraChavePesquisa { get; private set; }
        public DateTime DataInicio { get; private set; }
        public DateTime DataTermino { get; private set; }
        public decimal ValorProduto { get; private set; }
        public decimal ValorComDesconto { get; private set; }
        public int QuantidadeOfertaDisponivel { get; private set; }
    }
}
