

using acme.sistemas.compracoletiva.domain.Interfaces.Aggregate;

namespace acme.sistemas.compracoletiva.domain.Entity.Utils
{
    public class Parametro : BaseEntity, IAggregateRoot
    {
        public string Nome { get; set; }
        public string Valor { get; set; }
        public string Descricao { get; set; }

        protected Parametro() { }

        public Parametro(string nome, string valor, string descricao) : base()
        {
            Nome = nome;
            Valor = valor;
            Descricao = descricao;
        }
    }
}
