using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Message.Properties;
using Utilities;

namespace Message
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
                    FmLogin fmLogin=new FmLogin();
                    if (fmLogin.ShowDialog()==DialogResult.OK)
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
