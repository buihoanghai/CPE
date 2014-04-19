using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using CPE_vs1.BusinessLayer;
using CPE_vs1.Interface;
using DAL.Implement.CPE_vs1DAL;
namespace CPE_vs1
{
    public partial class CPECatalogueInventorize : DevExpress.XtraEditors.XtraForm
    {
        public CPECatalogueInventorize()
        {
            InitializeComponent();
            SetComboboxAlgorithm(new LookUpAlgorithm());
            SetGridAlgorithm(new DevGridAlgorithm());
        }
        #region Set các interface
        void AddRecently()
        {
            object[] arr = { 0, cpeCur.Barcode, cpeCur.ID, cpeCur.Status };
            IGrid.addRecently(arr);
        }
        void loadListData()
        {
            if (SessionCur.staff.AccountType == 2)
            {
                LKSiteSearch.Visible = true;
                if (SessionCur.staff.AccountType == 2)
                    IGrid.loadListData(cpeCur.GetListInfor());
                else
                    IGrid.loadListData(cpeCur.GetListInforBySite(SessionCur.site.ID));
                LKSiteSearch.Properties.DataSource = new Site().GetListInfor();

            }
            else if(SessionCur.staff.AccountType==1)
            {
                IGrid.loadListData(cpeCur.GetListBySite(SessionCur.staff.Site_ID));
            }
        }
         void SetComboboxAlgorithm(IComboboxAlgorithm ICombo)
        {
            this.ICombo = ICombo;
        }
        void SetGridAlgorithm(IGridAlgorithm IGrid)
        {
            this.IGrid = IGrid;
            IGrid.setItems(ControlCPERecords, gridViewNew, gridViewDatabase, Table, cpeCur, gridControlNew, gridControlDataBase);
        }
        
