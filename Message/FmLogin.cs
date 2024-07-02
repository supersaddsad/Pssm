using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Resources;
using System.Text;
using System.Windows.Forms;
using Message.Unitiy;
using PssmBLL.BLL;
using PssmModel.StaticModel;
using PssmPublicLibary.Enum;
using Utilities;
using YourNamespace;
using System.Security.Principal;

{
    public partial class FmLogin : DevExpress.XtraEditors.XtraForm
    {
        public FmLogin()
        {
            InitializeComponent();
            DataInitial();
        }

        #region 数据初始化
        /// <summary>
        /// 数据初始化
        /// </summary>
        public void DataInitial()
        {
            this.BackgroundImage = Resources.登陆背景;

            Btlogin.Click += Btlogin_Click;
            Btloginexit.Click += Btloginexit_Click;
            Ch_showPwd.CheckedChanged += Ch_showPwd_CheckedChanged;
            Ed_pwd.Properties.PasswordChar = '*';

        }


        #endregion

        #region 显示密码
        /// <summary>
        /// 显示密码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Ch_showPwd_CheckedChanged(object sender, EventArgs e)
        {
            if (!Ch_showPwd.Checked)
            {
                Ed_pwd.Properties.PasswordChar = '*';
            }
            else
            {
                Ed_pwd.Properties.PasswordChar = '\0';
            }
        } 
        #endregion

        #region 退出
        /// <summary>
        /// 退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void Btloginexit_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }
        #endregion

        #region 登陆

        /// <summary>
        /// 登陆
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>

        private void Btlogin_Click(object sender, EventArgs e)
        {
            Tb_User model = new Tb_User();
            Tb_User_BLL userBll = new Tb_User_BLL();
            {
                Username = Ed_user.Text.Trim(),
                Password = Ed_pwd.Text.Trim()
            };
            Action action = new Action(() =>
            {
                {
                    CommMessageBox.MesBoxError(Resources.UserIsExitis);
                }
                else
                {
                    if (userBll.ValiedUser(user, model))
                    {
                        CommMessageBox.OKCancelMesBox(Resources.UserSuccer);
                        UserInfo.UserName = user.Username;
                        UserInfo.Realid = model.RealID;
                        DialogResult = DialogResult.OK;
                        AddLoginLog(user.Username);
                    }
                    else
                    {
                        CommMessageBox.MesBoxError(Resources.UsePawErroy);
                    }
                }
            });
            action.TryCatch();
        }
        #endregion

        #region 数据校验
        /// <summary>
        /// 数据校验
        /// </summary>
        /// <param name="tbUser"></param>
        /// <returns></returns>
        public bool InputCheek(Tb_User tbUser)
        {
            bool bRet;
            if (string.IsNullOrEmpty(tbUser.Username))
            {
                CommMessageBox.MesBoxCaveat(Resources.UserIsNull);
                Ed_user.Focus();
                bRet = false;
            }
            else if (string.IsNullOrEmpty(tbUser.Password))
            {
                CommMessageBox.MesBoxCaveat(Resources.PassIsNull);
                Ed_pwd.Focus();
                bRet = false;
            }
            else
            {
                bRet = true;
            }

            return bRet;
        }
        #endregion

        #region 添加登陆日志
        /// <summary>
        /// 添加登陆日志
        /// </summary>
        /// <param name="UserName"></param>
        public void AddLoginLog(string UserName)
        {
            Tb_Operate operate = new Tb_Operate()
            {
                OperateTime = DateTime.Now,
                ComputName = Dns.GetHostEntry("localhost").HostName,
                OperateType = Resources.OpertypeLogin,
                OpertePerson = UserName,
                Statr = Resources.UserSuccer,
                OperateSystem = System.Runtime.InteropServices.RuntimeInformation.OSDescription,
                CodeType = (int)EnumCOdeType.SystemLogin,
                IP = Dns.GetHostEntry(Dns.GetHostName()).AddressList[0].ToString()
            };
            Tb_Operate_BLL.Add(operate);
        } 
        #endregion

    }
}
