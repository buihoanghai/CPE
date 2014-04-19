namespace CPE_vs1.Forms
{
    partial class CreditCard
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
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtNameOnCard = new DevExpress.XtraEditors.TextEdit();
            this.txtCreditCardNumber = new DevExpress.XtraEditors.TextEdit();
            this.dateExpiredDate = new DevExpress.XtraEditors.DateEdit();
            this.butOK = new DevExpress.XtraEditors.SimpleButton();
            this.butClose = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtNameOnCard.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCreditCardNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateExpiredDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateExpiredDate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(66, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Name on card";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 41);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(94, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Credit Card number";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 67);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(62, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Expired Date";
            // 
            // txtNameOnCard
            // 
            this.txtNameOnCard.Location = new System.Drawing.Point(114, 12);
            this.txtNameOnCard.Name = "txtNameOnCard";
            this.txtNameOnCard.Size = new System.Drawing.Size(146, 20);
            this.txtNameOnCard.TabIndex = 3;
            // 
            // txtCreditCardNumber
            // 
            this.txtCreditCardNumber.Location = new System.Drawing.Point(114, 38);
            this.txtCreditCardNumber.Name = "txtCreditCardNumber";
            this.txtCreditCardNumber.Size = new System.Drawing.Size(146, 20);
            this.txtCreditCardNumber.TabIndex = 4;
            // 
            // dateExpiredDate
            // 
            this.dateExpiredDate.EditValue = null;
            this.dateExpiredDate.Location = new System.Drawing.Point(114, 64);
            this.dateExpiredDate.Name = "dateExpiredDate";
            this.dateExpiredDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateExpiredDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateExpiredDate.Size = new System.Drawing.Size(146, 20);
            this.dateExpiredDate.TabIndex = 6;
            // 
            // butOK
            // 
            this.butOK.Location = new System.Drawing.Point(104, 90);
            this.butOK.Name = "butOK";
            this.butOK.Size = new System.Drawing.Size(75, 23);
            this.butOK.TabIndex = 7;
            this.butOK.Text = "Ok";
            this.butOK.Click += new System.EventHandler(this.butOK_Click);
            // 
            // butClose
            // 
            this.butClose.Location = new System.Drawing.Point(185, 90);
            this.butClose.Name = "butClose";
            this.butClose.Size = new System.Drawing.Size(75, 23);
            this.butClose.TabIndex = 8;
            this.butClose.Text = "Close";
            this.butClose.Click += new System.EventHandler(this.butClose_Click);
            // 
            // CreditCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 156);
            this.ControlBox = false;
            this.Controls.Add(this.butClose);
            this.Controls.Add(this.butOK);
            this.Controls.Add(this.dateExpiredDate);
            this.Controls.Add(this.txtCreditCardNumber);
            this.Controls.Add(this.txtNameOnCard);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CreditCard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Credit Card";
            ((System.ComponentModel.ISupportInitialize)(this.txtNameOnCard.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCreditCardNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateExpiredDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateExpiredDate.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton butOK;
        private DevExpress.XtraEditors.SimpleButton butClose;
        public DevExpress.XtraEditors.TextEdit txtNameOnCard;
        public DevExpress.XtraEditors.TextEdit txtCreditCardNumber;
        public DevExpress.XtraEditors.DateEdit dateExpiredDate;
    }
}