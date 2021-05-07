using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Teoguide.Domain.Model.Request;
using Teoguide.Domain.Model.Response;

namespace Teoguide.Domain.Service
{
    public interface IComentarioService
    {
        Task<int> Save(ComentarioReq comentarioReq);
        Task<ComentarioRes> GetComentarioByCentroId(int id);
    }
}
