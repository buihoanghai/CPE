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

namespace CPE_vs1.Report
{
    public partial class ReportCPE : DevExpress.XtraEditors.XtraForm
    {
        Dictionary<int, string> status = new Dictionary<int, string>() { { 1, "Available" }, { 2, "Deleted" }, { 3, "Damaged" }, { 4, "Lost" }, { 5, "On-loan" }, { 6, "LoanMore" } };
        ICPEsDAL _cpeDAL = new CPEsDAL();
        ISitesDAL _siteDAL = new SitesDAL();

        void formLoad()
        {
            LKStatusIngridDataBase.DataSource = status;
            LKSiteSearch.Properties.DataSource= LKSiteIngrid.DataSource = _siteDAL.SelectAll();
            GetAllCPE();
        }
        void GetCPEBySite()
        {
            gridControlDataBase.DataSource = _cpeDAL.ListBySiteID((int)LKSiteSearch.EditValue);
        }
        private void GetAllCPE()
        {
            gridControlDataBase.DataSource = _cpeDAL.SelectAll();
        }
        public ReportCPE()
        {
            InitializeComponent();
        }

        private void ReportCPE_Load(object sender, EventArgs e)
        {
            formLoad();
        }

        private void LKSiteSearch_EditValueChanged(object sender, EventArgs e)
        {
            GetCPEBySite();
        }

        private void butPrint_Click(object sender, EventArgs e)
        {
            gridControlDataBase.ShowRibbonPrintPreview();
        }

        private void butAll_Click(object sender, EventArgs e)
        {
            GetAllCPE();
        }
    }
}