using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using voting_app.application.Contract;
using voting_app.application.DTO;

namespace voting_app.application.Service
{
    public class UserService :  CRUDBaseService<UserDto>, IUserService
    {
    }
}
