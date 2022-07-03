using acme.sistemas.compracoletiva.api.teste.Config;
using Microsoft.AspNetCore.Mvc.Testing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace acme.sistemas.compracoletiva.api.teste.Fixture
{
    [CollectionDefinition(nameof(IntegrationApiTesteFixtureCollection))]
    public class IntegrationApiTesteFixtureCollection : ICollectionFixture<IntegrationTesteFixture<StartupApiTeste>>
    {

    }
    public class IntegrationTesteFixture<TStartup> : IDisposable where TStartup : class
    {
        public readonly CompraColetivoFactory<TStartup> Factory;
        public HttpClient Client;

        public IntegrationTesteFixture()
        {
            var clientOptions = new WebApplicationFactoryClientOptions() { 
                
            };
            Factory = new CompraColetivoFactory<TStartup>();
            Client = Factory.CreateClient(clientOptions);
        }

        public void Dispose()
        {
            Client.Dispose();
            Factory.Dispose();
        }
    }
}
