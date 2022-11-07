using F1.Application.Contracts.Persistance;
using F1.Domain.Dto;
using F1.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1.Application.Features.Circuits.GetCircuitListQuery
{
    public class GetCircuitListQueryHandler : IRequestHandler<GetCircuitListQuery, CircuitCollection>
    {
        private readonly ICircuitsRepository _repository;

        public GetCircuitListQueryHandler(ICircuitsRepository repository)
        {
            _repository = repository;
        }

        public async Task<CircuitCollection> Handle(GetCircuitListQuery request, CancellationToken cancellationToken)
        {
            return (CircuitCollection) await _repository.GetAllAsync(request.PageNumber,request.PageSize);
        }
    }
}
