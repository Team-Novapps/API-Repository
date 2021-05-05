using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Teoguide.Domain.Entity;
using Teoguide.Domain.Model.Request;
using Teoguide.Domain.Model.Response;

namespace Teoguide.Domain.Service
{
    public interface IUsuarioService
    {
        Task<UsuarioRes> Get(int id);
        Task<IEnumerable<UsuarioRes>> GetAll();
        Task<int> Save(UsuarioReq usuarioReq);
        Task<int> Update(int id, UsuarioReq usuarioReq);
        Task<bool> Delete(int id);
    }
}
