namespace CPE_vs1
{
    partial class UpdateCustomer
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
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule7 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule4 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule5 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.panel1 = new System.Windows.Forms.Panel();
            this.butcancel = new DevExpress.XtraEditors.SimpleButton();
            this.butok = new DevExpress.XtraEditors.SimpleButton();
            this.groupPassport = new System.Windows.Forms.GroupBox();
            this.labelControl35 = new DevExpress.XtraEditors.LabelControl();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.DateExpiredDate = new DevExpress.XtraEditors.DateEdit();
            this.lblexpiredDate = new DevExpress.XtraEditors.LabelControl();
            this.dateEditDOB = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblpassport = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtCustomerName = new DevExpress.XtraEditors.TextEdit();
            this.txtNationality = new DevExpress.XtraEditors.TextEdit();
            this.txtPassport = new DevExpress.XtraEditors.TextEdit();
            this.txtPhone = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.valid = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.panel1.SuspendLayout();
            this.groupPassport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateExpiredDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateExpiredDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDOB.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDOB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNationality.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassport.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.butcancel);
            this.panel1.Controls.Add(this.butok);
            this.panel1.Controls.Add(this.groupPassport);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 258);
            this.panel1.TabIndex = 0;
            // 
            // butcancel
            // 
            this.butcancel.Location = new System.Drawing.Point(193, 225);
            this.butcancel.Name = "butcancel";
            this.butcancel.Size = new System.Drawing.Size(75, 23);
            this.butcancel.TabIndex = 42;
            this.butcancel.Text = "Close";
            this.butcancel.Click += new System.EventHandler(this.butcancel_Click);
            // 
            // butok
            // 
            this.butok.Location = new System.Drawing.Point(112, 225);
            this.butok.Name = "butok";
            this.butok.Size = new System.Drawing.Size(75, 23);
            this.butok.TabIndex = 41;
            this.butok.Text = "OK";
            this.butok.Click += new System.EventHandler(this.butok_Click);
            // 
            // groupPassport
            // 
            this.groupPassport.Controls.Add(this.labelControl35);
            this.groupPassport.Controls.Add(this.txtEmail);
            this.groupPassport.Controls.Add(this.DateExpiredDate);
            this.groupPassport.Controls.Add(this.txtPhone);
            this.groupPassport.Controls.Add(this.labelControl10);
            this.groupPassport.Controls.Add(this.lblexpiredDate);
            this.groupPassport.Controls.Add(this.dateEditDOB);
            this.groupPassport.Controls.Add(this.labelControl1);
            this.groupPassport.Controls.Add(this.lblpassport);
            this.groupPassport.Controls.Add(this.labelControl3);
            this.groupPassport.Controls.Add(this.labelControl4);
            this.groupPassport.Controls.Add(this.txtCustomerName);
            this.groupPassport.Controls.Add(this.txtNationality);
            this.groupPassport.Controls.Add(this.txtPassport);
            this.groupPassport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.groupPassport.Location = new System.Drawing.Point(12, 12);
            this.groupPassport.Name = "groupPassport";
            this.groupPassport.Size = new System.Drawing.Size(267, 207);
            this.groupPassport.TabIndex = 40;
            this.groupPassport.TabStop = false;
            this.groupPassport.Text = "Passport Information";
            // 
            // labelControl35
            // 
            this.labelControl35.Location = new System.Drawing.Point(6, 177);
            this.labelControl35.Name = "labelControl35";
            this.labelControl35.Size = new System.Drawing.Size(28, 13);
            this.labelControl35.TabIndex = 45;
            this.labelControl35.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(94, 176);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(162, 20);
            this.txtEmail.TabIndex = 44;
            conditionValidationRule7.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule7.ErrorText = "This value is not valid";
            this.valid.SetValidationRule(this.txtEmail, conditionValidationRule7);
            // 
            // DateExpiredDate
            // 
            this.DateExpiredDate.EditValue = null;
            this.DateExpiredDate.Enabled = false;
            this.DateExpiredDate.Location = new System.Drawing.Point(94, 46);
            this.DateExpiredDate.Name = "DateExpiredDate";
            this.DateExpiredDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateExpiredDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateExpiredDate.Size = new System.Drawing.Size(162, 20);
            this.DateExpiredDate.TabIndex = 39;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "This value is not valid";
            this.valid.SetValidationRule(this.DateExpiredDate, conditionValidationRule1);
            // 
            // lblexpiredDate
            // 
            this.lblexpiredDate.Location = new System.Drawing.Point(6, 48);
            this.lblexpiredDate.Name = "lblexpiredDate";
            this.lblexpiredDate.Size = new System.Drawing.Size(62, 13);
            this.lblexpiredDate.TabIndex = 38;
            this.lblexpiredDate.Text = "Expired Date";
            // 
            // dateEditDOB
            // 
            this.dateEditDOB.EditValue = null;
            this.dateEditDOB.Location = new System.Drawing.Point(94, 98);
            this.dateEditDOB.Name = "dateEditDOB";
            this.dateEditDOB.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditDOB.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditDOB.Size = new System.Drawing.Size(162, 20);
            this.dateEditDOB.TabIndex = 35;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "This value is not valid";
            this.valid.SetValidationRule(this.dateEditDOB, conditionValidationRule2);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(6, 73);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(31, 13);
            this.labelControl1.TabIndex = 30;
            this.labelControl1.Text = "Name:";
            // 
            // lblpassport
            // 
            this.lblpassport.Location = new System.Drawing.Point(6, 22);
            this.lblpassport.Name = "lblpassport";
            this.lblpassport.Size = new System.Drawing.Size(85, 13);
            this.lblpassport.TabIndex = 31;
            this.lblpassport.Text = "Passport number:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(6, 125);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(55, 13);
            this.labelControl3.TabIndex = 32;
            this.labelControl3.Text = "Nationality:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(6, 102);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(25, 13);
            this.labelControl4.TabIndex = 36;
            this.labelControl4.Text = "DOB:";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(94, 72);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(162, 20);
            this.txtCustomerName.TabIndex = 2;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "This value is not valid";
            this.valid.SetValidationRule(this.txtCustomerName, conditionValidationRule3);
            // 
            // txtNationality
            // 
            this.txtNationality.Location = new System.Drawing.Point(94, 124);
            this.txtNationality.Name = "txtNationality";
            this.txtNationality.Size = new System.Drawing.Size(162, 20);
            this.txtNationality.TabIndex = 4;
            conditionValidationRule4.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule4.ErrorText = "This value is not valid";
            this.valid.SetValidationRule(this.txtNationality, conditionValidationRule4);
            // 
            // txtPassport
            // 
            this.txtPassport.Location = new System.Drawing.Point(94, 20);
            this.txtPassport.Name = "txtPassport";
            this.txtPassport.Size = new System.Drawing.Size(162, 20);
            this.txtPassport.TabIndex = 1;
            conditionValidationRule5.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule5.ErrorText = "This value is not valid";
            this.valid.SetValidationRule(this.txtPassport, conditionValidationRule5);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(94, 150);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(162, 20);
            this.txtPhone.TabIndex = 5;
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(6, 151);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(34, 13);
            this.labelControl10.TabIndex = 31;
            this.labelControl10.Text = "Phone:";
            // 
            // valid
            // 
            this.valid.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
            // 
            // UpdateCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 258);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UpdateCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Customer";
            this.Load += new System.EventHandler(this.UpdateCustomer_Load);
            this.panel1.ResumeLayout(false);
            this.groupPassport.ResumeLayout(false);
            this.groupPassport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateExpiredDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateExpiredDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDOB.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDOB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNationality.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassport.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupPassport;
        private DevExpress.XtraEditors.DateEdit DateExpiredDate;
        private DevExpress.XtraEditors.LabelControl lblexpiredDate;
        private DevExpress.XtraEditors.DateEdit dateEditDOB;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl lblpassport;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtCustomerName;
        private DevExpress.XtraEditors.TextEdit txtPhone;
        private DevExpress.XtraEditors.TextEdit txtNationality;
        private DevExpress.XtraEditors.TextEdit txtPassport;
        private DevExpress.XtraEditors.SimpleButton butcancel;
        private DevExpress.XtraEditors.SimpleButton butok;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider valid;
        private DevExpress.XtraEditors.LabelControl labelControl35;
        private DevExpress.XtraEditors.TextEdit txtEmail;
    }
}