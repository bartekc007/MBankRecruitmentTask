using F1.Application.Contracts.Persistance;
using F1.Domain.Entities;
using F1.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace F1.Infrastructure.Repositories
{
    public class RacesRepository : RepositoryBase<Race>, IRacesRepository
    {
        public RacesRepository(F1Context dbcontext) : base(dbcontext)
        {

        }
    }
}
