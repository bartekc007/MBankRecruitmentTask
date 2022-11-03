﻿using F1.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1.Application.Contracts.Persistance
{
    public interface IDriversRepository : IAsyncRepository<Driver>
    {
    }
}
