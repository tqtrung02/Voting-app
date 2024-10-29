using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using voting_app.application.Contract;
using voting_app.core.Entity;
using voting_app.core.Repository;
using voting_app.share.Common;

namespace voting_app.application.Service
{
    public class BaseService<TDto, TEntity> : IBaseService<TDto, TEntity>
    {
        protected readonly IMapper _mapper;
        protected readonly IBaseRepository<TEntity> _baseRepository;

        public BaseService(IBaseRepository<TEntity> baseRepository, IMapper mapper)
        {
            _baseRepository = baseRepository;
            _mapper = mapper;
        }

        public Task<TDto> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
