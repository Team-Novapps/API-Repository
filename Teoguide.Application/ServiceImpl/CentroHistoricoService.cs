using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Teoguide.Domain.Entity;
using Teoguide.Domain.Model.Request;
using Teoguide.Domain.Model.Response;
using Teoguide.Domain.Service;
using Teoguide.Infrastructure.UnitOfWork;

namespace Teoguide.Application.ServiceImpl
{
    public class CentroHistoricoService : ICentroHistoricoService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CentroHistoricoService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<IEnumerable<CentroHistoricoRes>> GetAll()
        {
            var centrosRes = await _unitOfWork.centroHistoricoRepository.GetAllRes();
            return centrosRes;
        }

        public async Task<List<CentroHistoricoRes>> GetCentroByLongitudLatitud(string longitud, string latitud)
        {
            return await _unitOfWork.centroHistoricoRepository.GetCentroByLongitudLatitud(longitud, latitud);
        }

        public async Task<CentroHistoricoDetail> GetDetailById(int id)
        {
            return await _unitOfWork.centroHistoricoRepository.GetDetailById(id);
        }

        public async Task<int> Save(CentroHistoricoReq centroReq)
        {
            var centro = _mapper.Map<CentroHistorico>(centroReq);
            var centroSaved = await _unitOfWork.centroHistoricoRepository.Save(centro);
            return centroSaved.Id;
        }
    }
}
