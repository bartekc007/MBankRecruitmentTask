namespace Seed.Entities.XML
{
    public class RaceCsv : ISheet
    {
        public int raceId { get; set; }
        public string year { get; set; }
        public string round { get; set; }
        public int circuitId { get; set; }
        public string name { get; set; }
        public string date { get; set; }
        public string time { get; set; }
    }
}
