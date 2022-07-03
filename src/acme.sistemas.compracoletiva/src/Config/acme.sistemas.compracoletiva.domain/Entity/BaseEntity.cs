using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace acme.sistemas.compracoletiva.domain.Entity
{
    [NotMapped]
    public abstract class BaseEntity
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

        protected BaseEntity(Guid id, DateTime dataCriacao, bool ativo, Guid? usuarioCriacaoId, Guid? usuarioModificacaoId)
        {
            Id = id;
            DataCriacao = dataCriacao;
            DataModificacao = DateTime.Now;
            Ativo = ativo;
            UsuarioCriacaoId = usuarioCriacaoId;
            UsuarioModificacaoId = usuarioModificacaoId;
        }

        public virtual void Ativar() => SetAtivo(true);
        public virtual void Inativar() => SetAtivo(false);

        private void SetAtivo(bool ativo) => Ativo = ativo;
    }
}
