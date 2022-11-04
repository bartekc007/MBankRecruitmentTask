using EventBus.Messages.Events;
using MassTransit;
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
        private readonly IPublishEndpoint eventBus;

        public F1ContextSeed(IPublishEndpoint eventBus)
        {
            this.eventBus = eventBus;
        }

        public async Task SeedAsync(F1Context context, ILogger<F1ContextSeed> logger)
        {
            if (!context.Drivers.Any() && !context.Construcors.Any() && !context.Races.Any() && !context.Circuits.Any())
            {
                GenerateDataEvent generateDataEvent = new GenerateDataEvent();
                await eventBus.Publish(generateDataEvent);
            }
        }
    }
}
