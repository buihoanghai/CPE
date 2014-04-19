namespace CPE_vs1
{
    partial class Promotion
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
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.GridPromotion = new DevExpress.XtraGrid.GridControl();
            this.gridViewPromotion = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.spinDiscount = new DevExpress.XtraEditors.SpinEdit();
            this.butDelete = new DevExpress.XtraEditors.SimpleButton();
            this.butSave = new DevExpress.XtraEditors.SimpleButton();
            this.butCancel = new DevExpress.XtraEditors.SimpleButton();
            this.lbldiscount = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtPromotionName = new DevExpress.XtraEditors.TextEdit();
            this.valid = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridPromotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPromotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinDiscount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPromotionName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.GridPromotion);
            this.panel1.Controls.Add(this.spinDiscount);
            this.panel1.Controls.Add(this.butDelete);
            this.panel1.Controls.Add(this.butSave);
            this.panel1.Controls.Add(this.butCancel);
            this.panel1.Controls.Add(this.lbldiscount);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.txtPromotionName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 317);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(9, 51);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(67, 13);
            this.labelControl2.TabIndex = 10;
            this.labelControl2.Text = "Promotion List";
            // 
            // GridPromotion
            // 
            this.GridPromotion.Location = new System.Drawing.Point(9, 70);
            this.GridPromotion.MainView = this.gridViewPromotion;
            this.GridPromotion.Name = "GridPromotion";
            this.GridPromotion.Size = new System.Drawing.Size(579, 204);
            this.GridPromotion.TabIndex = 9;
            this.GridPromotion.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPromotion});
            this.GridPromotion.DoubleClick += new System.EventHandler(this.GridPromotion_DoubleClick);
            // 
            // gridViewPromotion
            // 
            this.gridViewPromotion.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.gridViewPromotion.GridControl = this.GridPromotion;
            this.gridViewPromotion.Name = "gridViewPromotion";
            this.gridViewPromotion.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Name";
            this.gridColumn1.FieldName = "PromotionName";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 351;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Discount";
            this.gridColumn2.FieldName = "Discount";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 210;
            // 
            // spinDiscount
            // 
            this.spinDiscount.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinDiscount.Location = new System.Drawing.Point(281, 15);
            this.spinDiscount.Name = "spinDiscount";
            this.spinDiscount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)});
            this.spinDiscount.Properties.IsFloatValue = false;
            this.spinDiscount.Properties.Mask.EditMask = "N00";
            this.spinDiscount.Properties.MaxLength = 3;
            this.spinDiscount.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.spinDiscount.Size = new System.Drawing.Size(145, 20);
            this.spinDiscount.TabIndex = 8;
            this.spinDiscount.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtPromotionName_MouseDown);
            // 
            // butDelete
            // 
            this.butDelete.Location = new System.Drawing.Point(513, 280);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(75, 23);
            this.butDelete.TabIndex = 6;
            this.butDelete.Text = "Delete";
            this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // butSave
            // 
            this.butSave.Location = new System.Drawing.Point(513, 13);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(75, 23);
            this.butSave.TabIndex = 5;
            this.butSave.Text = "Save";
            this.butSave.Click += new System.EventHandler(this.butSave_Click);
            // 
            // butCancel
            // 
            this.butCancel.Location = new System.Drawing.Point(432, 13);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(75, 23);
            this.butCancel.TabIndex = 4;
            this.butCancel.Text = "Cancel";
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // lbldiscount
            // 
            this.lbldiscount.Location = new System.Drawing.Point(224, 18);
            this.lbldiscount.Name = "lbldiscount";
            this.lbldiscount.Size = new System.Drawing.Size(41, 13);
            this.lbldiscount.TabIndex = 3;
            this.lbldiscount.Text = "Discount";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(9, 18);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(27, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Name";
            // 
            // txtPromotionName
            // 
            this.txtPromotionName.Location = new System.Drawing.Point(42, 15);
            this.txtPromotionName.Name = "txtPromotionName";
            this.txtPromotionName.Size = new System.Drawing.Size(176, 20);
            this.txtPromotionName.TabIndex = 0;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "This value is not valid";
            this.valid.SetValidationRule(this.txtPromotionName, conditionValidationRule1);
            this.txtPromotionName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtPromotionName_MouseDown);
            // 
            // valid
            // 
            this.valid.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
            // 
            // Promotion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 317);
            this.Controls.Add(this.panel1);
            this.Name = "Promotion";
            this.Text = "Promotion";
            this.Load += new System.EventHandler(this.Promotion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridPromotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPromotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinDiscount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPromotionName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.TextEdit txtPromotionName;
        private DevExpress.XtraEditors.SimpleButton butDelete;
        private DevExpress.XtraEditors.SimpleButton butSave;
        private DevExpress.XtraEditors.SimpleButton butCancel;
        private DevExpress.XtraEditors.LabelControl lbldiscount;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.GridControl GridPromotion;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPromotion;
        private DevExpress.XtraEditors.SpinEdit spinDiscount;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider valid;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
    }
}