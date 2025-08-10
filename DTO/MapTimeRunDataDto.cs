using SurfTimer.Shared.Entities;

namespace SurfTimer.Shared.DTO
{
    public class MapTimeRunDataDto : RunStatsDto
    {
        public Dictionary<int, CheckpointEntity>? Checkpoints { get; set; }
        public required int PlayerID { get; set; }
        public required int MapID { get; set; }

        public MapTimeRunDataDto() { }
    }
}
