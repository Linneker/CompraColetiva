using acme.sistemas.compracoletiva.domain.Entity.Users;
using acme.sistemas.compracoletiva.core.Base;
using System;

namespace acme.sistemas.compracoletiva.domain.Entity.Location
{
    public class EnderecoPessoa : BaseEntity, IAggregateRoot
    {
        public int Numero { get; set; }
        public string Complemento { get; set; }

        public string Latitude { get; set; }
        public string Longitude{ get; set; }

        public Guid PessoaId{ get; set; }
        public Guid EnederecoId { get; set; }
        
        public Pessoa Pessoa { get; set; }
        public Endereco Endereco { get; set; }

    }
}
