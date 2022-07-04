using acme.sistemas.compracoletiva.core.Interfaces.Worker.Util;
using acme.sistemas.compracoletiva.di.Installers;
using acme.sistemas.compracoletiva.infra.Config;
using acme.sistemas.compracoletiva.service.Works.Util;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace acme.sistemas.compracoletiva.di
{
    public static class RegisterAll
    {
        public static IServiceCollection InstallDependencies(this IServiceCollection serviceCollection)
        {
            //serviceCollection.AddScoped<Context>();
            //serviceCollection.AddTransient<IUnitOfWork, UnitOfWork>();
            serviceCollection.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            serviceCollection.AddSingleton<IEmailWorkerServico,EmailWorkerServico>();
            serviceCollection.InstallDomainServices();
            serviceCollection.InstallRepositories();

            serviceCollection.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            return serviceCollection;
        }
    }
}
