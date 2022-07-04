using acme.sistemas.compracoletiva.core.Dtos.Users;
using acme.sistemas.compracoletiva.core.Helpers;
using acme.sistemas.compracoletiva.core.Interfaces.Service.User;
using acme.sistemas.compracoletiva.domain.Entity.Users;
using acme.sistemas.compracoletiva.domain.Interfaces.Repository.User;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace acme.sistemas.compracoletiva.service.Service.Users
{
    public class UsuarioService : BaseService<Usuario>, IUsuarioService
    {
        private readonly IUsuarioRepository _baseRepository;
        private readonly SignInManager<Usuario> _signInManager;
        private readonly UserManager<Usuario> _userManager;
        private readonly IMapper _mapper;
        public UsuarioService(IUsuarioRepository baseRepository,
            SignInManager<Usuario> signInManager,
            UserManager<Usuario> userManager,
            IMapper mapper) : base(baseRepository)
        {
            _baseRepository = baseRepository;
            _signInManager = signInManager;
            _userManager = userManager;
            _mapper = mapper;
        }

        public async Task<IdentityResult> Cadastrar(RegistroUsuarioDto registroUsuario, string privateKey)
        {
            Usuario userIdentity = new Usuario(registroUsuario.Pessoa.ParaPessoa())
            {
                UserName = registroUsuario.Email,
                Email = registroUsuario.Email,
                EmailConfirmed = true,
                TipoUsuarioId = registroUsuario.TipoUsuarioId
            };

            var result = await _userManager.CreateAsync(userIdentity, registroUsuario.Senha);

            if (!result.Succeeded)
                return result;


            var resultPermissao = await _userManager.AddToRoleAsync(userIdentity, registroUsuario.Permissao.Nome);
            if (resultPermissao.Succeeded)
            {

                var resultClaim = await _userManager.AddClaimAsync(userIdentity, new Claim("Permissao", registroUsuario.Permissao.Nome));

                registroUsuario.Claim.ForEach(t =>
                    _userManager.AddClaimAsync(userIdentity, new Claim(t.Nome, t.Valor))
                );

                if (resultClaim.Succeeded)
                {
                    await _signInManager.SignInAsync(userIdentity, false);
                    return result;
                }
                else
                    return resultClaim;
            }
            else
                return resultPermissao;

        }
        public async Task<IQueryable<Usuario>> GetUsuariosJoinPessoaEndereco()
        {
            return await _baseRepository.GetUsuariosJoinPessoaEndereco();
        }

        public Task<Usuario> GetUsuariosJoinPessoaEnderecoJoinPermissaoByLogin(string login)
        {
            return _baseRepository.GetUsuariosJoinPessoaEnderecoJoinPermissaoByLogin(login);
        }

    }
}
