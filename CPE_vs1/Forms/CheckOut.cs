using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using CPE_vs1.BusinessLayer;
using DAL.Implement.CPE_vs1DAL;
using System.IO;
using DevExpress.XtraReports.UI;


namespace CPE_vs1
{
    public partial class Transfer : DevExpress.XtraEditors.XtraForm
    {
        #region variable
        string TransferCode;
        ISitesDAL siteDAL = new SitesDAL();
        ICPEsDAL cpeDAL = new CPEsDAL();
        Dictionary<int, string> status = new Dictionary<int, string>() { { 1, "Available" }, { 2, "Deleted" }, { 3, "Faulty" }, { 4, "Lost" }, { 5, "Rented" }, { 6, "LoanMore" } };
        
        List<Models.Site> listSiteAll = new List<Models.Site>();
        List<Models.Site> listSiteTransfer = new List<Models.Site>();
        List<Models.CPE> listCheckOut = new List<Models.CPE>();
        List<Models.CPE> _listCheckIn = new List<Models.CPE>();
        Models.Site _site = new Models.Site();
        Models.CPE _cpeCur = new Models.CPE();
        #endregion

        #region method
        public Transfer()
        {
            InitializeComponent();
        }

        private void bindDataOfThisSiteToGrid()
        {
            gridControlDataBase.DataSource = cpeDAL.ListByCPENormalAndSiteID(SessionCur.site.ID);
        }

        private void BindDataToGrid()
        {
            gridControlDataBase.DataSource = cpeDAL.ListBySiteID((int)LKSiteSearch.EditValue);
        }

        void CheckOut()
        {
            try
            {

                string path = Path.GetRandomFileName();
                path = path.Replace(".", "").ToUpper();
                int[] numrow = gridViewDatabase.GetSelectedRows();
                for (int i = 0; i < numrow.Length; i++)
                {
                    Models.CPE cpe = (Models.CPE)gridViewDatabase.GetRow(numrow[i]);
                    listCheckOut.Add(cpe);
                    cpe.ToSite = (int)LKSiteTransfer.EditValue;
                    TransferCode = cpe.CodeTransfer = path;
                    cpe.FromSite = SessionCur.site.ID;
                    cpe.CheckOutDate = DateTime.Now.Date;
                    cpe.Site_ID = null;
                    cpeDAL.Update(cpe);
                }
                bindDataOfThisSiteToGrid();
            }
            catch { }
        }

        void Print()
        {

            Forms.CheckOutRept report = new Forms.CheckOutRept();
            report.DataSource = listCheckOut;
            report.lblTranserCode.Text = TransferCode;
            _site = siteDAL.SelectByID(SessionCur.site.ID);
            report.lblFromsite.Text = _site.Name;
            _site = siteDAL.SelectByID((int)LKSiteTransfer.EditValue);
            report.lbltoSite.Text = _site.Name;
            report.cellbarcode.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Barcode")});
            ReportPrintTool pt = new ReportPrintTool(report);
            pt.ShowRibbonPreviewDialog();
        }

        private void GetAllCPETransferByTransferCode()
        {
            _listCheckIn = cpeDAL.ListCPEbyCodeTransferOfToSite(txtTransferCode.Text, SessionCur.site.ID);
        }

        private void BindDataToGridCheckIn()
        {
            gridControlCheckIn.DataSource = _listCheckIn;
        }

        private void SelectedAllCPEInGridCheckIn()
        {
            gridViewCheckIN.SelectRows(0, gridViewCheckIN.RowCount - 1);
        }

        private void ScanCPE()
        {
            if (txtCPEbarcode.Text.Length == 13)
            {
                GetCPEByTransferToThisSite();
                CheckCPEInGridCheckIn();
            }
            txtCPEbarcode.Text = "";
            txtCPEbarcode.Focus();
        }

        private void CheckCPEInGridCheckIn()
        {
            if (_cpeCur != null)
            {
                for (int i = 0; i < gridViewCheckIN.RowCount; i++)
                {
                    Models.CPE cpe = (Models.CPE)gridViewCheckIN.GetRow(i);
                    if (cpe.Barcode.Trim() == _cpeCur.Barcode.Trim())
                        gridViewCheckIN.SelectRow(i);
                }
            }
        }

        private void GetCPEByTransferToThisSite()
        {
            try
            {
                _cpeCur = cpeDAL.GetCPEByTransferToThisSite(txtCPEbarcode.Text, SessionCur.site.ID, txtTransferCode.Text);
            }
            catch { _cpeCur = null; }
        }

        private void SaveCPEsCheckedInGridCheckIn()
        {
            int[] numrow = gridViewCheckIN.GetSelectedRows();
            for (int i = 0; i < numrow.Length; i++)
            {
                Models.CPE cpe = (Models.CPE)gridViewCheckIN.GetRow(numrow[i]);
                cpe.Site_ID = cpe.ToSite;
                cpe.CodeTransfer = null;
                cpe.CheckInDate = DateTime.Now;
                cpeDAL.Update(cpe);
            }
            MessageBox.Show("Save complete!");
            _listCheckIn = null;
            BindDataToGridCheckIn();
        }
        #endregion

        private void LKSiteSearch_EditValueChanged(object sender, EventArgs e)
        {
            BindDataToGrid();
        }

        private void Transfer_Load(object sender, EventArgs e)
        {
            listSiteTransfer = siteDAL.SelectAllExcludeThisSite(SessionCur.site.ID);
            listSiteAll = siteDAL.SelectAll();
            LKSiteIngrid.DataSource = listSiteAll;
            LKStatusIngridDataBase.DataSource = status;
            LKSiteSearch.Properties.DataSource = listSiteAll;
            LKSiteTransfer.Properties.DataSource = listSiteTransfer;
            LKStatusInGridCheckIn.DataSource = status;
            LKSiteInGridCheckIn.DataSource = listSiteAll;
            bindDataOfThisSiteToGrid();
            if (SessionCur.staff.AccountType == 2)
                LKSiteSearch.Visible = true;
            else
                LKSiteSearch.Visible = false;
        }

        private void butOk_Click(object sender, EventArgs e)
        {
            
            CheckOut();
            Print();
        }

        private void gridViewDatabase_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            if (gridViewDatabase.GetSelectedRows().Length > 0)
            {
                LKSiteTransfer.Enabled = true;
                butOk.Enabled = true;
            }
            else
            {
                LKSiteTransfer.Enabled = false;
                butOk.Enabled = false;
            }
        }
        
        private void butOk1_Click(object sender, EventArgs e)
        {
            _listCheckIn = new List<Models.CPE>();
            GetAllCPETransferByTransferCode();
            BindDataToGridCheckIn();
        }

        private void CheckGettype_CheckedChanged(object sender, EventArgs e)
        {
            butcheckInAll.Enabled = CheckGettype.Checked;
            txtCPEbarcode.Enabled = !CheckGettype.Checked;
        }

        private void butcheckInAll_Click(object sender, EventArgs e)
        {
            SelectedAllCPEInGridCheckIn();
        }
       
        private void txtCPEbarcode_EditValueChanged(object sender, EventArgs e)
        {
            ScanCPE();
        }

        private void butSave_Click(object sender, EventArgs e)
        {
            SaveCPEsCheckedInGridCheckIn();
        }

        private void txtTransferCode_MouseDown(object sender, MouseEventArgs e)
        {
            common.openOnScreenKeyboard();
        }

        private void xtraTabPage2_Click(object sender, EventArgs e)
        {
            common.killOnScreenKeyboard();
        }
    }
}