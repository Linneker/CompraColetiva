using acme.sistemas.compracoletiva.infra.Config;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.EntityFrameworkCore;
using NLog.Extensions.Logging;
using System.IO.Compression;
using System.Text.Json.Serialization;
using FluentValidation.AspNetCore;
using acme.sistemas.compracoletiva.service.Works.Util;

namespace acme.sistemas.compracoletiva.api
{
    public class StartupApiTeste
    {
        public StartupApiTeste(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRouting(_ => _.LowercaseUrls = true);

            services.AddResponseCompression();
            services.Configure<GzipCompressionProviderOptions>(options =>
            {
                options.Level = CompressionLevel.SmallestSize;
            });
            services.Configure<BrotliCompressionProviderOptions>(options =>
            {
                options.Level = CompressionLevel.SmallestSize;
            });

            var serverVersion = new MySqlServerVersion(new Version(8, 0, 27));


            services.AddDbContext<Context>(op => op.UseMySql(Configuration.GetConnectionString("MySqlLocal"), serverVersion)
            .UseLoggerFactory(loggerFactory)
                .EnableSensitiveDataLogging()
                .EnableDetailedErrors());

            services.AddDbContext<Context>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("CompraColetiva"), _ => _.MigrationsAssembly("acme.sistemas.compracoletiva.infra"));
            });

            services.AddHostedService<EmailWorkerServico>();

            // Add services to the container.
            //services.RegistrarDependencia();

            services.AddControllers()
                /*.AddFluentValidation(_ => {
                    _.RegisterValidatorsFromAssemblyContaining<AnuncioWebmotorsValidador>();
                    _.DisableDataAnnotationsValidation = true;
                }).SetCompatibilityVersion(_ => {
                    _.RegisterValidatorsFromAssemblyContaining<AnuncioWebmotorsValidador>();
                    _.DisableDataAnnotationsValidation = true;
                })*/.AddJsonOptions(x => x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();

        }
        public void Configure(WebApplication app, IWebHostEnvironment env, ILoggerFactory logger)
        {
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "CompqraColetiva.Api v1"));
            }

            app.UseHttpsRedirection();
            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            //app.UseMiddleware(typeof(ErrorHandlingMiddleware));

            logger.CreateLogger($"log_compracoletiva_${DateTime.Now.Year}{DateTime.Now.Month}{DateTime.Now.Day}");
            app.UseResponseCompression();

            app.MapControllers();

        }

        internal static readonly ILoggerFactory loggerFactory = LoggerFactory.Create(builder =>
        {
            builder.ClearProviders();
            builder.SetMinimumLevel(LogLevel.Trace);

            builder.AddNLog();
            builder.AddJsonConsole();
            builder.AddConsole();
        });
    }
}
