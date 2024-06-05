using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PssmDAL.DAL;
using YourNamespace;

namespace PssmBLL.BLL
{
    public class Tb_Operate_BLL
    {
        public static int Add(Tb_Operate operate)
        {
            return Tb_Operate_DAL.LogAdd(operate);
        }
    }
}
