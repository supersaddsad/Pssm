using Common.Utility;
using SqlSugar.Extensions;
using System.Data;
using System.Data.SqlClient;
using System.Text;

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


        #region 用户是否存在
        /// <summary>
        /// 用户是否存在
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool IsExists(Tb_User user)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("SELECT * FROM  Tb_User where UserName=@UserName");
            SqlParameter parameter = new SqlParameter("@UserName", SqlDbType.NChar, 10)
            {
                Value = user.Username
            };
            SqlDataReader dataReader = SqlHelper.ExecuteReader(CommandType.Text, sb.ToString(), parameter);
            if (dataReader.Read())
            {
                dataReader.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region 获取用户列表
        /// <summary>
        /// 获取用户列表
        /// </summary>
        /// <returns></returns>
        public DataTable GetUsers()
        {
            
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("SELECT UserID AS 序号,Username AS 账号,Password AS 密码,Email AS 邮箱,b.ReName AS 角色,");
            sb.AppendLine("CASE IsEnabled WHEN 1 then '否' ELSE '是' END AS 是否禁用");
            sb.AppendLine("FROM dbo.Tb_User\r\nLEFT JOIN dbo.Tb_Real b ON RealID=b.ReID");
            return SqlHelper.GetTableText(sb.ToString(), null)[0];

        }
        #endregion

        #region 添加用户
        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>

        public int AddUser(Tb_User user)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("declare  @a int\r\nset @a=(SELECT Max(UserID) from Tb_User)\r\ndbcc checkident('Tb_User',reseed,@a)    ");
            sb.AppendLine(
                "INSERT INTO dbo.Tb_User(Username, Password, RealID,IsEnabled)\r\nVALUES(@Username,@Password,@RealID,@IsEnabled)");
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@Username", user.Username),
                new SqlParameter("@Password", user.Password),
                new SqlParameter("@RealID", user.RealID),
                new SqlParameter("@IsEnabled",1)
            };
            return SqlHelper.ExecteNonQueryText(sb.ToString(), sqlParameters);
        }

        #endregion

        #region 删除用户
        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="UserID"></param>
        /// <returns></returns>
        public int DeleteUser(int UserID)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(" SET IDENTITY_INSERT Tb_User  ON DELETE FROM dbo.Tb_User WHERE UserID=@UserID SET IDENTITY_INSERT Tb_User  Off");
            SqlParameter sqlParameters = new SqlParameter("@UserID", UserID);
            return SqlHelper.ExecteNonQueryText(sb.ToString(), sqlParameters);
        }
        #endregion

        #region 启用用户
        /// <summary>
        /// 启用用户
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool UpdateEnableUser(int id, short IsEnable)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("UPDATE dbo.Tb_User SET IsEnabled=@IsEnable WHERE UserID=@UserID");
            SqlParameter[] sqlParameter =
            {
                    new SqlParameter("@UserID", id),
                    new SqlParameter("@IsEnable", IsEnable)
                };
            return SqlHelper.ExecteNonQueryText(sb.ToString(), sqlParameter) > 0;
        }
        #endregion

        #region 更新密码
        /// <summary>
        /// 更新密码
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public int UpdatePasswd(Tb_User user)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("UPDATE dbo.Tb_User SET Password=@Password WHERE UserID=@UserID ");
            SqlParameter[] sqlParameter =
            {
                new SqlParameter("@Password", user.Password),
                new SqlParameter("@UserID", user.UserID)
            };
            return SqlHelper.ExecteNonQueryText(sb.ToString(), sqlParameter);
        } 
        #endregion

    }


}
