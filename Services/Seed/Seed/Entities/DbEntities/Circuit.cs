namespace Seed.Entities.DbEntities
{
    public class Circuit : EntityBase
    {
        public string? Ref { get; set; }
        public string? Name { get; set; }
        public string? Location { get; set; }
        public string? Lat { get; set; }
        public string? Ing { get; set; }
        public string? Alt { get; set; }
    }
}
