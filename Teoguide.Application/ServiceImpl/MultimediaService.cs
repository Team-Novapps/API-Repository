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
    public class MultimediaService : IMultimediaService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public MultimediaService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<MultimediaRes>> GetAll()
        {
            var multimedias = await _unitOfWork.multimediaRespository.GetAll();
            var multimediasRes = _mapper.Map<IEnumerable<MultimediaRes>>(multimedias);
            return multimediasRes;
        }

        public async Task<int> Save(MultimediaReq multimediaReq)
        {
            var multimedia = _mapper.Map<Multimedia>(multimediaReq);
            var multimediaSaved = await _unitOfWork.multimediaRespository.Save(multimedia);
            return multimediaSaved.Id;
        }
    }
}
