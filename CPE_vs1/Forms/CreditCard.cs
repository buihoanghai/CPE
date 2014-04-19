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

namespace CPE_vs1.Forms
{
    public partial class CreditCard : DevExpress.XtraEditors.XtraForm
    {
        public CreditCard()
        {
            InitializeComponent();
        }
        public Models.Loan _loanCur = new Models.Loan();
        ILoansDAL _DALLoan = new LoansDAL();
        private void butClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void SaveCreditCard()
        {
            _loanCur = _DALLoan.SelectByID(_loanCur.ID);
            _loanCur.CreditCardNumer = txtCreditCardNumber.Text;
            _loanCur.ExpiredateCreditCard = dateExpiredDate.DateTime.Date;
            if (_DALLoan.Update(_loanCur))
                MessageBox.Show("Save Complete!");
            else
                MessageBox.Show("Error!");
        }
        private void butOK_Click(object sender, EventArgs e)
        {
            SaveCreditCard();
        }
    }
}