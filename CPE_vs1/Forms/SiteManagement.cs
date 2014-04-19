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
    public partial class SiteManagement : DevExpress.XtraEditors.XtraForm
    {
        public SiteManagement()
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
        Site siteCur = new Site();
        IGridAlgorithm IGrid;
        Dictionary<string, Type> Table = new Dictionary<string, Type>() {
               {"STT", typeof(int)},
               {"ID", typeof(int)},
               {"Name", typeof(string)},
               {"Amount", typeof(string)}};

        enum Tab
        {
            Recently = 0,
            DataBase
        };
        #endregion
        #region các hàm trên form
        void getSiteCurValueInForm()
        {
            siteCur.Name = textName.Text;
            siteCur.Amount = common.parseInt(textAmount.Text);
        }
        void newSiteCurInForm()
        {
            siteCur = new Site();
            textAmount.Text = "";
            textName.Text = "";
            ControlSiteRecords.Enabled = true;
        }
        void loadListSite()
        {
            gridControlDatabase.DataSource = siteCur.GetListInfor();
        }
        void LoadSiteCur()
        {
            if (siteCur == null)
                return;
            textName.Text = siteCur.Name;
            textAmount.Text = common.toString(siteCur.Amount);
        }
        void loadRowCur()
        {
            DataRow dt = IGrid.getRowCur(ControlSiteRecords, gridViewNew, gridViewDatabase);
            if (dt == null)
                return;
            siteCur =(Site) siteCur.GetInfor(common.parseInt(dt["ID"]));
            LoadSiteCur();
            ControlSiteRecords.Enabled = false;
        }
        #endregion
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            newSiteCurInForm();
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
                DataRow dt = IGrid.getRowCur(ControlSiteRecords, gridViewNew, gridViewDatabase);
                if (dt == null)
                    return;
                Site site =(Site) siteCur.GetInfor(common.parseInt(dt["ID"]));
                site.Delete(site);
                loadListSite();
                ControlSiteRecords.Enabled = true;
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
        private void SiteManagement_Load(object sender, EventArgs e)
        {
            gridControlNew.DataSource = IGrid.CreateTable(Table);
            loadListSite();
            newSiteCurInForm();
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            getSiteCurValueInForm();
            if (siteCur.ID == 0)
                siteCur.ID = siteCur.Insert(siteCur);
            else
            {
                siteCur.Update(siteCur);
            }
            if (siteCur.ID > 0)
            {
                loadListSite();
                IGrid.addRecently(gridControlNew, 0, siteCur.ID, siteCur.Name, siteCur.Amount);
                newSiteCurInForm();
            }
        }
        private void buttonLocation_Click(object sender, EventArgs e)
        {
            loadRowCur();
            LocationManagement l = new LocationManagement();
            l.siteCur = siteCur;
            l.ShowDialog();
        }

        private void textName_MouseDown(object sender, MouseEventArgs e)
        {
            common.openOnScreenKeyboard();
        }

        private void SiteManagement_Click(object sender, EventArgs e)
        {
            common.killOnScreenKeyboard();
            UserSession.ResetTimer();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            common.killOnScreenKeyboard();
            UserSession.ResetTimer();
        }
    }
}