using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;

namespace Hexagon.Data.DataAccess.DbExpand
{
    public class OracleHelper
    {
        public static DataTable GetPageTable(string sql, DbParameter[] param, string orderField, string orderType, int pageIndex, int pageSize, ref int count)
        {
            StringBuilder strSql = new StringBuilder();
            if (pageIndex == 0)
            {
                pageIndex = 1;
            }
            int num = (pageIndex - 1) * pageSize;
            int num1 = (pageIndex) * pageSize;
            string OrderBy = "";
            if (!string.IsNullOrEmpty(orderField))
                OrderBy = "Order By " + orderField + " " + orderType + "";
            else
                OrderBy = "order by (select 0)";
            strSql.Append("Select * From (Select ROW_NUMBER() Over (" + OrderBy + ")");
            strSql.Append("  rowNumber, T.* From (" + sql + ")  T )  N Where rowNumber > " + num + " And rowNumber <= " + num1 + "");
            count = Convert.ToInt32(DbHelper.ExecuteScalar(CommandType.Text, "Select Count(1) From (" + sql + ")  t", param));
            IDataReader dr = DbHelper.ExecuteReader(CommandType.Text, strSql.ToString(), param);
            return DatabaseReader.ReaderToDataTable(dr);
        }

       
    }
}
