using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Teoguide.Domain.Entity;
using Teoguide.Domain.Model.Response;
using Teoguide.Domain.Repository;
using Teoguide.Infrastructure.Context;

namespace Teoguide.Infrastructure.RepositoryImpl
{
    public class CentroHistoricoRepository : Repository<CentroHistorico>, ICentroHistoricoRepository
    {
        public CentroHistoricoRepository(TeoguideDbContext context) : base(context)
        {
        }

        public async Task<CentroHistoricoDetail> GetDetailById(int id)
        {
            var centro = await _context.CentroHistoricos
                                 .Where(c => c.Id == id)
                                 .Select(c => new CentroHistoricoDetail
                                 {
                                     Id = c.Id,
                                     Nombre = c.Nombre,
                                     Direccion = c.Direccion,
                                     Latitud = c.Latitud,
                                     Longitud = c.Longitud,
                                     Descripciones = _context.Descripciones
                                                             .Where(desc => desc.CentroHistoricoId == c.Id)
                                                             .Select(desc => new DescripcionRes
                                                             {
                                                                 Id = desc.Id,
                                                                 CentroHistoricoId = desc.CentroHistoricoId,
                                                                 Texto = desc.Texto
                                                             })
                                                             .ToList(),
                                     Multimedias = _context.Multimedias
                                                           .Where(mult => mult.CentroHistoricoId == c.Id)
                                                           .Select(mult => new MultimediaRes
                                                           {
                                                               Id = mult.Id,
                                                               UsuarioId = mult.UsuarioId,
                                                               CentroHistoricoId = mult.CentroHistoricoId,
                                                               Tipo = mult.Tipo,
                                                               Verificado = mult.Verificado,
                                                               ContendioUrl = mult.ContendioUrl
                                                           })
                                                           .ToList()
                                 })
                                 .FirstOrDefaultAsync();
            return centro;
        }

        public Task<List<CentroHistoricoRes>> GetCentroByLongitudLatitud(string longitud, string latitud)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<CentroHistoricoRes>> GetAllRes()
        {
            var centroHistoricosRes = await _context.CentroHistoricos
                .Select(ch => new CentroHistoricoRes
                {
                    Id = ch.Id,
                    Nombre = ch.Nombre,
                    Descripcion = ch.Descripciones
                                    .Where(d => d.Idioma == "ESP")
                                    .Select(d => d.Texto)
                                    .FirstOrDefault(),
                    ImgUrl = ch.ImgUrl,
                    Direccion = ch.Direccion,
                    Latitud = ch.Latitud,
                    Longitud = ch.Longitud                  
                }).ToListAsync();

            return centroHistoricosRes;
        }
    }
}
