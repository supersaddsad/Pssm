using DevExpress.XtraEditors.Controls;
using PssmBLL.BLL;
using SqlSugar.Extensions;
using System;
using System.Data;
using System.Windows.Forms;
using Pssm.Properties;
using Pssm.Unitiy;
using PssmPublicLibary.Unitiry;
using Utilities;

namespace Pssm.Users
{
    public partial class FrmUserPasswordUpdate : DevExpress.XtraEditors.XtraForm
    {
        private Tb_User_BLL usBll = new Tb_User_BLL();
        public FrmUserPasswordUpdate()
        {
            InitializeComponent();
            DateInitialize();
        }

        #region 数据初始化
        /// <summary>
        /// 数据初始化
        /// </summary>
        public void DateInitialize()
        {
            MaximizeBox = false;
            MinimizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            DataTable sqlData = Tb_Real_BLL.GetAllPass();
            TxEdUser.Properties.ImmediatePopup = true;
            TxEdUser.Properties.TextEditStyle = TextEditStyles.Standard;
            TxEdUser.Properties.PopupWidthMode = DevExpress.XtraEditors.PopupWidthMode.ContentWidth;
            TxEdUser.Properties.View.IndicatorWidth = 40;
            TxEdUser.Properties.DataSource = usBll.GetUserList();
            TxEdUser.Properties.DisplayMember = "账号";
            TxEdUser.Properties.ValueMember = "序号";
            TxEdUser.Properties.AutoComplete = false;//文本框自动补全
            TxEdUser.Properties.ImmediatePopup = true;//在输入框按任一可见字符键时立即弹出下拉窗体
            TxEdUser.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;//弹框筛选模式:
            TxEdUser.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;//控件类型:如只能下拉,可以筛选下拉
            TxEdUser.Properties.SearchMode = (DevExpress.XtraEditors.Repository.GridLookUpSearchMode)SearchMode.OnlyInPopup;
            TxEdUser.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            TxEdUser.Properties.View.BestFitColumns();
            TxEdUser.Properties.ShowFooter = false;
            TxEdUser.Properties.View.OptionsView.ShowAutoFilterRow = true;
            TxEdUser.Properties.Tag = "|账号|";//个人用Tag存放多列筛选字段
            TxEdName.Properties.NullText = Resources.SeachUser;
            TxEdUser.EditValueChanged += new EventHandler(TxEdUser_EditValueChanged); ;
            ButColse.Click += ButColse_Click;
            ButAdd.Click += ButAdd_Click;
        }

       
        #endregion

        #region 用户名编辑值变化
        /// <summary>
        /// 用户名编辑值变化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxEdUser_EditValueChanged(object sender, EventArgs e)
        {
            Action action = () =>
            {
                DataRow dr = TxEdUser.Properties.View.GetFocusedDataRow();
                TxEdName.Properties.NullText = dr["角色"].ToString();
                TxEdName.Properties.ReadOnly = true;

            };
            action.TryCatch();
        } 
        #endregion


        #region 保存密码
        /// <summary>
        /// 保存密码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButAdd_Click(object sender, EventArgs e)
        {
            if (PasswdIn())
            {
                DataRow dr = TxEdUser.Properties.View.GetFocusedDataRow();
                Tb_User user
                    = new Tb_User()
                    {
                        UserID = dr["序号"].ObjToInt(),
                        Username = dr["账号"].ToString(),
                        Password = TextHelper.GetMd532(TxEdPass.Text.Trim())
                    };
                if (usBll.UpdatePasswd(user) == 1)
                {
                    CommMessageBox.MesBox(Resources.SaveSucce);
                }
            }
            else
            {
                return;
            }
        }
        #endregion

        #region 关闭按钮
        /// <summary>
        /// 关闭按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButColse_Click(object sender, EventArgs e)
        {
            CloseWin();
        } 
        #endregion

        #region 关闭窗口
        /// <summary>
        /// 关闭窗口
        /// </summary>
        private void CloseWin()
        {
            Close();
            Dispose();
        }
        #endregion

        #region 数据校验
        /// <summary>
        /// 数据校验
        /// </summary>
        /// <returns></returns>
        private bool PasswdIn()
        {

            if (string.IsNullOrEmpty(TxEdPass.Text.Trim()))
            {
                CommMessageBox.MesBoxCaveat(Resources.PassIsNull);
                return false;
            }
            else if (string.IsNullOrEmpty(TeEdTpass.Text.Trim()))
            {
                CommMessageBox.MesBoxCaveat("二次" + Resources.PassIsNull);
                return false;
            }
            else if (!TxEdPass.Text.Trim().Equals(TeEdTpass.Text.Trim()))
            {
                CommMessageBox.MesBoxCaveat(Resources.TwoPass);
                return false;
            }
            else if (TxEdUser.EditValue == null)
            {
                CommMessageBox.MesBoxCaveat(Resources.SeachUser);
                return false;
            }
            else
            {
                return true;
            }

            #endregion
        }

    }
}