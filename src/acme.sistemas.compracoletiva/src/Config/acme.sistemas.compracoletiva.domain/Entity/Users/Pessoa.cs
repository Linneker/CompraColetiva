using acme.sistemas.compracoletiva.domain.Base;
using acme.sistemas.compracoletiva.domain.Enuns;
using acme.sistemas.compracoletiva.domain.Utils;
using System;
using System.Collections.Generic;

namespace acme.sistemas.compracoletiva.domain.Users
{
    public class Pessoa : BaseEntity
    {
        public string Nome { get; set; }
        public string NomeFantasia { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
        public string Telefone { get; set; }
        public DateTime? DataNascimento { get; set; }
        public EnumTipoPessoa TipoPessoa { get; set; }
        public string CPF { get; set; }
        public string CNPJ { get; set; }
        public string InscricaoMunicipal { get; set; }
        
        public virtual ICollection<Usuario> Usuarios { get; set; }
        public virtual ICollection<EnderecoPessoa> EnderecoPessoas { get; set; } = new HashSet<EnderecoPessoa>();
        
        public Pessoa() { }
        public Pessoa(string nome, string nomeFantasia, string email, string celular, string telefone, DateTime? dataNascimento, EnumTipoPessoa tipoPessoa, string cpf, string cnpj, string inscricaoMunicipal)
        {
            Nome = nome;
            NomeFantasia = nomeFantasia;
            Email = email;
            Celular = celular;
            Telefone = telefone;
            DataNascimento = dataNascimento;
            TipoPessoa = tipoPessoa;
            CPF = cpf;
            CNPJ = cnpj;
            InscricaoMunicipal = inscricaoMunicipal;
        }

        public Pessoa(string nome, string email, string celular, string telefone, string cpf, DateTime? dataNascimento = null)
            : this(nome, null, email, celular, telefone, dataNascimento, EnumTipoPessoa.Fisica, cpf, null, null)
        {
        }

        public Pessoa(string nome, string nomeFantasia, string email, string celular, string telefone, string cnpj, 
            string inscricaoMunicipal, DateTime? dataNascimento = null)
            : this(nome, nomeFantasia, email, celular, telefone, dataNascimento, EnumTipoPessoa.Juridica, null, cnpj, inscricaoMunicipal)
        {
        }

    }
}
