using acme.sistemas.compracoletiva.domain.Entity.Users;
using acme.sistemas.compracoletiva.domain.Interfaces.Repository.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acme.sistemas.compracoletiva.repository.Users
{
    public class TipoUsuarioRepository : BaseRepository<TipoUsuario>, ITipoUsuarioRepository
    {
        private readonly ITipoUsuarioRepository _tipoUsuarioRepository;

        public TipoUsuarioRepository(ITipoUsuarioRepository tipoUsuarioRepository): base(tipoUsuarioRepository)
        {
            _tipoUsuarioRepository = tipoUsuarioRepository;
        }
    }
}
