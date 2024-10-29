using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using voting_app.share.CustomAttribute;

namespace voting_app.core.Entity
{
    [Table("user")]
    public class UserEntty : RecordState
    {
        #region Field
        [PrimaryKey]
        public Guid user_id { get; set; }

        public string email { get; set; }
        #endregion

        #region Method


        #endregion




    }
}
