using acme.sistemas.compracoletiva.api.teste.Fixture;
using acme.sistemas.compracoletiva.core.Dtos.Security;
using acme.sistemas.compracoletiva.core.Dtos.Users;
using acme.sistemas.compracoletiva.domain.Entity.Enuns;
using acme.sistemas.compracoletiva.domain.Entity.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace acme.sistemas.compracoletiva.api.teste.Test
{
    [Collection(nameof(IntegrationApiTesteFixtureCollection))]
    public class UsuarioTest
    {
        private readonly IntegrationTesteFixture _integrationTesteFixture;
        public UsuarioTest(IntegrationTesteFixture integrationTesteFixture)
        {
            _integrationTesteFixture = integrationTesteFixture;
        }

        [Fact(DisplayName ="Cadastro de Usuario")]
        [Trait("Usuario","Integração Usuario")]
        public async Task Usuario_RealizaCadastro_DeveExecutarComSucesso()
        {
            //Arrange
            var claim = new List<ClaimDto>()
                {
                    new ClaimDto() { Nome = "Usuario", Valor = "All" },
                    new ClaimDto() { Nome = "Compra", Valor = "All" },
                    new ClaimDto() { Nome = "Produto", Valor = "All" },
                    new ClaimDto() { Nome = "Email", Valor = "All" }
                };
            var pessoa = new RegistroUsuarioDto()
            {

                ConfirmacaoSenha = "123@Mudar",
                Email = "123@Mudar.com.br",
                Permissao = new PermissaoDto() { Claims = claim, Nome = "Root" },
                Senha = "123@Mudar",
                Claim = claim,
                Pessoa = new PessoaDto()
                {
                    Nome = "Teste",
                    Celular = "(35)99244-5418",
                    CNPJ = "",
                    CPF = "12345678909",
                    DataNascimento = new DateTime(1990, 01, 31),
                    Email = "123@Mudar.com.br",
                    InscricaoMunicipal = "",
                    NomeFantasia = "",
                    Telefone = "",
                    TipoPessoa = EnumTipoPessoa.Fisica,
                    EnderecoPessoas = new List<EnderecoPessoaDto>()
                    {
                        new EnderecoPessoaDto()
                        {
                            Complemento ="Casa",
                            Endereco = new EnderecoDto()
                            {
                                Bairro ="A",
                                Cep = "37500000",
                                Cidade = "B",
                                Estado = "MG",
                                Pais = "Brazil",
                                Rua = "C"
                            },
                            Latitude = "",
                            Longitude = "",
                            Numero = 2
                        }
                    }
                }
            };
 

            //Act
            var post = await _integrationTesteFixture.Client.PostAsJsonAsync("api/Usuario/Registrar", pessoa);

            //Assert
            post.EnsureSuccessStatusCode();

        }
    }
}
