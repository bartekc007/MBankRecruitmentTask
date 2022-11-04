using CsvHelper.Configuration;
using CsvHelper;
using System.Globalization;
using Seed.Entities.XML;
using Seed.Entities.DbEntities;
using AutoMapper;

namespace Seed.Helpers
{
    public static class CsvReaderHelper
    {
        public static IEnumerable<EntityBase> ReadCsv(string sheet, IMapper _mapper)
        {
            var reader = InitDictionary();

            if (reader.ContainsKey(sheet))
                return reader[sheet].Invoke(_mapper);
            return null;
        }

        private static IDictionary<string, Func<IMapper,IEnumerable<EntityBase>>> InitDictionary()
        {
            return new Dictionary<string, Func<IMapper,IEnumerable<EntityBase>>>()
            {
                {"circuits",ReadCircuits},
                {"constructors",ReadConstructors},
                {"drivers",ReadCDrivers},
                {"races",ReadRaces}
            };
        }

        private static IMapper ReadCircuits(IEnumerable<EntityBase> arg)
        {
            throw new NotImplementedException();
        }

        private static IEnumerable<EntityBase> ReadCircuits(IMapper _mapper)
        {
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                PrepareHeaderForMatch = args => args.Header.ToLower(),
            };

            using (var reader = new StreamReader($"../Seed/Csvs/circuits.csv"))
            using (var csv = new CsvReader(reader, config))
            {
                var records = csv.GetRecords<CircuitCsv>().ToList();
                return _mapper.Map<List<Circuit>>(records);
            }
        }

        private static IEnumerable<EntityBase> ReadConstructors(IMapper _mapper)
        {
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                PrepareHeaderForMatch = args => args.Header.ToLower(),
            };

            using (var reader = new StreamReader($"../Seed/Csvs/constructors.csv"))
            using (var csv = new CsvReader(reader, config))
            {
                var records = csv.GetRecords<ConstructorCsv>().ToList();
                return _mapper.Map<List<Constructor>>(records);
            }
        }

        private static IEnumerable<EntityBase> ReadCDrivers(IMapper _mapper)
        {
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                PrepareHeaderForMatch = args => args.Header.ToLower(),
            };

            using (var reader = new StreamReader($"../Seed/Csvs/drivers.csv"))
            using (var csv = new CsvReader(reader, config))
            {
                var records = csv.GetRecords<DriverCsv>().ToList();
                return _mapper.Map<List<Driver>>(records);
            }
        }

        private static IEnumerable<EntityBase> ReadRaces(IMapper _mapper)
        {
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                PrepareHeaderForMatch = args => args.Header.ToLower(),
            };

            using (var reader = new StreamReader($"../Seed/Csvs/races.csv"))
            using (var csv = new CsvReader(reader, config))
            {
                var records = csv.GetRecords<RaceCsv>().ToList();
                return _mapper.Map<List<Race>>(records);
            }
        }
    }
}
