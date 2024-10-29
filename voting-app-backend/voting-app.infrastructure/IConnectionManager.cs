using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using voting_app.share.Common;

namespace voting_app.infrastructure
{
    public interface IConnectionManager
    {

        /// <summary>
        /// lấy ra connection
        /// </summary>
        /// <returns></returns>
        Task<IDbConnection> GetConnectionAsync();

        /// <summary>
        /// giải phóng connection
        /// </summary>
        /// <returns></returns>
        void DisposeConnection();
    }
}
