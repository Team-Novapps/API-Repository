using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Teoguide.Domain.Entity;
using Teoguide.Domain.Repository;
using Teoguide.Infrastructure.Context;

namespace Teoguide.Infrastructure.RepositoryImpl
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly TeoguideDbContext _context;

        public UsuarioRepository(TeoguideDbContext context)
        {
            _context = context;
        }

        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Usuario> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Usuario>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<int> Save(Usuario entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> Update(int id, Usuario entity)
        {
            throw new NotImplementedException();
        }
    }
}
