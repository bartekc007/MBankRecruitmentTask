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
    public class GetConstructorsListQuery : IRequest<ConstructorCollection>
    {
        public GetConstructorsListQuery(int pageNumber)
        {
            PageNumber = pageNumber;
        }

        public int PageSize { get; } = 25;
        public int PageNumber { get; }
    }
}
