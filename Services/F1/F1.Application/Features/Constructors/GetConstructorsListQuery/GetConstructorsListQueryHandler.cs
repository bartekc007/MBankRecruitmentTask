using F1.Application.Contracts.Persistance;
using F1.Domain.Dto;
using F1.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1.Application.Features.Constructors.GetConstructorsListQuery
{
    public class GetConstructorsListQueryHandler : IRequestHandler<GetConstructorsListQuery, ConstructorCollection>
    {
        private readonly IConstructorsRepository _repository;

        public GetConstructorsListQueryHandler(IConstructorsRepository repository)
        {
            _repository = repository;
        }

        public async Task<ConstructorCollection> Handle(GetConstructorsListQuery request, CancellationToken cancellationToken)
        {
            return (ConstructorCollection) await _repository.GetAllAsync(request.PageNumber, request.PageSize);
        }
    }
}
