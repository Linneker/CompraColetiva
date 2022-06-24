using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace acme.sistemas.compracoletiva.domain
{
    [NotMapped]
    public  class BaseEntity
    {
        public Guid Id { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataModificacao { get; set; }
        public bool Ativo { get; set; }
        public Guid? UsuarioCriacaoId { get; set; }
        public Guid? UsuarioModificacaoId { get; set; }

        protected BaseEntity()
        {
            Id = Guid.NewGuid();
            Ativo = true;
            DataCriacao = DateTime.Now;
        }

        public virtual void Ativar() => SetAtivo(true);
        public virtual void Inativar() => SetAtivo(false);

        private void SetAtivo(bool ativo) => Ativo = ativo;
    }
}
