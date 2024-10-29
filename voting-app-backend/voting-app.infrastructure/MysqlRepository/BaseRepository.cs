using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using voting_app.core.Repository;
using voting_app.share.Common;
using voting_app.share.CustomAttribute;

namespace voting_app.infrastructure.MysqlRepository
{
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity>
    {

        protected IConnectionManager connectionManager { get; set; }

        public BaseRepository(IConnectionManager connectionManager)
        {
            this.connectionManager = connectionManager;
        }

        public Task<TEntity> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }
        public string GetTableName()
        {
            var tType = typeof(TEntity);
            var tableAttr = tType.GetCustomAttribute<TableAttribute>();

            if(tableAttr is null)
            {
                return string.Empty;
            }

            return tableAttr.Name;

        }

        public PropertyInfo GetPrimaryKey()
        {
            throw new NotImplementedException();
        }

        public Dictionary<string, string> GetMasterTableInfo(PropertyInfo foreignKey)
        {
            throw new NotImplementedException();
        }

        public Dictionary<string, Dictionary<string, string>> GetAllMasterTableInfo() {
            throw new NotImplementedException();
        }
    }
}
