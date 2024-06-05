
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Utility;
using PssmPublicLibary.Unitiry;
using SqlSugar.Extensions;

namespace PssmDAL.DAL
{
    public class Tb_User_DAL
    {
        #region 登录业务逻辑
        /// <summary>
        /// 业务逻辑
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool IsExists(Tb_User user, out Tb_User modeUser)
        {
            modeUser = null;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("SELECT * FROM  Tb_User where UserName=@UserName");
            SqlParameter parameter = new SqlParameter("@UserName", SqlDbType.NChar, 10)
            {
                Value = user.Username
            };
            SqlDataReader dataReader = SqlHelper.ExecuteReader(CommandType.Text, sb.ToString(), parameter);
            if (dataReader.Read())
            {
                modeUser = new Tb_User()
                {
                    UserID = dataReader["UserId"].ObjToInt(),
                    Username = dataReader["UserName"].ToString(),
                    Password = dataReader["Password"].ToString(),
                    Email = dataReader["Email"].ToString(),
                    IsEnabled = dataReader["UserName"].ObjToBool(),
                    RealID = dataReader["RealID"].ObjToInt()
                };
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion

    }
}
