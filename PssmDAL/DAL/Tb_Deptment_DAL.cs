using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Utility;
using SqlSugar.Extensions;

namespace PssmDAL.DAL
{
    public class Tb_Deptment_DAL
    {
        #region 获取部门列表
        /// <summary>
        /// 获取部门列表
        /// </summary>
        /// <returns></returns>
        public DataTable GetDept()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("SELECT DeptID 序号, DeptName 名称, Remark 备注, IsEnable 是否启用,ParentID,LMTime as 更新时间 FROM dbo.Tb_Deptment");
            return SqlHelper.GetTableText(sb.ToString(), null)[0];
        }
        #endregion

        #region 根据ID删除部门
        /// <summary>
        /// 根据ID删除部门
        /// </summary>
        /// <param name="DeptID"></param>
        /// <returns></returns>
        public int DeleteDept(int DeptID)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("SELECT COUNT(ParentID) FROM dbo.Tb_Deptment WHERE DeptID=@DeptID");
            SqlParameter sqlParameter = new SqlParameter("@DeptID", DeptID);
          int  Is=   SqlHelper.ExecuteScalarText(sb.ToString(), sqlParameter).ObjToInt();
          if (Is>1)
          {
              return -1;
          }
          else
          {
              sb.Clear();
              sb.AppendLine("DELETE dbo.Tb_Deptment WHERE DeptID=@DeptID");
              return SqlHelper.ExecteNonQueryText(sb.ToString(), sqlParameter);
            }
        } 

        #endregion

    }
}
