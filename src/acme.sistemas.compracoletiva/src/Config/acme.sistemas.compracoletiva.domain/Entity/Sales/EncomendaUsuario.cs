using acme.sistemas.compracoletiva.core.Base;
using acme.sistemas.compracoletiva.domain.Entity.Users;
using acme.sistemas.compracoletiva.domain.Entity.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acme.sistemas.compracoletiva.domain.Entity.Sales
{
    public class EncomendaUsuario : BaseEntity, IAggregateRoot
    {
        protected EncomendaUsuario()
        {

        }

        public Guid IdReserva { get; private set; }
        public Guid IdUsuario { get; private set; }

        public DateTime Validade { get; private set; }
        public Reserva Reservas { get; private set; }
        public Usuario Usuarios { get; private set; }
    }
}
