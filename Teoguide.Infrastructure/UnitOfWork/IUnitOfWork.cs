using System;
using System.Collections.Generic;
using System.Text;
using Teoguide.Domain.Repository;

namespace Teoguide.Infrastructure.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        // agregar los otros repositorios
        IUsuarioRepository usuarioRepository { get; }       
        IPlanRepository planRepository { get; }
        IActividadRepository actividadRepository { get; }
        ICentroHistoricoRepository centroHistoricoRepository { get; }

    }
}
