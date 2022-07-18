using acme.sistemas.compracoletiva.domain.Entity.Location;
using acme.sistemas.compracoletiva.domain.Entity.Utils;
using acme.sistemas.compracoletiva.core.Base;
using System;
using System.Collections.Generic;
using acme.sistemas.compracoletiva.core.Enuns;

namespace acme.sistemas.compracoletiva.domain.Entity.Users
{
    public class Pessoa : BaseEntity, IAggregateRoot
    {
        public string Nome { get; set; }
        public string NomeFantasia { get; set; }
        public string Celular { get; set; }
        public string Telefone { get; set; }
        public DateTime? DataNascimento { get; set; }
        public EnumTipoPessoa TipoPessoa { get; set; }
        public string CPF { get; set; }
        public string CNPJ { get; set; }
        public string InscricaoMunicipal { get; set; }
        public Guid EmailId { get; set; }

        public virtual Email Email { get; set; }


        public virtual ICollection<Usuario> Usuarios { get; set; }
        public virtual ICollection<EnderecoPessoa> EnderecoPessoas { get; set; } = new HashSet<EnderecoPessoa>();

        public void SetEnderecoPessoas(ICollection<EnderecoPessoa> enderecosPessoas) =>
            EnderecoPessoas = enderecosPessoas;
        public void SetEmailId(Guid emailId) => EmailId = emailId;
        public void SetEmail(Email email) => Email = email;

        public void AddEnderecoPessoa(EnderecoPessoa enderecosPessoa) =>
            EnderecoPessoas.Add(enderecosPessoa);
        protected Pessoa() { }
        public Pessoa(string nome, string nomeFantasia, string celular, string telefone, DateTime? dataNascimento, EnumTipoPessoa tipoPessoa, string cpf, string cnpj, string inscricaoMunicipal)
        {
            Nome = nome;
            NomeFantasia = nomeFantasia;
            Celular = celular;
            Telefone = telefone;
            DataNascimento = dataNascimento;
            TipoPessoa = tipoPessoa;
            CPF = cpf;
            CNPJ = cnpj;
            InscricaoMunicipal = inscricaoMunicipal;
        }

        public Pessoa(string nome, string email, string celular, string telefone, string cpf, DateTime? dataNascimento = null)
            : this(nome, null, celular, telefone, dataNascimento, EnumTipoPessoa.Fisica, cpf, null, null)
        {
        }

        public Pessoa(string nome, string nomeFantasia, string email, string celular, string telefone, string cnpj, 
            string inscricaoMunicipal, DateTime? dataNascimento = null)
            : this(nome, nomeFantasia, celular, telefone, dataNascimento, EnumTipoPessoa.Juridica, null, cnpj, inscricaoMunicipal)
        {
        }

    }
}
