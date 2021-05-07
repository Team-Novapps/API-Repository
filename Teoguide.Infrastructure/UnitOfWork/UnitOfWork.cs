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
        public IUsuarioRepository usuarioRepository { get; private set; }
        public IPlanRepository planRepository { get; private set; }
        public IActividadRepository actividadRepository { get; private set; }
        public ICentroHistoricoRepository centroHistoricoRepository { get; set; }
        public IMultimediaRespository multimediaRespository { get; set; }
        public IDescripcionRepository descripcionRepository { get; set; }
        public IComentarioRespository comentarioRespository { get; set; }

        public UnitOfWork(TeoguideDbContext context)
        {
            _context = context;
            usuarioRepository = new UsuarioRepository(_context);
            planRepository = new PlanRepository(_context);
            actividadRepository = new ActividadRepository(_context);
            centroHistoricoRepository = new CentroHistoricoRepository(_context);
            multimediaRespository = new MultimediaRepository(_context);
            descripcionRepository = new DescripcionRepository(_context);
            comentarioRespository = new ComentarioRespository(_context);
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
