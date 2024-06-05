using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace Message.Unitiy
{
    /// <summary>
    ///静态类
    /// </summary>
    public static class FromUnitiy
    {
        public static void TryCatch(this Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception e)
            {
                CommMessageBox.MesBox(e.Message);
            }
        }

    }
}
