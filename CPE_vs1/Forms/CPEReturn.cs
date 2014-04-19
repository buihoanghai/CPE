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
using Newtonsoft.Json;
using CPE_vs1.DTO;
using System.Linq;
using DAL.Implement.CPE_vs1DAL;
namespace CPE_vs1
{
    public partial class CPEReturn : DevExpress.XtraEditors.XtraForm
    {
        Models.Loan _loanCur = new Models.Loan();
        ILoansDAL _DALLoan = new LoansDAL();
        Models.Site _siteCur = new Models.Site();
        ISitesDAL _DALSite = new SitesDAL();
        Models.LoanDetail _loanDetailUpdate = new Models.LoanDetail();
        ILoanDetailsDAL _DALLoanDetail = new LoanDetailsDAL();
        Models.CPE _CPEUpdate = new Models.CPE();
        ICPEsDAL _DALCPE = new CPEsDAL();
        


        int[] numrow;
        decimal penalty = 0;
        decimal rent = 0;
        decimal deposit = 0;
        bool flag = false;
        Dictionary<int, string> status = new Dictionary<int, string>() { { 1, "Available" }, { 2, "Deleted" }, { 3, "Faulty" }, { 4, "Lost" }, { 5, "Rented" }, { 6, "LoanMore" } };
        public CPEReturn()
        {
            InitializeComponent();
            SetComboboxAlgorithm(new LookUpAlgorithm());
            SetGridAlgorithm(new DevGridAlgorithm());
        }
        #region Set các interface
        
        void loadListData()
        {
            gridControlDatabase.DataSource = null;
            DataTable dt = loanDetailCur.GetListInforCustomer(common.toString(customerCur.ID));
            decimal totalDeposit = 0;
            decimal totalRent = 0;
            decimal totalPenalty = 0;
            if (dt.Rows.Count == 0)
                return;
            loanDetailArray = new LoanDetailDTO[dt.Rows.Count];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                loanDetailArray[i] = new LoanDetailDTO();
                loanDetailArray[i].loanDetail =(LoanDetail) loanDetailCur.GetInfor(common.parseInt(dt.Rows[i]["ID"]));
                loanDetailArray[i].ID = loanDetailArray[i].loanDetail.ID;
                totalDeposit += Convert.ToDecimal(dt.Rows[i]["Deposit"]);
                totalRent += Convert.ToDecimal(dt.Rows[i]["RentAmount"]);
                totalPenalty += Convert.ToDecimal(dt.Rows[i]["PenaltyAmount"]);
            }
            IGrid.loadListData(dt);
            loanCur = (Loan)loanCur.GetInfor(common.parseInt(dt.Rows[0]["Loan_ID"]));
            textTotalOfDeposit.Text = totalDeposit.ToString();
            textTotalOfRent.Text = totalRent.ToString();
            textTotalOfPenalty.Text = totalPenalty.ToString();
            GetAllReference();
            if (flag == false)
            {
                rent = totalRent;
                deposit = totalDeposit;
                penalty = totalPenalty;
                flag = true;
            }
        }
        public void GetAllReference()
        {
            LKStatusInGrid.DataSource = status;
            using (var db = new Models.DBContextCPEDB())
            {
                var bar = from ba in db.CPEs select new { ba.ID, ba.Barcode};
                LKBarcodeInGrid.DataSource = bar.ToList();
            }
        }
        void SetComboboxAlgorithm(IComboboxAlgorithm ICombo)
        {
            this.ICombo = ICombo;
        }
        void SetGridAlgorithm(IGridAlgorithm IGrid)
        {
            this.IGrid = IGrid;
            IGrid.setItems(gridViewDatabase, loanDetailCur, gridControlDatabase);
        }

        #endregion
        
