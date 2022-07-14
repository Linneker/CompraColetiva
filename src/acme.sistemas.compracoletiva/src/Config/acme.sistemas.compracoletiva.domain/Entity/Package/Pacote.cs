using acme.sistemas.compracoletiva.core.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acme.sistemas.compracoletiva.domain.Entity.Package
{
    public class Pacote : BaseEntity, IAggregateRoot
    {
        protected Pacote()
        {

        }

        public Pacote(string nome, string descricao, Guid codigo, int preco)
        {

            Nome = nome;
            Descricao = descricao;
            Codigo = codigo;
            Preco = preco;
        }


        public string Nome { get; set; }
        public string Descricao { get; set; }
        public Guid Codigo { get; set; }
        public int Preco { get; set; }
    }
}
