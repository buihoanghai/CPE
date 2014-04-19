namespace CPE_vs1
{
    partial class Transfer
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
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.gridControlDataBase = new DevExpress.XtraGrid.GridControl();
            this.gridViewDatabase = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnNo1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnBarcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LKStatusIngridDataBase = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LKSiteIngrid = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.butOk = new DevExpress.XtraEditors.SimpleButton();
            this.LKSiteSearch = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.LKSiteTransfer = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblsite = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.butSave = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtCPEbarcode = new DevExpress.XtraEditors.TextEdit();
            this.butcheckInAll = new DevExpress.XtraEditors.SimpleButton();
            this.CheckGettype = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.gridControlCheckIn = new DevExpress.XtraGrid.GridControl();
            this.gridViewCheckIN = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LKStatusInGridCheckIn = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LKSiteInGridCheckIn = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.butOk1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtTransferCode = new DevExpress.XtraEditors.TextEdit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDataBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDatabase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LKStatusIngridDataBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LKSiteIngrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LKSiteSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LKSiteTransfer.Properties)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCPEbarcode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckGettype.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCheckIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCheckIN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LKStatusInGridCheckIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LKSiteInGridCheckIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTransferCode.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.xtraTabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(583, 366);
            this.panel1.TabIndex = 0;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(5, 3);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(575, 363);
            this.xtraTabControl1.TabIndex = 55;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.gridControlDataBase);
            this.xtraTabPage1.Controls.Add(this.butOk);
            this.xtraTabPage1.Controls.Add(this.LKSiteSearch);
            this.xtraTabPage1.Controls.Add(this.labelControl2);
            this.xtraTabPage1.Controls.Add(this.LKSiteTransfer);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Controls.Add(this.lblsite);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(569, 335);
            this.xtraTabPage1.Text = "Check-Out";
            // 
            // gridControlDataBase
            // 
            this.gridControlDataBase.Location = new System.Drawing.Point(4, 54);
            this.gridControlDataBase.MainView = this.gridViewDatabase;
            this.gridControlDataBase.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControlDataBase.Name = "gridControlDataBase";
            this.gridControlDataBase.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.LKStatusIngridDataBase,
            this.LKSiteIngrid});
            this.gridControlDataBase.Size = new System.Drawing.Size(557, 215);
            this.gridControlDataBase.TabIndex = 25;
            this.gridControlDataBase.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDatabase});
            // 
            // gridViewDatabase
            // 
            this.gridViewDatabase.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.columnNo1,
            this.columnBarcode,
            this.columnStatus,
            this.gridColumn1});
            this.gridViewDatabase.GridControl = this.gridControlDataBase;
            this.gridViewDatabase.Name = "gridViewDatabase";
            this.gridViewDatabase.OptionsFind.AlwaysVisible = true;
            this.gridViewDatabase.OptionsFind.FindDelay = 100;
            this.gridViewDatabase.OptionsSelection.MultiSelect = true;
            this.gridViewDatabase.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridViewDatabase.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gridViewDatabase_SelectionChanged);
            // 
            // ID
            // 
            this.ID.Caption = "gridColumn1";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            // 
            // columnNo1
            // 
            this.columnNo1.Caption = "No.";
            this.columnNo1.FieldName = "STT";
            this.columnNo1.Name = "columnNo1";
            this.columnNo1.Width = 40;
            // 
            // columnBarcode
            // 
            this.columnBarcode.Caption = "Barcode";
            this.columnBarcode.FieldName = "Barcode";
            this.columnBarcode.Name = "columnBarcode";
            this.columnBarcode.OptionsColumn.AllowEdit = false;
            this.columnBarcode.Visible = true;
            this.columnBarcode.VisibleIndex = 1;
            this.columnBarcode.Width = 248;
            // 
            // columnStatus
            // 
            this.columnStatus.Caption = "Status";
            this.columnStatus.ColumnEdit = this.LKStatusIngridDataBase;
            this.columnStatus.FieldName = "Status";
            this.columnStatus.Name = "columnStatus";
            this.columnStatus.OptionsColumn.AllowEdit = false;
            this.columnStatus.Visible = true;
            this.columnStatus.VisibleIndex = 2;
            this.columnStatus.Width = 107;
            // 
            // LKStatusIngridDataBase
            // 
            this.LKStatusIngridDataBase.AutoHeight = false;
            this.LKStatusIngridDataBase.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LKStatusIngridDataBase.DisplayMember = "Value";
            this.LKStatusIngridDataBase.Name = "LKStatusIngridDataBase";
            this.LKStatusIngridDataBase.ValueMember = "Key";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Site";
            this.gridColumn1.ColumnEdit = this.LKSiteIngrid;
            this.gridColumn1.FieldName = "Site_ID";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 3;
            this.gridColumn1.Width = 168;
            // 
            // LKSiteIngrid
            // 
            this.LKSiteIngrid.AutoHeight = false;
            this.LKSiteIngrid.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LKSiteIngrid.DisplayMember = "Name";
            this.LKSiteIngrid.Name = "LKSiteIngrid";
            this.LKSiteIngrid.ValueMember = "ID";
            // 
            // butOk
            // 
            this.butOk.Enabled = false;
            this.butOk.Location = new System.Drawing.Point(328, 1);
            this.butOk.Name = "butOk";
            this.butOk.Size = new System.Drawing.Size(75, 23);
            this.butOk.TabIndex = 54;
            this.butOk.Text = "OK";
            this.butOk.Click += new System.EventHandler(this.butOk_Click);
            // 
            // LKSiteSearch
            // 
            this.LKSiteSearch.Location = new System.Drawing.Point(350, 31);
            this.LKSiteSearch.Name = "LKSiteSearch";
            this.LKSiteSearch.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LKSiteSearch.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name")});
            this.LKSiteSearch.Properties.DisplayMember = "Name";
            this.LKSiteSearch.Properties.NullText = "Filter by site";
            this.LKSiteSearch.Properties.ValueMember = "ID";
            this.LKSiteSearch.Size = new System.Drawing.Size(211, 20);
            this.LKSiteSearch.TabIndex = 51;
            this.LKSiteSearch.Visible = false;
            this.LKSiteSearch.EditValueChanged += new System.EventHandler(this.LKSiteSearch_EditValueChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(4, 34);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(33, 13);
            this.labelControl2.TabIndex = 53;
            this.labelControl2.Text = "All CPE";
            // 
            // LKSiteTransfer
            // 
            this.LKSiteTransfer.Enabled = false;
            this.LKSiteTransfer.Location = new System.Drawing.Point(107, 3);
            this.LKSiteTransfer.Name = "LKSiteTransfer";
            this.LKSiteTransfer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LKSiteTransfer.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name")});
            this.LKSiteTransfer.Properties.DisplayMember = "Name";
            this.LKSiteTransfer.Properties.NullText = "choose Site";
            this.LKSiteTransfer.Properties.ValueMember = "ID";
            this.LKSiteTransfer.Size = new System.Drawing.Size(211, 20);
            this.LKSiteTransfer.TabIndex = 51;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(282, 34);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(62, 13);
            this.labelControl1.TabIndex = 52;
            this.labelControl1.Text = "Fillter by Site";
            this.labelControl1.Visible = false;
            // 
            // lblsite
            // 
            this.lblsite.Location = new System.Drawing.Point(4, 6);
            this.lblsite.Name = "lblsite";
            this.lblsite.Size = new System.Drawing.Size(97, 13);
            this.lblsite.TabIndex = 52;
            this.lblsite.Text = "Transfer CPE to Site";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.butSave);
            this.xtraTabPage2.Controls.Add(this.labelControl5);
            this.xtraTabPage2.Controls.Add(this.txtCPEbarcode);
            this.xtraTabPage2.Controls.Add(this.butcheckInAll);
            this.xtraTabPage2.Controls.Add(this.CheckGettype);
            this.xtraTabPage2.Controls.Add(this.labelControl4);
            this.xtraTabPage2.Controls.Add(this.gridControlCheckIn);
            this.xtraTabPage2.Controls.Add(this.butOk1);
            this.xtraTabPage2.Controls.Add(this.labelControl3);
            this.xtraTabPage2.Controls.Add(this.txtTransferCode);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(569, 335);
            this.xtraTabPage2.Text = "Check-In";
            this.xtraTabPage2.Click += new System.EventHandler(this.xtraTabPage2_Click);
            // 
            // butSave
            // 
            this.butSave.Location = new System.Drawing.Point(487, 301);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(75, 23);
            this.butSave.TabIndex = 59;
            this.butSave.Text = "Save";
            this.butSave.Click += new System.EventHandler(this.butSave_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(209, 34);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(61, 13);
            this.labelControl5.TabIndex = 58;
            this.labelControl5.Text = "CPE Barcode";
            // 
            // txtCPEbarcode
            // 
            this.txtCPEbarcode.Enabled = false;
            this.txtCPEbarcode.Location = new System.Drawing.Point(278, 31);
            this.txtCPEbarcode.Name = "txtCPEbarcode";
            this.txtCPEbarcode.Size = new System.Drawing.Size(136, 20);
            this.txtCPEbarcode.TabIndex = 57;
            this.txtCPEbarcode.EditValueChanged += new System.EventHandler(this.txtCPEbarcode_EditValueChanged);
            this.txtCPEbarcode.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtTransferCode_MouseDown);
            // 
            // butcheckInAll
            // 
            this.butcheckInAll.Location = new System.Drawing.Point(95, 29);
            this.butcheckInAll.Name = "butcheckInAll";
            this.butcheckInAll.Size = new System.Drawing.Size(75, 23);
            this.butcheckInAll.TabIndex = 56;
            this.butcheckInAll.Text = "Check-In All";
            this.butcheckInAll.Click += new System.EventHandler(this.butcheckInAll_Click);
            // 
            // CheckGettype
            // 
            this.CheckGettype.EditValue = true;
            this.CheckGettype.Location = new System.Drawing.Point(5, 31);
            this.CheckGettype.Name = "CheckGettype";
            this.CheckGettype.Properties.Caption = "Check-In all";
            this.CheckGettype.Size = new System.Drawing.Size(84, 19);
            this.CheckGettype.TabIndex = 55;
            this.CheckGettype.CheckedChanged += new System.EventHandler(this.CheckGettype_CheckedChanged);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(5, 59);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(82, 13);
            this.labelControl4.TabIndex = 54;
            this.labelControl4.Text = "List CPE Transfer";
            // 
            // gridControlCheckIn
            // 
            this.gridControlCheckIn.Location = new System.Drawing.Point(5, 79);
            this.gridControlCheckIn.MainView = this.gridViewCheckIN;
            this.gridControlCheckIn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControlCheckIn.Name = "gridControlCheckIn";
            this.gridControlCheckIn.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.LKStatusInGridCheckIn,
            this.LKSiteInGridCheckIn});
            this.gridControlCheckIn.Size = new System.Drawing.Size(557, 215);
            this.gridControlCheckIn.TabIndex = 26;
            this.gridControlCheckIn.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCheckIN});
            // 
            // gridViewCheckIN
            // 
            this.gridViewCheckIN.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.gridViewCheckIN.GridControl = this.gridControlCheckIn;
            this.gridViewCheckIN.Name = "gridViewCheckIN";
            this.gridViewCheckIN.OptionsFind.AlwaysVisible = true;
            this.gridViewCheckIN.OptionsFind.FindDelay = 100;
            this.gridViewCheckIN.OptionsSelection.MultiSelect = true;
            this.gridViewCheckIN.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
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
            this.gridColumn3.Width = 40;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Barcode";
            this.gridColumn4.FieldName = "Barcode";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            this.gridColumn4.Width = 248;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Status";
            this.gridColumn5.ColumnEdit = this.LKStatusInGridCheckIn;
            this.gridColumn5.FieldName = "Status";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 2;
            this.gridColumn5.Width = 107;
            // 
            // LKStatusInGridCheckIn
            // 
            this.LKStatusInGridCheckIn.AutoHeight = false;
            this.LKStatusInGridCheckIn.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LKStatusInGridCheckIn.DisplayMember = "Value";
            this.LKStatusInGridCheckIn.Name = "LKStatusInGridCheckIn";
            this.LKStatusInGridCheckIn.ValueMember = "Key";
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Site";
            this.gridColumn6.ColumnEdit = this.LKSiteInGridCheckIn;
            this.gridColumn6.FieldName = "FromSite";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 3;
            this.gridColumn6.Width = 168;
            // 
            // LKSiteInGridCheckIn
            // 
            this.LKSiteInGridCheckIn.AutoHeight = false;
            this.LKSiteInGridCheckIn.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LKSiteInGridCheckIn.DisplayMember = "Name";
            this.LKSiteInGridCheckIn.Name = "LKSiteInGridCheckIn";
            this.LKSiteInGridCheckIn.ValueMember = "ID";
            // 
            // butOk1
            // 
            this.butOk1.Location = new System.Drawing.Point(186, 1);
            this.butOk1.Name = "butOk1";
            this.butOk1.Size = new System.Drawing.Size(75, 23);
            this.butOk1.TabIndex = 2;
            this.butOk1.Text = "OK";
            this.butOk1.Click += new System.EventHandler(this.butOk1_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(5, 6);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(69, 13);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Transfer Code";
            // 
            // txtTransferCode
            // 
            this.txtTransferCode.Location = new System.Drawing.Point(80, 3);
            this.txtTransferCode.Name = "txtTransferCode";
            this.txtTransferCode.Size = new System.Drawing.Size(100, 20);
            this.txtTransferCode.TabIndex = 0;
            this.txtTransferCode.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtTransferCode_MouseDown);
            // 
            // Transfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 366);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Transfer";
            this.Text = "Check-Out Check-In";
            this.Load += new System.EventHandler(this.Transfer_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDataBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDatabase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LKStatusIngridDataBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LKSiteIngrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LKSiteSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LKSiteTransfer.Properties)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCPEbarcode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckGettype.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCheckIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCheckIN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LKStatusInGridCheckIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LKSiteInGridCheckIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTransferCode.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gridControlDataBase;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDatabase;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn columnNo1;
        private DevExpress.XtraGrid.Columns.GridColumn columnBarcode;
        private DevExpress.XtraGrid.Columns.GridColumn columnStatus;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LKStatusIngridDataBase;
        private DevExpress.XtraEditors.SimpleButton butOk;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lblsite;
        private DevExpress.XtraEditors.LookUpEdit LKSiteTransfer;
        private DevExpress.XtraEditors.LookUpEdit LKSiteSearch;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LKSiteIngrid;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraEditors.SimpleButton butSave;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtCPEbarcode;
        private DevExpress.XtraEditors.SimpleButton butcheckInAll;
        private DevExpress.XtraEditors.CheckEdit CheckGettype;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraGrid.GridControl gridControlCheckIn;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCheckIN;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LKStatusInGridCheckIn;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LKSiteInGridCheckIn;
        private DevExpress.XtraEditors.SimpleButton butOk1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtTransferCode;
    }
}