using F1.Application.Contracts.Persistance;
using F1.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1.Application.Features.Circuits.GetCircuitListQuery
{
    public class GetCircuitListQueryHandler : IRequestHandler<GetCircuitListQuery, IEnumerable<Circuit>>
    {
        private readonly ICircuitsRepository _repository;

        public GetCircuitListQueryHandler(ICircuitsRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Circuit>> Handle(GetCircuitListQuery request, CancellationToken cancellationToken)
        {
            return await _repository.GetAllAsync();
        }
    }
}
