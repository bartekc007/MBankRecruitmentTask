using F1.Application.Contracts.Persistance;
using F1.Infrastructure.Persistence;
using F1.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1.Infrastructure
{
    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<F1Context>(options =>
            {
                options.UseNpgsql(configuration.GetConnectionString("F1ConnectionString"));
            });
            services.AddScoped(typeof(IAsyncRepository<>), typeof(RepositoryBase<>));
            services.AddScoped<IRacesRepository, RacesRepository>();
            services.AddScoped<ICircuitsRepository, CircuitsRepository>();
            services.AddScoped<IDriversRepository, DriversRepository>();
            services.AddScoped<IConstructorsRepository, ConstructorsRepository>();

            return services;
        }
    }
}
