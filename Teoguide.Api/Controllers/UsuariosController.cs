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
    public class UsuariosController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;

        public UsuariosController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpGet]
        public async Task<ActionResult<List<UsuarioRes>>> GetAll()
        {
            return Ok(await _usuarioService.GetAll());            
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<UsuarioRes>> GetById(int id)
        {
            return Ok(await _usuarioService.Get(id));
        }

        [HttpPost]
        public async Task<ActionResult<UsuarioRes>> Save([FromBody] UsuarioReq usuarioReq)
        {
            var usuario = await _usuarioService.Save(usuarioReq);
            return Ok(usuario);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<UsuarioRes>> Update(int id, [FromBody] UsuarioReq usuarioReq)
        {
            var usuario = await _usuarioService.Update(id, usuarioReq);
            return Ok(usuario);
        }

    }
}
