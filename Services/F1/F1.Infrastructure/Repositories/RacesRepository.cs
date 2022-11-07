using F1.Application.Contracts.Persistance;
using F1.Domain.Dto;
using F1.Domain.Entities;
using F1.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
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

        public override async Task<BaseCollection<Race>> GetAllAsync(int pageNumber, int pageSize)
        {
            var count = await Task.Run(() => _dbContext.Set<Race>().Count<Race>());
            int skip = pageNumber * pageSize;
            int take = pageSize;
            if ((count - skip) < pageSize)
                take = count - skip;
            List<Race> data = new List<Race>();
            if (take > 0)
                data = await _dbContext.Set<Race>().Skip<Race>(skip).Take<Race>(take).ToListAsync();
            return new RaceCollection
            {
                Data = data,
                ElementCount = count,
                PageSize = take
            };
        }
    }
}
