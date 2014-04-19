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
    public partial class LocationDetail : DevExpress.XtraEditors.XtraForm
    {
        public LocationDetail()
        {
            InitializeComponent();
            SetComboboxAlgorithm(new LookUpAlgorithm());
            SetGridAlgorithm(new DevGridAlgorithm());
        }
        #region Set các interface
        void AddRecently()
        {
            object[] arr = { 0, cLCur.ID, cpeCur.ID, cLCur.Amount };
            IGrid.addRecently(arr);
        }
        void loadListData()
        {
            IGrid.loadListData(cLCur.GetListInfor());
        }
        void SetComboboxAlgorithm(IComboboxAlgorithm ICombo)
        {
            this.ICombo = ICombo;
        }
        void SetGridAlgorithm(IGridAlgorithm IGrid)
        {
            this.IGrid = IGrid;
            IGrid.setItems(ControlRecords, gridViewNew, gridViewDatabase, Table, cpeCur, gridControlRecently, gridControlDatabase);
        }

        #endregion
        #region Khai báo biến
        CPE cpeCur = new CPE();
        CPELocation cLCur = new CPELocation();
        public Location locationCur = new Location();
        IGridAlgorithm IGrid;
        IComboboxAlgorithm ICombo;
        Dictionary<string, Type> Table = new Dictionary<string, Type>() {
               {"STT", typeof(int)},
               {"ID", typeof(string)},
               {"CPE_ID", typeof(string)},
               {"Name", typeof(string)},
               {"Price", typeof(string)},
               {"Amount", typeof(string)}};
        #endregion
        #region các hàm trên form
        void Delete()
        {
            DialogResult dialogResult = MessageBox.Show("Do you want delete it?", "Warn!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DataRow dt = IGrid.getRowCur(ControlRecords, gridViewNew, gridViewDatabase);
                if (dt == null)
                    return;
                CPELocation cL = (CPELocation)cLCur.GetInfor(common.parseInt(dt["ID"]));
                cL.Delete(cL);
                loadListData();
                ControlRecords.Enabled = true;
            }
        }
        void formLoad()
        {
            this.Text = "Location Detail: " + locationCur.Name;
            gridControlRecently.DataSource = IGrid.CreateTable(Table);
            loadListData();
            newLayerInForm();
        }
        void getDataValueInForm()
        {
            cLCur.Amount = common.parseInt(textAmount.Text);
            cLCur.CPE_ID = cpeCur.ID;
            cLCur.Location_ID = locationCur.ID;
        }
        void getLayerCur(string CPE)
        {
            if (CPE.Length != EnumConfig.LenghtBarcode)
                return;
            if (cpeCur.Barcode == CPE )
                return;
            CPE cpe = cpeCur.GetInfor(CPE,SessionCur.staff.Site_ID);
            if (cpe != null && cpe != cpeCur)
                cpeCur = cpe;
            LoadLayerCur();
        }
        void LoadLayerCur()
        {
            if (cpeCur == null)
                return;
            textBarcode.Text = cpeCur.Barcode;
            textAmount.Text = common.toString(cLCur.Amount);
        }
        void newLayerInForm()
        {
            cpeCur = new CPE();
            cLCur = new CPELocation();
            textAmount.Text = "";
            textBarcode.Text = "";
            textSIMIMSI.Text = "";
            textSerialNumber.Text = "";
            textName.Text = "";
            textPrice.Text = "";
            textDescription.Text = "";
            ControlRecords.Enabled = true;
        }
        void Save()
        {
            getDataValueInForm();
            if (cLCur.ID == 0)
                cLCur.ID = cLCur.Insert(cLCur);
            else
            {
                cLCur.Update(cLCur);
            }
            if (cLCur.ID > 0)
            {
                loadListData();
                AddRecently();
                newLayerInForm();
            }
        }
        void SelectedRow()
        {
            ControlRecords.Enabled = false;
            DataRow dt = null;
            if (gridViewNew == null)
                dt = gridViewDatabase.GetDataRow(gridViewDatabase.GetSelectedRows()[0]);
            else
                if (ControlRecords.SelectedIndex == (int)EnumConfig.Tab.Recently)
                {
                    if (gridViewNew.GetSelectedRows().Length != 0)
                        dt = gridViewNew.GetDataRow(gridViewNew.GetSelectedRows()[0]);
                }
                else
                {
                    if (gridViewDatabase.GetSelectedRows().Length != 0)
                        dt = gridViewDatabase.GetDataRow(gridViewDatabase.GetSelectedRows()[0]);
                }
            cpeCur = (CPE)cpeCur.GetInfor(common.parseInt(dt["CPE_ID"]));
            cLCur = (CPELocation)cLCur.GetInfor(common.parseInt(dt["ID"]));
            LoadLayerCur();
        }
        #endregion
        private void textBarcode_EditValueChanged(object sender, EventArgs e)
        {
            getLayerCur(textBarcode.Text);
        }

        private void textSerialNumber_EditValueChanged(object sender, EventArgs e)
        {
            getLayerCur(textBarcode.Text);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            newLayerInForm();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            SelectedRow();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void gridViewNew_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            SelectedRow();
        }

        private void gridViewDatabase_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            SelectedRow();
        }

        private void LocationDetail_Load(object sender, EventArgs e)
        {
            formLoad();
        }
    }
}