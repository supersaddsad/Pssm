using PssmDAL.DAL;
using PssmPublicLibary.Unitiry;
using System.Data;

namespace PssmBLL.BLL
{
    public class Tb_User_BLL
    {
        /// <summary>
        /// 数据访问层变量
        /// </summary>
        private readonly Tb_User_DAL dal = new Tb_User_DAL();

        #region 判断用户是否存在

        /// <summary>
        /// 判断用户是否存在
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool IsExists(Tb_User user, out Tb_User model)
        {
            return dal.IsExists(user, out model);
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
            return dal.IsExists(user);
        }
        #endregion

        #region 密码是否正确

        /// <summary>
        /// 密码是否正确
        /// </summary>
        /// <param name="user"></param>
        /// <param name="userMode"></param>
        /// <returns></returns>
        public bool ValiedUser(Tb_User user, Tb_User userMode)
        {
            user.Password = TextHelper.GetMd532(user.Password);
            if (user.Password == userMode.Password)
            {
                if (userMode.IsEnabled == false)
                {
                    return true;
                }
            }

            return false;
        }

        #endregion

        #region 获取用户列表
        /// <summary>
        /// 获取用户列表
        /// </summary>
        /// <returns></returns>
        public DataTable GetUserList()
        {
            return dal.GetUsers();
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
            user.Password = TextHelper.GetMd532(user.Password);
            return dal.AddUser(user);
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
            return dal.DeleteUser(UserID);
        }
        #endregion

        #region 启用停用账号
        /// <summary>
        /// 启用停用账号
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="isEnable"></param>
        /// <returns></returns>
        public bool UpdateEnableUser(int ID, short isEnable)
        {
            return dal.UpdateEnableUser(ID, isEnable);
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
            return dal.UpdatePasswd(user);
        } 
        #endregion
    }
}
