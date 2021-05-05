using System;
using System.Collections.Generic;
using System.Text;
using Teoguide.Domain.Entity;
using Teoguide.Domain.Repository;
using Teoguide.Infrastructure.Context;

namespace Teoguide.Infrastructure.RepositoryImpl
{
    public class ActividadRepository : Repository<Actividad>, IActividadRepository
    {
        public ActividadRepository(TeoguideDbContext context) : base(context)
        {
        }

    }
}
