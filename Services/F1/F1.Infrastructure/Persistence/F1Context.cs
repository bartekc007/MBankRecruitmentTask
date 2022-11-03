using F1.Domain.Common;
using F1.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1.Infrastructure.Persistence
{
    public class F1Context : DbContext
    {
        public F1Context(DbContextOptions<F1Context> options) : base(options) { }

        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Constructor> Construcors { get; set; }
        public DbSet<Race> Races { get; set; }
        public DbSet<Circuit> Circuits { get; set; }

    }
}
