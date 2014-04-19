namespace CPE_vs1
{
    partial class SiteManagement
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
            this.butDelete = new DevExpress.XtraEditors.SimpleButton();
            this.butEdit = new DevExpress.XtraEditors.SimpleButton();
            this.butSave = new DevExpress.XtraEditors.SimpleButton();
            this.butcancel = new DevExpress.XtraEditors.SimpleButton();
            this.ControlSiteRecords = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gridControlNew = new DevExpress.XtraGrid.GridControl();
            this.gridViewNew = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Name1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Amount1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gridControlDatabase = new DevExpress.XtraGrid.GridControl();
            this.gridViewDatabase = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtpage = new DevExpress.XtraEditors.TextEdit();
            this.butgo = new System.Windows.Forms.Button();
            this.butall = new System.Windows.Forms.Button();
            this.butnext = new System.Windows.Forms.Button();
            this.butrev = new System.Windows.Forms.Button();
            this.textName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textAmount = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.panel1.SuspendLayout();
            this.ControlSiteRecords.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDatabase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDatabase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textAmount.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.butDelete);
            this.panel1.Controls.Add(this.butEdit);
            this.panel1.Controls.Add(this.butSave);
            this.panel1.Controls.Add(this.butcancel);
            this.panel1.Controls.Add(this.ControlSiteRecords);
            this.panel1.Controls.Add(this.textName);
            this.panel1.Controls.Add(this.labelControl4);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.textAmount);
            this.panel1.Controls.Add(this.labelControl8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 384);
            this.panel1.TabIndex = 5;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // butDelete
            // 
            this.butDelete.Location = new System.Drawing.Point(425, 354);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(75, 23);
            this.butDelete.TabIndex = 34;
            this.butDelete.Text = "Delete";
            this.butDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // butEdit
            // 
            this.butEdit.Location = new System.Drawing.Point(506, 354);
            this.butEdit.Name = "butEdit";
            this.butEdit.Size = new System.Drawing.Size(75, 23);
            this.butEdit.TabIndex = 33;
            this.butEdit.Text = "Edit";
            this.butEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // butSave
            // 
            this.butSave.Location = new System.Drawing.Point(358, 9);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(75, 23);
            this.butSave.TabIndex = 32;
            this.butSave.Text = "Save";
            this.butSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // butcancel
            // 
            this.butcancel.Location = new System.Drawing.Point(277, 10);
            this.butcancel.Name = "butcancel";
            this.butcancel.Size = new System.Drawing.Size(75, 23);
            this.butcancel.TabIndex = 31;
            this.butcancel.Text = "Cancel";
            this.butcancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // ControlSiteRecords
            // 
            this.ControlSiteRecords.Controls.Add(this.tabPage1);
            this.ControlSiteRecords.Controls.Add(this.tabPage2);
            this.ControlSiteRecords.Location = new System.Drawing.Point(15, 106);
            this.ControlSiteRecords.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ControlSiteRecords.Name = "ControlSiteRecords";
            this.ControlSiteRecords.SelectedIndex = 0;
            this.ControlSiteRecords.Size = new System.Drawing.Size(573, 243);
            this.ControlSiteRecords.TabIndex = 30;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gridControlNew);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.tabPage1.Size = new System.Drawing.Size(565, 217);
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
            this.gridControlNew.Size = new System.Drawing.Size(559, 205);
            this.gridControlNew.TabIndex = 23;
            this.gridControlNew.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewNew,
            this.gridView1,
            this.gridView2});
            // 
            // gridViewNew
            // 
            this.gridViewNew.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID1,
            this.columnNo,
            this.Name1,
            this.Amount1});
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
            // 
            // columnNo
            // 
            this.columnNo.Caption = "No.";
            this.columnNo.FieldName = "STT";
            this.columnNo.Name = "columnNo";
            this.columnNo.OptionsColumn.AllowEdit = false;
            this.columnNo.Visible = true;
            this.columnNo.VisibleIndex = 0;
            this.columnNo.Width = 50;
            // 
            // Name1
            // 
            this.Name1.Caption = "Name";
            this.Name1.FieldName = "Name";
            this.Name1.Name = "Name1";
            this.Name1.OptionsColumn.AllowEdit = false;
            this.Name1.Visible = true;
            this.Name1.VisibleIndex = 1;
            this.Name1.Width = 372;
            // 
            // Amount1
            // 
            this.Amount1.Caption = "Amount";
            this.Amount1.FieldName = "Amount";
            this.Amount1.Name = "Amount1";
            this.Amount1.OptionsColumn.AllowEdit = false;
            this.Amount1.Visible = true;
            this.Amount1.VisibleIndex = 2;
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControlNew;
            this.gridView1.Name = "gridView1";
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControlNew;
            this.gridView2.Name = "gridView2";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gridControlDatabase);
            this.tabPage2.Controls.Add(this.txtpage);
            this.tabPage2.Controls.Add(this.butgo);
            this.tabPage2.Controls.Add(this.butall);
            this.tabPage2.Controls.Add(this.butnext);
            this.tabPage2.Controls.Add(this.butrev);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(565, 217);
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
            this.gridControlDatabase.Size = new System.Drawing.Size(559, 211);
            this.gridControlDatabase.TabIndex = 32;
            this.gridControlDatabase.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDatabase,
            this.gridView4});
            // 
            // gridViewDatabase
            // 
            this.gridViewDatabase.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8});
            this.gridViewDatabase.GridControl = this.gridControlDatabase;
            this.gridViewDatabase.Name = "gridViewDatabase";
            this.gridViewDatabase.OptionsFind.AlwaysVisible = true;
            this.gridViewDatabase.OptionsFind.FindDelay = 100;
            this.gridViewDatabase.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewDatabase_RowClick);
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "ID";
            this.gridColumn5.FieldName = "ID";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Width = 200;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "No.";
            this.gridColumn6.FieldName = "STT";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 0;
            this.gridColumn6.Width = 120;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Name";
            this.gridColumn7.FieldName = "Name";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 1;
            this.gridColumn7.Width = 661;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Amount";
            this.gridColumn8.FieldName = "Amount";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.OptionsColumn.AllowEdit = false;
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 2;
            this.gridColumn8.Width = 257;
            // 
            // gridView4
            // 
            this.gridView4.GridControl = this.gridControlDatabase;
            this.gridView4.Name = "gridView4";
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
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(98, 12);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(162, 20);
            this.textName.TabIndex = 1;
            this.textName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textName_MouseDown);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(15, 85);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(61, 13);
            this.labelControl4.TabIndex = 24;
            this.labelControl4.Text = "Site records:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(15, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(31, 13);
            this.labelControl1.TabIndex = 18;
            this.labelControl1.Text = "Name:";
            // 
            // textAmount
            // 
            this.textAmount.Location = new System.Drawing.Point(98, 42);
            this.textAmount.Name = "textAmount";
            this.textAmount.Size = new System.Drawing.Size(162, 20);
            this.textAmount.TabIndex = 2;
            this.textAmount.Visible = false;
            this.textAmount.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textName_MouseDown);
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(14, 45);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(63, 13);
            this.labelControl8.TabIndex = 18;
            this.labelControl8.Text = "CPE Amount:";
            this.labelControl8.Visible = false;
            // 
            // SiteManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 384);
            this.Controls.Add(this.panel1);
            this.Name = "SiteManagement";
            this.Text = "Site Management";
            this.Load += new System.EventHandler(this.SiteManagement_Load);
            this.Click += new System.EventHandler(this.SiteManagement_Click);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ControlSiteRecords.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDatabase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDatabase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textAmount.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.TextEdit textName;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textAmount;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private System.Windows.Forms.TabControl ControlSiteRecords;
        private System.Windows.Forms.TabPage tabPage1;
        private DevExpress.XtraGrid.GridControl gridControlNew;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewNew;
        private DevExpress.XtraGrid.Columns.GridColumn ID1;
        private DevExpress.XtraGrid.Columns.GridColumn columnNo;
        private DevExpress.XtraGrid.Columns.GridColumn Name1;
        private DevExpress.XtraGrid.Columns.GridColumn Amount1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.TabPage tabPage2;
        private DevExpress.XtraGrid.GridControl gridControlDatabase;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDatabase;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraEditors.TextEdit txtpage;
        private System.Windows.Forms.Button butgo;
        private System.Windows.Forms.Button butall;
        private System.Windows.Forms.Button butnext;
        private System.Windows.Forms.Button butrev;
        private DevExpress.XtraEditors.SimpleButton butDelete;
        private DevExpress.XtraEditors.SimpleButton butEdit;
        private DevExpress.XtraEditors.SimpleButton butSave;
        private DevExpress.XtraEditors.SimpleButton butcancel;
    }
}