using PssmDAL.DAL;
using PssmModel.StaticModel;
using System.Data;
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


        public static DataTable GetAllPass()
        {
            return Tb_Real_DAL.GetAllReal();
        }
    }
}
