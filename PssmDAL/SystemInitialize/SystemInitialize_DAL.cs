using Common.Utility;

namespace PssmDAL.SystemInitialize
{
    public class SystemInitialize_DAL
    {
        public bool SystemInitialize()
        {
            return SqlHelper.ExecteNonQueryProducts("Pro_SystemInitialize") == -1;
        }
    }
}
