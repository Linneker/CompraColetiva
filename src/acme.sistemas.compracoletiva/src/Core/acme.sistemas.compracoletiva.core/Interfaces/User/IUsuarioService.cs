using acme.sistemas.compracoletiva.core.Dtos.Users;
using acme.sistemas.compracoletiva.domain.Entity.Users;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acme.sistemas.compracoletiva.core.Interfaces.User
{
    public interface IUsuarioService: IBaseService<Usuario>
    {
        Task<IdentityResult> Cadastrar(RegistroUsuarioDto registroUsuario, string privateKey);
    }
}
