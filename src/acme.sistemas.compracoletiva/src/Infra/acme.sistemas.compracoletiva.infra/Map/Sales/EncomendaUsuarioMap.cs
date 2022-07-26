using acme.sistemas.compracoletiva.domain.Entity.Sales;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acme.sistemas.compracoletiva.infra.Map.Sales
{
    public class EncomendaUsuarioMap : IEntityTypeConfiguration<EncomendaUsuario>
    {
        public void Configure(EntityTypeBuilder<EncomendaUsuario> builder)
        {
            builder.ToTable("EncomendaUsuario");
            builder.HasKey(t => t.Id);

            builder.Property(t => t.DataCriacao).IsRequired();
            builder.Property(t => t.DataModificacao).IsRequired()
                .Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Save);
            builder.Property(t => t.UsuarioCriacaoId);
            builder.Property(t => t.UsuarioModificacaoId);
            builder.Property(t => t.Ativo).HasDefaultValue(true);

            builder.HasOne(t => t.Usuarios).WithMany(t => t.IndvUsuarios).HasForeignKey(t => t.IdUsuario);
            builder.HasOne(t => t.Reservas).WithMany(t => t.IndvReservas).HasForeignKey(t => t.IdReserva);
        }
    }
}
