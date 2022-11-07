using F1.Application.Contracts.Persistance;
using F1.Domain.Dto;
using F1.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1.Application.Features.Races.GetRacesListQuery
{
    public class GetRacesListQueryHandler : IRequestHandler<GetRacesListQuery, RaceCollection>
    {
        private readonly IRacesRepository _racesRepository;

        public GetRacesListQueryHandler(IRacesRepository racesRepository)
        {
            _racesRepository = racesRepository;
        }

        public async Task<RaceCollection> Handle(GetRacesListQuery request, CancellationToken cancellationToken)
        {
            return (RaceCollection) await _racesRepository.GetAllAsync(request.PageNumber, request.PageSize);
        }
    }
}
