using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Teoguide.Domain.Entity;
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

        public async Task<IEnumerable<UsuarioRes>> GetAll()
        {
            var usuarios = await _unitOfWork.usuarioRepository.GetAll();
            var usuariosRes = _mapper.Map<IEnumerable<UsuarioRes>>(usuarios);
            return usuariosRes;
        }

        public async Task<int> Save(UsuarioReq usuarioReq)
        {
            var usuario = _mapper.Map<Usuario>(usuarioReq);
            var usuarioSave = await _unitOfWork.usuarioRepository.Save(usuario);
            return usuarioSave.Id;
        }

        public Task<int> Update(int id, UsuarioReq usuarioReq)
        {
            throw new NotImplementedException();
        }
    }
}
