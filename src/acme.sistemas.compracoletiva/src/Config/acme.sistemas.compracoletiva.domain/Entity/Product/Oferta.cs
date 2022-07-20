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

        public string Titulo { get; set; }   
        public string Descricao { get; set; }
        public string Condicao { get; set; }
        public string PalavraChavePesquisa { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }
        public decimal ValorProduto { get; set; }
        public decimal ValorComDesconto { get; set; }
        public int QuantidadeOfertaDisponivel { get; set; }
        public bool Fornecedor { get; set; }
        public bool Comprador { get; set; }
        public Guid UsuarioId { get; set; }

        public Usuario Usuario { get; set; }
    }
}
