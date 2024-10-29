using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using voting_app.share.Common;
using voting_app.share.Config;

namespace voting_app.infrastructure
{
    public class ConnectionManager : IConnectionManager
    {
        private ContextData contextData;
        private string connectionString { get; set; }
        private IDbConnection connection { get; set; }

        public ConnectionManager(ConnectionConfig connectionConfig)
        {
            this.connectionString = connectionConfig.MysqlConnectionString;
        }

        public void DisposeConnection()
        {

            if (this.connection == null) return;
            this.connection.Close();
            this.connection.Dispose();
        }

        public async Task<IDbConnection> GetConnectionAsync()
        {
            if (this.connection == null)
            {
                var cnn = new MySqlConnection(this.connectionString);
                await cnn.OpenAsync();
                this.connection = cnn;
            }
            return connection;
        }

        public void SetContextData(ContextData contextData)
        {
            this.contextData= contextData;
        }

        public ContextData GetContextData()
        {
            return this.contextData;
        }
    }
}
