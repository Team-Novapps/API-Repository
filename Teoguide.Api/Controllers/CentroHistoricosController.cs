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
    public class CentroHistoricosController : ControllerBase
    {
        private readonly ICentroHistoricoService _centroHistoricoService;

        public CentroHistoricosController(ICentroHistoricoService centroHistoricoService)
        {
            _centroHistoricoService = centroHistoricoService;
        }

        [HttpGet]
        public async Task<ActionResult<List<CentroHistoricoRes>>> GetAll()
        {
            return Ok(await _centroHistoricoService.GetAll());
        }
    }
}
