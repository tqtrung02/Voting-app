using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using voting_app.application.Contract;

namespace voting_app.application.Service
{
    public class CRUDBaseService<TDto> : BaseService<TDto>, ICRUDBaseService<TDto>
    {
        public Task<TDto> CreateAsync(TDto entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(TDto entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(TDto entity)
        {
            throw new NotImplementedException();
        }
    }
}
