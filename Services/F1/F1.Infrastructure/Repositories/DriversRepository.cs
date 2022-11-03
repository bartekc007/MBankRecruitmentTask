﻿using F1.Application.Contracts.Persistance;
using F1.Domain.Entities;
using F1.Infrastructure.Persistence;
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
    }
}