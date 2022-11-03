using F1.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1.Application.Features.Constructors.GetConstructorsListQuery
{
    public class GetConstructorsListQuery : IRequest<IEnumerable<Constructor>>
    {
    }
}
