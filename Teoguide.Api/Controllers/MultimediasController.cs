using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teoguide.Domain.Model.Response;
using Teoguide.Domain.Service;

namespace Teoguide.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MultimediasController : ControllerBase
    {
        private readonly IMultimediaService _multimediaService;

        public MultimediasController(IMultimediaService multimediaService)
        {
            _multimediaService = multimediaService;
        }

        [HttpGet("imagenes/{id}")]
        public async Task<ActionResult<List<MultimediaRes>>> GetImagesByCentroId(int id)
        {
            return Ok(await _multimediaService.GetImagesByCentroId(id));
        }

    }
}
