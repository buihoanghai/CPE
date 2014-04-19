using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using CPE_vs1.BusinessLayer;

namespace CPE_vs1
{
    public partial class ChangePass : DevExpress.XtraEditors.XtraForm
    {
        public ChangePass()
        {
            InitializeComponent();
        }
        Staff staff = new Staff();
        private DataAccessLayer.DataConfig dtConfig = new DataAccessLayer.DataConfig(); 
        private void Login_Load(object sender, EventArgs e)
        {
            txtAccount.Text = SessionCur.staff.Account;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            staff = (Staff)staff.Login(txtAccount.Text, txtOldPass.Text);
            if (staff.ID != 0)
            {
                if (txtNewPass1.Text == txtNewPass2.Text && txtNewPass2.Text.Length > 5)
                {
                    staff.ChangePass(txtNewPass2.Text);
                    MessageBox.Show("Change Pass is successful!");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Password is incorrect!");
            }
            common.killOnScreenKeyboard();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            common.killOnScreenKeyboard();
            this.Close();
        }

        private void ChangePass_Click(object sender, EventArgs e)
        {
            common.killOnScreenKeyboard();
            UserSession.ResetTimer();
        }

        private void txtOldPass_MouseDown(object sender, MouseEventArgs e)
        {
            common.openOnScreenKeyboard();
        }
    }
}