        #region Khai báo biến
        LoanDetailDTO[] loanDetailArray;
        LoanDetailDTO loanDetailDTOCur;
        decimal rentAmount = 0; 
        CPE cpeCur = new CPE();
        Loan loanCur = new Loan();
        TrackLoan trackloan = new TrackLoan();
        LoanDetail loanDetailCur = new LoanDetail();
        Customer customerCur = new Customer();
        DataTable package = new DataTable();
        Site siteCur = SessionCur.site;
        Penalty penaltyCur = new Penalty();
        IGridAlgorithm IGrid;
        IComboboxAlgorithm ICombo;
        #endregion
        #region các hàm trên form
        void Delete()
        {
            DialogResult dialogResult = MessageBox.Show("Do you want delete it?", "Warm!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DataRow dt = IGrid.getRowCur(gridViewDatabase);
                if (dt == null)
                    return;
                LoanDetail lD = (LoanDetail)loanDetailCur.GetInfor(common.parseInt(dt["ID"]));
                lD.Delete(lD);
                cpeCur.Status = (int)EnumConfig.CPEStatus.Available;
                cpeCur.Update(cpeCur);
                loadListData();
            }
        }
        void formLoad()
        {
            Package pk = new Package();
            package = pk.GetListInfor();
            //ICombo.loadLookUp(penaltyCur.GetListInforByPackage(), lookUpStatus);
            lookUpStatus.Properties.DataSource = penaltyCur.GetListInforByPackage();
            //lookUpStatus.ItemIndex = 0;
            groupLoan.Enabled = false;
            groupLoanItem.Enabled = true;
            groupLoanTotal.Enabled = false;
        }
        void getDataValueInForm()
        {
            _loanDetailUpdate.ID = loanDetailCur.ID;
            _loanDetailUpdate = _DALLoanDetail.SelectByID(loanDetailCur.ID);

           // _CPEUpdate = _DALCPE.SelectByID(cpeCur.ID);
            //    _CPEUpdate.Status = (byte)cpeCur.Status;
            //    //cpeCur.Update(cpeCur);
            //    _DALCPE.Update(_CPEUpdate);

            _loanDetailUpdate.LoanDate= loanDetailCur.LoanDate = dateEditLoan.DateTime;
            _loanDetailUpdate.SiteReturn_ID= loanDetailCur.SiteReturn_ID = siteCur.ID;
            _loanDetailUpdate.ReturnDate= loanDetailCur.ReturnDate = dateEditReturn.DateTime;
            //DataRowView row = lookUpStatus.Properties.GetDataSourceRowByKeyValue(lookUpStatus.EditValue) as DataRowView;
            //if (row != null)
            //    loanDetailCur.Status = common.parseInt(row["StatusCPE"]);
            numrow = gridLookUpEdit1View.GetSelectedRows();
            bool lost, fauty, available;
            lost = false;
            fauty = false; ;
            available = false;
            for (int i = 0; i < numrow.Length; i++)
            {
                DataRow row = (DataRow)gridLookUpEdit1View.GetDataRow(numrow[i]);
                penalty += Convert.ToDecimal(row["Amount"]);
                if (int.Parse(row["StatusCPE"].ToString()) == 4)
                    lost = true;
                if (int.Parse(row["StatusCPE"].ToString()) == 3)
                    fauty = true;
                if (int.Parse(row["StatusCPE"].ToString()) != 3 && int.Parse(row["StatusCPE"].ToString()) != 4)
                    available = true;
            }
            if (available)
            {
                loanDetailCur.Status = 1;
                _loanDetailUpdate.Status = (byte)1;
            }
            if (fauty)
            {
                loanDetailCur.Status = 3;
                _loanDetailUpdate.Status = (byte)3;
            }
            if(lost)
            {
                loanDetailCur.Status = 4;
                _loanDetailUpdate.Status = (byte)4;
            }
            if(textRentMoreDays.Text!="0" && (dateEditReturn.DateTime-DateTime.Now).Days>0)
            {
                loanDetailCur.Status = 6;// (int)EnumConfig.CPEStatusPenalty.LoanMore;
                _loanDetailUpdate.Status = (byte)6;
            }
            loanDetailCur.Deposit = Convert.ToDecimal(textDepositAmount.EditValue);
            _loanDetailUpdate.Deposit = (float)Convert.ToDecimal(textDepositAmount.EditValue);
            loanDetailCur.RentAmount = Convert.ToDecimal(textRentAmount.EditValue);
            _loanDetailUpdate.RentAmount = (float)Convert.ToDecimal(textRentAmount.EditValue);
             loanDetailCur.PenaltyAmount = Convert.ToDecimal(textPenaltyAmount.EditValue);
             _loanDetailUpdate.PenaltyAmount = (float)Convert.ToDecimal(textPenaltyAmount.EditValue);
            _loanDetailUpdate.RentDay= loanDetailCur.RentDay = int.Parse(textRentDays.Text)+int.Parse(textRentMoreDays.Text);
            
        }
        void getDataCustomer()
        {
            customerCur.DOB = dateEditDOB.DateTime;
            customerCur.Name = textCustomerName.Text;
            customerCur.Nationality = textNationality.Text;
            customerCur.Passport = textPassport.Text;
            customerCur.Phone = textPhone.Text;
        }
        void getCPECur(string CPE)
        {
            if (CPE.Length != EnumConfig.LenghtBarcode)
            {
                return;
            }
            cpeCur = new CPE();
            if (cpeCur.Barcode == CPE)
                return;
            cpeCur = cpeCur.GetInfor2(CPE);
            if (cpeCur == null)
                return;
          //  LoadCPECur();
            
            loadRowCur();
            lookUpStatus.Enabled = true;
            dateEditReturn.Enabled = true;
        }
        void getCustomerByBarcode(string Barcode)
        {
            Customer customner = customerCur.GetCustomerByBarcode(Barcode);
            if (customner.ID == 0)
            {
                return;
            }
            if (customerCur != null && customner != customerCur)
                customerCur = customner;
        }
        void getCustomer()
        {
            string passport = textPassport.Text;
            if (cmbInfoType.Text == "Passport")
            {
                //if (passport.Length != EnumConfig.LenghtBarcode)
                //{
                //    ClearControl();
                //}
                //else
                //{
                    Customer customer = customerCur.GetInfor(passport);
                    if (customer.ID == 0 || customer==null)
                    {
                        ClearControl();
                        return;
                    }
                    //if ((DateTime.Now - customner.Expiry_date).Days >= 0)
                    //{
                    //    MessageBox.Show("Your Passport is experied");
                    //    return;
                    //}
                    if (customerCur != null && customer != customerCur)
                        customerCur = customer;

                    LoadCustomnerCur();
                //}
            }
            else if (cmbInfoType.Text == "Driving License")
            {
                if (passport.Length != EnumConfig.LenghtBarcode)
                {
                    ClearControl();
                }
                else
                {
                    Customer customner = customerCur.GetInforByDrivingLisence(passport);
                    if (customner.ID == 0)
                    {
                        return;
                    }
                    if (customerCur != null && customner != customerCur)
                        customerCur = customner;
                    LoadCustomnerCur();
                }
            }
            else
            {
                if (passport.Length != EnumConfig.LenghtBarcode)
                {
                    ClearControl();
                }
                else
                {
                    Customer customner = customerCur.GetInforByIDLisence(passport);
                    if (customner.ID == 0)
                    {
                        return;
                    }
                    if (customerCur != null && customner != customerCur)
                        customerCur = customner;
                    LoadCustomnerCur();
                }
            }
        }

