using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using voting_app.application.Contract;
using voting_app.share.Common;

namespace voting_app.application.Service
{
    public class BaseService<TDto> : IBaseService<TDto>
    {
        public Task<TDto> GetByFilterAsync(List<FilterItem> filterItems)
        {
            throw new NotImplementedException();
        }

        public Task<TDto> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<TDto>> GetListByFilterAsync()
        {
            throw new NotImplementedException();
        }
    }
}
