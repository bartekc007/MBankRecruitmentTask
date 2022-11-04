using Microsoft.EntityFrameworkCore;
using Seed.Entities.DbEntities;

namespace Seed.DatabaseContext
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
