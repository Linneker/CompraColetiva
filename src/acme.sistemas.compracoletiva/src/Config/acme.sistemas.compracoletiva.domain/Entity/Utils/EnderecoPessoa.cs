
using acme.sistemas.compracoletiva.domain.Users;
using System;

namespace acme.sistemas.compracoletiva.domain.Utils
{
    public class EnderecoPessoa : BaseEntity
    {
        public int Numero { get; set; }
        public string Complemento { get; set; }

        public string Latitude { get; set; }
        public string Longitude{ get; set; }

        public Guid PessoaId{ get; set; }
        public Guid? EnederecoId { get; set; }
        
        public Pessoa Pessoa { get; set; }
        public Endereco Endereco { get; set; }

    }
}
