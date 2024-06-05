namespace Pssm
{
    partial class FmLogin
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.Ed_user = new DevExpress.XtraEditors.TextEdit();
            this.Ed_pwd = new DevExpress.XtraEditors.TextEdit();
            this.Btlogin = new DevExpress.XtraEditors.SimpleButton();
            this.Btloginexit = new DevExpress.XtraEditors.SimpleButton();
            this.Ch_showPwd = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.Ed_user.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ed_pwd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ch_showPwd.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.labelControl1.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.labelControl1.LineVisible = true;
            this.labelControl1.Location = new System.Drawing.Point(56, 156);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(52, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "用户账号:";
            // 
            // labelControl2
            // 
            this.labelControl2.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Vertical;
            this.labelControl2.LineVisible = true;
            this.labelControl2.Location = new System.Drawing.Point(56, 191);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(52, 14);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "用户密码:";
            // 
            // Ed_user
            // 
            this.Ed_user.Location = new System.Drawing.Point(132, 153);
            this.Ed_user.Name = "Ed_user";
            this.Ed_user.Size = new System.Drawing.Size(150, 20);
            this.Ed_user.TabIndex = 2;
            // 
            // Ed_pwd
            // 
            this.Ed_pwd.Location = new System.Drawing.Point(132, 188);
            this.Ed_pwd.Name = "Ed_pwd";
            this.Ed_pwd.Properties.UseMaskAsDisplayFormat = true;
            this.Ed_pwd.Size = new System.Drawing.Size(150, 20);
            this.Ed_pwd.TabIndex = 3;
            // 
            // Btlogin
            // 
            this.Btlogin.ImageOptions.Image = global::Pssm.Properties.Resources.登录;
            this.Btlogin.Location = new System.Drawing.Point(132, 255);
            this.Btlogin.Name = "Btlogin";
            this.Btlogin.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.Btlogin.Size = new System.Drawing.Size(63, 32);
            this.Btlogin.TabIndex = 4;
            this.Btlogin.Text = "登陆";
            // 
            // Btloginexit
            // 
            this.Btloginexit.ImageOptions.Image = global::Pssm.Properties.Resources.退出;
            this.Btloginexit.Location = new System.Drawing.Point(220, 255);
            this.Btloginexit.Name = "Btloginexit";
            this.Btloginexit.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.Btloginexit.Size = new System.Drawing.Size(62, 32);
            this.Btloginexit.TabIndex = 5;
            this.Btloginexit.Text = "退出";
            // 
            // Ch_showPwd
            // 
            this.Ch_showPwd.Location = new System.Drawing.Point(132, 215);
            this.Ch_showPwd.Name = "Ch_showPwd";
            this.Ch_showPwd.Properties.Caption = "显示密码";
            this.Ch_showPwd.Size = new System.Drawing.Size(75, 20);
            this.Ch_showPwd.TabIndex = 6;
            // 
            // FmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 299);
            this.Controls.Add(this.Ch_showPwd);
            this.Controls.Add(this.Btloginexit);
            this.Controls.Add(this.Btlogin);
            this.Controls.Add(this.Ed_pwd);
            this.Controls.Add(this.Ed_user);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FmLogin";
            this.Text = "工资管理";
            ((System.ComponentModel.ISupportInitialize)(this.Ed_user.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ed_pwd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ch_showPwd.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit Ed_user;
        private DevExpress.XtraEditors.TextEdit Ed_pwd;
        private DevExpress.XtraEditors.SimpleButton Btlogin;
        private DevExpress.XtraEditors.SimpleButton Btloginexit;
        private DevExpress.XtraEditors.CheckEdit Ch_showPwd;
    }
}

