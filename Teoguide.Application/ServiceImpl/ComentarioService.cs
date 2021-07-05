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
    public class ComentarioService : IComentarioService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        
        public ComentarioService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ComentarioRes>> GetComentariosByCentroId(int id)
        {
            return await _unitOfWork.comentarioRespository.GetComentariosByCentroId(id);
        }

        public async Task<int> Save(ComentarioReq comentarioReq)
        {
            var comentario =  _mapper.Map<Comentario>(comentarioReq);
            var comentarioSaved = await _unitOfWork.comentarioRespository.Save(comentario);
            return comentarioSaved.Id;
        }
    }
}
