using System;
using System.Collections.Generic;
using System.Text;
using Teoguide.Domain.Entity;
using Teoguide.Domain.Repository;
using Teoguide.Infrastructure.Context;

namespace Teoguide.Infrastructure.RepositoryImpl
{
    public class CentroHistoricoRepository : Repository<CentroHistorico>, ICentroHistoricoRepository
    {
        public CentroHistoricoRepository(TeoguideDbContext context) : base(context)
        {
        }
    }
}
