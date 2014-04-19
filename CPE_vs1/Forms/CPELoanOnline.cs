using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DAL.Implement.CPE_vs1DAL;

namespace CPE_vs1
{
    public partial class CPELoanOnline : DevExpress.XtraEditors.XtraForm
    {
        #region variable
        Models.Loan _loanCur;
        Models.LoanDetail _loanDetailCur;
        Models.CPE _cpeCur;
        Models.Customer _customerCur;
        ICollection<Models.LoanDetail> _listLoanDetail;
        List<Models.Package> _listPackage=new List<Models.Package>();
        ILoanDetailsDAL _DALloanDetail = new LoanDetailsDAL();
        ILoansDAL _DALLoan = new LoansDAL();
        ICPEsDAL _DALcpe = new CPEsDAL();
        ICustomersDAL _DALcustomer = new CustomersDAL();
        IPromotionsDAL _DALpromotion = new PromotionsDAL();
        IAgentsDAL _DALagent = new AgentsDAL();
        IPackagesDAL _DALpackage = new PackagesDAL();
        Dictionary<int, string> status = new Dictionary<int, string>() { { 1, "Available" }, { 2, "Deleted" }, { 3, "Faulty" }, { 4, "Lost" }, { 5, "Rented" }, { 6, "LoanMore" }, { 7, "OrderOnline" } };
        decimal totalDeposit, totalRent,rentAmount;
        #endregion
        #region method
        public CPELoanOnline()
        {
            InitializeComponent();
        }
        void formload()
        {
            InitNewLoan();
            InitDateReturnAndLoan();
            LKPromotion.Properties.DataSource = _DALpromotion.SelectAll();
            LKAgent.Properties.DataSource = _DALagent.SelectAll();
            LKstatusInGrid.DataSource = status;
            LKBarodeInGrid.DataSource = _DALcpe.SelectAll();
            _listPackage = _DALpackage.SelectAll();
            txtCustomerCode.Focus();
        }
        void setCustomerToForm()
        {
            if (_customerCur != null && _customerCur.ID!=0)
            {
                txtPhone.Text = _customerCur.Phone==null?"":_customerCur.Phone;
                txtNationality.Text = _customerCur.Nationality==null?"":_customerCur.Nationality;
                txtCustomerName.Text = _customerCur.Name;
                dateEditDOB.DateTime = (DateTime)_customerCur.DOB;
                if (_customerCur.DrivingLisence != "" && _customerCur.DrivingLisence!=null)
                {
                    lblpassport.Text = "D. Lisence";
                    txtPassport.Text = _customerCur.DrivingLisence;
                }
                if (_customerCur.IDLisence != "" && _customerCur.IDLisence!=null)
                {
                    lblpassport.Text = "ID Lisence";
                    txtPassport.Text = _customerCur.IDLisence;
                }
                if (_customerCur.Passport != "" && _customerCur.Passport!=null)
                {
                    lblpassport.Text = "Passport number";
                    txtPassport.Text = _customerCur.Passport;
                    DateExpiredDate.DateTime = (DateTime)_customerCur.Expiry_date;
                }
            }
        }
        void getCustomer()
        {
            if (_loanCur != null)
            {
                _customerCur = _DALcustomer.SelectByID((int)_loanCur.Customer_ID);

            }
        }
        void getCustomerToForm()
        {
            getCustomer();
            setCustomerToForm();
        }
        void getLoanDetailToGrid()
        {
            if (_loanCur != null)
            {
                _listLoanDetail = _loanCur.LoanDetails;
                gridControlDatabase.DataSource = _listLoanDetail;
            }
        }
        void getLoan()
        {
            _loanCur = _DALLoan.SelectByCustomerCode(txtCustomerCode.Text);
        }
        void getLoanDetailFromGrid()
        {
            _loanDetailCur = (Models.LoanDetail)gridViewDatabase.GetFocusedRow();
        }
        void getLoanDetailToForm()
        {
            try
            {
                if (_loanDetailCur == null || _loanDetailCur.ID == 0)
                    return;
                LKAgent.EditValue = _loanDetailCur.AgentCode;
                dateEditLoan.DateTime = (DateTime)_loanDetailCur.LoanDate;
                dateEditReturn.EditValue = (DateTime)_loanDetailCur.ReturnDate;
                txtRentDays.Text = _loanDetailCur.RentDay.ToString();
                txtRentAmount.EditValue = _loanDetailCur.RentAmount;
                txtDepositAmount.EditValue = _loanDetailCur.Deposit;
                LKPromotion.EditValue = (int)_loanDetailCur.PromotionDisCount;
            }
            catch { }
        }
        void getTotalFromGridToForm()
        {
            totalDeposit=0;
            totalRent=0;
            if (gridViewDatabase.RowCount > 0)
            {
                for (int i = 0; i < gridViewDatabase.RowCount; i++)
                {
                    Models.LoanDetail ld = (Models.LoanDetail)gridViewDatabase.GetRow(i);
                    totalDeposit += Convert.ToDecimal(ld.Deposit);
                    totalRent += Convert.ToDecimal(ld.RentAmount);
                }
            }
            txtTotalOfDeposit.EditValue = totalDeposit;
            txtTotalOfRent.EditValue = totalRent;
        }
        void LoadInfoOrderOnlineToForm()
        {
            getLoan();
            getCustomerToForm();
            getLoanDetailToGrid();
            getTotalFromGridToForm();
        }
        void InitDateReturnAndLoan()
        {
            dateEditLoan.EditValue = null;
            dateEditReturn.EditValue = null;
        }
        void ClearLoanDetailControl()
        {

            InitDateReturnAndLoan();
            _loanDetailCur = null;
            txtBarcode.Text = "";
            LKPromotion.EditValue = null;
            LKAgent.EditValue = null;
            txtRentAmount.Text = "";
            txtRentDays.Text = "";
            txtDepositAmount.Text = "";
        }
        void ClearCustomerControl()
        {
            txtPassport.Text = "";
            DateExpiredDate.EditValue = null;
            txtNationality.Text = "";
            txtCustomerName.Text = "";
            dateEditDOB.EditValue = null;
            txtPhone.Text = "";
        }
        void ClearTotalControl()
        {
            txtTotalOfDeposit.Text = "";
            txtTotalOfRent.Text = "";
        }
        void ClearGridControl()
        {
            gridControlDatabase.DataSource = null;
        }
        void InitNewLoan()
        {
            _loanCur = new Models.Loan();
            _loanDetailCur = new Models.LoanDetail();
            _cpeCur = new Models.CPE();
            _customerCur = new Models.Customer();
            _listLoanDetail = new List<Models.LoanDetail>();
        }
        void deleteOneLoanDetaiInGrid()
        {
            try
            {
                Models.LoanDetail ld = (Models.LoanDetail)gridViewDatabase.GetFocusedRow();
                _DALloanDetail.DeleteByID(ld.ID);
                Models.CPE cpe = _DALcpe.SelectByID((int)ld.CPE_ID);
                cpe.Status = 1;
                _DALcpe.Update(cpe);
                gridViewDatabase.DeleteSelectedRows();
            }
            catch { }
        }
        void CheckCountRent()
        {

            try
            {
                
                if (dateEditLoan.DateTime.Date < DateTime.Now.Date)
                {
                    dateEditLoan.DateTime = DateTime.Now.Date;
                }
                if (dateEditReturn.DateTime.Date < dateEditLoan.DateTime.Date)
                {
                    dateEditReturn.DateTime = dateEditLoan.DateTime.Date.AddDays(2);
                }
                DateTime dayLoan = dateEditLoan.DateTime.Date;
                int dayRent = (dateEditReturn.DateTime - dayLoan).Days;
                txtRentDays.Text = dayRent.ToString();
                rentAmount = 0;
                while (dayRent > 0)
                {
                    foreach (var item in _listPackage)
                    {
                        if (dayRent >= (int)item.Days)
                        {
                            rentAmount += Convert.ToDecimal(item.Price);
                            dayRent = dayRent - (int)item.Days;
                            break;
                        }
                    }
                }
                if (LKPromotion.EditValue != null)
                {
                    txtRentAmount.Text = (rentAmount - Convert.ToInt16(LKPromotion.EditValue) * rentAmount / 100).ToString();
                }
                else
                {
                    txtRentAmount.Text = rentAmount.ToString();
                }
            }
            catch (Exception ex)
            {
                
            }
        }
        void getLoanDetailFromControl()
        {
            if (LKAgent.EditValue != null)
            _loanDetailCur.AgentCode = LKAgent.EditValue.ToString();
            _loanDetailCur.Deposit = (float)Convert.ToDecimal(txtDepositAmount.Text);
            _loanDetailCur.LoanDate = dateEditLoan.DateTime.Date;
            _loanDetailCur.RentAmount = (float)Convert.ToDecimal(txtRentAmount.Text);
            _loanDetailCur.RentDay = int.Parse(txtRentDays.Text);
            _loanDetailCur.ReturnDate = dateEditReturn.DateTime.Date;
            _loanDetailCur.SiteLoan_ID = SessionCur.site.ID;
            if (LKPromotion.EditValue!=null)
            _loanDetailCur.PromotionDisCount = int.Parse( LKPromotion.EditValue.ToString());
            _loanDetailCur.CPE_ID = _cpeCur.ID;
            _loanDetailCur.Status = 5;
        }
        void getCPE()
        {
            if (txtBarcode.Text.Length != 13)
                return;
                if (_DALcpe.CheckExistBarcodeRented(txtBarcode.Text))
                {
                    MessageBox.Show("CPE was Rented!");
                    _cpeCur = null;
                    return;
                }
                _cpeCur = _DALcpe.SelectByBarcodeStatuNormal(txtBarcode.Text,SessionCur.site.ID);
        }
        void EnableEditCPE(bool val)
        {
            if(_loanDetailCur!=null && _loanDetailCur.PromotionDisCount==null)
                LKPromotion.Enabled = val;
            LKAgent.Enabled = val;
            dateEditLoan.Enabled = val;
            dateEditReturn.Enabled = val;
        }
        void UpdateLoanDetail()
        {
            _DALloanDetail.Update(_loanDetailCur);
        }
        void UpdateCpeStatus()
        {
            _cpeCur.Status = 5;
            _DALcpe.Update(_cpeCur);
        }
        #endregion

