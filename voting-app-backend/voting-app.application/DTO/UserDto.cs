using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace voting_app.application.DTO
{
    public class UserDto
    {
        public Guid UserId { get; set; }

        public string FullName { get; set; }

        public string Email { get; set; }
    }
}
