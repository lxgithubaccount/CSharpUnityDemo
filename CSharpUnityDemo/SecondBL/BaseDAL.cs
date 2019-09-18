using CSharpUnityBaseBL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondBL
{
    public class BaseDAL : IBaseDAL
    {
        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="sqlString">执行SQL</param>
        /// <param name="transaction">事务</param>
        /// <returns></returns>
        public int delete(string sqlString, IDbTransaction transaction)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 插入数据
        /// </summary>
        /// <param name="sqlString">执行SQL</param>
        /// <param name="transaction">事务</param>
        /// <returns></returns>
        public int insert(string sqlString, IDbTransaction transaction)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 查询数据，返回DataTable
        /// </summary>
        /// <param name="sqlString">执行SQL</param>
        /// <returns></returns>
        public DataTable select(string sqlString)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name="sqlString">执行SQL</param>
        /// <param name="transaction">事务</param>
        /// <returns></returns>
        public int update(string sqlString, IDbTransaction transaction)
        {
            throw new NotImplementedException();
        }
    }
}
