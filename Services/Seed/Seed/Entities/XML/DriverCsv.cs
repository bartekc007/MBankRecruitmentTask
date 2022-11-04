namespace Seed.Entities.XML
{
    public class DriverCsv : ISheet
    {
        public int driverId { get; set; }
        public string driverRef { get; set; }
        public string number { get; set; }
        public string code { get; set; }
        public string forename { get; set; }
        public string surname { get; set; }
        public string dob { get; set; }
        public string nationality { get; set; }
    }
}
