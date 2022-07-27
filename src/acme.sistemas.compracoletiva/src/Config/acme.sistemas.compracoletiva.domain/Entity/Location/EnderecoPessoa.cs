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

        public void Atualizar(EnderecoPessoa enderecoPessoa)
        {
            if(this.Numero != enderecoPessoa.Numero)
                Numero = enderecoPessoa.Numero;

            if (this.Complemento != enderecoPessoa.Complemento)
                Complemento = enderecoPessoa.Complemento;

            if (this.Latitude != enderecoPessoa.Latitude)
                Latitude = enderecoPessoa.Latitude;

            if (this.Longitude != enderecoPessoa.Longitude)
                Longitude = enderecoPessoa.Longitude;

            if (this.PessoaId != enderecoPessoa.PessoaId)
                PessoaId = enderecoPessoa.PessoaId;

            if (this.EnederecoId != enderecoPessoa.EnederecoId)
                EnederecoId = enderecoPessoa.EnederecoId;

            base.Atualizar(enderecoPessoa.UsuarioModificacaoId);
        }

    }
}
