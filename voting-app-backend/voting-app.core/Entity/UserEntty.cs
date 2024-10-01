using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using voting_app.share.CustomAttribute;

namespace voting_app.core.Entity
{
    [Table("User")]
    public class UserEntty : RecordState
    {
        #region Field
        [PrimaryKey]
        public Guid UserId { get; set; }

        public string FullName { get; set; }

        public string Email { get; set; }
        #endregion

        #region Method


        #endregion




    }
}
