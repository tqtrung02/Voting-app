using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using voting_app.application.Contract;
using voting_app.core.Repository;

namespace voting_app.application.Service
{
    public class CRUDBaseService<TDto, TEntity> : BaseService<TDto, TEntity>, ICRUDBaseService<TDto, TEntity>
    {

        private ICRUDBaseRepository<TEntity> _repository;

        public CRUDBaseService(ICRUDBaseRepository<TEntity> repository, IMapper mapper) : base(repository, mapper)
        {
            _repository = repository;
        }

        public async Task<TDto> CreateAsync(TDto dto)
        {
            var entityCreate = _mapper.Map<TDto, TEntity>(dto);

            await processDataBeforeCreate(dto, entityCreate);

            await beforeCreateAsync(dto, entityCreate);

            var entityResut = await _repository.CreateAsync(entityCreate);

            var dtoResult = _mapper.Map<TEntity, TDto>(entityResut);

            await afterCreateAsync(dtoResult);

            return dtoResult;

        }

        public Task DeleteAsync(TDto dto)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(TDto dto)
        {
            throw new NotImplementedException();
        }


        protected virtual async Task processDataBeforeCreate(TDto dto, TEntity entity)
        {
            return;
        }

        protected virtual async Task beforeCreateAsync(TDto dto, TEntity entity)
        {
            return;
        }

        protected virtual async Task afterCreateAsync(TDto dto)
        {
            return;
        }

    }
}
