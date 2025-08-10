namespace SurfTimer.Shared.DTO
{
    public class RunStatsDto
    {
        public required int Type { get; set; }      // 0 = Map, 1 = Bonus, 2 = Stage
        public required int RunTime { get; set; }
        public required int Stage { get; set; }     // Signifies Bonus number when Type == 1
        public required int Style { get; set; }
        public string? Name { get; set; }
        public required float StartVelX { get; set; }
        public required float StartVelY { get; set; }
        public required float StartVelZ { get; set; }
        public required float EndVelX { get; set; }
        public required float EndVelY { get; set; }
        public required float EndVelZ { get; set; }
        public int RunDate { get; set; }
        public required string ReplayFrames { get; set; } // TODO: Try and change this to ReplayFramesString
    }
}
