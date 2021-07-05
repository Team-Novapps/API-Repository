using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Teoguide.Domain.Entity;
using Teoguide.Domain.Model.Response;
using Teoguide.Domain.Repository;
using Teoguide.Infrastructure.Context;

namespace Teoguide.Infrastructure.RepositoryImpl
{
    public class ComentarioRespository : Repository<Comentario>, IComentarioRespository
    {
        public ComentarioRespository(TeoguideDbContext context) : base(context)
        {

        }
        public async Task<IEnumerable<ComentarioRes>> GetComentariosByCentroId(int id)
        {
            var comentario = await _context.Comentarios
                            .Where(c => c.CentroHistoricoId == id)
                            .Select(
                               c => new ComentarioRes
                               {
                                   Id = c.Id,
                                   UsuarioId = c.UsuarioId,
                                   CentroHistoricoId = c.CentroHistoricoId,
                                   Texto = c.Texto,
                                   NombreUsuario = c.Usuario.Nombres,
                                   ApellidoUsuario = c.Usuario.Apellidos,
                                   ImagenUrlUsuario = c.Usuario.ImagenUrl
                               })
                            .ToListAsync();
            return comentario;
        }
    }
}
