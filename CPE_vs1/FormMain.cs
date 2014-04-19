using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using DevExpress.XtraBars.Helpers;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using System.Linq;
using CPE_vs1.Report;
using CPE_vs1.Forms;
using DAL.Implement.CPE_vs1DAL;

namespace CPE_vs1
{
    public partial class FormMain : RibbonForm
    {
        #region Variable
        private FullScreen _FullScreen;
        CPECatalogueInventorize fCPECatalogueInventorize = new CPECatalogueInventorize();
        CPELoan fCPELoan = new CPELoan();
        CPEReturn fCPEReturn = new CPEReturn();
        LocationDetail fLocationDetail = new LocationDetail();
        LocationManagement fLocationManagement = new LocationManagement();
        PackageManagement fPackage = new PackageManagement();
        SiteManager fSiteManagement = new SiteManager();
        StaffManagement fstaffManagement = new StaffManagement();
        PenaltyManagement fPenaltyManagement = new PenaltyManagement();
        Transfer ftransfer = new Transfer();
        Promotion fPromotion = new Promotion();
        Agent fAgent = new Agent();
        CPELoanOnline fOnline = new CPELoanOnline();
        Customer_Managent fcustomer = new Customer_Managent();
        ReportCPE freportCPE = new ReportCPE();
        bool flag = false;
        #endregion

        #region method
        public FormMain()
        {
            InitializeComponent();
            InitSkinGallery();
            dispose(fCPECatalogueInventorize);
            dispose(fCPELoan);
            dispose(fCPEReturn);
            dispose(fLocationDetail);
            dispose(fLocationManagement);
            dispose(fSiteManagement);
            dispose(fstaffManagement);
            dispose(fPackage);
            dispose(ftransfer);
            dispose(fPromotion);
            dispose(fAgent);
            dispose(fOnline);
            dispose(fcustomer);
            dispose(freportCPE);
        }

        public void ActiveFormNew(System.Windows.Forms.Form str)
        {

            foreach (System.Windows.Forms.Form frm in MdiChildren)
            {
                if (frm.Name == str.Name)
                {
                    frm.Activate();
                    return;
                }
            }
            str.MdiParent = this;
            str.Show();
        }

        private void CheckAuthor()
        {
            butReport.Visibility = BarItemVisibility.Never;
            butAdmin.Visibility = BarItemVisibility.Never;
            if (SessionCur.staff.AccountType == 2)
            {
                butReport.Visibility = BarItemVisibility.Always;
                butAdmin.Visibility = BarItemVisibility.Always;
            }
            else
            {
                butReport.Visibility = BarItemVisibility.Never;
                butAdmin.Visibility = BarItemVisibility.Never;
            }
        }

        private void LogIn()
        {
            //SessionCur.staff = null;
            //SessionCur.site = null;
            ITrackLogsDAL _DALTracklog = new TrackLogsDAL();
            _DALTracklog.Insert(new Models.TrackLog() { Action = "Logout staff:" + SessionCur.staff.ID, Type = "Logout", TimeAction = DateTime.Now, Staff_ID = SessionCur.staff.ID });
            butReport.Visibility = BarItemVisibility.Never;
            butAdmin.Visibility = BarItemVisibility.Never;
            UserSession.ResetTimer();
            Login login= new Login();
            login.ShowDialog();
            CheckAuthor();
            RefreshLogin(login);
        }
        private void CheckShowFullScreen()
        {
            //this.TopMost = true;
            if (!flag)
            {
                _FullScreen.ShowFullScreen(false);
                flag = true;
            }
        }
        private void RefreshLogin(Login log)
        {
            if (log.newuser == true)
            {
                foreach (System.Windows.Forms.Form frm in MdiChildren)
                {
                    frm.Close();
                }
                CheckAuthor();
            }
        }
        private void LoadForm()
        {
            UserSession.BeginTimer();
            timer1.Start();
            _FullScreen = new FullScreen(this);
            _FullScreen.ShowFullScreen(false);
            using (var db = new Models.DBContextCPEDB()) { var sta = from s in db.Staffs where 1 == 0 select s; sta.ToList(); }
            LogIn();
        }
        #endregion

        #region Event

        private static void dispose(XtraForm form)
        {
            if (form != null)
            {
                form.Dispose();
                form = null;
            }
        }

