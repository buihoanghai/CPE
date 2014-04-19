namespace CPE_vs1
{
    partial class LocationManagement
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
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.ControlLocationRecords = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gridControlNew = new DevExpress.XtraGrid.GridControl();
            this.gridViewNew = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnAddress1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtpage = new DevExpress.XtraEditors.TextEdit();
            this.butgo = new System.Windows.Forms.Button();
            this.butall = new System.Windows.Forms.Button();
            this.butnext = new System.Windows.Forms.Button();
            this.butrev = new System.Windows.Forms.Button();
            this.gridControlDataBase = new DevExpress.XtraGrid.GridControl();
            this.gridViewDatabase = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnNo1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDetail = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textName = new DevExpress.XtraEditors.TextEdit();
            this.textSite = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textAddress = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.panel1.SuspendLayout();
            this.ControlLocationRecords.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtpage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDataBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDatabase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textSite.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textAddress.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.ControlLocationRecords);
            this.panel1.Controls.Add(this.buttonEdit);
            this.panel1.Controls.Add(this.buttonDetail);
            this.panel1.Controls.Add(this.buttonDelete);
            this.panel1.Controls.Add(this.buttonCancel);
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Controls.Add(this.textName);
            this.panel1.Controls.Add(this.textSite);
            this.panel1.Controls.Add(this.labelControl4);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.textAddress);
            this.panel1.Controls.Add(this.labelControl8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 594);
            this.panel1.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(14, 12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(22, 13);
            this.labelControl2.TabIndex = 30;
            this.labelControl2.Text = "Site:";
            // 
            // ControlLocationRecords
            // 
            this.ControlLocationRecords.Controls.Add(this.tabPage1);
            this.ControlLocationRecords.Controls.Add(this.tabPage2);
            this.ControlLocationRecords.Location = new System.Drawing.Point(7, 191);
            this.ControlLocationRecords.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ControlLocationRecords.Name = "ControlLocationRecords";
            this.ControlLocationRecords.SelectedIndex = 0;
            this.ControlLocationRecords.Size = new System.Drawing.Size(404, 329);
            this.ControlLocationRecords.TabIndex = 29;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gridControlNew);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.tabPage1.Size = new System.Drawing.Size(396, 303);
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
            this.gridControlNew.Size = new System.Drawing.Size(390, 291);
            this.gridControlNew.TabIndex = 23;
            this.gridControlNew.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewNew,
            this.gridView1});
            // 
            // gridViewNew
            // 
            this.gridViewNew.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID1,
            this.columnNo,
            this.columnName1,
            this.columnAddress1});
            this.gridViewNew.GridControl = this.gridControlNew;
            this.gridViewNew.Name = "gridViewNew";
            this.gridViewNew.OptionsFind.AlwaysVisible = true;
            this.gridViewNew.OptionsFind.FindDelay = 100;
            this.gridViewNew.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewNew_RowClick);
            // 
            // ID1
            // 
            this.ID1.Caption = "gridColumn1";
            this.ID1.FieldName = "ID";
            this.ID1.Name = "ID1";
            this.ID1.Visible = true;
            this.ID1.VisibleIndex = 0;
            // 
            // columnNo
            // 
            this.columnNo.Caption = "No.";
            this.columnNo.FieldName = "STT";
            this.columnNo.Name = "columnNo";
            this.columnNo.Visible = true;
            this.columnNo.VisibleIndex = 1;
            this.columnNo.Width = 50;
            // 
            // columnName1
            // 
            this.columnName1.Caption = "Name";
            this.columnName1.FieldName = "Name";
            this.columnName1.Name = "columnName1";
            this.columnName1.Visible = true;
            this.columnName1.VisibleIndex = 2;
            this.columnName1.Width = 372;
            // 
            // columnAddress1
            // 
            this.columnAddress1.Caption = "Address";
            this.columnAddress1.FieldName = "Address";
            this.columnAddress1.Name = "columnAddress1";
            this.columnAddress1.Visible = true;
            this.columnAddress1.VisibleIndex = 3;
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControlNew;
            this.gridView1.Name = "gridView1";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtpage);
            this.tabPage2.Controls.Add(this.butgo);
            this.tabPage2.Controls.Add(this.butall);
            this.tabPage2.Controls.Add(this.butnext);
            this.tabPage2.Controls.Add(this.butrev);
            this.tabPage2.Controls.Add(this.gridControlDataBase);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(396, 303);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Database";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtpage
            // 
            this.txtpage.Location = new System.Drawing.Point(644, 335);
            this.txtpage.Name = "txtpage";
            this.txtpage.Properties.Mask.EditMask = "###,###,###";
            this.txtpage.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtpage.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtpage.Size = new System.Drawing.Size(85, 20);
            this.txtpage.TabIndex = 27;
            // 
            // butgo
            // 
            this.butgo.Location = new System.Drawing.Point(735, 333);
            this.butgo.Name = "butgo";
            this.butgo.Size = new System.Drawing.Size(75, 23);
            this.butgo.TabIndex = 28;
            this.butgo.Text = "Go";
            this.butgo.UseVisualStyleBackColor = true;
            // 
            // butall
            // 
            this.butall.Location = new System.Drawing.Point(563, 333);
            this.butall.Name = "butall";
            this.butall.Size = new System.Drawing.Size(75, 23);
            this.butall.TabIndex = 29;
            this.butall.Text = "All";
            this.butall.UseVisualStyleBackColor = true;
            // 
            // butnext
            // 
            this.butnext.Location = new System.Drawing.Point(514, 333);
            this.butnext.Name = "butnext";
            this.butnext.Size = new System.Drawing.Size(43, 23);
            this.butnext.TabIndex = 30;
            this.butnext.Text = ">>";
            this.butnext.UseVisualStyleBackColor = true;
            // 
            // butrev
            // 
            this.butrev.Location = new System.Drawing.Point(465, 333);
            this.butrev.Name = "butrev";
            this.butrev.Size = new System.Drawing.Size(43, 23);
            this.butrev.TabIndex = 31;
            this.butrev.Text = "<<";
            this.butrev.UseVisualStyleBackColor = true;
            // 
            // gridControlDataBase
            // 
            this.gridControlDataBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlDataBase.Location = new System.Drawing.Point(3, 3);
            this.gridControlDataBase.MainView = this.gridViewDatabase;
            this.gridControlDataBase.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControlDataBase.Name = "gridControlDataBase";
            this.gridControlDataBase.Size = new System.Drawing.Size(390, 297);
            this.gridControlDataBase.TabIndex = 24;
            this.gridControlDataBase.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDatabase});
            // 
            // gridViewDatabase
            // 
            this.gridViewDatabase.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.columnNo1,
            this.columnName,
            this.columnAddress});
            this.gridViewDatabase.GridControl = this.gridControlDataBase;
            this.gridViewDatabase.Name = "gridViewDatabase";
            this.gridViewDatabase.OptionsFind.AlwaysVisible = true;
            this.gridViewDatabase.OptionsFind.FindDelay = 100;
            this.gridViewDatabase.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewDatabase_RowClick);
            // 
            // ID
            // 
            this.ID.Caption = "gridColumn1";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = true;
            this.ID.VisibleIndex = 0;
            // 
            // columnNo1
            // 
            this.columnNo1.Caption = "No.";
            this.columnNo1.FieldName = "STT";
            this.columnNo1.Name = "columnNo1";
            this.columnNo1.Visible = true;
            this.columnNo1.VisibleIndex = 1;
            this.columnNo1.Width = 50;
            // 
            // columnName
            // 
            this.columnName.Caption = "Name";
            this.columnName.FieldName = "Name";
            this.columnName.Name = "columnName";
            this.columnName.Visible = true;
            this.columnName.VisibleIndex = 2;
            this.columnName.Width = 248;
            // 
            // columnAddress
            // 
            this.columnAddress.Caption = "Address";
            this.columnAddress.FieldName = "Address";
            this.columnAddress.Name = "columnAddress";
            this.columnAddress.Visible = true;
            this.columnAddress.VisibleIndex = 3;
            this.columnAddress.Width = 150;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(333, 528);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 59);
            this.buttonEdit.TabIndex = 28;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDetail
            // 
            this.buttonDetail.Location = new System.Drawing.Point(251, 528);
            this.buttonDetail.Name = "buttonDetail";
            this.buttonDetail.Size = new System.Drawing.Size(75, 59);
            this.buttonDetail.TabIndex = 27;
            this.buttonDetail.Text = "Detail";
            this.buttonDetail.UseVisualStyleBackColor = true;
            this.buttonDetail.Click += new System.EventHandler(this.buttonDetail_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(170, 528);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 59);
            this.buttonDelete.TabIndex = 27;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(251, 104);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 60);
            this.buttonCancel.TabIndex = 26;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(333, 104);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 60);
            this.buttonSave.TabIndex = 25;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(126, 35);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(281, 20);
            this.textName.TabIndex = 20;
            // 
            // textSite
            // 
            this.textSite.Location = new System.Drawing.Point(127, 9);
            this.textSite.Name = "textSite";
            this.textSite.Size = new System.Drawing.Size(281, 20);
            this.textSite.TabIndex = 20;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 170);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(83, 13);
            this.labelControl4.TabIndex = 24;
            this.labelControl4.Text = "Location records:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(15, 38);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(31, 13);
            this.labelControl1.TabIndex = 18;
            this.labelControl1.Text = "Name:";
            // 
            // textAddress
            // 
            this.textAddress.Location = new System.Drawing.Point(125, 65);
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(283, 20);
            this.textAddress.TabIndex = 20;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(14, 68);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(43, 13);
            this.labelControl8.TabIndex = 18;
            this.labelControl8.Text = "Address:";
            // 
            // LocationManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 594);
            this.Controls.Add(this.panel1);
            this.Name = "LocationManagement";
            this.Text = "Location Management";
            this.Load += new System.EventHandler(this.LocationManagement_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ControlLocationRecords.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtpage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDataBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDatabase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textSite.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textAddress.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl ControlLocationRecords;
        private System.Windows.Forms.TabPage tabPage1;
        private DevExpress.XtraGrid.GridControl gridControlNew;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewNew;
        private DevExpress.XtraGrid.Columns.GridColumn ID1;
        private DevExpress.XtraGrid.Columns.GridColumn columnNo;
        private DevExpress.XtraGrid.Columns.GridColumn columnName1;
        private DevExpress.XtraGrid.Columns.GridColumn columnAddress1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private DevExpress.XtraEditors.TextEdit txtpage;
        private System.Windows.Forms.Button butgo;
        private System.Windows.Forms.Button butall;
        private System.Windows.Forms.Button butnext;
        private System.Windows.Forms.Button butrev;
        private DevExpress.XtraGrid.GridControl gridControlDataBase;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDatabase;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn columnNo1;
        private DevExpress.XtraGrid.Columns.GridColumn columnName;
        private DevExpress.XtraGrid.Columns.GridColumn columnAddress;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit textSite;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textAddress;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit textName;
        private System.Windows.Forms.Button buttonDetail;
    }
}