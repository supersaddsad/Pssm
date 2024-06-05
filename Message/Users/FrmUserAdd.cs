using DevExpress.XtraEditors.Controls;
using Pssm.Properties;
using Pssm.Unitiy;
using PssmBLL.BLL;
using SqlSugar.Extensions;
using System;
using System.Data;
using System.Windows.Forms;
using Utilities;

namespace Pssm.Users
{
    public partial class FrmUserAdd : DevExpress.XtraEditors.XtraForm
    {
        #region 数据变量
        /// <summary>
        /// 数据变量
        /// </summary>
        private readonly Tb_User_BLL userBLL = new Tb_User_BLL();
        #endregion

        #region 构造函数
        /// <summary>
        /// 构造函数
        /// </summary>
        public FrmUserAdd()
        {
            InitializeComponent();
            InitializeForm();
        }

        #endregion

        #region 数据初始化

        /// <summary>
        /// 数据初始化
        /// </summary>
        private void InitializeForm()
        {

            MaximizeBox = false;
            MinimizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            DataTable sqlData = Tb_Real_BLL.GetAllPass();
            this.TxEdName.Properties.ImmediatePopup = true;
            this.TxEdName.Properties.TextEditStyle = TextEditStyles.Standard;
            this.TxEdName.Properties.PopupWidthMode = DevExpress.XtraEditors.PopupWidthMode.ContentWidth;
            this.TxEdName.Properties.View.IndicatorWidth = 40;
            this.TxEdName.Properties.DataSource = sqlData;
            TxEdName.Properties.DisplayMember = "ReName";
            TxEdName.Properties.ValueMember = "ReID";
            TxEdName.Properties.AutoComplete = false;//文本框自动补全
            TxEdName.Properties.ImmediatePopup = true;//在输入框按任一可见字符键时立即弹出下拉窗体
            TxEdName.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;//弹框筛选模式:
            TxEdName.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;//控件类型:如只能下拉,可以筛选下拉
            TxEdName.Properties.ShowFooter = false;
            TxEdName.Properties.View.OptionsView.ShowAutoFilterRow = true;
            TxEdName.Properties.Tag = "|ReID|";//个人用Tag存放多列筛选字段
            TxEdName.DeselectAll();
            ButColse.Click += new EventHandler(ButColse_Click);
            ButAdd.Click += new EventHandler(ButAdd_Click);
            ;
        }

        #endregion

        #region 增加用户
        /// <summary>
        /// 增加用户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButAdd_Click(object sender, EventArgs e)
        {
            if (!CheekInput(out Tb_User user)) return;
            if (CheckUserName(user))
            {
                CommMessageBox.MesBoxCaveat(Resources.UserIsExitis);
                return;
            }

            Action asAction = () =>
            {
                if (userBLL.AddUser(user) == 1)
                {
                    DialogResult = DialogResult.OK;
                    CommMessageBox.MesBox(Resources.AddOK);
                    ColseWin();
                }
            };
            asAction.TryCatch();
        }

        #endregion

        #region 用户是否存在
        /// <summary>
        /// 用户是否存在
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        private bool CheckUserName(Tb_User user)
        {
            return userBLL.IsExists(user);
        }

        #endregion

        #region 关闭按钮
        /// <summary>
        ///关闭按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void ButColse_Click(object sender, EventArgs e)
        {
            ColseWin();
        }
        #endregion

        #region 关闭窗口
        /// <summary>
        /// 关闭窗口
        /// </summary>
        private void ColseWin()
        {
            Close();
            Dispose(true);
        }
        #endregion

        #region 检测输入数据
        /// <summary>
        /// 检测输入数据
        /// </summary>
        /// <param name="tbUser"></param>
        /// <returns></returns>
        private bool CheekInput(out Tb_User tbUser)
        {
            DataRow dr = TxEdName.Properties.View.GetFocusedDataRow();
            tbUser = new Tb_User()
            {

                Username = TxEdUser.Text.Trim(),
                Password = TxEdPass.Text.Trim(),
                RealID = dr["ReId"].ObjToInt()
            };
            if (string.IsNullOrEmpty(tbUser.Username))
            {
                CommMessageBox.MesBoxCaveat(Resources.UserIsNull);
                TxEdUser.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(tbUser.Password))
            {
                CommMessageBox.MesBoxCaveat(Resources.PassIsNull);
                TxEdPass.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(TeEdTpass.Text.Trim()))
            {
                CommMessageBox.MesBoxCaveat("确认" + Resources.PassIsNull);
                TeEdTpass.Focus();
                return false;
            }
            else if (!tbUser.Password.Equals(TeEdTpass.Text.Trim()))
            {
                CommMessageBox.MesBoxCaveat(Resources.TwoPass);
                TeEdTpass.Focus();
                return false;
            }
            else
            {
                return true;
            }

        }
        #endregion
    }
}