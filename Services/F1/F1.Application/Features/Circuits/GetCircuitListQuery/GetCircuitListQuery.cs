using F1.Domain.Dto;
using F1.Domain.Entities;
using MediatR;

namespace F1.Application.Features.Circuits.GetCircuitListQuery
{
    public class GetCircuitListQuery :  IRequest<CircuitCollection>
    {
        public GetCircuitListQuery(int pageNumber)
        {
            PageNumber = pageNumber;
        }

        public int PageSize { get; } = 25;
        public int PageNumber { get; }
    }
}
