namespace SurfTimer.Shared.DTO
{
    public class PlayerProfileDto
    {
        public required string Name { get; set; }
        public required ulong SteamID { get; set; }
        public required string Country { get; set; }
        public int JoinDate { get; set; }        // UNIX timestamp
        public int LastSeen { get; set; }        // UNIX timestamp
        public int Connections { get; set; }
    }
}
