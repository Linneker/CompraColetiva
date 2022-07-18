using acme.sistemas.compracoletiva.core.Helpers;
using acme.sistemas.compracoletiva.domain.Entity.Security;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;

namespace acme.sistemas.compracoletiva.config.Security
{
    public static class ConfiguraAutorizacao
    {

        public static IServiceCollection ConfigurarToken(this IServiceCollection services, ConfiguracaoToken configuracaoToken)
        {

            CriptografiaAssincrona criptografiaAssincrona = new CriptografiaAssincrona();
            SigningConfigurations setings = new SigningConfigurations();
            services.AddSingleton(setings);

            services.AddAuthentication(authOptions =>
            {
                authOptions.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                authOptions.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(t =>
            {
                t.RequireHttpsMetadata = true;
                t.SaveToken = true;
                t.Authority = "https://securetoken.google.com/compra-297d1";
                t.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = setings.Key,
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidAudiences = configuracaoToken.AutenticacoesSistemas.Select(t => t.ValidoEm).ToList(),
                    ValidIssuers = configuracaoToken.AutenticacoesSistemas.Select(t => t.SistemaEmissao).ToList(),
                    ClockSkew = TimeSpan.FromHours(configuracaoToken.Expiracao.HasValue ? configuracaoToken.Expiracao.Value : 2),
                    ValidateLifetime = true
                };
                t.Validate();

                //t.Authority = "https://securetoken.google.com/compra-297d1";
                //t.TokenValidationParameters = new TokenValidationParameters
                //{
                //    ValidateIssuer = true,
                //    ValidIssuer = "https://securetoken.google.com/compra-297d1",
                //    ValidateAudience = true,
                //    ValidAudience = "compra-297d1",
                //    ValidateLifetime = true
                //};
            });

            services.AddAuthorization(auth =>
            {
                auth.AddPolicy("Bearer", new AuthorizationPolicyBuilder()
                    .AddAuthenticationSchemes(JwtBearerDefaults.AuthenticationScheme)
                    .RequireAuthenticatedUser().Build());
            });

            return services;
        }
    }
}
