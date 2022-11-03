using F1.Application.Contracts.Persistance;
using F1.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1.Application.Features.Races.GetRacesListQuery
{
    public class GetRacesListQueryHandler : IRequestHandler<GetRacesListQuery, IEnumerable<Race>>
    {
        private readonly IRacesRepository _racesRepository;

        public GetRacesListQueryHandler(IRacesRepository racesRepository)
        {
            _racesRepository = racesRepository;
        }

        async Task<IEnumerable<Race>> IRequestHandler<GetRacesListQuery, IEnumerable<Race>>.Handle(GetRacesListQuery request, CancellationToken cancellationToken)
        {
            return await _racesRepository.GetAllAsync();
        }
    }
}