        private void CPELoanOnline_Load(object sender, EventArgs e)
        {
            formload();
        }

        private void txtCustomerCode_EditValueChanged(object sender, EventArgs e)
        {
            InitNewLoan();
            LoadInfoOrderOnlineToForm();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            common.killOnScreenKeyboard();
            UserSession.ResetTimer();
        }

        private void txtCustomerCode_MouseDown(object sender, MouseEventArgs e)
        {
            common.openOnScreenKeyboard();
        }

        private void gridViewDatabase_DoubleClick(object sender, EventArgs e)
        {
            //EnableEditCPE(true);
            getLoanDetailFromGrid();
            getLoanDetailToForm();
            txtBarcode.Enabled = true;
            txtBarcode.Focus();
        }

        private void butcancel_Click(object sender, EventArgs e)
        {
            ClearLoanDetailControl();
        }

        private void butNewLoan_Click(object sender, EventArgs e)
        {
            InitNewLoan();
            ClearCustomerControl();
            ClearLoanDetailControl();
            ClearTotalControl();
            ClearGridControl();
        }

        private void butdelete_Click(object sender, EventArgs e)
        {
            deleteOneLoanDetaiInGrid();
        }

        private void butsave_Click(object sender, EventArgs e)
        {
            getLoanDetailFromControl();
            UpdateLoanDetail();
            UpdateCpeStatus();
            getLoan();
            getLoanDetailToGrid();
            getTotalFromGridToForm();
            ClearLoanDetailControl();
            EnableEditCPE(false);
            txtBarcode.Enabled = false;
        }

        private void LKPromotion_EditValueChanged(object sender, EventArgs e)
        {
            CheckCountRent();
        }

        private void dateEditLoan_EditValueChanged(object sender, EventArgs e)
        {
            CheckCountRent();
        }

        private void dateEditReturn_EditValueChanged(object sender, EventArgs e)
        {
            CheckCountRent();
        }

        private void txtBarcode_EditValueChanged(object sender, EventArgs e)
        {
            getCPE();
            if (_cpeCur != null)
                EnableEditCPE(true);
            else
                EnableEditCPE(false);
        }

        private void butUpdateInfor_Click(object sender, EventArgs e)
        {
            UpdateCustomer ud = new UpdateCustomer();
            ud._customerCur = _customerCur;
            ud.ShowDialog();
            _customerCur = ud._customerCur;
            setCustomerToForm();
        }
    }
}