        void InitSkinGallery()
        {
            SkinHelper.InitSkinGallery(rgbiSkins, true);
        }

        private void butCPECatalogueInventorize_ItemClick(object sender, ItemClickEventArgs e)
        {
            ActiveFormNew(fCPECatalogueInventorize);
        }

        private void butCPELoan_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (fCPELoan.IsDisposed == true)
                fCPELoan = new CPELoan();
            ActiveFormNew(fCPELoan);
            CheckShowFullScreen();
        }

        

        private void butCPEreturn_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (fCPEReturn.IsDisposed == true)
                fCPEReturn = new CPEReturn();
            ActiveFormNew(fCPEReturn);
            CheckShowFullScreen();
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (fSiteManagement.IsDisposed == true)
                fSiteManagement = new SiteManager();
            ActiveFormNew(fSiteManagement);
            CheckShowFullScreen();
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (fLocationManagement.IsDisposed == true)
                fLocationManagement = new LocationManagement();
            ActiveFormNew(fLocationManagement);
            CheckShowFullScreen();
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (fPackage.IsDisposed == true)
                fPackage = new PackageManagement();
            ActiveFormNew(fPackage);
            CheckShowFullScreen();
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (fCPECatalogueInventorize.IsDisposed == true)
                fCPECatalogueInventorize = new CPECatalogueInventorize();
            ActiveFormNew(fCPECatalogueInventorize);
            CheckShowFullScreen();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        

        private void butStaffManagement_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (fstaffManagement.IsDisposed == true)
            fstaffManagement = new StaffManagement();
            ActiveFormNew(fstaffManagement);
            CheckShowFullScreen();
        }

        private void iExit_ItemClick(object sender, ItemClickEventArgs e)
        {

            if (MessageBox.Show("Are you sure want to exit?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SessionCur.staff.Logout();
                this.Close();
            }
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            //ReportViewer.CPEInventory report = new ReportViewer.CPEInventory();
            //ReportPrintTool pt = new ReportPrintTool(report);
            //pt.ShowRibbonPreviewDialog();
            //PrintBarcode report = new PrintBarcode();
            //ReportPrintTool pt = new ReportPrintTool(report);
            //pt.ShowRibbonPreviewDialog();
            if (freportCPE.IsDisposed == true)
                freportCPE = new ReportCPE();
            ActiveFormNew(freportCPE);
            CheckShowFullScreen();
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
        }

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            ChangePass cp = new ChangePass();
            cp.ShowDialog();
        }

        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (fPenaltyManagement.IsDisposed == true)
                fPenaltyManagement = new PenaltyManagement();
            ActiveFormNew(fPenaltyManagement);
            CheckShowFullScreen();
        }

        private void FormMain_FormClosing1(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure want to exit?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Taskbar.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (!UserSession.SessionAlive)
                {
                    timer1.Stop();
                    Login log = new Login();
                    log.ShowDialog();
                    timer1.Start();
                    RefreshLogin(log);
                }
            }
            catch { }
        }

        

        private void FormMain_Click(object sender, EventArgs e)
        {
            ResetSession();
        }

        private void xtraTabbedMdiManager1_SelectedPageChanged(object sender, EventArgs e)
        {
            ResetSession();
        }

        private static void ResetSession()
        {
            UserSession.ResetTimer();
        }
        private void buttransferWarehouse_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (ftransfer.IsDisposed == true)
                ftransfer = new Transfer();
            ActiveFormNew(ftransfer);
            CheckShowFullScreen();
        }

        private void butlogout_ItemClick(object sender, ItemClickEventArgs e)
        {
            LogIn();
        }

        private void butPromotion_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (fPromotion.IsDisposed == true)
                fPromotion = new Promotion();
            ActiveFormNew(fPromotion);
            CheckShowFullScreen();
        }

        private void butAgent_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (fAgent.IsDisposed == true)
                fAgent = new Agent();
            ActiveFormNew(fAgent);
            CheckShowFullScreen();
        }

        #endregion

        private void butOnline_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (fOnline.IsDisposed == true)
                fOnline = new CPELoanOnline();
            ActiveFormNew(fOnline);
            CheckShowFullScreen();
        }

        private void butCustomer_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (fcustomer.IsDisposed == true)
                fcustomer = new Customer_Managent();
            ActiveFormNew(fcustomer);
            CheckShowFullScreen();
        }
    }
}