namespace SurfTimer.Shared.Entities
{
    //public class Checkpoint : RunStats
    public class Checkpoint
    {
        public int? MapTimeID { get; set; }
        public required int CP { get; set; }
        public required int RunTime { get; set; }
        public required int EndTouch { get; set; }
        public required int Attempts { get; set; }
        public required float StartVelX { get; set; }
        public required float StartVelY { get; set; }
        public required float StartVelZ { get; set; }
        public required float EndVelX { get; set; }
        public required float EndVelY { get; set; }
        public required float EndVelZ { get; set; }
    }
}
