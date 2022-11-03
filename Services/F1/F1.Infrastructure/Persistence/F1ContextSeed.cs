using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1.Infrastructure.Persistence
{
    public class F1ContextSeed
    {
        public static void SeedAsync(F1Context context, ILogger<F1ContextSeed> logger)
        {
            if (!context.Drivers.Any())
            {
                // RabbitMq Ask for Seed Data another microservice
            }
        }
    }
}
