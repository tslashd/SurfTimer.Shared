namespace SurfTimer.Shared.Entities
{
    public class PlayerStatsRunData : RunStats
    {
        public required int PlayerID { get; set; }
        public required int MapID { get; set; }
        public required int Rank { get; set; }
    }
}
