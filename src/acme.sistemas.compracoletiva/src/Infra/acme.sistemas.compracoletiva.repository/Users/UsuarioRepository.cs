using acme.sistemas.compracoletiva.domain.Entity.Users;
using acme.sistemas.compracoletiva.domain.Interfaces.Repository.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acme.sistemas.compracoletiva.repository.Users
{
    public class UsuarioRepository : BaseRepository<Usuario>, IUsuarioRepository
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioRepository(IUsuarioRepository usuarioRepository) : base(usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }
    }
}
