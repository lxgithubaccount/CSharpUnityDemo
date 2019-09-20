using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DataAccessLibInterface
{
    public interface IUserDAL
    {
        /// <summary>
        /// 批量新增用户信息
        /// </summary>
        /// <param name="sqlString">执行SQL</param>
        /// <param name="transaction">事务</param>
        /// <returns></returns>
        int BatchSaveUserInfo(string sqlString, IDbTransaction transaction);
    }
}
