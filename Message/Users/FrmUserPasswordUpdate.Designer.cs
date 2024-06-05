namespace Pssm.Users
{
    partial class FrmUserPasswordUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUserPasswordUpdate));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.TxEdName = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.ButColse = new DevExpress.XtraEditors.SimpleButton();
            this.ButAdd = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.TeEdTpass = new DevExpress.XtraEditors.TextEdit();
            this.TxEdPass = new DevExpress.XtraEditors.TextEdit();
            this.TxEdUser = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxEdName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TeEdTpass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxEdPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxEdUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionLocation = DevExpress.Utils.Locations.Top;
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.TxEdName);
            this.groupControl1.Controls.Add(this.TxEdUser);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.groupControl1.Location = new System.Drawing.Point(2, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(355, 126);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "添加登陆用户";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(68, 76);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 14);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "真实姓名";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(68, 43);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "登陆用户名";
            // 
            // TxEdName
            // 
            this.TxEdName.Location = new System.Drawing.Point(164, 73);
            this.TxEdName.Name = "TxEdName";
            this.TxEdName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TxEdName.Properties.NullText = "";
            this.TxEdName.Properties.PopupFormSize = new System.Drawing.Size(80, 0);
            this.TxEdName.Properties.PopupSizeable = false;
            this.TxEdName.Properties.PopupView = this.gridLookUpEdit1View;
            this.TxEdName.Size = new System.Drawing.Size(100, 20);
            this.TxEdName.TabIndex = 3;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // panelControl1
            // 
            this.panelControl1.AutoSize = true;
            this.panelControl1.Controls.Add(this.groupControl2);
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(359, 299);
            this.panelControl1.TabIndex = 1;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.ButColse);
            this.groupControl2.Controls.Add(this.ButAdd);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Controls.Add(this.TeEdTpass);
            this.groupControl2.Controls.Add(this.TxEdPass);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.groupControl2.Location = new System.Drawing.Point(2, 128);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(355, 169);
            this.groupControl2.TabIndex = 1;
            // 
            // ButColse
            // 
            this.ButColse.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButColse.ImageOptions.SvgImage")));
            this.ButColse.Location = new System.Drawing.Point(258, 135);
            this.ButColse.Name = "ButColse";
            this.ButColse.Size = new System.Drawing.Size(75, 32);
            this.ButColse.TabIndex = 5;
            this.ButColse.Text = "关闭";
            // 
            // ButAdd
            // 
            this.ButAdd.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ButAdd.ImageOptions.SvgImage")));
            this.ButAdd.Location = new System.Drawing.Point(164, 135);
            this.ButAdd.Name = "ButAdd";
            this.ButAdd.Size = new System.Drawing.Size(75, 32);
            this.ButAdd.TabIndex = 4;
            this.ButAdd.Text = "确定";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(68, 98);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(48, 14);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "确认密码";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(68, 49);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(24, 14);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "密码";
            // 
            // TeEdTpass
            // 
            this.TeEdTpass.Location = new System.Drawing.Point(164, 95);
            this.TeEdTpass.Name = "TeEdTpass";
            this.TeEdTpass.Size = new System.Drawing.Size(100, 20);
            this.TeEdTpass.TabIndex = 1;
            // 
            // TxEdPass
            // 
            this.TxEdPass.Location = new System.Drawing.Point(164, 46);
            this.TxEdPass.Name = "TxEdPass";
            this.TxEdPass.Size = new System.Drawing.Size(100, 20);
            this.TxEdPass.TabIndex = 0;
            // 
            // TxEdUser
            // 
            this.TxEdUser.Location = new System.Drawing.Point(164, 37);
            this.TxEdUser.Name = "TxEdUser";
            this.TxEdUser.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TxEdUser.Properties.NullText = "";
            this.TxEdUser.Properties.PopupView = this.gridView1;
            this.TxEdUser.Size = new System.Drawing.Size(100, 20);
            this.TxEdUser.TabIndex = 2;
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // FrmUserPasswordUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 299);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmUserPasswordUpdate";
            this.Text = "密码修改";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxEdName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TeEdTpass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxEdPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxEdUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GridLookUpEdit TxEdName;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton ButColse;
        private DevExpress.XtraEditors.SimpleButton ButAdd;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit TeEdTpass;
        private DevExpress.XtraEditors.TextEdit TxEdPass;
        private DevExpress.XtraEditors.GridLookUpEdit TxEdUser;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}