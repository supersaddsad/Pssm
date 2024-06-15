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
using PssmBLL.BLL;
using PssmModel.StaticModel;
using SqlSugar;
using SqlSugar.Extensions;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
using Pssm.Properties;
using Utilities;

namespace Pssm.Personnel
{

    public partial class Seperator : DevExpress.XtraEditors.XtraForm
    {

        #region 公用数据常量

        /// <summary>
        /// 公用数据常量
        /// </summary>
        private Tb_Deptment_BLL deptmentBll = new Tb_Deptment_BLL();

        private List<TreeListS> list = new List<TreeListS>();
        private int DeptID;

        #endregion

        #region 构造函数

        /// <summary>
        /// 构造函数
        /// </summary>
        public Seperator()
        {
            InitializeComponent();
            InitializeTreeComponent();
            FrmInitialize();

        }

        #endregion

        #region 初始化界面

        /// <summary>
        /// 初始化界面
        /// </summary>
        private void FrmInitialize()
        {
            setTreeList();
            MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            TerDept.MouseDown += TerDept_MouseDown;
            PopMenu.CloseUp += PopMenu_CloseUp;
            BarButADD.ItemClick += new ItemClickEventHandler(BarButADD_ItemClick);
            BarButDele.ItemClick += new ItemClickEventHandler(BarButDele_ItemClick);
            BarButEnable.ItemClick += new ItemClickEventHandler(BarButEnable_ItemClick);
            BarButNoEnable.ItemClick += new ItemClickEventHandler(BarButNoEnable_ItemClick);

        }









        #endregion

        #region 鼠标弹起事件

        /// <summary>
        /// 鼠标弹起事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PopMenu_CloseUp(object sender, EventArgs e)
        {
            this.TerDept.ContextMenuStrip = null;
        }

        #endregion

        #region 鼠标右键事件

        /// <summary>
        /// 鼠标右键事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TerDept_MouseDown(object sender, MouseEventArgs e)
        {
         
            TreeListHitInfo hitInfo = (sender as TreeList).CalcHitInfo(new Point(e.X, e.Y));
            TreeListNode node = hitInfo.Node;
            if (e.Button == MouseButtons.Right)
            {
                getID(sender);
                if (node != null)
                {

                    node.TreeList.FocusedNode = node;
                    PopMenu.ShowPopup(MousePosition);
                }
            }

        }

        #endregion

        #region 数据初始化

        /// <summary>
        /// 数据初始化
        /// </summary>
        private void InitializeTreeComponent()
        {
            DataTable data = deptmentBll.GetDept();
            this.list.Add(new TreeListS() { Id = 0, ParentId = 0, Name = "所有" });
            foreach (DataRow dataRow in data.Rows)
            {
                TreeListS lis = new TreeListS()
                {
                    Id = dataRow["序号"].ObjToInt(),
                    ParentId = dataRow["ParentID"].ObjToInt(),
                    Name = dataRow["名称"].ToString()

                };
                this.list.Add(lis);
            }

            setTreeList();
        }

        #endregion

        #region 设置树界面

        /// <summary>
        /// 设置树界面
        /// </summary>
        private void setTreeList()
        {
            TerDept.DataSource = list;
            TerDept.KeyFieldName = "Id";
            TerDept.ParentFieldName = "ParentId";
            TerDept.Columns[0].Caption = list[0].Name;
            TerDept.OptionsBehavior.Editable = false;
            TerDept.RowHeight = 20;
            TerDept.OptionsView.ShowCheckBoxes = true; // 显示复选框
            TerDept.OptionsBehavior.AllowRecursiveNodeChecking = true; // 实现节点选择联动
            TerDept.Appearance.OddRow.BackColor = Color.White;
            TerDept.OptionsView.EnableAppearanceOddRow = true;
            TerDept.Appearance.EvenRow.BackColor = Color.AliceBlue;
            TerDept.OptionsView.EnableAppearanceEvenRow = true;
            TerDept.ExpandAll();
        }

        #endregion

        #region 添加事件

        /// <summary>
        /// 添加事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void BarButADD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region 启用事件

        /// <summary>
        /// 启用事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void BarButNoEnable_ItemClick(object sender, ItemClickEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region 禁用事件

        /// <summary>
        /// 禁用事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void BarButEnable_ItemClick(object sender, ItemClickEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region 删除事件

        /// <summary>
        /// 删除事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void BarButDele_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (deptmentBll.DeleteDept(DeptID) == -1)
            {
                CommMessageBox.MesBoxCaveat(Resources.ISParentID);
            }
            else
            {

                CommMessageBox.MesBox(Resources.DeleteSucce);
                TerDept.DataSource = null;
                list.Clear();
                InitializeTreeComponent();

            }


        }

        #endregion

        #region 获取单前选择ID
        /// <summary>
        /// 获取单前选择ID
        /// </summary>
        /// <param name="sender"></param>
        private void getID(object sender)
        {

            DevExpress.XtraTreeList.TreeList treeList = sender as DevExpress.XtraTreeList.TreeList;
            if (treeList != null && treeList.Selection.Count == 1)
            {
                object idValue = null;
                int strIdValue = 0;
                TreeListS nodeData = null;
                //通过TreeList的DataSource属性获取所有节点的List
                List<TreeListS> datasource = treeList.DataSource as List<TreeListS>;
                if (datasource != null)
                {
                    //获取选中节点的集合中第一个的Id属性
                    idValue = treeList.Selection[0].GetValue("Id");
                    strIdValue = idValue.ToString().ObjToInt();
                    //获取当前选中节点DataTreeNode对象
                    nodeData = datasource.Where<TreeListS>(p => p.Id == strIdValue).FirstOrDefault<TreeListS>();
                    {

                        treeList.OptionsSelection.EnableAppearanceFocusedRow = true;
                    }
                    DeptID = nodeData.Id;
                }

            }
        }

        #endregion
    }
}
