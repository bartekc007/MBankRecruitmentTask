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
    public class GetRacesListQuery : IRequest<RaceCollection>
    {
        public GetRacesListQuery(int pageNumber)
        {
            PageNumber = pageNumber;
        }

        public int PageSize { get; } = 25;
        public int PageNumber { get; }
    }
}
