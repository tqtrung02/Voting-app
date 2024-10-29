using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using voting_app.application.DTO;
using voting_app.core.Entity;

namespace voting_app.application
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UserDto, UserEntty>();
            CreateMap<UserEntty, UserDto>();
        }
    }
}
