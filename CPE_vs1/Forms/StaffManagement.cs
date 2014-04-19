using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using DAL.Implement.CPE_vs1DAL;
namespace CPE_vs1
{
    public partial class StaffManagement : DevExpress.XtraEditors.XtraForm
    {
        IStaffsDAL _DALStaff = new StaffsDAL();
        ISitesDAL _DALSite = new SitesDAL();

        BusinessLayer.Staff _staffCur = new BusinessLayer.Staff();
        BusinessLayer.Site _siteCur = new BusinessLayer.Site();
        public StaffManagement()
        {
            InitializeComponent();
        }
        Dictionary<int, string> accountTypes = new Dictionary<int, string>() { { 1, "Receptionist" }, { 2, "Site Admin" } };
        private void StaffManagement_Load(object sender, EventArgs e)
        {
            FormLoad();

        }
        private void FormLoad()
        {
            
            //GCStaff.DataSource = sta.GetListInforNotAdmin();
            DataTable tbsite = _siteCur.GetListInfor();
            try
            {
                cmbSite.Properties.DataSource = tbsite;
                lkEditSite.DataSource = tbsite;
            }
            catch { }
            lkAccountType.DataSource = accountTypes;
            cmbAccountType.Properties.DataSource = accountTypes;
            cmbSex.SelectedIndex = 0;
            dateDOB.DateTime = DateTime.Now;
        }
       private void getAllList()
        {
            GCStaff.DataSource = _DALStaff.SelectAll();
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (valid.Validate())
            {

                Models.Staff staff = new Models.Staff();
                if (_DALStaff.CheckStaffByUsername(txtAccount.Text) == true)
                {
                    MessageBox.Show("UserName Alrealdy Exist!");
                    return;
                }
                
                if (ID != 0)
                    staff = _DALStaff.SelectByID(ID);

                GetStaffFromForm(staff);
                if (ID == 0)
                    _DALStaff.Insert(staff);
                else
                    _DALStaff.Update(staff);
                getAllList();
                ClearControl();
            }
        }

        private void GetStaffFromForm(Models.Staff staff)
        {
            staff.Account = txtAccount.Text;
            staff.AccountType = (int)cmbAccountType.EditValue;
            staff.Address = memoAddress.Text;
            if (ID == 0)
            {
                staff.Created = DateTime.Now;
                staff.Created_By = 1;
            }
            staff.DOB = Convert.ToDateTime(dateDOB.EditValue);
            staff.Name = txtName.Text;
            staff.Password = txtPassword.Text;
            staff.Phone = txtPhone.Text;
            staff.Sex = (byte)(cmbSex.Text == "Male" ? 1 : 0);
            staff.Site_ID = (int)cmbSite.EditValue;
            staff.HomePhone = txthomePhone.Text;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            ClearControl();
        }

        private void ClearControl()
        {
            txtAccount.Text = "";
            txtName.Text = "";
            txtPassword.Text = "";
            txtPhone.Text = "";
            memoAddress.Text = "";
            cmbAccountType.EditValue = null;
            cmbSex.SelectedIndex = 0;
            cmbSite.EditValue = null;
            dateDOB.DateTime = DateTime.Now;
            ID = 0;
            txthomePhone.Text = "";
            txtretype.Text = "";

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Models.Staff staff = (Models.Staff)GVStaff.GetRow(GVStaff.FocusedRowHandle);
            if (staff.ID == 1)
            {
                MessageBox.Show("Can not delete main Admin");
                return;
            }
            if (MessageBox.Show("Are you sure want to delete?", "Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
                _DALStaff.DeleteByID(staff.ID);
                getAllList();
                ClearControl();
            }
        }
        int ID = 0;
        private void GCSatff_DoubleClick(object sender, EventArgs e)
        {
            SetStaffToForm();
        }

        private void SetStaffToForm()
        {
            Models.Staff staff = (Models.Staff)GVStaff.GetRow(GVStaff.FocusedRowHandle);
            if (staff.ID == 1 && SessionCur.staff.ID != 1)
            {
                MessageBox.Show("You can not Edit main Admin");
                return;
            }
            txtAccount.Text = staff.Account;
            cmbAccountType.EditValue = staff.AccountType;
            memoAddress.Text = staff.Address;
            dateDOB.EditValue = staff.DOB;
            txtName.Text = staff.Name;
            txtPassword.Text = staff.Password;
            txtPhone.Text = staff.Phone;
            cmbSex.Text = (staff.Sex == 1 ? "Male" : "FeMale");
            cmbSite.EditValue = staff.Site_ID;
            txthomePhone.Text = staff.HomePhone;
            ID = staff.ID;
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtName_MouseDown(object sender, MouseEventArgs e)
        {
            common.openOnScreenKeyboard();
        }

        private void StaffManagement_Click(object sender, EventArgs e)
        {
            common.killOnScreenKeyboard();
            UserSession.ResetTimer();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            common.killOnScreenKeyboard();
            UserSession.ResetTimer();
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.Properties.UseSystemPasswordChar = !checkEdit1.Checked;
            txtretype.Properties.UseSystemPasswordChar = !checkEdit1.Checked;
        }

    }
    //public class AccountType
    //{
    //    public int ID { get; set; }
    //    public string Type { get; set; }
    //}
}
