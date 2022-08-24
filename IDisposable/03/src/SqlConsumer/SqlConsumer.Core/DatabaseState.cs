using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;

namespace SqlConsumer
{
    public class DatabaseState : IDisposable
    {
        protected SqlConnection _connection;
        private readonly string _connectionString;
        private bool _disposed;

        public DatabaseState(IConfiguration config) : this(config.GetConnectionString("db")) { }

        public DatabaseState(string connectionString)
        {
            _connectionString = connectionString;
        }

        public virtual string GetDate()
        {
            if (_disposed)
            {
                throw new ObjectDisposedException("DatabaseState");
            }

            if (_connection == null)
            {
                _connection = new SqlConnection(_connectionString);
                _connection.Open();
            }
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "SELECT getdate()";
                return command.ExecuteScalar().ToString();
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
                return;

            if (disposing)
            {
                if (_connection != null)
                {
                    _connection.Dispose();
                    _connection = null;
                }
                _disposed = true;
            }
        }
    }
}
