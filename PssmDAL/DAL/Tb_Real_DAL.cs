using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Utility;
using YourNamespace;

namespace PssmDAL.DAL
{
    public class Tb_Real_DAL
    {

        #region 获取当前登录账号角色
        /// <summary>
        /// 获取当前登录账号角色
        /// </summary>
        public static string GetRealName(Tb_Real tbReal)
        {
            string Name = "";
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("SELECT * FROM dbo.Tb_Real WHERE ReID=@ReID");
            SqlParameter parameter = new SqlParameter("@ReID", SqlDbType.Int, 10)
            {
                Value = tbReal.ReID
            };
            SqlDataReader dataReader = SqlHelper.ExecuteReader(CommandType.Text, sb.ToString(), parameter);

            if (dataReader.Read())
            {
                Name = dataReader[1].ToString();
            }


            return Name;
        } 
        #endregion
    }
}
