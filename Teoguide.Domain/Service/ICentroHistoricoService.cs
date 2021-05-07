using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Teoguide.Domain.Model.Request;
using Teoguide.Domain.Model.Response;

namespace Teoguide.Domain.Service
{
    public interface ICentroHistoricoService
    {
        Task<IEnumerable<CentroHistoricoRes>> GetAll();
        Task<CentroHistoricoDetail> GetDetailById(int id);
        Task<List<CentroHistoricoRes>> GetCentroByLongitudLatitud(string longitud, string latitud);
        Task<int> Save(CentroHistoricoReq centroReq);

    }
}
