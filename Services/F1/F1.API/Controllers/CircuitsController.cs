
using F1.Application.Features.Circuits.GetCircuitListQuery;
using F1.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace F1.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class CircuitsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CircuitsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("GetAll")]
        [ProducesResponseType(typeof(IEnumerable<Circuit>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<Circuit>>> GetAll()
        {
            var query = new GetCircuitListQuery();
            var circuits = await _mediator.Send(query);
            return Ok(circuits);
        }
    }
}
