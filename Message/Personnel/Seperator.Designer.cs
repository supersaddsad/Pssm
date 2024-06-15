namespace Pssm.Personnel
{
    partial class Seperator
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
            this.TerDept = new DevExpress.XtraTreeList.TreeList();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.BarMan = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.BarButADD = new DevExpress.XtraBars.BarButtonItem();
            this.BarButDele = new DevExpress.XtraBars.BarButtonItem();
            this.BarButEnable = new DevExpress.XtraBars.BarButtonItem();
            this.BarButNoEnable = new DevExpress.XtraBars.BarButtonItem();
            this.PopMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.TerDept)).BeginInit();
            this.TerDept.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BarMan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PopMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // TerDept
            // 
            this.TerDept.Controls.Add(this.barDockControlLeft);
            this.TerDept.Controls.Add(this.barDockControlRight);
            this.TerDept.Controls.Add(this.barDockControlBottom);
            this.TerDept.Controls.Add(this.barDockControlTop);
            this.TerDept.Dock = System.Windows.Forms.DockStyle.Left;
            this.TerDept.Location = new System.Drawing.Point(0, 0);
            this.TerDept.Name = "TerDept";
            this.TerDept.OptionsMenu.ShowExpandCollapseItems = false;
            this.TerDept.Size = new System.Drawing.Size(476, 371);
            this.TerDept.TabIndex = 0;
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.BarMan;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 371);
            // 
            // BarMan
            // 
            this.BarMan.DockControls.Add(this.barDockControlTop);
            this.BarMan.DockControls.Add(this.barDockControlBottom);
            this.BarMan.DockControls.Add(this.barDockControlLeft);
            this.BarMan.DockControls.Add(this.barDockControlRight);
            this.BarMan.Form = this.TerDept;
            this.BarMan.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.BarButADD,
            this.BarButDele,
            this.BarButEnable,
            this.BarButNoEnable});
            this.BarMan.MaxItemId = 4;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.BarMan;
            this.barDockControlTop.Size = new System.Drawing.Size(476, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 371);
            this.barDockControlBottom.Manager = this.BarMan;
            this.barDockControlBottom.Size = new System.Drawing.Size(476, 0);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(476, 0);
            this.barDockControlRight.Manager = this.BarMan;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 371);
            // 
            // BarButADD
            // 
            this.BarButADD.Caption = "添加";
            this.BarButADD.Id = 0;
            this.BarButADD.Name = "BarButADD";
            // 
            // BarButDele
            // 
            this.BarButDele.Caption = "删除";
            this.BarButDele.Id = 1;
            this.BarButDele.Name = "BarButDele";
            // 
            // BarButEnable
            // 
            this.BarButEnable.Caption = "禁用";
            this.BarButEnable.Id = 2;
            this.BarButEnable.Name = "BarButEnable";
            // 
            // BarButNoEnable
            // 
            this.BarButNoEnable.Caption = "启用";
            this.BarButNoEnable.Id = 3;
            this.BarButNoEnable.Name = "BarButNoEnable";
            // 
            // PopMenu
            // 
            this.PopMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.BarButADD),
            new DevExpress.XtraBars.LinkPersistInfo(this.BarButDele),
            new DevExpress.XtraBars.LinkPersistInfo(this.BarButEnable),
            new DevExpress.XtraBars.LinkPersistInfo(this.BarButNoEnable)});
            this.PopMenu.Manager = this.BarMan;
            this.PopMenu.Name = "PopMenu";
            // 
            // Seperator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 371);
            this.Controls.Add(this.TerDept);
            this.Name = "Seperator";
            this.Text = "Seperator";
            ((System.ComponentModel.ISupportInitialize)(this.TerDept)).EndInit();
            this.TerDept.ResumeLayout(false);
            this.TerDept.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BarMan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PopMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList TerDept;
        private DevExpress.XtraBars.PopupMenu PopMenu;
        private DevExpress.XtraBars.BarButtonItem BarButADD;
        private DevExpress.XtraBars.BarButtonItem BarButDele;
        private DevExpress.XtraBars.BarButtonItem BarButEnable;
        private DevExpress.XtraBars.BarButtonItem BarButNoEnable;
        private DevExpress.XtraBars.BarManager BarMan;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
    }
}