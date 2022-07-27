using acme.sistemas.compracoletiva.core.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acme.sistemas.compracoletiva.domain.Entity.Utils
{
    public class Seguro : BaseEntity, IAggregateRoot
    {
        protected Seguro()
        {

        }

        public string Nome { get; set; }
        public string Empresa { get; set; }
        public decimal Taxa { get; set; }

        

        public void Atualizar(Seguro seguro)
        {
            if (this.Nome != seguro.Nome)
                Nome = seguro.Nome;

            if (this.Empresa != seguro.Empresa)
                Empresa = seguro.Empresa;

            if (this.Taxa != seguro.Taxa)
                Taxa = seguro.Taxa;

            base.Atualizar(seguro.UsuarioModificacaoId);
        }
    }
}
