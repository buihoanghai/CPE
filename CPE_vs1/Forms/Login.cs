using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using CPE_vs1.BusinessLayer;
using CPE_vs1.Forms;
using DAL.Implement.CPE_vs1DAL;

namespace CPE_vs1
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        public Login()
        {
            InitializeComponent();
        }
        private DataAccessLayer.DataConfig dtConfig = new DataAccessLayer.DataConfig(); 
        Staff staff=new Staff();
        Site site=new Site();
        public bool newuser;
        private void button1_Click(object sender, EventArgs e)
        {
            staff=(Staff)staff.Login(txtAccount.Text,txtPassword.Text);
            if(staff.ID!=0)
            {
                site=(Site) site.GetInfor(staff.Site_ID);
                if(site.ID!=0)
                {
                    try {
                        if (SessionCur.staff.ID != staff.ID)
                            newuser = true;
                        else
                        {
                            newuser = false;
                        }
                    }
                    catch { }
                    SessionCur.site=site;
                    SessionCur.staff=staff;
                    ITrackLogsDAL _DALTracklog = new TrackLogsDAL();
                    _DALTracklog.Insert(new Models.TrackLog() { Action = "Login staff:" + staff.ID,Type="Login", TimeAction=DateTime.Now,Staff_ID=SessionCur.staff.ID });
                    //dtConfig.InsertTrackLog("Login staff:" + staff.ID, "Login");
                    //FormMain main = new FormMain();
                    common.killOnScreenKeyboard();
                    //main.ShowDialog();
                    //Application.Exit();
                    UserSession.ResetTimer();
                    this.Close();
                }
                
            }
            else
                MessageBox.Show("Account or password incorrect!");

        }

        private void Login_Click(object sender, EventArgs e)
        {
            common.killOnScreenKeyboard();
        }

        private void txtAccount_MouseDown(object sender, MouseEventArgs e)
        {
            common.openOnScreenKeyboard();
        }

        private void butCancel_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to exit?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                common.killOnScreenKeyboard();
                Application.Exit();
            }
        }
    }
}