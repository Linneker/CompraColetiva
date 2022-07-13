using acme.sistemas.compracoletiva.service.Interfaces.Service;
using acme.sistemas.compracoletiva.service.Interfaces.Service.Location;
using acme.sistemas.compracoletiva.service.Interfaces.Service.User;
using acme.sistemas.compracoletiva.service.Interfaces.Service.Utils;
using acme.sistemas.compracoletiva.service.Service;
using acme.sistemas.compracoletiva.service.Service.Location;
using acme.sistemas.compracoletiva.service.Service.Users;
using acme.sistemas.compracoletiva.service.Service.Utils;
using Microsoft.Extensions.DependencyInjection;

namespace acme.sistemas.compracoletiva.di.Installers
{
    public static class DomainServices
    {
        public static IServiceCollection InstallDomainServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient(typeof(IBaseService<>), typeof(BaseService<>));

            serviceCollection.AddTransient<IUsuarioService, UsuarioService>();

            serviceCollection.AddTransient<IEnderecoService, EnderecoService>();
            serviceCollection.AddTransient<IArquivoService, ArquivoService>();
            serviceCollection.AddTransient<IParametroService, ParametroService>();
            serviceCollection.AddTransient<ITipoUsuarioService, TipoUsuarioService>();

            //serviceCollection.AddTransient<IConfiguracaoTokenServices, ConfiguracaoTokenServices>();
            return serviceCollection;
        }
    }
}
