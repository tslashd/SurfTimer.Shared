using System.Data;
using MySqlConnector;

namespace SurfTimer.Shared.Data.MySql
{
    public class MySqlConnectionStringFactory : IDbConnectionFactory
    {
        private readonly string _connectionString;

        public MySqlConnectionStringFactory(string connectionString) =>
            _connectionString = connectionString;

        public async Task<IDbConnection> OpenConnectionAsync()
        {
            var conn = new MySqlConnection(_connectionString);
            await conn.OpenAsync();
            return conn;
        }
    }
}
