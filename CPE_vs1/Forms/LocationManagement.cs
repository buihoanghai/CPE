using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using CPE_vs1.Interface;
using CPE_vs1.BusinessLayer;

namespace CPE_vs1
{
    public partial class LocationManagement : DevExpress.XtraEditors.XtraForm
    {
        public LocationManagement()
        {
            InitializeComponent();
            SetGridAlgorithm(new DevGridAlgorithm());
        }
        #region Set các interface
        void SetGridAlgorithm(IGridAlgorithm IGrid)
        {
            this.IGrid = IGrid;
        }
        #endregion
        #region Khai báo biến
        IGridAlgorithm IGrid;
        public Site siteCur = new Site();
        Location locationCur = new Location();
        Dictionary<string, Type> Table = new Dictionary<string, Type>() {
               {"STT", typeof(int)},
               {"ID", typeof(int)},
               {"Name", typeof(string)},
               {"Address", typeof(string)}};

        enum Tab
        {
            Recently = 0,
            DataBase
        };
        #endregion
        #region các hàm trên form
        void getLocationCurValueInForm()
        {
            locationCur.Address = textAddress.Text;
            locationCur.Name = textName.Text;
            locationCur.Site_ID = siteCur.ID;
        }
        void loadListLocation()
        {
            gridControlDataBase.DataSource = locationCur.GetListInforBySite(siteCur.ID);
        }
        void LoadLocationCur()
        {
            textName.Text = locationCur.Name;
            textAddress.Text = locationCur.Address;
        }
        void loadRowCur()
        {
            DataRow dt = IGrid.getRowCur(gridViewDatabase);
            if (dt == null)
                return;
            locationCur =(Location) locationCur.GetInfor(common.parseInt(dt["ID"]));
            loadValueInForm();
            ControlLocationRecords.Enabled = false;
        }
        void loadValueInForm()
        {
            LoadLocationCur();
        }
        void newLocationCurInForm()
        {
            locationCur = new Location();
            textAddress.Text = "";
            textName.Text = "";
            ControlLocationRecords.Enabled = true;
        }

        #endregion
        private void LocationManagement_Load(object sender, EventArgs e)
        {
            gridControlNew.DataSource = IGrid.CreateTable(Table);
            loadListLocation();
            textSite.Text = siteCur.Name;
            newLocationCurInForm();
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            newLocationCurInForm();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            loadRowCur();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want delete it?", "Warn!", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                DataRow dt = IGrid.getRowCur(gridViewDatabase);
                Location location =(Location) locationCur.GetInfor(common.parseInt(dt["ID"]));
                location.Delete(location);
                loadListLocation();
                ControlLocationRecords.Enabled = true;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            getLocationCurValueInForm();
            if (locationCur.ID == 0)
                locationCur.ID = locationCur.Insert(locationCur);
            else
            {
                locationCur.Update(locationCur);
            }
            if (locationCur.ID > 0)
            {
                loadListLocation();
                IGrid.addRecently(gridControlNew, 0, locationCur.ID, locationCur.Name, locationCur.Address);
                newLocationCurInForm();
            }
        }
        private void gridViewNew_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            loadRowCur();
        }
        private void gridViewDatabase_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            loadRowCur();
        }

        private void buttonDetail_Click(object sender, EventArgs e)
        {
            loadRowCur();
            LocationDetail l = new LocationDetail();
            l.locationCur = locationCur;
            l.ShowDialog();
        }
    }
}