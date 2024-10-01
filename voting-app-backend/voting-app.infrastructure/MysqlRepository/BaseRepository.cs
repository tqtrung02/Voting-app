using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using voting_app.core.Repository;
using voting_app.share.Common;

namespace voting_app.infrastructure.MysqlRepository
{
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity>
    {
        public Task<TEntity> GetByFilterAsync(List<FilterItem> filterItems)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<TEntity>> GetListByFilterAsync()
        {
            throw new NotImplementedException();
        }

        public string GetTableName()
        {
            throw new NotImplementedException();
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
