using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using voting_app.core.Entity;
using voting_app.core.Repository;

namespace voting_app.infrastructure.MysqlRepository
{
    public abstract class CRUDBaseRepository<TEntity> : BaseRepository<TEntity>, ICRUDBaseRepository<TEntity>
    {
        public CRUDBaseRepository(IConnectionManager connectionManager) : base(connectionManager)
        {

        }


        /// <summary>
        /// xử lý entity trước khi cất
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        protected virtual async  Task<TEntity> ProcessEntityBeforeInsertAsync(TEntity entity)
        {
            if(entity == null)
            {
                return entity;
            }

            // nếu có thông tin ngảy, giờ, người tạo thì gán lại
            if (typeof(TEntity).IsSubclassOf(typeof(RecordState)))
            {
                entity.GetType().GetProperty(nameof(RecordState.created_date)).SetValue(entity, DateTime.Now);
                entity.GetType().GetProperty(nameof(RecordState.modified_date)).SetValue(entity, DateTime.Now);
            }

            return entity;
        }

        public async Task<TEntity> CreateAsync(TEntity entity)
        {
            // gen lệnh insert

            entity = await ProcessEntityBeforeInsertAsync(entity);

            var listPropertyName = entity.GetType().GetProperties().Select(p => p.Name).ToList();
            var listParam = listPropertyName.Select(n => $"@{n}");
            var sql = $"INSERT INTO {GetTableName()} ( {string.Join(',', listPropertyName)} ) VALUES ( {string.Join(',', listParam)} )";

            var param = new DynamicParameters();

            listPropertyName.ForEach(n =>
            {
                var value = entity.GetType().GetProperty(n).GetValue(entity);

                param.Add(n, value);

            });

            var cnn =  await connectionManager.GetConnectionAsync();
            
            await cnn.ExecuteAsync(sql, param);
            return entity;
        }

        public Task DeleteAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
