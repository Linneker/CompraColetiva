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


        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public Guid Codigo { get; private set; }
        public int Preco { get; private set; }
    }
}
