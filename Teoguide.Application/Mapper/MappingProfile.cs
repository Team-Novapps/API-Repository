using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using Teoguide.Domain.Entity;
using Teoguide.Domain.Model.Request;
using Teoguide.Domain.Model.Response;

namespace Teoguide.Application.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Usuario, UsuarioRes>();
            CreateMap<UsuarioReq, Usuario>();
            CreateMap<Plan, PlanRes>();
            CreateMap<PlanReq, Plan>();
            CreateMap<Actividad, ActividadRes>();
            CreateMap<ActividadReq, Actividad>();
        }
    }
}
