using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace acme.sistemas.compracoletiva.infra.Migrations
{
    public partial class addmigrationCompraColetiva : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Pessoa");

            migrationBuilder.AddColumn<Guid>(
                name: "EmailId",
                table: "Pessoa",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Compra",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantidade = table.Column<int>(type: "int", precision: 20, nullable: false),
                    Valor = table.Column<int>(type: "int", precision: 20, nullable: false),
                    Produto = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, precision: 20, nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    DataModificacao = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    Ativo = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    UsuarioCriacaoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UsuarioModificacaoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compra", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ConfiguracaoEmail",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ConfigSet = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Host = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Porta = table.Column<int>(type: "int", precision: 10, nullable: false),
                    Ssl = table.Column<bool>(type: "bit", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    DataModificacao = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    Ativo = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    UsuarioCriacaoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UsuarioModificacaoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConfiguracaoEmail", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Email",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    DataModificacao = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    Ativo = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    UsuarioCriacaoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UsuarioModificacaoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Email", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Encomenda",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PessoaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompraId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProdutoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    DataModificacao = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    Ativo = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    UsuarioCriacaoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UsuarioModificacaoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Encomenda", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pacote",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: false),
                    Descricao = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: false),
                    Codigo = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Preco = table.Column<int>(type: "int", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    DataModificacao = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    Ativo = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    UsuarioCriacaoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UsuarioModificacaoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pacote", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoProduto",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: false),
                    Descricao = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    DataModificacao = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    Ativo = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    UsuarioCriacaoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UsuarioModificacaoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoProduto", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmailConfiguracaoEmail",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Senha = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: false),
                    EmailEnvioId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmailRemetenteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ConfiguracaoEmailId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    DataModificacao = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    Ativo = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    UsuarioCriacaoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UsuarioModificacaoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailConfiguracaoEmail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmailConfiguracaoEmail_ConfiguracaoEmail_ConfiguracaoEmailId",
                        column: x => x.ConfiguracaoEmailId,
                        principalTable: "ConfiguracaoEmail",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmailConfiguracaoEmail_Email_EmailEnvioId",
                        column: x => x.EmailEnvioId,
                        principalTable: "Email",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmailConfiguracaoEmail_Email_EmailRemetenteId",
                        column: x => x.EmailRemetenteId,
                        principalTable: "Email",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EnvioEmail",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Titulo = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Corpo = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: false),
                    DestinatarioId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    DataModificacao = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    Ativo = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    UsuarioCriacaoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UsuarioModificacaoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnvioEmail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EnvioEmail_Email_DestinatarioId",
                        column: x => x.DestinatarioId,
                        principalTable: "Email",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Produto",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, precision: 500, nullable: false),
                    ValorCompra = table.Column<decimal>(type: "decimal(20,2)", precision: 20, scale: 2, nullable: false),
                    ValorVenda = table.Column<decimal>(type: "decimal(20,2)", precision: 20, scale: 2, nullable: false),
                    Prazo = table.Column<int>(type: "int", precision: 20, nullable: false),
                    TicketMinimo = table.Column<int>(type: "int", precision: 20, nullable: false),
                    ValorUnitario = table.Column<decimal>(type: "decimal(20,2)", precision: 20, scale: 2, nullable: false),
                    TipoProdutoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    DataModificacao = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    Ativo = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    UsuarioCriacaoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UsuarioModificacaoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Produto_TipoProduto_TipoProdutoId",
                        column: x => x.TipoProdutoId,
                        principalTable: "TipoProduto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EmailCopias",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmailId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EnvioEmailId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailCopias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmailCopias_Email_EmailId",
                        column: x => x.EmailId,
                        principalTable: "Email",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmailCopias_EnvioEmail_EnvioEmailId",
                        column: x => x.EnvioEmailId,
                        principalTable: "EnvioEmail",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pessoa_EmailId",
                table: "Pessoa",
                column: "EmailId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EmailConfiguracaoEmail_ConfiguracaoEmailId",
                table: "EmailConfiguracaoEmail",
                column: "ConfiguracaoEmailId");

            migrationBuilder.CreateIndex(
                name: "IX_EmailConfiguracaoEmail_EmailEnvioId",
                table: "EmailConfiguracaoEmail",
                column: "EmailEnvioId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EmailConfiguracaoEmail_EmailRemetenteId",
                table: "EmailConfiguracaoEmail",
                column: "EmailRemetenteId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EmailCopias_EmailId",
                table: "EmailCopias",
                column: "EmailId");

            migrationBuilder.CreateIndex(
                name: "IX_EmailCopias_EnvioEmailId",
                table: "EmailCopias",
                column: "EnvioEmailId");

            migrationBuilder.CreateIndex(
                name: "IX_EnvioEmail_DestinatarioId",
                table: "EnvioEmail",
                column: "DestinatarioId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Produto_TipoProdutoId",
                table: "Produto",
                column: "TipoProdutoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pessoa_Email_EmailId",
                table: "Pessoa",
                column: "EmailId",
                principalTable: "Email",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pessoa_Email_EmailId",
                table: "Pessoa");

            migrationBuilder.DropTable(
                name: "Compra");

            migrationBuilder.DropTable(
                name: "EmailConfiguracaoEmail");

            migrationBuilder.DropTable(
                name: "EmailCopias");

            migrationBuilder.DropTable(
                name: "Encomenda");

            migrationBuilder.DropTable(
                name: "Pacote");

            migrationBuilder.DropTable(
                name: "Produto");

            migrationBuilder.DropTable(
                name: "ConfiguracaoEmail");

            migrationBuilder.DropTable(
                name: "EnvioEmail");

            migrationBuilder.DropTable(
                name: "TipoProduto");

            migrationBuilder.DropTable(
                name: "Email");

            migrationBuilder.DropIndex(
                name: "IX_Pessoa_EmailId",
                table: "Pessoa");

            migrationBuilder.DropColumn(
                name: "EmailId",
                table: "Pessoa");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Pessoa",
                type: "varchar(126)",
                unicode: false,
                maxLength: 126,
                nullable: false,
                defaultValue: "");
        }
    }
}
