using F1.Application.Contracts.Persistance;
using F1.Domain.Dto;
using F1.Domain.Entities;
using F1.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1.Infrastructure.Repositories
{
    public class CircuitsRepository : RepositoryBase<Circuit>, ICircuitsRepository
    {
        public CircuitsRepository(F1Context dbcontext) : base(dbcontext)
        {

        }
         
        public override async Task<BaseCollection<Circuit>> GetAllAsync(int pageNumber, int pageSize)
        {
            var count = await Task.Run(() => _dbContext.Set<Circuit>().Count<Circuit>());
            int skip = pageNumber * pageSize;
            int take = pageSize;
            if ((count - skip) < pageSize)
                take = count - skip;
            List<Circuit> data = new List<Circuit>();
            if (take > 0)
                data = await _dbContext.Set<Circuit>().Skip<Circuit>(skip).Take<Circuit>(take).ToListAsync();
            return new CircuitCollection
            {
                Data = data,
                ElementCount = count,
                PageSize = take
            };
        }
    }
}
