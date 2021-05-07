using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Teoguide.Domain.Model.Request;
using Teoguide.Domain.Model.Response;

namespace Teoguide.Domain.Service
{
    public interface IDescripcionService
    {
        Task<IEnumerable<DescripcionRes>> GetAll();
        Task<int> Save(DescripcionReq descripcionReq);
    }
}
