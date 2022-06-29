﻿using acme.sistemas.compracoletiva.domain.Entity;
using acme.sistemas.compracoletiva.domain.Entity.Product;
using acme.sistemas.compracoletiva.domain.Interfaces.Aggregate;
using acme.sistemas.compracoletiva.domain.Interfaces.Repository;
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
    public class ProdutoMap : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("Produto");
            builder.HasKey(t => t.Id);

            builder.Property(t => t.DataCriacao).IsRequired().ValueGeneratedOnAdd().HasDefaultValueSql("GETDATE()");
            builder.Property(t => t.DataModificacao).IsRequired().ValueGeneratedOnAddOrUpdate().HasDefaultValueSql("GETDATE()")
                .Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Save);
            builder.Property(t => t.UsuarioCriacaoId);
            builder.Property(t => t.UsuarioModificacaoId);
            builder.Property(t => t.Ativo).HasDefaultValue(true);



            builder.Property(_=>_.Nome).HasMaxLength(500).IsRequired();
            builder.Property(_=>_.ValorCompra).HasMaxLength(30).IsRequired();
            builder.Property(_=>_.ValorVenda).HasMaxLength(30).IsRequired();
            builder.Property(_=>_.Quantidade).HasMaxLength(40).IsRequired();
            builder.Property(_=>_.TicketMedio).HasMaxLength(60).IsRequired();
        }
    }
}
