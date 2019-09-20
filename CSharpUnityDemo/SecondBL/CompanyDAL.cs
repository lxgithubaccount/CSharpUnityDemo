using DataAccessLibInterface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySqlDAL
{
    public class CompanyDAL : BaseDAL, ICompanyDAL
    {
        public int BatchSaveCompanyInfo(string sqlString, IDbTransaction transaction)
        {
            throw new Exception("使用的是Mysql的CompanyDAL");
        }
    }
}
