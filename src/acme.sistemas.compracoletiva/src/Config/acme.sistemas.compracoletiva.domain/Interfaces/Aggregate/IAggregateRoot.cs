using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acme.sistemas.compracoletiva.domain.Interfaces.Aggregate
{
    public interface IAggregateRoot
    {
        Guid Id { get; }
    }
}
