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
using DAL.Implement;

namespace CPE_vs1.Forms
{
    public partial class SiteManager : DevExpress.XtraEditors.XtraForm
    {
        #region variable
        ISitesDAL _DALSite = new SitesDAL();
        IPublicDAL _DALpublic = new PublicDAL();
        Models.Site _siteCur = new Models.Site();
        Models.SiteCPEStaff _siteCPEStaffCur = new Models.SiteCPEStaff();
        List<Models.SiteCPEStaff> _listSiteCPE = new List<Models.SiteCPEStaff>();
        List<Models.SiteCPEStaff> _listSiteStaff = new List<Models.SiteCPEStaff>();
        #endregion

        #region method
        private void _formLoad()
        {
            _bindDataToGrid();
        }

        void _bindDataToGrid()
        {
            _listSiteCPE = _DALpublic.GetAllSiteCpe();
            _listSiteStaff = _DALpublic.GetAllSiteStaff();
            foreach (var item in _listSiteCPE)
            {
                foreach (var item1 in _listSiteStaff)
                {
                    if(item.ID==item1.ID)
                    {
                        item.StaffQuantity = item1.StaffQuantity;
                        break;
                    }
                }
            }
            gridControlDatabase.DataSource = _listSiteCPE;
        }

        void _getSiteFromControl()
        {
            _siteCur.Name = textName.Text;
        }

        void _setSiteTocontrol()
        {
            textName.Text = _siteCur.Name;
        }
        void _clearControl()
        {
            _siteCur = new Models.Site();
            textName.Text = "";
        }
        void _insertSite()
        {
            _siteCur.Created = DateTime.Now;
            _siteCur.Created_By = SessionCur.staff.ID;
            _DALSite.Insert(_siteCur);
        }
        void _getSiteFromDatabase()
        {
            _siteCur = _DALSite.SelectByID(_siteCur.ID);
        }
        void _updateSite()
        {
            _siteCur.Modified = DateTime.Now;
            _siteCur.Modified_By = SessionCur.staff.ID;
            _DALSite.Update(_siteCur);
        }
        void _insertAction()
        {
            _getSiteFromControl();
            _insertSite();
            _clearControl();
        }
        void _updateAction()
        {
            _getSiteFromControl();
            _updateSite();
            _clearControl();
        }
        void _save()
        {
            if (_siteCur.ID == 0)
            {
                _insertAction();
            }
            else
            {
                _updateAction();
            }
            _bindDataToGrid();
        }
        void _SiteCPEStaffToSite()
        {
            _siteCur.ID = _siteCPEStaffCur.ID;
            _siteCur.Name = _siteCPEStaffCur.SiteName;

        }
        void _getSiteFromGrid()
        {
            _siteCPEStaffCur = (Models.SiteCPEStaff)gridViewDatabase.GetFocusedRow();
            _SiteCPEStaffToSite();
        }
        private void _deleteAction()
        {
            _getSiteFromGrid();
            if(_siteCPEStaffCur.StaffQuantity!=0 || _siteCPEStaffCur.CPEQuantity!=0)
            {
                MessageBox.Show("Can not delete! Already exist CPE or Staff in Site");
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Do you want delete it?", "Warn!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (!_DALSite.CheckHaveSite(_siteCur.ID))
                {
                    _DALSite.DeleteByID(_siteCur.ID);
                }
                else
                {
                    MessageBox.Show("Can not delete it! Because Site already exist anywhere!");
                }
            }
            _clearControl();
            _bindDataToGrid();
        }
        #endregion

        public SiteManager()
        {
            InitializeComponent();
        }


        private void SiteManager_Load(object sender, EventArgs e)
        {
            
            _formLoad();
        }

        private void butSave_Click(object sender, EventArgs e)
        {
            _save();
        }

        private void gridControlDatabase_DoubleClick(object sender, EventArgs e)
        {
            _getSiteFromGrid();
            _setSiteTocontrol();
        }

        private void butcancel_Click(object sender, EventArgs e)
        {
            _clearControl();
        }

        private void butDelete_Click(object sender, EventArgs e)
        {
            _deleteAction();
        }

        
    }
}