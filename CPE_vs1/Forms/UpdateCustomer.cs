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
    public partial class UpdateCustomer : DevExpress.XtraEditors.XtraForm
    {
        public Models.Customer _customerCur;
        ICustomersDAL _DALcustomer = new CustomersDAL();
        public UpdateCustomer()
        {
            InitializeComponent();
        }
        void getCustomerFromForm()
        {
            _customerCur = _DALcustomer.SelectByID(_customerCur.ID);
            _customerCur.Phone = txtPhone.Text;
            _customerCur.Nationality = txtNationality.Text;
            _customerCur.Name = txtCustomerName.Text;
            _customerCur.DOB = dateEditDOB.DateTime.Date;
            _customerCur.Email = txtEmail.Text;
            if (_customerCur.DrivingLisence != "")
            {
                lblpassport.Text = "D. Lisence";
                _customerCur.DrivingLisence = txtPassport.Text;
            }
            if (_customerCur.IDLisence != "")
            {
                lblpassport.Text = "ID Lisence";
                _customerCur.IDLisence = txtPassport.Text;
            }
            if (_customerCur.Passport != "")
            {
                lblpassport.Text = "Passport number";
                _customerCur.Passport = txtPassport.Text;
                _customerCur.Expiry_date = DateExpiredDate.DateTime.Date;
            }
        }
        void setCustomerToForm()
        {
            txtEmail.Text = _customerCur.Email;
            txtPhone.Text = _customerCur.Phone;
            txtNationality.Text = _customerCur.Nationality;
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
                DateExpiredDate.Enabled = true;
            }
        }
        void saveCustomer()
        {
            if (_DALcustomer.Update(_customerCur))
                MessageBox.Show("Update Complete!");
            else
                MessageBox.Show("Update not Complete!");
        }
        private void butcancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void UpdateCustomer_Load(object sender, EventArgs e)
        {
            setCustomerToForm();
        }

        private void butok_Click(object sender, EventArgs e)
        {
            try
            {
                if ((DateTime.Now.Year - dateEditDOB.DateTime.Year) < 18)
                {
                    MessageBox.Show("Invalid DOB!");
                    dateEditDOB.EditValue = null;
                    return;
                }
                if (_customerCur.Passport != "" && _customerCur.Passport != null)
                {

                    if (DateTime.Now.Date >= DateExpiredDate.DateTime.Date)
                    {
                        MessageBox.Show("Invalid Expire day!");
                        DateExpiredDate.EditValue = null;
                        return;
                    }
                }
                getCustomerFromForm();
                saveCustomer();
            }
            catch { }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}