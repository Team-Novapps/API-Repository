using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Teoguide.Domain.Model.Request;
using Teoguide.Domain.Model.Response;

namespace Teoguide.Domain.Service
{
    public interface IPlanService
    {
        Task<IEnumerable<PlanRes>> GetAll();
        Task<PlanDetail> GetDetailById(int id);
        Task<int> Save(PlanReq planReq);
        Task<IEnumerable<PlanRes>> GetAllByUserId(int usuarioId);
    }
}
