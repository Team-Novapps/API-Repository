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
    public class DescripcionService : IDescripcionService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public async Task<IEnumerable<DescripcionRes>> GetAll()
        {
            var descripciones = await _unitOfWork.descripcionRepository.GetAll();
            var descripcionesRes = _mapper.Map<IEnumerable<DescripcionRes>>(descripciones);
            return descripcionesRes;
        }

        public async Task<int> Save(DescripcionReq descripcionReq)
        {
            var descripcion = _mapper.Map<Descripcion>(descripcionReq);
            var descripcionSaved = await _unitOfWork.descripcionRepository.Save(descripcion);
            return descripcionSaved.Id;
        }
    }
}
