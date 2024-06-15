 using DevExpress.XtraBars;
using Pssm.DALFactory;
using Pssm.Properties;
using Pssm.Unitiy;
using PssmBLL.BLL;
using SqlSugar.Extensions;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Utilities;

namespace Pssm.Users
{
    public partial class FrmUserList : DevExpress.XtraEditors.XtraForm
    {
        private readonly Tb_User_BLL userBll = new Tb_User_BLL();
        #region 构造函数
        /// <summary>
        /// 构造函数
        /// </summary>
        public FrmUserList()
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
            gridView1.BestFitColumns();
            barButAdd.ItemClick += new ItemClickEventHandler(BarButAdd_ItemClick);
            barButDel.ItemClick += new ItemClickEventHandler(BarButDel_ItemClick);
            barButCCols.ItemClick += new ItemClickEventHandler(BarButCCols_ItemClick);
            barButEnab.ItemClick += new ItemClickEventHandler(BarButEnab_ItemClick);
            barButNoEn.ItemClick += new ItemClickEventHandler(BarButNoEn_ItemClick);
            BarPrint.ItemClick += new ItemClickEventHandler(BarPrint_ItemClick);
            this.MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Load += new EventHandler(FrmUserList_Load);
            gridView1.MouseDown +=new MouseEventHandler(GridView1_MouseDown) ;
        }
        #endregion

        #region 打印按钮

        /// <summary>
        /// 打印按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BarPrint_ItemClick(object sender, ItemClickEventArgs e)
        {
            Action action = () =>
            {
                GridCont.ShowPrintPreview();
            };
            action.TryCatch();
        }

        #endregion

        #region 右键菜单
        /// <summary>
        /// 右键菜单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GridView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)//如果点击为右键
            {
                //激活右键菜单
                new Point(Cursor.Position.X, Cursor.Position.Y);
                this.popupMenu1.ShowPopup(new Point(Cursor.Position.X, Cursor.Position.Y));

            }
        } 
        #endregion

        #region 禁用
        /// <summary>
        /// 禁用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void BarButNoEn_ItemClick(object sender, ItemClickEventArgs e)
        {
            int selectRow = gridView1.GetSelectedRows()[0];
            int ID = this.gridView1.GetRowCellValue(selectRow, "序号").ObjToInt();
            string UserName = this.gridView1.GetRowCellValue(selectRow, "账号").ToString();
            if (UserName.ToLower().Equals("admin"))
            {
                CommMessageBox.MesBoxCaveat(Resources.AdiminNotDisable);
                return;
            }

            Action action = () =>
            {
                if (userBll.UpdateEnableUser(ID, 0))
                {
                    CommMessageBox.MesBox(Resources.DisableSucce);
                    LoadUserList();
                }
            };
            action.TryCatch();
        }
        #endregion

        #region 启用
        /// <summary>
        /// 启用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void BarButEnab_ItemClick(object sender, ItemClickEventArgs e)
        {
            int selectRow = gridView1.GetSelectedRows()[0];
            int ID = this.gridView1.GetRowCellValue(selectRow, "序号").ObjToInt();

            Action action = () =>
            {
                if (userBll.UpdateEnableUser(ID, 1))
                {
                    CommMessageBox.MesBox(Resources.EnableSucce);
                    LoadUserList();
                }
            };
            action.TryCatch();
        }

        #endregion

        #region 关闭
        /// <summary>
        /// 关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void BarButCCols_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
            Dispose();
        }

        #endregion

        #region 删除
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void BarButDel_ItemClick(object sender, ItemClickEventArgs e)
        {
            int selectRow = gridView1.GetSelectedRows()[0];
            int ID = this.gridView1.GetRowCellValue(selectRow, "序号").ObjToInt();
            string UserName = this.gridView1.GetRowCellValue(selectRow, "账号").ToString();
            if (string.IsNullOrEmpty(UserName)) return;
            if (UserName.ToLower().Equals("admin"))
            {
                CommMessageBox.MesBoxCaveat(Resources.AdminNotDelte);
                return;
            }
            DialogResult result = CommMessageBox.YesNoMesBox(Resources.OKDelete);
            if (result == DialogResult.Yes)
            {
                Action action = () =>
            {
                if (userBll.DeleteUser(ID) == 1)
                {
                    LoadUserList();
                    CommMessageBox.MesBoxCaveat(Resources.DeleteSucce);
                }
            };
                action.TryCatch();
            }
            else
            {
                return;
            }
        }
        #endregion

        #region 增加
        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BarButAdd_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmUserAdd userAdd = DataAccessFactory.OpenForm("Users", nameof(FrmUserAdd)) as FrmUserAdd;
            if (userAdd != null)
            {
                if (userAdd.ShowDialog(this) == DialogResult.OK)
                {
                    LoadUserList();
                }
            }
        }
        #endregion

        #region 加载用户
        /// <summary>
        /// 加载用户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>

        private void FrmUserList_Load(object sender, EventArgs e)
        {
            LoadUserList();
        }

        private void LoadUserList()
        {
            Action action = () =>
            {
                DataTable dataTable = userBll.GetUserList();
                GridCont.DataSource = dataTable;
            };
            action.TryCatch();
        }
        #endregion
    }
}