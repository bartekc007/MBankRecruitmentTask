using F1.Application.Contracts.Persistance;
using F1.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1.Application.Features.Drivers.GetDriversListQuery
{
    public class GetDriversListQueryHandler : IRequestHandler<GetDriversListQuery, IEnumerable<Driver>>
    {
        private readonly IDriversRepository _driversRepository;

        public GetDriversListQueryHandler(IDriversRepository driversRepository)
        {
            _driversRepository = driversRepository;
        }

        public async Task<IEnumerable<Driver>> Handle(GetDriversListQuery request, CancellationToken cancellationToken)
        {
            return await _driversRepository.GetAllAsync();
        }
    }
}
