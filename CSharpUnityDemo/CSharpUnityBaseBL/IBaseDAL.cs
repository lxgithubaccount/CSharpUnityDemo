using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DataAccessLibInterface
{
    /// <summary>
    /// 数据处理的基础接口
    /// </summary>
    public interface IBaseDAL
    {
        /// <summary>
        /// 插入数据
        /// </summary>
        /// <param name="sqlString">执行SQL</param>
        /// <param name="transaction">事务</param>
        /// <returns></returns>
        int insert(string sqlString, IDbTransaction transaction);

        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="sqlString">执行SQL</param>
        /// <param name="transaction">事务</param>
        /// <returns></returns>
        int delete(string sqlString, IDbTransaction transaction);

        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name="sqlString">执行SQL</param>
        /// <param name="transaction">事务</param>
        /// <returns></returns>
        int update(string sqlString, IDbTransaction transaction);

        /// <summary>
        /// 查询数据，返回DataTable
        /// </summary>
        /// <param name="sqlString"></param>
        /// <returns></returns>
        DataTable select(string sqlString);
    }
}
