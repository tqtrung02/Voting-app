using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using voting_app.application.Contract;
using voting_app.application.DTO;
using voting_app.core.Entity;
using voting_app.core.Repository;

namespace voting_app.application.Service
{
    public class UserService : CRUDBaseService<UserDto, UserEntty>, IUserService
    {
        public UserService(IUserRepository userRepository, IMapper mapper) : base(userRepository, mapper) { 
        
        }

        protected override Task processDataBeforeCreate(UserDto dto, UserEntty entity)
        {
            var userId = Guid.NewGuid();
            entity.user_id= userId;
            dto.user_id= userId;
            entity.created_by = userId.ToString();
            entity.modified_by = userId.ToString();
            return base.processDataBeforeCreate(dto, entity);
        }
    }
}
