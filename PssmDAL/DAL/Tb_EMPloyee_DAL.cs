using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Utility;

namespace PssmDAL.DAL
{
    public class Tb_EMPloyee_DAL
    {
        #region 获取员工列表
        /// <summary>
        /// 获取员工列表
        /// </summary>
        /// <returns></returns>
        public DataTable GetEmp()
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendLine(
                "SELECT EmpID 序号, Name 姓名, LogID 登陆账号, Sex 性别, iDCode 身份证号, Birthday 生日, dpt.DeptName 部门, emp.IsEnable 是否启用");
            sb.AppendLine("FROM dbo.Tb_EMPloyee emp\r\nLEFT JOIN dbo.Tb_Deptment dpt ON dpt.DeptID = emp.DepartmentID");
            return SqlHelper.GetTableText(sb.ToString(), null)[0];
        } 
        #endregion

    }
}
