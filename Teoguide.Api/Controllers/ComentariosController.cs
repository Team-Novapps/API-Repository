using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teoguide.Domain.Model.Request;
using Teoguide.Domain.Model.Response;
using Teoguide.Domain.Service;

namespace Teoguide.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ComentariosController : ControllerBase
    {
        private readonly IComentarioService _comentarioService;

        public ComentariosController(IComentarioService comentarioService)
        {
            _comentarioService = comentarioService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<ComentarioRes>>> GetAllByCentroHistoricoId(int id)
        {
            return Ok(await _comentarioService.GetComentariosByCentroId(id));
        }

        [HttpPost]
        public async Task<ActionResult<int>> Save([FromBody] ComentarioReq comentarioReq)
        {
            var comentario = await _comentarioService.Save(comentarioReq);
            return Ok(comentario);
        }
    }
}