        private void ClearControl()
        {
            textCustomerName.Text = "";
            textNationality.Text = "";
            textPhone.Text = "";
            textTotalOfDeposit.Text = "";
            textTotalOfRent.Text = "";
            textTotalOfPenalty.Text = "";
            formLoad();
        }
        void getStatus()
        {
            penaltyLoanDetail();
        }
        void LoadLayerCur()
        {
          //  LoadCPECur();
            LoadLoanDetailCur();
            penaltyLoanDetail();
        }
        void LoadCPECur()
        {
            if (cpeCur == null)
                return;
   //         textBarcode.Text = cpeCur.Barcode;
            panelReturn.Enabled = true;
            butSave.Enabled = true;
        }
        void loadRowCur()
        {
            DataRow dt = IGrid.getRowCur(gridViewDatabase);
            for (int i = 0; i < gridViewDatabase.DataRowCount; i++)
            {
                gridViewDatabase.FocusedRowHandle = i;
                dt = IGrid.getRowCur(gridViewDatabase);
                if (cpeCur.ID == common.parseInt(dt["CPE_ID"]))
                {

                    Console.WriteLine("cpeCur ok:" + cpeCur.ID);
                    break;
                }
                if (i == gridViewDatabase.DataRowCount - 1)
                {
                    Console.WriteLine("cpeCur out:" + cpeCur.ID);
                    newLayerInForm();
                    return;
                }
            }
            panelReturn.Enabled = true;
            butSave.Enabled = true;
     //      dt = IGrid.getRowCur(gridViewDatabase);
            if (dt == null)
                return;
            //cpeCur = (CPE)cpeCur.GetInfor(common.parseInt(dt["CPE_ID"]));
            loanDetailCur = (LoanDetail)loanDetailCur.GetInfor(common.parseInt(dt["ID"]));
            for (int i = 0; i < loanDetailArray.Length; i++)
            {
                if (loanDetailArray[i].ID == loanDetailCur.ID)
                {
                    loanDetailDTOCur = loanDetailArray[i];
                }
            }
            LoadLayerCur();
            groupLoan.Enabled = false;
        }
        void LoadLoanDetailCur()
        {
            if (loanDetailCur == null)
                return;
            textDepositAmount.EditValue = common.toString(loanDetailCur.Deposit);
            textRentAmount.EditValue = common.toString(loanDetailCur.RentAmount);
            dateEditLoan.DateTime = loanDetailCur.LoanDate;
            
            dateEditReturn.DateTime = loanDetailCur.ReturnDate;
      //      dateTimePickerReturnDate.MinDate = loanDetailCur.ReturnDate;
            textRentDays.Text = loanDetailCur.RentDay.ToString();
            textPenaltyAmount.EditValue = loanDetailCur.PenaltyAmount;
            checkDayRent();
        //    ICombo.loadLookUp(penaltyCur.GetListInforByPackage(), lookUpStatus);
            DataTable dt=lookUpStatus.Properties.DataSource as DataTable;
            //lookUpStatus.ItemIndex = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (loanDetailCur.Status == common.parseInt(dt.Rows[i]["StatusCPE"]))
                {
                    //lookUpStatus.ItemIndex = i;
                    break;
                }
            }
            
