using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace voting_app.core.Entity
{
    public class RecordState
    {
        public string created_by { get; set; }

        public string modified_by { get; set; }

        public DateTime created_date { get; set; }

        public DateTime modified_date { get; set;}
    }
}
