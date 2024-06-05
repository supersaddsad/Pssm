using System;
using Utilities;

namespace Pssm.Unitiy
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
