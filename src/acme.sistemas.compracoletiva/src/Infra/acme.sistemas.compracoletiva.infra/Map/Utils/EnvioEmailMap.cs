using acme.sistemas.compracoletiva.domain.Entity.Utils;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acme.sistemas.compracoletiva.infra.Map.Utils
{
    public class EnvioEmailMap : IEntityTypeConfiguration<EnvioEmail>
    {
        public void Configure(EntityTypeBuilder<EnvioEmail> builder)
        {
            builder.ToTable("EnvioEmail");
            builder.HasKey(t => t.Id);

            builder.Property(t => t.DataCriacao).IsRequired().ValueGeneratedOnAdd().HasDefaultValueSql("GETDATE()");
            builder.Property(t => t.DataModificacao).IsRequired().ValueGeneratedOnAddOrUpdate().HasDefaultValueSql("GETDATE()")
                .Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Save);
            builder.Property(t => t.UsuarioCriacaoId);
            builder.Property(t => t.UsuarioModificacaoId);
            builder.Property(t => t.Ativo).HasDefaultValue(true);


            builder.Property(t => t.Corpo);
            builder.Property(t => t.Titulo).HasMaxLength(100);

            builder.HasOne(t => t.Remetente).WithMany(t=>t.EnvioEmails).HasForeignKey(t=>t.RemetenteId);

        }
    }
}
