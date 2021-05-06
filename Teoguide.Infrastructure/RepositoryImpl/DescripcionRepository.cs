using System;
using System.Collections.Generic;
using System.Text;
using Teoguide.Domain.Entity;
using Teoguide.Domain.Repository;
using Teoguide.Infrastructure.Context;

namespace Teoguide.Infrastructure.RepositoryImpl
{
    public class DescripcionRepository :Repository<Descripcion>, IDescripcionRepository
    {
        public DescripcionRepository(TeoguideDbContext context) : base(context)
        {

        }
    }
}
