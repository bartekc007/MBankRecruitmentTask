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
    public class ConstructorsRepository : RepositoryBase<Constructor>, IConstructorsRepository
    {
        public ConstructorsRepository(F1Context dbcontext) : base(dbcontext)
        {

        }

        public override async Task<BaseCollection<Constructor>> GetAllAsync(int pageNumber, int pageSize)
        {
            var count = await Task.Run(() => _dbContext.Set<Constructor>().Count<Constructor>());
            int skip = pageNumber * pageSize;
            int take = pageSize;
            if ((count - skip) < pageSize)
                take = count - skip;
            List<Constructor> data = new List<Constructor>();
            if (take > 0)
                data = await _dbContext.Set<Constructor>().Skip<Constructor>(skip).Take<Constructor>(take).ToListAsync();
            return new ConstructorCollection
            {
                Data = data,
                ElementCount = count,
                PageSize = take
            };
        }
    }
}
