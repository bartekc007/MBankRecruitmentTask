using F1.Application.Features.Circuits.GetCircuitListQuery;
using F1.Application.Features.Constructors.GetConstructorsListQuery;
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
    public class ConstructorsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ConstructorsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("GetAll")]
        [ProducesResponseType(typeof(ConstructorCollection), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<ConstructorCollection>> GetAll(int pageNumber)
        {
            var query = new GetConstructorsListQuery(pageNumber);
            var constructors = await _mediator.Send(query);
            return Ok(constructors);
        }
    }
}
