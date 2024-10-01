using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace voting_app.application.Contract
{
    public interface ICRUDBaseService<TDto> : IBaseService<TDto>
    {
        Task UpdateAsync(TDto entity);

        Task DeleteAsync(TDto entity);

        Task<TDto> CreateAsync(TDto entity);
    }
}
