using F1.Application.Features.Drivers.GetDriversListQuery;
using F1.Application.Features.Races.GetRacesListQuery;
using F1.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Xml.Linq;

namespace F1.API.Controllers
{

    [ApiController]
    [Route("api/v1/[controller]")]
    public class RacesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public RacesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("GetAll")]
        [ProducesResponseType(typeof(IEnumerable<Race>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<Race>>> GetAll()
        {
            var query = new GetRacesListQuery();
            var races = await _mediator.Send(query);
            return Ok(races);
        }
    }
}
