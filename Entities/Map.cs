namespace SurfTimer.Shared.Entities
{
    public class Map
    {
        public required int ID { get; set; }
        public required string Name { get; set; }
        public required string Author { get; set; }
        public required short Tier { get; set; }
        public required short Stages { get; set; }
        public required short Bonuses { get; set; }
        public required bool Ranked { get; set; }
        public required int DateAdded { get; set; }
        public required int LastPlayed { get; set; }

    }
}
