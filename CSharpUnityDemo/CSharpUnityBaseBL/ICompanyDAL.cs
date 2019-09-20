using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DataAccessLibInterface
{
    public interface ICompanyDAL : IBaseDAL
    {
        /// <summary>
        /// 批量保存公司信息
        /// </summary>
        /// <param name="sqlString">执行SQL</param>
        /// <param name="transaction">事务</param>
        /// <returns></returns>
        int BatchSaveCompanyInfo(string sqlString, IDbTransaction transaction);
    }
}
