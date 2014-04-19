namespace CPE_vs1
{
    partial class CPECategory : DevExpress.XtraEditors.XtraForm
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
            this.buttonPackage = new System.Windows.Forms.Button();
            this.buttonPanalty = new System.Windows.Forms.Button();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.ControlCPERecords = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gridControlNew = new DevExpress.XtraGrid.GridControl();
            this.gridViewNew = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnPrice1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnStatus1 = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.columnPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.textPrice = new DevExpress.XtraEditors.TextEdit();
            this.textName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.textDescription = new DevExpress.XtraEditors.MemoEdit();
            this.panel1.SuspendLayout();
            this.ControlCPERecords.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtpage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDataBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDatabase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textDescription.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.buttonPackage);
            this.panel1.Controls.Add(this.buttonPanalty);
            this.panel1.Controls.Add(this.labelControl7);
            this.panel1.Controls.Add(this.ControlCPERecords);
            this.panel1.Controls.Add(this.buttonEdit);
            this.panel1.Controls.Add(this.buttonDelete);
            this.panel1.Controls.Add(this.buttonCancel);
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Controls.Add(this.labelControl4);
            this.panel1.Controls.Add(this.textPrice);
            this.panel1.Controls.Add(this.textName);
            this.panel1.Controls.Add(this.labelControl6);
            this.panel1.Controls.Add(this.labelControl5);
            this.panel1.Controls.Add(this.textDescription);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(621, 415);
            this.panel1.TabIndex = 4;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // buttonPackage
            // 
            this.buttonPackage.Location = new System.Drawing.Point(367, 344);
            this.buttonPackage.Name = "buttonPackage";
            this.buttonPackage.Size = new System.Drawing.Size(75, 59);
            this.buttonPackage.TabIndex = 32;
            this.buttonPackage.Text = "Package";
            this.buttonPackage.UseVisualStyleBackColor = true;
            // 
            // buttonPanalty
            // 
            this.buttonPanalty.Location = new System.Drawing.Point(448, 344);
            this.buttonPanalty.Name = "buttonPanalty";
            this.buttonPanalty.Size = new System.Drawing.Size(75, 59);
            this.buttonPanalty.TabIndex = 31;
            this.buttonPanalty.Text = "Penalty";
            this.buttonPanalty.UseVisualStyleBackColor = true;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(216, 19);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(57, 13);
            this.labelControl7.TabIndex = 30;
            this.labelControl7.Text = "Description:";
            // 
            // ControlCPERecords
            // 
            this.ControlCPERecords.Controls.Add(this.tabPage1);
            this.ControlCPERecords.Controls.Add(this.tabPage2);
            this.ControlCPERecords.Location = new System.Drawing.Point(7, 110);
            this.ControlCPERecords.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ControlCPERecords.Name = "ControlCPERecords";
            this.ControlCPERecords.SelectedIndex = 0;
            this.ControlCPERecords.Size = new System.Drawing.Size(602, 229);
            this.ControlCPERecords.TabIndex = 29;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gridControlNew);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.tabPage1.Size = new System.Drawing.Size(594, 203);
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
            this.gridControlNew.Size = new System.Drawing.Size(588, 191);
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
            this.columnPrice1,
            this.columnStatus1});
            this.gridViewNew.GridControl = this.gridControlNew;
            this.gridViewNew.Name = "gridViewNew";
            this.gridViewNew.OptionsFind.AlwaysVisible = true;
            this.gridViewNew.OptionsFind.FindDelay = 100;
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
            // columnPrice1
            // 
            this.columnPrice1.Caption = "Price";
            this.columnPrice1.FieldName = "Price";
            this.columnPrice1.Name = "columnPrice1";
            this.columnPrice1.Visible = true;
            this.columnPrice1.VisibleIndex = 3;
            this.columnPrice1.Width = 200;
            // 
            // columnStatus1
            // 
            this.columnStatus1.Caption = "Status";
            this.columnStatus1.FieldName = "Status";
            this.columnStatus1.Name = "columnStatus1";
            this.columnStatus1.Visible = true;
            this.columnStatus1.VisibleIndex = 4;
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
            this.tabPage2.Size = new System.Drawing.Size(594, 203);
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
            this.gridControlDataBase.Size = new System.Drawing.Size(588, 197);
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
            this.columnPrice,
            this.columnStatus});
            this.gridViewDatabase.GridControl = this.gridControlDataBase;
            this.gridViewDatabase.Name = "gridViewDatabase";
            this.gridViewDatabase.OptionsFind.AlwaysVisible = true;
            this.gridViewDatabase.OptionsFind.FindDelay = 100;
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
            // columnPrice
            // 
            this.columnPrice.Caption = "Price";
            this.columnPrice.FieldName = "Price";
            this.columnPrice.Name = "columnPrice";
            this.columnPrice.Visible = true;
            this.columnPrice.VisibleIndex = 3;
            this.columnPrice.Width = 150;
            // 
            // columnStatus
            // 
            this.columnStatus.Caption = "Status";
            this.columnStatus.FieldName = "Status";
            this.columnStatus.Name = "columnStatus";
            this.columnStatus.Visible = true;
            this.columnStatus.VisibleIndex = 4;
            this.columnStatus.Width = 200;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(530, 344);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 59);
            this.buttonEdit.TabIndex = 12;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(283, 344);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 59);
            this.buttonDelete.TabIndex = 11;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(452, 19);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 60);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(534, 19);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 60);
            this.buttonSave.TabIndex = 10;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 89);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(110, 13);
            this.labelControl4.TabIndex = 24;
            this.labelControl4.Text = "CPE Category records:";
            // 
            // textPrice
            // 
            this.textPrice.Location = new System.Drawing.Point(48, 44);
            this.textPrice.Name = "textPrice";
            this.textPrice.Size = new System.Drawing.Size(162, 20);
            this.textPrice.TabIndex = 5;
            this.textPrice.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textName_MouseDown);
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(48, 16);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(162, 20);
            this.textName.TabIndex = 4;
            this.textName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textName_MouseDown);
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(11, 47);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(27, 13);
            this.labelControl6.TabIndex = 18;
            this.labelControl6.Text = "Price:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(11, 19);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(31, 13);
            this.labelControl5.TabIndex = 17;
            this.labelControl5.Text = "Name:";
            // 
            // textDescription
            // 
            this.textDescription.Location = new System.Drawing.Point(279, 17);
            this.textDescription.Name = "textDescription";
            this.textDescription.Size = new System.Drawing.Size(162, 62);
            this.textDescription.TabIndex = 6;
            this.textDescription.UseOptimizedRendering = true;
            this.textDescription.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textName_MouseDown);
            // 
            // CPECategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 415);
            this.Controls.Add(this.panel1);
            this.Name = "CPECategory";
            this.Text = "CPECategory";
            this.Click += new System.EventHandler(this.CPECategory_Click);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ControlCPERecords.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtpage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDataBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDatabase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textDescription.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private System.Windows.Forms.TabControl ControlCPERecords;
        private System.Windows.Forms.TabPage tabPage1;
        private DevExpress.XtraGrid.GridControl gridControlNew;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewNew;
        private DevExpress.XtraGrid.Columns.GridColumn ID1;
        private DevExpress.XtraGrid.Columns.GridColumn columnNo;
        private DevExpress.XtraGrid.Columns.GridColumn columnName1;
        private DevExpress.XtraGrid.Columns.GridColumn columnPrice1;
        private DevExpress.XtraGrid.Columns.GridColumn columnStatus1;
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
        private DevExpress.XtraGrid.Columns.GridColumn columnPrice;
        private DevExpress.XtraGrid.Columns.GridColumn columnStatus;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit textPrice;
        private DevExpress.XtraEditors.TextEdit textName;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.MemoEdit textDescription;
        private System.Windows.Forms.Button buttonPackage;
        private System.Windows.Forms.Button buttonPanalty;
    }
}