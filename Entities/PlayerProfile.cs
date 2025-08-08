namespace SurfTimer.Shared.Entities
{
    public class PlayerProfile
    {
        public required int ID { get; set; }
        public required string Name { get; set; }
        public required ulong SteamID { get; set; }
        public required string Country { get; set; }
        public required int JoinDate { get; set; }
        public required int LastSeen { get; set; }
        public required int Connections { get; set; }
    }
}
