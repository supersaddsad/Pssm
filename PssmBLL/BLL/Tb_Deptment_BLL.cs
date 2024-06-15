using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PssmDAL.DAL;

namespace PssmBLL.BLL
{
    public class Tb_Deptment_BLL
    {
        private Tb_Deptment_DAL dal=new Tb_Deptment_DAL();

        #region 获取部门列表
        /// <summary>
        /// 获取部门列表
        /// </summary>
        /// <returns></returns>
        public DataTable GetDept()
        {
            return dal.GetDept();
        }

        #endregion

        /// <summary>
        /// 删除部门
        /// </summary>
        /// <param name="DeptID"></param>
        /// <returns></returns>
        public int DeleteDept(int DeptID)
        {
            return dal.DeleteDept(DeptID);
        }
    }
}
