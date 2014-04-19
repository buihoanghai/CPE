namespace CPE_vs1
{
    partial class CPECatalogueInventorize
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
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraPrinting.BarCode.EAN128Generator eaN128Generator1 = new DevExpress.XtraPrinting.BarCode.EAN128Generator();
            this.panel1 = new System.Windows.Forms.Panel();
            this.butAll = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlDataBase = new DevExpress.XtraGrid.GridControl();
            this.gridViewDatabase = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnNo1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnBarcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LKStatusIngridDataBase = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LKSiteInGrid = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.txtSimNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.LKSiteSearch = new DevExpress.XtraEditors.LookUpEdit();
            this.butEdit = new DevExpress.XtraEditors.SimpleButton();
            this.butDelete = new DevExpress.XtraEditors.SimpleButton();
            this.butSave = new DevExpress.XtraEditors.SimpleButton();
            this.butCancel = new DevExpress.XtraEditors.SimpleButton();
            this.LookUpStatus = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpSite = new DevExpress.XtraEditors.LookUpEdit();
            this.textBarcode = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.ControlCPERecords = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gridControlNew = new DevExpress.XtraGrid.GridControl();
            this.gridViewNew = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Barcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnStatus1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LKStatusInGrid = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.barCodeControl1 = new DevExpress.XtraEditors.BarCodeControl();
            this.valid = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDataBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDatabase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LKStatusIngridDataBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LKSiteInGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSimNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LKSiteSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpSite.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBarcode.Properties)).BeginInit();
            this.ControlCPERecords.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LKStatusInGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.butAll);
            this.panel1.Controls.Add(this.gridControlDataBase);
            this.panel1.Controls.Add(this.txtSimNo);
            this.panel1.Controls.Add(this.labelControl5);
            this.panel1.Controls.Add(this.LKSiteSearch);
            this.panel1.Controls.Add(this.butEdit);
            this.panel1.Controls.Add(this.butDelete);
            this.panel1.Controls.Add(this.butSave);
            this.panel1.Controls.Add(this.butCancel);
            this.panel1.Controls.Add(this.LookUpStatus);
            this.panel1.Controls.Add(this.lookUpSite);
            this.panel1.Controls.Add(this.textBarcode);
            this.panel1.Controls.Add(this.labelControl3);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.ControlCPERecords);
            this.panel1.Controls.Add(this.labelControl4);
            this.panel1.Controls.Add(this.barCodeControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 373);
            this.panel1.TabIndex = 3;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // butAll
            // 
            this.butAll.Location = new System.Drawing.Point(545, 59);
            this.butAll.Name = "butAll";
            this.butAll.Size = new System.Drawing.Size(35, 23);
            this.butAll.TabIndex = 52;
            this.butAll.Text = "All";
            this.butAll.Click += new System.EventHandler(this.butAll_Click);
            // 
            // gridControlDataBase
            // 
            this.gridControlDataBase.Location = new System.Drawing.Point(14, 84);
            this.gridControlDataBase.MainView = this.gridViewDatabase;
            this.gridControlDataBase.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControlDataBase.Name = "gridControlDataBase";
            this.gridControlDataBase.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.LKStatusIngridDataBase,
            this.LKSiteInGrid});
            this.gridControlDataBase.Size = new System.Drawing.Size(567, 187);
            this.gridControlDataBase.TabIndex = 24;
            this.gridControlDataBase.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDatabase});
            // 
            // gridViewDatabase
            // 
            this.gridViewDatabase.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.columnNo1,
            this.gridColumn1,
            this.columnBarcode,
            this.columnStatus,
            this.gridColumn2});
            this.gridViewDatabase.GridControl = this.gridControlDataBase;
            this.gridViewDatabase.Name = "gridViewDatabase";
            this.gridViewDatabase.OptionsFind.AlwaysVisible = true;
            this.gridViewDatabase.OptionsFind.FindDelay = 100;
            this.gridViewDatabase.OptionsView.ShowGroupPanel = false;
            this.gridViewDatabase.DoubleClick += new System.EventHandler(this.gridViewDatabase_DoubleClick);
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
            this.columnNo1.OptionsColumn.AllowEdit = false;
            this.columnNo1.Visible = true;
            this.columnNo1.VisibleIndex = 0;
            this.columnNo1.Width = 83;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "SIM No";
            this.gridColumn1.FieldName = "SIMNo";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 2;
            this.gridColumn1.Width = 209;
            // 
            // columnBarcode
            // 
            this.columnBarcode.Caption = "Barcode";
            this.columnBarcode.FieldName = "Barcode";
            this.columnBarcode.Name = "columnBarcode";
            this.columnBarcode.OptionsColumn.AllowEdit = false;
            this.columnBarcode.Visible = true;
            this.columnBarcode.VisibleIndex = 1;
            this.columnBarcode.Width = 234;
            // 
            // columnStatus
            // 
            this.columnStatus.Caption = "Status";
            this.columnStatus.ColumnEdit = this.LKStatusIngridDataBase;
            this.columnStatus.FieldName = "Status";
            this.columnStatus.Name = "columnStatus";
            this.columnStatus.OptionsColumn.AllowEdit = false;
            this.columnStatus.Visible = true;
            this.columnStatus.VisibleIndex = 3;
            this.columnStatus.Width = 191;
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
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Site";
            this.gridColumn2.ColumnEdit = this.LKSiteInGrid;
            this.gridColumn2.FieldName = "Site_ID";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 4;
            this.gridColumn2.Width = 321;
            // 
            // LKSiteInGrid
            // 
            this.LKSiteInGrid.AutoHeight = false;
            this.LKSiteInGrid.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LKSiteInGrid.DisplayMember = "Name";
            this.LKSiteInGrid.Name = "LKSiteInGrid";
            this.LKSiteInGrid.ValueMember = "ID";
            // 
            // txtSimNo
            // 
            this.txtSimNo.Location = new System.Drawing.Point(62, 35);
            this.txtSimNo.Name = "txtSimNo";
            this.txtSimNo.Size = new System.Drawing.Size(143, 20);
            this.txtSimNo.TabIndex = 51;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "This value is not valid";
            this.valid.SetValidationRule(this.txtSimNo, conditionValidationRule1);
            this.txtSimNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSimNo_KeyPress);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(17, 38);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(34, 13);
            this.labelControl5.TabIndex = 50;
            this.labelControl5.Text = "SIM No";
            // 
            // LKSiteSearch
            // 
            this.LKSiteSearch.Location = new System.Drawing.Point(369, 61);
            this.LKSiteSearch.Name = "LKSiteSearch";
            this.LKSiteSearch.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LKSiteSearch.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name")});
            this.LKSiteSearch.Properties.DisplayMember = "Name";
            this.LKSiteSearch.Properties.NullText = "Filter By Site";
            this.LKSiteSearch.Properties.ValueMember = "ID";
            this.LKSiteSearch.Size = new System.Drawing.Size(170, 20);
            this.LKSiteSearch.TabIndex = 49;
            this.LKSiteSearch.Visible = false;
            this.LKSiteSearch.EditValueChanged += new System.EventHandler(this.LKSiteSearch_EditValueChanged);
            // 
            // butEdit
            // 
            this.butEdit.Location = new System.Drawing.Point(505, 278);
            this.butEdit.Name = "butEdit";
            this.butEdit.Size = new System.Drawing.Size(75, 23);
            this.butEdit.TabIndex = 48;
            this.butEdit.Text = "Edit";
            this.butEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // butDelete
            // 
            this.butDelete.Location = new System.Drawing.Point(424, 278);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(75, 23);
            this.butDelete.TabIndex = 47;
            this.butDelete.Text = "Delete";
            this.butDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // butSave
            // 
            this.butSave.Location = new System.Drawing.Point(506, 7);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(75, 23);
            this.butSave.TabIndex = 46;
            this.butSave.Text = "Save";
            this.butSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // butCancel
            // 
            this.butCancel.Location = new System.Drawing.Point(425, 7);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(75, 23);
            this.butCancel.TabIndex = 45;
            this.butCancel.Text = "Cancel";
            this.butCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // LookUpStatus
            // 
            this.LookUpStatus.Location = new System.Drawing.Point(437, 35);
            this.LookUpStatus.Name = "LookUpStatus";
            this.LookUpStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookUpStatus.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Name")});
            this.LookUpStatus.Properties.DisplayMember = "Value";
            this.LookUpStatus.Properties.NullText = "Choose Status";
            this.LookUpStatus.Properties.ValueMember = "Key";
            this.LookUpStatus.Size = new System.Drawing.Size(143, 20);
            this.LookUpStatus.TabIndex = 44;
            this.LookUpStatus.Visible = false;
            // 
            // lookUpSite
            // 
            this.lookUpSite.Location = new System.Drawing.Point(249, 35);
            this.lookUpSite.Name = "lookUpSite";
            this.lookUpSite.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpSite.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name")});
            this.lookUpSite.Properties.DisplayMember = "Name";
            this.lookUpSite.Properties.NullText = "Choose Site";
            this.lookUpSite.Properties.ValueMember = "ID";
            this.lookUpSite.Size = new System.Drawing.Size(143, 20);
            this.lookUpSite.TabIndex = 43;
            // 
            // textBarcode
            // 
            this.textBarcode.Location = new System.Drawing.Point(62, 9);
            this.textBarcode.Name = "textBarcode";
            this.textBarcode.Size = new System.Drawing.Size(143, 20);
            this.textBarcode.TabIndex = 42;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "This value is not valid";
            this.valid.SetValidationRule(this.textBarcode, conditionValidationRule2);
            this.textBarcode.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBarcode_MouseDown);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(398, 38);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(31, 13);
            this.labelControl3.TabIndex = 41;
            this.labelControl3.Text = "Status";
            this.labelControl3.Visible = false;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(220, 38);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(23, 13);
            this.labelControl2.TabIndex = 40;
            this.labelControl2.Text = "Sites";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(17, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(39, 13);
            this.labelControl1.TabIndex = 39;
            this.labelControl1.Text = "barcode";
            // 
            // ControlCPERecords
            // 
            this.ControlCPERecords.Controls.Add(this.tabPage1);
            this.ControlCPERecords.Controls.Add(this.tabPage2);
            this.ControlCPERecords.Location = new System.Drawing.Point(17, 312);
            this.ControlCPERecords.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ControlCPERecords.Name = "ControlCPERecords";
            this.ControlCPERecords.SelectedIndex = 0;
            this.ControlCPERecords.Size = new System.Drawing.Size(195, 56);
            this.ControlCPERecords.TabIndex = 29;
            this.ControlCPERecords.Visible = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gridControlNew);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.tabPage1.Size = new System.Drawing.Size(187, 30);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Recently";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gridControlNew
            // 
            this.gridControlNew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlNew.Location = new System.Drawing.Point(3, 6);
            this.gridControlNew.MainView = this.gridViewNew;
            this.gridControlNew.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControlNew.Name = "gridControlNew";
            this.gridControlNew.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.LKStatusInGrid});
            this.gridControlNew.Size = new System.Drawing.Size(181, 18);
            this.gridControlNew.TabIndex = 23;
            this.gridControlNew.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewNew,
            this.gridView1});
            // 
            // gridViewNew
            // 
            this.gridViewNew.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID1,
            this.Barcode,
            this.columnNo,
            this.columnStatus1});
            this.gridViewNew.GridControl = this.gridControlNew;
            this.gridViewNew.Name = "gridViewNew";
            this.gridViewNew.OptionsFind.AlwaysVisible = true;
            this.gridViewNew.OptionsFind.FindDelay = 100;
            this.gridViewNew.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewNew_RowClick);
            // 
            // ID1
            // 
            this.ID1.Caption = "ID";
            this.ID1.FieldName = "ID";
            this.ID1.Name = "ID1";
            // 
            // Barcode
            // 
            this.Barcode.Caption = "Barcode";
            this.Barcode.FieldName = "Barcode";
            this.Barcode.Name = "Barcode";
            this.Barcode.OptionsColumn.AllowEdit = false;
            this.Barcode.Visible = true;
            this.Barcode.VisibleIndex = 1;
            this.Barcode.Width = 471;
            // 
            // columnNo
            // 
            this.columnNo.Caption = "No.";
            this.columnNo.FieldName = "STT";
            this.columnNo.Name = "columnNo";
            this.columnNo.OptionsColumn.AllowEdit = false;
            this.columnNo.Visible = true;
            this.columnNo.VisibleIndex = 0;
            this.columnNo.Width = 93;
            // 
            // columnStatus1
            // 
            this.columnStatus1.Caption = "Status";
            this.columnStatus1.ColumnEdit = this.LKStatusInGrid;
            this.columnStatus1.FieldName = "Status";
            this.columnStatus1.Name = "columnStatus1";
            this.columnStatus1.OptionsColumn.AllowEdit = false;
            this.columnStatus1.Visible = true;
            this.columnStatus1.VisibleIndex = 2;
            this.columnStatus1.Width = 474;
            // 
            // LKStatusInGrid
            // 
            this.LKStatusInGrid.AutoHeight = false;
            this.LKStatusInGrid.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LKStatusInGrid.DisplayMember = "Value";
            this.LKStatusInGrid.Name = "LKStatusInGrid";
            this.LKStatusInGrid.ValueMember = "Key";
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControlNew;
            this.gridView1.Name = "gridView1";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(187, 30);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Database";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(17, 64);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(111, 13);
            this.labelControl4.TabIndex = 24;
            this.labelControl4.Text = "CPE inventory records:";
            // 
            // barCodeControl1
            // 
            this.barCodeControl1.AutoModule = true;
            this.barCodeControl1.Location = new System.Drawing.Point(230, 7);
            this.barCodeControl1.Name = "barCodeControl1";
            this.barCodeControl1.Padding = new System.Windows.Forms.Padding(10, 2, 10, 0);
            this.barCodeControl1.ShowText = false;
            this.barCodeControl1.Size = new System.Drawing.Size(182, 22);
            this.barCodeControl1.Symbology = eaN128Generator1;
            this.barCodeControl1.TabIndex = 22;
            this.barCodeControl1.Text = "4535453554";
            // 
            // valid
            // 
            this.valid.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
            // 
            // CPECatalogueInventorize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 373);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CPECatalogueInventorize";
            this.Text = "CPECatalogueInventorize";
            this.Load += new System.EventHandler(this.CPECatalogueInventorize_Load);
            this.Click += new System.EventHandler(this.CPECatalogueInventorize_Click);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDataBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDatabase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LKStatusIngridDataBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LKSiteInGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSimNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LKSiteSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpSite.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBarcode.Properties)).EndInit();
            this.ControlCPERecords.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LKStatusInGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gridControlDataBase;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDatabase;
        private DevExpress.XtraGrid.Columns.GridColumn columnNo1;
        private DevExpress.XtraGrid.Columns.GridColumn columnBarcode;
        private DevExpress.XtraGrid.Columns.GridColumn columnStatus;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.BarCodeControl barCodeControl1;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraEditors.LookUpEdit LookUpStatus;
        private DevExpress.XtraEditors.LookUpEdit lookUpSite;
        private DevExpress.XtraEditors.TextEdit textBarcode;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton butEdit;
        private DevExpress.XtraEditors.SimpleButton butDelete;
        private DevExpress.XtraEditors.SimpleButton butSave;
        private DevExpress.XtraEditors.SimpleButton butCancel;
        private DevExpress.XtraEditors.LookUpEdit LKSiteSearch;
        private DevExpress.XtraEditors.TextEdit txtSimNo;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.TabControl ControlCPERecords;
        private System.Windows.Forms.TabPage tabPage1;
        private DevExpress.XtraGrid.GridControl gridControlNew;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewNew;
        private DevExpress.XtraGrid.Columns.GridColumn ID1;
        private DevExpress.XtraGrid.Columns.GridColumn Barcode;
        private DevExpress.XtraGrid.Columns.GridColumn columnNo;
        private DevExpress.XtraGrid.Columns.GridColumn columnStatus1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LKStatusInGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LKStatusIngridDataBase;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LKSiteInGrid;
        private DevExpress.XtraEditors.SimpleButton butAll;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider valid;
    }
}