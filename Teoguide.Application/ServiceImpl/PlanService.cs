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
    public class PlanService : IPlanService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public PlanService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<PlanRes>> GetAll()
        {
            var planes = await _unitOfWork.planRepository.GetAll();
            var planesRes = _mapper.Map<IEnumerable<PlanRes>>(planes);
            return planesRes;
        }

        public async Task<IEnumerable<PlanRes>> GetAllByUserId(int usuarioId)
        {
            var planes = await _unitOfWork.planRepository.GetAllDetailByUserId(usuarioId);
            return planes;
        }

        public async Task<PlanDetail> GetDetailById(int id)
        {
            return await _unitOfWork.planRepository.GetDetailById(id);
        }

        public async Task<int> Save(PlanReq planReq)
        {
            var plan = _mapper.Map<Plan>(planReq);
            var planSaved = await _unitOfWork.planRepository.Save(plan);
            return planSaved.Id;
        }
    }
}
