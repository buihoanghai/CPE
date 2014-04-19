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
    public partial class Customer_Managent : DevExpress.XtraEditors.XtraForm
    {
        ICustomersDAL _DALCustomer = new CustomersDAL();
        Models.Customer _customerCur = new Models.Customer();
        public Customer_Managent()
        {
            InitializeComponent();
        }
        void setEnableLisence(bool passport, bool driving, bool IDLisence)
        {
            DateExpiredDate.Enabled=passport;
            txtPassport.Enabled = passport;
            txtDrivingLisence.Enabled = driving;
            txtIDLisence.Enabled = IDLisence;
        }
        bool CheckValidate()
        {
            bool flag=true;
            if (txtPassport.Text == "" && txtDrivingLisence.Text == "" && txtIDLisence.Text == "")
            {
                MessageBox.Show("Invalid Passport or Driving Lisence or ID Lisence!");
                return false;
            }
            if (txtPassport.Text != "" && (DateExpiredDate.DateTime.Date <= DateTime.Now.Date))
            {
                MessageBox.Show("Invalid Expire date!");
                return false;
            }
            if ((DateTime.Now.Year - dateEditDOB.DateTime.Year) < 18)
            {
                MessageBox.Show("Invalid DOB!");
                return false;
            }
            return flag;
        }
        void setCustomerToForm()
        {
            if (!string.IsNullOrEmpty(_customerCur.DrivingLisence))
                txtDrivingLisence.Text = _customerCur.DrivingLisence;
            if (!string.IsNullOrEmpty(_customerCur.IDLisence))
                txtIDLisence.Text = _customerCur.IDLisence;
            if (!string.IsNullOrEmpty(_customerCur.Passport))
            {
                txtPassport.Text = _customerCur.Passport;
                DateExpiredDate.EditValue = _customerCur.Expiry_date;
            }
            txtCustomerName.Text = _customerCur.Name;
            dateEditDOB.EditValue = _customerCur.DOB;
            txtAddress.Text = _customerCur.Address;
            txtNationality.Text = _customerCur.Nationality;
            txtPhone.Text = _customerCur.Phone;
            txtEmail.Text = _customerCur.Email;
        }
        void getCustomerFromForm()
        {
            if (!string.IsNullOrEmpty(txtDrivingLisence.Text))
            {
                _customerCur.DrivingLisence = txtDrivingLisence.Text;
                _customerCur.IDLisence = null;
                _customerCur.Passport = null;
                _customerCur.Expiry_date = null;
            }
            if (!string.IsNullOrEmpty(txtIDLisence.Text))
            {
                _customerCur.IDLisence = txtIDLisence.Text;
                _customerCur.DrivingLisence = null;
                _customerCur.Passport = null;
                _customerCur.Expiry_date = null;
            }
            if (!string.IsNullOrEmpty(txtPassport.Text))
            {
                _customerCur.Passport = txtPassport.Text;
                _customerCur.Expiry_date = DateExpiredDate.DateTime;
                _customerCur.DrivingLisence = null;
                _customerCur.IDLisence = null;
            }
            _customerCur.Name = txtCustomerName.Text;
            _customerCur.DOB = dateEditDOB.DateTime;
            _customerCur.Address = txtAddress.Text;
            _customerCur.Nationality = txtNationality.Text;
            _customerCur.Phone = txtPhone.Text;
            _customerCur.Email = txtEmail.Text;
        }
        void ClearControl()
        {
            _customerCur = new Models.Customer();
            txtDrivingLisence.Text = "";
            txtIDLisence.Text = "";
            txtPassport.Text = "";
            DateExpiredDate.EditValue = null;
            txtCustomerName.Text = "";
            dateEditDOB.EditValue = null;
            txtAddress.Text = "";
            txtNationality.Text = "";
            txtPhone.Text = "";

        }
        void getListCustomer()
        {
            GridCustomer.DataSource = _DALCustomer.SelectAll();
        }
        private void FormLoad()
        {
            getListCustomer();
        }
        void UpdateCustomer()
        {
            _customerCur = (Models.Customer)gridViewCustomer.GetFocusedRow();
            _customerCur = _DALCustomer.SelectByID(_customerCur.ID);
            _customerCur.Modified = DateTime.Now.Date;
            _customerCur.Modified_By = SessionCur.staff.ID;
            getCustomerFromForm();
            _DALCustomer.Update(_customerCur);
        }
        void InsertCustomer()
        {
            getCustomerFromForm();
            _customerCur.Created = DateTime.Now.Date;
            _customerCur.Created_By = SessionCur.staff.ID;
            _DALCustomer.Insert(_customerCur);
        }
        void DeleteCustomer()
        {
            _customerCur = (Models.Customer)gridViewCustomer.GetFocusedRow();
            _DALCustomer.DeleteByID(_customerCur.ID);
        }
        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtPassport_EditValueChanged(object sender, EventArgs e)
        {
            if (txtPassport.Text != "")
                setEnableLisence(true, false, false);
            else
                setEnableLisence(true, true, true);
        }

        private void txtDrivingLisence_EditValueChanged(object sender, EventArgs e)
        {
            if (txtDrivingLisence.Text != "")
            {
                setEnableLisence(false, true, false);
                DateExpiredDate.EditValue = null;
            }
            else
                setEnableLisence(true, true, true);
        }

        private void txtIDLisence_EditValueChanged(object sender, EventArgs e)
        {
            if (txtIDLisence.Text != "")
            {
                setEnableLisence(false, false, true);
                DateExpiredDate.EditValue = null;
            }
            else
                setEnableLisence(true, true, true);
        }

        private void butSave_Click(object sender, EventArgs e)
        {
            if (valid.Validate())
            {
                if (!CheckValidate()) return;
                if (_customerCur.ID != 0 && _customerCur != null)
                {
                    UpdateCustomer();
                }
                else
                {
                    InsertCustomer();
                }
                ClearControl();
                getListCustomer();
            }
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            ClearControl();
        }

        private void Customer_Managent_Load(object sender, EventArgs e)
        {
            FormLoad();
        }

        private void butDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to delete!", "Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DeleteCustomer();
                ClearControl();
                getListCustomer();
            }
        }

        private void gridViewCustomer_DoubleClick(object sender, EventArgs e)
        {
            _customerCur = (Models.Customer)gridViewCustomer.GetFocusedRow();
            setCustomerToForm();
        }

        private void txtPassport_MouseDown(object sender, MouseEventArgs e)
        {
            common.openOnScreenKeyboard();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            common.killOnScreenKeyboard();
        }

    }
}