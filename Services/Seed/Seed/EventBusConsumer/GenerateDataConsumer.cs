using EventBus.Messages.Events;
using MassTransit;
using Seed.Services;

namespace Seed.EventBusConsumer
{
    public class GenerateDataConsumer : IConsumer<GenerateDataEvent>
    {
        private readonly ICsvService csvReader;

        public GenerateDataConsumer(ICsvService csvReader)
        {
            this.csvReader = csvReader;
        }

        public async Task Consume(ConsumeContext<GenerateDataEvent> context)
        {
            await csvReader.readCsvFile();

        }
    }
}
