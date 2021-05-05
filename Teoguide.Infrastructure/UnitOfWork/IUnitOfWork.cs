using System;
using System.Collections.Generic;
using System.Text;
using Teoguide.Domain.Repository;

namespace Teoguide.Infrastructure.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        // agregar los otros repositorios
        IUsuarioRepository _usuarioRepository { get; }       
    }
}
