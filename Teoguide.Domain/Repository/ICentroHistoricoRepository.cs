using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Teoguide.Domain.Entity;
using Teoguide.Domain.Model.Response;

namespace Teoguide.Domain.Repository
{
    public interface ICentroHistoricoRepository : IRepository<CentroHistorico>
    {
        Task<IEnumerable<CentroHistoricoRes>> GetAllRes();

        Task<CentroHistoricoDetail> GetDetailById(int id);

        //Obtener los centros más cercanos a un punto
        Task<List<CentroHistoricoRes>> GetCentroByLongitudLatitud(string longitud, string latitud);
    }
}
