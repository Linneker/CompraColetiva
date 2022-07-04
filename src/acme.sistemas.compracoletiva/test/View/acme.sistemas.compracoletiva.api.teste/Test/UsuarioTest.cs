using acme.sistemas.compracoletiva.api.teste.Fixture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace acme.sistemas.compracoletiva.api.teste.Test
{
    [CollectionDefinition(nameof(IntegrationApiTesteFixtureCollection))]
    public class UsuarioTest
    {
        private readonly IntegrationTesteFixture<StartupApiTeste> _integrationTesteFixture;
        public UsuarioTest(IntegrationTesteFixture<StartupApiTeste> integrationTesteFixture)
        {
            _integrationTesteFixture = integrationTesteFixture;
        }
        [Fact(DisplayName ="Cadastro de Usuario")]
        [Trait("Usuario","Integração Usuario")]
        public async Task Usuario_RealizaCadastro_DeveExecutarComSucesso()
        {
            //Arrange
            var iniciar = await _integrationTesteFixture.Client.GetAsync("");
            iniciar.EnsureSuccessStatusCode();
            
        }
    }
}
