using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PssmDAL.DAL;

namespace PssmBLL.BLL
{
    public class Tb_EMPloyee_BLL
    {
        private Tb_EMPloyee_DAL dal=new Tb_EMPloyee_DAL();

        #region 获取员工列表
        /// <summary>
        /// 获取员工列表
        /// </summary>
        /// <returns></returns>
        public DataTable GetEmp()
        {
            return dal.GetEmp();
        } 
        #endregion
    }
}
