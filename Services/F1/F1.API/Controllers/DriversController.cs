using F1.Application.Features.Constructors.GetConstructorsListQuery;
using F1.Application.Features.Drivers.GetDriversListQuery;
using F1.Domain.Dto;
using F1.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Xml.Linq;

namespace F1.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class DriversController : ControllerBase
    {
        private readonly IMediator _mediator;

        public DriversController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("GetAll")]
        [ProducesResponseType(typeof(DriverCollection), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<DriverCollection>> GetAll(int pageNumber)
        {
            var query = new GetDriversListQuery(pageNumber);
            var drivers = await _mediator.Send(query);
            return Ok(drivers);
        }
    }
}
