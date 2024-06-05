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
