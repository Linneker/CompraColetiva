///Applicação
using acme.sistemas.compracoletiva.core.Security;
using acme.sistemas.compracoletiva.domain.Entity.Security;
using acme.sistemas.compracoletiva.domain.Entity.Users;
using acme.sistemas.compracoletiva.infra.Config;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<Context>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("CompraColetiva"), _ => _.MigrationsAssembly("EProcessos.Infra"));
});


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var tokenConfigurations = new ConfiguracaoToken();
new ConfigureFromConfigurationOptions<ConfiguracaoToken>(
    builder.Configuration.GetSection("ConfiguracaoToken"))
        .Configure(tokenConfigurations);
builder.Services.AddSingleton(tokenConfigurations);

builder.Services.ConfigurarToken(tokenConfigurations);

//builder.Services.AddDefaultIdentity<Usuario>(t =>
//{
//    t.SignIn.RequireConfirmedAccount = true;
//    t.SignIn.RequireConfirmedEmail = true;
//}).AddRoles<Permissao>().AddEntityFrameworkStores<Context>();

///Builder

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "EProcessos.Api v1"));
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
