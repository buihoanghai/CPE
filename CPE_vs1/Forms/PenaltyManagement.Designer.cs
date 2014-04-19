namespace CPE_vs1
{
    partial class PenaltyManagement
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
            this.textAmount = new DevExpress.XtraEditors.SpinEdit();
            this.textPercent = new DevExpress.XtraEditors.SpinEdit();
            this.butEdit = new DevExpress.XtraEditors.SimpleButton();
            this.butDelete = new DevExpress.XtraEditors.SimpleButton();
            this.butSave = new DevExpress.XtraEditors.SimpleButton();
            this.butCancel = new DevExpress.XtraEditors.SimpleButton();
            this.LookUpStatus = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.ControlPackagePanaltyRecords = new System.Windows.Forms.TabControl();
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
            this.columnTitle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridPercents = new DevExpress.XtraGrid.Columns.GridColumn();
            this.textTitle = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPercent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpStatus.Properties)).BeginInit();
            this.ControlPackagePanaltyRecords.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtpage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDataBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDatabase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textTitle.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.textAmount);
            this.panel1.Controls.Add(this.textPercent);
            this.panel1.Controls.Add(this.butEdit);
            this.panel1.Controls.Add(this.butDelete);
            this.panel1.Controls.Add(this.butSave);
            this.panel1.Controls.Add(this.butCancel);
            this.panel1.Controls.Add(this.LookUpStatus);
            this.panel1.Controls.Add(this.labelControl14);
            this.panel1.Controls.Add(this.ControlPackagePanaltyRecords);
            this.panel1.Controls.Add(this.textTitle);
            this.panel1.Controls.Add(this.labelControl3);
            this.panel1.Controls.Add(this.labelControl4);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.labelControl8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 376);
            this.panel1.TabIndex = 6;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // textAmount
            // 
            this.textAmount.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.textAmount.Location = new System.Drawing.Point(75, 40);
            this.textAmount.Name = "textAmount";
            this.textAmount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.textAmount.Properties.IsFloatValue = false;
            this.textAmount.Properties.Mask.EditMask = "N00";
            this.textAmount.Size = new System.Drawing.Size(131, 20);
            this.textAmount.TabIndex = 41;
            this.textAmount.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textTitle_MouseDown);
            // 
            // textPercent
            // 
            this.textPercent.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.textPercent.Location = new System.Drawing.Point(272, 41);
            this.textPercent.Name = "textPercent";
            this.textPercent.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.textPercent.Properties.IsFloatValue = false;
            this.textPercent.Properties.Mask.EditMask = "N00";
            this.textPercent.Size = new System.Drawing.Size(131, 20);
            this.textPercent.TabIndex = 40;
            this.textPercent.Visible = false;
            this.textPercent.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textTitle_MouseDown);
            // 
            // butEdit
            // 
            this.butEdit.Location = new System.Drawing.Point(507, 348);
            this.butEdit.Name = "butEdit";
            this.butEdit.Size = new System.Drawing.Size(75, 23);
            this.butEdit.TabIndex = 39;
            this.butEdit.Text = "Edit";
            this.butEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // butDelete
            // 
            this.butDelete.Location = new System.Drawing.Point(426, 348);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(75, 23);
            this.butDelete.TabIndex = 38;
            this.butDelete.Text = "Delete";
            this.butDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // butSave
            // 
            this.butSave.Location = new System.Drawing.Point(477, 12);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(75, 23);
            this.butSave.TabIndex = 37;
            this.butSave.Text = "Save";
            this.butSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // butCancel
            // 
            this.butCancel.Location = new System.Drawing.Point(396, 12);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(75, 23);
            this.butCancel.TabIndex = 36;
            this.butCancel.Text = "Cancel";
            this.butCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // LookUpStatus
            // 
            this.LookUpStatus.Location = new System.Drawing.Point(259, 14);
            this.LookUpStatus.Name = "LookUpStatus";
            this.LookUpStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookUpStatus.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name")});
            this.LookUpStatus.Properties.DisplayMember = "Name";
            this.LookUpStatus.Properties.PopupSizeable = false;
            this.LookUpStatus.Properties.ShowHeader = false;
            this.LookUpStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.LookUpStatus.Properties.ValueMember = "ID";
            this.LookUpStatus.Size = new System.Drawing.Size(131, 20);
            this.LookUpStatus.TabIndex = 35;
            // 
            // labelControl14
            // 
            this.labelControl14.Location = new System.Drawing.Point(196, 17);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(57, 13);
            this.labelControl14.TabIndex = 34;
            this.labelControl14.Text = "Status CPE:";
            // 
            // ControlPackagePanaltyRecords
            // 
            this.ControlPackagePanaltyRecords.Controls.Add(this.tabPage2);
            this.ControlPackagePanaltyRecords.Location = new System.Drawing.Point(12, 98);
            this.ControlPackagePanaltyRecords.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ControlPackagePanaltyRecords.Name = "ControlPackagePanaltyRecords";
            this.ControlPackagePanaltyRecords.SelectedIndex = 0;
            this.ControlPackagePanaltyRecords.Size = new System.Drawing.Size(577, 248);
            this.ControlPackagePanaltyRecords.TabIndex = 29;
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
            this.tabPage2.Size = new System.Drawing.Size(569, 222);
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
            this.gridControlDataBase.Size = new System.Drawing.Size(563, 216);
            this.gridControlDataBase.TabIndex = 24;
            this.gridControlDataBase.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDatabase});
            this.gridControlDataBase.DoubleClick += new System.EventHandler(this.gridControlDataBase_DoubleClick);
            // 
            // gridViewDatabase
            // 
            this.gridViewDatabase.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.columnNo1,
            this.columnTitle,
            this.columnAmount,
            this.gridPercents});
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
            // 
            // columnNo1
            // 
            this.columnNo1.Caption = "No.";
            this.columnNo1.FieldName = "STT";
            this.columnNo1.Name = "columnNo1";
            this.columnNo1.OptionsColumn.AllowEdit = false;
            this.columnNo1.Visible = true;
            this.columnNo1.VisibleIndex = 0;
            this.columnNo1.Width = 99;
            // 
            // columnTitle
            // 
            this.columnTitle.Caption = "Title";
            this.columnTitle.FieldName = "Title";
            this.columnTitle.Name = "columnTitle";
            this.columnTitle.OptionsColumn.AllowEdit = false;
            this.columnTitle.Visible = true;
            this.columnTitle.VisibleIndex = 1;
            this.columnTitle.Width = 492;
            // 
            // columnAmount
            // 
            this.columnAmount.Caption = "Amount";
            this.columnAmount.FieldName = "Amount";
            this.columnAmount.Name = "columnAmount";
            this.columnAmount.OptionsColumn.AllowEdit = false;
            this.columnAmount.Visible = true;
            this.columnAmount.VisibleIndex = 2;
            this.columnAmount.Width = 223;
            // 
            // gridPercents
            // 
            this.gridPercents.Caption = "Percents";
            this.gridPercents.FieldName = "Percents";
            this.gridPercents.Name = "gridPercents";
            this.gridPercents.OptionsColumn.AllowEdit = false;
            this.gridPercents.Width = 224;
            // 
            // textTitle
            // 
            this.textTitle.Location = new System.Drawing.Point(59, 14);
            this.textTitle.Name = "textTitle";
            this.textTitle.Size = new System.Drawing.Size(131, 20);
            this.textTitle.TabIndex = 20;
            this.textTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textTitle_MouseDown);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 17);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(24, 13);
            this.labelControl3.TabIndex = 18;
            this.labelControl3.Text = "Title:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 77);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(61, 13);
            this.labelControl4.TabIndex = 24;
            this.labelControl4.Text = "Site records:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(225, 44);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(41, 13);
            this.labelControl1.TabIndex = 18;
            this.labelControl1.Text = "Percent:";
            this.labelControl1.Visible = false;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(12, 43);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(41, 13);
            this.labelControl8.TabIndex = 18;
            this.labelControl8.Text = "Amount:";
            // 
            // PenaltyManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 376);
            this.Controls.Add(this.panel1);
            this.Name = "PenaltyManagement";
            this.Text = "Penalty";
            this.Load += new System.EventHandler(this.PackagePenalty_Load);
            this.Click += new System.EventHandler(this.PenaltyManagement_Click);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPercent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpStatus.Properties)).EndInit();
            this.ControlPackagePanaltyRecords.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtpage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDataBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDatabase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textTitle.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl ControlPackagePanaltyRecords;
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
        private DevExpress.XtraGrid.Columns.GridColumn columnTitle;
        private DevExpress.XtraGrid.Columns.GridColumn columnAmount;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit textTitle;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraGrid.Columns.GridColumn gridPercents;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.LookUpEdit LookUpStatus;
        private DevExpress.XtraEditors.SimpleButton butEdit;
        private DevExpress.XtraEditors.SimpleButton butDelete;
        private DevExpress.XtraEditors.SimpleButton butSave;
        private DevExpress.XtraEditors.SimpleButton butCancel;
        private DevExpress.XtraEditors.SpinEdit textAmount;
        private DevExpress.XtraEditors.SpinEdit textPercent;
    }
}