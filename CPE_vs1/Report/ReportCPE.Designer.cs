namespace CPE_vs1.Report
{
    partial class ReportCPE
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
            this.butAll = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlDataBase = new DevExpress.XtraGrid.GridControl();
            this.gridViewDatabase = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnBarcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LKStatusIngridDataBase = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LKSiteIngrid = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.lblsite = new DevExpress.XtraEditors.LabelControl();
            this.LKSiteSearch = new DevExpress.XtraEditors.LookUpEdit();
            this.butPrint = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDataBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDatabase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LKStatusIngridDataBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LKSiteIngrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LKSiteSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.butAll);
            this.panel1.Controls.Add(this.gridControlDataBase);
            this.panel1.Controls.Add(this.lblsite);
            this.panel1.Controls.Add(this.LKSiteSearch);
            this.panel1.Controls.Add(this.butPrint);
            this.panel1.Controls.Add(this.labelControl4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 349);
            this.panel1.TabIndex = 4;
            // 
            // butAll
            // 
            this.butAll.Location = new System.Drawing.Point(555, 7);
            this.butAll.Name = "butAll";
            this.butAll.Size = new System.Drawing.Size(33, 23);
            this.butAll.TabIndex = 51;
            this.butAll.Text = "All";
            this.butAll.Click += new System.EventHandler(this.butAll_Click);
            // 
            // gridControlDataBase
            // 
            this.gridControlDataBase.Location = new System.Drawing.Point(12, 32);
            this.gridControlDataBase.MainView = this.gridViewDatabase;
            this.gridControlDataBase.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControlDataBase.Name = "gridControlDataBase";
            this.gridControlDataBase.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.LKStatusIngridDataBase,
            this.LKSiteIngrid});
            this.gridControlDataBase.Size = new System.Drawing.Size(576, 254);
            this.gridControlDataBase.TabIndex = 24;
            this.gridControlDataBase.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDatabase});
            // 
            // gridViewDatabase
            // 
            this.gridViewDatabase.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.columnBarcode,
            this.gridColumn2,
            this.columnStatus,
            this.gridColumn1});
            this.gridViewDatabase.GridControl = this.gridControlDataBase;
            this.gridViewDatabase.Name = "gridViewDatabase";
            this.gridViewDatabase.OptionsFind.AlwaysVisible = true;
            this.gridViewDatabase.OptionsFind.FindDelay = 100;
            this.gridViewDatabase.OptionsPrint.EnableAppearanceEvenRow = true;
            // 
            // ID
            // 
            this.ID.Caption = "gridColumn1";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            // 
            // columnBarcode
            // 
            this.columnBarcode.Caption = "Device barcode no.\r\n";
            this.columnBarcode.FieldName = "Barcode";
            this.columnBarcode.Name = "columnBarcode";
            this.columnBarcode.Visible = true;
            this.columnBarcode.VisibleIndex = 0;
            this.columnBarcode.Width = 243;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "SIM card no\r\n";
            this.gridColumn2.FieldName = "SIMNo";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 216;
            // 
            // columnStatus
            // 
            this.columnStatus.Caption = "Device status";
            this.columnStatus.ColumnEdit = this.LKStatusIngridDataBase;
            this.columnStatus.FieldName = "Status";
            this.columnStatus.Name = "columnStatus";
            this.columnStatus.Visible = true;
            this.columnStatus.VisibleIndex = 2;
            this.columnStatus.Width = 136;
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
            this.gridColumn1.Caption = "Device location site\r\n";
            this.gridColumn1.ColumnEdit = this.LKSiteIngrid;
            this.gridColumn1.FieldName = "Site_ID";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 3;
            this.gridColumn1.Width = 443;
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
            // lblsite
            // 
            this.lblsite.Location = new System.Drawing.Point(311, 12);
            this.lblsite.Name = "lblsite";
            this.lblsite.Size = new System.Drawing.Size(60, 13);
            this.lblsite.TabIndex = 50;
            this.lblsite.Text = "Filter By Site";
            // 
            // LKSiteSearch
            // 
            this.LKSiteSearch.Location = new System.Drawing.Point(377, 9);
            this.LKSiteSearch.Name = "LKSiteSearch";
            this.LKSiteSearch.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LKSiteSearch.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name")});
            this.LKSiteSearch.Properties.DisplayMember = "Name";
            this.LKSiteSearch.Properties.ValueMember = "ID";
            this.LKSiteSearch.Size = new System.Drawing.Size(172, 20);
            this.LKSiteSearch.TabIndex = 49;
            this.LKSiteSearch.EditValueChanged += new System.EventHandler(this.LKSiteSearch_EditValueChanged);
            // 
            // butPrint
            // 
            this.butPrint.Location = new System.Drawing.Point(513, 293);
            this.butPrint.Name = "butPrint";
            this.butPrint.Size = new System.Drawing.Size(75, 23);
            this.butPrint.TabIndex = 48;
            this.butPrint.Text = "Print";
            this.butPrint.Click += new System.EventHandler(this.butPrint_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 12);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(111, 13);
            this.labelControl4.TabIndex = 24;
            this.labelControl4.Text = "CPE inventory records:";
            // 
            // gridView2
            // 
            this.gridView2.Name = "gridView2";
            // 
            // ReportCPE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 349);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ReportCPE";
            this.Text = "Report CPE";
            this.Load += new System.EventHandler(this.ReportCPE_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDataBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDatabase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LKStatusIngridDataBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LKSiteIngrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LKSiteSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gridControlDataBase;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDatabase;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn columnBarcode;
        private DevExpress.XtraGrid.Columns.GridColumn columnStatus;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LKStatusIngridDataBase;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LKSiteIngrid;
        private DevExpress.XtraEditors.LabelControl lblsite;
        private DevExpress.XtraEditors.LookUpEdit LKSiteSearch;
        private DevExpress.XtraEditors.SimpleButton butPrint;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.SimpleButton butAll;
    }
}