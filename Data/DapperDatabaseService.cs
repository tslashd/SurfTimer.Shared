using System.Data;
using Dapper;

namespace SurfTimer.Shared.Data
{
    public class DapperDatabaseService : IDatabaseService
    {
        private readonly IDbConnectionFactory _factory;

        public DapperDatabaseService(IDbConnectionFactory factory)
        {
            _factory = factory;
        }

        public async Task<IEnumerable<T>> QueryAsync<T>(string sql, object? parameters = null)
        {
            await using var conn =
                (IDisposable?)await _factory.OpenConnectionAsync() as IAsyncDisposable ?? null;
            using var c = await _factory.OpenConnectionAsync(); // fallback if not IAsyncDisposable
            var connection =
                c as System.Data.Common.DbConnection
                ?? throw new System.InvalidOperationException("DbConnection required.");

            return await connection.QueryAsync<T>(sql, parameters);
        }

        public async Task<T?> QueryFirstOrDefaultAsync<T>(string sql, object? parameters = null)
        {
            using var conn = await _factory.OpenConnectionAsync();
            return await conn.QueryFirstOrDefaultAsync<T>(sql, parameters);
        }

        public async Task<int> ExecuteAsync(string sql, object? parameters = null)
        {
            using var conn = await _factory.OpenConnectionAsync();
            using var tx = await (conn as System.Data.Common.DbConnection)!.BeginTransactionAsync();
            try
            {
                var rows = await conn.ExecuteAsync(sql, parameters, tx);
                await tx.CommitAsync();
                return rows;
            }
            catch
            {
                await tx.RollbackAsync();
                throw;
            }
        }

        public async Task<long> InsertAsync(string sql, object? parameters = null)
        {
            using var conn = await _factory.OpenConnectionAsync();
            using var tx = await (conn as System.Data.Common.DbConnection)!.BeginTransactionAsync();
            try
            {
                _ = await conn.ExecuteAsync(sql, parameters, tx);
                var id = await conn.ExecuteScalarAsync<long>(
                    "SELECT LAST_INSERT_ID();",
                    transaction: tx
                );
                await tx.CommitAsync();
                return id;
            }
            catch
            {
                await tx.RollbackAsync();
                throw;
            }
        }

        public async Task TransactionAsync(Func<IDbConnection, IDbTransaction, Task> operations)
        {
            using var conn = await _factory.OpenConnectionAsync();
            using var tx = await (conn as System.Data.Common.DbConnection)!.BeginTransactionAsync();
            try
            {
                await operations(conn, tx);
                await tx.CommitAsync();
            }
            catch
            {
                await tx.RollbackAsync();
                throw;
            }
        }
    }
}
