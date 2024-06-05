using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Common.Utility;
using YourNamespace;

namespace PssmDAL.DAL
{
    public class Tb_Operate_DAL
    {
        public static int LogAdd(Tb_Operate tbOperate)
        {
            StringBuilder str=new StringBuilder();
            str.AppendLine(
                "INSERT INTO dbo.Tb_Operate(OperateType, OperateTime, OpertePerson, Statr, ComputName, OperateSystem,CodeType,IP)");
            str.AppendLine("VALUES(@OperateType, @OperateTime, @OpertePerson, @Statr, @ComputName, @OperateSystem,@CodeType,@IP)");
            str.AppendLine(";SELECT @@IDENTITY");
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@OperateType", tbOperate.OperateType),
                new SqlParameter("@OperateTime", tbOperate.OperateTime),
                new SqlParameter("@OpertePerson", tbOperate.OpertePerson),
                new SqlParameter("@Statr", tbOperate.Statr),
                new SqlParameter("@ComputName", tbOperate.ComputName),
                new SqlParameter("@OperateSystem", tbOperate.OperateSystem),
                new SqlParameter("@CodeType", tbOperate.CodeType),
                new SqlParameter("@IP",tbOperate.IP)
            };
            return SqlHelper.ExecteNonQueryText(str.ToString(), sp);
        }
    }
}
