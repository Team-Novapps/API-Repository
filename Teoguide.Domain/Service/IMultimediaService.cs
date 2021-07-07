using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Teoguide.Domain.Model.Request;
using Teoguide.Domain.Model.Response;

namespace Teoguide.Domain.Service
{
    public interface IMultimediaService
    {
        Task<IEnumerable<MultimediaRes>> GetAll();
        Task<int> Save(MultimediaReq multimediaReq);
        Task<IEnumerable<MultimediaRes>> GetImagesByCentroId(int centroId);
    }
}
