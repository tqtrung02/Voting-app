using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using voting_app.share.Common;

namespace voting_app.core.Repository
{
    public interface IBaseRepository<TEntity>
    {
        Task<TEntity> GetByIdAsync(Guid id);

        Task<TEntity> GetByFilterAsync(List<FilterItem> filterItems);

        Task<List<TEntity>> GetListByFilterAsync();

    }
}
