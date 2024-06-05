using Pssm.Properties;
using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;
using Utilities;

namespace Pssm
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            new Mutex(true, Process.GetCurrentProcess().ProcessName, out bool isCreatedNew);//判断窗体重复启动
            if (isCreatedNew)
            {
                FmLogin fmLogin = new FmLogin();
                if (fmLogin.ShowDialog() == DialogResult.OK)
                {

                    Application.Run(new FmMain());
                }
                else
                {
                    CommMessageBox.Caption = "程序已经运行";
                    CommMessageBox.MesBoxError(Resources.FromIsTwo);
                }
            }
        }
    }
}
