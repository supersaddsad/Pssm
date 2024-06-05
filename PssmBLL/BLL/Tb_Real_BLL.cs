using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PssmDAL.DAL;
using PssmModel.StaticModel;
using YourNamespace;

namespace PssmBLL.BLL
{
    public class Tb_Real_BLL
    {


        #region 角色业务逻辑
        /// <summary>
        /// 角色业务逻辑
        /// </summary>
        /// <returns></returns>
        public static string GetName()
        {
            Tb_Real tbReal = new Tb_Real()
            {
                ReID = UserInfo.Realid
            };
            return Tb_Real_DAL.GetRealName(tbReal).ToString();
        } 
        #endregion
    }
}
