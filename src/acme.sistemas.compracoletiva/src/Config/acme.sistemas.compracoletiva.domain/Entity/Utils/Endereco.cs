﻿
using acme.sistemas.compracoletiva.domain.Interfaces.Aggregate;
using System.Collections.Generic;

namespace acme.sistemas.compracoletiva.domain.Entity.Utils
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
    }
}
