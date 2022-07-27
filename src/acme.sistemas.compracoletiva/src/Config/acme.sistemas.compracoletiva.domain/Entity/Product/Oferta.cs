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


        public void Atualizar(Oferta oferta)
        {
            if (this.Titulo != oferta.Titulo)
                Titulo = oferta.Titulo;

            if (this.Descricao != oferta.Descricao)
                Descricao = oferta.Descricao;

            if (this.Condicao != oferta.Condicao)
                Condicao = oferta.Condicao;

            if (this.PalavraChavePesquisa != oferta.PalavraChavePesquisa)
                PalavraChavePesquisa = oferta.PalavraChavePesquisa;

            if (this.DataInicio != oferta.DataInicio)
                DataInicio = oferta.DataInicio;

            if (this.DataTermino != oferta.DataTermino)
                DataTermino = oferta.DataTermino;

            if (this.ValorProduto != oferta.ValorProduto)
                ValorProduto = oferta.ValorProduto;

            if (this.ValorComDesconto != oferta.ValorComDesconto)
                ValorComDesconto = oferta.ValorComDesconto;

            if (this.QuantidadeOfertaDisponivel != oferta.QuantidadeOfertaDisponivel)
                QuantidadeOfertaDisponivel = oferta.QuantidadeOfertaDisponivel;

            if (this.Fornecedor != oferta.Fornecedor)
                Fornecedor = oferta.Fornecedor;

            if (this.Comprador != oferta.Comprador)
                Comprador = oferta.Comprador;

            if (this.UsuarioId != oferta.UsuarioId)
                UsuarioId = oferta.UsuarioId;

            base.Atualizar(oferta.UsuarioModificacaoId);
        }


        public void Ofertar(string titulo, string descricao, string condicao, DateTime dataInicio,
                            DateTime dataTermino, decimal valorProduto, decimal valorComDesconto,
                            int quantidadeOfertaDisponivel)
        {
            Titulo = titulo;
            Descricao = descricao;
            Condicao = condicao;
            DataInicio = dataInicio;
            DataTermino = dataTermino;
            ValorProduto = valorProduto;
            ValorComDesconto = valorComDesconto;
            QuantidadeOfertaDisponivel = quantidadeOfertaDisponivel;
        }
    }
}
