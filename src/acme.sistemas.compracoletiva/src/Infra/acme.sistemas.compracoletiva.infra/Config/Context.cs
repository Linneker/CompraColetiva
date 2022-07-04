using acme.sistemas.compracoletiva.domain.Entity.Location;
using acme.sistemas.compracoletiva.domain.Entity.Product;
using acme.sistemas.compracoletiva.domain.Entity.Sales;
using acme.sistemas.compracoletiva.domain.Entity.Security;
using acme.sistemas.compracoletiva.domain.Entity.Users;
using acme.sistemas.compracoletiva.domain.Entity.Utils;
using acme.sistemas.compracoletiva.infra.Map.Users;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acme.sistemas.compracoletiva.infra.Config
{
    public class Context : IdentityDbContext<Usuario, Permissao, Guid, UserClaim, PermissaoUsuario, UserLogin, PermissaoClaim, UserToken>
    {
       
        public Context(DbContextOptions<Context> dbContextOptions) : base(dbContextOptions)
        {
        }

        public DbSet<UnidadeMedidaCompra> UnidadeMedidaCompra { get; set; }
        public DbSet<Reserva> Reserva { get; set; }
        public DbSet<Oferta> Oferta { get; set; }
        public DbSet<TipoUsuario> TipoUsuarios { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Pessoa> Pessoas { get; set; }

        public DbSet<Produto> Produto { get; set; }
        public DbSet<Arquivo> Arquivos { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<EnderecoPessoa> EnderecosPessoa { get; set; }
        public DbSet<Parametro> Parametros { get; set; }

        public DbSet<ConfiguracaoToken> ConfiguracaoTokens { get; set; }
        public DbSet<ConfiguracaoTokenSistema> ConfiguracaoTokenSistemas { get; set; }

        public override DbSet<Usuario> Users { get; set; }
        public override DbSet<Permissao> Roles { get; set; }
        public override DbSet<PermissaoUsuario> UserRoles { get; set; }

        public override DbSet<PermissaoClaim> RoleClaims { get; set; }
        public override DbSet<UserClaim> UserClaims { get; set; }
        public override DbSet<UserLogin> UserLogins { get; set; }
        public override DbSet<UserToken> UserTokens { get; set; }
       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(Context).Assembly);

            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
                relationship.DeleteBehavior = DeleteBehavior.Restrict;

            var stringProperties = modelBuilder.Model.GetEntityTypes()
                .SelectMany(_ => _.GetProperties())
                .Where(_ => _.ClrType == typeof(string) && _.GetColumnType() == null);

            foreach (var item in stringProperties)
            {
                item.SetIsUnicode(false);
                if (item.GetMaxLength() == null)
                    item.SetMaxLength(256);
            }

            var decimalProperties = modelBuilder.Model.GetEntityTypes()
                .SelectMany(_ => _.GetProperties())
                .Where(_ => (_.ClrType == typeof(decimal) || _.ClrType == typeof(decimal?)) && _.GetColumnType() == null);

            foreach (var item in decimalProperties)
            {
                if (item.GetPrecision() == null && item.GetScale() == null)
                {
                    item.SetPrecision(18);
                    item.SetScale(4);
                }
            }
            modelBuilder.Entity<Permissao>().ToTable("Permissao").HasKey(t => t.Id);
            modelBuilder.Entity<PermissaoClaim>().ToTable("PermissaoClaim").HasKey(t => t.Id);
            modelBuilder.Entity<UserClaim>().ToTable("UserClaim").HasKey(t => t.Id);
            modelBuilder.Entity<PermissaoUsuario>().ToTable("UserPermissao").HasKey(t => t.Id);
            modelBuilder.Entity<UserLogin>().ToTable("UserLogin").HasKey(t => t.Id);
            modelBuilder.Entity<UserToken>().ToTable("UserToken").HasKey(t => t.Id);

            base.OnModelCreating(modelBuilder);
        }

    }
}
