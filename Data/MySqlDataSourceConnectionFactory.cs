using System.Data;
using MySqlConnector;

namespace SurfTimer.Shared.Data.MySql
{
    /// <summary>Useful for SurfTimer.Api, where we already have MySqlDataSource from DI.</summary>
    public class MySqlDataSourceConnectionFactory : IDbConnectionFactory
    {
        private readonly MySqlDataSource _dataSource;

        public MySqlDataSourceConnectionFactory(MySqlDataSource dataSource) =>
            _dataSource = dataSource;

        public async Task<IDbConnection> OpenConnectionAsync()
        {
            return await _dataSource.OpenConnectionAsync();
        }
    }
}
