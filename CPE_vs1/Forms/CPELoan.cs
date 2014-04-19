using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using CPE_vs1.Interface;
using CPE_vs1.BusinessLayer;
using System.Linq;
using DAL.Implement.CPE_vs1DAL;
using DevExpress.XtraReports.UI;

namespace CPE_vs1
{
    public partial class CPELoan : DevExpress.XtraEditors.XtraForm
    {
        public CPELoan()
        {
            InitializeComponent();
            SetComboboxAlgorithm(new LookUpAlgorithm());
            SetGridAlgorithm(new DevGridAlgorithm());
        }
        #region Set các interface
        void loadListData()
        {
            DataTable dt = new DataTable();
            if (cmbLoanType.Text == "CPE Barcode")
                dt = loanDetailCur.GetListInfor(common.toString(loanCur.ID));
            else
                dt = loanDetailCur.GetListInfor(common.toString(loanOnline.ID));
            decimal totalDeposit = 0;
            decimal totalRent = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
			{
                totalDeposit += Convert.ToDecimal(dt.Rows[i]["Deposit"]);
                totalRent += Convert.ToDecimal(dt.Rows[i]["RentAmount"]);
            }
            IGrid.loadListData(dt);
            textTotalOfDeposit.Text = totalDeposit.ToString();
            textTotalOfRent.Text = totalRent.ToString();

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

        Models.Customer _customerInsert = new Models.Customer();
        Models.Loan _loanCur = new Models.Loan();
        ILoansDAL _DALLoan = new LoansDAL();
        ICustomersDAL _DALCustomer = new CustomersDAL();
        Models.LoanDetail _loanDetailInsert = new Models.LoanDetail();
        ILoanDetailsDAL _DALLoanDetail = new LoanDetailsDAL();
        Models.CPE _CPEUpdate = new Models.CPE();
        ICPEsDAL _DALCPE = new CPEsDAL();
        List<Models.LoanDetail> _listLoandetail = new List<Models.LoanDetail>();
        ITrackLoansDAL _DALTrackLoan = new TrackLoansDAL();
        Models.TrackLoan _trackLoanCur = new Models.TrackLoan();

        decimal rentAmount = 0;
        CPE cpeCur = new CPE();
        Loan loanCur = new Loan();
        Loan loanOnline = new Loan();
        LoanDetail loanDetailCur = new LoanDetail();
        Customer customnerCur = new Customer();
        DataTable package = new DataTable();
        Location locationCur = SessionCur.location;
        Staff staffCur = SessionCur.staff;
        CPEGlobal cpeGlobal = new CPEGlobal();
        Site siteCur = SessionCur.site;
        TrackLoan trackloan = new TrackLoan();
        IGridAlgorithm IGrid;
        IComboboxAlgorithm ICombo;
        IPromotionsDAL promoDAL = new PromotionsDAL();
        IAgentsDAL AgentDAL = new AgentsDAL();
        ICPEsDAL cpeDAL = new CPEsDAL();
        Models.Customer _customerCur=new Models.Customer();
        Dictionary<int, string> status = new Dictionary<int, string>() { { 1, "Available" }, { 2, "Deleted" }, { 3, "Faulty" }, { 4, "Lost" }, { 5, "Rented" }, { 6, "LoanMore" }, { 7, "OrderOnline" } };
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
                cpeCur = (CPE)cpeCur.GetInfor(common.parseInt(dt["CPE_ID"]));
                cpeCur.Status = (int)EnumConfig.CPEStatus.Available;
                cpeCur.Update(cpeCur);
                loadListData();
            }
        }
        void getCustomerFromForm()
        {
            _customerCur.ID = customnerCur.ID;
            _customerCur.Phone = textPhone.Text;
            _customerCur.Nationality = textNationality.Text;
            _customerCur.Name = textCustomerName.Text;
            _customerCur.DOB = dateEditDOB.DateTime.Date;
            _customerCur.Email = txtEmail.Text;
            if (cmbInfoType.Text == "Passport")
            {
                _customerCur.Passport = textPassport.Text;
                _customerCur.Expiry_date = DateExpiredDate.DateTime.Date;
            }
            else if (cmbInfoType.Text == "Driving License")
            {
                _customerCur.DrivingLisence = textPassport.Text;
            }
            else
            {
                _customerCur.IDLisence = textPassport.Text;
            }
        }
        void setCustomerToForm()
        {
            if (_customerCur != null && _customerCur.ID != 0)
            {
                textPhone.Text = _customerCur.Phone;
                textNationality.Text = _customerCur.Nationality;
                textCustomerName.Text = _customerCur.Name;
                dateEditDOB.DateTime = (DateTime)_customerCur.DOB;
                txtEmail.Text = _customerCur.Email;
                if (cmbInfoType.Text == "Passport")
                {
                    textPassport.Text = _customerCur.Passport;
                    DateExpiredDate.DateTime = (DateTime)_customerCur.Expiry_date;
                }
                else if (cmbInfoType.Text == "Driving License")
                {
                    textPassport.Text = _customerCur.DrivingLisence;
                }
                else
                {
                    textPassport.Text = _customerCur.IDLisence;
                }
            }
        }
        void formLoad()
        {
            LKstatusInGrid.DataSource = status;
            LKBarodeInGrid.DataSource = cpeDAL.SelectAll();
            LKAgent.Properties.DataSource = AgentDAL.SelectAll();
            LKPromotion.Properties.DataSource = promoDAL.SelectAll();
            Package pk = new Package();
           package= pk.GetListInfor();
           cpeGlobal = (CPEGlobal)cpeGlobal.GetInfor(1);
            groupLoan.Enabled = false;
            groupLoanItem.Enabled = false;
            groupLoanTotal.Enabled = false;
        }
        void getDataValueInForm()
        {
            _loanDetailInsert.Loan_ID= loanDetailCur.Loan_ID = loanCur.ID;
            _loanDetailInsert.LoanDate= loanDetailCur.LoanDate = dateEditLoan.DateTime;
            _loanDetailInsert.SiteLoan_ID= loanDetailCur.SiteLoan_ID = siteCur.ID;
            _loanDetailInsert.CPE_ID= loanDetailCur.CPE_ID = cpeCur.ID;
             loanDetailCur.Status = (int)EnumConfig.CPEStatus.Rented;
             _loanDetailInsert.Status = (byte)EnumConfig.CPEStatus.Rented;
            _loanDetailInsert.ReturnDate= loanDetailCur.ReturnDate = dateEditReturn.DateTime;
            loanDetailCur.Deposit = Convert.ToDecimal(textDepositAmount.Text);
            _loanDetailInsert.Deposit = (float)Convert.ToDecimal(textDepositAmount.Text);
            loanDetailCur.RentAmount = Convert.ToDecimal(textRentAmount.Text);
            _loanDetailInsert.RentAmount =(float) Convert.ToDecimal(textRentAmount.Text);
            _loanDetailInsert.RentDay= loanDetailCur.RentDay = common.parseInt(textRentDays.Text);
            _loanDetailInsert.AgentCode= loanDetailCur.AgentCode = LKAgent.EditValue==null?"":LKAgent.EditValue.ToString();
             loanDetailCur.PromotionDisCount = float.Parse(LKPromotion.EditValue==null?"0":LKPromotion.EditValue.ToString());
             _loanDetailInsert.PromotionDisCount = (int)float.Parse(LKPromotion.EditValue == null ? "0" : LKPromotion.EditValue.ToString());
             _loanDetailInsert.PenaltyAmount = 0;
        }
        void getDataCustomer()
        {
            if (customnerCur.ID == 0)
            {
                if (cmbInfoType.Text == "Passport")
                {
                    _customerInsert.DrivingLisence= customnerCur.DrivingLisence = null;
                    _customerInsert.IDLisence= customnerCur.IDLisence = null;
                    _customerInsert.Passport= customnerCur.Passport = textPassport.Text;
                    _customerInsert.Expiry_date= customnerCur.Expiry_date = (DateTime)DateExpiredDate.EditValue;
                }
                else if (cmbInfoType.Text == "Driving License")
                {
                    _customerInsert.DrivingLisence= customnerCur.DrivingLisence = textPassport.Text;
                    _customerInsert.IDLisence= customnerCur.IDLisence = null;
                    _customerInsert.Passport= customnerCur.Passport = null;
                }
                else
                {
                    _customerInsert.DrivingLisence= customnerCur.DrivingLisence = null;
                    _customerInsert.IDLisence= customnerCur.IDLisence = textPassport.Text;
                    _customerInsert.Passport= customnerCur.Passport = null;
                }
            }
            else if (cmbInfoType.Text == "Passport")
            {
                _customerInsert.Expiry_date= customnerCur.Expiry_date = (DateTime)DateExpiredDate.EditValue;
            }
            _customerInsert.DOB= customnerCur.DOB = dateEditDOB.DateTime;
            _customerInsert.Name= customnerCur.Name = textCustomerName.Text;
            _customerInsert.Nationality= customnerCur.Nationality = textNationality.Text;
            _customerInsert.Phone= customnerCur.Phone = textPhone.Text;
            _customerInsert.Email= customnerCur.Email = txtEmail.Text;
            
        }
        void getCPECur(string CPE)
        {
            if (CPE.Length != EnumConfig.LenghtBarcode)
            {
                panelLoan.Enabled = false;
                ClearLoanItem();
                return;
            }
            //if (cpeCur.Barcode == CPE || cpeCur.SerialNumber == CPE)
            //    return;
            if (cpeCur.CheckExistBarcodeRented(CPE))
            {
                MessageBox.Show("CPE was Rented!");
                return;
            }
            CPE cpe = cpeCur.GetInfor(CPE,SessionCur.staff.Site_ID);
            if (cpe== null)
            {
                panelLoan.Enabled = false;
                cpeCur = new CPE();
                return;
            }
            if (cpe != null && cpe != cpeCur)
                cpeCur = cpe;
            LoadCPECur();
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
                    Customer customner = customnerCur.GetInfor(passport);
                    if (customner.ID == 0)
                    {
                        RenewCustomer();
                        return;
                    }
                    //if ((DateTime.Now - customner.Expiry_date).Days >= 0)
                    //{
                    //    MessageBox.Show("Your Passport is experied");
                    //    return;
                    //}
                    SetCustomerCurAndLoad(customner);
                //}
            }
            else if (cmbInfoType.Text == "Driving License")
            {
                //if (passport.Length != EnumConfig.LenghtBarcode)
                //{
                //    ClearControl();
                //}
                //else
                //{
                    Customer customner = customnerCur.GetInforByDrivingLisence(passport);
                    if (customner.ID == 0)
                    {
                        RenewCustomer();
                        return;
                    }
                    SetCustomerCurAndLoad(customner);
                //}
            }
            else
            {
                //if (passport.Length != EnumConfig.LenghtBarcode)
                //{
                //    ClearControl();
                //}
                //else
                //{
                    Customer customner = customnerCur.GetInforByIDLisence(passport);
                    if (customner.ID == 0)
                    {
                        RenewCustomer();
                        return;
                    }
                    SetCustomerCurAndLoad(customner);
                //}
            }
            
        }

        private void RenewCustomer()
        {
            ClearControl();
            customnerCur = new Customer();
            butnewcustomer.Visible = true;
            gridControlDatabase.DataSource = null;
            NewLoan();
            
        }

        private void SetCustomerCurAndLoad(Customer customner)
        {
            if (customnerCur != null && customner != customnerCur)
            {
                customnerCur = customner;
                butnewcustomer.Visible = false;
            }
            LoadCustomnerCur();
        }
        private void NewLoan()
        {
            customnerCur = new Customer();
            loanCur = new Loan();
            loanDetailCur = new LoanDetail();
            cpeCur = new CPE();
            GroupSummery.Visible = false;
            _loanCur = new Models.Loan();
        }
        void calculateTotal()
        {
            lblDeviceQTY.Text = gridViewDatabase.RowCount.ToString();
            lblCollectionLocation.Text = SessionCur.site.Name;
            lblLoanDate.Text = DateTime.Now.Date.ToShortDateString();
            if (gridViewDatabase.RowCount > 1)
                lblReturndate.Text = "Multiple";
            else
                lblReturndate.Text = Convert.ToDateTime(gridViewDatabase.GetDataRow(0)["ReturnDate"].ToString()).Date.ToShortDateString();
            lblReturnType.Text = "";
            lblRentalPrice.Text ="SGD "+ textTotalOfRent.Text;
            lblSubTotal.Text = "SGD " + (Convert.ToDecimal(textTotalOfRent.Text) + Convert.ToDecimal(textTotalOfDeposit.Text)).ToString();
            lblCustomerName.Text = textCustomerName.Text;
            if (cmbInfoType.Text == "Passport")
            {
                lblPassportNumber.Text = textPassport.Text;
                lblPassportExpiration.Text = DateExpiredDate.DateTime.Date.ToShortDateString();
                lblPassportExpiration.Visible = true;
                lbl16.Visible = true;
            }
            else if (cmbInfoType.Text == "Driving Lisence")
            {
                lbl15.Text = "Driving Lisencce";
                lblPassportNumber.Text = textPassport.Text;
                lblPassportExpiration.Visible = false;
                lbl16.Visible = false;
            }
            else
            {
                lbl15.Text = "ID Lisencce";
                lblPassportNumber.Text = textPassport.Text;
                lblPassportExpiration.Visible = false;
                lbl16.Visible = false;
            }
            lblDateOfBirth.Text = dateEditDOB.DateTime.Date.ToShortDateString();
            lblEmail.Text = txtEmail.Text;
            lblContactNumber.Text = textPhone.Text;
        }
        public void GetCustomerByCustomerBarcode(string barcode)
        {
            Customer customner = new Customer();
            Loan loan = new Loan();
            if (cmbLoanType.Text == "Customer Code")
            {
                customner = customnerCur.GetCustomerByCustomerCode(barcode);
                loan = (Loan)loanOnline.GetInforByCustomerCode(barcode);
            }
            //else
            //{
            //    //customner = customnerCur.GetCustomerByCustomerBarcode(barcode);
            //}
            if (customner.ID == 0)
                return;
            if (customnerCur != null && customner != customnerCur)
            {
                customnerCur = customner;
                loanOnline = loan;
            }
            LoadCustomnerCur();
            textPassport.Text = customner.Passport;

        }

        private void ClearControl()
        {
            dateEditDOB.EditValue = null;
            DateExpiredDate.EditValue = null;
            textCustomerName.Text = "";
            textNationality.Text = "";
            textPhone.Text = "";
            textTotalOfDeposit.EditValue = 0;
            textTotalOfRent.EditValue = 0;
            txtEmail.Text = "";
            formLoad();
        }
        void ClearLoanItem()
        {
            textBarcode.Text = "";
            LKPromotion.EditValue = null;
            LKAgent.EditValue = null;
            dateEditLoan.EditValue = null;
            dateEditReturn.EditValue = null;
            textRentDays.Text = "";
            textRentAmount.EditValue = 0;
            textDepositAmount.EditValue = 0;
        }
        void LoadLayerCur()
        {
            LoadCPECur();
            LoadLoanDetailCur();
        }
        void LoadCPECur()
        {
            if (cpeCur == null)
                return;
            textBarcode.Text = cpeCur.Barcode;
            panelLoan.Enabled = true;
            textDepositAmount.Text = cpeGlobal.Deposit.ToString();
            butsave.Enabled = true;
            checkDayRent();
        
        }
        void loadRowCur()
        {
            DataRow dt = IGrid.getRowCur( gridViewDatabase);
            if (dt == null)
                return;
            cpeCur = (CPE)cpeCur.GetInfor(common.parseInt(dt["CPE_ID"]));
            loanDetailCur = (LoanDetail)loanDetailCur.GetInfor(common.parseInt(dt["ID"]));
            LoadLayerCur();
            textBarcode.Enabled = false;
        }
        void LoadLoanDetailCur()
        {
            if (loanDetailCur == null)
                return;
            textDepositAmount.Text = loanDetailCur.Deposit.ToString();
            textRentAmount.Text = loanDetailCur.RentAmount.ToString();
            dateEditLoan.DateTime = loanDetailCur.LoanDate;
            dateEditReturn.DateTime = loanDetailCur.ReturnDate;
            LKPromotion.EditValue = (int)loanDetailCur.PromotionDisCount;
            LKAgent.EditValue = loanDetailCur.AgentCode;

            checkDayRent();
        }
        void LoadCustomnerCur()
        {
            if (customnerCur == null)
            {
                return;
            }
            if (cmbInfoType.Text == "Passport")
            {
                DateExpiredDate.EditValue = customnerCur.Expiry_date;
            }
            dateEditDOB.DateTime = customnerCur.DOB;
            textCustomerName.Text = customnerCur.Name;
            textNationality.Text = customnerCur.Nationality;
            textPhone.Text = customnerCur.Phone;
            txtEmail.Text = customnerCur.Email;
            groupLoan.Enabled = true;
            groupLoanItem.Enabled = true;
            groupLoanTotal.Enabled = true;
        }
        void newLayerInForm()
        {
            cpeCur = new CPE();
            loanDetailCur = new LoanDetail();
        //    packageCur = new Package();
            dateEditLoan.EditValue = null;
            dateEditReturn.EditValue = null;
            textBarcode.Text = "";
            panelLoan.Enabled = false;
            butsave.Enabled = false;
            LKPromotion.EditValue = null;
            LKAgent.EditValue = null;
        }
        void SaveChoicePackage()
        {
            DateTime dayLoan = new DateTime(dateEditLoan.DateTime.Year, dateEditLoan.DateTime.Month, dateEditLoan.DateTime.Day);
            int dayRent = (dateEditReturn.DateTime - dayLoan).Days;
            if (dayRent != loanDetailCur.RentDay)
            {
                //trackloan.DeleteByLoanID(loanDetailCur.ID);
                _DALTrackLoan.DeleteByLoanDetailID(loanDetailCur.ID);
            }
            rentAmount = 0;
            int y = 0;
            while (dayRent > 0 && y < 1000)
            {
                for (int i = package.Rows.Count - 1; i >= 0; i--)
                {
                    if (dayRent >= (int)package.Rows[i]["Days"])
                    {
                        _trackLoanCur.LoanDetail_ID= trackloan.LoanDetail_ID = loanDetailCur.ID;
                        _trackLoanCur.Package_ID= trackloan.Package_ID = (int)package.Rows[i]["ID"];
                        _trackLoanCur.Type= trackloan.Type = 1;
                        _trackLoanCur.Created = DateTime.Now;
                        _trackLoanCur.Created_By = SessionCur.staff.ID;
                        _DALTrackLoan.Insert(_trackLoanCur);
                        //trackloan.Insert(trackloan);
                        rentAmount += Convert.ToDecimal( package.Rows[i]["Price"]);
                        dayRent = dayRent - (int)package.Rows[i]["Days"];
                        break;
                    }
                }
                y++;
            }
            if (LKPromotion.EditValue != null)
            {
                loanDetailCur.RentAmount = (rentAmount - Convert.ToDecimal(LKPromotion.EditValue));
            }
            else
            {
                loanDetailCur.RentAmount = rentAmount;
            }
        }

        void OpenFormCreditCard()
        {
            Forms.CreditCard cr = new Forms.CreditCard();
            cr._loanCur.ID = loanCur.ID;
            cr.txtNameOnCard.Text = textCustomerName.Text;
            cr.ShowDialog();
        }
        void PrintReceipt()
        {
            Form.CPELoanReceipt report = new Form.CPELoanReceipt();
            report.lblDeviceQTY.Text = gridViewDatabase.RowCount.ToString();
            report.lblLocation.Text = SessionCur.site.Name;
            report.lblLoanDate.Text = DateTime.Now.Date.ToShortDateString();
            if (gridViewDatabase.RowCount > 1)
                report.lblReturnDate.Text = "Multiple";
            else
                report.lblReturnDate.Text = Convert.ToDateTime(gridViewDatabase.GetDataRow(0)["ReturnDate"].ToString()).Date.ToShortDateString();
            report.lblreturnType.Text = "";
            report.lblRentalPrice.Text = textTotalOfRent.Text;
            report.lblOnlineDiscount.Text = "";
            report.lblDelivery.Text = "";
            report.lblSubTotal.Text = (Convert.ToDecimal(textTotalOfRent.Text) + Convert.ToDecimal(textTotalOfDeposit.Text)).ToString();
            report.lblCustomerName.Text = textCustomerName.Text;
            if (cmbInfoType.Text == "Passport")
            {
                report.lblPassportNumber.Text = textPassport.Text;
                report.lblExpireDate.Text = DateExpiredDate.DateTime.Date.ToShortDateString();
                report.lblExpireDate.Visible = true;
                report.lblExpireDateBold.Visible = true;
            }
            else if (cmbInfoType.Text == "Driving Lisence")
            {
                report.lblPassportNumberBold.Text = "Driving Lisencce";
                report.lblPassportNumber.Text = textPassport.Text;
                report.lblExpireDate.Visible = false;
                report.lblExpireDateBold.Visible = false;
            }
            else
            {
                report.lblPassportNumberBold.Text = "ID Lisencce";
                report.lblPassportNumber.Text = textPassport.Text;
                report.lblExpireDate.Visible = false;
                report.lblExpireDateBold.Visible = false;
            }
            report.lblDateOfBirth.Text = dateEditDOB.DateTime.Date.ToShortDateString();
            report.lblEmail.Text = txtEmail.Text;
            ReportPrintTool pt = new ReportPrintTool(report);
            pt.ShowRibbonPreviewDialog();
            //PrintBarcode report = new PrintBarcode();
            //ReportPrintTool pt = new ReportPrintTool(report);
            //pt.ShowRibbonPreviewDialog();
        }
        void checkDayRent()
        {
            dateEditLoan.DateTime = dateEditLoan.DateTime < DateTime.Now ? DateTime.Now : dateEditLoan.DateTime;
            dateEditReturn.DateTime = dateEditReturn.DateTime <= dateEditLoan.DateTime.AddDays(2) ? dateEditLoan.DateTime.AddDays(2) : dateEditReturn.DateTime;
            DateTime dayLoan = new DateTime(dateEditLoan.DateTime.Year, dateEditLoan.DateTime.Month, dateEditLoan.DateTime.Day);
            int dayRent = (dateEditReturn.DateTime - dayLoan).Days;
            textRentDays.Text = dayRent.ToString();
            rentAmount = 0;
            while (dayRent > 0)
            {
                for (int i = package.Rows.Count - 1; i >= 0; i--)
                {
                    if (dayRent >= (int)package.Rows[i]["Days"])
                    {
                        rentAmount += Convert.ToDecimal( package.Rows[i]["Price"]);
                        dayRent = dayRent - (int)package.Rows[i]["Days"];
                        break;
                    }
                }
            }
            if (LKPromotion.EditValue != null)
            {
                textRentAmount.Text = (rentAmount - Convert.ToInt16( LKPromotion.EditValue)*rentAmount/100).ToString();
            }
            else
            {
                textRentAmount.Text = rentAmount.ToString();
            }
         

        }
        void Save()
        {
           
            //SaveCustomer();
            if(cmbLoanType.Text=="CPE Barcode")
            SaveLoan();
           
            getDataValueInForm();
            if (loanDetailCur.ID == 0)
            {
                //loanDetailCur.ID = loanDetailCur.Insert(loanDetailCur);
                _DALLoanDetail.Insert(_loanDetailInsert);
                _loanDetailInsert.ID = loanDetailCur.ID = _DALLoanDetail.GetMaxID();
            }
            else
            {
                //loanDetailCur.Update(loanDetailCur);
                _DALLoanDetail.Update(_loanDetailInsert);
               
            }
            if (loanDetailCur.ID > 0)
            {
                cpeCur.Status = (int)EnumConfig.CPEStatus.Rented;
               // cpeCur.Update(cpeCur);
                _CPEUpdate = _DALCPE.SelectByID(cpeCur.ID);
                _CPEUpdate.Status = (int)EnumConfig.CPEStatus.Rented;
                _DALCPE.Update(_CPEUpdate);

                SaveChoicePackage();
                loadListData();
                newLayerInForm();
            }
        }
        void SaveLoan()
        {
            if (loanCur.ID == 0)
            {
                loanCur.Customer_ID = customnerCur.ID;
                loanCur.Staff_ID = staffCur.ID;
                loanCur.Status = 1;
                loanCur.CustomerCode = "";
                loanCur.CustomerBarcode = "";
                loanCur.ID = loanCur.Insert(loanCur);

                _loanCur = _DALLoan.SelectByID(loanCur.ID);
                _loanCur.LoanSiteID = SessionCur.site.ID;
                //_DALLoan.Update(_loanCur);
            }
        }
        void SaveCustomer()
        {
            if (textPassport.Text != "")
            {
                getDataCustomer();
                if (customnerCur.ID == 0)
                {
                    //customnerCur.ID = customnerCur.Insert(customnerCur);

                    _DALCustomer.Insert(_customerInsert);
                    _customerInsert.ID= customnerCur.ID = _DALCustomer.GetMaxID();
                    groupLoan.Enabled = true;
                    groupLoanItem.Enabled = true;
                    groupLoanTotal.Enabled = true;
                }
                else
                {
                    //customnerCur.Update(customnerCur);
                    _DALCustomer.Update(_customerInsert);
                }
            }
            else
            {
                MessageBox.Show("Invalid Passport!");
            }
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
        private void textBarcode_EditValueChanged(object sender, EventArgs e)
        {
            getCPECur(textBarcode.Text);
            barCodeControl1.Text = textBarcode.Text;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            newLayerInForm();
            textBarcode.Enabled = true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Save();
            textBarcode.Enabled = true;
            textBarcode.Focus();
        }

        private void textPassport_EditValueChanged(object sender, EventArgs e)
        {
            try { getCustomer(); }
            catch { }
            
        }

        private void CPELoan_Load(object sender, EventArgs e)
        {
            formLoad();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            loadRowCur();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Valid.Validate())
            {
                if(cmbInfoType.Text=="Passport")
                if ((DateTime.Now.Date - DateExpiredDate.DateTime.Date).Days >= 0 || DateExpiredDate == null)
                {
                    MessageBox.Show("Invalid Expired date");
                    return;
                }
                if (DateTime.Now.Year - dateEditDOB.DateTime.Year < 18)
                {
                    MessageBox.Show("Invalid DOB");
                    return;
                }
                SaveCustomer();
            }
            butnewcustomer.Visible = false;

        }

        private void dateTimePickerReturnDate_ValueChanged(object sender, EventArgs e)
        {
            //_calendarDroppedDown = true;
            try
            {
                checkDayRent();
            }
            catch { }
        }

        private void dateTimePickerLoanDate_ValueChanged(object sender, EventArgs e)
        {
            //_calendarDroppedDown = true;
            try
            {
                checkDayRent();
            }
            catch { }
        }
        private bool _calendarDroppedDown = false;
        private void dateTimePickerReturnDate_CloseUp(object sender, EventArgs e)
        {
            _calendarDroppedDown = false;
            RefreshToolbox(null, null); //NOW we want to refresh display
        }
        public void RefreshToolbox(object sender, EventArgs e)
        {
            if (_calendarDroppedDown) //only refresh the display once user has chosen a date from the calendar, not while they're paging through the days.
                return;
            checkDayRent();
        }

        private void dateTimePickerLoanDate_CloseUp(object sender, EventArgs e)
        {
            _calendarDroppedDown = false;
            RefreshToolbox(null, null); //NOW we want to refresh display
        }

        

        private void CPELoan_Click(object sender, EventArgs e)
        {
            common.killOnScreenKeyboard();
            UserSession.ResetTimer();
        }

        private void textPassport_MouseDown(object sender, MouseEventArgs e)
        {
            common.openOnScreenKeyboard();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            common.killOnScreenKeyboard();
            UserSession.ResetTimer();
        }

        private void cmbLoanType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLoanType.Text == "CPE Barcode")
            {
                GroupCustomerCode.Enabled = false;
            }
            else
            {
                GroupCustomerCode.Enabled = true;
            }
        }
        
        private void txtCustomerbarcode_EditValueChanged(object sender, EventArgs e)
        {
            if (txtCustomerbarcode.Text.Length == 13)
            {
                barCodeControl2.Text = txtCustomerbarcode.Text;
                GetCustomerByCustomerBarcode(txtCustomerbarcode.Text);
            }
        }

        private void txtCustomerCode_EditValueChanged(object sender, EventArgs e)
        {
            if (txtCustomerCode.Text!= "")
            {
                GetCustomerByCustomerBarcode(txtCustomerCode.Text);
                loadListData();
            }
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
            customnerCur = new Customer();
            ClearControl();
            textPassport.Text = "";
            textPassport.Focus();
            ClearLoanItem();
            NewLoan();
        }

        private void LKPromotion_EditValueChanged(object sender, EventArgs e)
        {
            checkDayRent();
        }

        private void textPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void butNewLoan_Click(object sender, EventArgs e)
        {
            ClearControl();
            NewLoan();
            newLayerInForm();
            textPassport.Text = "";
            ClearLoanItem();
        }

        private void butUpdateInfor_Click(object sender, EventArgs e)
        {

            getCustomerFromForm();
            UpdateCustomer ud = new UpdateCustomer();
            ud._customerCur = _customerCur;
            ud.ShowDialog();
            _customerCur = ud._customerCur;
            setCustomerToForm();
        }

        private void gridViewDatabase_DoubleClick(object sender, EventArgs e)
        {
            loadRowCur();
        }
        void updateRentalPriceAndSubPriceForLoan()
        {
            _loanCur = _DALLoan.SelectByID(loanCur.ID);
            _loanCur.RentalPrice = (float)Convert.ToDecimal(textTotalOfRent.Text);
            _loanCur.SubTotal = (float)Convert.ToDecimal(textTotalOfRent.Text) + (float)Convert.ToDecimal(textTotalOfDeposit.Text);
            _DALLoan.Update(_loanCur);
        }
        private void butConfirm_Click(object sender, EventArgs e)
        {
            GroupSummery.Visible = true;
            calculateTotal();
            updateRentalPriceAndSubPriceForLoan();
        }
        private void butPrint_Click(object sender, EventArgs e)
        {
            PrintReceipt();
        }
        private void butCreditCard_Click(object sender, EventArgs e)
        {
            OpenFormCreditCard();
        }

        
    }
}