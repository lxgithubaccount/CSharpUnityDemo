using DataAccessLibInterface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySqlDAL
{
    public class UserDAL : BaseDAL, IUserDAL
    {
        public int BatchSaveUserInfo(string sqlString, IDbTransaction transaction)
        {
            throw new Exception("使用的是Mysql的UserDAL");
        }
    }
}
