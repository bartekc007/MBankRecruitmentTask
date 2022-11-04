namespace Seed.Entities.XML
{
    public class CircuitCsv : ISheet
    {
        public int CircuitId { get; set; }
        public string CircuitRef { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Lat { get; set; }
        public string Lng { get; set; }
        public string Alt { get; set; }
    }
}
