using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Teoguide.Domain.Entity;
using Teoguide.Domain.Model.Response;

namespace Teoguide.Domain.Repository
{
    public interface IComentarioRespository:IRepository<Comentario>
    {
        Task<ComentarioRes> GetComentarioByCentroId(int id);
    }
}
