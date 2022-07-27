
using acme.sistemas.compracoletiva.core.Base;
using System.Collections.Generic;

namespace acme.sistemas.compracoletiva.domain.Entity.Location
{
    public class Endereco : BaseEntity, IAggregateRoot
    {
        public Endereco()
        {
        }
        public string Cep { get; set; }
        public string Pais { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Rua { get; set; }
        public virtual ICollection<EnderecoPessoa> EnderecoPessoas { get; set; } = new HashSet<EnderecoPessoa>();


        public void Atualizar(Endereco endereco)
        {
            if (this.Cep != endereco.Cep)
                Cep = endereco.Cep;

            if (this.Pais != endereco.Pais)
                Pais = endereco.Pais;

            if (this.Estado != endereco.Estado)
                Estado = endereco.Estado;

            if (this.Cidade != endereco.Cidade)
                Cidade = endereco.Cidade;

            if (this.Bairro != endereco.Bairro)
                Bairro = endereco.Bairro;

            if (this.Rua != endereco.Rua)
                Rua = endereco.Rua;

            base.Atualizar(endereco.UsuarioModificacaoId);
        }
    }
}
