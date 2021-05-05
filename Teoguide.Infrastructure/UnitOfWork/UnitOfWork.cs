using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Teoguide.Domain.Repository;
using Teoguide.Infrastructure.Context;
using Teoguide.Infrastructure.RepositoryImpl;

namespace Teoguide.Infrastructure.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly TeoguideDbContext _context;
        
        // agregar los otros repositories
        public IUsuarioRepository _usuarioRepository { get; private set; }

        public UnitOfWork(TeoguideDbContext context)
        {
            _context = context;
            _usuarioRepository = new UsuarioRepository(_context);
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