        #endregion
        #region Khai báo biến
        ISitesDAL _siteDAL = new SitesDAL();
        CPE cpeCur=new CPE();
        IGridAlgorithm IGrid;
        IComboboxAlgorithm ICombo;
        Dictionary<string, Type> Table = new Dictionary<string, Type>() {
               {"STT", typeof(int)},
               {"Barcode", typeof(string)},
               {"ID", typeof(string)},
               {"Status", typeof(string)}};
        Dictionary<int, string> status = new Dictionary<int, string>() { { 1, "Available" }, { 2, "Deleted" }, { 3, "Faulty" }, { 4, "Lost" }, { 5, "Rented" }, { 6, "LoanMore" } };
        Dictionary<int, string> status1 = new Dictionary<int, string>() { { 1, "Available" }, { 3, "Faulty" }, { 4, "Lost" } };
        #endregion
        #region các hàm trên form
        void Delete()
        {
            DataRow dt = gridViewDatabase.GetFocusedDataRow();
            if (dt["Status"].ToString() != "1")
            {
                MessageBox.Show("Can't Delete!");
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Do you want delete it?", "Warn!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //DataRow dt = IGrid.getRowCur(ControlCPERecords, gridViewNew, gridViewDatabase);
                
                if (dt == null)
                    return;
                CPE cpe = (CPE)cpeCur.GetInfor(Convert.ToInt16(dt["ID"]));
                cpe.Delete(cpe);
                loadListData();
                ControlCPERecords.Enabled = true;
            }
        }
        void formLoad()
        {
            gridControlNew.DataSource = IGrid.CreateTable(Table);
            loadListData();
            ICombo.loadLookUp(new Site().GetListInfor(), lookUpSite);
            //ICombo.loadLookUp(EnumConfig.getTableFromEnum(EnumConfig.CPEStatus.Available), LookUpStatus);
            lookUpSite.ItemIndex = 0;
            LookUpStatus.Properties.DataSource = status1;
            LookUpStatus.ItemIndex = 0;
            LKStatusInGrid.DataSource = status;
            LKStatusIngridDataBase.DataSource = status;
            LKSiteInGrid.DataSource = _siteDAL.SelectAll();
            newLayerInForm();
            if (SessionCur.staff.AccountType != 2)
            {
                lookUpSite.Enabled = false;
                lookUpSite.EditValue = SessionCur.site.ID;
                LKSiteSearch.Visible = false;
                butAll.Visible = false;

            }
            
        }
        void getDataValueInForm()
        {
            cpeCur.Barcode = textBarcode.Text;
            cpeCur.Site_ID =int.Parse( lookUpSite.EditValue.ToString());
            if (txtSimNo.Text == "")
                cpeCur.Status = 3;
            else if (LookUpStatus.EditValue == null)
                cpeCur.Status = 1;
            else
                cpeCur.Status = int.Parse(LookUpStatus.EditValue.ToString());
            cpeCur.SIMNo = txtSimNo.Text;
        }
        void getLayerCur(string CPE)
        {
            if (CPE.Length != EnumConfig.LenghtBarcode)
                return;
            if (cpeCur.Barcode == CPE)
                return;
            CPE cpe = cpeCur.GetInfor(CPE,SessionCur.staff.Site_ID);
            if (cpe != null && cpe != cpeCur)
            {
                LoadLayerCur();
                cpeCur = cpe;
            }
            else
                cpeCur = new CPE();
        }
        void LoadLayerCur()
        {
            if (cpeCur == null)
                return;
            textBarcode.Text = cpeCur.Barcode;
            txtSimNo.Text = cpeCur.SIMNo;
            lookUpSite.EditValue = cpeCur.Site_ID;
            LookUpStatus.EditValue = cpeCur.Status;
        }
        void newLayerInForm()
        {
            cpeCur = new CPE();
            textBarcode.Text = "";
            ControlCPERecords.Enabled = true;
            txtSimNo.Text = "";
            LookUpStatus.Visible = false;
            _CheckRentLoan(true);
        }
        void Save()
        {

            if (textBarcode.Text != "")
            {
                getDataValueInForm();
                if (cpeCur.ID == 0)
                {

                    if (cpeCur.CheckExistBarcode(textBarcode.Text))
                    {
                        MessageBox.Show("Barcode already exist!");
                        return;
                    }
                    cpeCur.ID = cpeCur.Insert(cpeCur);
                }
                else
                {
                    cpeCur.Update(cpeCur);
                }
                if (cpeCur.ID > 0)
                {
                    loadListData();
                    AddRecently();
                    newLayerInForm();
                }
            }
            LookUpStatus.Visible = false;
            _CheckRentLoan(true);
        }
        void getCPE()
        {
            DataRow row = gridViewDatabase.GetFocusedDataRow();
            cpeCur = (CPE)cpeCur.GetInfor(int.Parse(row["ID"].ToString()));
        }
        void SelectedRow()
        {
            ControlCPERecords.Enabled = false;
            //cpeCur =(CPE) IGrid.getRowCur();
            getCPE();
            LoadLayerCur();
            LookUpStatus.Visible = true;
            if (cpeCur.Status == 5 || cpeCur.Status == 6)
            {
                LookUpStatus.Visible = false;
                _CheckRentLoan(false);
            }
        }
        void _CheckRentLoan(bool val)
        {
            textBarcode.Enabled = val;
            txtSimNo.Enabled = val;
            lookUpSite.Enabled = val;
        }
        #endregion

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            newLayerInForm();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            SelectedRow();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
           Delete();
        }

        private void CPECatalogueInventorize_Load(object sender, EventArgs e)
        {
            formLoad();

        }

        private void textBarcode_EditValueChanged(object sender, EventArgs e)
        {
            getLayerCur(textBarcode.Text);
        }

      
        private void gridViewNew_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            SelectedRow();
        }

        private void gridViewDatabase_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            SelectedRow();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if(valid.Validate())
                Save();
        }

        private void textBarcode_MouseDown(object sender, MouseEventArgs e)
        {
            common.openOnScreenKeyboard();
        }

        private void CPECatalogueInventorize_Click(object sender, EventArgs e)
        {
            common.killOnScreenKeyboard();
            UserSession.ResetTimer();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            common.killOnScreenKeyboard();
            UserSession.ResetTimer();
        }

        private void LKSiteSearch_EditValueChanged(object sender, EventArgs e)
        {
            gridControlDataBase.DataSource = cpeCur.GetAllListBySite((int)LKSiteSearch.EditValue);
        }

        private void txtSimNo_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void gridViewDatabase_DoubleClick(object sender, EventArgs e)
        {
            SelectedRow();
        }
        void getAllCPE()
        {
            gridControlDataBase.DataSource = cpeCur.GetListInfor();
        }
        private void butAll_Click(object sender, EventArgs e)
        {
            getAllCPE();
        }
    }
}