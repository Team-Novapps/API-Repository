using System;
using System.Collections.Generic;
using System.Text;
using Teoguide.Domain.Entity;
using Teoguide.Domain.Repository;
using Teoguide.Infrastructure.Context;

namespace Teoguide.Infrastructure.RepositoryImpl
{
    public class MultimediaRepository : Repository<Multimedia>, IMultimediaRespository
    {
        public MultimediaRepository(TeoguideDbContext context) : base(context)
        {

        }
    }
}
