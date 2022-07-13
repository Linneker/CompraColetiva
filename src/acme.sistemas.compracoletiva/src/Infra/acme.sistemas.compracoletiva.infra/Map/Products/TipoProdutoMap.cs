﻿using acme.sistemas.compracoletiva.domain.Entity.Product;
using acme.sistemas.compracoletiva.domain.Entity.Utils;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acme.sistemas.compracoletiva.infra.Map.Products
{
    public class TipoProdutoMap : IEntityTypeConfiguration<TipoProduto>
    {
        public void Configure(EntityTypeBuilder<TipoProduto> builder)
        {
            builder.ToTable("TipoProduto");

            builder.HasKey(t => t.Id);

            builder.Property(t => t.DataCriacao).IsRequired().ValueGeneratedOnAdd().HasDefaultValueSql("NOW()");
            builder.Property(t => t.DataModificacao).IsRequired().ValueGeneratedOnAddOrUpdate().HasDefaultValueSql("NOW()")
                .Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Save);
            builder.Property(t => t.UsuarioCriacaoId);
            builder.Property(t => t.UsuarioModificacaoId);
            builder.Property(t => t.Ativo).HasDefaultValue(true);



            builder.Property(t => t.Nome).HasPrecision(500).IsRequired();
            builder.Property(t => t.Descricao).HasPrecision(500).IsRequired();


        }
    }
}
