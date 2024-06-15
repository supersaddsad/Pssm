using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using Pssm.Unitiy;
using PssmBLL.BLL;
using YourNamespace;

namespace Pssm.Personnel
{
    public partial class FrmlodifyPass : DevExpress.XtraEditors.XtraForm
    {

        private Tb_EMPloyee_BLL bll=new Tb_EMPloyee_BLL();

        #region 构造函数
        /// <summary>
        /// 构造函数
        /// </summary>
        public FrmlodifyPass()
        {
            InitializeComponent();
            DataInitialize();
        } 
        #endregion

        #region 数据初始化
        /// <summary>
        /// 数据初始化
        /// </summary>
        private void DataInitialize()
        {
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Load += new EventHandler(FrmlodifyPass_Load);
            barButAdd.ItemClick +=new ItemClickEventHandler(BarButAdd_ItemClick) ;
            gridView1.MouseDown += GridView1_MouseDown;
            BarPrint.ItemClick +=new ItemClickEventHandler(BarPrint_ItemClick) ;
            barButCCols.ItemClick += BarButCCols_ItemClick;
        }




        #endregion

        #region 加载事件
        /// <summary>
        /// 加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmlodifyPass_Load(object sender, EventArgs e)
        {
            LoadList();
        } 
        #endregion

        #region 加载用户列表
        /// <summary>
        /// 加载用户列表
        /// </summary>
        private void LoadList()
        {
            Action action = () =>
            {
                DataTable da = bll.GetEmp();
                GridCont.DataSource = da;
            };
            action.TryCatch();
        }
        #endregion

        #region 添加用户
        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void BarButAdd_ItemClick(object sender, ItemClickEventArgs e)
        {
            throw new NotImplementedException();
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

        #region 关闭
        /// <summary>
        /// 关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BarButCCols_ItemClick(object sender, ItemClickEventArgs e)
        {
            WinColse();
        }

        private void WinColse()
        {
            Close();
            Dispose();
        } 
        #endregion

    }
}