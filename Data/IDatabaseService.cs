﻿using System.Data;

namespace SurfTimer.Shared.Data
{
    public interface IDatabaseService
    {
        /// <summary>
        /// Executes a SQL query and returns multiple results of the specified type.
        /// Suitable for SELECT queries expecting more than one row.
        /// </summary>
        /// <typeparam name="T">The type to map the result rows to.</typeparam>
        /// <param name="sql">The SQL query to execute.</param>
        /// <param name="parameters">Optional parameters for the query.</param>
        /// <returns>A collection of mapped results.</returns>
        Task<IEnumerable<T>> QueryAsync<T>(string sql, object? parameters = null);

        /// <summary>
        /// Executes a SQL query and returns the first result of the specified type, or the default value if no results are found.
        /// Suitable for SELECT queries expecting at most one row.
        /// </summary>
        /// <typeparam name="T">The type to map the result to.</typeparam>
        /// <param name="sql">The SQL query to execute.</param>
        /// <param name="parameters">Optional parameters for the query.</param>
        /// <returns>The mapped result, or null if no row is returned.</returns>
        Task<T?> QueryFirstOrDefaultAsync<T>(string sql, object? parameters = null);

        /// <summary>
        /// Execute non-query (INSERT/UPDATE/DELETE). Returns affected rows.
        /// </summary>
        /// <param name="sql">The SQL query to execute.</param>
        /// <param name="parameters">Optional parameters for the query.</param>
        /// <returns>int affectedRows</returns>
        Task<int> ExecuteAsync(string sql, object? parameters = null);

        /// <summary>
        /// Execute INSERT query and return LAST_INSERT_ID().
        /// </summary>
        /// <param name="sql">The SQL query to execute.</param>
        /// <param name="parameters">Optional parameters for the query.</param>
        /// <returns>int LAST_INSERT_ID()</returns>
        Task<long> InsertAsync(string sql, object? parameters = null);

        /// <summary>
        /// Executes multiple operations within a single transaction using the provided delegate.
        /// Commits the transaction if all operations succeed, otherwise rolls back on error.
        /// </summary>
        /// <param name="operations">A delegate containing the operations to execute within the transaction.</param>
        /// <returns>A task that completes when the transaction is committed or rolled back.</returns>
        Task TransactionAsync(Func<IDbConnection, IDbTransaction, Task> operations);
    }
}
