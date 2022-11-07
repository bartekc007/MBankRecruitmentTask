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
    public class DriversRepository : RepositoryBase<Driver>, IDriversRepository
    {
        public DriversRepository(F1Context dbcontext) : base(dbcontext)
        {

        }

        public override async Task<BaseCollection<Driver>> GetAllAsync(int pageNumber, int pageSize)
        {
            var count = await Task.Run(() => _dbContext.Set<Driver>().Count<Driver>());
            int skip = pageNumber * pageSize;
            int take = pageSize;
            if ((count - skip) < pageSize)
                take = count - skip;
            List<Driver> data = new List<Driver>();
            if (take > 0)
                data = await _dbContext.Set<Driver>().Skip<Driver>(skip).Take<Driver>(take).ToListAsync();
            return new DriverCollection
            {
                Data = data,
                ElementCount = count,
                PageSize = take
            };
        }
    }
}
