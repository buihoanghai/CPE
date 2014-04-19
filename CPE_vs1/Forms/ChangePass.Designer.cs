namespace CPE_vs1
{
    partial class ChangePass
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
            this.butcancel = new DevExpress.XtraEditors.SimpleButton();
            this.butchange = new DevExpress.XtraEditors.SimpleButton();
            this.txtAccount = new DevExpress.XtraEditors.TextEdit();
            this.txtOldPass = new DevExpress.XtraEditors.TextEdit();
            this.txtNewPass1 = new DevExpress.XtraEditors.TextEdit();
            this.txtNewPass2 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOldPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewPass1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewPass2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // butcancel
            // 
            this.butcancel.Location = new System.Drawing.Point(104, 112);
            this.butcancel.Name = "butcancel";
            this.butcancel.Size = new System.Drawing.Size(75, 23);
            this.butcancel.TabIndex = 11;
            this.butcancel.Text = "Cancel";
            this.butcancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // butchange
            // 
            this.butchange.Location = new System.Drawing.Point(185, 112);
            this.butchange.Name = "butchange";
            this.butchange.Size = new System.Drawing.Size(75, 23);
            this.butchange.TabIndex = 12;
            this.butchange.Text = "Change";
            this.butchange.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtAccount
            // 
            this.txtAccount.Enabled = false;
            this.txtAccount.Location = new System.Drawing.Point(104, 9);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(156, 20);
            this.txtAccount.TabIndex = 13;
            // 
            // txtOldPass
            // 
            this.txtOldPass.Location = new System.Drawing.Point(104, 35);
            this.txtOldPass.Name = "txtOldPass";
            this.txtOldPass.Size = new System.Drawing.Size(156, 20);
            this.txtOldPass.TabIndex = 14;
            this.txtOldPass.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtOldPass_MouseDown);
            // 
            // txtNewPass1
            // 
            this.txtNewPass1.Location = new System.Drawing.Point(104, 61);
            this.txtNewPass1.Name = "txtNewPass1";
            this.txtNewPass1.Size = new System.Drawing.Size(156, 20);
            this.txtNewPass1.TabIndex = 15;
            this.txtNewPass1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtOldPass_MouseDown);
            // 
            // txtNewPass2
            // 
            this.txtNewPass2.Location = new System.Drawing.Point(104, 87);
            this.txtNewPass2.Name = "txtNewPass2";
            this.txtNewPass2.Size = new System.Drawing.Size(156, 20);
            this.txtNewPass2.TabIndex = 16;
            this.txtNewPass2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtOldPass_MouseDown);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(39, 13);
            this.labelControl1.TabIndex = 17;
            this.labelControl1.Text = "Account";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 38);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(65, 13);
            this.labelControl2.TabIndex = 18;
            this.labelControl2.Text = "Old Password";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 64);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(70, 13);
            this.labelControl3.TabIndex = 19;
            this.labelControl3.Text = "New Password";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 90);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(86, 13);
            this.labelControl4.TabIndex = 20;
            this.labelControl4.Text = "Confirm Password";
            // 
            // ChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 147);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtNewPass2);
            this.Controls.Add(this.txtNewPass1);
            this.Controls.Add(this.txtOldPass);
            this.Controls.Add(this.txtAccount);
            this.Controls.Add(this.butchange);
            this.Controls.Add(this.butcancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ChangePass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Password";
            this.Load += new System.EventHandler(this.Login_Load);
            this.Click += new System.EventHandler(this.ChangePass_Click);
            ((System.ComponentModel.ISupportInitialize)(this.txtAccount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOldPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewPass1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewPass2.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton butcancel;
        private DevExpress.XtraEditors.SimpleButton butchange;
        private DevExpress.XtraEditors.TextEdit txtAccount;
        private DevExpress.XtraEditors.TextEdit txtOldPass;
        private DevExpress.XtraEditors.TextEdit txtNewPass1;
        private DevExpress.XtraEditors.TextEdit txtNewPass2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}