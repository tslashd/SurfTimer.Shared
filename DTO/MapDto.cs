namespace SurfTimer.Shared.DTO
{
    public class MapDto
    {
        public required string Name { get; set; }
        public required string Author { get; set; }
        public required short Tier { get; set; }
        public required short Stages { get; set; }
        public required short Bonuses { get; set; }
        public required bool Ranked { get; set; }
        public int DateAdded { get; set; }
        public int LastPlayed { get; set; }
    }
}