            lookUpStatus.EditValue = loanDetailCur.Status;
        }
        void LoadCustomnerCur()
        {
            if (customerCur == null || customerCur.ID==0)
                return;
            dateEditDOB.DateTime = customerCur.DOB;
            textCustomerName.Text = customerCur.Name;
            textNationality.Text = customerCur.Nationality;
            textPhone.Text = customerCur.Phone;
            if (cmbInfoType.Text == "Passport")
            {
                DateExpiredDate.EditValue = customerCur.Expiry_date;
            }
            groupLoan.Enabled = true;
            groupLoanItem.Enabled = true;
            groupLoanTotal.Enabled = true;
            penalty = 0;
            rent = 0;
            deposit = 0;
            flag = false;
            loadListData();
            
        }
        void newLayerInForm()
        {
            cpeCur = new CPE();
            loanDetailCur = new LoanDetail();
            
            textRentDays.Text = "";

         //   dateEditLoan.DateTime = DateTime.Now;
         //   dateEditReturn.DateTime = DateTime.Now;
            dateEditReturn.Properties.MinValue = new DateTime(1945, 1, 1);
            dateEditReturn.DateTime = DateTime.Now;
            dateEditLoan.DateTime = DateTime.Now;
            dateEditReturn.Enabled = false;
            lookUpStatus.Enabled = false;
            barCodeControl1.Focus(); 
            textBarcode.Text = "";
            textBarcode.Focus();
            textPenaltyAmount.EditValue = 0;
            textDepositAmount.EditValue = 0;
            textRentAmount.EditValue = 0;
            textReturnAmount.EditValue = 0;
            
            textRentMoreDays.Text = "0";
            groupLoan.Enabled = true;
      //      panelReturn.Enabled = true;
            butSave.Enabled = false;
            unselectLookupStatus();
        }
        void penaltyLoanDetail()
        {
            decimal rent = loanDetailCur.RentAmount;
            decimal penalty = 0;
            int days = loanDetailCur.RentDay;
            int daysRent=(dateEditReturn.DateTime.Date - dateEditLoan.DateTime.Date).Days;
            if (daysRent > days && days > 0)
            {
                penalty = (rent / days) * (daysRent - days);
            }
            //DataRowView row = lookUpStatus.Properties.GetDataSourceRowByKeyValue(lookUpStatus.EditValue) as DataRowView;
            //if (row != null)
            //    penalty += Convert.ToDecimal(row["Amount"]);
            numrow = gridLookUpEdit1View.GetSelectedRows();
            for (int i = 0; i < numrow.Length; i++)
            {
                DataRow row = (DataRow)gridLookUpEdit1View.GetDataRow(numrow[i]);
                penalty += Convert.ToDecimal(row["Amount"]);
            }
            textPenaltyAmount.EditValue = penalty;
            //textReturnAmount.EditValue = (loanDetailCur.Deposit - penalty-rent);
            textReturnAmount.EditValue = (loanDetailCur.Deposit - penalty);
        }
        void Save()
        {
            getDataValueInForm();
            if (loanDetailCur.ID == 0)
            {
            }
            else
            {
                //loanDetailCur.Update(loanDetailCur);
                _DALLoanDetail.Update(_loanDetailUpdate);
                cpeCur.Status = loanDetailCur.Status;

                _CPEUpdate = _DALCPE.SelectByID(cpeCur.ID);
                _CPEUpdate.Status = (byte)cpeCur.Status;
                //cpeCur.Update(cpeCur);
                _DALCPE.Update(_CPEUpdate);
            }
            if (loanDetailCur.ID > 0)
            {
                SaveChoicePackage();
                //update code
                //LoanSave();
                //if (Convert.ToDecimal(textPenaltyAmount.EditValue) != 0)
                //    flag = false;
                loadListData();
                newLayerInForm();
            }
        }
        ICPEsDAL cpe = new CPEsDAL();
        ILoanDetailsDAL _loandetail = new LoanDetailsDAL();
        //BAL.Interface.ICPE_vs1BAL.ICPEsBAL cpe = new BAL.Implement.CPE_vs1BAL.CPEsBAL();
        //BAL.Interface.ICPE_vs1BAL.ILoanDetailsBAL _loandetail = new BAL.Implement.CPE_vs1BAL.LoanDetailsBAL();
        public void LoanSave()
        {
            using (var db = new Models.DBContextCPEDB())
            {
                var cp = from c in db.CPEs where c.Barcode == textBarcode.Text select c;
                var cp1 = cp.Single();
                cp1.Status = 1;
                cpe.Update(cp1);
                var loandetail = from ld in db.LoanDetails where ld.CPE_ID == cp1.ID && ld.Loan_ID==loanCur.ID select ld;
                var loandetail1 = loandetail.Single();
                loandetail1.Status = 1;
                _loandetail.Update(loandetail1);
            }
        }
        void SaveChoicePackage()
        {
            DateTime dayLoan = new DateTime(dateEditLoan.DateTime.Year, dateEditLoan.DateTime.Month, dateEditLoan.DateTime.Day);
            int dayRent = (dateEditReturn.DateTime - dayLoan).Days;
            if (dayRent != loanDetailCur.RentDay)
            {
                trackloan.DeleteByLoanIDReturn(loanDetailCur.ID);
            }
            rentAmount = 0;
            int y = 0;
            dayRent = dayRent == loanDetailCur.RentDay ? 0 : dayRent - loanDetailCur.RentDay;
            textRentMoreDays.Text = dayRent.ToString();
            loanDetailDTOCur.trackloan = new TrackLoan[100];
            while (dayRent > 0 && y < 1000)
            {
                for (int i = package.Rows.Count - 1; i >= 0; i--)
                {
                    if (dayRent >= (int)package.Rows[i]["Days"])
                    {
                        trackloan.LoanDetail_ID = loanDetailCur.ID;
                        trackloan.Package_ID = (int)package.Rows[i]["ID"];
                        trackloan.Type = 2;
                        trackloan.Insert(trackloan);
                        loanDetailDTOCur.trackloan[y] = trackloan;
                        rentAmount += (decimal)package.Rows[i]["Price"];
                        dayRent = dayRent - (int)package.Rows[i]["Days"];
                         y++;
                        break;
                    }
                }
               
            }
            loanDetailCur.RentAmount = rentAmount + loanDetailCur.RentAmount;
        }
        void checkDayRent()
        {
            DateTime dayLoan = new DateTime(dateEditLoan.DateTime.Year, dateEditLoan.DateTime.Month, dateEditLoan.DateTime.Day);
            int dayRent = (dateEditReturn.DateTime.Date - dayLoan.Date).Days;
            textRentDays.Text = dayRent.ToString();
            dayRent = dayRent == loanDetailCur.RentDay ? 0 : dayRent - loanDetailCur.RentDay;
            textRentMoreDays.Text = dayRent.ToString();
            if (dayRent > 0)
                lookUpStatus.Enabled = false;
            else
                lookUpStatus.Enabled = true;
            rentAmount = 0;
            while (dayRent > 0)
            {
                for (int i = package.Rows.Count - 1; i >= 0; i--)
                {
                    if (dayRent >= (int)package.Rows[i]["Days"])
                    {
                        rentAmount += Convert.ToDecimal( package.Rows[i]["Price"]);
                        dayRent = dayRent - Convert.ToInt16(package.Rows[i]["Days"]);
                        break;
                    }
                }
            }
            textRentAmount.EditValue =( rentAmount+ loanDetailCur.RentAmount).ToString();


        }
        void SaveLoan()
        {
            if (loanCur.ID != 0)
            {
                loanCur.Status = 2;
                loanCur.Update(loanCur);
            }
            this.Close();
        }
        void SelectedRow()
        {
            gridControlDatabase.Enabled = false;
            DataRow dt = null;
            if (gridViewDatabase.GetSelectedRows().Length != 0)
                dt = gridViewDatabase.GetDataRow(gridViewDatabase.GetSelectedRows()[0]);
            cpeCur = (CPE)cpeCur.GetInfor(common.parseInt(dt["CPE_ID"]));
            loanDetailCur = (LoanDetail)loanDetailCur.GetInfor(common.parseInt(dt["ID"]));
            LoadLayerCur();
        }
        #endregion
        private void gridViewDatabase_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
        //    loadRowCur();
        }

        private void CPEReturn_Load(object sender, EventArgs e)
        {
            formLoad();
        }
        void unselectLookupStatus()
        {
            for (int i = 0; i < numrow.Length; i++)
            {
                gridLookUpEdit1View.UnselectRow(numrow[i]);
            }
        }
        private void textBarcode_EditValueChanged(object sender, EventArgs e)
        {
          //  barCodeControl1.Focus();
            
            if (customerCur.ID != 0 && customerCur != null)
            {
                try
                {
                    _loanCur = _DALLoan.GetLoanByBarcode(textBarcode.Text);
                    if (_loanCur.CreditCardNumer != null && _loanCur.LoanSiteID != SessionCur.site.ID)
                    {
                        _siteCur = _DALSite.SelectByID((int)_loanCur.LoanSiteID);
                        MessageBox.Show("CPE pay by Cash and Loan from " + _siteCur.Name + " and can not return here! ");
                        return;
                    }
                }
                catch { return; }
                getCPECur(textBarcode.Text);
                try
                {
                    if (textBarcode.Text.Length == 13)
                    {
                        if (cpeCur == null)
                            return;
                        PenaltyMoreday();
                        //lookUpStatus.ItemIndex = 0;
                    }
                }
                catch { }
            }
            else
            {
                try
                {
                    _loanCur = _DALLoan.GetLoanByBarcode(textBarcode.Text);
                    if (_loanCur.CreditCardNumer != null && _loanCur.LoanSiteID != SessionCur.site.ID)
                    {
                        _siteCur = _DALSite.SelectByID((int)_loanCur.LoanSiteID);
                        MessageBox.Show("CPE pay by Cash and Loan from " + _siteCur.Name + " and can not return here! ");
                        return;
                    }
                }
                catch { return; }
                customerCur = new Customer();
                getCustomerByBarcode(textBarcode.Text);
                LoadCustomnerCur();
                if (customerCur.ID != 0 && customerCur != null)
                {
                    if (customerCur.DrivingLisence != "")
                    {
                        lblpassport.Text = "D. Lisence";
                        textPassport.Text = customerCur.DrivingLisence;
                        DateExpiredDate.EditValue = null;
                    }
                    if (customerCur.IDLisence != "")
                    {
                        lblpassport.Text = "ID Lisence";
                        textPassport.Text = customerCur.IDLisence;
                        DateExpiredDate.EditValue = null;
                    }
                    if (customerCur.Passport != "")
                    {
                        lblpassport.Text = "Passport number";
                        textPassport.Text = customerCur.Passport;
                        DateExpiredDate.DateTime = (DateTime)customerCur.Expiry_date;
                    }
                    cmbInfoType.Enabled = false;
                    
                    textBarcode_EditValueChanged(sender, e);
                }
            }
        }

        private void PenaltyMoreday()
        {
            if (DateTime.Now.Date > loanDetailCur.ReturnDate.Date)
            {
                int daysMore;
                if (dateEditReturn.DateTime.Date > DateTime.Now.Date)
                {
                    daysMore = (dateEditReturn.DateTime.Date - loanDetailCur.ReturnDate.Date).Days;
                }
                else
                    daysMore = (DateTime.Now.Date - loanDetailCur.ReturnDate.Date).Days;
                textPenaltyAmount.EditValue = checkDayRentMore(daysMore).ToString();
                //textReturnAmount.EditValue = (Convert.ToDecimal(textDepositAmount.EditValue) - Convert.ToDecimal(textRentAmount.EditValue) - Convert.ToDecimal(textPenaltyAmount.EditValue)).ToString();
                textReturnAmount.EditValue = (Convert.ToDecimal(textDepositAmount.EditValue) - Convert.ToDecimal(textPenaltyAmount.EditValue)).ToString();
            }
        }
        private void textPassport_EditValueChanged(object sender, EventArgs e)
        {
            if( customerCur.ID == 0 || customerCur == null)
             getCustomer();
        }
        private void lookUpStatus_EditValueChanged(object sender, EventArgs e)
        {
            getStatus();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (dateEditReturn.DateTime.Date == loanDetailCur.ReturnDate.Date)
            {
               //dateEditReturn =Convert.ToDecimal(dateEditReturn.EditValue);
                Save();
                try
                {
                    penalty += Convert.ToDecimal(textPenaltyAmount.Text);
                    textTotalOfPenalty.Text = penalty.ToString();
                    textTotalOfDeposit.Text = deposit.ToString();
                    textTotalOfRent.Text = rent.ToString();
                    textRentAmount.EditValue = Convert.ToDecimal(textRentAmount.EditValue);
                    textDepositAmount.EditValue = Convert.ToDecimal(textDepositAmount.EditValue);

                }
                catch { }
            }
            else
            {
                getDataValueInForm();
                if (loanDetailCur.ID == 0)
                {
                }
                else
                {
                    _DALLoanDetail.Update(_loanDetailUpdate);
                    cpeCur.Status = loanDetailCur.Status;

                    _CPEUpdate = _DALCPE.SelectByID(cpeCur.ID);
                    _CPEUpdate.Status = (byte)cpeCur.Status;
                    _DALCPE.Update(_CPEUpdate);

                    //loanDetailCur.Update(loanDetailCur);
                    //cpeCur.Status = loanDetailCur.Status;
                    //cpeCur.Update(cpeCur);
                }
                flag = false;
                loadListData();
                newLayerInForm();
                try
                {
                    textTotalOfRent.EditValue = rent;
                }
                catch { }
            }
            unselectLookupStatus();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            newLayerInForm();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            //loadRowCur();
            try
            {
                DataRow row = gridViewDatabase.GetFocusedDataRow();
                CPE cpeCur1 = (CPE)cpeCur.GetInfor(common.parseInt(row["CPE_ID"]));
                textBarcode.Text = cpeCur1.Barcode;
            }
            catch { }
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            SaveLoan();
        }
        private bool _calendarDroppedDown = false;
        private void dateTimePickerLoanDate_ValueChanged(object sender, EventArgs e)
        {
            _calendarDroppedDown = true;
        }

        private void dateTimePickerReturnDate_ValueChanged(object sender, EventArgs e)
        {
            _calendarDroppedDown = true;
            penaltyLoanDetail();
        }

        private void dateTimePickerLoanDate_CloseUp(object sender, EventArgs e)
        {
            _calendarDroppedDown = false;
            RefreshToolbox(null, null);
        }
        public void RefreshToolbox(object sender, EventArgs e)
        {
            if (_calendarDroppedDown) //only refresh the display once user has chosen a date from the calendar, not while they're paging through the days.
                return;
            checkDayRent();
            penaltyLoanDetail();
        }
        private void dateTimePickerReturnDate_CloseUp(object sender, EventArgs e)
        {
            _calendarDroppedDown = false;
            RefreshToolbox(null, null); 
        }

        private void textBarcode_MouseDown(object sender, MouseEventArgs e)
        {
            common.openOnScreenKeyboard();
        }

        private void CPEReturn_Click(object sender, EventArgs e)
        {
            common.killOnScreenKeyboard();
            UserSession.ResetTimer();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            common.killOnScreenKeyboard();
            UserSession.ResetTimer();
        }

        private void cmbInfoType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbInfoType.Text == "Passport")
            {
                lblexpiredDate.Enabled = true;
                DateExpiredDate.Enabled = true;
                lblpassport.Text = "Passport Number";
            }
            else
            {
                lblpassport.Text = "Lisence";
                lblexpiredDate.Enabled = false;
                DateExpiredDate.Enabled = false;
            }
            NewReturn();
        }

        private void dateEditReturn_EditValueChanged(object sender, EventArgs e)
        {
            if ((loanDetailCur.ReturnDate.Date - dateEditReturn.DateTime.Date).Days > 0)
            {
                MessageBox.Show("invalid return date");
                dateEditReturn.EditValue = loanDetailCur.ReturnDate;
            }
            else
            {
                int daysRentMore = (dateEditReturn.DateTime.Date - loanDetailCur.ReturnDate.Date).Days;
                if (daysRentMore <= 0) return;
                textRentMoreDays.Text = daysRentMore.ToString();
                decimal rentAmount = checkDayRentMore(daysRentMore);         
                textRentAmount.EditValue = (rentAmount + loanDetailCur.RentAmount).ToString();
                textDepositAmount.EditValue = loanDetailCur.Deposit;
                //textReturnAmount.EditValue = Convert.ToDecimal(textDepositAmount.EditValue) - Convert.ToDecimal(textRentAmount.EditValue);
                textReturnAmount.EditValue = Convert.ToDecimal(textDepositAmount.EditValue) - Convert.ToDecimal(textPenaltyAmount.EditValue);
                //lookUpStatus.Enabled = false;
                unselectLookupStatus();
            }
        }
        decimal checkDayRentMore(int daysRentMore)
        {
            rentAmount = 0;
            while (daysRentMore > 0)
            {
                for (int i = package.Rows.Count - 1; i >= 0; i--)
                {
                    if (daysRentMore >= (int)package.Rows[i]["Days"])
                    {
                        rentAmount += Convert.ToDecimal( package.Rows[i]["Price"]);
                        daysRentMore = daysRentMore - Convert.ToInt16( package.Rows[i]["Days"]);
                        break;
                    }
                }
            }
            return rentAmount;

        }

        private void butNewReturn_Click(object sender, EventArgs e)
        {
            NewReturn();
        }

        private void NewReturn()
        {
            newLayerInForm();
            ClearControl();
            textPassport.Text = "";
            dateEditDOB.EditValue = null;
            cmbInfoType.Enabled = true;
            gridControlDatabase.DataSource = null;
            customerCur = new Customer();
            loanCur = new Loan();
            penalty = 0;
        }


        private void gridLookUpEdit1View_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            bool flag1 = false;
            //getStatus();
            string s = "";
            numrow = gridLookUpEdit1View.GetSelectedRows();
            for (int i = 0; i < numrow.Length; i++)
            {
                DataRow row = (DataRow)gridLookUpEdit1View.GetDataRow(numrow[i]);
                s += row["Title"].ToString() + ", ";
                if (row["Amount"].ToString() == "0")
                    flag1 = true;
            }
            if (!flag1)
                getStatus();
            else
                PenaltyMoreday();

            lookUpStatus.Text = s;
        }

        private void lookUpStatus_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
            string s = "";
            numrow = gridLookUpEdit1View.GetSelectedRows();
            for (int i = 0; i < numrow.Length; i++)
            {
                DataRow row = (DataRow)gridLookUpEdit1View.GetDataRow(numrow[i]);
                s += row["Title"].ToString() + ", ";
            }
            e.DisplayText = s;
        }

    }
}