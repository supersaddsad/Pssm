using PssmDAL.DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PssmPublicLibary;
using PssmPublicLibary.Unitiry;

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
    } 
    #endregion
}
