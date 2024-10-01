using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using voting_app.core.Entity;
using voting_app.core.Repository;

namespace voting_app.infrastructure.MysqlRepository
{
    public class UserRepository : CRUDBaseRepository<UserEntty>,  IUserRepository
    {
    }
}
