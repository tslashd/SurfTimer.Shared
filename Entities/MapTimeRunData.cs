namespace SurfTimer.Shared.Entities
{
    public class MapTimeRunData : RunStats
    {
        public required int PlayerID { get; set; }
        public required int MapID { get; set; }
        public required int Rank { get; set; }
        public required int TotalCount { get; set; }
    }
}
