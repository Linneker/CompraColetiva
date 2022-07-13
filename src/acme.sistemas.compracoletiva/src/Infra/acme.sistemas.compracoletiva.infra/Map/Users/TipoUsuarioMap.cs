using acme.sistemas.compracoletiva.domain.Entity.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace acme.sistemas.compracoletiva.infra.Map.Users
{
    public class TipoUsuarioMap : IEntityTypeConfiguration<TipoUsuario>
    {
        public void Configure(EntityTypeBuilder<TipoUsuario> builder)
        {
            builder.ToTable("TipoUsuario");

            builder.HasKey(t => t.Id);

            builder.Property(t => t.DataCriacao).IsRequired().ValueGeneratedOnAdd().HasDefaultValueSql("NOW()");
            builder.Property(t => t.DataModificacao).IsRequired().ValueGeneratedOnAddOrUpdate().HasDefaultValueSql("NOW()")
                .Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Save);
            builder.Property(t => t.UsuarioCriacaoId);
            builder.Property(t => t.UsuarioModificacaoId);
            builder.Property(t => t.Ativo).HasDefaultValue(true);
            //builder.Property(t => t.ConcurrencyToken).IsRowVersion().ValueGeneratedOnAddOrUpdate().HasDefaultValueSql("NOW()")
            //    .Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Save); ;


            builder.Property(_ => _.Nome);
        }
    }
}
