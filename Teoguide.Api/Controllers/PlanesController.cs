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
    public class PlanesController : ControllerBase
    {
        private readonly IPlanService _planService;

        public PlanesController(IPlanService planService)
        {
            _planService = planService;
        }

        [HttpGet]
        public async Task<ActionResult<List<PlanRes>>> GetAll()
        {
            return Ok(await _planService.GetAll());
        }

        [HttpGet("detail/{id}")]
        public async Task<ActionResult<PlanDetail>> GetDetailById(int id)
        {
            return Ok(await _planService.GetDetailById(id));
        }

        [HttpPost]
        public async Task<ActionResult<int>> Save([FromBody] PlanReq planReq)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            else
            {
                return Ok(await _planService.Save(planReq));
            }
        }
    }
}
