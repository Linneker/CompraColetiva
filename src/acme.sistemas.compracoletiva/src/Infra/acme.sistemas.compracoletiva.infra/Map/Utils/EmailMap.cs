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
    public class EmailMap : IEntityTypeConfiguration<Email>
    {
        public void Configure(EntityTypeBuilder<Email> builder)
        {
            builder.ToTable("Produto");
            builder.HasKey(t => t.Id);

            builder.Property(t => t.DataCriacao).IsRequired().ValueGeneratedOnAdd().HasDefaultValueSql("GETDATE()");
            builder.Property(t => t.DataModificacao).IsRequired().ValueGeneratedOnAddOrUpdate().HasDefaultValueSql("GETDATE()")
                .Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Save);
            builder.Property(t => t.UsuarioCriacaoId);
            builder.Property(t => t.UsuarioModificacaoId);
            builder.Property(t => t.Ativo).HasDefaultValue(true);


            builder.HasMany(t => t.EnvioEmails).WithMany(t => t.EmailsCopias).UsingEntity<Dictionary<string, object>>("EmailCopias",
                t => t.HasOne<Email>().WithMany().HasForeignKey("EmailId"),
                t => t.HasOne<EnvioEmail>().WithMany().HasForeignKey("EnvioEmailId"),
                t =>
                {
                    t.Property<Guid>("Id");
                    t.HasKey("Id");
                    t.Property<Guid>("EmailId");
                    t.Property<Guid>("EnvioEmailId");
                });
        }
    }
}
