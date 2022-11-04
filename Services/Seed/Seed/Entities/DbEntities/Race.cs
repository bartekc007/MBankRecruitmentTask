namespace Seed.Entities.DbEntities
{
    public class Race : EntityBase
    {
        public string? Year { get; set; }
        public string? Round { get; set; }
        public int? CircuitId { get; set; }
        public string? Name { get; set; }
        public string? Date { get; set; }
        public string? Time { get; set; }
    }
}
