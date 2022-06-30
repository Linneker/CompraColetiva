﻿using acme.sistemas.compracoletiva.domain.Entity.Utils;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acme.sistemas.compracoletiva.infra.Map.Order
{
    internal class EncomendaMap : IEntityTypeConfiguration<Encomenda>
    {
        public void Configure(EntityTypeBuilder<Encomenda> builder)
        {
            builder.ToTable("Encomenda");
            builder.HasKey(t => t.Id);

            builder.Property(t => t.DataCriacao).IsRequired().ValueGeneratedOnAdd().HasDefaultValueSql("GETDATE()");
            builder.Property(t => t.DataModificacao).IsRequired().ValueGeneratedOnAddOrUpdate().HasDefaultValueSql("GETDATE()")
                .Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Save);
            builder.Property(t => t.UsuarioCriacaoId);
            builder.Property(t => t.UsuarioModificacaoId);
            builder.Property(t => t.Ativo).HasDefaultValue(true);
        }
    }
}
