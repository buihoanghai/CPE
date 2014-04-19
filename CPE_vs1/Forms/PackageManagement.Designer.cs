namespace CPE_vs1
{
    partial class PackageManagement
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textDay = new DevExpress.XtraEditors.SpinEdit();
            this.textPackagePrice = new DevExpress.XtraEditors.SpinEdit();
            this.butEdit = new DevExpress.XtraEditors.SimpleButton();
            this.butDelete = new DevExpress.XtraEditors.SimpleButton();
            this.butSave = new DevExpress.XtraEditors.SimpleButton();
            this.butCancel = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.LookUpEOM = new DevExpress.XtraEditors.LookUpEdit();
            this.ControlPackgeRecords = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gridControlDatabase = new DevExpress.XtraGrid.GridControl();
            this.gridViewDatabase = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.textPackageName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textDay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPackagePrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEOM.Properties)).BeginInit();
            this.ControlPackgeRecords.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDatabase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDatabase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPackageName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.textDay);
            this.panel1.Controls.Add(this.textPackagePrice);
            this.panel1.Controls.Add(this.butEdit);
            this.panel1.Controls.Add(this.butDelete);
            this.panel1.Controls.Add(this.butSave);
            this.panel1.Controls.Add(this.butCancel);
            this.panel1.Controls.Add(this.labelControl9);
            this.panel1.Controls.Add(this.LookUpEOM);
            this.panel1.Controls.Add(this.ControlPackgeRecords);
            this.panel1.Controls.Add(this.labelControl4);
            this.panel1.Controls.Add(this.textPackageName);
            this.panel1.Controls.Add(this.labelControl11);
            this.panel1.Controls.Add(this.labelControl8);
            this.panel1.Controls.Add(this.labelControl7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 380);
            this.panel1.TabIndex = 4;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // textDay
            // 
            this.textDay.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.textDay.Location = new System.Drawing.Point(295, 9);
            this.textDay.Name = "textDay";
            this.textDay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.textDay.Properties.IsFloatValue = false;
            this.textDay.Properties.Mask.EditMask = "N00";
            this.textDay.Properties.MaxValue = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.textDay.Size = new System.Drawing.Size(138, 20);
            this.textDay.TabIndex = 38;
            // 
            // textPackagePrice
            // 
            this.textPackagePrice.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.textPackagePrice.Location = new System.Drawing.Point(90, 35);
            this.textPackagePrice.Name = "textPackagePrice";
            this.textPackagePrice.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.textPackagePrice.Properties.IsFloatValue = false;
            this.textPackagePrice.Properties.Mask.EditMask = "N00";
            this.textPackagePrice.Properties.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.textPackagePrice.Size = new System.Drawing.Size(138, 20);
            this.textPackagePrice.TabIndex = 37;
            // 
            // butEdit
            // 
            this.butEdit.Location = new System.Drawing.Point(511, 349);
            this.butEdit.Name = "butEdit";
            this.butEdit.Size = new System.Drawing.Size(75, 23);
            this.butEdit.TabIndex = 36;
            this.butEdit.Text = "Edit";
            this.butEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // butDelete
            // 
            this.butDelete.Location = new System.Drawing.Point(430, 349);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(75, 23);
            this.butDelete.TabIndex = 35;
            this.butDelete.Text = "Delete";
            this.butDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // butSave
            // 
            this.butSave.Location = new System.Drawing.Point(520, 7);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(75, 23);
            this.butSave.TabIndex = 34;
            this.butSave.Text = "Save";
            this.butSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // butCancel
            // 
            this.butCancel.Location = new System.Drawing.Point(439, 7);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(75, 23);
            this.butCancel.TabIndex = 33;
            this.butCancel.Text = "Cancel";
            this.butCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(263, 38);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(26, 13);
            this.labelControl9.TabIndex = 32;
            this.labelControl9.Text = "EOM:";
            this.labelControl9.Visible = false;
            // 
            // LookUpEOM
            // 
            this.LookUpEOM.Location = new System.Drawing.Point(295, 35);
            this.LookUpEOM.Name = "LookUpEOM";
            this.LookUpEOM.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookUpEOM.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name")});
            this.LookUpEOM.Properties.DisplayMember = "Name";
            this.LookUpEOM.Properties.PopupSizeable = false;
            this.LookUpEOM.Properties.ShowHeader = false;
            this.LookUpEOM.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.LookUpEOM.Properties.ValueMember = "ID";
            this.LookUpEOM.Size = new System.Drawing.Size(138, 20);
            this.LookUpEOM.TabIndex = 8;
            this.LookUpEOM.Visible = false;
            // 
            // ControlPackgeRecords
            // 
            this.ControlPackgeRecords.Controls.Add(this.tabPage2);
            this.ControlPackgeRecords.Location = new System.Drawing.Point(12, 93);
            this.ControlPackgeRecords.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ControlPackgeRecords.Name = "ControlPackgeRecords";
            this.ControlPackgeRecords.SelectedIndex = 0;
            this.ControlPackgeRecords.Size = new System.Drawing.Size(578, 254);
            this.ControlPackgeRecords.TabIndex = 29;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gridControlDatabase);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(570, 228);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Database";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gridControlDatabase
            // 
            this.gridControlDatabase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlDatabase.Location = new System.Drawing.Point(3, 3);
            this.gridControlDatabase.MainView = this.gridViewDatabase;
            this.gridControlDatabase.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControlDatabase.Name = "gridControlDatabase";
            this.gridControlDatabase.Size = new System.Drawing.Size(564, 222);
            this.gridControlDatabase.TabIndex = 32;
            this.gridControlDatabase.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDatabase,
            this.gridView4});
            // 
            // gridViewDatabase
            // 
            this.gridViewDatabase.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn8,
            this.gridColumn7});
            this.gridViewDatabase.GridControl = this.gridControlDatabase;
            this.gridViewDatabase.Name = "gridViewDatabase";
            this.gridViewDatabase.OptionsFind.AlwaysVisible = true;
            this.gridViewDatabase.OptionsFind.FindDelay = 100;
            this.gridViewDatabase.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewDatabase_RowClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "gridColumn1";
            this.gridColumn1.FieldName = "CPE_ID";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "gridColumn1";
            this.gridColumn2.FieldName = "ID";
            this.gridColumn2.Name = "gridColumn2";
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "No.";
            this.gridColumn3.FieldName = "STT";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            this.gridColumn3.Width = 67;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Package Name";
            this.gridColumn4.FieldName = "Name";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            this.gridColumn4.Width = 386;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Price";
            this.gridColumn5.FieldName = "Price";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 2;
            this.gridColumn5.Width = 232;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Day";
            this.gridColumn6.FieldName = "Days";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 3;
            this.gridColumn6.Width = 172;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "EOM";
            this.gridColumn8.FieldName = "EOM";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Width = 181;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "OEM";
            this.gridColumn7.FieldName = "gridColumn7";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            this.gridColumn7.UnboundExpression = "ToStr(Iif([EOM]=1,\'Normal\'  ,\'OEM\' ))";
            this.gridColumn7.UnboundType = DevExpress.Data.UnboundColumnType.String;
            // 
            // gridView4
            // 
            this.gridView4.GridControl = this.gridControlDatabase;
            this.gridView4.Name = "gridView4";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 72);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(83, 13);
            this.labelControl4.TabIndex = 24;
            this.labelControl4.Text = "Package records:";
            // 
            // textPackageName
            // 
            this.textPackageName.Location = new System.Drawing.Point(90, 9);
            this.textPackageName.Name = "textPackageName";
            this.textPackageName.Size = new System.Drawing.Size(138, 20);
            this.textPackageName.TabIndex = 6;
            this.textPackageName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textPackageName_MouseDown);
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(263, 12);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(23, 13);
            this.labelControl11.TabIndex = 18;
            this.labelControl11.Text = "Day:";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(10, 12);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(74, 13);
            this.labelControl8.TabIndex = 18;
            this.labelControl8.Text = "Package Name:";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(10, 40);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(70, 13);
            this.labelControl7.TabIndex = 18;
            this.labelControl7.Text = "Package Price:";
            // 
            // PackageManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 380);
            this.Controls.Add(this.panel1);
            this.Name = "PackageManagement";
            this.Text = "Package";
            this.Load += new System.EventHandler(this.Package_Load);
            this.Click += new System.EventHandler(this.PackageManagement_Click);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textDay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPackagePrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEOM.Properties)).EndInit();
            this.ControlPackgeRecords.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDatabase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDatabase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPackageName.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LookUpEdit LookUpEOM;
        private System.Windows.Forms.TabControl ControlPackgeRecords;
        private System.Windows.Forms.TabPage tabPage2;
        private DevExpress.XtraGrid.GridControl gridControlDatabase;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDatabase;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit textPackageName;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.SimpleButton butEdit;
        private DevExpress.XtraEditors.SimpleButton butDelete;
        private DevExpress.XtraEditors.SimpleButton butSave;
        private DevExpress.XtraEditors.SimpleButton butCancel;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraEditors.SpinEdit textDay;
        private DevExpress.XtraEditors.SpinEdit textPackagePrice;
    }
}