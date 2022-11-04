using AutoMapper;
using CsvHelper;
using CsvHelper.Configuration;
using RabbitMQ.Client.Logging;
using Seed.DatabaseContext;
using Seed.Entities.XML;
using Seed.Helpers;
using System.Globalization;

namespace Seed.Services
{
    public interface ICsvService
    {
        Task readCsvFile();
    }
    public class CsvService : ICsvService
    {
        private readonly IEnumerable<string> _csvFiles = new List<string> { "circuits", "constructors", "drivers", "races" };
        private readonly ILogger<CsvService> _logger;
        private readonly IMapper _mapper;
        private readonly F1Context _context;

        public CsvService(ILogger<CsvService> logger, IMapper mapper, F1Context context)
        {
            _logger = logger;
            _mapper = mapper;
            _context = context;
        }

        public async Task readCsvFile()
        {
            foreach(var sheet in _csvFiles)
            {
                var csvRecords = CsvReaderHelper.ReadCsv(sheet,_mapper);
                await _context.AddRangeAsync(csvRecords);
                _context.SaveChanges();
            }
            
        }
    }
}
