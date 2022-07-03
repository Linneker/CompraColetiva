using acme.sistemas.compracoletiva.domain.Interfaces.Repository;
using acme.sistemas.compracoletiva.domain.Interfaces.Repository.User;
using acme.sistemas.compracoletiva.domain.Interfaces.Repository.Utils;
using acme.sistemas.compracoletiva.repository;
using acme.sistemas.compracoletiva.repository.Users;
using acme.sistemas.compracoletiva.repository.Utils;
using Microsoft.Extensions.DependencyInjection;

namespace acme.sistemas.compracoletiva.di.Installers
{
    public static class Repositories
    {
        public static IServiceCollection InstallRepositories(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient(typeof(IBaseRepository<>), typeof(BaseRepository<>));


            serviceCollection.AddTransient<IUsuarioRepository, UsuarioRepository>();

            serviceCollection.AddTransient<IEnderecoRepository, EnderecoRepository>();
            serviceCollection.AddTransient<IArquivoRepository, ArquivoRepository>();
            serviceCollection.AddTransient<IParametroRepository, ParametroRepository>();

            // serviceCollection.AddTransient<IConfiguracaoTokenRepository, ConfiguracaoTokenRepository>();

            return serviceCollection;
        }
    }
}
