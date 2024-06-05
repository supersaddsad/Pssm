using PssmDAL.SystemInitialize;

namespace PssmBLL.BLL.SystemInitialize_BLL
{

    public class SystemInitialize_BLL
    {
        private SystemInitialize_DAL systemInitializeDal = new SystemInitialize_DAL();
        public bool SystemInitialize()
        {
            return systemInitializeDal.SystemInitialize();
        }
    }
}
