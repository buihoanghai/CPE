using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace CPE_vs1.Forms
{
    public partial class CPELoanNew : DevExpress.XtraEditors.XtraForm
    {
        #region variable
        Models.Customer _customerCur = new Models.Customer();
        Models.Loan _loanCur = new Models.Loan();
        Models.LoanDetail _loanDetailCur = new Models.LoanDetail();
        Models.CPE _cpeCur = new Models.CPE();

        #endregion

        #region method

        void _getLoanDetailFromControl()
        {
            _loanDetailCur.LoanDate  = dateEditLoan.DateTime;
            _loanDetailCur.SiteLoan_ID = SessionCur.site.ID;
            _loanDetailCur.CPE_ID  = _cpeCur.ID;
            _loanDetailCur.Status = (byte)EnumConfig.CPEStatus.Rented;
            _loanDetailCur.ReturnDate  = dateEditReturn.DateTime;
            _loanDetailCur.Deposit = (float)Convert.ToDecimal(textDepositAmount.Text);
            _loanDetailCur.RentAmount = (float)Convert.ToDecimal(textRentAmount.Text);
            _loanDetailCur.RentDay = common.parseInt(textRentDays.Text);
            _loanDetailCur.AgentCode  = LKAgent.EditValue == null ? "" : LKAgent.EditValue.ToString();
            _loanDetailCur.PromotionDisCount = (int)float.Parse(LKPromotion.EditValue == null ? "0" : LKPromotion.EditValue.ToString());
            _loanDetailCur.PenaltyAmount = 0;
        }
        void _setLoanDetailToControl()
        {

        }
        void _getCustomerFromControl()
        {
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

        void _setCustomerToControl()
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

        #endregion


        public CPELoanNew()
        {
            InitializeComponent();
        }
    }
}