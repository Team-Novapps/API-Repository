using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Teoguide.Domain.Model.Request;
using Teoguide.Domain.Model.Response;
using Teoguide.Domain.Repository;
using Teoguide.Domain.Service;
using Teoguide.Infrastructure.UnitOfWork;

namespace Teoguide.Application.ServiceImpl
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UsuarioService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<UsuarioRes> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<UsuarioRes>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<int> Save(UsuarioReq usuarioReq)
        {
            throw new NotImplementedException();
        }

        public Task<int> Update(int id, UsuarioReq usuarioReq)
        {
            throw new NotImplementedException();
        }
    }
}
