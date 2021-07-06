using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teoguide.Domain.Entity;
using Teoguide.Domain.Model.Response;
using Teoguide.Domain.Repository;
using Teoguide.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Teoguide.Infrastructure.RepositoryImpl
{
    public class PlanRepository : Repository<Plan>, IPlanRepository
    {
        public PlanRepository(TeoguideDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<PlanRes>> GetAllDetailByUserId(int usuarioId)
        {
            var planesDetail = await _context.Planes
                .Where(p => p.UsuarioId == usuarioId)
                .Select(p => new PlanRes
                {
                    Id = p.Id,
                    Titulo = p.Titulo,
                    Descripcion = p.Descripcion,
                    FechaPlan = p.FechaPlan,
                    Actividades = _context.Actividades
                        .Where(act => act.PlanId == p.Id)
                        .Select(act => new ActividadRes
                        {
                            Id = act.Id,
                            PlanId = act.PlanId,
                            CentroHistoricoId = act.CentroHistoricoId,
                            NombreCentroHistorico = act.CentroHistorico.Nombre,
                            Descripcion = act.Descripcion,
                            HoraActividad = act.HoraActividad.ToString()
                        })
                        .ToList()

                })
                .ToListAsync();

            return planesDetail;
        }

        public async Task<PlanDetail> GetDetailById(int id)
        {
            var planDetail = await _context.Planes
                .Where(p => p.Id == id)
                .Select(p => new PlanDetail 
                { 
                    Id = p.Id,
                    Titulo = p.Titulo,
                    Actividades = _context.Actividades
                                          .Where(act => act.PlanId == p.Id)
                                          .Select(act => new ActividadRes
                                          {
                                              Id = act.Id,
                                              CentroHistoricoId = act.CentroHistoricoId,
                                              NombreCentroHistorico = act.CentroHistorico.Nombre,
                                              Descripcion = act.Descripcion,
                                              //FechaHoraActividad = act.FechaHoraActividad
                                          })
                                          .ToList()

                })
                .FirstOrDefaultAsync();

            return planDetail;
        }
    }
}
