using F1.Application.Contracts.Persistance;
using F1.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1.Application.Features.Constructors.GetConstructorsListQuery
{
    public class GetConstructorsListQueryHandler : IRequestHandler<GetConstructorsListQuery, IEnumerable<Constructor>>
    {
        private readonly IConstructorsRepository _repository;

        public GetConstructorsListQueryHandler(IConstructorsRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Constructor>> Handle(GetConstructorsListQuery request, CancellationToken cancellationToken)
        {
            return await _repository.GetAllAsync();
        }
    }
}
