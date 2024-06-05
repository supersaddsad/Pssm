namespace Pssm.Users
{
    partial class FrmUserList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUserList));
            this.BarLiast = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButAdd = new DevExpress.XtraBars.BarButtonItem();
            this.barButDel = new DevExpress.XtraBars.BarButtonItem();
            this.barButEnab = new DevExpress.XtraBars.BarButtonItem();
            this.barButNoEn = new DevExpress.XtraBars.BarButtonItem();
            this.barButCCols = new DevExpress.XtraBars.BarButtonItem();
            this.skinBarSubItem1 = new DevExpress.XtraBars.SkinBarSubItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.barCheckItem1 = new DevExpress.XtraBars.BarCheckItem();
            this.GridCont = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.BarPrint = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.BarLiast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridCont)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            this.SuspendLayout();
            // 
            // BarLiast
            // 
            this.BarLiast.AllowCustomization = false;
            this.BarLiast.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.BarLiast.DockControls.Add(this.barDockControlTop);
            this.BarLiast.DockControls.Add(this.barDockControlBottom);
            this.BarLiast.DockControls.Add(this.barDockControlLeft);
            this.BarLiast.DockControls.Add(this.barDockControlRight);
            this.BarLiast.Form = this;
            this.BarLiast.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButAdd,
            this.barButDel,
            this.barButEnab,
            this.barButNoEn,
            this.barButCCols,
            this.skinBarSubItem1,
            this.barSubItem1,
            this.barCheckItem1,
            this.BarPrint});
            this.BarLiast.MainMenu = this.bar2;
            this.BarLiast.MaxItemId = 9;
            // 
            // bar2
            // 
            this.bar2.BarName = "主菜单";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButAdd),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButDel),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButEnab),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButNoEn),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButCCols),
            new DevExpress.XtraBars.LinkPersistInfo(this.skinBarSubItem1)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "主菜单";
            // 
            // barButAdd
            // 
            this.barButAdd.Caption = "添加用户";
            this.barButAdd.Id = 0;
            this.barButAdd.Name = "barButAdd";
            this.barButAdd.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barButDel
            // 
            this.barButDel.Caption = "删除用户";
            this.barButDel.CloseSubMenuOnClickMode = DevExpress.Utils.DefaultBoolean.False;
            this.barButDel.Id = 1;
            this.barButDel.Name = "barButDel";
            // 
            // barButEnab
            // 
            this.barButEnab.Caption = "启用用户";
            this.barButEnab.Id = 2;
            this.barButEnab.Name = "barButEnab";
            // 
            // barButNoEn
            // 
            this.barButNoEn.Caption = "停用用户";
            this.barButNoEn.Id = 3;
            this.barButNoEn.Name = "barButNoEn";
            // 
            // barButCCols
            // 
            this.barButCCols.Caption = "关闭";
            this.barButCCols.Id = 4;
            this.barButCCols.Name = "barButCCols";
            // 
            // skinBarSubItem1
            // 
            this.skinBarSubItem1.Caption = "皮肤";
            this.skinBarSubItem1.Id = 5;
            this.skinBarSubItem1.Name = "skinBarSubItem1";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.BarLiast;
            this.barDockControlTop.Size = new System.Drawing.Size(620, 21);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 407);
            this.barDockControlBottom.Manager = this.BarLiast;
            this.barDockControlBottom.Size = new System.Drawing.Size(620, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 21);
            this.barDockControlLeft.Manager = this.BarLiast;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 386);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(620, 21);
            this.barDockControlRight.Manager = this.BarLiast;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 386);
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "barSubItem1";
            this.barSubItem1.Id = 6;
            this.barSubItem1.Name = "barSubItem1";
            // 
            // barCheckItem1
            // 
            this.barCheckItem1.Caption = "barCheckItem1";
            this.barCheckItem1.Id = 7;
            this.barCheckItem1.Name = "barCheckItem1";
            // 
            // GridCont
            // 
            this.GridCont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridCont.Location = new System.Drawing.Point(0, 21);
            this.GridCont.MainView = this.gridView1;
            this.GridCont.MenuManager = this.BarLiast;
            this.GridCont.Name = "GridCont";
            this.GridCont.Size = new System.Drawing.Size(620, 386);
            this.GridCont.TabIndex = 4;
            this.GridCont.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.GridCont;
            this.gridView1.Name = "gridView1";
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButAdd),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButNoEn),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButEnab),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButDel),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButCCols),
            new DevExpress.XtraBars.LinkPersistInfo(this.skinBarSubItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.BarPrint)});
            this.popupMenu1.Manager = this.BarLiast;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // BarPrint
            // 
            this.BarPrint.Caption = "打印";
            this.BarPrint.Id = 8;
            this.BarPrint.Name = "BarPrint";
            // 
            // FrmUserList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 407);
            this.Controls.Add(this.GridCont);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("FrmUserList.IconOptions.SvgImage")));
            this.Name = "FrmUserList";
            this.Text = "用户管理";
            ((System.ComponentModel.ISupportInitialize)(this.BarLiast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridCont)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager BarLiast;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem barButAdd;
        private DevExpress.XtraBars.BarButtonItem barButDel;
        private DevExpress.XtraBars.BarButtonItem barButEnab;
        private DevExpress.XtraBars.BarButtonItem barButNoEn;
        private DevExpress.XtraBars.BarButtonItem barButCCols;
        private DevExpress.XtraBars.SkinBarSubItem skinBarSubItem1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl GridCont;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarCheckItem barCheckItem1;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarButtonItem BarPrint;
    }
}