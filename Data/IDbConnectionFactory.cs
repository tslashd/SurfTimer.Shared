using System.Data;

namespace SurfTimer.Shared.Data
{
    public interface IDbConnectionFactory
    {
        Task<IDbConnection> OpenConnectionAsync();
    }
}
