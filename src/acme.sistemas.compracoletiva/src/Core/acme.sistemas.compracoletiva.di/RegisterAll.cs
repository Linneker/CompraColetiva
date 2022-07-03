using acme.sistemas.compracoletiva.di.Installers;
using acme.sistemas.compracoletiva.infra.Config;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace acme.sistemas.compracoletiva.di
{
    public static class RegisterAll
    {
        public static IServiceCollection InstallDependencies(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<Context>();
            //serviceCollection.AddTransient<IUnitOfWork, UnitOfWork>();
            serviceCollection.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            serviceCollection.InstallDomainServices();
            serviceCollection.InstallRepositories();
            return serviceCollection;
        }
    }
}
